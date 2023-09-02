'************************************************* Bismillah ****************************************************
Imports System.Data.SqlClient
Public Class ProductBatch

    Private PluID As Integer = 0
    Private BatID As Short = 0

    Private Sub ProductBatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
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

    Private Sub ProductBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        txtCode.Select()

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select m.pluid,m.plucode,m.pluname,b.rate,b.batchid from productmaster m,productbatch b where m.pluid=b.pluid and m.plucode='" & txtCode.Text.Trim & "' order by b.batchid desc"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    PluID = .Item(0)
                    txtCode.Text = .GetString(1)
                    txtName.Text = .GetString(2)
                    txtORat.Text = Format(.Item(3), "0.00")
                    BatID = .Item(4)
                    txtNRat.Focus()
                Else
                    TTip.Show("Product code not found..!", txtCode, 0, 25, 2000)
                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub txtNRat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNRat.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Val(txtNRat.Text) <= 0 Then
                TTip.Show("Rate should not be zero..!", txtNRat, 0, 25, 2000)
                txtNRat.Clear()
                Exit Sub
            ElseIf Val(txtNRat.Text) = Val(txtORat.Text) Then
                TTip.Show("Old and new batch rate should not be same..!", txtNRat, 0, 25, 2000)
                txtNRat.SelectAll()
                Exit Sub
            End If

            Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)
            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = PluID
            TG.Item(1, NRI).Value = txtCode.Text
            TG.Item(2, NRI).Value = txtName.Text
            TG.Item(3, NRI).Value = Format(Val(txtORat.Text), "0.00")
            TG.Item(4, NRI).Value = Format(Val(txtNRat.Text), "0.00")
            TG.Item(5, NRI).Value = BatID

            txtName.Clear()
            txtNRat.Clear()
            txtORat.Clear()
            txtCode.Focus()
            txtCode.SelectionStart = txtCode.Text.Length

        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        TG.Rows.Clear()
        txtCode.Clear()
        txtName.Clear()
        txtORat.Clear()
        txtNRat.Clear()
        txtCode.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If TG.Rows.Count = 0 Then
            TTip.Show("There are not details to save..!", btnSave, 0, 25, 2000)
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "UPDATE ProductMaster SET RetailPrice={0}, WholeSalePrice={0}, MRP={0}, ISUpdated=0 WHERE PluID={1}"
                SQL = String.Format(SQL, Val(TG.Item(4, i).Value), Val(TG.Item(0, i).Value))

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                SQL = "insert into productbatch values (" _
                    & Val(TG.Item(5, i).Value) + 1 & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & "," _
                    & Val(TG.Item(3, i).Value) & ",0,'" _
                    & Format(Now.Date, "yyyy-MM-dd") & "'," _
                    & ShopID & "," _
                    & UserID & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()
            xMessageBox.ShowMessage("Product batch saved successfully..!", "Product Batch", xMessageBox.MessageBoxStyle.OKOnly)
            btnReset.PerformClick()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub
End Class