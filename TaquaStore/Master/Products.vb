'************************************************* Bismillah ************************************************
Imports System.Data.SqlClient
Public Class Products

    Private Pluid As Integer = 0
    Private CatID(0 To 5) As Short
    Private CatDesc(0 To 5) As String

    Private Sub Products_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub RefreshForm()

        ESSA.ClearTextBox(Me)
        TG.Rows.Clear()
        txtPlucode.Focus()

    End Sub

    Private Sub LoadColors()

        SQL = "select cid,code,color from colors order by code"
        With ESSA.OpenReader(SQL)
            TGColor.Rows.Clear()
            While .Read
                TGColor.Rows.Add()
                TGColor.Item(0, TGColor.Rows.Count - 1).Value = .Item(0)
                TGColor.Item(1, TGColor.Rows.Count - 1).Value = .GetString(1)
                TGColor.Item(2, TGColor.Rows.Count - 1).Value = .GetString(2)
            End While
            .Close()
        End With


    End Sub

    Private Sub Products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadColors()
        PopulateTreeview()
        LoadVendors()
        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        cmbTaxable.SelectedIndex = 0
        txtPlucode.Select()

    End Sub

    Private Sub LoadVendors()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        SQL = "select distinct units from productmaster where len(units)>0 order by units"
        ESSA.LoadCombo(cmbUOM, SQL, "units")

    End Sub

    Private Sub PopulateTreeview()

        SQL = "select catid,catdesc from category order by catid;" _
            & "select pvscatid,scatid,scatdesc from categorylevels where cattype=1 order by pvscatid,scatid"

        With ESSA.OpenReader(SQL)

            TVCat.Nodes.Clear()

            While .Read
                TVCat.Nodes.Add(.Item(0), .GetString(1).Trim)
            End While

            .NextResult()

            While .Read

                Dim TN As TreeNode() = TVCat.Nodes.Find(.Item(0), True)
                If TN.Length > 0 Then
                    TN(0).Nodes.Add(.Item(1), .GetString(2).Trim)
                End If

            End While

            .Close()

        End With

    End Sub

    Private Sub TVCat_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)

        If e.Node Is Nothing Then Exit Sub

        For i As Byte = 0 To 5
            CatID(i) = 0
            CatDesc(i) = ""
        Next

        txtSCat.Text = e.Node.FullPath
        CatID(e.Node.Level) = e.Node.Name
        CatDesc(e.Node.Level) = e.Node.Text

        Dim t = e.Node.Parent
        Do Until t Is Nothing
            CatID(t.Level) = t.Name
            CatDesc(t.Level) = t.Text
            t = t.Parent
        Loop

        cmbUOM.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtSCat.Text.Trim = "" Then
            TTip.Show("Category not selected..!", txtSCat, 0, 25, 2000)
            txtSCat.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            TTip.Show("No products to save..!", btnSave, 0, 25, 2000)
            Exit Sub
        End If

        For i As Short = 0 To TG.Rows.Count - 1

            SQL = "select pluid from productmaster where plucode='" & TG.Item(0, i).Value & "'"
            If ESSA.ISFound(SQL) = True Then
                MsgBox("Unable to save, The product code " & TG.Item(0, i).Value & " already exists..!", MsgBoxStyle.Critical)
                Exit Sub
                Exit For
            End If

        Next

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            Dim TmpID = ESSA.GenerateID("select max(pluid) from productmaster")

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into productmaster values (" _
                    & TmpID & ",'" _
                    & TG.Item(0, i).Value & "','" _
                    & TG.Item(1, i).Value & "',0,'" _
                    & TG.Item(2, i).Value & "'," _
                    & cmbVendor.SelectedValue & ",'" _
                    & TG.Item(8, i).Value & "','" _
                    & TG.Item(3, i).Value & "','" _
                    & TG.Item(5, i).Value & "','" _
                    & TG.Item(6, i).Value & "','" _
                    & TG.Item(7, i).Value & "','" _
                    & TG.Item(4, i).Value & "','" _
                    & TG.Item(22, i).Value & "','" _
                    & TG.Item(23, i).Value & "','" _
                    & TG.Item(24, i).Value & "','" _
                    & txtRack.Text.Trim & "',0,'" _
                    & Format(Now, "yyyy-MM-dd hh:mm:ss") & "'," _
                    & UserID & "," _
                    & TG.Item(25, i).Value & ")"

                SQL &= "insert into productlevels values (" _
                    & TmpID & "," _
                    & TG.Item(10, i).Value & ",'" _
                    & TG.Item(11, i).Value & "'," _
                    & TG.Item(12, i).Value & ",'" _
                    & TG.Item(13, i).Value & "'," _
                    & TG.Item(14, i).Value & ",'" _
                    & TG.Item(15, i).Value & "'," _
                    & TG.Item(16, i).Value & ",'" _
                    & TG.Item(17, i).Value & "'," _
                    & TG.Item(18, i).Value & ",'" _
                    & TG.Item(19, i).Value & "'," _
                    & TG.Item(20, i).Value & ",'" _
                    & TG.Item(21, i).Value & "',0);"

                SQL &= "insert into productbatch values (1," _
                    & TmpID & "," _
                    & Val(TG.Item(5, i).Value) & ",0,'" _
                    & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                    & ShopID & "," _
                    & UserID & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                TmpID += 1

            Next

            Trn.Commit()
            Con.Close()
            xMessageBox.ShowMessage("New products created successfully..!", "Congratulations..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshForm()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub AddProductRows(ByVal e As Object)

        If e.KeyCode = Keys.Enter Then

            If txtPlucode.Text.Trim = "" Then
                TTip.Show("Product code cannot be blank..!", txtPlucode, 0, 25, 2000)
                txtPlucode.Focus()
                Exit Sub
            ElseIf Val(txtCostPrice.Text) <= 0 Or Val(txtRetail.Text) <= 0 Then
                TTip.Show("Cost price and retail price cannot be zero..!", txtCostPrice, 0, 25, 2000)
                txtCostPrice.Focus()
                Exit Sub
            ElseIf Val(txtStart.Text) > Val(txtEnd.Text) Then
                TTip.Show("End size cannot less then stating size..!", txtEnd, 0, 25, 2000)
                txtEnd.Focus()
                Exit Sub
            ElseIf txtSCat.Text.Trim = "" Or CatID(0) = 0 Then
                TTip.Show("Category not selected..!", txtSCat, 0, 25, 2000)
                txtSCat.Focus()
                Exit Sub
            End If

            Dim Siz As Short = Val(txtSize.Text)
            Dim NRI As Short = 0
            Dim ifr As Boolean = False
            Dim rwi As Double = 0
            Dim icp As Double = 0 'Increase Cost Price

            For i As Short = Val(txtStart.Text) To Val(txtEnd.Text) Step Val(txtIncr.Text)

                NRI = ESSA.FindGridIndex(TG, 0, txtPlucode.Text.Trim & IIf(chkSB.Checked = True, SizeToCode(i), i))
                If NRI = -1 Then NRI = TG.Rows.Add()

                If ifr = False Then
                    rwi = Val(txtRetail.Text)
                    ifr = True
                Else
                    rwi += Val(txtRate.Text)
                    If chkOCP.Checked = False Then
                        icp += Val(txtRate.Text)
                    End If
                End If

                TG.Item(0, NRI).Value = txtPlucode.Text.Trim & IIf(chkSB.Checked = True, SizeToCode(i), i)
                TG.Item(1, NRI).Value = txtPludesc.Text.Trim & IIf(chkSB.Checked = True, SizeToCode(i), i)
                TG.Item(2, NRI).Value = cmbUOM.Text
                TG.Item(3, NRI).Value = Val(txtCostPrice.Text) + IIf(chkOCP.Checked = False, icp, 0)
                TG.Item(4, NRI).Value = Val(txtDis.Text)
                TG.Item(5, NRI).Value = rwi
                TG.Item(6, NRI).Value = rwi
                TG.Item(7, NRI).Value = rwi
                TG.Item(8, NRI).Value = IIf(cmbTaxable.SelectedIndex = 0, 1, 0)
                TG.Item(9, NRI).Value = cmbVendor.SelectedValue
                TG.Item(10, NRI).Value = CatID(0)
                TG.Item(11, NRI).Value = CatDesc(0)
                TG.Item(12, NRI).Value = CatID(1)
                TG.Item(13, NRI).Value = CatDesc(1)
                TG.Item(14, NRI).Value = CatID(2)
                TG.Item(15, NRI).Value = CatDesc(2)
                TG.Item(16, NRI).Value = CatID(3)
                TG.Item(17, NRI).Value = CatDesc(3)
                TG.Item(18, NRI).Value = CatID(4)
                TG.Item(19, NRI).Value = CatDesc(4)
                TG.Item(20, NRI).Value = CatID(5)
                TG.Item(21, NRI).Value = CatDesc(5)
                TG.Item(22, NRI).Value = Siz
                TG.Item(23, NRI).Value = IIf(chkSB.Checked = True, SizeToCode(i), i)
                TG.Item(24, NRI).Value = txtSCat.Text
                Siz += 2

            Next

            txtPlucode.Focus()

        End If


    End Sub

    Private Function GetColorCode(ByVal Index As SByte) As String

        If chkColorWise.Checked = True Then
            GetColorCode = TGPick.Item(1, Index).Value
        End If

    End Function

    Private Function GetColorID(ByVal Index As SByte) As Short

        If chkColorWise.Checked = False Then
            GetColorID = 1
        Else
            GetColorID = TGPick.Item(0, Index).Value
        End If

    End Function

    Private Sub txtDis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDis.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtPlucode.Text.Trim = "" Then
                TTip.Show("Product code cannot be blank..!", txtPlucode, 0, 25, 2000)
                txtPlucode.Focus()
                Exit Sub
            ElseIf Val(txtCostPrice.Text) <= 0 Or Val(txtRetail.Text) <= 0 Then
                TTip.Show("Cost price and retail price cannot be zero..!", txtCostPrice, 0, 25, 2000)
                txtCostPrice.Focus()
                Exit Sub
            ElseIf Val(txtStart.Text) > Val(txtEnd.Text) Then
                TTip.Show("End size cannot less then stating size..!", txtEnd, 0, 25, 2000)
                txtEnd.Focus()
                Exit Sub
            ElseIf txtSCat.Text.Trim = "" Or CatID(0) = 0 Then
                TTip.Show("Category not selected..!", txtSCat, 0, 25, 2000)
                txtSCat.Focus()
                Exit Sub
            End If

            Dim Siz As Short = Val(txtSize.Text)
            Dim NRI As Short = 0
            Dim ifr As Boolean = False
            Dim rwi As Double = 0
            Dim icp As Double = 0 'Increase Cost Price
            Dim pcc As SByte = 0 'Picked Color Count

            If chkColorWise.Checked = True Then
                pcc = TGPick.Rows.Count - 1
            End If

            For c As SByte = 0 To pcc

                For i As Short = Val(txtStart.Text) To Val(txtEnd.Text) Step Val(txtIncr.Text)

                    NRI = ESSA.FindGridIndex(TG, 0, txtPlucode.Text.Trim & IIf(chkSB.Checked = True, SizeToCode(i), i))
                    If NRI = -1 Then NRI = TG.Rows.Add()

                    If ifr = False Then
                        rwi = Val(txtRetail.Text)
                        ifr = True
                    Else
                        rwi += Val(txtRate.Text)
                        If chkOCP.Checked = False Then
                            icp += Val(txtRate.Text)
                        End If
                    End If

                    TG.Item(0, NRI).Value = txtPlucode.Text.Trim & IIf(chkColorWise.Checked = True, GetColorCode(c), "") & IIf(chkSB.Checked = True, SizeToCode(i), i)
                    TG.Item(1, NRI).Value = txtPludesc.Text.Trim & IIf(chkSB.Checked = True, SizeToCode(i), i)
                    TG.Item(2, NRI).Value = cmbUOM.Text
                    TG.Item(3, NRI).Value = Val(txtCostPrice.Text) + IIf(chkOCP.Checked = False, icp, 0)
                    TG.Item(4, NRI).Value = Val(txtDis.Text)
                    TG.Item(5, NRI).Value = rwi
                    TG.Item(6, NRI).Value = rwi
                    TG.Item(7, NRI).Value = rwi
                    TG.Item(8, NRI).Value = IIf(cmbTaxable.SelectedIndex = 0, 1, 0)
                    TG.Item(9, NRI).Value = cmbVendor.SelectedValue
                    TG.Item(10, NRI).Value = CatID(0)
                    TG.Item(11, NRI).Value = CatDesc(0)
                    TG.Item(12, NRI).Value = CatID(1)
                    TG.Item(13, NRI).Value = CatDesc(1)
                    TG.Item(14, NRI).Value = CatID(2)
                    TG.Item(15, NRI).Value = CatDesc(2)
                    TG.Item(16, NRI).Value = CatID(3)
                    TG.Item(17, NRI).Value = CatDesc(3)
                    TG.Item(18, NRI).Value = CatID(4)
                    TG.Item(19, NRI).Value = CatDesc(4)
                    TG.Item(20, NRI).Value = CatID(5)
                    TG.Item(21, NRI).Value = CatDesc(5)
                    TG.Item(22, NRI).Value = Siz
                    TG.Item(23, NRI).Value = IIf(chkSB.Checked = True, SizeToCode(i), i)
                    TG.Item(24, NRI).Value = txtSCat.Text
                    TG.Item(25, NRI).Value = GetColorID(c)
                    Siz += 2

                Next

            Next

            txtPlucode.Focus()

        End If

    End Sub

    Private Function SizeToCode(ByVal Size As Short) As String

        Select Case Size

            Case 1
                SizeToCode = "S"
            Case 2
                SizeToCode = "M"
            Case 3
                SizeToCode = "L"
            Case 4
                SizeToCode = "XL"
            Case 5
                SizeToCode = "XXL"
            Case 6
                SizeToCode = "XXXL"
            Case 7
                SizeToCode = "4XL"
            Case 8
                SizeToCode = "5XL"
            Case Else
                SizeToCode = ""

        End Select

    End Function

    Private Sub TTip_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles TTip.Draw

        'Dim Rect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        'e.Graphics.FillRectangle(Brushes.Black, Rect)

        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()

    End Sub

    Private Function RoundOff(ByVal Amt As Double) As Double

        RoundOff = Amt
        Amt = Amt Mod 10

        If Amt > 0 Then
            RoundOff += IIf(Amt >= 5, 10 - Amt, -Amt)
        End If

    End Function

    Private Sub txtProfit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProfit.TextChanged, txtExtra.TextChanged, txtCostPrice.TextChanged

        Dim Retail As Double = Math.Round(Val(txtCostPrice.Text) + ((Val(txtCostPrice.Text) * Val(txtProfit.Text)) / 100) + Val(txtExtra.Text))

        If chkRO.Checked = True Then
            Retail = RoundOff(Retail)
        End If

        txtRetail.Text = Format(Retail, "0.00")
        txtWholesale.Text = Format(Val(txtRetail.Text), "0.00")
        txtMRP.Text = Format(Val(txtRetail.Text), "0.00")

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        ESSA.ClearTextBox(Panel2, "5")
        LoadVendors()
        PopulateTreeview()

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.Delete Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
        End If

    End Sub

    Private Sub txtRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRate.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDis.Focus()
        End If

    End Sub

    Private Sub btnShowColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowColor.Click

        pnlColors.Visible = True
        txtCode.Focus()

    End Sub

    Private Sub Products_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlColors, Me)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        PickRow(False, TGColor, TGPick)

    End Sub

    Private Sub PickRow(ByVal PickAll As Boolean, ByVal Source As DataGridView, ByVal Target As DataGridView)

        If PickAll = True Then

            For i As Short = 0 To Target.Rows.Count - 1
                Target.Rows.Add()
                Target.Item(0, Target.Rows.Count - 1).Value = Source.Item(0, i).Value
                Target.Item(1, Target.Rows.Count - 1).Value = Source.Item(1, i).Value
                Target.Item(2, Target.Rows.Count - 1).Value = Source.Item(2, i).Value
            Next

            Source.Rows.Clear()

        Else

            Target.Rows.Add()
            Target.Item(0, Target.Rows.Count - 1).Value = Source.Item(0, Source.CurrentRow.Index).Value
            Target.Item(1, Target.Rows.Count - 1).Value = Source.Item(1, Source.CurrentRow.Index).Value
            Target.Item(2, Target.Rows.Count - 1).Value = Source.Item(2, Source.CurrentRow.Index).Value
            Source.Rows.RemoveAt(Source.CurrentRow.Index)
            If Source.Rows.Count > 0 Then
                Source.CurrentCell = Source.Item(1, Source.CurrentRow.Index)
            End If

        End If

    End Sub

    Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click

        PickRow(True, TGColor, TGPick)

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        PickRow(False, TGPick, TGColor)

    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click

        PickRow(True, TGPick, TGColor)

    End Sub

    Private Sub TGColor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGColor.CellDoubleClick

        If TGColor.CurrentRow.Index = -1 Then Exit Sub
        btnAdd.PerformClick()

    End Sub

    Private Sub TGPick_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TGPick.DoubleClick

        If TGPick.CurrentRow.Index = -1 Then Exit Sub
        btnRemove.PerformClick()

    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click

        pnlColors.Visible = False

    End Sub

    Private Sub chkColorWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColorWise.CheckedChanged

        btnShowColor.Enabled = chkColorWise.Checked

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlColors.Visible = False

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

        If e.KeyCode = Keys.Down Then
            TGColor.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TGColor, 1, txtCode.Text)
        End If

    End Sub

    Private Sub txtColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColor.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub txtColor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColor.KeyUp

        If e.KeyCode = Keys.Down Then
            TGPick.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TGPick, 1, txtColor.Text)
        End If

    End Sub

    Private Sub btnReLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReLoad.Click

        TGColor.Rows.Clear()
        TGPick.Rows.Clear()
        LoadColors()

    End Sub

    Private Sub txtDis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDis.TextChanged

    End Sub

    Private Sub TGColor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGColor.CellContentClick

    End Sub

    Private Sub txtColor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColor.TextChanged

    End Sub

    Private Sub btnAddColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddColors.Click

        Colors.Visible = False
        Colors.ShowDialog(Me)

    End Sub

End Class