
'// In the name of Allah, Most Merciful, Most Compassionate

Imports System.Data.SqlClient
Public Class frmBankRegister

    '// **** reference id for bank ****

    Private bankID As Short = 0
    Private edit As Boolean = False

    Private Sub frmBankRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape

                If pnlAddNewBank.Visible Then pnlAddNewBank.Hide()

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub frmBankRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Load bank list function

        Call loadBankList()

    End Sub

    Private Sub loadBankList()

        '// Get list of bank name in database
        '// Table : banklist

        SQL = "select bankid,bankname from banklist where bankid>0 order by bankname"

        With ESSA.OpenReader(SQL)

            dgv.Rows.Clear()

            While .Read

                Dim nri = dgv.Rows.Add
                dgv.Item(0, nri).Value = .Item(0)
                dgv.Item(1, nri).Value = .GetString(1).Trim

            End While

            .Close()

        End With

        lblBankCount.Text = dgv.Rows.Count

    End Sub

    Private Sub btnAddNewBank_Click(sender As Object, e As EventArgs) Handles btnAddNewBank.Click

        pnlAddNewBank.Visible = True
        txtBankName.Focus()

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        lblHead.Text = "Add New Bank"
        bankID = 0
        edit = False
        Call loadBankList()
        pnlAddNewBank.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '// **** Validation Process ****

        If edit = False Then
            SQL = "select bankid from banklist where bankname='{0}'"
        Else
            SQL = "select bankid from banklist where bankname='{0}' and bankid<>{1}"
        End If

        If txtBankName.Text.Trim = "" Then
            MsgBox("Bank name cannot be empty..!", MsgBoxStyle.Information)
            txtBankName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound(String.Format(SQL, txtBankName.Text.Trim, bankID)) Then
            MsgBox("Bank name already exists..!", MsgBoxStyle.Information)
            txtBankName.Focus()
            Exit Sub
        End If

        '// **** Saving Process ****

        If Not edit Then
            bankID = ESSA.GenerateID("select max(bankid) from banklist")
        Else
            SQL = "delete from banklist where bankid=" & bankID
            ESSA.Execute(SQL)
        End If

        SQL = "insert into banklist values (" _
            & bankID & ",'" _
            & txtBankName.Text.Trim & "','" _
            & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)

        MsgBox("Registered Successfully..!", MsgBoxStyle.Exclamation)
        txtBankName.Clear()

        If edit = True Then
            btnHide.PerformClick()
        End If

    End Sub

    Private Sub txtBankName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBankName.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnUpdate.PerformClick()
        End If

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 2 Then

            edit = True
            bankID = Val(dgv.Item(0, e.RowIndex).Value)
            txtBankName.Text = Trim(dgv.Item(1, e.RowIndex).Value)

            lblHead.Text = "Add New Bank - Edit Mode"
            pnlAddNewBank.Visible = True
            txtBankName.Focus()

        End If

    End Sub

End Class