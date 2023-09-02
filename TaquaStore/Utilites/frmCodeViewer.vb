Public Class frmCodeViewer

    Private Sub frmCodeViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub ViewResult(plucode As String)

        SQL = "SELECT S.ShopName,M.DeliveryCode,M.DeliveryDate,sum(D.Quantity) Qty " _
            & "FROM ReceivedMasterTemp M,ReceivedDetailsTemp D,Shops S,ProductMaster P " _
            & "WHERE D.PluID=P.PluID AND M.DeliveryCode=D.DeliveryCode " _
            & "AND M.DeliveryFrom=S.ShopID AND P.Plucode='" & plucode & "' " _
            & "GROUP BY S.ShopName,M.DeliveryCode,M.DeliveryDate ORDER BY M.DeliveryDate"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0).Trim
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = Format(.GetDateTime(2).Date, "dd-MM-yyyy")
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
            End While
            .Close()
        End With

        If TG.Rows.Count = 0 Then
            MsgBox("Items not available..!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        ViewResult(txtCode.Text.Trim)

    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            ViewResult(txtCode.Text.Trim)
        End If

    End Sub

End Class