'***************************************** Bismillah ************************************
Imports System.Data.SqlClient
Public Class StockUpdater

    Private Edit As Boolean = False
    Private PluID As Integer = 0
    Private PluNm As String = ""

    Private Sub GenerateEntryID()

        SQL = "select max(entryno) from StockAlterMaster"
        txtEntryNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub StockUpdater_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F3
                btnEdit.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub StockUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'InitializeProducts()
        mebEntryDt.Text = Format(Now.Date, "dd-MM-yyyy")
        GenerateEntryID()
        ESSA.LoadVendors(cmbVendor)
        txtRmrks.Focus()
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub RefreshForm()

        ESSA.ClearTextBox(Panel1)
        TG.Rows.Clear()
        lblTQty.Text = "0"
        GenerateEntryID()

    End Sub

    'Private Sub InitializeProducts()

    '    SQL = "SELECT P.PLUID,P.PLUCODE 'CODE',P.PLUNAME 'PRODUCT DESCRIPTION',P.COSTPRICE 'RATE',QOH 'STOCK' FROM " _
    '        & "PRODUCTMASTER P ORDER BY P.PLUCODE"

    '    ESSA.OpenConnection()
    '    Using Adp As New SqlDataAdapter(SQL, Con)
    '        Using Tbl As New DataTable
    '            Adp.Fill(Tbl)
    '            TGProd.DataSource = Nothing
    '            TGProd.DataSource = Tbl
    '            TGProd.Columns(0).Visible = False
    '            TGProd.Columns(1).Width = 100
    '            TGProd.Columns(2).Width = 190
    '            TGProd.Columns(3).Width = 70
    '            TGProd.Columns(4).Width = 72
    '        End Using
    '    End Using
    '    Con.Close()

    'End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select p.pluid,plucode,pluname,retailprice,stock from productmaster p,v_stockpos v " _
                & "where p.pluid=v.pluid and plucode='" & txtCode.Text.Trim & "'"

            With ESSA.OpenReader(SQL)
                If .Read Then
                    PluID = .Item(0)
                    txtCode.Text = .GetString(1).Trim
                    PluNm = .GetString(2)
                    txtRate.Text = Format(.Item(3), "0.00")
                    txtStock.Text = .Item(4)
                    txtQty.Focus()
                Else
                    TTip.Show("Sorry, Product code not found..!", txtCode, 0, 25, 2000)
                    txtCode.SelectAll()
                    Exit Sub
                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)
            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = PluID
            TG.Item(1, NRI).Value = NRI + 1
            TG.Item(2, NRI).Value = txtCode.Text.Trim
            TG.Item(3, NRI).Value = PluNm
            TG.Item(4, NRI).Value = Format(Val(txtRate.Text), "0.00")
            TG.Item(5, NRI).Value = Val(txtQty.Text)

            If chkIQ.Checked = True Then
                TG.Item(6, NRI).Value = Val(txtQty.Text) + Val(TG.Item(6, NRI).Value)
            Else
                TG.Item(6, NRI).Value = Val(txtQty.Text)
            End If

            TG.Item(7, NRI).Value = Val(TG.Item(6, NRI).Value) - Val(txtStock.Text)

            lblTQty.Text = ESSA.GetColTotal(TG, 6)
            txtCode.Clear()
            txtRate.Clear()
            txtQty.Clear()
            txtStock.Clear()
            txtCode.Focus()

        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        lblTQty.Text = ESSA.GetColTotal(TG, 5)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cmbVendor.SelectedIndex = -1 Then
            TTip.Show("Vendor not selected..!", cmbVendor, 0, 25, 2000)
            cmbVendor.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            TTip.Show("No products to save..!", btnSave, 0, 25, 2000)
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = False Then
                GenerateEntryID()
            Else
                SQL = "delete from stockaltermaster where entryno=" & Val(txtEntryNo.Text) & ";" _
                    & "delete from stockalterdetails where entryno=" & Val(txtEntryNo.Text)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            End If

            SQL = "insert into stockaltermaster values (" _
                & Val(txtEntryNo.Text) & ",'" _
                & Format(CDate(mebEntryDt.Text), "yyyy-MM-dd") & "'," _
                & cmbVendor.SelectedValue & ",'" _
                & txtRmrks.Text.Trim & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into stockalterdetails values (" _
                    & Val(txtEntryNo.Text) & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & "," _
                    & Val(TG.Item(7, i).Value) & "," _
                    & i + 1 & ");update productmaster set qoh=" _
                    & Val(TG.Item(6, i).Value) & " where pluid=" _
                    & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()
            xMessageBox.ShowMessage("Stock details updated successfully..!", "Congratulations..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshForm()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        'InitializeProducts()
        RefreshForm()

    End Sub

End Class