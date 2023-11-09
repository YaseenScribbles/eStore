Imports System.Data.SqlClient

Public Class Customer

    'Private CustID As Short = 0
    'Private Edit As Boolean = False

    'Private Sub GenerateCustID()

    '    SQL = "select max(customerid) from customers"
    '    CustID = ESSA.GenerateID(SQL)
    '    txtCustCode.Text = "C" & CustID

    'End Sub

    'Private Sub RefreshForms()

    '    Edit = False
    '    ESSA.ClearTextBox(Panel3)
    '    GenerateCustID()
    '    txtCustName.Focus()

    'End Sub

    'Private Sub LoadCustomers()

    '    TG.Rows.Clear()

    '    SQL = "select customerid,customercode,customername from customers order by customerid"
    '    With ESSA.OpenReader(SQL)
    '        While .Read
    '            TG.Rows.Add()
    '            TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
    '            TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
    '            TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
    '        End While
    '        .Close()
    '    End With

    'End Sub

    'Private Sub Customer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    '    Select Case e.KeyCode

    '        Case Keys.F2
    '            btnSave.PerformClick()
    '        Case Keys.F5
    '            btnReset.PerformClick()
    '        Case Keys.Escape
    '            Close()
    '        Case Keys.Enter
    '            If Me.ActiveControl.Tag <> "1" Then
    '                e.SuppressKeyPress = True
    '                Me.ProcessTabKey(True)
    '            End If

    '    End Select

    'End Sub

    'Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    LoadCustomers()
    '    GenerateCustID()
    '    txtCustName.Select()

    'End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    '    If txtCustName.Text.Trim = "" Then
    '        TTip.Show("Customer name should be empty..!", txtCustName, 0, 25, 2000)
    '        txtCustName.Focus()
    '        Exit Sub
    '    End If

    '    ESSA.OpenConnection()
    '    Dim Cmd = Con.CreateCommand
    '    Dim Trn = Con.BeginTransaction
    '    Cmd.Transaction = Trn

    '    Try

    '        If Edit = True Then
    '            SQL = "delete from customers where customerid=" & CustID
    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()
    '        Else
    '            GenerateCustID()
    '        End If

    '        SQL = "insert into customers values (" _
    '            & CustID & ",'" _
    '            & txtCustCode.Text.Trim & "','" _
    '            & txtCustName.Text.Trim & "','" _
    '            & txtAddress1.Text.Trim & "','" _
    '            & txtAddress2.Text.Trim & "','" _
    '            & txtCity.Text.Trim & "','" _
    '            & txtState.Text.Trim & "','" _
    '            & txtCountry.Text.Trim & "','" _
    '            & txtPhone.Text.Trim & "','" _
    '            & txtMobile.Text.Trim & "','" _
    '            & txtEmail.Text.Trim & "',0,'" _
    '            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
    '            & ShopID & "," _
    '            & UserID & ")"

    '        Cmd.CommandText = SQL
    '        Cmd.ExecuteNonQuery()

    '        Trn.Commit()
    '        Con.Close()

    '    Catch ex As Exception
    '        Trn.Rollback()
    '        Con.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        Exit Sub
    '    End Try

    '    MsgBox("New customer has been save successfully..!", vbExclamation)
    '    RefreshForms()

    'End Sub

    'Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

    '    LoadCustomers()
    '    RefreshForms()

    'End Sub

    'Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

    '    If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    MainWindowX.CloseTab(Me.Name)

    'End Sub

    'Private Sub txtFindCust_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindCust.KeyDown

    '    TG_KeyDown(sender, e)

    'End Sub

    'Private Sub txtFindCust_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindCust.KeyUp

    '    If e.KeyCode = Keys.Down Then
    '        TG.Focus()
    '    ElseIf e.KeyCode <> Keys.Enter Then
    '        ESSA.FindAndSelect(TG, 2, txtFindCust.Text)
    '    End If

    'End Sub

    'Private Sub TG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyDown

    '    If e.KeyCode = Keys.Enter Then

    '    End If

    'End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private CUSTOMERID As Short
    Private Edit As Boolean = False

    Private Sub CUSTOMERS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape
                If pnlList.Visible = True Then pnlList.Visible = False : Exit Sub
                If (MsgBox("Exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No) Then Exit Sub
                MainWindowX.CloseTab(Me.Name)

        End Select

    End Sub

    Private Sub CUSTOMERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateCUSTOMERID()

        ESSA.LoadCombo(cmbState, "SELECT DISTINCT STATE FROM CUSTOMERS ORDER BY STATE", "STATE")

    End Sub

    Private Sub GenerateCUSTOMERID()

        SQL = "select max(CUSTOMERID) from CUSTOMERS"
        CUSTOMERID = ESSA.GenerateID(SQL)

        txtCustCode.Text = "C" & Format(CUSTOMERID, "00")

        ESSA.LoadCombo(cmbState, "SELECT DISTINCT STATE FROM CUSTOMERS ORDER BY STATE", "STATE")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtVName.Text.Trim = "" Then
            xMessage.ShowMsg("Customer name cannot be empty..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            txtVName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select CUSTOMERID from CUSTOMERS where LocationId = " & ShopID & " AND CustomerName='" & txtVName.Text.Trim & "'" & IIf(Edit = True, " and CUSTOMERID<>" & CUSTOMERID, "")) = True Then
            xMessage.ShowMsg("Customer name already exists..!", False, frmMainScreen, 0, xMessage.MsgStyle.iError)
            txtVName.Focus()
            Exit Sub
        End If

        If xMessage.ShowMsg("Do you want to save..?", True, frmMainScreen, 0, xMessage.MsgStyle.Question) = False Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from CUSTOMERS where CUSTOMERID=" & CUSTOMERID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateCUSTOMERID()
            End If

            SQL = "insert into CUSTOMERS values (" _
                & CUSTOMERID & ",'" _
                & txtCustCode.Text & "','" _
                & txtVName.Text & "','" _
                & txtAdd1.Text & "','" _
                & txtAdd2.Text & "','" _
                & txtCity.Text & "','" _
                & cmbState.Text & "','INDIA','" _
                & txtPhone.Text & "','" _
                & txtMobile.Text & "','" _
                & txtEmail.Text & "', " _
                & IIf(chkIsReceivable.Checked, 1, 0) & ",0,'" _
                & Format(Now.Date, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

            xMessage.ShowMsg("Entry save successfully..!", False, frmMainScreen, 0, xMessage.MsgStyle.Exclamation)
            RefreshForms()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp

        If e.KeyCode = Keys.Down Then
            If TGLst.CurrentRow.Index = TGLst.Rows.Count - 1 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index + 1)
        ElseIf e.KeyCode = Keys.Up Then
            If TGLst.CurrentRow.Index = 0 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index - 1)
        ElseIf e.KeyCode <> Keys.Enter Then
            SQL = String.Format("SELECT CUSTOMERID,CUSTOMERCODE,CustomerName FROM CUSTOMERS WHERE LocationId = {1} CustomerName Like '%{0}%' ORDER BY CustomerName", txtFind.Text, ShopID)
            With ESSA.OpenReader(SQL)
                TGLst.Rows.Clear()
                While .Read
                    TGLst.Rows.Add()
                    TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                    TGLst.Item(1, TGLst.Rows.Count - 1).Value = .GetString(1).Trim
                    TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
                End While
                .Close()
            End With
        End If

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If TGLst.Rows.Count = 0 Then Exit Sub
            EditVendor(Val(TGLst.Item(0, TGLst.CurrentRow.Index).Value))
            lblEdit.Visible = True
            pnlList.Visible = False
            txtVName.Focus()
        End If

    End Sub

    Public Sub EditVendor(VendorID As Short)

        SQL = "SELECT * FROM CUSTOMERS WHERE CUSTOMERID=" & VendorID
        With ESSA.OpenReader(SQL)
            If .Read Then

                Edit = True
                CUSTOMERID = .Item(0)
                txtCustCode.Text = .GetString(1).Trim
                txtVName.Text = .GetString(2).Trim
                txtAdd1.Text = .GetString(3).Trim
                txtAdd2.Text = .GetString(4).Trim
                txtCity.Text = .GetString(5).Trim
                cmbState.Text = .GetString(6).Trim
                txtPhone.Text = .GetString(8).Trim
                txtMobile.Text = .GetString(9).Trim
                txtEmail.Text = .GetString(10).Trim
                chkIsReceivable.Checked = IIf(Val(.Item(11)) = 1, True, False)

            End If
            .Close()
        End With

    End Sub

    Private Sub RefreshForms()

        lblEdit.Visible = False
        Edit = False
        chkIsReceivable.Checked = Edit
        ESSA.ClearTextBox(Me)
        GenerateCUSTOMERID()
        txtCustCode.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        RefreshForms()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        'pnlLoading.Visible = True
        'pnlLoading.Refresh()

        TGLst.SuspendLayout()

        SQL = "SELECT CUSTOMERID,ISNULL(CUSTOMERCODE,''),ISNULL(CustomerName,'') FROM CUSTOMERS WHERE LocationId = " & ShopID & " ORDER BY CustomerName"
        With ESSA.OpenReader(SQL)
            TGLst.Rows.Clear()
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = .GetString(1).Trim
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
            End While
            .Close()
        End With

        TGLst.ResumeLayout()

        'pnlLoading.Visible = False
        pnlList.Visible = True
        txtFind.Focus()

    End Sub

    Private Sub CUSTOMERS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If xMessage.ShowMsg("Do you want to exit..?", True, frmMainScreen, 0, xMessage.MsgStyle.iExit) = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Sub TGLst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGLst.CellContentClick

    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub
End Class