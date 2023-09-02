'******************************* in the name of Allah, most merciful, most compassionate **********************
Imports System.Data.SqlClient
Public Class BillGenerator

    Private Rpt As New PaymentBillSummary

    Private Sub BillGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateBillNo()
        lblBillDt.Text = Format(Now, "dd-MM-yyyy")
        LoadVendors()

        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 9, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub GenerateBillNo()

        SQL = "select max(billno) from paymentmaster"
        lblBillNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub LoadVendors()

        SQL = "select vendorid,vendorname from vendors where vendorid in (select distinct vendorid from  " _
            & "grnmaster where billno=0) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        SQL = "select vendorid,vendorname from vendors where vendorid in (select distinct vendorid from  " _
            & "paymentmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor2, SQL, "vendorname", "vendorid", "All Vendor(s)")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "SELECT GRNNO,GRNDT,INVNO,INVDT,REFNO,REFDT,NETTAMOUNT FROM GRNMASTER WHERE BILLNO=0 AND " _
            & "invdt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "' AND VENDORID=" & cmbVendor.SelectedValue _
            & " ORDER BY GRNNO;" _
            & "select sum(amount) from rvchmaster where vchdt<='" _
            & Format(Now.Date, "yyyy-MM-dd") & "' and vendorid=" & cmbVendor.SelectedValue _
            & " and billno=0 and LocalReturn=0"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = Format(.GetDateTime(3).Date, "dd-MM-yyyy")
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(4).Trim
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.GetDateTime(5).Date, "dd-MM-yyyy")
                TG.Item(6, TG.Rows.Count - 1).Value = cmbVendor.Text.Trim
                TG.Item(7, TG.Rows.Count - 1).Value = Format(.Item(6), "0.00")
                TG.Item(8, TG.Rows.Count - 1).Value = "0.00"
                TG.Item(9, TG.Rows.Count - 1).Value = Format(.Item(6), "0.00")

            End While

            .NextResult()

            If .Read Then
                If IsDBNull(.Item(0)) = False Then
                    lblDebit.Text = Format(.Item(0), "0.00")
                End If
            End If

            .Close()
        End With

        GetTotal()

    End Sub

    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        'If e.ColumnIndex = 6 Then
        '    If Val(TG.Item(6, TG.CurrentRow.Index).Value) > Val(TG.Item(5, TG.CurrentRow.Index).Value) Then
        '        TG.Item(6, TG.CurrentRow.Index).Value = Format(Val(TG.Item(5, TG.CurrentRow.Index).Value), "0.00")
        '    End If
        '    TG.Item(7, TG.CurrentRow.Index).Value = Format(Val(TG.Item(5, TG.CurrentRow.Index).Value) - Val(TG.Item(6, TG.CurrentRow.Index).Value), "0.00")
        '    'GetTotal()
        'End If

    End Sub

    Private Sub GetTotal()

        Dim iTot As Double = 0
        Dim iDbt As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            iTot += Val(TG.Item(9, i).Value)
            'iDbt += Val(TG.Item(6, i).Value)

        Next

        lblSubTot.Text = Format(iTot, "0.00")
        iDbt = Val(lblDebit.Text)
        lblGrandTot.Text = Format(iTot - iDbt, "0.00")

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
            GetTotal()
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If TG.Rows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure, do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "insert into paymentmaster values (" _
                & Val(lblBillNo.Text) & ",'" _
                & Format(CDate(lblBillDt.Text).Date, "yyyy-MM-dd") & "','" _
                & Format(mebFrom.Value, "yyyy-MM-dd") & "','" _
                & Format(mebTo.Value, "yyyy-MM-dd") & "'," _
                & cmbVendor.SelectedValue & "," _
                & Val(lblDebit.Text) & "," _
                & Val(lblGrandTot.Text) & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "update grnmaster set billno=" & Val(lblBillNo.Text) _
                    & " where grnno=" _
                    & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            SQL = "update rvchmaster set billno=" & Val(lblBillNo.Text) & " where vchdt between '" _
                & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
                & Format(mebTo.Value, "yyyy-MM-dd") & "' and vendorid=" & cmbVendor.SelectedValue _
                & " and billno=0"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If MsgBox("Bill generated successfully, do you want to print report..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ViewBillSummary(lblBillNo.Text, cmbVendor.Text, Format(mebFrom.Value, "dd-MM-yyyy") & " To " & Format(mebTo.Value, "dd-MM-yyyy"), Format(CDate(lblBillDt.Text).Date, "dd-MM-yyyy"), Val(lblDebit.Text))
        End If
        RefreshForms()

    End Sub

    Private Sub ViewBillSummary(ByVal iBillNo As Short, ByVal iVendor As String, ByVal iDuration As String, ByVal iBillDt As String, ByVal iDebit As Double)

        SQL = "SELECT L.LEDGERNAME,T.PERC,T.AMOUNT,M.NETAMT,M.DBTDESC FROM LEDGER L,PAYMENTTAX T,PAYMENTMASTER M WHERE " _
            & "L.LEDGERID=T.LEDGERID AND T.BILLNO=" & iBillNo & " AND M.BILLNO=T.BILLNO ORDER BY T.SNO"

        Dim STbl As New DataTable
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Adp.Fill(STbl)
        End Using
        Con.Close()


        SQL = "SELECT A.GRNNO,A.GRNDT,A.INVNO,A.REFNO,ISNULL(B.PERC,0) DEBITAMT,A.NETAMT,ISNULL(B.DIS,0) DISCOUNT,A.BILLAMT FROM (" _
            & "SELECT GRNNO,GRNDT,INVNO,INVDT,REFNO,REFDT,NETTAMOUNT NETAMT,TOTALAMOUNT BILLAMT FROM" _
            & " GRNMASTER WHERE BILLNO=" & iBillNo & ") A LEFT OUTER JOIN " _
            & "(SELECT T.PERC,M.GRNNO,SUM(-T.AMOUNT) DIS FROM GRNTAX T,GRNMASTER M WHERE M.GRNNO=T.GRNNO " _
            & "AND M.BILLNO=" & iBillNo & " AND T.LEDGERID=4 GROUP BY M.GRNNO,T.PERC) B ON A.GRNNO=B.GRNNO ORDER BY A.GRNNO"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                Rpt.Subreports.Item(0).SetDataSource(STbl)
                Rpt.SetParameterValue("Vendor", iVendor)
                Rpt.SetParameterValue("BillNo", iBillNo)
                Rpt.SetParameterValue("BillDt", iBillDt)
                Rpt.SetParameterValue("Duration", iDuration)
                Rpt.SetParameterValue("Debit", iDebit)
                ReportViewer.CViewer.ReportSource = Rpt
                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub RefreshForms()

        lblDebit.Text = "0.00"
        GenerateBillNo()
        GetTotal()
        TG.Rows.Clear()
        mebFrom.Focus()

    End Sub

    Private Sub btnAlter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlter.Click

        pnlAlter.Visible = True

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlAlter.Visible = False

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        SQL = "select billno,billdt,vendorname,netamt,frdt,todt,debitamt from vendors v,paymentmaster p where v.vendorid=p.vendorid"

        If cmbVendor2.SelectedIndex > 0 Then
            SQL &= " and p.vendorid=" & cmbVendor2.SelectedValue
        End If

        SQL &= " order by billno"

        With ESSA.OpenReader(SQL)

            TGEdt.Rows.Clear()
            While .Read
                TGEdt.Rows.Add()
                TGEdt.Item(0, TGEdt.Rows.Count - 1).Value = .Item(0)
                TGEdt.Item(1, TGEdt.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TGEdt.Item(2, TGEdt.Rows.Count - 1).Value = .GetString(2).Trim
                TGEdt.Item(3, TGEdt.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                TGEdt.Item(7, TGEdt.Rows.Count - 1).Value = Format(.GetDateTime(4).Date, "dd-MM-yyyy")
                TGEdt.Item(8, TGEdt.Rows.Count - 1).Value = Format(.GetDateTime(5).Date, "dd-MM-yyyy")
                TGEdt.Item(9, TGEdt.Rows.Count - 1).Value = Format(.Item(6), "0.00")
            End While

            .Close()

        End With

    End Sub

    Private Sub TGEdt_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGEdt.CellClick

        If e.ColumnIndex = 4 Then
            ViewBillSummary(Val(TGEdt.Item(0, e.RowIndex).Value), TGEdt.Item(2, e.RowIndex).Value, TGEdt.Item(7, e.RowIndex).Value & " to " & TGEdt.Item(8, e.RowIndex).Value, TGEdt.Item(1, e.RowIndex).Value, TGEdt.Item(9, e.RowIndex).Value)
        ElseIf e.ColumnIndex = 5 Then

            If IsAdmin = False Then
                MsgBox("Access denied..!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If MsgBox("Are you sure, do you want to delete this bill..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = "delete from paymentmaster where billno=" & Val(TGEdt.Item(0, e.RowIndex).Value) & ";" _
                & "update grnmaster set billno=0 where billno=" & Val(TGEdt.Item(0, e.RowIndex).Value) & ";" _
                & "update rvchmaster set billno=0 where billno=" & Val(TGEdt.Item(0, e.RowIndex).Value) & ";"

            ESSA.Execute(SQL)
            xMessageBox.ShowMessage("Entru deleted successfully..!", "Taqua Store", vbOK)
            TGEdt.Rows.RemoveAt(e.RowIndex)

        End If

    End Sub

    Private Sub mebTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mebTo.ValueChanged

        SQL = "select vendorid,vendorname from vendors where vendorid in (select distinct vendorid from  " _
            & "grnmaster where billno=0 and grndt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "') order by vendorname"

        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub TGEdt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGEdt.CellContentClick

    End Sub
End Class

