Imports System.Data.SqlClient

Public Class frmCreditNote

#Region "Variabale-Declaration"

    Private VchID As Integer = 0
    Private Status As SByte = 0

#End Region

#Region "Form-Operations"

    Private Sub frmCreditNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbPaid.SelectedIndex = 0
        GenerateVoucherNo()
        txtVDt.Text = Format(Now.Date, "dd-MM-yyyy")
        LoadVendors()
        cmbLedger.Select()

    End Sub

    Private Sub frmCreditNote_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Me.Close()

        End Select

    End Sub

#End Region

#Region "Common-Functions"

    Private Sub GenerateVoucherNo()

        SQL = "select max(vchid) from creditnote"
        VchID = ESSA.GenerateID(SQL)

        SQL = "select max(vchno) from creditnote"
        txtVNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub LoadVendors()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbLedger, SQL, "vendorname", "vendorid")

    End Sub

#End Region

#Region "Textbox-Operations"

    Private Sub txtRefDt_Leave(sender As Object, e As EventArgs) Handles txtRefDt.Leave

        If IsDate(txtRefDt.Text) = False Then

            txtRefDt.Text = Format(Now.Date, "dd-MM-yyyy")

            Isa.Convert.ToDate(txtRefDt)

        End If

    End Sub

    Private Sub txtAmt_Leave(sender As Object, e As EventArgs) Handles txtAmt.Leave

        txtAmt.Text = Format(Val(txtAmt.Text), "0.00")

    End Sub

#End Region

#Region "Save-Connection"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ItemFound(cmbPaid) = False Then

            ShowMsgNotFound() : Exit Sub

        End If

        If MsgBox("Do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            GenerateVoucherNo()

            SQL = "insert into CreditNote values (" _
                 & VchID & "," _
                 & Val(txtVNo.Text) & ",'" _
                 & Format(CDate(txtVDt.Text).Date, "yyyy-MM-dd") & "'," _
                 & cmbLedger.SelectedValue & "," _
                 & cmbPaid.SelectedIndex & ",'" _
                 & txtRefNo.Text.Trim & "','" _
                 & Format(CDate(txtRefDt.Text).Date, "yyyy-MM-dd") & "'," _
                 & Val(txtAmt.Text) & ",'" _
                 & txtRemarks.Text.Trim & "'," _
                 & Status & ",'" _
                 & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                 & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

            RefreshForm()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub RefreshForm()

        ESSA.ClearTextBox(Me)
        GenerateVoucherNo()
        cmbLedger.Focus()

    End Sub

    '// check whether item found in entire combo box list

    Public Shared Function ItemFound(iCmb As ComboBox) As Boolean


        If iCmb.FindStringExact(iCmb.Text) = -1 Then

            ItemFound = False
            iCmb.Focus()

        Else

            ItemFound = True

        End If


    End Function

    Public Shared Sub ShowMsgNotFound()

        MsgBox("Sorry, Item not found in list !", vbCritical)

    End Sub


#End Region


End Class