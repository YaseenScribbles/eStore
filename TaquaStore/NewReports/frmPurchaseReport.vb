Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class frmPurchaseReport

    Dim bind As New BindingSource

    Private Sub frmPurchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ESSA.LoadVendors(cmbVendor, "All Vendors")
        cmbStyle.SelectedIndex = 0

    End Sub

    Private Sub LoadDetailReport()

        SQL = "SELECT A.GrnNo [GRN No],A.GrnDt [GRN Date],A.InvNo [Inv No]," _
            & "A.InvDt [Inv Date],A.VendorName [Vendor], A.Plucode, A.Pluname,A.Size," _
            & "A.CostPrice, A.Margin, A.RetailPrice, A.Qty, A.Amount, B.Department, B.Category, B.Style," _
            & "B.Pattern, B.Material, B.Color, B.Sleeve, B.Catalog FROM " _
            & "(SELECT D.PluId, M.GrnNo, M.GrnDt, M.InvNo, M.InvDt,V.VendorName, P.Plucode, P.Pluname, " _
            & "P.CostPrice, P.RetailPrice,((P.RetailPrice - P.CostPrice) / P.CostPrice) * 100 Margin, D.Qty, (D.Qty * D.CostPrice) Amount,P.Id [Size] " _
            & "FROM GRNMaster M, GRNDetails D, Vendors V, ProductMaster P " _
            & "WHERE D.PluId = P.PluId AND M.GrnNo = D.GrnNo " _
            & "AND V.VendorID = M.VendorID AND M.GrnDt BETWEEN '{0}' AND '{1}' {2}) A " _
            & "LEFT OUTER JOIN " _
            & "(SELECT * FROM ProductAttributes) B " _
            & "ON A.PluID = B.PluId ORDER BY A.GrnNo"

        Dim filterVendor = ""

        If cmbVendor.SelectedIndex > 0 Then
            filterVendor = " AND M.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value), filterVendor)

        LoadData(SQL)
        GetDetailsTotal()

        dgvList.Columns(0).Width = 80
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 80
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 300

    End Sub

    Private Sub LoadSummaryReport()

        SQL = "SELECT A.*, " _
            & "CASE(B.PaidStatus) " _
            & "When 0 Then 'NO' " _
            & "WHEN 1 THEN 'YES' " _
            & "ELSE 'NOT GIVEN' " _
            & "END AS [Paid Status], " _
            & "ISNULL(B.Paid,0) [LR Amount] " _
            & "FROM " _
            & "(Select " _
            & "M.GrnNo [GRN No]," _
            & "M.GrnDt [GRN Date]," _
            & "M.InvNo [Inv No]," _
            & "M.InvDt [Inv Date]," _
            & "V.VendorName [Vendor]," _
            & "M.TotalQuantity [Quantity]," _
            & "CONVERT(Decimal(10,2), M.NettAmount) [Amount], " _
            & "U.UserName [User], " _
            & "M.LRNo [LR No] " _
            & "FROM " _
            & "GRNMaster M, Vendors V, Users U " _
            & "WHERE " _
            & "V.VendorID = M.VendorID And M.UserId = U.UserId And " _
            & "M.GrnDt BETWEEN '{0}' AND '{1}'"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND M.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= ") A LEFT JOIN (SELECT * FROM LR_Payment) B ON A.[GRN No] = B.GrnNo"

        LoadData(SQL)
        GetSummaryTotal()

        dgvList.Columns(0).Width = 80
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 80
        dgvList.Columns(3).Width = 80
        dgvList.Columns(4).Width = 300
        dgvList.Columns(8).Width = 145

    End Sub

    Private Function GetBillCount() As Short

        Dim grnNo As String = ""
        Dim count As Short = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1

            If grnNo <> Trim(dgvList.Item(0, i).Value) Then
                grnNo = Trim(dgvList.Item(0, i).Value)
                count += 1
            End If

        Next

        Return count

    End Function

    Private Sub GetSummaryTotal()

        GetSummary(5, 6)

    End Sub

    Private Sub GetDetailsTotal()

        GetSummary(11, 12)

    End Sub

    Private Sub GetSummary(qIndex As Byte, aIndex As Byte)

        Dim amount As Double = 0
        Dim quantity As Double = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1
            quantity += Val(dgvList.Item(qIndex, i).Value)
            amount += Val(dgvList.Item(aIndex, i).Value)
        Next

        lblBills.Text = GetBillCount()
        lblQty.Text = quantity
        lblAmount.Text = Format(amount, "0.00")

    End Sub

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

        If cmbStyle.SelectedIndex = 0 Then
            LoadSummaryReport()
        Else
            LoadDetailReport()
        End If

    End Sub

    Private Sub dgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvList.SortStringChanged

        bind.Sort = dgvList.SortString

    End Sub

    Private Sub dgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvList.FilterStringChanged

        bind.Filter = dgvList.FilterString
        If cmbStyle.SelectedIndex = 0 Then
            GetSummaryTotal()
        Else
            GetDetailsTotal()
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvList.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "Purchase Report"
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

End Class