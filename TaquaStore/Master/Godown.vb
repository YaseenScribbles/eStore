'****************************************** Bismillah ***************************************
Imports System.Data.SqlClient
Public Class Godown

    Private GdnID As Short = 0
    Private Edit As Boolean = False

    Private Sub GenerateGdnID()

        SQL = "select max(GdnID) from Godown"
        GdnID = ESSA.GenerateID(SQL)
        txtGDNCode.Text = "GN" & Format(GdnID, "00")

    End Sub

    Private Sub RefreshForms()

        Edit = False
        ESSA.ClearTextBox(pnlWS)
        txtgdnName.Focus()
        GenerateGdnID()

    End Sub

    'Private Sub LoadGodown()

    '    TG.Rows.Clear()

    '    SQL = "select GdnID,Gdncode,Gdnname from Godown order by GdnID"
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

    Private Sub Gdnomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If
        End Select

    End Sub

    Private Sub Gdnomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        GenerateGdnID()
        txtgdnName.Select()

    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If txtgdnName.Text.Trim = "" Then
    '        TTip.Show("Godown name should be empty..!", txtgdnName, 0, 25, 2000)
    '        txtgdnName.Focus()
    '        Exit Sub
    '    End If

    '    ESSA.OpenConnection()
    '    Dim Cmd = Con.CreateCommand
    '    Dim Trn = Con.BeginTransaction
    '    Cmd.Transaction = Trn

    '    Try

    '        If Edit = True Then
    '            SQL = "delete from Godown where GdnID=" & GdnID
    '            Cmd.CommandText = SQL
    '            Cmd.ExecuteNonQuery()
    '        Else
    '            GenerateGdnID()
    '        End If

    '        SQL = "insert into Godown values (" _
    '            & GdnID & ",'" _
    '            & txtGDNCode.Text.Trim & "','" _
    '            & txtgdnName.Text.Trim & "','" _
    '            & txtAddress1.Text.Trim & "','" _
    '            & txtAddress2.Text.Trim & "','" _
    '            & txtCity.Text.Trim & "','" _
    '            & txtPhone.Text.Trim & "','" _
    '            & txtEmailID.Text.Trim & "','" _
    '            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
    '            & ShopID & "," _
    '            & UserID & ")"

    '        Cmd.CommandText = SQL
    '        Cmd.ExecuteNonQuery()

    '        Trn.Commit()
    '        Con.Close()
    '        MsgBox("New godown has been saved successfully..!", vbExclamation)
    '        RefreshForms()

    '    Catch ex As Exception
    '        Trn.Rollback()
    '        Con.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub

    'Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    LoadGodown()
    '    RefreshForms()

    'End Sub

    'Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    MainWindowX.CloseTab(Me.Name)

    'End Sub

    'Private Sub txtFindGdn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindGdn.KeyDown

    '    TG_KeyDown(sender, e)

    'End Sub

    'Private Sub txtFindGdn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindGdn.KeyUp

    '    If e.KeyCode = Keys.Down Then
    '        TG.Focus()
    '    ElseIf e.KeyCode <> Keys.Enter Then
    '        ESSA.FindAndSelect(TG, 2, txtFindGdn.Text)
    '    End If

    'End Sub

    'Private Sub TG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyDown

    '    If e.KeyCode = Keys.Enter Then

    '    End If

    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Godown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Godown_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        pnlWS.Left = (Me.Width - pnlWS.Width) / 2
        pnlWS.Top = (Me.Height - pnlWS.Height) / 2

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtgdnName.Text.Trim = "" Then
            TTip.Show("Godown name should be empty..!", txtgdnName, 0, 25, 2000)
            txtgdnName.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from Godown where GdnID=" & GdnID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateGdnID()
            End If

            SQL = "insert into Godown values (" _
                & GdnID & ",'" _
                & txtGDNCode.Text.Trim & "','" _
                & txtgdnName.Text.Trim & "','" _
                & txtAddress1.Text.Trim & "','" _
                & txtAddress2.Text.Trim & "','" _
                & txtCity.Text.Trim & "','" _
                & txtPhone.Text.Trim & "','" _
                & txtEmailID.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("New godown has been saved successfully..!", vbExclamation)
            RefreshForms()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub

End Class