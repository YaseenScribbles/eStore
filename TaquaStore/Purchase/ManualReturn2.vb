'// In the name of Allah, Most Merciful, Most Compassionate

Imports System.Data.SqlClient

Public Class ManualReturn2

    Private pluid As Integer = 0

    Private Sub showdata(icode As String)

        SQL = "select pluid,pluname,costprice " _
            & "from productmaster " _
            & "where plucode='{0}'"

        With ESSA.OpenReader(String.Format(SQL, icode))
            If .Read Then
                pluid = .Item(0)
                txtDesc.Text = .GetString(1).Trim
                txtRate.Text = Format(.Item(2), "0.00")
                txtQty.Focus()
            Else
                MsgBox("Product code not found..!", MsgBoxStyle.Critical)
            End If
            .Close()
        End With

    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtCode.Text.Trim = "" Then
                MsgBox("Product code cannot be empty..!", MsgBoxStyle.Critical)
                txtCode.Focus()
                Exit Sub
            End If

            showdata(txtCode.Text.Trim)

        End If

    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtDisPer.Focus()

        End If

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

        txtAmt.Text = Format(Val(txtQty.Text) * Val(txtRate.Text), "0.00")

    End Sub

    Private Sub txtDisPer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDisPer.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtTaxPer.Focus()

        End If

    End Sub

    Private Sub txtDisPer_TextChanged(sender As Object, e As EventArgs) Handles txtDisPer.TextChanged

        txtDisAmt.Text = Format((Val(txtAmt.Text) / 100) * Val(txtDisPer.Text), "0.00")

    End Sub

    Private Sub ManualReturn2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub ManualReturn2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbGST.SelectedIndex = 0

    End Sub

End Class