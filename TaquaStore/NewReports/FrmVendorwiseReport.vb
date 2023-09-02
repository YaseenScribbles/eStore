Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class FrmVendorwiseReport
    Private Sub FrmVendorwiseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT DeptId,Department FROM TSDepartment ORDER BY Department"
        ESSA.LoadCombo(CmbDept, SQL, "Department", "DeptId", "All Departments")

        SQL = "SELECT CatId,Category FROM TSCategory ORDER BY Category"
        ESSA.LoadCombo(CmbCat, SQL, "Category", "CatId", "All Categories")

        SQL = "SELECT MaterialId,Material FROM TSMaterial ORDER BY Material"
        ESSA.LoadCombo(CmbMaterial, SQL, "Material", "MaterialId", "All Materials")

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        pnlLoad.Show() : pnlLoad.Refresh()

        SQL = "SELECT VendorName,SUM(Purchase) Purchase, " _
               & "SUM(Sales) Sales, " _
               & "SUM ([Party Return]) [Party Return], " _
               & "ROUND((SUM(Sales)/SUM(Purchase)) * 100,0) Percentage " _
               & "FROM VendorWise_Report WHERE GRNDt BETWEEN '" _
               & Format(dtpBegin.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpEnd.Value, "yyyy-MM-dd") & "'"

        If CmbDept.SelectedIndex > 0 Then
            SQL &= "AND Department = '" & CmbDept.Text.Trim & "'"
        End If

        If CmbCat.SelectedIndex > 0 Then
            SQL &= "AND Category = '" & CmbCat.Text.Trim & "'"
        End If

        If CmbMaterial.SelectedIndex > 0 Then
            SQL &= "AND Material = '" & CmbMaterial.Text.Trim & "'"
        End If

        SQL &= "GROUP BY VendorName " _
            & "ORDER BY VendorName"

        LoadData(SQL)

        dgvReport.Columns(0).Width = 300
        dgvReport.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvReport.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvReport.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvReport.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        pnlLoad.Hide()

    End Sub

    Dim bind As New BindingSource

    Private Sub LoadData(iSql As String)

        ESSA.OpenConnection()
        Using adp As New SqlDataAdapter(iSql, Con)
            adp.SelectCommand.CommandTimeout = 0
            Using data2 As New DataTable
                adp.Fill(data2)
                bind.DataSource = Nothing
                bind.DataSource = data2
                dgvReport.CleanFilterAndSort()
                dgvReport.DataSource = Nothing
                dgvReport.DataSource = bind.DataSource
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub dgvReport_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvReport.SortStringChanged

        bind.Sort = dgvReport.SortString

    End Sub

    Private Sub dgvReport_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvReport.FilterStringChanged

        bind.Filter = dgvReport.FilterString

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvReport.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "Vendors Report"
        sfd1.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If sfd1.ShowDialog = DialogResult.Cancel Then Exit Sub

        Dim fileName = sfd1.FileName & ".xlsx"
        Dim tableData As New DataTable
        tableData = CType(dgvReport.DataSource, DataTable)

        Using package As New ExcelPackage(New IO.FileInfo(fileName))
            Dim Sheetname As String = ""
            If CmbDept.SelectedIndex > 0 Then
                Sheetname = CmbDept.Text & "-"
            End If
            If CmbCat.SelectedIndex > 0 Then
                Sheetname &= CmbCat.Text
            End If
            If CmbMaterial.SelectedIndex > 0 Then
                Sheetname &= "-" & CmbMaterial.Text
            End If
            Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add(Sheetname)
            ws.Cells("A1").LoadFromDataTable(tableData, True)
            package.Save()
        End Using

        MsgBox("File exported successfully..!", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Tag)

    End Sub

End Class