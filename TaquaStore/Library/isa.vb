Public Class Isa

    '// Check whether input text is available in combobox list
    Public Shared Function FoundInList(iCmb As ComboBox) As Boolean

        FoundInList = True

        If iCmb.FindStringExact(iCmb.Text.Trim) = -1 Then
            FoundInList = False
        End If

    End Function

    Public Class Convert

        '// Check whether input date is valid, or convert into current proper date
        Public Shared Sub ToDate(iTextBox As MaskedTextBox)

            If Not IsDate(iTextBox.Text) Then
                iTextBox.Text = Format(Now.Date, "dd-MM-yyyy")
            End If

        End Sub

    End Class

    Public Class KeyWorks

        '// Common Form Keys
        Public Shared Sub CommonKeys(iForm As Form, e As KeyEventArgs)

            Select Case e.KeyCode

                Case Keys.Enter

                    If iForm.ActiveControl.Tag <> "1" Then
                        e.SuppressKeyPress = True
                        SendKeys.Send("{Tab}")
                    End If

                Case Keys.Escape

                    If Msg.ShowExit() = MsgBoxResult.No Then Exit Sub
                    iForm.Close()

            End Select

        End Sub

    End Class

    Public Class Msg

        '// Close Message
        Public Shared Function ShowExit() As MsgBoxResult

            Return MsgBox("Do you want to exit..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        End Function

        Public Shared Function ShowSaveQuestion() As MsgBoxResult

            Return MsgBox("Do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        End Function

    End Class

End Class
