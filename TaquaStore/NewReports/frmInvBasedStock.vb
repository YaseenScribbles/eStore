Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class frmInvBasedStock

    Dim bind As New BindingSource

    Private Sub LoadDetailReport()

        SQL = "SELECT M.InvNo [Bill No],M.InvDt [Bill Date],M.GrnNo [Grn No],M.GrnDt [Grn Dt],P.Plucode [Code],P.Pluname [Description],S.Stock,P.CostPrice [Cost Price],A.Department,A.Category,A.Material,V.VendorName [Party Name] FROM GRNDetails D " _
        & "INNER JOIN GRNMaster M On M.GrnNo = D.GRNNo And M.InvDt BETWEEN '{0}' AND '{1}' " _
        & "INNER JOIN ProductMaster P ON P.PluID = D.PluID " _
        & "INNER JOIN ProductAttributes A ON A.PluId = P.PluID " _
        & "INNER JOIN Vendors V ON V.VendorID = M.VendorID "

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND M.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= "INNER JOIN v_stockpos S ON S.pluid = D.PluID AND S.location_id = 1 AND S.stock > 0 "

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetDetailsTotal()

        dgvList.Columns(5).Width = 200
        dgvList.Columns(11).Width = 300


    End Sub

    Private Sub LoadSummaryReport()

        SQL = "Select V.VendorName [Party Name],SUM(S.stock) Stock,SUM(P.CostPrice) [Total CP] FROM GRNDetails D " _
        & "INNER JOIN GRNMaster M On M.GrnNo = D.GRNNo And M.InvDt BETWEEN '{0}' AND '{1}' " _
        & "INNER JOIN ProductMaster P On P.PluID = D.PluID " _
        & "INNER JOIN Vendors V ON V.VendorID = M.VendorID "

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND M.VendorId = " & cmbVendor.SelectedValue
        End If

        SQL &= "INNER JOIN v_stockpos S On S.pluid = D.PluID And S.location_id = 1 And S.stock > 0 " _
        & "GROUP BY V.VendorName ORDER BY V.VendorName"

        SQL = String.Format(SQL, SqlDate(dtpBegin.Value), SqlDate(dtpEnd.Value))

        LoadData(SQL)
        GetSummaryTotal()
        dgvList.Columns(0).Width = 300

    End Sub

    Private Sub GetSummaryTotal()

        GetSummary(1, 2)

    End Sub

    Private Sub GetDetailsTotal()

        GetSummary(6, 7)

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
        sfd1.FileName = "Stock Report " & Format(dtpBegin.Value, "dd-MM-yyyy") & " To " & Format(dtpEnd.Value, "dd-MM-yyyy")
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


    Private Sub frmInvBasedStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ESSA.LoadVendors(cmbVendor, "All Vendors")
        cmbStyle.SelectedIndex = 0

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If cmbStyle.SelectedIndex = 0 Then
            LoadSummaryReport()
        Else
            LoadDetailReport()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Tag)

    End Sub

End Class