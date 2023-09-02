'**************************** In the name of Allah, Most Merceiful, Most Compassionate ****************************
Imports System.Data.SqlClient
Public Class ProductSearch

    Private MainTbl As New DataTable
    Private FiltTbl As New DataTable

    Private Sub LoadData()

        SQL = "select p.plucode 'CODE',p.pluname 'DESCRIPTION',v.stock 'QOH',p.costprice 'C.PRICE',p.retailprice 'R.PRICE'," _
            & "vv.vendorname 'VENDOR',l.catdesc 'CATEGORY',l.scatdesc1 'SUBCATEGORY-1',l.scatdesc2 'SUBCATEGORY-2' from productmaster p,v_stockpos v,vendors vv,productlevels l where p.pluid=l.pluid and p.vendorid=vv.vendorid and p.pluid=v.pluid order by p.plucode"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            MainTbl.Clear()
            Adp.Fill(MainTbl)
        End Using
        Con.Close()

    End Sub

    Private Sub ProductSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'pnlLoading.Show() : pnlLoading.Refresh()
        'LoadData()
        'pnlLoading.Hide()

    End Sub
    Private Sub ProductSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        pnlLoading.Show() : pnlLoading.Refresh()
        LoadData()
        pnlLoading.Hide()

    End Sub

    Private Sub FilterData(ByVal ColNm As String, ByVal ColVl As String)

        TG.Visible = False
        pnlLoading.Show() : pnlLoading.Refresh()


        Try
            TG.DataSource = Nothing
            TG.DataSource = MainTbl.Select(ColNm & " like '%" + ColVl + "%'").CopyToDataTable
        Catch ex As Exception

        End Try

        pnlLoading.Hide()
        TG.Visible = True

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

        FilterData("CODE", txtCode.Text)

    End Sub

    Private Sub txtCat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCat.TextChanged

        FilterData("CATEGORY", txtCat.Text)

    End Sub

    Private Sub txtSCat1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSCat1.TextChanged

        FilterData("SUBCATEGORY-1", txtSCat1.Text)

    End Sub

    Private Sub txtSCat2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSCat2.TextChanged

        FilterData("SUBCATEGORY-2", txtSCat2.Text)

    End Sub

    Private Sub txtSCat3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSCat3.TextChanged

        FilterData("SUBCATEGORY-3", txtSCat3.Text)

    End Sub

    Private Sub txtVendor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.TextChanged

        FilterData("VENDOR", txtVendor.Text)

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

        FilterData("DESCRIPTION", txtName.Text)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlLOG.Visible = False

    End Sub

    Private Sub ProductSearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlLOG, Me)
        ESSA.MovetoCenter(pnlLoading, Me)

    End Sub

    Private Sub TG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellDoubleClick

        If e.ColumnIndex = -1 Then Exit Sub

        SQL = "SELECT DISTINCT M.GRNNO,M.GRNDT FROM GRNMASTER M,GRNDETAILS D,PRODUCTMASTER P " _
            & "WHERE M.GRNNO=D.GRNNO AND D.PLUID=P.PLUID AND P.PLUCODE='" & TG.Item(0, e.RowIndex).Value & "'" _
            & " ORDER BY M.GRNNO,M.GRNDT"

        With ESSA.OpenReader(SQL)
            TGGrn.Rows.Clear()
            While .Read
                TGGrn.Rows.Add()
                TGGrn.Item(0, TGGrn.Rows.Count - 1).Value = .Item(0)
                TGGrn.Item(1, TGGrn.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
            End While
            .Close()
        End With

        If TGGrn.Rows.Count > 0 Then
            pnlLOG.Visible = True
            TGGrn.Focus()
        End If

    End Sub


End Class