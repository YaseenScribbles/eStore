'**** In the name of Allah, Most Merciful, Most Compassionate ****

Imports System.Data.SqlClient
Public Class frmPaymentRegister

    Private Sub frmPaymentRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub frmPaymentRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Design table header

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleRight)


        '// Load vendor list

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub frmPaymentRegister_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        TG.Columns(TG.Columns.Count - 2).Width = TG.Width - 712

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        SQL = "select grnno,grndt,nettamount from grnmaster where vendorid={0} order by grnno"

        With ESSA.OpenReader(String.Format(SQL, cmbVendor.SelectedValue))
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = Format(.Item(2), "0.00")
            End While
            .Close()
        End With

        If TG.Rows.Count > 0 Then
            TG.CurrentCell = TG.Item(3, 0)
            TG.Focus()
        End If

    End Sub

    Private Sub TG_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellEndEdit

        ESSA.MoveNextCell(TG, 3, 7, False)

    End Sub

    Private Sub TG_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TG.PreviewKeyDown

        If e.KeyCode = Keys.Enter Then
            ESSA.MoveNextCell(TG, 3, 7, False)
        End If

    End Sub

    Private Sub TG_KeyUp(sender As Object, e As KeyEventArgs) Handles TG.KeyUp

        Select Case e.KeyCode

            Case Keys.C
                TG.Item(3, TG.CurrentRow.Index).Value = "Cash"
            Case Keys.Q
                TG.Item(3, TG.CurrentRow.Index).Value = "Cheque"
            Case Keys.T
                TG.Item(3, TG.CurrentRow.Index).Value = "Tranfer"

        End Select

    End Sub

End Class