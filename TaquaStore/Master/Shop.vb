'*************************************** Bismillah **************************************
Imports System.Data.SqlClient
Public Class Shop

    Private LocID As Short
    Private Edit As Boolean = False

    Private Sub vendors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                If pnlList.Visible = True Then pnlList.Visible = False : txtLName.Focus() : Exit Sub
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbLType.SelectedIndex = 0
        GenerateShopID()
        txtLCode.Select()

    End Sub

    Private Sub GenerateShopID()

        SQL = "select max(ShopID) from Shops"
        LocID = ESSA.GenerateID(SQL)

        SQL = "select count(ShopID) from Shops where Shoptype='" & cmbLType.Text & "'"
        txtLCode.Text = IIf(cmbLType.SelectedIndex = 0, "EW", "ER") & Format(ESSA.GenerateID(SQL), "00")
        'txtLCode.Text = IIf(cmbLType.SelectedIndex = 0, "WH", "TS") & Format(ESSA.GenerateID(SQL), "00")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from Shops where ShopID=" & LocID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateShopID()
            End If

            SQL = "insert into Shops values (" _
                & LocID & ",'" _
                & txtLCode.Text & "','" _
                & txtLName.Text & "','" _
                & txtAlias.Text.Trim & "','" _
                & cmbLType.Text & "','" _
                & txtAdd1.Text & "','" _
                & txtAdd2.Text & "','" _
                & txtCity.Text & "','" _
                & cmbState.Text & "','" _
                & txtPhone.Text & "','" _
                & txtMobile.Text & "','" _
                & txtWApp.Text & "','" _
                & txtEmail.Text & "','" _
                & txtTIN.Text & "','" _
                & txtCST.Text & "',0,1,'" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            xMessageBox.ShowMessage("New Shops has been created successfully..!", "Congratualtions..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshForms()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub RefreshForms()

        lblEM.Visible = False
        Edit = False
        ESSA.ClearTextBox(pMain)
        GenerateShopID()
        txtLName.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        RefreshForms()

    End Sub

    Private Sub cmbLType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLType.Leave

        GenerateShopID()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        pnlList.Left = 0
        pnlList.Top = 0
        pnlList.Width = Me.Width
        pnlList.Height = Me.Height - 33

        TGLst.SuspendLayout()

        SQL = "SELECT SHOPID,SHOPCODE,SHOPNAME FROM SHOPS ORDER BY SHOPNAME"
        With ESSA.OpenReader(SQL)
            TGLst.Rows.Clear()
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = .GetString(1).Trim
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
            End While
            .Close()
        End With

        'TGLst.ResumeLayout()
        pnlList.Visible = True
        txtFind.Focus()

    End Sub

    Public Sub EditVendor(VendorID As Short)

        SQL = "SELECT * FROM SHOPS WHERE SHOPID=" & VendorID
        With ESSA.OpenReader(SQL)
            If .Read Then

                lblEM.Visible = True
                Edit = True
                LocID = .Item(0)
                txtLCode.Text = .GetString(1).Trim
                txtLName.Text = .GetString(2).Trim
                txtAlias.Text = .GetString(3).Trim
                cmbLType.Text = .GetString(4).Trim
                txtAdd1.Text = .GetString(5).Trim
                txtAdd2.Text = .GetString(6).Trim
                txtCity.Text = .GetString(7).Trim
                cmbState.Text = .GetString(8).Trim
                txtPhone.Text = .GetString(9).Trim
                txtMobile.Text = .GetString(10).Trim
                txtWApp.Text = .GetString(11).Trim
                txtEmail.Text = .GetString(12).Trim
                txtTIN.Text = .GetString(13).Trim
                txtCST.Text = .GetString(14).Trim

            End If
            .Close()
        End With

    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp

        If e.KeyCode = Keys.Down Then
            If TGLst.CurrentRow.Index = TGLst.Rows.Count - 1 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index + 1)
        ElseIf e.KeyCode = Keys.Up Then
            If TGLst.CurrentRow.Index = 0 Then Exit Sub
            TGLst.CurrentCell = TGLst.Item(1, TGLst.CurrentRow.Index - 1)
        ElseIf e.KeyCode <> Keys.Enter
            SQL = String.Format("SELECT SHOPID,SHOPCODE,SHOPNAME FROM SHOPS WHERE SHOPNAME LIKE '%{0}%' ORDER BY SHOPNAME", txtFind.Text)
            With ESSA.OpenReader(SQL)
                TGLst.Rows.Clear()
                While .Read
                    TGLst.Rows.Add()
                    TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                    TGLst.Item(1, TGLst.Rows.Count - 1).Value = .GetString(1).Trim
                    TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
                End While
                .Close()
            End With
        End If

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If TGLst.Rows.Count = 0 Then Exit Sub
            EditVendor(Val(TGLst.Item(0, TGLst.CurrentRow.Index).Value))
            'lblEdit.Visible = True
            pnlList.Visible = False
            txtLName.Focus()
        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        If pnlList.Visible = True Then pnlList.Visible = False : txtLName.Focus() : Exit Sub

    End Sub

    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If xMessage.ShowMsg("Do you want to exit..?", True, frmMainScreen, 0, xMessage.MsgStyle.iExit) = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnHidePnl_Click(sender As Object, e As EventArgs) Handles btnHidePnl.Click

        MainWindowX.CloseTab(Me.Name)
        If Not MainWindowX.TabExists(Me.Name) Then
            Me.Close()
        End If

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        btnHidePnl.PerformClick()

    End Sub

End Class