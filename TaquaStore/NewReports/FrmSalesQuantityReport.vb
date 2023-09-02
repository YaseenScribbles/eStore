Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class FrmSalesQuantityReport

    Private Data As New DataTable
    Private BindingSource1 As New BindingSource

    Private Sub FrmSalesQuantityReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shoptype='Retail' order by shopid"
        ESSA.LoadCombo(CmbLocation, SQL, "shopdesc", "shopid")

    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click

        SQL = "SELECT A.Code, A.Description, A.Size, A.Quantity, A.CostPrice, A.MRP, A.Amount, A.VendorName," _
            & "B.Department, B.Category, B.Style, B.Pattern, B.Material, B.Color, B.Sleeve, B.Brand, B.Catalog FROM " _
            & "(SELECT " _
            & "P.PluId," _
            & "P.Plucode [Code]," _
            & "P.Pluname [Description]," _
            & "P.Id [Size]," _
            & "D.Qty [Quantity]," _
            & "CONVERT(DECIMAL(10,2), P.CostPrice) CostPrice," _
            & "CONVERT(DECIMAL(10,2), P.MRP) MRP," _
            & "CONVERT(DECIMAL(10,2), D.Amount) Amount," _
            & "V.VendorName " _
            & "FROM BillDetails D, ProductMaster P, Vendors V " _
            & "WHERE V.VendorId = P.VendorId And D.PluId = P.PluId And D.BillDt BETWEEN '" _
            & Format(DtpFrom.Value, "yyyy-MM-dd") & "' AND '" _
            & Format(DtpTo.Value, "yyyy-MM-dd") & "' AND D.ShopId=" _
            & CmbLocation.SelectedValue

        If chkReturn.Checked Then
            SQL &= " AND D.Qty < 0"
        Else
            SQL &= " AND D.Qty >= 0"
        End If

        SQL &= ") A " _
            & "LEFT OUTER JOIN " _
            & "(SELECT * FROM ProductAttributes) B " _
            & "ON A.PluID = B.PluId"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Data.Clear()
            Adp.Fill(Data)
        End Using
        Con.Close()

        BindingSource1.DataSource = Data
        DgvList.CleanFilterAndSort()
        DgvList.DataSource = Nothing
        DgvList.DataSource = BindingSource1.DataSource

        SetHeaderWidth()
        GetGrandTotal(3, 6)

    End Sub

    Private Sub SetHeaderWidth()

        DgvList.Columns(0).Width = 100
        DgvList.Columns(1).Width = 250
        DgvList.Columns(2).Width = 80
        DgvList.Columns(3).Width = 80
        DgvList.Columns(4).Width = 80
        DgvList.Columns(5).Width = 80
        DgvList.Columns(6).Width = 80
        DgvList.Columns(7).Width = 250

    End Sub

    Private Sub GetGrandTotal(qIndex As Short, aIndex As Short)

        Dim totalQty As Double = 0
        Dim totalAmount As Double = 0

        For i As Integer = 0 To DgvList.Rows.Count - 1
            totalQty += Val(DgvList.Item(qIndex, i).Value)
            totalAmount += Val(DgvList.Item(aIndex, i).Value)
        Next

        lblQty.Text = Format(totalQty, "0.00")
        lblAmt.Text = Format(totalAmount, "0.00")

    End Sub

    Private Sub DgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles DgvList.SortStringChanged

        BindingSource1.Sort = DgvList.SortString

    End Sub

    Private Sub DgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles DgvList.FilterStringChanged

        BindingSource1.Filter = DgvList.FilterString
        GetGrandTotal(3, 6)

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

        If DgvList.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "SalesQuantityReport"
        sfd1.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If sfd1.ShowDialog = DialogResult.Cancel Then Exit Sub

        Dim fileName = sfd1.FileName & ".xlsx"
        Dim tableData As New DataTable
        tableData = CType(DgvList.DataSource, DataTable)

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