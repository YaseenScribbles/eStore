'****************************************** Bismillah *************************************
Imports System.Data.SqlClient
Public Class Vendors2

    Private VendorID As Short
    Private Edit As Boolean = False
    Private AgentID As Short = 0
    Private BankPanelVisited As Boolean = False
    Private TblLst As New DataTable

    Private Sub LoadVendorList()

        SQL = "SELECT VENDORID,VENDORCODE,VENDORNAME FROM VENDORS ORDER BY VENDORNAME"

        TblLst.Clear()
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Adp.Fill(TblLst)
        End Using
        Con.Close()

    End Sub

    Private Sub Vendors_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F8

                txtVCode.Focus()

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                If pnlList.Visible = True Then pnlList.Visible = False : Exit Sub
                If pnlBankDetails.Visible = True Then pnlBankDetails.Visible = False : Exit Sub
                btnClose.PerformClick()

        End Select

    End Sub

    Private Sub Vendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each ctl As Control In Me.Controls

            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then

                AddHandler ctl.Enter, AddressOf Control_Enter
                AddHandler ctl.Leave, AddressOf Control_Leave

            End If

        Next

        SQL = "SELECT AGENTID,AGENTNAME FROM AGENTS ORDER BY AGENTNAME"
        ESSA.LoadCombo(cmbVGroup, SQL, "AGENTNAME", "AGENTID")

        SQL = "SELECT DISTINCT STATE FROM VENDORS WHERE LEN(STATE)>0 ORDER BY STATE"
        ESSA.LoadCombo(cmbState, SQL, "STATE", "")

        SQL = "SELECT DISTINCT COUNTRY FROM VENDORS WHERE LEN(COUNTRY)>0 ORDER BY COUNTRY"
        ESSA.LoadCombo(cmbCountry, SQL, "COUNTRY", "")

        SQL = "SELECT DISTINCT BANK FROM VENDORS WHERE LEN(BANK)>0 ORDER BY BANK"
        ESSA.LoadCombo(cmbBank, SQL, "BANK")

        cmbDR.SelectedIndex = 0

    End Sub

    Private Sub Control_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CType(sender, Control).BackColor = Color.LightYellow

    End Sub

    Private Sub Control_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CType(sender, Control).BackColor = SystemColors.Window

    End Sub

    Private Sub GenerateVendorID()

        SQL = "SELECT MAX(VENDORID) FROM VENDORS"
        VendorID = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SQL = "select vendorid from vendors where vendorname='" & txtVName.Text.Trim & "'" & IIf(Edit = True, " and vendorid<>" & VendorID, "")

        If txtVName.Text.Trim = "" Then
            txtVName.Focus()
            MsgBox("Vendor name cannot be blank..!", vbCritical)
            Exit Sub
        ElseIf ESSA.ISFound("Select vendorid from vendors where vendorname='" & txtVName.Text.Trim & "'" & IIf(Edit = True, " and vendorid<>" & VendorID, "")) = True Then
            MsgBox("Vendor name already exists..!", vbCritical)
            txtVName.Focus()
            Exit Sub
        End If

        'If BankPanelVisited = False Then
        '    pnlBankDetails.Visible = True
        '    cmbBank.Focus()
        '    Exit Sub
        'End If

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "DELETE FROM VENDORS WHERE VENDORID=" & VendorID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateVendorID()
            End If

            SQL = "INSERT INTO VENDORS VALUES (" _
                & VendorID & ",'" _
                & txtVCode.Text & "','" _
                & txtVName.Text & "'," _
                & cmbVGroup.SelectedValue & ",'" _
                & txtAdd1.Text & "','" _
                & txtAdd2.Text & "','','" _
                & txtCity.Text & "','" _
                & cmbState.Text & "','INDIA','" _
                & txtPhone.Text & "','" _
                & txtMobile.Text & "','" _
                & txtWhatApp.Text & "','" _
                & txtEmail.Text & "','" _
                & txtTIN.Text & "','" _
                & txtCST.Text & "',0,'" _
                & Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & ShopID & "," _
                & UserID & ",'" _
                & txtGST.Text.Trim & "','" _
                & txtPAN.Text.Trim & "','" _
                & cmbBank.Text.Trim & "','" _
                & txtACNo.Text.Trim & "','" _
                & txtACName.Text.Trim & "','" _
                & txtIFSC.Text.Trim & "','" _
                & txtBranch.Text.Trim & "'," _
                & Val(txtOBal.Text) & "," _
                & Val(txtCLimit.Text) & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("Entry saved successfully..!", vbExclamation)
            RefreshForms()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub

    'Private Sub btnBank_Click(sender As Object, e As EventArgs) Handles btnBank.Click

    '    pnlBankDetails.Visible = True
    '    cmbBank.Focus()

    'End Sub

    Private Sub txtCLimit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCLimit.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If

    End Sub

    Private Sub btnHide2_Click(sender As Object, e As EventArgs) Handles btnHide2.Click

        pnlBankDetails.Visible = False

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        BankPanelVisited = True
        pnlBankDetails.Visible = False
        btnSave.PerformClick()

    End Sub

    Private Sub RefreshForms()

        pnlBankDetails.Visible = False
        pnlList.Visible = False
        BankPanelVisited = False
        lblEdit.Visible = False
        Edit = False
        'ESSA.ClearTextBox(pMain)
        ESSA.ClearTextBox(Me)
        ESSA.ClearTextBox(pnlBankDetails)
        txtVCode.Focus()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        RefreshForms()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        'pnlLoading.Visible = True
        'pnlLoading.Refresh()

        pnlList.Left = 0
        pnlList.Top = 0
        pnlList.Width = Me.Width
        pnlList.Height = Me.Height - 33

        TGLst.SuspendLayout()

        SQL = "SELECT VENDORID,VENDORCODE,VENDORNAME FROM VENDORS ORDER BY VENDORNAME"
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

        pnlList.Visible = True
        txtFind.Focus()

        'pnlLoading.Visible = False
        'pnlList.Visible = True
        'txtFind.Focus()

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp

        If e.KeyCode = Keys.Down Then
            If TGLst.CurrentRow.Index = TGLst.Rows.Count - 1 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index + 1)
        ElseIf e.KeyCode = Keys.Up Then
            If TGLst.CurrentRow.Index = 0 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index - 1)
        ElseIf e.KeyCode <> Keys.Enter Then
            SQL = String.Format("SELECT VENDORID,VENDORCODE,VENDORNAME FROM VENDORS WHERE VENDORNAME Like '%{0}%' ORDER BY VENDORNAME", txtFind.Text)
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
            txtVCode.Focus()
        End If

    End Sub

    Public Sub EditVendor(IVendorID As Short)

        SQL = "SELECT * FROM VENDORS WHERE VENDORID=" & IVendorID
        With ESSA.OpenReader(SQL)
            If .Read Then

                Edit = True
                VendorID = .Item(0)
                txtVCode.Text = .GetString(1).Trim
                txtVName.Text = .GetString(2).Trim
                cmbVGroup.SelectedValue = .Item(3)
                txtAdd1.Text = .GetString(4).Trim
                txtAdd2.Text = .GetString(5).Trim
                txtCity.Text = .GetString(7).Trim
                cmbState.Text = .GetString(8).Trim
                txtPhone.Text = .GetString(10).Trim
                txtMobile.Text = .GetString(11).Trim
                txtWhatApp.Text = .GetString(12).Trim
                txtEmail.Text = .GetString(13).Trim
                txtTIN.Text = .GetString(14).Trim
                txtCST.Text = .GetString(15).Trim
                txtGST.Text = .GetString(20).Trim
                txtPAN.Text = .GetString(21).Trim
                cmbBank.Text = .GetString(22).Trim
                txtACNo.Text = .GetString(23).Trim
                txtACName.Text = .GetString(24).Trim
                txtIFSC.Text = .GetString(25).Trim
                txtBranch.Text = .GetString(26).Trim
                txtOBal.Text = Format(.Item(27), "0.00")
                txtCLimit.Text = .Item(28)

            End If
            .Close()
        End With

    End Sub

    Private Sub TGLst_KeyDown(sender As Object, e As KeyEventArgs) Handles TGLst.KeyDown

        txtFind_KeyDown(sender, e)

    End Sub


    'Private Sub vendors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    '    Select Case e.KeyCode

    '        Case Keys.Escape
    '            btnClose.PerformClick()
    '        Case Keys.Enter
    '            If TypeOf Me.ActiveControl Is cTextBox And Me.ActiveControl.Tag <> "1" Then
    '                If CType(Me.ActiveControl, cTextBox).AcceptEmptyWords = False And Me.ActiveControl.Text.Trim = "" Then Exit Sub
    '                e.SuppressKeyPress = True
    '                Me.ProcessTabKey(True)
    '            End If
    '        Case Keys.Back
    '            If Me.ActiveControl.Text.Trim = "" And CType(Me.ActiveControl, cTextBox).AcceptBackwards = True Then
    '                Me.ProcessTabKey(False)
    '            End If

    '    End Select

    'End Sub

    'Private Sub vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    'Line1.Width = Me.Width - 25
    '    'GenerateVendorID()
    '    LoadDetails()
    '    txtVendorCode.Select()

    'End Sub

    'Private Sub LoadDetails()

    '    SQL = "select agentid,agentname from agents order by agentname"
    '    LstAgt.LoadListItems(SQL, "agentname", "agentid")
    '    'ESSA.LoadCombo(cmbAgent, SQL, "agentname", "agentid")

    '    'SQL = "select vendorid,vendorcode,vendorname from vendors order by vendorid"
    '    'ESSA.LoadDataGrid(TG, SQL)
    '    'TG.Columns(0).Visible = False
    '    'TG.Columns(1).Width = 60
    '    'TG.Columns(2).Width = 244

    'End Sub


    'Private Sub txtAgent_Enter(sender As Object, e As EventArgs) Handles txtAgent.Enter

    '    LstAgt.Visible = True

    'End Sub

    'Private Sub txtAgent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAgent.KeyDown

    '    If e.KeyCode = Keys.Down Then
    '        LstAgt.ChangeSelection(True)
    '    ElseIf e.KeyCode = Keys.Up Then
    '        LstAgt.ChangeSelection(False)
    '    ElseIf e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True
    '        If LstAgt.Lst.SelectedIndex = -1 Then Exit Sub
    '        AgentID = LstAgt.Lst.SelectedValue
    '        txtAgent.Text = LstAgt.Lst.Text
    '        Me.ProcessTabKey(True)
    '    End If

    'End Sub

    'Private Sub txtAgent_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAgent.KeyUp

    '    If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then

    '    ElseIf e.KeyCode <> Keys.Enter Then
    '        LstAgt.FilterListItems(txtAgent.Text)
    '    End If

    'End Sub

    'Private Sub txtAgent_Leave(sender As Object, e As EventArgs) Handles txtAgent.Leave

    '    LstAgt.Visible = False

    'End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    '    If txtVendorCode.Text.Trim = "" Then
    '        txtVendorCode.Focus()
    '        Exit Sub
    '    ElseIf txtVendorName.Text.Trim = "" Then
    '        txtVendorName.Focus()
    '        Exit Sub
    '    ElseIf ESSA.ISFound("select vendorid from vendors where vendorcode='" & txtVendorCode.Text.Trim & "'" & IIf(Edit = True, " and vendorid<>" & VendorID, "")) = True Then
    '        xMessage.ShowMsg("Duplicate Code", False, pnlWS, 100)
    '        txtVendorCode.Focus()
    '        Exit Sub
    '    ElseIf ESSA.ISFound("select vendorid from vendors where vendorname='" & txtVendorName.Text.Trim & "'" & IIf(Edit = True, " and vendorid<>" & VendorID, "")) = True Then
    '        xMessage.ShowMsg("Duplicate Name", False, pnlWS, 100)
    '        txtVendorName.Focus()
    '        Exit Sub
    '    End If

    '    If xMessage.ShowMsg("Do you want to save..?", True, pnlWS, 100) = False Then Exit Sub

    '    ESSA.OpenConnection()
    '    Dim Cmd = Con.CreateCommand
    '    Dim Trn = Con.BeginTransaction
    '    Cmd.Transaction = Trn

    '    Try

    '        If Edit = True Then
    '            SQL = "delete from vendors where VendorID=" & VendorID
    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()
    '        Else
    '            GenerateVendorID()
    '        End If

    '        SQL = "insert into vendors values (" _
    '            & VendorID & ",'" _
    '            & txtVendorCode.Text & "','" _
    '            & txtVendorName.Text & "'," _
    '            & AgentID & ",'" _
    '            & txtAddress1.Text & "','" _
    '            & txtAddress2.Text & "','','" _
    '            & txtCity.Text & "','" _
    '            & txtState.Text & "','INDIA','" _
    '            & txtPhone.Text & "','" _
    '            & txtMobile.Text & "','" _
    '            & txtFax.Text & "','" _
    '            & txtEmail.Text & "','" _
    '            & txtVAT.Text & "','" _
    '            & txtCST.Text & "',0,'" _
    '            & Format(Now.Date, "yyyy-MM-dd hh:mm:ssss") & "'," _
    '            & ShopID & "," _
    '            & UserID & ")"

    '        Cmd.CommandText = SQL
    '        Cmd.ExecuteNonQuery()

    '        Trn.Commit()
    '        Con.Close()
    '        'xMessage .ShowMsg   ("New vendor has been created successfully..!", "Congratualtions..!", xMessageBox.MessageBoxStyle.OKOnly)
    '        RefreshForms()

    '    Catch ex As SqlException
    '        Trn.Rollback()
    '        Con.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub

    'Private Sub RefreshForms()

    '    Edit = False
    '    ESSA.ClearTextBox(pnlWS)
    '    txtVendorCode.Focus()

    'End Sub

    'Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

    '    'If xMessage.ShowMsg("Do you want to exit..?", True, pnlWS, 100) = False Then Exit Sub
    '    MainWindowX.CloseTab(Me.Name)

    'End Sub

    ''Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

    ''    LoadDetails()
    ''    RefreshForms()

    ''End Sub

    '''Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown, txtName.KeyDown

    '''    If e.KeyCode = Keys.Enter Then
    '''        TG_KeyDown(sender, e)
    '''    End If

    '''End Sub

    '''Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

    '''    If e.KeyCode = Keys.Down Then
    '''        TG.Focus()
    '''    ElseIf e.KeyCode <> Keys.Enter Then
    '''        'ESSA.FindAndSelect(TG, 1, txtCode.Text)
    '''    End If

    '''End Sub

    ''Private Sub txtName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp

    ''    If e.KeyCode = Keys.Down Then
    ''        TG.Focus()
    ''    ElseIf e.KeyCode <> Keys.Enter Then
    ''        ESSA.FindAndSelect(TG, 2, txtName.Text)
    ''    End If

    ''End Sub

    'Public Sub EditVendor(VendorID As Short)

    '    SQL = "select * from vendors where vendorid=" & VendorID
    '    With ESSA.OpenReader(SQL)
    '        If .Read Then

    '            Edit = True
    '            VendorID = .Item(0)
    '            txtVendorCode.Text = .GetString(1).Trim
    '            txtVendorName.Text = .GetString(2).Trim
    '            AgentID = .Item(3)
    '            LstAgt.Lst.SelectedValue = AgentID
    '            txtAgent.Text = LstAgt.Lst.Text
    '            txtAddress1.Text = .GetString(4).Trim
    '            txtAddress2.Text = .GetString(5).Trim
    '            txtCity.Text = .GetString(7).Trim
    '            txtState.Text = .GetString(8).Trim
    '            txtPhone.Text = .GetString(10).Trim
    '            txtMobile.Text = .GetString(11).Trim
    '            txtFax.Text = .GetString(12).Trim
    '            txtEmail.Text = .GetString(13).Trim
    '            txtVAT.Text = .GetString(14).Trim
    '            txtCST.Text = .GetString(15).Trim


    '        End If
    '        .Close()
    '    End With

    'End Sub

    ''Private Sub TG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyDown

    ''    If e.KeyCode = Keys.Enter Then
    ''        e.SuppressKeyPress = True



    ''        'txtCode.Clear()
    ''        txtName.Clear()
    ''        txtVendorCode.Focus()

    ''    End If

    ''End Sub

    ''Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick



    ''End Sub

    ''Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    ''    pnlSearch.Visible = False
    ''    txtVendorCode.Focus()

    ''End Sub

    ''Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    ''    pnlSearch.Visible = True
    ''    txtName.Focus()

    ''End Sub

    'Private Sub txtCST_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCST.KeyDown

    '    If e.KeyCode = Keys.Enter Then btnSave.PerformClick()

    'End Sub

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    '    MainWindowX.AddTab(VendorList)

    'End Sub

    Private Sub txtCLimit_TextChanged(sender As Object, e As EventArgs) Handles txtCLimit.TextChanged

    End Sub
End Class