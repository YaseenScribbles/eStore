Imports System.Data.SqlClient

Public Class frmNewCategory2

    Private dgvA, dgvB, dgvC, dgvD As Short
    Private SelTypeID As SByte = 0
    Private SelParentID As Short = 0
    Private Sub LoadDept()

        dgvA = 0
        lblA.Text = dgvA

        SQL = "SELECT CATID,CATDESC FROM CATEGORY_NEW ORDER BY CATDESC"
        LoadData(dgvDept, SQL)

    End Sub

    Private Sub LoadCat1(iDeptID As Short)

        dgvB = 0
        lblB.Text = dgvB

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY1_NEW WHERE PVSCATID={0} ORDER BY SCATDESC", iDeptID)
        LoadData(dgvCat1, SQL)

    End Sub

    Private Sub LoadCat2(iCatID1 As Short)

        dgvC = 0
        lblC.Text = dgvC

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY2_NEW WHERE PVSCATID={0} ORDER BY SCATDESC", iCatID1)
        LoadData(dgvCat2, SQL)

    End Sub

    Private Sub LoadCat3(iCatID2 As Short)

        dgvD = 0
        lblD.Text = dgvD

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY3_NEW WHERE PVSCATID={0} ORDER BY SCATDESC", iCatID2)
        LoadData(dgvCat3, SQL)

    End Sub

    Private Sub LoadData(iDGV As DataGridView, iSQL As String)

        iDGV.Rows.Clear()

        With ESSA.OpenReader(iSQL)
            While .Read
                iDGV.Rows.Add()
                iDGV.Item(0, iDGV.Rows.Count - 1).Value = .Item(0)
                iDGV.Item(1, iDGV.Rows.Count - 1).Value = .GetString(1).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub frmCategoryNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvA = 0
        dgvB = 0
        dgvC = 0
        dgvD = 0

        LoadDept()

        If dgvDept.Rows.Count > 0 Then
            dgvA = Val(dgvDept.Item(0, 0).Value)
            lblA.Text = "A : " & dgvA
            dgvDept.CurrentCell = dgvDept.Item(1, 0)
            LoadCat1(Val(dgvDept.Item(0, 0).Value))
        End If

        If dgvCat1.Rows.Count > 0 Then
            dgvB = Val(dgvCat1.Item(0, 0).Value)
            lblB.Text = "B : " & dgvB
            dgvCat1.CurrentCell = dgvCat1.Item(1, 0)
            LoadCat2(Val(dgvCat1.Item(0, 0).Value))
        End If

        If dgvCat2.Rows.Count > 0 Then
            dgvC = Val(dgvCat2.Item(0, 0).Value)
            lblC.Text = "C : " & dgvC
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(Val(dgvCat2.Item(0, 0).Value))
        End If

        If dgvCat3.Rows.Count > 0 Then
            dgvD = Val(dgvCat3.Item(0, 0).Value)
            lblD.Text = "D : " & dgvD
            dgvCat3.CurrentCell = dgvCat3.Item(1, 0)
        End If

    End Sub

    Private Sub dgvDept_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDept.CellEnter

        If e.RowIndex = -1 Then Exit Sub

        dgvCat1.Rows.Clear() : dgvCat2.Rows.Clear() : dgvCat3.Rows.Clear()
        LoadCat1(Val(dgvDept.Item(0, e.RowIndex).Value))
        dgvA = Val(dgvDept.Item(0, e.RowIndex).Value)
        lblA.Text = "A : " & dgvA

        If dgvCat1.Rows.Count > 0 Then
            dgvCat1.CurrentCell = dgvCat1.Item(1, 0)
            LoadCat2(Val(dgvCat1.Item(0, 0).Value))
            dgvB = Val(dgvCat1.Item(0, 0).Value)
            lblB.Text = "b : " & dgvB
        End If

        If dgvCat2.Rows.Count > 0 Then
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(Val(dgvCat2.Item(0, 0).Value))
            dgvC = Val(dgvCat2.Item(0, 0).Value)
            lblC.Text = "c : " & dgvC
        End If

        If dgvCat3.Rows.Count > 0 Then
            dgvCat3.CurrentCell = dgvCat3.Item(1, 0)
            dgvD = Val(dgvCat3.Item(0, 0).Value)
            lblD.Text = "d : " & dgvD
        End If

    End Sub

    Private Sub dgvCat1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCat1.CellEnter

        If e.RowIndex = -1 Then Exit Sub

        dgvCat2.Rows.Clear() : dgvCat3.Rows.Clear()
        LoadCat2(Val(dgvCat1.Item(0, e.RowIndex).Value))
        dgvB = Val(dgvCat1.Item(0, e.RowIndex).Value)
        lblB.Text = "b : " & dgvB

        If dgvCat2.Rows.Count > 0 Then
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(Val(dgvCat2.Item(0, 0).Value))
            dgvC = Val(dgvCat2.Item(0, 0).Value)
            lblC.Text = "c : " & dgvC
        End If

        If dgvCat3.Rows.Count > 0 Then
            dgvCat3.CurrentCell = dgvCat3.Item(1, 0)
            dgvD = Val(dgvCat3.Item(0, 0).Value)
            lblD.Text = "d : " & dgvD
        End If

    End Sub

    Private Sub dgvCat2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCat2.CellEnter

        If e.RowIndex = -1 Then Exit Sub

        dgvCat3.Rows.Clear()
        LoadCat3(Val(dgvCat2.Item(0, e.RowIndex).Value))
        dgvC = Val(dgvCat2.Item(0, e.RowIndex).Value)
        lblC.Text = "c : " & dgvC

        If dgvCat3.Rows.Count > 0 Then
            dgvCat3.CurrentCell = dgvCat3.Item(1, 0)
            dgvD = Val(dgvCat3.Item(0, 0).Value)
            lblD.Text = "d : " & dgvD
        End If

    End Sub

    Private Sub dgvCat3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCat3.CellEnter

        If e.RowIndex = -1 Then Exit Sub
        dgvD = Val(dgvCat3.Item(0, e.RowIndex).Value)
        lblD.Text = "d : " & dgvD

    End Sub

    Private Sub ShowPanel(iType As Short)

        Dim typeHead As String() = {"Department", "Category", "Style", "Sub-Style"}
        Dim typeColr As Color() = {Color.Black, Color.Purple, Color.FromArgb(192, 0, 0), Color.Green}

        lbl_head.Text = typeHead(iType) & " Name"
        pnl_head.Text = "Add " & typeHead(iType)
        lbl_err.Text = ""

        pnl_head.BackColor = typeColr(iType)
        btn_save.BackColor = typeColr(iType)
        btn_hide.BackColor = typeColr(iType)

        pnl_cat.Visible = True
        txt_name.Focus()

    End Sub

    Private Sub InsertCategory(iType As SByte, iParentID As Short)

        Dim typeHead As String() = {"Department", "Category", "Style", "Sub-Style"}

        If txt_name.Text.Trim = "" Then
            lbl_err.Text = typeHead(iType) & " cannot be empty..!"
            lbl_err.Show()
            Exit Sub
        End If

        Dim iName As String = txt_name.Text.Trim
        iName = iName.ToUpper()

        Dim iColName() As String = {"CATID", "SCATID", "SCATID", "SCATID"}
        Dim iColDesc() As String = {"CATDESC", "SCATDESC", "SCATDESC", "SCATDESC"}
        'Dim iTblName() As String = {"CATEGORY", "SUBCATEGORY1", "SUBCATEGORY2", "SUBCATEGORY3"}
        Dim iTblName() As String = {"CATEGORY_NEW", "SUBCATEGORY1_NEW", "SUBCATEGORY2_NEW", "SUBCATEGORY3_NEW"}
        Dim newCatID As Short = 0

        SQL = String.Format("SELECT {0} FROM {1} WHERE {2}='{3}'", iColName(iType), iTblName(iType), iColDesc(iType), iName)
        If ESSA.ISFound(SQL) = True Then
            lbl_err.Text = typeHead(iType) & " already exists..!"
            lbl_err.Show()
            txt_name.Focus()
            Exit Sub
        End If

        SQL = String.Format("SELECT MAX({0}) FROM {1}", iColName(iType), iTblName(iType))
        newCatID = ESSA.GenerateID(SQL)

        If iType = 0 Then

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        Else

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & iParentID & "," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        End If

        ESSA.Execute(SQL)

        txt_name.Clear()
        txt_name.Focus()
        lbl_err.Text = typeHead(iType) & " saved successfully..!"
        lbl_err.Show()

        Select Case iType

            Case 0
                LoadDept()
                ESSA.FindAndSelect(dgvDept, 0, newCatID)
                dgvCat1.Rows.Clear() : dgvCat2.Rows.Clear() : dgvCat3.Rows.Clear()
            Case 1
                LoadCat1(iParentID)
                ESSA.FindAndSelect(dgvCat1, 0, newCatID)
                dgvCat2.Rows.Clear() : dgvCat3.Rows.Clear()
            Case 2
                LoadCat2(iParentID)
                ESSA.FindAndSelect(dgvCat2, 0, newCatID)
                dgvCat3.Rows.Clear()
            Case 3
                LoadCat3(iParentID)
                ESSA.FindAndSelect(dgvCat3, 0, newCatID)

        End Select

    End Sub

    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click

        SelTypeID = 0
        SelParentID = dgvA

        ShowPanel(SelTypeID)

    End Sub

    Private Sub btnAddCat1_Click(sender As Object, e As EventArgs) Handles btnAddCat1.Click

        If dgvA = 0 Then
            MsgBox("Please select previous category..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        SelTypeID = 1
        SelParentID = dgvA
        ShowPanel(SelTypeID)

    End Sub

    Private Sub btnAddCat2_Click(sender As Object, e As EventArgs) Handles btnAddCat2.Click

        If dgvB = 0 Then
            MsgBox("Please select previous category..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        SelTypeID = 2
        SelParentID = dgvB
        ShowPanel(SelTypeID)

        'InsertCategory(2, dgvB)

    End Sub

    Private Sub btnAddCat3_Click(sender As Object, e As EventArgs) Handles btnAddCat3.Click

        If dgvC = 0 Then
            MsgBox("Please select previous category..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        SelTypeID = 3
        SelParentID = dgvC
        ShowPanel(SelTypeID)

        'InsertCategory(3, dgvC)

    End Sub

    Private Sub dgvDept_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDept.RowsRemoved

        dgvA = 0
        lblA.Text = dgvA

    End Sub

    Private Sub dgvCat1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCat1.RowsRemoved

        dgvB = 0
        lblB.Text = dgvB

    End Sub

    Private Sub dgvCat2_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCat1.RowsRemoved

        dgvC = 0
        lblC.Text = dgvC

    End Sub

    Private Sub dgvCat3_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCat1.RowsRemoved

        dgvD = 0
        lblD.Text = dgvD

    End Sub


    'Private id As Short = 0
    'Private edit As Boolean = False
    'Private status As SByte = 0             '0 - inactive, 1 - active
    'Private parent_id As SByte = 0          '0 - department, 1 - category, 2 - style, 3 - substyle
    'Private data_view As DataGridView = Nothing

    'Private Sub add_category(idgv As DataGridView, itype As SByte, Optional iparent_id As Short = -1)

    '    'var-declaration

    '    Dim typeHead As String() = {"Department", "Category", "Style", "Sub-Style"}
    '    Dim typeColr As Color() = {Color.Black, Color.Purple, Color.FromArgb(192, 0, 0), Color.Green}

    '    'panel-design-process

    '    parent_id = iparent_id
    '    lbl_err.Text = ""
    '    pnl_head.Text = typeHead(itype)
    '    lbl_head.Text = "Enter " & typeHead(itype)
    '    data_view = idgv

    '    'pane-color-section

    '    pnl_head.BackColor = typeColr(itype)
    '    btn_hide.BackColor = typeColr(itype)
    '    btn_save.BackColor = typeColr(itype)

    '    'panel-functional-section

    '    pnl_cat.Visible = True
    '    pnl_cat.Location = New Point(0, 0)
    '    txt_name.Focus()

    'End Sub

    'Private Sub generate_id()

    '    SQL = "SELECT max(id) FROM ts_category"
    '    id = ESSA.GenerateID(SQL)

    'End Sub

    'Private Sub btn_add1_Click(sender As Object, e As EventArgs) Handles btn_add1.Click

    '    add_category(tg_dept, 0, 0)

    'End Sub

    'Private Sub btn_add2_Click(sender As Object, e As EventArgs) Handles btn_add2.Click

    '    add_category(tg_catg, 1, Val(tg_dept.Item(0, tg_dept.CurrentRow.Index).Value))

    'End Sub

    'Private Sub btn_add3_Click(sender As Object, e As EventArgs) Handles btn_add3.Click

    '    add_category(tg_styl, 2, Val(tg_catg.Item(0, tg_catg.CurrentRow.Index).Value))

    'End Sub

    'Private Sub btn_add4_Click(sender As Object, e As EventArgs) Handles btn_add4.Click

    '    add_category(tg_ssty, 3, Val(tg_styl.Item(0, tg_styl.CurrentRow.Index).Value))

    'End Sub

    'Private Sub frmNewCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    '    Select Case e.KeyCode

    '        Case Keys.Enter

    '            If Me.ActiveControl.Tag <> "1" Then
    '                e.SuppressKeyPress = True
    '                Me.ProcessTabKey(True)
    '            End If

    '        Case Keys.Escape

    '            btn_hide.PerformClick()

    '    End Select

    'End Sub

    'Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click

    '    load_category(data_view, parent_id)
    '    pnl_cat.Visible = False

    'End Sub

    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    '    If txt_name.Text.Trim = "" Then
    '        show_msg(0)
    '        Exit Sub
    '    End If

    '    ESSA.OpenConnection()
    '    Dim Cmd = Con.CreateCommand
    '    Dim Trn = Con.BeginTransaction
    '    Cmd.Transaction = Trn

    '    Try

    '        If edit = True Then
    '            SQL = "DELETE FROM ts_category WHERE id=" & id
    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()
    '        Else
    '            generate_id()
    '        End If

    '        SQL = "INSERT INTO ts_category VALUES (" _
    '            & id & ",'" _
    '            & txt_name.Text.Trim & "'," _
    '            & parent_id & "," _
    '            & status & "," _
    '            & 0 & ",'" _
    '            & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
    '            & UserID & ")"

    '        Cmd.CommandText = SQL
    '        Cmd.ExecuteNonQuery()

    '        Trn.Commit()
    '        Con.Close()

    '        txt_name.Clear()
    '        txt_name.Focus()
    '        show_msg(3)

    '    Catch ex As SqlException
    '        Trn.Rollback()
    '        Con.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub

    'Private Sub show_msg(itype As SByte)

    '    Dim err_type As String() = {" cannot be empty.", " already exists.", " created successfully.", " updated successfully."}
    '    lbl_err.Text = pnl_head.Text & err_type(itype)
    '    lbl_err.Show()
    '    txt_name.Focus()

    'End Sub

    'Private Sub hide_msg()

    '    If lbl_err.Visible = True Then lbl_err.Visible = False

    'End Sub

    'Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    '    hide_msg()

    'End Sub

    'Private Sub btn_clear_text_Click(sender As Object, e As EventArgs) Handles btn_clear_text.Click

    '    txt_name.Clear()

    'End Sub

    'Private Sub load_category(dgv As DataGridView, Optional parent_id As SByte = -1)

    '    SQL = "SELECT id,name FROM ts_category"
    '    If parent_id > -1 Then
    '        SQL &= " WHERE parent=" & parent_id
    '    End If
    '    SQL &= " ORDER BY name"

    '    With ESSA.OpenReader(SQL)
    '        dgv.Rows.Clear()
    '        While .Read
    '            dgv.Rows.Add()
    '            dgv.Item(0, dgv.Rows.Count - 1).Value = .Item(0)
    '            dgv.Item(1, dgv.Rows.Count - 1).Value = .GetString(1).Trim
    '        End While
    '        .Close()
    '    End With

    'End Sub

    'Private Sub frmNewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    load_category(tg_dept, 0)

    '    If tg_dept.Rows.Count > 0 Then
    '        load_category(tg_catg, Val(tg_dept.Item(0, 0).Value))
    '        load_category(tg_styl, Val(tg_catg.Item(0, 0).Value))
    '        load_category(tg_ssty, Val(tg_styl.Item(0, 0).Value))
    '    End If

    'End Sub

    'Private Sub tg_dept_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tg_dept.CellClick

    '    If e.RowIndex = -1 Then Exit Sub
    '    load_category(tg_catg, Val(tg_dept.Item(0, e.RowIndex).Value))

    'End Sub

    'Private Sub tg_catg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tg_catg.CellClick

    '    If e.RowIndex = -1 Then Exit Sub
    '    load_category(tg_styl, Val(tg_catg.Item(0, e.RowIndex).Value))

    'End Sub

    'Private Sub tg_styl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tg_styl.CellClick

    '    If e.RowIndex = -1 Then Exit Sub
    '    load_category(tg_ssty, Val(tg_styl.Item(0, e.RowIndex).Value))

    'End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        InsertCategory(SelTypeID, SelParentID)

    End Sub

    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click

        txt_name.Text = ""
        lbl_err.Text = ""
        pnl_cat.Visible = False

    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

        If lbl_err.Text <> "" Then
            lbl_err.Text = ""
            lbl_err.Hide()
        End If

    End Sub

    Private Sub btn_clear_text_Click(sender As Object, e As EventArgs) Handles btn_clear_text.Click

        txt_name.Clear()

    End Sub

End Class