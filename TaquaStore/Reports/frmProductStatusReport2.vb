Public Class frmProductStatusReport2

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        pnlLoading.Show() : pnlLoading.Refresh()

        SQL = "SELECT P.PLUCODE [CODE],P.PLUNAME [DESCRIPTION],P.UNITS,V.PURCHASE,V.DELIVERY,V.SALES,(V.DELIVERY-V.SALES) [W.H STOCK],V2.VENDORNAME,L.CATDESC,L.SCATDESC1 FROM " _
            & "V_PRODUCTSTOCKATWAREHOUSE V,PRODUCTMASTER P,VENDORS V2,PRODUCTLEVELS L " _
            & "WHERE P.PLUID=L.PLUID AND P.VENDORID=V2.VENDORID AND V.PLUID=P.PLUID AND P.PLUID IN " _
            & "(SELECT DISTINCT PLUID FROM BILLDETAILS WHERE CAST(Convert(VARCHAR(8), BILLDT, 112) As INT)" _
            & " BETWEEN {0} AND {1}"

        If cmbShop.SelectedIndex > 0 Then
            SQL &= " AND SHOPID=" & cmbShop.SelectedValue
        End If

        SQL &= ") ORDER BY P.PLUCODE"

        SQL = String.Format(SQL, Format(mebFrom.Value, "yyyyMMdd"), Format(mebTo.Value, "yyyyMMdd"))

        ESSA.LoadDataGrid(TG, SQL)

        TG.Columns(0).Width = 80
        TG.Columns(1).Width = 250
        TG.Columns(2).Width = 50
        TG.Columns(3).Width = 75
        TG.Columns(4).Width = 75
        TG.Columns(5).Width = 75
        TG.Columns(6).Width = 75
        TG.Columns(7).Width = 200
        TG.Columns(8).Width = 200
        TG.Columns(9).Width = 200

        pnlLoading.Hide()

    End Sub

    Private Sub frmProductStatusReport2_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlLoading, Me)


    End Sub

    Private Sub frmProductStatusReport2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT SHOPID,(SHOPNAME + '-' + SHOPCODE) SHOP FROM SHOPS WHERE SHOPTYPE='RETAIL' ORDER BY SHOPID"
        ESSA.LoadCombo(cmbShop, SQL, "SHOP", "SHOPID", "ALL SHOP(S)")

    End Sub

End Class