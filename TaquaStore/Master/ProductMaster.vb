'***************************************** Bismillah ****************************************
Imports System.Data.SqlClient
Public Class ProductMaster

    Private Edit As Boolean = False
    Private Pluid As Integer = 0
    Private CatID(0 To 5) As Short
    Private CatDesc(0 To 5) As String
    Private CatPath As String = ""

    Private Sub GenerateProductID()

        Pluid = ESSA.GenerateID("select max(pluid) from productmaster")

    End Sub

    Private Sub ProductMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
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

    Private Sub ProductMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDetails()

        TG.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        cmbTaxable.SelectedIndex = 0

    End Sub

    Private Sub LoadDetails()

        LoadProducts()

        SQL = "select distinct units from productmaster order by units"
        ESSA.LoadCombo(cmbUnits, SQL, "units")

        ESSA.PopulateTreeview(TV2)

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        SQL = "select cid,color from colors order by color"
        ESSA.LoadCombo(cmbColor, SQL, "color", "cid")

        SQL = "select distinct printname from productmaster order by printname"
        ESSA.LoadCombo(cmbPrintName, SQL, "printname")

        SQL = "select distinct hsncode from productmaster order by hsncode"
        ESSA.LoadCombo(cmbHSN, SQL, "hsncode")

    End Sub

    Private Sub LoadProducts()

        SQL = "select pluid,plucode 'CODE',pluname 'PRODUCT DESCRIPTION' from productmaster order by plucode"
        ESSA.LoadDataGrid(TGProd, SQL)
        TGProd.Columns(0).Visible = 0
        TGProd.Columns(1).Width = 100
        TGProd.Columns(2).Width = 235

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        TGProd_KeyDown(sender, e)

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

        If e.KeyCode = Keys.Down Then
            TGProd.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TGProd, 1, txtCode.Text.Trim)
        End If

    End Sub

    Private Sub TGProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TGProd.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select pluid,plucode,pluname,units,vendorid,istaxable,costprice,retailprice,wholesaleprice,mrp,discount," _
                & "size,id,rackno,cid,printname,hsncode,utax from productmaster where pluid=" & Val(TGProd(0, TGProd.CurrentRow.Index).Value) & ";" _
                & "select * from productlevels where pluid=" & Val(TGProd(0, TGProd.CurrentRow.Index).Value) & ";" _
                & "select pluid,batchid,rate,orate from productbatch where pluid=" & Val(TGProd(0, TGProd.CurrentRow.Index).Value) _
                & " order by batchid"

            With ESSA.OpenReader(SQL)

                If .Read Then
                    Edit = True
                    Pluid = .Item(0)
                    txtCode.Text = .GetString(1)
                    txtName.Text = .GetString(2)
                    cmbUnits.Text = .GetString(3)
                    cmbVendor.SelectedValue = .Item(4)
                    cmbTaxable.SelectedIndex = .Item(5)
                    txtCostPrice.Text = Format(.Item(6), "0.00")
                    txtRetail.Text = Format(.Item(7), "0.00")
                    txtWholeSale.Text = Format(.Item(8), "0.00")
                    txtMRP.Text = Format(.Item(9), "0.00")
                    txtDiscount.Text = Format(.Item(10), "0.0")
                    txtID.Text = .Item(11)
                    txtSize.Text = .Item(12)
                    txtRack.Text = .GetString(13)
                    cmbColor.SelectedValue = .Item(14)
                    cmbPrintName.Text = .GetString(15).Trim
                    cmbHSN.Text = .GetString(16).Trim
                    chkUTax.Checked = IIf(.Item(17) = 1, True, False)
                End If

                .NextResult()

                If .Read Then

                    CatID(0) = .Item(1)
                    CatDesc(0) = .GetString(2)

                    CatID(1) = .Item(3)
                    CatDesc(1) = .GetString(4)

                    CatID(2) = .Item(5)
                    CatDesc(2) = .GetString(6)

                    CatID(3) = .Item(7)
                    CatDesc(3) = .GetString(8)

                    CatID(4) = .Item(9)
                    CatDesc(4) = .GetString(10)

                    CatID(5) = .Item(11)
                    CatDesc(5) = .GetString(12)

                    If CatDesc(0).Length > 0 Then
                        CatPath = CatDesc(0) & "->"
                    End If

                    If CatDesc(1).Length > 0 Then
                        CatPath &= CatDesc(1) & "->"
                    End If

                    If CatDesc(2).Length > 0 Then
                        CatPath &= CatDesc(2) & "->"
                    End If

                    If CatDesc(3).Length > 0 Then
                        CatPath &= CatDesc(3) & "->"
                    End If

                    If CatDesc(4).Length > 0 Then
                        CatPath &= CatDesc(4) & "->"
                    End If

                    If CatDesc(5).Length > 0 Then
                        CatPath &= CatDesc(5) & "->"
                    End If

                    CatPath = Mid(CatPath, 1, CatPath.Length - 2)

                End If

                txtCat.Text = CatPath

                .NextResult()

                TG.Rows.Clear()
                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .Item(1)
                    TG.Item(2, TG.Rows.Count - 1).Value = Format(.Item(2), "0.00")
                    TG.Item(3, TG.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                End While

                .Close()

            End With

            txtName.Focus()

        End If

    End Sub

    Private Sub btnPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPick.Click

        pnlSide.ColumnStyles(0).SizeType = SizeType.Absolute
        pnlSide.ColumnStyles(0).Width = 0

        pnlSide.ColumnStyles(1).SizeType = SizeType.Percent
        pnlSide.ColumnStyles(1).Width = 100

    End Sub

    Private Sub TV2_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV2.AfterSelect

        If e.Node Is Nothing Then Exit Sub
        txtCat.Text = e.Node.FullPath

        For i As Byte = 0 To 5
            CatID(i) = 0
            CatDesc(i) = ""
        Next

        CatID(e.Node.Level) = e.Node.Name
        CatDesc(e.Node.Level) = e.Node.Text

        Dim t = e.Node.Parent
        Do Until t Is Nothing
            CatID(t.Level) = t.Name
            CatDesc(t.Level) = t.Text
            t = t.Parent
        Loop

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        LoadDetails()
        RefreshForm()

    End Sub

    Private Sub RefreshForm()

        pnlSide.ColumnStyles(0).SizeType = SizeType.Percent
        pnlSide.ColumnStyles(0).Width = 100

        pnlSide.ColumnStyles(1).SizeType = SizeType.Absolute
        pnlSide.ColumnStyles(1).Width = 0

        Edit = False
        TG.Rows.Clear()
        ESSA.ClearTextBox(Me)
        chkUTax.Checked = False
        txtCode.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtCode.Text.Trim = "" Then
            TTip.Show("Product code should not be empty..!", txtCode, 0, 25, 2000)
            txtCode.Focus()
            Exit Sub
        ElseIf txtName.Text.Trim = "" Then
            TTip.Show("Product name should not be empty..!", txtName, 0, 25, 2000)
            txtName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select pluid from productmaster " & IIf(Edit = True, " where plucode='" & txtCode.Text.Trim & "' and pluid<>" & Pluid, " where plucode='" & txtCode.Text.Trim & "'")) = True Then
            TTip.Show("Product code already exists..!", txtCode, 0, 25, 2000)
            txtCode.Focus()
            Exit Sub
        ElseIf cmbVendor.SelectedIndex = -1 Then
            TTip.Show("Vendor not selected..!", cmbVendor, 0, 25, 2000)
            cmbVendor.Focus()
            Exit Sub
        ElseIf txtCat.Text.Trim = "" Then
            TTip.Show("Category not selected..!", txtCat, 0, 25, 2000)
            txtCat.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then

                SQL = "delete from productmaster where pluid=" & Pluid & ";" _
                    & "delete from productlevels where pluid=" & Pluid & ";" _
                    & "delete from productbatch where pluid=" & Pluid

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Else

                GenerateProductID()

            End If

            SQL = "INSERT INTO PRODUCTMASTER VALUES (" _
                & Pluid & ",'" _
                & txtCode.Text.Trim & "','" _
                & txtName.Text.Trim & "',0,'" _
                & cmbUnits.Text.Trim & "'," _
                & cmbVendor.SelectedValue & "," _
                & cmbTaxable.SelectedIndex & "," _
                & Val(txtCostPrice.Text) & "," _
                & Val(txtRetail.Text) & "," _
                & Val(txtWholeSale.Text) & "," _
                & Val(txtMRP.Text) & "," _
                & Val(txtDiscount.Text) & "," _
                & Val(txtSize.Text) & ",'" _
                & txtID.Text & "','" _
                & txtCat.Text.Trim & "','" _
                & txtRack.Text.Trim & "',0,'" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & UserID & "," _
                & cmbColor.SelectedValue & ",'" _
                & cmbPrintName.Text.Trim & "','" _
                & cmbHSN.Text.Trim & "'," _
                & IIf(chkUTax.Checked = True, 1, 0) & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "insert into productlevels values (" _
                & Pluid & "," _
                & CatID(0) & ",'" _
                & CatDesc(0) & "'," _
                & CatID(1) & ",'" _
                & CatDesc(1) & "'," _
                & CatID(2) & ",'" _
                & CatDesc(2) & "'," _
                & CatID(3) & ",'" _
                & CatDesc(3) & "'," _
                & CatID(4) & ",'" _
                & CatDesc(4) & "'," _
                & CatID(5) & ",'" _
                & CatDesc(5) & "',0)"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As SByte = 0 To TG.Rows.Count - 1

                SQL = "insert into productbatch values (" _
                    & Val(TG.Item(1, i).Value) & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(2, i).Value) & "," _
                    & Val(TG.Item(3, i).Value) & ",0,'" _
                    & Format(Now.Date, "yyyy-MM-dd") & "'," _
                    & ShopID & "," _
                    & UserID & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()
            MsgBox("Product details updated..!", MsgBoxStyle.Exclamation)
            'xMessageBox.ShowMessage("Product updated successfully..!", "Congratualtions..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshForm()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub TGProd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGProd.CellContentClick

    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub
End Class