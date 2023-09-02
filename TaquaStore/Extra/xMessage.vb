Public Class xMessage

    Public ISYes As Boolean

    Enum MsgStyle

        Question = 0
        iError = 1
        Exclamation = 2
        iExit = 3
        iPrint = 4

    End Enum
    Private Sub xMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Y Or e.KeyCode = Keys.Enter Or e.KeyCode = Keys.O Then
            btnYes.PerformClick()
        ElseIf e.KeyCode = Keys.N Or e.KeyCode = Keys.Escape Then
            btnNo.PerformClick()
        End If

    End Sub

    Public Function ShowMsg(Message As String, ISYesorNo As Boolean, ParentWdw As Control, AdjustHeight As Short, Optional MsgStyle As MsgStyle = MsgStyle.Exclamation) As Boolean

        Me.Left = (ParentWdw.Width - Me.Width) / 2
        Me.Top = (ParentWdw.Height + AdjustHeight - Me.Height) / 2

        UpdateMsgStyle(ISYesorNo)
        lblMsg.Text = Message

        Select Case MsgStyle

            Case 0
                lblMsg.ImageIndex = 0
            Case 1
                lblMsg.ImageIndex = 1
            Case 2
                lblMsg.ImageIndex = 2
            Case 3
                lblMsg.ImageIndex = 3
            Case 4
                lblMsg.ImageIndex = 4

        End Select

        btnYes.Select()
        Me.ShowDialog()

        Return ISYes

    End Function

    Private Sub UpdateMsgStyle(ISYesorNoStyle As Boolean)

        If ISYesorNoStyle = True Then

            btnYes.Text = "&Yes"
            btnYes.Left = 75
            btnNo.Left = 156
            btnNo.Visible = True

        Else

            btnYes.Text = "&OK"
            btnYes.Left = 116
            'btnNo.Left = -100
            btnNo.Visible = False

        End If

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        ISYes = True
        Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        ISYes = False
        Close()

    End Sub

End Class