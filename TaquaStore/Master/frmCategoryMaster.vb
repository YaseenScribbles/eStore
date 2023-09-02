Public Class frmCategoryMaster

    Private CatID As Short = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        InsertCategory(txtName.Text)

    End Sub

    Private Sub InsertCategory(iName As String)

        '// Check Field Empty

        If txtName.Text.Trim = "" Then
            MsgBox("Category cannot be empty..!", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        End If

        '// Check Category Name Already Exists

        SQL = "select catid from categorylist where catdesc='" & iName.Trim & "'"
        If ESSA.ISFound(SQL) Then
            MsgBox("Category already exists..!", vbCritical)
            txtName.Focus()
            Exit Sub
        End If

        '// Create Unique ID

        CatID = ESSA.GenerateID("select max(catid) from categorylist")

        '// Save Data Into Database

        SQL = "insert into categorylist values (" _
            & CatID & ",'" _
            & iName.Trim & "')"

        ESSA.Execute(SQL)

        '// Insert Data Into DataGrid

        TG.Rows.Add()
        TG.Item(0, TG.Rows.Count - 1).Value = CatID
        TG.Item(1, TG.Rows.Count - 1).Value = iName.Trim

        '// Clear And Focus Name Field

        txtName.Clear()
        txtName.Focus()

    End Sub

    Private Sub LoadCategoryList()

        SQL = "select catid,catdesc from categorylist order by catdesc"
        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub frmCategoryMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            If pnlUpdate.Visible = True Then
                btnHide.PerformClick()
            End If
        End If

    End Sub

    Private Sub frmCategoryMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCategoryList()
        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlUpdate.Visible = False
        txtName.Focus()

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = 2 Then
            pnlUpdate.Visible = True
            lblCatID.Text = Val(TG.Item(0, e.RowIndex).Value)
            txtOldCat.Text = Trim(TG.Item(1, e.RowIndex).Value)
            txtNewCat.Clear()
            txtNewCat.Focus()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '// Check Field Empty

        If txtNewCat.Text.Trim = "" Then
            MsgBox("Category cannot be empty..!", MsgBoxStyle.Critical)
            txtNewCat.Focus()
            Exit Sub
        End If

        '// Check Category Name Already Exists

        SQL = "select catid from categorylist where catdesc='" & txtNewCat.Text.Trim & "'" _
            & " and catid<>" & Val(lblCatID.Text)
        If ESSA.ISFound(SQL) Then
            MsgBox("Category already exists..!", vbCritical)
            txtNewCat.Focus()
            Exit Sub
        End If

        SQL = "update categorylist set catdesc='" _
            & txtNewCat.Text.Trim & "' where catid=" _
            & Val(lblCatID.Text)

        ESSA.Execute(SQL)
        MsgBox("Category name updated..!", MsgBoxStyle.Information)
        LoadCategoryList()
        btnHide.PerformClick()

    End Sub

    Private Sub txtNewCat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewCat.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnUpdate.PerformClick()
        End If

    End Sub

End Class