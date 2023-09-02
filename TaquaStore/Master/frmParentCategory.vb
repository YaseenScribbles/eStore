Public Class frmParentCategory

    Private CatID As Short
    Private Edit As Boolean = False

    Private Sub frmParentCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                Close()

        End Select

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCat.Text.Trim = "" Then
            Exit Sub
        ElseIf ESSA.ISFound("select catid from category where catdesc='" & txtCat.Text.Trim & "'" & IIf(Edit = True, " and catid<>" & CatID, "")) = True Then
            xMessage.ShowMsg("Category name already exists..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            txtCat.Focus()
            Exit Sub
        End If

        If xMessage.ShowMsg("Do you want to save..?", True, frmMainScreen, 0, xMessage.MsgStyle.Question) = False Then Exit Sub

        GenerateCategoryID()

        SQL = "insert into category values (" _
            & CatID & ",'" _
            & txtCat.Text.Trim & "',0,'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)
        txtCat.Clear()
        txtCat.Focus()

    End Sub
    Private Sub GenerateCategoryID()

        SQL = "select max(scatid) from categorylevels"
        CatID = ESSA.GenerateID(SQL)

    End Sub

End Class