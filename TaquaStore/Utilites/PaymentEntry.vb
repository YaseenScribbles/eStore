'**************************** in the name of Allah, most merciful, most compassionate ******************************
Imports System.Data.SqlClient
Public Class PaymentEntryNew

    Private EntryNo As Short
    Private EntryDt As Date
    Private Edit As Boolean = False

    Private Sub PaymentEntryNew_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnUpdate.PerformClick()
            Case Keys.F3
                btnAlter.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub PaymentEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbPType.SelectedIndex = 0
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from paymentmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub GenerateEntryID()

        SQL = "select max(eno) from pemaster"
        EntryNo = ESSA.GenerateID(SQL)

        EntryDt = Now

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub

        SQL = "select netamt,billno from paymentmaster where vendorid=" & IIf(cmbVendor.SelectedValue.ToString.Contains("Row"), "0", cmbVendor.SelectedValue) & " order by billno"
        ESSA.LoadCombo(cmbBillNo, SQL, "billno", "netamt")

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        lblBillAmt.Text = Format(cmbBillNo.SelectedValue, "0.00")
        TG.Rows.Clear()

        SQL = "SELECT PTYPE,REFNO,REFDT,D.AMOUNT,REMARKS FROM PEDETAILS D,PEMASTER M WHERE M.ENO=D.ENO AND M.BILLNO=" & cmbBillNo.Text & " ORDER BY SNO"
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0).Trim
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = Format(.GetDateTime(2).Date, "dd-MM-yyyy")
                TG.Item(3, TG.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(4).Trim
            End While
            .Close()
        End With

        GetTotal()
        cmbPType.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub mebRefDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mebRefDt.Leave

        If IsDate(mebRefDt.Text) = False Then
            mebRefDt.Text = Format(Now.Date, "dd-MM-yyyy")
        End If

    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            If IsDate(mebRefDt.Text) = False Then
                MsgBox("Reference date should be valid format..!", MsgBoxStyle.Information)
                mebRefDt.Focus()
                Exit Sub
            ElseIf Val(txtAmount.Text) <= 0 Then
                MsgBox("Amount should not be zero..!", MsgBoxStyle.Information)
                txtAmount.Focus()
                Exit Sub
            End If

            TG.Rows.Add()
            TG.Item(0, TG.Rows.Count - 1).Value = cmbPType.Text
            TG.Item(1, TG.Rows.Count - 1).Value = txtRefNo.Text
            TG.Item(2, TG.Rows.Count - 1).Value = Format(CDate(mebRefDt.Text).Date, "dd-MM-yyyy")
            TG.Item(3, TG.Rows.Count - 1).Value = Format(Val(txtAmount.Text), "0.00")
            TG.Item(4, TG.Rows.Count - 1).Value = txtRemarks.Text.Trim
            GetTotal()

            txtRemarks.Clear()
            txtAmount.Clear()
            txtRefNo.Clear()
            mebRefDt.Clear()
            cmbPType.Focus()

        End If

    End Sub

    Private Sub GetTotal()

        lblGTot.Text = Format(ESSA.GetColTotal(TG, 3), "0.00")

    End Sub

    Private Sub RefreshForm()

        Edit = False
        TG.Rows.Clear()
        GetTotal()
        lblBillAmt.Text = "0.00"
        txtRemarks.Clear()
        txtAmount.Clear()
        mebRefDt.Clear()
        txtRefNo.Clear()
        cmbVendor.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForm()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If cmbVendor.SelectedIndex = 0 Then
            MsgBox("Vendor not selected..!", MsgBoxStyle.Information)
            cmbVendor.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            MsgBox("No details to save..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Are you sure, do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then

            Else
                GenerateEntryID()
            End If

            SQL = "insert into pemaster values (" _
                & EntryNo & ",'" _
                & Format(EntryDt, "yyyy-MM-dd HH:mm:ss") & "'," _
                & cmbBillNo.Text & "," _
                & cmbVendor.SelectedValue & "," _
                & lblGTot.Text & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into pedetails values (" _
                    & EntryNo & ",'" _
                    & TG.Item(0, i).Value & "','" _
                    & TG.Item(1, i).Value & "','" _
                    & Format(CDate(TG.Item(2, i).Value).Date, "yyyy-MM-dd") & "'," _
                    & Val(TG.Item(3, i).Value) & ",'" _
                    & TG.Item(4, i).Value & "'," _
                    & i + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As Exception

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        MsgBox("Entry saved successfully..!", MsgBoxStyle.Information)
        RefreshForm()

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
            GetTotal()
        End If

    End Sub

    Private Sub btnAlter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlter.Click

    End Sub
End Class