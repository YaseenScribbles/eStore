'********************************************** Bismillah *****************************************************
Imports System.Data.SqlClient
Public Class LocationSettings

    Private Sub LocationSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub LocationSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "shopdesc", "shopid")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocation.SelectedIndexChanged

        If cmbLocation.SelectedIndex = -1 Then Exit Sub

        SQL = "select * from locationsettings where shopid=" & IIf(cmbLocation.SelectedValue.ToString.Contains("DataRow"), 0, cmbLocation.SelectedValue)
        With ESSA.OpenReader(SQL)
            If .Read Then
                txtSQLServer.Text = .GetString(1)
                txtUserName.Text = .GetString(2)
                txtPassword.Text = .GetString(3)
                txtDatabase.Text = .GetString(4)
            Else
                txtSQLServer.Clear()
                txtUserName.Clear()
                txtPassword.Clear()
                txtDatabase.Clear()
            End If
            .Close()
        End With

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        'If TestConnection() = False Then
        '    If MsgBox("Connection Testing Failed, Are you sure do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If

        SQL = "delete from locationsettings where shopid=" & cmbLocation.SelectedValue & ";" _
            & "insert into locationsettings values (" _
            & cmbLocation.SelectedValue & ",'" _
            & txtSQLServer.Text.Trim & "','" _
            & txtUserName.Text.Trim & "','" _
            & txtPassword.Text & "','" _
            & txtDatabase.Text.Trim & "')"

        ESSA.Execute(SQL)
        MsgBox("Settings updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Function TestConnection() As Boolean

        TestConnection = False

        Using Cn As New SqlConnection("Data Source=" & txtSQLServer.Text.Trim & ";User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";Initial Catalog=" & txtDatabase.Text.Trim)

            Try
                Cn.Open()

                If Cn.State = ConnectionState.Open Then
                    TestConnection = True
                    MsgBox("Connection established successfully..!", MsgBoxStyle.Information)
                    Cn.Close()
                End If
            Catch ex As SqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End Using

    End Function

End Class