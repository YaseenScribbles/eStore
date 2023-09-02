Imports System.Data.SqlClient
Public Class frmCategory

    Private CategoryMode As Boolean = False
    Public NodeLevel As SByte = 0
    Private CatID As Short = 0
    Public ParentID As Short = 0
    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        frmCategoryList.MdiParent = frmMainScreen
        frmCategoryList.Show()

    End Sub

    Private Sub Agents_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If xMessage.ShowMsg("Do you want to exit..?", True, frmMainScreen, 0, xMessage.MsgStyle.iExit) = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frmCategoryList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape

                Close()

        End Select

    End Sub

    Private Sub GenerateCategoryID()

        SQL = "select max(scatid) from categorylevels"
        CatID = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCat.Text.Trim = "" Then
            xMessage.ShowMsg("Subcategory cannot empty..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            Exit Sub
        ElseIf txtParent.Text.Trim.Length = 0 Then
            xMessage.ShowMsg("Cannot insert, Please select any category..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            Exit Sub
        ElseIf ESSA.ISFound("select * from subcategory" & NodeLevel - 1 & " where scatdesc='" & txtCat.Text.Trim & "'") = True Then
            xMessage.ShowMsg("Sub category already exists..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            txtCat.Focus()
            Exit Sub
        End If

        If xMessage.ShowMsg("Do you want to save..?", True, frmMainScreen, 0, xMessage.MsgStyle.Question) = False Then Exit Sub

        GenerateCategoryID()

        SQL = "insert into subcategory" & NodeLevel & " values (" _
            & CatID & ",'" _
            & txtCat.Text.Trim & "'," _
            & ParentID & ",1,'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)

        txtCat.Clear()
        txtParent.Clear()
        txtCat.Focus()

        'Dim TN As TreeNode() = TV2.Nodes.Find(ParentID, True)
        'If TN.Length > 0 Then
        '    TN(0).Nodes.Add(CatID, txtSubCat.Text.Trim)
        'End If

        'txtSubCat.Clear()
        'txtSubCat.Focus()

    End Sub

End Class