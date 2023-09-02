'********************************************* Bismillah ***********************************
Imports System.Data.SqlClient
Public Class PurchaseOrder

    Private Rpt As New RptPurchaseOrder

    Private Sub LoadVendors()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub LoadStore()

        SQL = "select gdnid,gdnname from godown order by gdnname"
        ESSA.LoadCombo(cmbDLoc, SQL, "gdnname", "gdnid")

    End Sub

    Private Sub PurchaseOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F3
                btnEdit.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                If pnlOList.Visible = True Then pnlOList.Visible = False : Exit Sub
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub PurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        LoadVendors()
        LoadStore()
        GenerateOrderNo()
        mebOrderDt.Text = Format(Now.Date, "dd-MM-yyyy")
        mebEDDt.Select()

    End Sub

    Private Sub GenerateOrderNo()

        SQL = "select max(orderno) from ordermaster"
        txtOrderNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub mebEDDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mebEDDt.Leave

        CType(sender, MaskedTextBox).Text = Format(Now.Date, "dd-MM-yyyy")

    End Sub

    Private Sub txtRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRate.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtAmount.Text = Format(Val(txtQty.Text) * Val(txtRate.Text), "0.00")
            Dim NRI = ESSA.FindGridIndex(TG, 1, txtCode.Text)
            If NRI = -1 Then NRI = TG.Rows.Add()

            TG.Item(0, NRI).Value = NRI + 1
            TG.Item(1, NRI).Value = txtCode.Text.Trim
            TG.Item(2, NRI).Value = Format(Val(txtQty.Text), "0.000")
            TG.Item(3, NRI).Value = Format(Val(txtRate.Text), "0.00")
            TG.Item(4, NRI).Value = Format(Val(txtAmount.Text), "0.00")

            'txtCode.Clear()
            'txtQty.Clear()
            'txtRate.Clear()
            'txtAmount.Clear()
            txtCode.Focus()

            CalculateTotal()

        End If

    End Sub

    Private Sub CalculateTotal()

        Dim TQty As Short = 0
        Dim TAmt As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TQty += Val(TG.Item(2, i).Value)
            TAmt += Val(TG.Item(4, i).Value)

        Next

        lblTQty.Text = TQty
        lblTAmt.Text = Format(TAmt, "0.00")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cmbVendor.SelectedIndex = -1 Then
            TTip.Show("Vendor not selected..!", cmbVendor, 0, 25, 2000)
            cmbVendor.Focus()
            Exit Sub
        ElseIf cmbDLoc.SelectedIndex = -1 Then
            TTip.Show("Godown not selected..!", cmbDLoc, 0, 25, 2000)
            cmbDLoc.Focus()
            Exit Sub
        ElseIf IsDate(mebEDDt.Text) = False Then
            TTip.Show("Incorrect delivery date..!", mebEDt, 0, 25, 2000)
            mebEDt.Focus()
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

            GenerateOrderNo()

            SQL = "insert into ordermaster values (" _
                & Val(txtOrderNo.Text) & ",'" _
                & Format(CDate(mebOrderDt.Text), "yyyy-MM-dd") & "','" _
                & Format(CDate(mebEDDt.Text), "yyyy-MM-dd") & "'," _
                & cmbVendor.SelectedValue & "," _
                & cmbDLoc.SelectedValue & ",'" _
                & txtRmrks.Text.Trim & "'," _
                & Val(lblTQty.Text) & "," _
                & Val(lblTAmt.Text) & ",0," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into orderdetails values (" _
                    & Val(txtOrderNo.Text) & ",0,'" _
                    & Trim(TG.Item(1, i).Value) & "'," _
                    & Val(TG.Item(2, i).Value) & "," _
                    & Val(TG.Item(3, i).Value) & "," _
                    & Val(TG.Item(0, i).Value) & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()
            If MsgBox("Purchase order saved successfully, Do you want to print..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                PrintReport(Val(txtOrderNo.Text))
            End If
            RefreshForm()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub RefreshForm()

        lblTAmt.Text = "0.00"
        lblTQty.Text = "0.000"
        ESSA.ClearTextBox(Panel1)
        GenerateOrderNo()
        mebEDDt.Clear()
        TG.Rows.Clear()
        mebEDDt.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        LoadStore()
        LoadVendors()
        RefreshForm()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub PrintReport(ByVal OrdNo As Integer)

        SQL = "select c.companyname,c.address1,c.address2,c.city,('PH : ' + c.phone) phone,('TIN :' + c.tin) TIN,v.vendorname,v.city,m.orderno,m.orderdt,m.eddt," _
            & "d.pludesc,d.quantity from icompany c,vendors v,ordermaster m,orderdetails d where m.shopid=c.companyid and " _
            & "m.orderno=d.orderno and m.vendorid=v.vendorid and m.orderno=" & OrdNo & " order by d.sno"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                ReportViewer.CViewer.ReportSource = Rpt
                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub btnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprint.Click

        ESSA.MovetoCenter(pnlOList, Me)

        SQL = "select m.orderno,m.orderdt,v.vendorname,totalquantity,totalamount from ordermaster m,vendors v " _
            & "where m.vendorid=v.vendorid order by m.orderno"

        TGLst.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2)
                TGLst.Item(3, TGLst.Rows.Count - 1).Value = .Item(3)
                TGLst.Item(4, TGLst.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            End While
            .Close()
        End With

        If TGLst.Rows.Count > 0 Then
            pnlOList.Visible = True
            TGLst.Focus()
        End If

    End Sub

    Private Sub TGLst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TGLst.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PrintReport(Val(TGLst.Item(0, TGLst.CurrentRow.Index).Value))
        End If

    End Sub

End Class