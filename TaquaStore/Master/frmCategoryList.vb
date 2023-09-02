Imports System.Data.SqlClient
Public Class frmCategoryList

    Private TblCat As New DataTable
    Private ParentID As Short = 0
    Private NodeLevel As SByte = 0

    Private Sub LoadCategoryLevels()

        SQL = "SELECT * FROM V_CATEGORYLEVELS ORDER BY LVL"

        TblCat.Clear()
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Adp.Fill(TblCat)
            TGLst.DataSource = TblCat
            HideOtherColumns()
            TGLst.Columns(TGLst.Columns.Count - 1).Width = 600
        End Using
        Con.Close()

        If TGLst.Rows.Count > 0 Then
            TGLst.Focus()
            TGLst.CurrentCell = TGLst.Item(TGLst.Columns.Count - 1, 0)
        End If
        txtFind.Select()

    End Sub

    Private Sub HideOtherColumns()

        For i As SByte = 0 To TGLst.Columns.Count - 2
            TGLst.Columns(i).Visible = False
        Next

    End Sub

    Private Sub FilterCategoryList(FilterText As String)

        Try

            Dim Vw = TblCat.Select("LVL LIKE '%" & FilterText & "%'", "LVL").CopyToDataTable
            TGLst.DataSource = Nothing
            TGLst.DataSource = Vw
            HideOtherColumns()
            TGLst.Columns(TGLst.Columns.Count - 1).Width = 600
            If TGLst.Rows.Count > 0 Then
                TGLst.CurrentCell = TGLst.Item(TGLst.Columns.Count - 1, 0)
            End If

        Catch EX As Exception
            TGLst.DataSource = Nothing
        End Try

    End Sub

    Private Sub frmCategoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCategoryLevels()

    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then

        ElseIf e.KeyCode <> Keys.Enter Then
            FilterCategoryList(txtFind.Text)
        End If

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown

        If TGLst.Rows.Count = 0 Then Exit Sub

        If e.KeyCode = Keys.Down Then
            If TGLst.CurrentRow Is Nothing Then Exit Sub
            If TGLst.CurrentRow.Index = TGLst.Rows.Count - 1 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(TGLst.Columns.Count - 1, TGLst.CurrentRow.Index + 1)
        ElseIf e.KeyCode = Keys.Up Then
            If TGLst.CurrentRow Is Nothing Then Exit Sub
            If TGLst.CurrentRow.Index = 0 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(TGLst.Columns.Count - 1, TGLst.CurrentRow.Index - 1)
        ElseIf e.KeyCode = Keys.Enter
            If TGLst.CurrentRow Is Nothing Then Exit Sub
            TGLst_KeyDown(sender, e)
        End If

    End Sub

    Private Sub frmCategoryList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape

                Close()

        End Select

    End Sub

    Private Sub TGLst_KeyDown(sender As Object, e As KeyEventArgs) Handles TGLst.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If TGLst.Rows.Count = 0 Then Exit Sub
            NodeLevel = GetNodeLevel(TGLst.CurrentRow.Index)
            frmCategory.txtParent.Text = TGLst.Item(TGLst.Columns.Count - 1, TGLst.CurrentRow.Index).Value
            frmCategory.txtCat.Focus()
            frmCategory.ParentID = ParentID
            frmCategory.NodeLevel = NodeLevel
            Me.Close()

        End If

    End Sub

    Private Function GetNodeLevel(iRowIdx As Short) As SByte

        GetNodeLevel = 0

        For i As SByte = 6 To 11

            If Val(TGLst.Item(i, iRowIdx).Value) = 0 Then
                Exit For
            End If

            ParentID = Val(TGLst.Item(i, iRowIdx).Value)
            GetNodeLevel += 1

        Next

    End Function

End Class