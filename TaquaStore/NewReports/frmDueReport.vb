Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class frmDueReport

    Dim bind As New BindingSource
    Dim LSERVER As String = ""
    Dim DBASE As String = ""

    Private Sub frmDueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT VendorId,VendorName FROM Vendors ORDER BY VendorName "
        ESSA.LoadCombo(CmbVendor, SQL, "VendorName", "VendorId", "All Vendors")
        CmbVendor.SelectedIndex = 0

        SQL = "SELECT ShopId,ShopName + ' - ' + ShopCode ShopDesc FROM Shops ORDER BY ShopId "
        ESSA.LoadCombo(cmbLocation, SQL, "ShopDesc", "ShopId")
        cmbLocation.SelectedIndex = 0

    End Sub

    Private Sub LoadDueReport()

        'GetConnectionString()

        SQL = "SELECT S.PluId," _
            & "M.PluCode [CODE]," _
            & "M.PluName [DESCRIPTION]," _
            & "M.Id [SIZE]," _
            & "A.Department [DEPARTMENT]," _
            & "A.Category [CATEGORY]," _
            & "A.Material [MATERIAL]," _
            & "M.CostPrice [COST PRICE]," _
            & "M.RetailPrice [RETAIL PRICE]," _
            & "DATEDIFF(DAY,G.GRNDt,CURRENT_TIMESTAMP) [DAYS], " _
            & "SUM(S.stock) [STOCK], " _
            & "V.VendorName [VENDOR NAME] " _
            & "FROM v_stockpos S, ProductMaster M, GRNDetails G, GRNMaster GM, ProductAttributes A, Vendors V " _
            & "WHERE S.pluid = M.PluID And M.Size = G.PluID And S.pluid = A.PluId And G.GrnNo = GM.GrnNo And GM.VendorId = V.VendorId And S.location_id = " & cmbLocation.SelectedValue & "  And S.stock > 0 "

        If CmbVendor.SelectedIndex > 0 Then
            SQL &= " And GM.VendorId =" & CmbVendor.SelectedValue
        End If

        If chkGrnWise.Checked = True Then
            SQL &= " And GM.GrnNo = " & cmbGrn.Text.Trim
        End If

        If chkDateWise.Checked = True Then
            SQL &= " And GM.GrnDt BETWEEN '" & Format(dtpBegin.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpEnd.Value, "yyyy-MM-dd") & "'"
        End If

        SQL &= " GROUP BY S.pluid, M.Plucode, M.Pluname,M.Id,A.Department,A.Category,A.Material,M.CostPrice,M.RetailPrice, DATEDIFF(DAY,G.GRNDt,CURRENT_TIMESTAMP), V.VendorName " _
             & "ORDER BY DAYS DESC"

        Try

            LoadData(SQL)
            LoadSummary()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Con.Close()

        End Try

        dgvList.Columns(0).Visible = False
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 250
        dgvList.Columns(3).Width = 60
        dgvList.Columns(4).Width = 120
        dgvList.Columns(5).Width = 120
        dgvList.Columns(6).Width = 120
        dgvList.Columns(7).Width = 100
        dgvList.Columns(8).Width = 100
        dgvList.Columns(9).Width = 80
        dgvList.Columns(10).Width = 80
        dgvList.Columns(11).Width = 250

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvList.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "DueDays Report"
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

    Private Sub LoadData(iSql As String)

        ESSA.OpenConnection()
        Using adp As New SqlDataAdapter(iSql, Con)
            adp.SelectCommand.CommandTimeout = 0
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Tag)

    End Sub

    Private Function LSTBL(tbl As String, als As String) As String

        LSTBL = LSERVER & "." & DBASE & ".DBO." & tbl & " " & als

    End Function

    Private Sub GetConnectionString()

        SQL = "select * from locationsettings where shopid=" & cmbLocation.SelectedValue
        With ESSA.OpenReader(SQL)
            If .Read Then
                LSERVER = .GetString(1)
                DBASE = .GetString(4)
            End If
            .Close()
        End With

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        pnlLoad.Show() : pnlLoad.Refresh()
        LoadDueReport()
        pnlLoad.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If chkGrnWise.Checked = True Then
            If CmbVendor.SelectedIndex > 0 Then
                SQL = "SELECT GrnNo FROM GrnMaster WHERE VendorId = " & CmbVendor.SelectedValue
                ESSA.LoadCombo(cmbGrn, SQL, "GrnNo")
            Else
                cmbGrn.DataSource = Nothing
            End If
        Else
            cmbGrn.DataSource = Nothing
        End If

    End Sub

    Private Sub LoadSummary()

        Dim Qty As Double = 0
        Dim Amount As Double = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1
            Qty += Val(dgvList.Item(10, i).Value)
            Amount += Val(dgvList.Item(7, i).Value)
        Next

        lblQty.Text = Qty
        lblAmount.Text = Format(Amount, "0.00")

    End Sub

    Private Sub frmDueReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlLoad, Me)

    End Sub

    Private Sub chkDateWise_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateWise.CheckedChanged

        dtpBegin.Enabled = chkDateWise.Checked
        dtpEnd.Enabled = chkDateWise.Checked

    End Sub

    Private Sub dgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvList.SortStringChanged

        bind.Sort = dgvList.SortString

    End Sub

    Private Sub dgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvList.FilterStringChanged

        bind.Filter = dgvList.FilterString
        LoadSummary()

    End Sub
End Class