'***************************************** Bismillah ******************************************
Imports System.Data.SqlClient
Public Class Ledger

    Private Edit As Boolean = False

    Private Sub GenerateLedgerID()

        txtLedgerID.Text = ESSA.GenerateID("select max(ledgerid) from ledger")

    End Sub

    Private Sub LoadGroups()

        SQL = "select groupid,groupname from ledgergroup order by groupname"
        ESSA.LoadCombo(cmbLGroup, SQL, "groupname", "groupid")

        SQL = "select groupid,groupname from ledgergroup order by groupname"
        ESSA.LoadCombo(cmbGrpHead, SQL, "groupname", "groupid", "Primary")

    End Sub

    Private Sub GenerateGroupID()

        txtGrpID.Text = ESSA.GenerateID("select max(groupid) from ledgergroup")

    End Sub

    Private Sub Ledger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub Ledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadGroups()
        GenerateLedgerID()
        cmbDR.SelectedIndex = 0
        txtLedgerName.Select()
        'TabControlEX1.SelectedIndex = 0

    End Sub

    Private Sub SaveLedger()

        SQL = "SELECT LEDGERID  FROM LEDGER WHERE LEDGERNAME='" & txtLedgerName.Text.Trim & "'" & IIf(Edit = True, " AND LEDGERID<>" & Val(txtLedgerID.Text), "")

        If txtLedgerName.Text.Trim = "" Then
            TTip.Show("Ledger name should not be empty..!", txtLedgerName, 0, 25, 2000)
            txtLedgerName.Focus()
            Exit Sub
        ElseIf cmbLGroup.SelectedIndex = -1 Then
            TTip.Show("Ledger group not selected..!", cmbLGroup, 0, 25, 2000)
            cmbLGroup.Focus()
            Exit Sub
        ElseIf ESSA.ISFound(SQL) = True Then
            TTip.Show("Ledger name already exists..!", txtLedgerName, 0, 25, 2000)
            txtLedgerName.SelectAll()
            txtLedgerName.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from ledger where ledgerid=" & Val(txtLedgerID.Text)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateLedgerID()
            End If

            SQL = "insert into ledger values (" _
                & Val(txtLedgerID.Text) & ",'" _
                & txtLedgerName.Text.Trim & "'," _
                & cmbLGroup.SelectedValue & "," _
                & IIf(cmbDR.SelectedIndex = 0, -Val(txtOBal.Text), Val(txtOBal.Text)) & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("Entry saved successfully..!", vbExclamation)
            'xMessageBox.ShowMessage("Ledger created successfully..!", "Taqua Store..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshLedger()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub RefreshLedger()

        ESSA.ClearTextBox(Me)
        GenerateLedgerID()
        txtLedgerName.Focus()

    End Sub

    Private Sub RefreshLedgerGroup()

        ESSA.ClearTextBox(Me)
        GenerateGroupID()
        txtGrpNm.Focus()

    End Sub

    Private Sub SaveLedgerGroup()

        SQL = "SELECT GROUPID  FROM LEDGERGROUP WHERE GROUPNAME='" & txtGrpNm.Text.Trim & "'" & IIf(Edit = True, " AND GROUPID<>" & Val(txtGrpID.Text), "")

        If txtGrpNm.Text.Trim = "" Then
            TTip.Show("Ledger group should not be empty..!", txtGrpNm, 0, 25, 2000)
            txtGrpNm.Focus()
            Exit Sub
        ElseIf cmbGrpHead.SelectedIndex = -1 Then
            TTip.Show("Ledger group not selected..!", cmbGrpHead, 0, 25, 2000)
            cmbGrpHead.Focus()
            Exit Sub
        ElseIf ESSA.ISFound(SQL) = True Then
            TTip.Show("Ledger group already exists..!", txtGrpNm, 0, 25, 2000)
            txtGrpNm.SelectAll()
            txtGrpNm.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from ledgergroup where groupid=" & Val(txtGrpID.Text)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateLedgerID()
            End If

            SQL = "insert into ledgergroup values (" _
                & Val(txtGrpID.Text) & ",'" _
                & txtGrpNm.Text.Trim & "'," _
                & IIf(cmbGrpHead.SelectedIndex = 0, 0, cmbGrpHead.SelectedValue) & "," _
                & IIf(cmbGrpHead.SelectedIndex = 0, 1, 0) & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("Entry saved successfully..!", vbExclamation)
            'xMessageBox.ShowMessage("Ledger group created successfully..!", "Taqua Store..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshLedgerGroup()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'If TabControlEX1.SelectedIndex = 0 Then
        SaveLedger()
        'Else
        '    SaveLedgerGroup()
        'End If

    End Sub

    Private Sub TabControlEX1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        LoadGroups()
        'If TabControlEX1.SelectedIndex = 0 Then
        GenerateLedgerID()
        'Else
        '    GenerateGroupID()
        'End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        LoadGroups()
        'If TabControlEX1.SelectedIndex = 0 Then
        RefreshLedger()
        'Else
        'RefreshLedgerGroup()
        'End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        'If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    'Private Sub Ledger_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    '    pnlWS.Left = (Me.Width - pnlWS.Width) / 2
    '    pnlWS.Top = (Me.Height - pnlWS.Height) / 2

    'End Sub

End Class