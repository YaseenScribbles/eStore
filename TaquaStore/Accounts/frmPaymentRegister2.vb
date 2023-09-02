Public Class frmPaymentRegister2

    Private Sub frmPaymentRegister2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then

                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)

                End If

            Case Keys.Escape

                If MsgBox("Do you want to exit..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select


    End Sub

    Private Sub frmPaymentRegister2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)



    End Sub

End Class