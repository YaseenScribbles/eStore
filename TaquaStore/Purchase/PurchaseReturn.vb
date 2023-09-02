'************************************ Bismillah *****************************************
Imports System.Data.SqlClient
Public Class PurchaseReturn

    Private Edit As Boolean = False

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub PurchaseReturn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F3
                btnEdit.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub CalculateTotal()

        Dim TAmt As Double = 0
        Dim TQty As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TQty += Val(TG.Item(4, i).Value)
            TAmt += Val(TG.Item(6, i).Value)

        Next

        lblTQty.Text = Format(TQty, "0.000")
        lblTAmt.Text = Format(TAmt, "0.00")

    End Sub

    Private Sub RefreshForm()

        Edit = False
        ESSA.ClearTextBox(Panel1)
        GenerateReturnID()
        mebLRDt.Clear()
        lblTAmt.Text = "0.00"
        lblTQty.Text = "0.000"
        TGProd.Visible = False
        TG.Rows.Clear()


    End Sub

    Private Sub GenerateReturnID()

        SQL = "select max(vchno) from returnmaster"
        txtVchNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub PurchaseReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateReturnID()
        ESSA.LoadVendors(cmbVendor)
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        InitializeProducts()

    End Sub

    Private Sub InitializeProducts()

        SQL = "select d.pluid,p.plucode 'CODE',d.grnno 'GRN NO',d.grndt 'DATE',(d.qty-d.rqty) 'QUANTITY',d.costprice 'RATE',p.pluname from " _
            & "grndetails d,productmaster p where d.pluid=p.pluid order by p.pluid,d.grnno"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                TGProd.DataSource = Nothing
                TGProd.DataSource = Tbl
                TGProd.Columns(0).Visible = False
                TGProd.Columns(1).Width = 100
                TGProd.Columns(2).Width = 125
                TGProd.Columns(3).Width = 80
                TGProd.Columns(4).Width = 80
                TGProd.Columns(5).Width = 100
                TGProd.Columns(6).Visible = False

            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        TGProd_KeyDown(sender, e)

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

        If e.KeyCode = Keys.Down Then
            TGProd.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            If TGProd.Visible = False Then TGProd.Visible = True
            ESSA.FindAndSelect(TGProd, 1, txtCode.Text)
        End If

    End Sub

    Private Sub TGProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TGProd.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            txtCode.Text = TGProd.Item(1, TGProd.CurrentRow.Index).Value
            txtGRNNo.Text = TGProd.Item(2, TGProd.CurrentRow.Index).Value
            txtAQty.Text = Format(Val(TGProd.Item(4, TGProd.CurrentRow.Index).Value), "0.000")
            txtRate.Text = Format(Val(TGProd.Item(5, TGProd.CurrentRow.Index).Value), "0.00")
            txtRQty.Focus()
            TGProd.Visible = False

        End If

    End Sub

    Private Sub txtRQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRQty.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim NRI = ESSA.FindGridIndex(TG, 0, Val(TGProd.Item(0, TGProd.CurrentRow.Index).Value), 7, Val(TGProd.Item(2, TGProd.CurrentRow.Index).Value))
            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = Val(TGProd.Item(0, TGProd.CurrentRow.Index).Value)
            TG.Item(1, NRI).Value = NRI + 1
            TG.Item(2, NRI).Value = TGProd.Item(1, TGProd.CurrentRow.Index).Value
            TG.Item(3, NRI).Value = TGProd.Item(6, TGProd.CurrentRow.Index).Value
            TG.Item(4, NRI).Value = Format(Val(txtRQty.Text), "0.000")
            TG.Item(5, NRI).Value = Format(Val(TGProd.Item(5, TGProd.CurrentRow.Index).Value), "0.00")
            TG.Item(6, NRI).Value = Format(Val(txtRQty.Text) * Val(txtRate.Text), "0.00")
            TG.Item(7, NRI).Value = TGProd.Item(2, TGProd.CurrentRow.Index).Value
            CalculateTotal()

            txtCode.Clear()
            txtAQty.Clear()
            txtRQty.Clear()
            txtGRNNo.Clear()
            txtRate.Clear()
            txtCode.Focus()

        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cmbVendor.SelectedIndex = -1 Then
            TTip.Show("Vendor not selected..!", cmbVendor, 0, 25, 2000)
            cmbVendor.Focus()
            Exit Sub
        ElseIf IsDate(mebLRDt.Text) = False Then
            TTip.Show("Incorrect L.R date..!", mebLRDt, 0, 25, 2000)
            mebLRDt.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            TTip.Show("No products to save..!", btnSave, 0, 25, 2000)
            Exit Sub
        End If

        If Isa.Msg.ShowSaveQuestion = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from returnmaster where vchno=" & Val(txtVchNo.Text) & ";" _
                    & "delete from returndetails where vchno=" & Val(txtVchNo.Text) & ";"
            Else
                GenerateReturnID()
            End If

            SQL = "insert into returnmaster values (" _
                & Val(txtVchNo.Text) & ",'" _
                & Format(CDate(mebVchDt.Text), "yyyy-MM-dd") & "','" _
                & txtLRNo.Text.Trim & "','" _
                & Format(CDate(mebLRDt.Text), "yyyy-MM-dd") & "'," _
                & cmbVendor.SelectedValue & ",'" _
                & txtRmrks.Text.Trim & "'," _
                & Val(lblTQty.Text) & "," _
                & Val(lblTAmt.Text) & "," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into returndetails values (" _
                    & Val(txtVchNo.Text) & "," _
                    & Trim(TG.Item(8, i).Value) & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & "," _
                    & Val(TG.Item(5, i).Value) & "," _
                    & i + 1 & ");" _
                    & "update grndetails set rqty=" & Val(TG.Item(4, i).Value) _
                    & " where grnno=" & Trim(TG.Item(8, i).Value) & "," _
                    & " and pluid=" & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()
            MsgBox("Purchase return saved successfully..!", MsgBoxStyle.Exclamation)
            RefreshForm()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

    End Sub
End Class