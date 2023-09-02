'******************************************** Bismillah *************************************************
Imports System.Data.SqlClient
Public Class Category

    Private CatID As Short
    Private ParentID As String
    Private NodeLevel As Byte

    Private Sub btnAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCat.Click

        If txtCat.Text.Trim = "" Then
            Exit Sub
        End If

        GenerateCategoryID()

        SQL = "insert into category values (" _
            & CatID & ",'" _
            & txtCat.Text.Trim & "',0,'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)
        txtCat.Clear()
        txtCat.Focus()
        PopulateTreeview()

    End Sub

    Private Sub GenerateCategoryID()

        SQL = "select max(scatid) from categorylevels"
        CatID = ESSA.GenerateID(SQL)

    End Sub

    Private Sub Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopulateTreeview()

    End Sub

    Private Sub PopulateTreeview()

        SQL = "select catid,catdesc from category order by catid;" _
            & "select pvscatid,scatid,scatdesc from categorylevels where cattype=1 order by pvscatid,scatid"

        With ESSA.OpenReader(SQL)

            TV2.Nodes.Clear()

            While .Read
                TV2.Nodes.Add(.Item(0), .GetString(1).Trim)
            End While

            .NextResult()

            While .Read

                Dim TN As TreeNode() = TV2.Nodes.Find(.Item(0), True)
                If TN.Length > 0 Then
                    TN(0).Nodes.Add(.Item(1), .GetString(2).Trim)
                End If

            End While

            .Close()

        End With

    End Sub

    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV2.AfterSelect, TV2.AfterSelect

        If e.Node Is Nothing Then Exit Sub
        lblSCat.Text = e.Node.FullPath
        ParentID = e.Node.Name
        NodeLevel = e.Node.Level

    End Sub

    Private Sub btnAddSubCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubCat.Click

        If txtSubCat.Text.Trim = "" Then
            LBLMsg.Text = " Subcategory cannot empty..!"
            Exit Sub
        ElseIf lblSCat.Text.Trim.Length = 0 Then
            LBLMsg.Text = " Cannot insert, Please select any category..!"
            Exit Sub
        Else
            LBLMsg.Text = ""
        End If

        GenerateCategoryID()

        SQL = "insert into subcategory" & NodeLevel + 1 & " values (" _
            & CatID & ",'" _
            & txtSubCat.Text.Trim & "'," _
            & ParentID & ",0,'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)
        Dim TN As TreeNode() = TV2.Nodes.Find(ParentID, True)
        If TN.Length > 0 Then
            TN(0).Nodes.Add(CatID, txtSubCat.Text.Trim)
        End If

        txtSubCat.Clear()
        txtSubCat.Focus()



        'PopulateTreeview()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub TV2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TV2.KeyUp

        If e.KeyCode = Keys.Delete Then

            If TV2.SelectedNode IsNot Nothing Then

                If MsgBox("Are you sure, do you want to delete category..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                If TV2.SelectedNode.Level = 0 Then
                    ESSA.Execute("delete from category where catid=" & TV2.SelectedNode.Name)
                Else
                    ESSA.Execute("delete from subcategory" & TV2.SelectedNode.Level & " where subcatid=" & TV2.SelectedNode.Name)
                End If

                MsgBox("Category deleted successfully..!", MsgBoxStyle.Information)
                PopulateTreeview()

            End If

        End If

    End Sub

End Class