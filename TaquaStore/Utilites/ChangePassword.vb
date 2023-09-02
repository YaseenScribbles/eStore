Imports System.Data.SqlClient
Public Class ChangePassword

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'MsgBox(ClsEncodeDecode.DCode(txtCP.Text))
        'Exit Sub

        SQL = "select userid from users where userid=" & UserID & " and password='" _
            & ClsEncodeDecode.Encode(txtCP.Text) & "'"

        If ESSA.ISFound(SQL) = False Then
            MsgBox("Incorrect current password..!", vbCritical)
            txtCP.Focus()
            Exit Sub
        End If

        If txtNP.Text = "" Then
            MsgBox("Password should not be empty..!", vbCritical)
            txtNP.Focus()
            Exit Sub
        ElseIf StrComp(txtNP.Text, txtRP.Text) <> 0 Then
            MsgBox("Incorrect retype password..!", vbCritical)
            txtRP.Clear()
            txtRP.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to update password..!", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        SQL = "update users set password='" & ClsEncodeDecode.Encode(txtNP.Text) & "' where userid=" _
            & UserID
        ESSA.Execute(SQL)

        MsgBox("Password updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub ChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                Close()

        End Select

    End Sub

End Class