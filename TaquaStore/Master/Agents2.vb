'************************************ Bismillah ****************************************
Imports System.Data.SqlClient
Public Class Agents2
    Inherits Form

    Private Sub Agents_Move(sender As Object, e As EventArgs) Handles Me.Move

        Me.Left = 0
        Me.Top = 0

    End Sub

    Private AgentID As Short
    Private Edit As Boolean = False

    Private Sub Agents_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                If pnlList.Visible = True Then pnlList.Visible = False : Exit Sub
                btnHidePnl.PerformClick()

        End Select

    End Sub

    Private Sub Agents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        For Each ctl As Control In Me.Controls

            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then

                AddHandler ctl.Enter, AddressOf Control_Enter
                AddHandler ctl.Leave, AddressOf Control_Leave

            End If

        Next

        GenerateAgentID()
        txtComm.Select()

    End Sub

    Private Sub Control_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CType(sender, Control).BackColor = Color.LightYellow

    End Sub

    Private Sub Control_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CType(sender, Control).BackColor = SystemColors.Window

    End Sub

    Private Sub GenerateAgentID()

        SQL = "select max(agentid) from agents"
        AgentID = ESSA.GenerateID(SQL)

        txtAgentCode.Text = "AT" & Format(AgentID, "00")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtVName.Text.Trim = "" Then
            MsgBox("Agent name cannot be empty..!", vbCritical)
            txtVName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select agentid from agents where agentname='" & txtVName.Text.Trim & "'" & IIf(Edit = True, " and agentid<>" & AgentID, "")) = True Then
            MsgBox("Agent name already exists..!", vbCritical)
            txtVName.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from agents where agentid=" & AgentID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateAgentID()
            End If

            SQL = "insert into Agents values (" _
                & AgentID & ",'" _
                & txtAgentCode.Text & "','" _
                & txtVName.Text & "','" _
                & txtAdd1.Text & "','" _
                & txtAdd2.Text & "','" _
                & txtCity.Text & "','" _
                & cmbState.Text & "','" _
                & txtPhone.Text & "','" _
                & txtMobile.Text & "','" _
                & txtWApp.Text & "','" _
                & txtEmail.Text & "','" _
                & Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss") & "'," _
                & ShopID & "," _
                & UserID & "," _
                & Val(txtComm.Text) & ")"

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
            SQL = String.Format("SELECT AGENTID,AGENTCODE,AGENTNAME FROM AGENTS WHERE AGENTNAME Like '%{0}%' ORDER BY AGENTNAME", txtFind.Text)
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
            txtAgentCode.Focus()
        End If

    End Sub

    Public Sub EditVendor(IVendorID As Short)

        SQL = "SELECT * FROM AGENTS WHERE AGENTID=" & IVendorID
        With ESSA.OpenReader(SQL)
            If .Read Then

                Edit = True
                AgentID = .Item(0)
                txtAgentCode.Text = .GetString(1).Trim
                txtVName.Text = .GetString(2).Trim
                txtAdd1.Text = .GetString(3).Trim
                txtAdd2.Text = .GetString(4).Trim
                txtCity.Text = .GetString(5).Trim
                cmbState.Text = .GetString(6).Trim
                txtPhone.Text = .GetString(7).Trim
                txtMobile.Text = .GetString(8).Trim
                txtWApp.Text = .GetString(9).Trim
                txtEmail.Text = .GetString(10).Trim
                txtComm.Text = .Item(14)

            End If
            .Close()
        End With

    End Sub

    Private Sub RefreshForms()

        lblEdit.Visible = True
        Edit = False
        ESSA.ClearTextBox(Me)
        GenerateAgentID()
        txtAgentCode.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        RefreshForms()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click


        'pnlLoading.Visible = True
        'pnlLoading.Refresh()

        TGLst.SuspendLayout()

        SQL = "SELECT AGENTID,AGENTCODE,AGENTNAME FROM AGENTS ORDER BY AGENTNAME"
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

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Sub btnHidePnl_Click(sender As Object, e As EventArgs) Handles btnHidePnl.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub Agents2_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlList, Me)

    End Sub

End Class