'******************************** In the name of Allah, Most Mericiful, Most Compassionate ************************
Imports System.Data.SqlClient
Public Class SalesReturnReport

    Private Rpt As New RptSalesQuantityReportDW

    Private Sub SalesQuantityReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "shopdesc", "shopid")

        SQL = "select catid,catdesc from category order by catdesc"
        ESSA.LoadComboSimple(CmbCat, SQL, "catdesc", "catid", "All Category(s)")

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid", "All Vendor(s)")

        Dim OBTbl As New DataTable
        OBTbl.Columns.Add("OBID")
        OBTbl.Columns.Add("OBNAME")

        Dim DR = OBTbl.NewRow
        DR("OBID") = "plucode"
        DR("OBNAME") = "CODE"
        OBTbl.Rows.Add(DR)


        DR = OBTbl.NewRow
        DR("OBID") = "vendorname"
        DR("OBNAME") = "VENDOR NAME"
        OBTbl.Rows.Add(DR)

        DR = OBTbl.NewRow
        DR("OBID") = "billdt"
        DR("OBNAME") = "Bill Date"
        OBTbl.Rows.Add(DR)

        cmbOrderBy.DataSource = OBTbl
        cmbOrderBy.DisplayMember = "OBNAME"
        cmbOrderBy.ValueMember = "OBID"

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "select p.plucode,p.pluname,p.id,sum(-d.qty) 'Quantity',convert(decimal(10,2),d.ORate) 'MRP',convert(decimal(10,2),sum(-d.amount)) 'Amount',convert(decimal(10,2),sum(d.DisAmt)) 'Discount',l.CatDesc,l.SCatDesc1,l.SCatDesc2,l.SCatDesc3,l.SCatDesc4,v.vendorname,d.billdt,p.costprice,d.disperc disp from " _
            & "productmaster p,billdetails d,productlevels l,vendors v where p.vendorid=v.vendorid and p.pluid=l.pluid and p.pluid=d.pluid and d.shopid=" & cmbLocation.SelectedValue _
            & " and d.billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If pnlCatFilter.Visible = True Then

            If cmbVendor.SelectedIndex > 0 Then SQL &= " and p.vendorid=" & cmbVendor.SelectedValue
            If CmbCat.SelectedIndex > 0 Then SQL &= " and l.catid=" & ESSA.GetItemValue(CmbCat)
            If CmbSCat1.SelectedIndex > 0 Then SQL &= " and l.scatid1=" & ESSA.GetItemValue(CmbSCat1)
            If cmbSCat2.SelectedIndex > 0 Then SQL &= " and l.scatid2=" & ESSA.GetItemValue(cmbSCat2)
            If cmbSCat3.SelectedIndex > 0 Then SQL &= " and l.scatid3=" & ESSA.GetItemValue(cmbSCat3)

            If chkFGW.Checked = True Then
                SQL &= " and d.pluid in (select distinct pluid from grndetails where grnno=" & Val(CMBGrn.Text) & ")"
            End If

        End If

        SQL &= " group by p.plucode,p.pluname,p.id,d.ORate,CatDesc,SCatDesc1,SCatDesc2,SCatDesc3,SCatDesc4,v.vendorname,d.billdt,p.costprice,d.disperc" _
            & " having sum(d.qty)<0 order by " & cmbOrderBy.SelectedValue

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                Rpt.SetParameterValue("LOCATION", cmbLocation.Text)
                Rpt.SetParameterValue("DURATION", Format(mebFrom.Value, "dd-MMM-yyyy") & " TO " & Format(mebTo.Value, "dd-MMM-yyyy"))
                CRpt.ReportSource = Rpt
            End Using
        End Using
        Con.Close()

        'ESSA.OpenConnection()
        'Using Adp As New SqlDataAdapter(SQL, Con)
        '    Using Tbl As New DataTable
        '        Adp.Fill(Tbl)
        '        TG.DataSource = Nothing
        '        TG.DataSource = Tbl
        '        TG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        '    End Using
        'End Using
        'Con.Close()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlCatFilter.Visible = False

    End Sub

    Private Sub CmbCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCat.SelectedIndexChanged

        If CmbCat.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory1 " & IIf(CmbCat.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbCat), "") & " order by scatdesc"
        ESSA.LoadComboSimple(CmbSCat1, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub CmbSCat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSCat1.SelectedIndexChanged

        If CmbSCat1.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory2 " & IIf(CmbSCat1.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbSCat1), "") & " order by scatdesc"
        ESSA.LoadComboSimple(cmbSCat2, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub cmbSCat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat2.SelectedIndexChanged

        If cmbSCat2.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory3 " & IIf(cmbSCat2.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(cmbSCat2), "") & " order by scatdesc"
        ESSA.LoadComboSimple(cmbSCat3, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub btnAdvanceSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvanceSearch.Click

        pnlCatFilter.Visible = True
        cmbVendor.Focus()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        btnDisplay.PerformClick()
        pnlCatFilter.Visible = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub chkFGW_CheckedChanged(sender As Object, e As EventArgs) Handles chkFGW.CheckedChanged

        btnLoadGRN.Visible = chkFGW.Checked
        lblGRN.Visible = chkFGW.Checked
        CMBGrn.Visible = chkFGW.Checked

    End Sub

    Private Sub btnLoadGRN_Click(sender As Object, e As EventArgs) Handles btnLoadGRN.Click

        If cmbVendor.SelectedIndex > 0 Then
            SQL = "SELECT grnno FROM GRNMASTER WHERE VENDORID=" & cmbVendor.SelectedValue & " ORDER BY GRNNO"
            ESSA.LoadCombo(CMBGrn, SQL, "grnno")
        End If

    End Sub

End Class