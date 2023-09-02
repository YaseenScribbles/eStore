Imports System.Data.SqlClient

Public Class frmAdvancePayment

    Private Edit As Boolean = False
    Private EntryNo As Integer = 0
    Private CreatedDate As Date = DateTime.Now
    Private BillNo As Integer = 0
    Dim rpt As New RptAdvancePayment
    Private DebitAmount As Double = 0
    Private DebitDesc As String = ""

    Private Sub AdvancePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT VendorId, VendorName FROM Vendors ORDER BY VendorName"
        ESSA.LoadCombo(cmbVendor, SQL, "VendorName", "VendorId")

        TG.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


        TG.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TG.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        cmbAccount.SelectedIndex = 0
        cmbPayment.SelectedIndex = 0
        cmbVendor.SelectedIndex = 0

        cmbVendor.Select()

    End Sub

    Private Sub AdvancePayment_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlBankList, Me)
        ESSA.MovetoCenter(pnlAdvList, Me)

    End Sub

    Private Sub btnHide3_Click(sender As Object, e As EventArgs) Handles btnHide3.Click

        pnlBankList.Visible = False

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        LoadBankList(cmbVendor.SelectedValue)

        pnlBankList.Visible = True
        pnlBankList.BringToFront()

    End Sub

    Private Sub LoadBankList(iVendorId As Integer)

        SQL = "select r.sno,b.bankname,r.acno,r.acname,r.ifsc,r.actype,r.bankid from bankregister r,banklist b " _
            & "where r.bankid=b.bankid and r.vendorid={0} order by r.sno"

        With ESSA.OpenReader(String.Format(SQL, iVendorId))
            TGBank.Rows.Clear()
            While .Read
                TGBank.Rows.Add()
                TGBank.Item(0, TGBank.Rows.Count - 1).Value = .Item(0)
                TGBank.Item(1, TGBank.Rows.Count - 1).Value = TGBank.Rows.Count
                TGBank.Item(2, TGBank.Rows.Count - 1).Value = .GetString(1).Trim
                TGBank.Item(3, TGBank.Rows.Count - 1).Value = .GetString(2).Trim
                TGBank.Item(4, TGBank.Rows.Count - 1).Value = .GetString(3).Trim
                TGBank.Item(5, TGBank.Rows.Count - 1).Value = .GetString(4).Trim
                TGBank.Item(6, TGBank.Rows.Count - 1).Value = .Item(5)
                TGBank.Item(7, TGBank.Rows.Count - 1).Value = .Item(6)
            End While
            .Close()
        End With

    End Sub

    Private Sub TGBank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGBank.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 8 Then

            txtAccNo.Text = TGBank.Item(3, e.RowIndex).Value
            txtAccName.Text = TGBank.Item(4, e.RowIndex).Value
            txtIFSC.Text = TGBank.Item(5, e.RowIndex).Value
            txtBank.Text = TGBank.Item(2, e.RowIndex).Value

            pnlBankList.Hide()
            cmbAccount.Focus()

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub CalculateTotal()

        Dim billCount As Short = 0
        Dim Amount As Double = 0
        Dim Qty As Double = 0

        If TG.Rows.Count = 0 Then

            lblBillCount.Text = "0"
            lblQty.Text = "0"
            lblAmount.Text = "0"
            lblDebit.Text = "0"

        Else

            For i As Short = 0 To TG.Rows.Count - 1

                billCount = TG.Rows.Count
                Qty += Val(TG.Item(3, i).Value)
                Amount += Val(TG.Item(4, i).Value)

            Next

        End If

        lblBillCount.Text = billCount.ToString()
        lblAmount.Text = Math.Round(Amount - Val(lblDebit.Text))
        'lblAmount.Text = RoundOff(Amount - Val(lblDebit.Text))
        lblQty.Text = Qty.ToString()

    End Sub

    'Private Sub TG_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TG.RowsAdded

    '    CalculateTotal()

    'End Sub

    Private Sub TG_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub RefreshForm()

        ESSA.ClearTextBox(Me)
        SetComboIndex(Me)
        SetDate(Me)
        EntryNo = 0
        DebitAmount = 0
        DebitDesc = ""
        CreatedDate = DateTime.Now
        Edit = False
        TG.Rows.Clear()
        CalculateTotal()

    End Sub

    Private Sub SetComboIndex(ByVal BaseControl As Control)

        For Each ctrl As Control In BaseControl.Controls
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = 0
            End If
        Next

    End Sub

    Private Sub SetDate(ByVal BaseControl As Control)

        For Each ctrl As Control In BaseControl.Controls
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).ResetText()
            End If
        Next

    End Sub

    Private Sub GenerateEntryNo()

        SQL = "SELECT MAX(EntryNo) FROM AdvPaymentMaster"
        EntryNo = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ValidateCombo(cmbVendor) = -1 Then
            MsgBox("Please select correct vendor..!", MsgBoxStyle.Critical)
            cmbVendor.Focus()
            Exit Sub
        ElseIf txtBank.Text = "" Then
            MsgBox("Please select the vendor bank detail..!", MsgBoxStyle.Critical)
            txtBank.Focus()
            Exit Sub
        ElseIf txtAccName.Text = "" Then
            MsgBox("Please select the vendor bank detail..!", MsgBoxStyle.Critical)
            txtAccName.Focus()
            Exit Sub
        ElseIf txtAccNo.Text = "" Then
            MsgBox("Please select the vendor bank detail..!", MsgBoxStyle.Critical)
            txtAccNo.Focus()
            Exit Sub
        ElseIf txtIFSC.Text = "" Then
            MsgBox("Please select the vendor bank detail..!", MsgBoxStyle.Critical)
            txtIFSC.Focus()
            Exit Sub
        ElseIf txtChequeNo.Text = "" Then
            MsgBox("Please fill the cheque details..!", MsgBoxStyle.Critical)
            txtChequeNo.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            MsgBox("No bill details found..!", MsgBoxStyle.Critical)
            cmbVendor.Focus()
            Exit Sub
        End If

        If MsgBox("Confirm Save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim cmd = Con.CreateCommand()
        Dim trn = Con.BeginTransaction()
        cmd.Transaction = trn

        If Edit Then

            SQL = "DELETE FROM AdvPaymentMaster WHERE EntryNo =" & EntryNo
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            SQL = "DELETE FROM AdvPaymentDetails WHERE EntryNo =" & EntryNo
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

        Else

            GenerateEntryNo()

        End If

        Try

            SQL = "INSERT INTO AdvPaymentMaster VALUES (" _
                & EntryNo & ",'" _
                & Format(CreatedDate, "yyyy-MM-dd hh:mm:ss") & "'," _
                & cmbVendor.SelectedValue & ",'" _
                & txtBank.Text.Trim & "','" _
                & txtAccName.Text.Trim & "','" _
                & txtAccNo.Text.Trim & "','" _
                & txtIFSC.Text.Trim & "'," _
                & cmbAccount.SelectedIndex & "," _
                & cmbPayment.SelectedIndex & ",'" _
                & txtChequeNo.Text.Trim & "','" _
                & Format(dtpChequeDate.Value, "yyyy-MM-dd") & "','" _
                & txtRemarks.Text.Trim & "'," _
                & IIf(Val(lblDebit.Text) <> 0, Val(lblDebit.Text), 0) & ", '" _
                & IIf(DebitDesc.Trim <> "", DebitDesc.Trim, "") & "', " _
                & Val(lblQty.Text) & "," _
                & Val(lblBillCount.Text) & "," _
                & Val(lblAmount.Text) & ",0,0," _
                & UserID & ",'" _
                & Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss") & "')"

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "INSERT INTO AdvPaymentDetails VALUES(" _
                    & EntryNo & "," _
                    & TG.Item(0, i).Value & ",'" _
                    & TG.Item(1, i).Value & "','" _
                    & Format(CDate(TG.Item(2, i).Value), "yyyy-MM-dd") & "'," _
                    & TG.Item(3, i).Value & "," _
                    & Val(TG.Item(4, i).Value) & ")"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

            Next

            MsgBox("Saved Successfully", MsgBoxStyle.Information)
            trn.Commit()
            Con.Close()
            RefreshForm()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trn.Rollback()
            Con.Close()

        End Try

    End Sub

    Private Function ValidateCombo(cmb As ComboBox) As Short

        Dim Index = cmb.FindStringExact(cmb.Text.Trim)
        If Index <> -1 Then
            cmb.SelectedIndex = Index
        End If
        Return Index

    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        pnlAdvList.BringToFront()
        pnlAdvList.Show()

        SQL = "SELECT AM.VendorId, V.VendorName FROM AdvPaymentMaster AM, Vendors V " _
            & "WHERE AM.VendorId = V.VendorId"

        ESSA.LoadCombo(cmbVdr, SQL, "VendorName", "VendorId", "All Vendor(s)")
        cmbVdr.Select()

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        SQL = "SELECT AM.EntryNo,AM.EntryDate,V.VendorName,AM.TotalQty,AM.TotalAmount,AM.BillNo " _
         & "FROM AdvPaymentMaster AM, Vendors V " _
         & "WHERE AM.VendorId = V.VendorId"

        If cmbVdr.SelectedIndex > 0 Then
            SQL &= "AND AM.VendorId =" & cmbVdr.SelectedValue
        End If

        SQL &= " ORDER BY AM.EntryNo"

        With ESSA.OpenReader(SQL)
            TGAdvList.Rows.Clear()
            While .Read
                Dim Row = TGAdvList.Rows.Add()
                TGAdvList.Item(0, Row).Value = .Item(0)
                TGAdvList.Item(1, Row).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                TGAdvList.Item(2, Row).Value = .GetString(2).Trim
                TGAdvList.Item(3, Row).Value = Val(.Item(3))
                TGAdvList.Item(4, Row).Value = Val(.Item(4))
                TGAdvList.Item(7, Row).Value = Val(.Item(5))
            End While
            .Close()
        End With

    End Sub

    Private Sub btnHideGRN_Click(sender As Object, e As EventArgs) Handles btnHideGRN.Click

        pnlAdvList.Hide()

    End Sub

    Private Sub TGAdvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGAdvList.CellClick

        If e.RowIndex = -1 Then

            Exit Sub

        ElseIf e.ColumnIndex = 5 Then

            If IsAdmin Then
                If TGAdvList.Item(7, e.RowIndex).Value = 0 Then
                    Edit = True
                    btnSave.Enabled = True
                Else
                    btnSave.Enabled = False
                End If
            Else
                btnSave.Enabled = False
            End If

            ViewDetails(Val(TGAdvList.Item(0, e.RowIndex).Value))
            CalculateTotal()
            pnlAdvList.Hide()

        ElseIf e.ColumnIndex = 6 Then

            If IsAdmin Then

                If TGAdvList.Item(7, e.RowIndex).Value <> 0 Then
                    MsgBox("Entry Locked..!", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If MsgBox("Confirm Delete ..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                SQL = "DELETE FROM AdvPaymentMaster WHERE EntryNo = " & Val(TGAdvList.Item(0, e.RowIndex).Value)
                ESSA.Execute(SQL)

                SQL = "DELETE FROM AdvPaymentDetails WHERE EntryNo = " & Val(TGAdvList.Item(0, e.RowIndex).Value)
                ESSA.Execute(SQL)

                MsgBox("Deleted Succesfully..!", MsgBoxStyle.Information)

                TGAdvList.Rows.RemoveAt(e.RowIndex)

            Else

                MsgBox("Access denied..!", MsgBoxStyle.Critical)
                Exit Sub

            End If

        ElseIf e.ColumnIndex = 8 Then

            PrintReport(Val(TGAdvList.Item(0, e.RowIndex).Value))

        End If

    End Sub

    Private Sub ViewDetails(iEntryNo As Integer)

        SQL = "SELECT * FROM AdvPaymentMaster APM WHERE EntryNo = " & iEntryNo & ";" _
        & "SELECT * FROM AdvPaymentDetails APD WHERE EntryNo =" & iEntryNo

        With ESSA.OpenReader(SQL)

            If .Read Then

                EntryNo = .Item(0)
                CreatedDate = .GetDateTime(1)
                cmbVendor.SelectedValue = .Item(2)
                txtBank.Text = .GetString(3).Trim
                txtAccName.Text = .GetString(4).Trim
                txtAccNo.Text = .GetString(5).Trim
                txtIFSC.Text = .GetString(6).Trim
                cmbAccount.SelectedIndex = .Item(7)
                cmbPayment.SelectedIndex = .Item(8)
                txtChequeNo.Text = .GetString(9).Trim
                dtpChequeDate.Value = Format(.GetDateTime(10), "dd-MM-yyyy")
                txtRemarks.Text = .GetString(11).Trim
                lblDebit.Text = Format(.Item(12), "0.00")
                lblQty.Text = .Item(14)
                lblBillCount.Text = .Item(15)
                lblAmount.Text = .Item(16)
                BillNo = .Item(17)

            End If

            .NextResult()

            TG.Rows.Clear()
            While .Read

                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = .Item(1)
                TG.Item(1, row).Value = .GetString(2).Trim
                TG.Item(2, row).Value = Format(.GetDateTime(3), "dd-MM-yyyy")
                TG.Item(3, row).Value = .Item(4)
                TG.Item(4, row).Value = .Item(5)

            End While
            .Close()

        End With

    End Sub

    Private Sub frmAdvancePayment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.Tag <> "1" Then
                Me.ProcessTabKey(True)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If pnlAdvList.Visible Then
                pnlAdvList.Hide()
            ElseIf pnlBankList.Visible Then
                pnlBankList.Hide()
            Else
                btnClose.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            btnLoad.PerformClick()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtInvNo.Text = "" Then
            MsgBox("Please fill the invoice number..!", MsgBoxStyle.Critical)
            txtInvNo.Focus()
            Exit Sub
        ElseIf txtQty.Text = "" Then
            MsgBox("Please fill the Quantity..!", MsgBoxStyle.Critical)
            txtQty.Focus()
            Exit Sub
        ElseIf txtAmount.Text = "" Then
            MsgBox("Please fill the Amount..!", MsgBoxStyle.Critical)
            txtAmount.Focus()
            Exit Sub
        End If

        Dim row = TG.Rows.Add()
        TG.Item(0, row).Value = TG.Rows.Count
        TG.Item(1, row).Value = txtInvNo.Text.Trim
        TG.Item(2, row).Value = Format(dtpInvDate.Value, "dd-MM-yyyy")
        TG.Item(3, row).Value = Val(txtQty.Text.Trim)
        TG.Item(4, row).Value = Val(txtAmount.Text.Trim)

        txtInvNo.Clear()
        txtQty.Clear()
        txtAmount.Clear()
        CalculateTotal()
        txtInvNo.Focus()

    End Sub

    Private Sub TG_KeyDown(sender As Object, e As KeyEventArgs) Handles TG.KeyDown

        If e.KeyCode = Keys.Delete Then

            TG.Rows.RemoveAt(TG.CurrentRow.Index)
            ResetSerial()

        End If

    End Sub

    Private Sub ResetSerial()

        For i As Short = 0 To TG.Rows.Count - 1
            TG.Item(0, i).Value = i + 1
        Next

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        RefreshForm()

    End Sub

    Private Sub PrintReport(iEntryNo As Short)

        SQL = "SELECT M.EntryNo,M.EntryDate,V.VendorName,M.VenAccName AccName,M.VenBankName BankName,M.VenAccNo AccNo,M.IFSC,M.ChequeNo,M.ChequeDate,M.Remarks,M.DebitAmount,M.DebitDesc DebitVouchers,M.TotalAmount ,D.SNo,D.InvNo,D.InvDate,D.Qty,D.Amount " _
            & "FROM AdvPaymentMaster M, AdvPaymentDetails D,Vendors V " _
            & "WHERE M.EntryNo = D.EntryNo AND M.VendorId = V.VendorId AND " _
            & "M.EntryNo =" & iEntryNo & " ORDER BY D.SNo"

        ESSA.OpenConnection()
        Using Adapter As New SqlDataAdapter(SQL, Con)
            Using Table As New DataTable
                Adapter.Fill(Table)
                rpt.SetDataSource(Table)
                ReportViewer.CViewer.ReportSource = rpt
                ReportViewer.Text = "Advance Payment Report"
                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged

        If ifExist() Then

            If cmbVendor.SelectedIndex > 0 Then

                SQL = "SELECT VchNo,NetAmt FROM RvchMaster WHERE BillNo = 0 AND VendorId = " _
                    & cmbVendor.SelectedValue

                Dim DbtDesc As String = ""
                DebitAmount = 0
                DebitDesc = ""
                With ESSA.OpenReader(SQL)
                    While .Read
                        DbtDesc += .Item(0) & ","
                        DebitAmount += .Item(1)
                    End While
                    .Close()
                End With

                lblDebit.Text = Format(DebitAmount, "0.00")
                DebitDesc = Mid(DbtDesc, 1, DbtDesc.Length - 1)

            End If

        Else

            If cmbVendor.SelectedIndex > 0 Then
                lblDebit.Text = "0"
                DebitDesc = ""
            End If

        End If

    End Sub

    Private Function RoundOff(ByVal Amt As Double) As Double

        RoundOff = Amt
        Amt = Amt Mod 10

        If Amt > 0 Then
            RoundOff += IIf(Amt >= 5, 10 - Amt, -Amt)
        End If

    End Function

    Private Function ifExist() As Boolean

        ifExist = False
        SQL = "SELECT VchNo FROM RvchMaster WHERE BillNo = 0 AND VendorId = " & cmbVendor.SelectedValue

        With ESSA.OpenReader(SQL)

            If .Read Then
                ifExist = True
            End If
            .Close()
        End With

        Return ifExist

    End Function

End Class