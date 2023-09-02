'************************************************** Bismillah **********************************************************
Imports System.Data.SqlClient
Public Class BillUpdater

    Private TotAmt As Double = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub LoadLedgers()

        SQL = "SELECT LEDGERID,LEDGERNAME FROM LEDGER WHERE GROUPID=5 ORDER BY LEDGERNAME"
        ESSA.LoadCombo(cmbLedger, SQL, "LEDGERNAME", "LEDGERID")

    End Sub

    Private Sub LoadVendors()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub BillUpdater_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnUpdate.PerformClick()
            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub BillUpdater_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ESSA.AlignHeader(TGTax, 3, DataGridViewContentAlignment.MiddleRight)
        cmbMode.SelectedIndex = 0
        LoadLedgers()
        LoadVendors()

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub
        SQL = "select grnno from grnmaster where vendorid=" & IIf(cmbVendor.SelectedValue.ToString.Contains("DataRow"), "0", cmbVendor.SelectedValue.ToString) & " order by grnno"
        ESSA.LoadCombo(cmbGRNNo, SQL, "grnno")

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Dim Tot As Double = 0

        SQL = "SELECT T.LEDGERID,L.LEDGERNAME,T.AMOUNT,T.PERC FROM GRNTAX T,LEDGER L WHERE " _
            & "T.LEDGERID=L.LEDGERID AND T.GRNNO=" & cmbGRNNo.Text.Trim & " ORDER BY T.SNO;" _
            & "SELECT TOTALAMOUNT,BILLNO FROM GRNMASTER WHERE GRNNO=" & cmbGRNNo.Text.Trim

        TGTax.Rows.Clear()
        With ESSA.OpenReader(SQL)

            While .Read
                TGTax.Rows.Add()
                TGTax.Item(0, TGTax.Rows.Count - 1).Value = .Item(0)
                TGTax.Item(1, TGTax.Rows.Count - 1).Value = .GetString(1).Trim
                TGTax.Item(2, TGTax.Rows.Count - 1).Value = IIf(.Item(2) < 0, "Less", "Add")
                TGTax.Item(3, TGTax.Rows.Count - 1).Value = Format(IIf(.Item(2) < 0, -.Item(2), .Item(2)), "0.00")
                TGTax.Item(4, TGTax.Rows.Count - 1).Value = .Item(2)
                TGTax.Item(5, TGTax.Rows.Count - 1).Value = .Item(3)
                Tot += .Item(2)
            End While

            .NextResult()

            If .Read Then
                If .Item(1) > 0 Then
                    btnUpdate.Enabled = False
                Else
                    btnUpdate.Enabled = True
                End If
                Tot += .Item(0)
                TotAmt = .Item(0)
            End If

            .Close()

        End With

        lblSubTot.Text = Format(Tot, "0.00")
        TaxTotal()

    End Sub

    Private Sub TaxTotal()

        Dim TAmt As Double = 0

        For i As SByte = 0 To TGTax.Rows.Count - 1
            TAmt += Val(TGTax.Item(4, i).Value)
        Next

        lblNett.Text = Format(TotAmt + TAmt, "0.00")

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Val(txtAmount.Text) <= 0 Then
                Exit Sub
            End If

            Dim NRI = ESSA.FindGridIndex(TGTax, 0, cmbLedger.SelectedValue)
            If NRI = -1 Then NRI = TGTax.Rows.Add

            TGTax.Item(0, NRI).Value = cmbLedger.SelectedValue
            TGTax.Item(1, NRI).Value = cmbLedger.Text
            TGTax.Item(2, NRI).Value = cmbMode.Text
            TGTax.Item(3, NRI).Value = Format(Val(txtAmount.Text), "0.00")
            TGTax.Item(4, NRI).Value = Format(IIf(cmbMode.SelectedIndex = 0, Val(txtAmount.Text), -Val(txtAmount.Text)), "0.00")
            TGTax.Item(5, NRI).Value = Val(txtPerc.Text)
            TaxTotal()

            txtAmount.Clear()
            cmbLedger.Focus()

        End If

    End Sub

    Private Sub TGTax_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TGTax.RowsRemoved

        TaxTotal()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If TGTax.Rows.Count = 0 Then
            MsgBox("No details to save..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Are you sure, do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "UPDATE GRNMASTER SET NETTAMOUNT=" & Val(lblNett.Text) & " WHERE GRNNO=" & Val(cmbGRNNo.Text) _
                & ";DELETE FROM GRNTAX WHERE GRNNO=" & cmbGRNNo.Text

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For j As SByte = 0 To TGTax.Rows.Count - 1

                SQL = "insert into grntax values (" _
                    & Val(cmbGRNNo.Text) & "," _
                    & Val(TGTax.Item(0, j).Value) & "," _
                    & Val(TGTax.Item(4, j).Value) & "," _
                    & Val(TGTax.Item(5, j).Value) & "," _
                    & j + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            xMessageBox.ShowMessage(ex.Message, "Error..!", xMessageBox.MessageBoxStyle.OkandCancel)
            Exit Sub
        End Try

        xMessageBox.ShowMessage("Bill updated successfully..!", "Congratulations..!", xMessageBox.MessageBoxStyle.OkandCancel)
        lblNett.Text = "0.00"
        lblSubTot.Text = "0.00"
        TGTax.Rows.Clear()
        cmbVendor.Focus()

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class