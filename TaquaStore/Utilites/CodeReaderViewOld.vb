Public Class CodeReaderViewOld

    Private Sub CodeReaderView_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.CenterToScreen(Me, pnlList)

    End Sub

    Private Sub btnAlter_Click(sender As Object, e As EventArgs) Handles btnAlter.Click

        SQL = "SELECT M.*, U.UserName FROM CRMaster M, Users U " _
            & "WHERE M.UserID = U.UserID ORDER BY M.ENo"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(5).Trim
            End While
            .Close()
        End With

        pnlList.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        pnlList.Hide()

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then

            SQL = "SELECT Z.Plucode, D.Department, C.Category, S.Style, P.Pattern,
                    M.Material, O.Color, V.Sleeve, B.Brand, G.Catalog, 
                    CASE WHEN Z.IsStitched = 0 THEN 'Yes' ELSE 'No' END [IsStitched]
                    FROM CRDetail Z, TSDepartment D, TSCategory C,
                    TSStyle S, TSPattern P, TSMaterial M, TSColor O, TSSleeve V, TSBrand B,
                    TSCatalog G
                    WHERE D.DeptId = Z.DeptId AND Z.CatId = C.CatId
                    AND Z.StyleId = S.StyleId AND Z.PatternId = P.PatternId
                    AND Z.MaterialId = M.MaterialId AND Z.ColorId = O.ColorId
                    AND Z.SleeveId = V.SleeveId AND Z.BrandId = B.BrandId
                    AND Z.CatalogId = G.CatalogId AND Z.ENo = {0} ORDER BY Z.Sno"

            SQL = String.Format(SQL, Val(TG.Item(0, e.RowIndex).Value))
            ESSA.LoadDataGrid(DataGrid, SQL)
            lblTotal.Text = "Total Items: " & DataGrid.Rows.Count
            pnlList.Hide()

        End If

    End Sub

End Class