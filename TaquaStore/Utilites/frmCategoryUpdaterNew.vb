Imports System.Data.SqlClient

Public Class frmCategoryUpdaterNew

#Region "UNUSED"

    'Private Sub frmCategoryUpdaterNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    load_department(cmbDept)
    '    load_department_2(cmbDeptNC)

    '    TG.Columns(8).Width = TG.Width - 920

    'End Sub

    'Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged

    '    cmbSCat1.DataSource = Nothing : cmbSCat2.DataSource = Nothing : cmbSCat3.DataSource = Nothing
    '    If cmbDept.SelectedIndex = -1 Then Exit Sub
    '    load_category(cmbSCat1, 1, cmbDept.SelectedValue)

    'End Sub

    'Private Sub cmbSCat1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat1.SelectedIndexChanged

    '    cmbSCat2.DataSource = Nothing : cmbSCat3.DataSource = Nothing
    '    If cmbSCat1.SelectedIndex = -1 Then Exit Sub
    '    load_category(cmbSCat2, 2, cmbSCat1.SelectedValue)

    'End Sub

    'Private Sub cmbSCat2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat2.SelectedIndexChanged

    '    cmbSCat3.DataSource = Nothing
    '    If cmbSCat2.SelectedIndex = -1 Then Exit Sub
    '    load_category(cmbSCat3, 3, cmbSCat2.SelectedValue)

    'End Sub

    'Private Sub cmbDeptNC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeptNC.SelectedIndexChanged

    '    cmbSCat1NC.DataSource = Nothing : cmbSCat2NC.DataSource = Nothing : cmbSCat3NC.DataSource = Nothing
    '    If cmbDeptNC.SelectedIndex = -1 Then Exit Sub
    '    load_category_2(cmbSCat1NC, 1, cmbDeptNC.SelectedValue)

    'End Sub

    'Private Sub cmbSCat1NC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat1NC.SelectedIndexChanged

    '    cmbSCat2NC.DataSource = Nothing : cmbSCat3NC.DataSource = Nothing
    '    If cmbSCat1NC.SelectedIndex = -1 Then Exit Sub
    '    load_category_2(cmbSCat2NC, 2, cmbSCat1NC.SelectedValue)

    'End Sub

    'Private Sub cmbSCat2NC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat2NC.SelectedIndexChanged

    '    cmbSCat3NC.DataSource = Nothing
    '    If cmbSCat2NC.SelectedIndex = -1 Then Exit Sub
    '    load_category_2(cmbSCat3NC, 3, cmbSCat2NC.SelectedValue)

    'End Sub

    'Private Sub load_department(iCmb As ComboBox)

    '    SQL = " select catid,catdesc from category order by catdesc"
    '    ESSA.LoadCombo(iCmb, SQL, "catdesc", "catid")

    'End Sub
    'Private Sub load_category(iCmb As ComboBox, iCatLvl As SByte, pvsCatID As Short)

    '    SQL = " select scatid,scatdesc from subcategory" & iCatLvl _
    '        & " where pvscatid=" & pvsCatID & " order by scatdesc"
    '    ESSA.LoadCombo(iCmb, SQL, "scatdesc", "scatid")

    'End Sub

    'Private Sub load_department_2(iCmb As ComboBox)

    '    SQL = " select catid,catdesc from category_new order by catdesc"
    '    ESSA.LoadCombo(iCmb, SQL, "catdesc", "catid")

    'End Sub
    'Private Sub load_category_2(iCmb As ComboBox, iCatLvl As SByte, pvsCatID As Short)

    '    SQL = " select scatid,scatdesc from subcategory" & iCatLvl & "_new" _
    '        & " where pvscatid=" & pvsCatID & " order by scatdesc"
    '    ESSA.LoadCombo(iCmb, SQL, "scatdesc", "scatid")

    'End Sub

    'Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click

    '    SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,L.CATDESC,L.SCATDESC1,L.SCATDESC2,L.SCATDESC3 FROM PRODUCTMASTER P,PRODUCTLEVELS L " _
    '        & "WHERE P.PLUID=L.PLUID AND L.CATID=" & cmbDept.SelectedValue

    '    SQL &= " AND L.ISUPDATED=0"

    '    If cmbSCat1.SelectedIndex > -1 Then
    '        SQL &= " AND L.SCATID1=" & cmbSCat1.SelectedValue
    '    End If

    '    If cmbSCat2.SelectedIndex > -1 Then
    '        SQL &= " AND L.SCATID2=" & cmbSCat2.SelectedValue
    '    End If

    '    If cmbSCat3.SelectedIndex > -1 Then
    '        SQL &= " AND L.SCATID3=" & cmbSCat3.SelectedValue
    '    End If

    '    SQL &= " ORDER BY P.PLUID"

    '    TG.Rows.Clear()
    '    With ESSA.OpenReader(SQL)
    '        While .Read
    '            TG.Rows.Add()
    '            TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
    '            TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
    '            TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
    '            TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
    '            TG.Item(4, TG.Rows.Count - 1).Value = .GetString(4).Trim
    '            TG.Item(5, TG.Rows.Count - 1).Value = .GetString(5).Trim
    '            TG.Item(6, TG.Rows.Count - 1).Value = .GetString(6).Trim
    '        End While
    '        .Close()
    '    End With

    'End Sub

    'Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    '    If TG.Rows.Count = 0 Then
    '        MsgBox("No products to update..!", MsgBoxStyle.Critical)
    '        Exit Sub
    '    End If

    '    If MsgBox("Do you want to update category..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

    '    Dim DeptID As Short = 0
    '    Dim SCatID1 As Short = 0
    '    Dim SCatID2 As Short = 0
    '    Dim SCatID3 As Short = 0
    '    Dim SCatID4 As Short = 0
    '    Dim SCatID5 As Short = 0

    '    Dim DeptNm As String = ""
    '    Dim SCatNm1 As String = ""
    '    Dim SCatNm2 As String = ""
    '    Dim SCatNm3 As String = ""
    '    Dim SCatNm4 As String = ""
    '    Dim SCatNm5 As String = ""

    '    Dim CatLink As String = ""

    '    DeptID = cmbDeptNC.SelectedValue
    '    SCatID1 = cmbSCat1NC.SelectedValue
    '    SCatID2 = cmbSCat2NC.SelectedValue
    '    SCatID3 = cmbSCat3NC.SelectedValue

    '    If DeptID > 0 Then
    '        CatLink = cmbDeptNC.Text.Trim & "->"
    '        DeptNm = cmbDeptNC.Text.Trim
    '    End If

    '    If SCatID1 > 0 Then
    '        CatLink &= cmbSCat1NC.Text.Trim & "->"
    '        SCatNm1 = cmbSCat1NC.Text.Trim
    '    End If

    '    If SCatID2 > 0 Then
    '        CatLink &= cmbSCat2NC.Text.Trim & "->"
    '        SCatNm2 = cmbSCat2NC.Text.Trim
    '    End If

    '    If SCatID3 > 0 Then
    '        CatLink &= cmbSCat3NC.Text.Trim & "->"
    '        SCatNm3 = cmbSCat3NC.Text.Trim
    '    End If

    '    If CatLink.Length > 0 Then
    '        CatLink = Mid(CatLink, 1, CatLink.Length - 2)
    '    End If

    '    ESSA.OpenConnection()
    '    Dim Cmd = Con.CreateCommand
    '    Dim Trn = Con.BeginTransaction
    '    Cmd.Transaction = Trn

    '    Try

    '        For i As Integer = 0 To TG.Rows.Count - 1

    '            SQL = "update productmaster set catlink='" _
    '                & CatLink & "',isupdated=1 where pluid=" _
    '                & Val(TG.Item(0, i).Value)

    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()

    '            SQL = "update productlevels set " _
    '                & "catid=" & DeptID & "," _
    '                & "catdesc='" & DeptNm & "'," _
    '                & "scatid1=" & SCatID1 & "," _
    '                & "scatdesc1='" & SCatNm1 & "'," _
    '                & "scatid2=" & SCatID2 & "," _
    '                & "scatdesc2='" & SCatNm2 & "'," _
    '                & "scatid3=" & SCatID3 & "," _
    '                & "scatdesc3='" & SCatNm3 & "'," _
    '                & "scatid4=" & SCatID4 & "," _
    '                & "scatdesc4='" & SCatNm4 & "'," _
    '                & "scatid5=" & SCatID5 & "," _
    '                & "scatdesc5='" & SCatNm5 & "'," _
    '                & "isupdated=1 where pluid=" _
    '                & Val(TG.Item(0, i).Value)

    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()

    '        Next

    '        Trn.Commit()
    '        Con.Close()

    '        MsgBox("Entry saved successfully..!", MsgBoxStyle.Exclamation)

    '    Catch ex As SqlException
    '        Trn.Rollback()
    '        Con.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub

    'Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

    '    load_department(cmbDept)
    '    load_department_2(cmbDeptNC)

    'End Sub

#End Region

#Region "FORM-OPERATIONS"

    Private Sub frmCategoryUpdaterNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '//LEFT-COMBOBOX-OPERATIONS
        LoadDepartment()
        LoadVendors()

        '// RIGHT-COMBOBOX-OPERATIONS
        LoadDepartmentNC()

        '//DATAVIEW-OPERATIONS
        TG.Columns(9).Width = TG.Width - 900

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub frmCategoryUpdaterNew_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlLoad, Me)

    End Sub

#End Region

#Region "LEFT-COMBOBOX-OPERATIONS"

    Private Sub LoadDepartment()

        SQL = "SELECT CATID,CATDESC FROM CATEGORY ORDER BY CATDESC"
        ESSA.LoadCombo(cmbDept, SQL, "CATDESC", "CATID")

    End Sub

    Private Sub LoadVendors()

        SQL = "SELECT VENDORID,VENDORNAME FROM VENDORS ORDER BY VENDORNAME"
        ESSA.LoadCombo(cmbVendor, SQL, "VENDORNAME", "VENDORID", "NO FILTER")

    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY1 WHERE PVSCATID={0}", cmbDept.SelectedValue)
        ESSA.LoadCombo(cmbSCat1, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat1.SelectedIndexChanged

        SQL = "SELECT SCATID,SCATDESC FROM SUBCATEGORY2"
        If cmbSCat1.SelectedIndex > 0 Then
            SQL &= " WHERE PVSCATID=" & cmbSCat1.SelectedValue
        End If
        SQL &= " ORDER BY SCATDESC"

        ESSA.LoadCombo(cmbSCat2, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat2.SelectedIndexChanged

        SQL = "SELECT SCATID,SCATDESC FROM SUBCATEGORY3"
        If cmbSCat2.SelectedIndex > 0 Then
            SQL &= " WHERE PVSCATID=" & cmbSCat2.SelectedValue
        End If
        SQL &= " ORDER BY SCATDESC"

        ESSA.LoadCombo(cmbSCat3, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat3.SelectedIndexChanged

        SQL = "SELECT SCATID,SCATDESC FROM SUBCATEGORY4"
        If cmbSCat3.SelectedIndex > 0 Then
            SQL &= " WHERE PVSCATID=" & cmbSCat3.SelectedValue
        End If
        SQL &= " ORDER BY SCATDESC"

        ESSA.LoadCombo(cmbSCat4, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Function GenerateQuery(ISLeftSide As Boolean) As String

        If ISLeftSide = True Then

            GenerateQuery = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,L.CATDESC,L.SCATDESC1,L.SCATDESC2,L.SCATDESC3,L.SCATDESC4,V.VENDORNAME FROM PRODUCTMASTER P,PRODUCTLEVELS L,VENDORS V " _
                & "WHERE P.VENDORID=V.VENDORID AND P.PLUID=L.PLUID AND L.CATID=" & cmbDept.SelectedValue

            GenerateQuery &= " AND L.ISUPDATED=0"

            If cmbSCat1.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID1=" & cmbSCat1.SelectedValue
            End If

            If cmbSCat2.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID2=" & cmbSCat2.SelectedValue
            End If

            If cmbSCat3.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID3=" & cmbSCat3.SelectedValue
            End If

            If cmbSCat4.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID4=" & cmbSCat4.SelectedValue
            End If

            If cmbVendor.SelectedIndex > 0 Then
                GenerateQuery &= " AND P.VENDORID=" & cmbVendor.SelectedValue
            End If

            GenerateQuery &= " ORDER BY P.PLUID"

        Else

            GenerateQuery = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,L.CATDESC,L.SCATDESC1,L.SCATDESC2,L.SCATDESC3,L.SCATDESC4,V.VENDORNAME FROM PRODUCTMASTER P,PRODUCTLEVELS L,VENDORS V " _
                          & "WHERE P.VENDORID=V.VENDORID AND P.PLUID=L.PLUID AND L.CATID=" & cmbDeptNC.SelectedValue

            GenerateQuery &= " AND L.ISUPDATED=1"

            If cmbSCat1NC.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID1=" & cmbSCat1NC.SelectedValue
            End If

            If cmbSCat2NC.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID2=" & cmbSCat2NC.SelectedValue
            End If

            If cmbSCat3NC.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID3=" & cmbSCat3NC.SelectedValue
            End If

            If cmbSCat4NC.SelectedIndex > 0 Then
                GenerateQuery &= " AND L.SCATID4=" & cmbSCat4NC.SelectedValue
            End If

            'If cmbVendor.SelectedIndex > 0 Then
            '    GenerateQuery &= " AND P.VENDORID=" & cmbVendor.SelectedValue
            'End If

            GenerateQuery &= " ORDER BY P.PLUID"

        End If

    End Function

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click

        pnlLoad.Show() : pnlLoad.Refresh()

        SQL = GenerateQuery(Not chkSUC.Checked)

        TG.Visible = False

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(4).Trim
                TG.Item(5, TG.Rows.Count - 1).Value = .GetString(5).Trim
                TG.Item(6, TG.Rows.Count - 1).Value = .GetString(6).Trim
                TG.Item(7, TG.Rows.Count - 1).Value = .GetString(7).Trim
                TG.Item(8, TG.Rows.Count - 1).Value = .GetString(8).Trim
                TG.Item(9, TG.Rows.Count - 1).Value = .GetString(9).Trim
            End While
            .Close()
        End With

        TG.Visible = True
        pnlLoad.Hide()

    End Sub

#End Region

#Region "RIGHT-COMBOBOX-OPERATIONS"

    Dim TempSCat1 As Short = 0
    Dim TempSCat2 As Short = 0
    Dim TempSCat3 As Short = 0

    Private Sub LoadDepartmentNC()

        SQL = "SELECT CATID,CATDESC FROM CATEGORY_NEW ORDER BY CATDESC"
        ESSA.LoadCombo(cmbDeptNC, SQL, "CATDESC", "CATID")

    End Sub

    Private Sub cmbDeptNC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeptNC.SelectedIndexChanged

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY1_NEW WHERE DEPTID={0}", cmbDeptNC.SelectedValue)
        ESSA.LoadCombo(cmbSCat1NC, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat1NC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat1NC.SelectedIndexChanged

        If cmbSCat1NC.SelectedIndex = -1 Then Exit Sub

        If Not IsDBNull(cmbSCat1NC.SelectedValue) Then
            TempSCat1 = cmbSCat1NC.SelectedValue
        End If

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY2_NEW WHERE DEPTID={0} AND PVSCATID1={1}", cmbDeptNC.SelectedValue, TempSCat1)
        ESSA.LoadCombo(cmbSCat2NC, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat2NC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat2NC.SelectedIndexChanged

        If cmbSCat2NC.SelectedIndex = -1 Then Exit Sub

        If Not IsDBNull(cmbSCat2NC.SelectedValue) Then
            TempSCat2 = cmbSCat2NC.SelectedValue
        End If

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY3_NEW WHERE DEPTID={0} AND PVSCATID1={1} AND PVSCATID2={2}", cmbDeptNC.SelectedValue, TempSCat1, TempSCat2)
        ESSA.LoadCombo(cmbSCat3NC, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub cmbSCat3NC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat3NC.SelectedIndexChanged

        If cmbSCat3NC.SelectedIndex = -1 Then Exit Sub

        If Not IsDBNull(cmbSCat3NC.SelectedValue) Then
            TempSCat3 = cmbSCat3NC.SelectedValue
        End If

        SQL = String.Format("SELECT SCATID,SCATDESC FROM SUBCATEGORY4_NEW WHERE DEPTID={0} AND PVSCATID1={1} AND PVSCATID2={2} AND PVSCATID2={3}", cmbDeptNC.SelectedValue, TempSCat1, TempSCat2, TempSCat3)
        ESSA.LoadCombo(cmbSCat4NC, SQL, "SCATDESC", "SCATID", "NO FILTER")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If TG.Rows.Count = 0 Then
            MsgBox("No products to update..!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Do you want to update category..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim DeptID As Short = 0
        Dim SCatID1 As Short = 0
        Dim SCatID2 As Short = 0
        Dim SCatID3 As Short = 0
        Dim SCatID4 As Short = 0
        Dim SCatID5 As Short = 0

        Dim DeptNm As String = ""
        Dim SCatNm1 As String = ""
        Dim SCatNm2 As String = ""
        Dim SCatNm3 As String = ""
        Dim SCatNm4 As String = ""
        Dim SCatNm5 As String = ""

        Dim CatLink As String = ""

        DeptID = cmbDeptNC.SelectedValue
        SCatID1 = cmbSCat1NC.SelectedValue
        SCatID2 = cmbSCat2NC.SelectedValue
        SCatID3 = cmbSCat3NC.SelectedValue
        SCatID4 = cmbSCat4NC.SelectedValue

        If DeptID > 0 Then
            CatLink = cmbDeptNC.Text.Trim & "->"
            DeptNm = cmbDeptNC.Text.Trim
        End If

        If SCatID1 > 0 Then
            CatLink &= cmbSCat1NC.Text.Trim & "->"
            SCatNm1 = cmbSCat1NC.Text.Trim
        End If

        If SCatID2 > 0 Then
            CatLink &= cmbSCat2NC.Text.Trim & "->"
            SCatNm2 = cmbSCat2NC.Text.Trim
        End If

        If SCatID3 > 0 Then
            CatLink &= cmbSCat3NC.Text.Trim & "->"
            SCatNm3 = cmbSCat3NC.Text.Trim
        End If

        If SCatID4 > 0 Then
            CatLink &= cmbSCat4NC.Text.Trim & "->"
            SCatNm4 = cmbSCat4NC.Text.Trim
        End If

        If CatLink.Length > 0 Then
            CatLink = Mid(CatLink, 1, CatLink.Length - 2)
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As Integer = 0 To TG.Rows.Count - 1

                SQL = "update productmaster set catlink='" _
                    & CatLink & "',isupdated=1 where pluid=" _
                    & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                SQL = "update productlevels set " _
                    & "catid=" & DeptID & "," _
                    & "catdesc='" & DeptNm & "'," _
                    & "scatid1=" & SCatID1 & "," _
                    & "scatdesc1='" & SCatNm1 & "'," _
                    & "scatid2=" & SCatID2 & "," _
                    & "scatdesc2='" & SCatNm2 & "'," _
                    & "scatid3=" & SCatID3 & "," _
                    & "scatdesc3='" & SCatNm3 & "'," _
                    & "scatid4=" & SCatID4 & "," _
                    & "scatdesc4='" & SCatNm4 & "'," _
                    & "scatid5=" & SCatID5 & "," _
                    & "scatdesc5='" & SCatNm5 & "'," _
                    & "isupdated=1 where pluid=" _
                    & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

            MsgBox("Entry saved successfully..!", MsgBoxStyle.Exclamation)

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

#End Region



End Class