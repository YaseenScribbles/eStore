'******************************************* Bismillah ******************************************
Imports System.Data.SqlClient
Public Class DirectGRN2

    Private ProductTable As New DataTable
    Private Edit As Boolean = False
    Private VDRTbl As New DataTable
    Private Dummy As New DataTable
    Private VendorID As Short = 0

    Private Sub LoadVendorList()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            VDRTbl.Clear()
            Adp.Fill(VDRTbl)
        End Using
        Con.Close()

        ApplyVendorList(False, "")

    End Sub

    Private Sub ApplyVendorList(EnableFilter As Boolean, FilterValue As String)

        Try

            If EnableFilter = True Then
                Dim DR = VDRTbl.Select("vendorname like '%" & FilterValue & "%'").CopyToDataTable
                LstVendors.DataSource = DR
                LstVendors.DisplayMember = "vendorname"
                LstVendors.ValueMember = "vendorid"
            ElseIf VDRTbl.Rows.Count > 0 Then
                LstVendors.DataSource = VDRTbl
                LstVendors.DisplayMember = "vendorname"
                LstVendors.ValueMember = "vendorid"
            End If

        Catch ex As Exception
            LstVendors.DataSource = Nothing
        End Try

    End Sub

    Private Sub RefreshForm()

        btnEdit.Enabled = True
        btnSave.Enabled = True
        pnlBillSundry.Visible = False
        lblTItms.Text = "0.000"
        lblNett.Text = "0.00"
        TGTax.Rows.Clear()
        TG.Rows.Clear()
        ESSA.ClearTextBox(Panel1)
        VendorID = 0
        txtVendor.Text = ""
        LstVendors.Visible = False
        mebRefDt.Text = ""
        mebLrDt.Text = ""
        mebInvDt.Text = ""
        mebGRNDt.Text = Format(Now.Date, "dd-MM-yyyy")
        GenerateGRNNo()
        Edit = False
        txtRefNo.Focus()

    End Sub

    Private Sub InitializeProduct()

        SQL = "select pluid,plucode,pluname,units,costprice,retailprice from productmaster order by pluid"
        Using nCon As New SqlConnection(ConStr)
            nCon.Open()
            Using Adp As New SqlDataAdapter(SQL, nCon)
                ProductTable.Clear()
                Adp.Fill(ProductTable)
            End Using
            nCon.Close()
        End Using

    End Sub

    Private Sub DirectGRN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                If pnlBillSundry.Visible = True Then
                    btnDone.PerformClick()
                Else
                    btnSave.PerformClick()
                End If
            Case Keys.F3
                btnEdit.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                If pnlGList.Visible = True Then pnlGList.Visible = False : Exit Sub
                If pnlBillSundry.Visible = True Then pnlBillSundry.Visible = False : Exit Sub
                MainWindowX.CloseTab(Me.Name)
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub LoadLedgers()

        SQL = "SELECT LEDGERID,LEDGERNAME FROM LEDGER WHERE GROUPID=5 ORDER BY LEDGERNAME"
        ESSA.LoadCombo(cmbLedger, SQL, "LEDGERNAME", "LEDGERID")

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

    Private Sub DirectGRN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadColors()
        cmbMode.SelectedIndex = 0
        InitializeProduct()
        LoadVendorList()
        LoadLedgers()
        ESSA.LoadStore(cmbGodown)
        GenerateGRNNo()
        mebGRNDt.Text = Format(Now.Date, "dd-MM-yyyy")
        txtRefNo.Select()

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVdr, SQL, "vendorname", "vendorid", "All Vendor(s)")

    End Sub

    Private Sub GenerateGRNNo()

        SQL = "select max(grnno) from grnmaster"
        txtGRNNo.Text = ESSA.GenerateID(SQL)

    End Sub

    'Private Sub LoadVendors()

    '    SQL = "select vendorid,vendorname from vendors order by vendorname"
    '    ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    'End Sub

    Private Sub mebRefDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mebRefDt.Leave, mebInvDt.Leave, mebLrDt.Leave

        If IsDate(CType(sender, MaskedTextBox).Text) = False Then
            CType(sender, MaskedTextBox).Text = Format(Now.Date, "dd-MM-yyyy")
        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Dim NRI As Integer = 0

            If txtCode.Text.Trim = "" Then
                TTip.Show("Product code should not be empty..!", txtCode, 0, 25, 2000)
                txtCode.Focus()
                Exit Sub
            ElseIf Val(txtEnd.Text) < Val(txtBegin.Text) Then
                TTip.Show("End level should not less than begin level..!", txtEnd, 0, 25, 2000)
                txtEnd.Clear()
                txtEnd.Focus()
                Exit Sub
            ElseIf Val(txtQty.Text) <= 0 Then
                TTip.Show("Quantity should not be zero..!", txtQty, 0, 25, 2000)
                Exit Sub
            End If

            SQL = "SELECT pluid,plucode,pluname,units,costprice,retailprice from productmaster where plucode in (" _
                & CombineCode(txtCode.Text) & ") order by pluid"

            With ESSA.OpenReader(SQL)

                While .Read

                    NRI = ESSA.FindGridIndex(TG, 1, .Item(0))
                    If NRI = -1 Then NRI = TG.Rows.Add

                    TG.Item(0, NRI).Value = .Item(0)
                    TG.Item(1, NRI).Value = .GetString(1)
                    TG.Item(2, NRI).Value = .GetString(2)
                    TG.Item(3, NRI).Value = .GetString(3)
                    TG.Item(4, NRI).Value = Format(Val(txtQty.Text), "0.000")
                    TG.Item(5, NRI).Value = Format(.Item(4), "0.0000")
                    TG.Item(6, NRI).Value = Format(Val(txtQty.Text) * Val(TG.Item(5, NRI).Value), "0.00")
                    TG.Item(7, NRI).Value = Format(.Item(5), "0.0000")


                End While

                .Close()

            End With

            CalculateTotal()

            'txtCode.Clear()
            'txtBegin.Clear()
            'txtStep.Clear()
            'txtEnd.Clear()
            'txtQty.Clear()
            txtCode.Focus()

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
            Case Else
                SizeToCode = ""

        End Select

    End Function

    Private Function CombineCode(ByVal Code As String) As String

        CombineCode = ""

        Dim pcc As SByte = 0 'Picked Color Count

        If chkCBE.Checked = True Then
            pcc = TGPick.Rows.Count - 1
        End If

        For c As SByte = 0 To pcc

            For i As SByte = Val(txtBegin.Text) To Val(txtEnd.Text) Step Val(txtStep.Text)

                If chkSBC.Checked = True Then
                    CombineCode &= "'" & Code & IIf(chkCBE.Checked = True, GetColorCode(c), "") & SizeToCode(i) & "',"
                Else
                    CombineCode &= "'" & Code & IIf(chkCBE.Checked = True, GetColorCode(c), "") & i & "',"
                End If

            Next

        Next

        If CombineCode.Length > 0 Then
            CombineCode = Mid(CombineCode, 1, CombineCode.Length - 1)
        End If

    End Function

    Private Function GetColorCode(ByVal Index As SByte) As String

        GetColorCode = ""

        If chkCBE.Checked = True Then
            GetColorCode = TGPick.Item(1, Index).Value
        End If

    End Function

    Private Sub CalculateTotal()

        Dim TotQty As Double = 0
        Dim TotAmt As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TotQty += Val(TG.Item(4, i).Value)
            TotAmt += Val(TG.Item(4, i).Value) * Val(TG.Item(5, i).Value)

        Next

        lblTItms.Text = Format(TotQty, "0.000")
        txtTotAmt.Text = Format(TotAmt, "0.00")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If VendorID = 0 Then
            TTip.Show("Vendor not selected..!", txtVendor, 0, 25, 2000)
            txtVendor.Focus()
            Exit Sub
        ElseIf IsDate(mebRefDt.Text) = False Then
            TTip.Show("Incorrect Refrence date..!", mebRefDt, 0, 25, 2000)
            mebRefDt.Focus()
            Exit Sub
        ElseIf IsDate(mebInvDt.Text) = False Then
            TTip.Show("Incorrect invoice date..!", mebInvDt, 0, 25, 2000)
            mebInvDt.Focus()
            Exit Sub
        ElseIf IsDate(mebLrDt.Text) = False Then
            TTip.Show("Incorrect L.R date..!", mebLrDt, 0, 25, 2000)
            mebLrDt.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            TTip.Show("No products to save..!", btnSave, 0, 25, 2000)
            Exit Sub
        End If

        TaxTotal()
        pnlBillSundry.Visible = True
        cmbLedger.Focus()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlBillSundry.Visible = False

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim NRI = ESSA.FindGridIndex(TGTax, 0, cmbLedger.SelectedValue)
            If NRI = -1 Then NRI = TGTax.Rows.Add

            TGTax.Item(0, NRI).Value = cmbLedger.SelectedValue
            TGTax.Item(1, NRI).Value = cmbLedger.Text
            TGTax.Item(2, NRI).Value = cmbMode.Text
            TGTax.Item(3, NRI).Value = Format(Val(txtAmount.Text), "0.00")
            TGTax.Item(4, NRI).Value = Format(IIf(cmbMode.SelectedIndex = 0, Val(txtAmount.Text), -Val(txtAmount.Text)), "0.00")
            TGTax.Item(5, NRI).Value = Val(txtPerc.Text)
            TaxTotal()

            txtAmount.Clear()
            cmbLedger.Focus()

        End If

    End Sub

    Private Sub TaxTotal()

        Dim TAmt As Double = 0

        For i As SByte = 0 To TGTax.Rows.Count - 1
            TAmt += Val(TGTax.Item(4, i).Value)
        Next

        lblNett.Text = Format(Val(0) + TAmt, "0.00")

    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click

        Dim OrderNo As Integer = Val(cmbOrderNo.Text)

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try


            If Edit = True Then
                SQL = "delete from grnmaster where grnno=" & Val(txtGRNNo.Text) & ";" _
                    & "delete from grndetails where grnno=" & Val(txtGRNNo.Text) & ";" _
                    & "delete from grntax where grnno=" & Val(txtGRNNo.Text) & ";" _
                    & "delete from ordermaster where grnno=" & Val(txtGRNNo.Text) & ";" _
                    & "delete from orderdetails where orderno in (select orderno from ordermaster where grnno=" & Val(txtGRNNo.Text) & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateGRNNo()
            End If

            If Edit = False Then

                '******************************************************************************
                '                       Begin Order Process
                '------------------------------------------------------------------------------

                If cmbOrderNo.SelectedIndex = 0 Then
                    OrderNo = ESSA.GenerateID("select max(orderno) from ordermaster")
                Else
                    OrderNo = cmbOrderNo.Text
                End If

                If cmbOrderNo.SelectedIndex > 0 Then

                    SQL = "update ordermaster set totalquantity=" _
                        & Val(lblTItms.Text) & ",TotalAmount=" _
                        & Val(0) & ",GRNNo=" _
                        & Val(txtGRNNo.Text) & ",UserID=" _
                        & UserID & " where orderno=" & OrderNo

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                    SQL = "delete from orderdetails where orderno=" & OrderNo
                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                Else

                    SQL = "insert into ordermaster values (" _
                        & OrderNo & ",'" _
                        & Format(CDate(mebGRNDt.Text), "yyyy-MM-dd") & "','" _
                        & Format(CDate(mebGRNDt.Text), "yyyy-MM-dd") & "'," _
                        & VendorID & "," _
                        & cmbGodown.SelectedValue & ",''," _
                        & Val(lblTItms.Text) & "," _
                        & Val(0) & "," _
                        & Val(txtGRNNo.Text) & "," _
                        & ShopID & "," _
                        & UserID & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

                For i As Short = 0 To TG.Rows.Count - 1

                    SQL = "insert into orderdetails values (" _
                        & OrderNo & "," _
                        & Val(TG.Item(0, i).Value) & ",'" _
                        & Trim(TG.Item(1, i).Value) & "'," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & i + 1 & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                Next

                '******************************************************************************
                '                       End of Order Process
                '------------------------------------------------------------------------------

            End If

            SQL = "insert into grnmaster values (" _
                & Val(txtGRNNo.Text) & ",'" _
                & Format(CDate(mebGRNDt.Text), "yyyy-MM-dd") & "'," _
                & VendorID & ",'" _
                & txtRefNo.Text.Trim & "','" _
                & Format(CDate(mebRefDt.Text), "yyyy-MM-dd") & "','" _
                & txtInvNo.Text.Trim & "','" _
                & Format(CDate(mebInvDt.Text), "yyyy-MM-dd") & "','" _
                & txtLRNo.Text.Trim & "','" _
                & Format(CDate(mebLrDt.Text), "yyyy-MM-dd") & "'," _
                & OrderNo & "," _
                & Val(lblTItms.Text) & "," _
                & Val(0) & "," _
                & Val(lblNett.Text) & ",0,0," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into grndetails values (" _
                    & Val(txtGRNNo.Text) & ",'" _
                    & Format(CDate(mebGRNDt.Text), "yyyy-MM-dd") & "'," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & ",0," _
                    & Val(TG.Item(5, i).Value) & "," _
                    & i + 1 & ")" _
                    & ";update productmaster set qoh=qoh+" _
                    & Val(TG.Item(4, i).Value) & " where pluid=" _
                    & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            For j As SByte = 0 To TGTax.Rows.Count - 1

                SQL = "insert into grntax values (" _
                    & Val(txtGRNNo.Text) & "," _
                    & Val(TGTax.Item(0, j).Value) & "," _
                    & Val(TGTax.Item(4, j).Value) & "," _
                    & Val(TGTax.Item(5, j).Value) & "," _
                    & j + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

            If MsgBox("GRN saved successfully, do you want to print lable..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                SQL = "select m.pluid,m.plucode,m.pluname,d.qty,m.retailprice,m.id,substring(a.department,1,len(a.department) - 4) + '-' + a.category,a.style,a.material,a.color from productmaster m,grndetails d,productattributes a where m.pluid=d.pluid and a.pluid = m.pluid " _
                    & "and d.grnno=" & Val(txtGRNNo.Text) & " order by d.sno"

                LablePrinting.LoadProducts(SQL)
                MainWindowX.AddTab(LablePrinting)

            End If

            'xMessageBox.ShowMessage("GRN saved successfully..!", "Congratulations..!", xMessageBox.MessageBoxStyle.OKOnly)
            RefreshForm()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub TGTax_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TGTax.RowsRemoved

        TaxTotal()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        InitializeProduct()
        LoadVendorList()
        LoadLedgers()
        ESSA.LoadStore(cmbGodown)
        RefreshForm()

    End Sub

    'Private Sub cmbVendor_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

    '    If cmbVendor.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select convert(varchar,orderno) ordno from ordermaster where grnno=0 and vendorid=" & cmbVendor.SelectedValue & "  order by orderno"
    '    ESSA.LoadCombo(cmbOrderNo, SQL, "ordno", "", "New")

    'End Sub

    Private Sub DirectGRN_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        TG.Columns(2).Width = TG.Width - 620

        pnlGList.Top = (Me.Height - pnlGList.Height) / 2
        pnlGList.Left = (Me.Width - pnlGList.Width) / 2

        pnlBillSundry.Top = (Me.Height - pnlBillSundry.Height) / 2
        pnlBillSundry.Left = (Me.Width - pnlBillSundry.Width) / 2

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        pnlGList.Visible = True
        cmbVdr.Focus()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        TGGrn.Rows.Clear()

        SQL = "select m.grnno,m.grndt,v.vendorname,m.totalquantity,m.totalamount,m.billno from " _
            & "grnmaster m,vendors v where m.vendorid=v.vendorid"

        If cmbVdr.SelectedIndex > 0 Then
            SQL &= " and m.vendorid=" & cmbVdr.SelectedValue
        End If

        SQL &= " order by m.grnno desc"

        With ESSA.OpenReader(SQL)
            While .Read
                TGGrn.Rows.Add()
                TGGrn.Item(0, TGGrn.Rows.Count - 1).Value = .Item(0)
                TGGrn.Item(1, TGGrn.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MMM-yyyy")
                TGGrn.Item(2, TGGrn.Rows.Count - 1).Value = .GetString(2)
                TGGrn.Item(3, TGGrn.Rows.Count - 1).Value = .Item(3)
                TGGrn.Item(4, TGGrn.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TGGrn.Item(7, TGGrn.Rows.Count - 1).Value = .Item(5)
            End While
            .Close()
        End With

    End Sub

    Private Sub LoadOrders(ByVal iVendor As Short)

        SQL = "select convert(varchar,orderno) ordno from ordermaster where grnno=0 and vendorid=" & iVendor & "  order by orderno"
        ESSA.LoadCombo(cmbOrderNo, SQL, "ordno", "", "New")

    End Sub

    Private Sub TGGrn_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGGrn.CellClick

        If e.ColumnIndex = 5 Then

            SQL = "SELECT GRNNO,GRNDT,REFNO,REFDT,INVNO,INVDT,LRNO,LRDT,ORDERNO,VENDORID FROM GRNMASTER WHERE GRNNO=" & TGGrn.Item(0, e.RowIndex).Value & ";" _
                & "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,D.QTY,D.COSTPRICE,(D.QTY*D.COSTPRICE) AMOUNT,P.RETAILPRICE FROM " _
                & "PRODUCTMASTER P,GRNDETAILS D WHERE P.PLUID=D.PLUID AND D.GRNNO=" & TGGrn.Item(0, e.RowIndex).Value & " ORDER BY D.SNO"

            With ESSA.OpenReader(SQL)

                If .Read Then

                    btnSave.Enabled = False

                    If Val(TGGrn.Item(7, e.RowIndex).Value) > 0 Then
                        'btnSave.Enabled = False
                        btnEdit.Enabled = False
                    End If

                    txtGRNNo.Text = .Item(0)
                    mebGRNDt.Text = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                    txtRefNo.Text = .Item(2)
                    mebRefDt.Text = Format(.GetDateTime(3).Date, "dd-MM-yyyy")
                    txtInvNo.Text = .Item(4)
                    mebInvDt.Text = Format(.GetDateTime(5).Date, "dd-MM-yyyy")
                    txtLRNo.Text = .Item(6)
                    mebLrDt.Text = Format(.GetDateTime(7).Date, "dd-MM-yyyy")

                    LoadOrders(.Item(9))
                    VendorID = .Item(9)
                    txtVendor.Text = TGGrn.Item(2, e.RowIndex).Value
                    cmbOrderNo.SelectedIndex = cmbOrderNo.FindStringExact(.Item(8))

                End If

                .NextResult()

                TG.Rows.Clear()

                While .Read

                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                    TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3)
                    TG.Item(4, TG.Rows.Count - 1).Value = .Item(4)
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.000")
                    TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(6), "0.00")
                    TG.Item(7, TG.Rows.Count - 1).Value = Format(.Item(7), "0.000")

                End While

                .Close()

            End With

            CalculateTotal()
            pnlGList.Visible = False

        ElseIf e.ColumnIndex = 6 Then

            SQL = "select m.pluid,m.plucode,m.pluname,d.qty,m.retailprice,m.id,substring(a.department,1,len(a.department) - 4) + '-' + a.category,a.style,a.material,a.color from productmaster m,grndetails d,productattributes a where m.pluid=d.pluid and a.pluid = m.pluid " _
                & "and d.grnno=" & Val(TGGrn.Item(0, e.RowIndex).Value) & " order by d.sno"

            LablePrinting.LoadProducts(SQL)
            MainWindowX.AddTab(LablePrinting)

        ElseIf e.ColumnIndex = 8 Then

            If IsAdmin = False Then
                MsgBox("Access Denied..!", vbCritical)
                Exit Sub
            End If

            If Val(TGGrn.Item(7, e.RowIndex).Value) > 0 Then
                MsgBox("Unable to delete, Payment already processed..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MsgBox("Do you want to delete this entry..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = "delete from grnmaster where grnno=" & Val(TGGrn.Item(0, e.RowIndex).Value) & ";" _
                & "delete from grndetails where grnno=" & Val(TGGrn.Item(0, e.RowIndex).Value) & ";" _
                & "delete from grntax where grnno=" & Val(TGGrn.Item(0, e.RowIndex).Value)

            ESSA.Execute(SQL)

            MsgBox("GRN Deleted successfully..!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprint.Click

        SQL = "select m.pluid,m.plucode,m.pluname,d.qty,m.retailprice,m.id,substring(a.department,1,len(a.department) - 4) + '-' + a.category,a.style,a.material,a.color from productmaster m,grndetails d,productattributes a where m.pluid=d.pluid and a.pluid = m.pluid " _
            & "and d.grnno=" & Val(txtGRNNo.Text) & " order by d.sno"

        LablePrinting.LoadProducts(SQL)
        MainWindowX.AddTab(LablePrinting)

    End Sub

    Private Sub btnPickColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickColor.Click

        pnlColors.Visible = True
        txtCode.Focus()

    End Sub

    Private Sub btnReLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReLoad.Click

        TGColor.Rows.Clear()
        TGPick.Rows.Clear()
        LoadColors()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        pnlColors.Visible = False

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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        PickRow(False, TGColor, TGPick)

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

    Private Sub chkCBE_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCBE.CheckStateChanged

        btnPickColor.Enabled = chkCBE.Checked

    End Sub

    Private Sub txtVendor_Enter(sender As Object, e As EventArgs) Handles txtVendor.Enter

        LstVendors.Visible = True

    End Sub

    Private Sub txtVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendor.KeyDown

        If e.KeyCode = Keys.Enter Then
            LstVendors_KeyDown(sender, e)
        End If

    End Sub

    Private Sub txtVendor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtVendor.KeyUp

        If e.KeyCode = Keys.Down Then
            If LstVendors.SelectedIndex = LstVendors.Items.Count - 1 Then Exit Sub
            LstVendors.SelectedIndex = LstVendors.SelectedIndex + 1
        ElseIf e.KeyCode = Keys.Up Then
            If LstVendors.SelectedIndex < 1 Then Exit Sub
            LstVendors.SelectedIndex = LstVendors.SelectedIndex - 1
        ElseIf e.KeyCode <> Keys.Enter Then
            ApplyVendorList(True, txtVendor.Text)
        End If

    End Sub
    Private Sub LstVendors_KeyDown(sender As Object, e As KeyEventArgs) Handles LstVendors.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If LstVendors.SelectedIndex = -1 Then
                VendorID = 0
            Else
                VendorID = LstVendors.SelectedValue
                txtVendor.Text = LstVendors.Text
                SQL = "select convert(varchar,orderno) ordno from ordermaster where grnno=0 and vendorid=" & VendorID & "  order by orderno"
                ESSA.LoadCombo(cmbOrderNo, SQL, "ordno", "", "New")
                cmbOrderNo.Focus()
            End If
        End If

    End Sub

    Private Sub txtVendor_Leave(sender As Object, e As EventArgs) Handles txtVendor.Leave

        LstVendors.Visible = False

    End Sub

    Private Sub btnHideGRN_Click(sender As Object, e As EventArgs) Handles btnHideGRN.Click

        pnlGList.Visible = False

    End Sub

    Private Sub txtVendor_TextChanged(sender As Object, e As EventArgs) Handles txtVendor.TextChanged

    End Sub
End Class