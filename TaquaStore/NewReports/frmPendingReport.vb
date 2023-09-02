Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class frmPendingReport

    Dim bind As New BindingSource

    Private Sub frmPurchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ESSA.LoadVendors(cmbVendor, "All Vendors")
        cmbStyle.SelectedIndex = 0

    End Sub

    Private Sub LoadDebitReport()

        SQL = "SELECT V.VendorName [PARTY NAME], " _
               & "RM.vchno [DEBIT NO], " _
               & "RM.vchdt [DEBIT DATE], " _
               & "RM.quantity [QUANTITY], " _
               & "CONVERT(DECIMAL(10,2),RM.netamt) [AMOUNT], " _
               & "RM.PODNo [POD No], " _
               & "U.UserName [USER] " _
               & "From rvchmaster RM, Vendors V, Users U " _
               & "WHERE RM.vendorid = V.VendorID AND RM.userid = U.UserID AND billno = 0 AND " _
               & "RM.VchDt BETWEEN '{0}' AND '{1}'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND RM.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY [DEBIT DATE]"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetDebitTotal()

        dgvList.Columns(0).Width = 200
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 100
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 80
        dgvList.Columns(5).Width = 100
        dgvList.Columns(6).Width = 100

    End Sub

    Private Sub LoadPaymentReport()

        SQL = "SELECT V.VendorName [PARTY NAME], " _
               & "GM.GrnNo [GRN NO], " _
               & "GM.InvNo [INV. NO], " _
               & "GM.InvDt [INV. DT], " _
               & "CONVERT(DECIMAL(10,2),GM.TotalAmount) [GRN Amount], " _
               & "DATEDIFF(DAY,GM.InvDt,CURRENT_TIMESTAMP) [PENDING DAYS] " _
               & "FROM GRNMaster GM, Vendors V " _
               & "WHERE GM.VendorID = V.VendorID AND GM.BillNo = 0 AND " _
               & "GM.InvDt BETWEEN '{0}' AND '{1}'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= "AND GM.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= "ORDER BY [INV. DT]"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetPaymentTotal()

        dgvList.Columns(0).Width = 200
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 80
        dgvList.Columns(3).Width = 100
        dgvList.Columns(4).Width = 100
        dgvList.Columns(5).Width = 80

    End Sub

    Private Sub GetDebitTotal()

        GetSummary(3, 4)

    End Sub

    Private Sub GetPaymentTotal()

        lblBills.Text = GetCount()
        Dim amount As Double = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1
            amount += Val(dgvList.Item(4, i).Value)
        Next
        lblAmount.Text = Format(amount, "0.00")

    End Sub

    Private Sub GetSummary(qIndex As Byte, aIndex As Byte)

        Dim amount As Double = 0
        Dim quantity As Double = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1
            quantity += Val(dgvList.Item(qIndex, i).Value)
            amount += Val(dgvList.Item(aIndex, i).Value)
        Next

        lblQty.Text = quantity
        lblAmount.Text = Format(amount, "0.00")

    End Sub

    Private Function GetCount() As Short

        Dim count As Short = 0
        Dim dt As DataTable
        dt = dgvList.DataSource
        count = dt.Rows.Count.ToString
        Return count

    End Function

    Private Sub LoadData(iSql As String)

        ESSA.OpenConnection()
        Using adp As New SqlDataAdapter(iSql, Con)
            Using data2 As New DataTable
                adp.Fill(data2)
                bind.DataSource = Nothing
                bind.DataSource = data2
                dgvList.CleanFilterAndSort()
                dgvList.DataSource = Nothing
                dgvList.DataSource = bind.DataSource
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If cmbStyle.Text = "DEBIT" Then
            pnlBills.Visible = False
            LoadDebitReport()
        ElseIf cmbStyle.Text = "PAYMENT" Then
            pnlBills.Visible = True
            LoadPaymentReport()
        ElseIf cmbStyle.Text = "OLD DEBIT" Then
            pnlBills.Visible = False
            LoadOldDebit()
        ElseIf cmbStyle.Text = "CHEQUE DEBIT" Then
            pnlBills.Visible = False
            LoadDebitCheque()
        ElseIf cmbStyle.Text = "NOT SENT (DEBIT)" Then
            pnlBills.Visible = False
            LoadNotSent()
        End If

    End Sub

    Private Sub dgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvList.SortStringChanged

        bind.Sort = dgvList.SortString

    End Sub

    Private Sub dgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvList.FilterStringChanged

        bind.Filter = dgvList.FilterString
        If Not cmbStyle.Text = "PAYMENT" Then
            GetDebitTotal()
        Else
            GetPaymentTotal()
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvList.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "Pending Report"
        sfd1.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If sfd1.ShowDialog = DialogResult.Cancel Then Exit Sub

        Dim fileName = sfd1.FileName & ".xlsx"
        Dim tableData As New DataTable
        tableData = CType(dgvList.DataSource, DataTable)

        Using package As New ExcelPackage(New IO.FileInfo(fileName))
            Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")
            ws.Cells("A1").LoadFromDataTable(tableData, True)
            package.Save()
        End Using

        MsgBox("File exported successfully..!", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Tag)

    End Sub

    Private Sub LoadDebitCheque()

        SQL = "SELECT V.VendorName [PARTY NAME], " _
               & "RM.vchno [DEBIT NO], " _
               & "RM.vchdt [DEBIT DATE], " _
               & "RM.quantity [QUANTITY], " _
               & "CONVERT(DECIMAL(10,2),RM.netamt) [AMOUNT], " _
               & "RM.PODNo [POD No], " _
               & "U.UserName [USER] " _
               & "From rvchmaster RM, Vendors V, Users U " _
               & "WHERE RM.vendorid = V.VendorID AND RM.userid = U.UserID AND billno = -3 AND " _
               & "RM.VchDt BETWEEN '{0}' AND '{1}'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND RM.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY [DEBIT DATE]"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetDebitTotal()

        dgvList.Columns(0).Width = 200
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 100
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 80
        dgvList.Columns(5).Width = 100
        dgvList.Columns(6).Width = 100

    End Sub

    Private Sub LoadOldDebit()

        SQL = "SELECT V.VendorName [PARTY NAME], " _
               & "RM.vchno [DEBIT NO], " _
               & "RM.vchdt [DEBIT DATE], " _
               & "RM.quantity [QUANTITY], " _
               & "CONVERT(DECIMAL(10,2),RM.netamt) [AMOUNT], " _
               & "RM.PODNo [POD No], " _
               & "U.UserName [USER] " _
               & "From rvchmaster RM, Vendors V, Users U " _
               & "WHERE RM.vendorid = V.VendorID AND RM.userid = U.UserID AND billno = -2 AND " _
               & "RM.VchDt BETWEEN '{0}' AND '{1}'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND RM.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY [DEBIT DATE]"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetDebitTotal()

        dgvList.Columns(0).Width = 200
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 100
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 80
        dgvList.Columns(5).Width = 100
        dgvList.Columns(6).Width = 100

    End Sub

    Private Sub LoadNotSent()

        SQL = "SELECT V.VendorName [PARTY NAME], " _
               & "RM.vchno [DEBIT NO], " _
               & "RM.vchdt [DEBIT DATE], " _
               & "RM.quantity [QUANTITY], " _
               & "CONVERT(DECIMAL(10,2),RM.netamt) [AMOUNT], " _
               & "RM.PODNo [POD No], " _
               & "U.UserName [USER] " _
               & "From rvchmaster RM, Vendors V, Users U " _
               & "WHERE RM.vendorid = V.VendorID AND RM.userid = U.UserID AND billno = -1 AND " _
               & "RM.VchDt BETWEEN '{0}' AND '{1}'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND RM.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY [DEBIT DATE]"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetDebitTotal()

        dgvList.Columns(0).Width = 200
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 100
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 80
        dgvList.Columns(5).Width = 100
        dgvList.Columns(6).Width = 100

    End Sub

End Class