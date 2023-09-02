Imports System.Data.SqlClient

Public Class frmNewCategory

    Private dgvA, dgvB, dgvC, dgvD As Short
    Private SelTypeID As SByte = 0
    Private SelParentID As Short = 0
    Private DGrid As DataGridView

    Private Sub LoadDept()

        dgvA = 0
        lblA.Text = dgvA

        SQL = "SELECT CATID,CATDESC FROM CATEGORY_NEW ORDER BY CATDESC"
        LoadData(dgvDept, SQL)

    End Sub

    Private Sub LoadCat1(iDeptID As Short)

        dgvB = 0
        lblB.Text = dgvB

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY1_NEW WHERE DEPTID={0} ORDER BY SCATDESC", iDeptID)
        LoadData(dgvCat1, SQL)

    End Sub

    Private Sub LoadCat2(iDeptID As Short, iCatID1 As Short)

        dgvC = 0
        lblC.Text = dgvC

        'SQL = "SELECT S2.SCATID,S2.SCATDESC FROM SUBCATEGORY2_NEW S2,SUBCATEGORY1_NEW S1 WHERE S2.PVSCATID=S1.SCATID AND S2.PVSCATID={0} AND S1.PVSCATID={1} ORDER BY S2.SCATDESC"
        'SQL = String.Format(SQL, dgvA, iCatID1)

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY2_NEW WHERE DEPTID={0} AND PVSCATID1={1} ORDER BY SCATDESC", iDeptID, iCatID1)
        LoadData(dgvCat2, SQL)

    End Sub

    Private Sub LoadCat3(iDeptID As Short, iCatID1 As Short, iCatID2 As Short)

        dgvD = 0
        lblD.Text = dgvD

        'SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY3_NEW WHERE PVSCATID={0} ORDER BY SCATDESC", iCatID2)

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY3_NEW WHERE DEPTID={0} AND PVSCATID1={1} AND PVSCATID2={2} ORDER BY SCATDESC", iDeptID, iCatID1, iCatID2)
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

        LoadCategoryList()
        'loadCollections()
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
            LoadCat2(dgvA, Val(dgvCat1.Item(0, 0).Value))
        End If

        If dgvCat2.Rows.Count > 0 Then
            dgvC = Val(dgvCat2.Item(0, 0).Value)
            lblC.Text = "C : " & dgvC
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(dgvA, dgvB, Val(dgvCat2.Item(0, 0).Value))
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
            LoadCat2(dgvA, Val(dgvCat1.Item(0, 0).Value))
            dgvB = Val(dgvCat1.Item(0, 0).Value)
            lblB.Text = "b : " & dgvB
        End If

        If dgvCat2.Rows.Count > 0 Then
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(dgvA, dgvB, Val(dgvCat2.Item(0, 0).Value))
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
        LoadCat2(dgvA, Val(dgvCat1.Item(0, e.RowIndex).Value))
        dgvB = Val(dgvCat1.Item(0, e.RowIndex).Value)
        lblB.Text = "b : " & dgvB

        If dgvCat2.Rows.Count > 0 Then
            dgvCat2.CurrentCell = dgvCat2.Item(1, 0)
            LoadCat3(dgvA, dgvB, Val(dgvCat2.Item(0, 0).Value))
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
        LoadCat3(dgvA, dgvB, Val(dgvCat2.Item(0, e.RowIndex).Value))
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
        'cmbName.Focus()

    End Sub

    Private Sub InsertCategory(iType As SByte, iParentID As Short)

        Dim typeHead As String() = {"Department", "Category", "Style", "Sub-Style"}

        'If cmbName.Text.Trim = "" Then
        '    lbl_err.Text = typeHead(iType) & " cannot be empty..!"
        '    lbl_err.Show()
        '    Exit Sub
        'ElseIf cmbName.SelectedIndex = -1 Then
        '    lbl_err.Text = typeHead(iType) & " cannot be empty..!"
        '    lbl_err.Show()
        '    Exit Sub
        'End If

        Dim iName As String = txtName.Text.Trim
        Dim iVals As Short = Val(lblCatID.Text)

        iName = iName.ToUpper()

        Dim iColName() As String = {"CATID", "SCATID", "SCATID", "SCATID"}
        Dim iColDesc() As String = {"CATDESC", "SCATDESC", "SCATDESC", "SCATDESC"}
        Dim iTblName() As String = {"CATEGORY_NEW", "SUBCATEGORY1_NEW", "SUBCATEGORY2_NEW", "SUBCATEGORY3_NEW"}
        Dim newCatID As Short = 0

        'If iParentID = 0 Then
        '    SQL = String.Format("SELECT {0} FROM {1} WHERE {2}='{3}'", iColName(iType), iTblName(iType), iColDesc(iType), iName, iParentID)
        'Else
        '    SQL = String.Format("SELECT {0} FROM {1} WHERE {2}='{3}' AND PVSCATID={4}", iColName(iType), iTblName(iType), iColDesc(iType), iName, iParentID)
        'End If

        If FindPicked(DGrid, TGCat.Item(1, TGCat.CurrentRow.Index).Value) Then
            MsgBox("Item already picked..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If ESSA.ISFound(SQL) = True Then
        '    MsgBox("Already Exists..!", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        newCatID = iVals

        If iType = 0 Then

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        ElseIf iType = 1 Then

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & iParentID & "," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        ElseIf iType = 2 Then       'Sub Category Two

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & dgvA & "," _
                & iParentID & "," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        ElseIf iType = 3 Then       'Sub Category Three

            SQL = "INSERT INTO " & iTblName(iType) & " VALUES (" _
                & newCatID & ",'" _
                & iName & "'," _
                & dgvA & "," _
                & dgvB & "," _
                & iParentID & "," _
                & 0 & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

        End If

        ESSA.Execute(SQL)

        lblStatus.Text = typeHead(iType) & " Saved."
        lblStatus.Show()

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
                LoadCat2(dgvA, iParentID)
                ESSA.FindAndSelect(dgvCat2, 0, newCatID)
                dgvCat3.Rows.Clear()
            Case 3
                LoadCat3(dgvA, dgvB, iParentID)
                ESSA.FindAndSelect(dgvCat3, 0, newCatID)

        End Select

    End Sub

    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click

        DGrid = dgvDept
        SelTypeID = 0
        SelParentID = 0

        ShowPanel(SelTypeID)

    End Sub

    Private Sub btnAddCat1_Click(sender As Object, e As EventArgs) Handles btnAddCat1.Click

        If dgvA = 0 Then
            MsgBox("Please select previous category..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        DGrid = dgvCat1
        SelTypeID = 1
        SelParentID = dgvA
        ShowPanel(SelTypeID)

    End Sub

    Private Sub btnAddCat2_Click(sender As Object, e As EventArgs) Handles btnAddCat2.Click

        If dgvB = 0 Then
            MsgBox("Please select previous category..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        DGrid = dgvCat2
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

        DGrid = dgvCat3
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

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        InsertCategory(SelTypeID, SelParentID)

    End Sub

    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click

        lbl_err.Text = ""
        pnl_cat.Visible = False

    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs)

        If lbl_err.Text <> "" Then
            lbl_err.Text = ""
            lbl_err.Hide()
        End If

    End Sub

    Private Sub btnCategoryRegister_Click(sender As Object, e As EventArgs) Handles btnCategoryRegister.Click

        frmCategoryMaster.Visible = False
        frmCategoryMaster.Show(MainWindowX)

    End Sub

    Private Sub btnHide2_Click(sender As Object, e As EventArgs) Handles btnHide2.Click

        pnl_cat.Visible = False

    End Sub

    Private Sub LoadCategoryList()

        SQL = "select catid,catdesc from categorylist order by catdesc"
        With ESSA.OpenReader(SQL)
            TGCat.Rows.Clear()
            While .Read
                TGCat.Rows.Add()
                TGCat.Item(0, TGCat.Rows.Count - 1).Value = .Item(0)
                TGCat.Item(1, TGCat.Rows.Count - 1).Value = .GetString(1).Trim
            End While
            .Close()
        End With

    End Sub
    Private Sub btnReloadCat_Click(sender As Object, e As EventArgs) Handles btnReloadCat.Click

        LoadCategoryList()

    End Sub

    Private Sub TGCat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGCat.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        lblCatID.Text = Val(TGCat.Item(0, e.RowIndex).Value)
        txtName.Text = Trim(TGCat.Item(1, e.RowIndex).Value)
        InsertCategory(SelTypeID, SelParentID)

    End Sub

    Private Sub TGCat_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TGCat.PreviewKeyDown

        If e.KeyCode = Keys.Enter Then

        Else
            FindAndFocus(TGCat, Chr(e.KeyValue))
        End If

    End Sub

    Private Sub FindAndFocus(iGrid As DataGridView, iFindChar As String)

        For i As Short = 0 To iGrid.Rows.Count - 1

            If Mid(iGrid.Item(1, i).Value, 1, 1) = iFindChar Then
                iGrid.CurrentCell = iGrid.Item(1, i)
                iGrid.FirstDisplayedScrollingRowIndex = i
                Exit For
            End If

        Next

    End Sub

    Private Function FindPicked(iGrid As DataGridView, iFindValue As String) As Boolean

        FindPicked = False

        For i As Short = 0 To iGrid.Rows.Count - 1

            If iGrid.Item(1, i).Value = iFindValue Then
                FindPicked = True
                Exit For
            End If

        Next

    End Function

End Class