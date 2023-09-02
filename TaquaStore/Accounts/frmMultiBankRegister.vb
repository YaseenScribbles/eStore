'**** In the name of Allah, Most Merciful, Most Compassionate ****
Imports System.Data.SqlClient
Public Class frmMultiBankRegister

    Private Sub frmMultiBankRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F3

                btnUpdate.PerformClick()

            Case Keys.F4

                TG.Item(2, TG.CurrentRow.Index).Value = cmbVendor.Text.Trim

            Case Keys.F8

                cmbBank.Focus()

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Sub frmMultiBankRegister_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        '// Adjust width for last column

        TG.Columns(8).Width = TG.Width - 600

    End Sub

    Private Sub frmMultiBankRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Design table header

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleCenter)

        '// Load bank list

        SQL = "select bankid,bankname from banklist order by bankname"
        ESSA.LoadCombo(cmbBank, SQL, "bankname", "bankid")

        '// Load vendor list

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    'Private Sub btnHide_Click(sender As Object, e As EventArgs)

    '    pnlAddBank.Visible = False

    'End Sub

    'Private Sub btnBankRegister_Click(sender As Object, e As EventArgs)

    '    pnlAddBank.Visible = True
    '    txtBank.Focus()

    'End Sub

    'Private Sub addNewBank(iBankName As String)

    '    If txtBank.Text.Trim = "" Then
    '        MsgBox("Bank name cannot be empty..!", MsgBoxStyle.Information)
    '        txtBank.Focus()
    '        Exit Sub
    '    ElseIf ESSA.ISFound("select bankname from banklist where bankname='" & iBankName & "'") Then
    '        MsgBox("Bank name already exists..!", MsgBoxStyle.Information)
    '        txtBank.Focus()
    '        Exit Sub
    '    End If

    '    Dim newBankID = ESSA.GenerateID("select max(bankid) from banklist")

    '    SQL = "insert into banklist values (" _
    '            & newBankID & ",'" _
    '            & txtBank.Text.Trim & "','" _
    '            & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
    '            & UserID & ")"

    '    ESSA.Execute(SQL)

    '    loadBankList()
    '    btnHide.PerformClick()

    'End Sub

    Private Sub loadBankList()

        SQL = "select bankid,bankname from banklist order by bankname"
        ESSA.LoadCombo(cmbBank, SQL, "bankname", "bankid")

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        SQL = "select r.bankid,b.bankname,r.acname,r.acno,r.ifsc,r.branch,r.actype,r.status from banklist b,bankregister r " _
            & "where r.bankid=b.bankid and r.vendorid={0} order by r.sno"

        With ESSA.OpenReader(String.Format(SQL, cmbVendor.SelectedValue))

            TG.Rows.Clear()
            While .Read
                Dim nri = TG.Rows.Add
                TG.Item(0, nri).Value = .Item(0)
                TG.Item(1, nri).Value = .GetString(1).Trim
                TG.Item(2, nri).Value = .GetString(2).Trim
                TG.Item(3, nri).Value = .GetString(3).Trim
                TG.Item(4, nri).Value = .GetString(4).Trim
                TG.Item(5, nri).Value = .GetString(5).Trim
                TG.Item(6, nri).Value = IIf(.Item(6) = 10, "SAVINGS", "CURRENT")
                TG.Item(7, nri).Value = IIf(.Item(7) = 0, "YES", "NO")
            End While
            .Close()

        End With

        If TG.Rows.Count = 0 Then

            TG.Rows.Add()
            TG.Item(7, TG.Rows.Count - 1).Value = "YES"
            TG.CurrentCell = TG.Item(1, 0)

        Else

            cmbBank.Visible = False
            TG.CurrentCell = TG.Item(7, TG.Rows.Count - 1)
            TG.Focus()

        End If

    End Sub

    Private Function findDuplicateDataInGrid(dgv As DataGridView, findCol As Short, findValue As String, excludeCurrentRow As Boolean) As Boolean

        findDuplicateDataInGrid = False

        Dim currentRowIndex As Integer = If(excludeCurrentRow, dgv.CurrentRow.Index, -2)

        For i As Integer = 0 To dgv.Rows.Count - 1

            If i <> currentRowIndex Then

                If dgv.Item(findCol, i).Value = findValue Then

                    findDuplicateDataInGrid = True
                    Exit Function

                End If


            End If

        Next

    End Function

    Private Sub TG_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellEndEdit

        If e.ColumnIndex = 3 Then
            If findDuplicateDataInGrid(TG, 3, Trim(TG.Item(3, e.RowIndex).Value), True) Then
                MsgBox("Account number already in list..!", MsgBoxStyle.Information)
                TG.Item(3, e.RowIndex).Value = ""
                Exit Sub
            End If
        End If

        ESSA.MoveNextCell(TG, 1, 7, False)

    End Sub

    Private Sub TG_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellEnter

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 1 Then
            ApplyControl(e.RowIndex)
        ElseIf e.ColumnIndex = 2 Then
            cmbBank.Visible = False
        End If

    End Sub

    Private Sub ApplyControl(iRowIdx As Short)

        With cmbBank

            .Left = TG.GetCellDisplayRectangle(1, iRowIdx, True).Left + 2
            .Top = TG.GetCellDisplayRectangle(1, iRowIdx, True).Top + 135
            .Width = TG.GetCellDisplayRectangle(1, iRowIdx, True).Width - 4
            .Visible = True
            .SelectedValue = Val(TG.Item(0, iRowIdx).Value)
            .Focus()

        End With

    End Sub

    Private Sub cmbBank_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBank.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            TG.Item(0, TG.CurrentRow.Index).Value = cmbBank.SelectedValue
            TG.Item(1, TG.CurrentRow.Index).Value = cmbBank.Text.Trim

            TG.CurrentCell = TG.Item(2, TG.CurrentRow.Index)
            TG.Focus()

        End If

    End Sub

    Private Sub TG_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TG.PreviewKeyDown

        If e.KeyCode = Keys.Enter Then

            ESSA.MoveNextCell(TG, 1, 7, False)

        End If

    End Sub

    Private Sub TG_KeyUp(sender As Object, e As KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F8 Then

            TG.Rows.Add()
            TG.Item(7, TG.Rows.Count - 1).Value = "YES"
            TG.CurrentCell = TG.Item(1, TG.Rows.Count - 1)

        End If

        If TG.CurrentCell.ColumnIndex = 6 Then

            If e.KeyCode = Keys.S Then

                TG.Item(6, TG.CurrentRow.Index).Value = "SAVINGS"

            ElseIf e.KeyCode = Keys.C Then

                TG.Item(6, TG.CurrentRow.Index).Value = "CURRENT"

            End If

        End If

        If TG.CurrentCell.ColumnIndex = 7 Then

            If e.KeyCode = Keys.Y Then

                TG.Item(7, TG.CurrentRow.Index).Value = "YES"

            ElseIf e.KeyCode = Keys.N Then

                TG.Item(7, TG.CurrentRow.Index).Value = "NO"

            End If

        End If

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If MsgBox("Do you want to update bank details..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "delete from bankregister where vendorid=" & cmbVendor.SelectedValue
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As SByte = 0 To TG.Rows.Count - 1

                If Len(Trim(TG.Item(3, i).Value)) > 0 Then

                    SQL = "insert into bankregister (vendorid, bankid, acname, acno, ifsc, branch, actype, status, updateddate, userid) values (" _
                        & cmbVendor.SelectedValue & "," _
                        & Val(TG.Item(0, i).Value) & ",'" _
                        & Trim(TG.Item(2, i).Value) & "','" _
                        & Trim(TG.Item(3, i).Value) & "','" _
                        & Trim(TG.Item(4, i).Value) & "','" _
                        & Trim(TG.Item(5, i).Value) & "','" _
                        & IIf(Trim(TG.Item(6, i).Value) = "SAVINGS", 10, 11) & "'," _
                        & IIf(Trim(TG.Item(7, i).Value) = "YES", 0, 1) & ",'" _
                        & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                        & UserID & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

            MsgBox("Bank register updated..!", MsgBoxStyle.Exclamation)

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    'Private Sub txtBank_KeyDown(sender As Object, e As KeyEventArgs)

    '    If e.KeyCode = Keys.Enter Then

    '        addNewBank(txtBank.Text.Trim)

    '    End If

    'End Sub

    'Private Sub addNewBank(iBankName As String)

    '    If txtBank.Text.Trim = "" Then
    '        MsgBox("Bank name cannot be empty..!", MsgBoxStyle.Information)
    '        txtBank.Focus()
    '        Exit Sub
    '    ElseIf ESSA.ISFound("select bankname from banklist where bankname='" & iBankName & "'") Then
    '        MsgBox("Bank name already exists..!", MsgBoxStyle.Information)
    '        txtBank.Focus()
    '        Exit Sub
    '    End If

    '    Dim newBankID = ESSA.GenerateID("select max(bankid) from banklist")

    '    SQL = "insert into banklist values (" _
    '            & newBankID & ",'" _
    '            & txtBank.Text.Trim & "','" _
    '            & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
    '            & UserID & ")"

    '    ESSA.Execute(SQL)

    '    loadBankList()
    '    btnHide.PerformClick()

    'End Sub

End Class