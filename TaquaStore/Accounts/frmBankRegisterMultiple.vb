Imports System.Data.SqlClient
Public Class frmBankRegisterMultiple

    Private Sno As Short = 0
    Private Edt As Boolean = False

    Private Sub frmBankRegisterMultiple_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F3

                btnUpdate.PerformClick()

            Case Keys.F4

                txtACName.Text = cmbVendor.Text.Trim

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

    Private Sub frmBankRegisterMultiple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Design table header

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleLeft)

        '// Load bank list

        LoadBankList()

        '// Load vendor list

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        '// Set Default Account Type

        cmbACType.SelectedIndex = 0

        '// Load Distinct Branch List

        SQL = "select distinct branch from bankregister where len(branch)>0 order by branch"
        ESSA.LoadCombo(cmbBranch, SQL, "branch", "")

    End Sub

    '// Load bank list
    Private Sub LoadBankList()

        SQL = "select bankid,bankname from banklist order by bankname"
        ESSA.LoadCombo(cmbBank, SQL, "bankname", "bankid")

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub
        LoadAccountDetails()
        If Edt Then RefreshForm()

    End Sub

    Private Sub LoadAccountDetails()

        SQL = String.Format("select distinct sno,acno from bankregister where vendorid={0} order by acno", cmbVendor.SelectedValue)
        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = "2"
            End While
            .Close()
        End With

    End Sub

    Private Sub GenerateSerialNo()

        SQL = "select max(sno) from bankregister"
        Sno = ESSA.GenerateID(SQL)

    End Sub

    Private Function convertIFSC(ifsc As String) As String

        convertIFSC = ""

        For i As SByte = 1 To ifsc.Length
            convertIFSC &= Mid(ifsc, i, 1) & " "
        Next

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        SQL = "select acname from bankregister where acno='" _
            & txtACNo.Text.Trim & "' and sno<>" & Sno

        If txtACName.Text.Trim = "" Then
            TTip.Show("Account name cannot be empty..!", txtACName, 0, 25, 2000)
            txtACName.Focus()
            Exit Sub
        ElseIf txtACNo.Text.Trim = "" Then
            TTip.Show("Account number cannot be empty..!", txtACNo, 0, 25, 2000)
            txtACNo.Focus()
            Exit Sub
        ElseIf txtIFSC.Text.Trim.Length <> 11 Then
            TTip.Show("IFSC code must be 11 characters..!", txtIFSC, 0, 25, 2000)
            txtIFSC.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edt Then
                SQL = String.Format("delete from bankregister where sno={0}", Sno)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateSerialNo()
            End If

            SQL = "insert into bankregister values (" _
                & cmbVendor.SelectedValue & "," _
                & cmbBank.SelectedValue & ",'" _
                & txtACName.Text.Trim & "','" _
                & txtACNo.Text.Trim & "','" _
                & txtIFSC.Text.Trim & "','" _
                & cmbBranch.Text.Trim & "'," _
                & IIf(cmbACType.SelectedIndex = 0, 10, 11) & ",0," _
                & Sno & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

            MsgBox("Entry saved successfully..!", MsgBoxStyle.Information)

            RefreshForm()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub RefreshForm()

        ESSA.ClearTextBox(Me)
        Edt = False
        lblEM.Visible = False
        cmbBank.Focus()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        RefreshForm()

    End Sub

    Private Sub FetchBankData(iRowIdx As Short)

        SQL = "select * from bankregister where vendorid={0} and sno={1}"
        With ESSA.OpenReader(String.Format(SQL, cmbVendor.SelectedValue, Val(TG.Item(0, iRowIdx).Value)))
            If .Read Then
                Edt = True
                lblEM.Visible = True
                cmbBank.SelectedValue = .Item(1)
                txtACName.Text = .GetString(2).Trim
                txtACNo.Text = .GetString(3).Trim
                txtIFSC.Text = .GetString(4).Trim
                cmbBranch.Text = .GetString(5).Trim
                cmbACType.SelectedIndex = IIf(.Item(6) = 10, 0, 1)
                Sno = .Item(8)
                cmbBank.Focus()
            End If
            .Close()
        End With

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 2 Then
            If MsgBox("Do you want to modify bank info..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            FetchBankData(e.RowIndex)
        End If

    End Sub

    Private Sub btnReloadBankList_Click(sender As Object, e As EventArgs) Handles btnReloadBankList.Click

        LoadBankList()

    End Sub

    Private Sub btnAddBank_Click(sender As Object, e As EventArgs) Handles btnAddBank.Click

        frmBankRegister.ShowDialog(Me)

    End Sub

    Private Sub txtIFSC_TextChanged(sender As Object, e As EventArgs) Handles txtIFSC.TextChanged

        lblIFSC.Text = convertIFSC(txtIFSC.Text.Trim)

    End Sub

    Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub
End Class