Public Class xMessageBox

    Public MessageBoxResult As MessageBoxResultList

    Public Enum MessageBoxResultList As Byte

        OKOnly = 1

        CancelOnly = 2

    End Enum

    Public Enum MessageBoxStyle As Byte

        OKOnly = 1

        OkandCancel = 2

    End Enum

    Public Function ShowMessage(ByVal Msg As String, ByVal Title As String, ByVal MessageBoxStyle As MessageBoxStyle) As MessageBoxResultList

        If MessageBoxStyle = xMessageBox.MessageBoxStyle.OKOnly Then
            btnCancel.Visible = False
        End If

        lblMsg.Text = Msg
        lblTitle.Text = Title

        Me.ShowDialog()
        Return MessageBoxResult

    End Function

    Public Function ShowMessage2(ByVal Msg As String, ByVal Title As String, ByVal MessageBoxStyle As MessageBoxStyle, Parent As Control) As MessageBoxResultList

        If MessageBoxStyle = xMessageBox.MessageBoxStyle.OKOnly Then
            btnCancel.Visible = False
        End If

        lblMsg.Text = Msg
        lblTitle.Text = Title

        'Me.StartPosition = FormStartPosition.Manual
        Me.Left = (MainWindowX2.pMain.Width - Me.Width) / 2
        Me.Top = (MainWindowX2.pMain.Height + 50 - Me.Height) / 2
        Me.ShowDialog(Parent)
        Return MessageBoxResult

    End Function


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        MessageBoxResult = MessageBoxResultList.CancelOnly
        Close()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        MessageBoxResult = MessageBoxResultList.OKOnly
        Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        MessageBoxResult = MessageBoxResultList.CancelOnly
        Close()

    End Sub

    Private Sub xMessageBox_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Y Or e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        ElseIf e.KeyCode = Keys.N Or e.KeyCode = Keys.Escape Then
            btnCancel.PerformClick()
        End If

    End Sub

End Class