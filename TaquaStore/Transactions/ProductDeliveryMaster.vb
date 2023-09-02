'**************************************** Bismillah *************************************************
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports OfficeOpenXml.FormulaParsing.Excel.Functions.Information
Imports OfficeOpenXml.FormulaParsing.Excel.Functions.Text

Public Class ProductDeliveryMaster

    Private DeliveryID As UShort
    Private DCode As String
    Private PluID As Integer
    Private CostPrice As Double = 0
    Private RetailPrice As Double = 0
    Private Edit As Boolean = False
    Private IsAutomatic As Boolean = False
    Private Sub ProductDeliveryChallan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSend.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                If pnlGList.Visible Then
                    pnlGList.Hide()
                    Exit Sub
                End If
                If MsgBox("Are you sure,do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                MainWindowX.CloseTab(Me.Name)
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Public Sub loadProductList(Optional entryNo As Integer = 0, Optional external As Boolean = False)

        'If isLocal Then

        '    SQL = "select uniqueid from deliverymastertemp where deliverycode='" & cmbDCode.Text.Trim & "';" _
        '        & "select p.pluid,p.plucode,p.pluname,d.quantity,d.costprice,d.retailprice from productmaster p,deliverydetailstemp d " _
        '        & "where p.pluid=d.pluid and d.deliverycode='" & cmbDCode.Text.Trim & "' order by sno"

        '    txtRemarks.Text = cmbDCode.SelectedValue

        'Else

        '    SQL = "SELECT Format(GetDate(),'yyyyMMddHHmmss');" _
        '        & "select p.pluid,p.plucode,p.pluname,d.qty,p.costprice,p.retailprice from productmaster p,ccdetails d " _
        '        & "where p.pluid=d.newcode and d.eno=" & entryNo & " order by sno"

        'End If

        SQL = "select p.pluid,p.plucode,p.pluname,d.qty,p.costprice,p.retailprice from productmaster p,ccdetails d " _
            & "where p.pluid=d.newcode and d.eno=" & entryNo & " order by sno"

        Dim Tot As Double = 0

        TG.Rows.Clear()

        With ESSA.OpenReader(SQL)

            'If .Read Then
            '    UniqueID = .GetString(0).Trim
            'End If

            '.NextResult()

            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                Tot += .Item(3)
            End While
            .Close()
        End With

        lblTQty.Text = Tot

        If TG.Rows.Count > 0 Then
            TG.CurrentCell = TG.Item(4, 0)
            TG.Focus()
        End If

        CalculateTotal()

        externalSource = external
        externalNumber = entryNo

    End Sub

    Private Sub ProductDeliveryChallan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbDCLocation, SQL, "shopdesc", "shopid")

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation2, SQL, "shopdesc", "shopid")

        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        pnlEntryType.Select()

        TGExl.ColumnHeadersDefaultCellStyle.Font = New Font(TGExl.Font, FontStyle.Bold)

        For i As SByte = 0 To 7
            TGExl.Rows.Add()
        Next

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        If TG.Rows.Count = 0 Then
            TTip.Show("No details to proceed..!", btnSend, 0, 25, 2000)
            Exit Sub
        ElseIf cmbDCLocation.SelectedIndex = -1 Then
            TTip.Show("Delivery location not selected..!", cmbDCLocation, 0, 25, 2000)
            cmbDCLocation.Focus()
            Exit Sub
            'ElseIf ExistanceCheck() Then
            '    TTip.Show("Code already exists in temporary delivery list..!", btnSend, 0, 25, 2000)
            '    Exit Sub
            'ElseIf IsReceived() Then
            '    TTip.Show("Code already exists in not received delivery list..!", btnSend, 0, 25, 2000)
            '    Exit Sub
        ElseIf Not StockCheck() Then
            TTip.Show("Insufficient Stock..!", btnSend, 0, 25, 2000)
            Exit Sub
        End If

        Dim id As Integer = ESSA.GenerateID("select max(id) from deliverymaster")

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction(IsolationLevel.Serializable)
        Cmd.Transaction = Trn

        Try

            If Edit = True Then

                SQL = "DELETE FROM DELIVERYMASTER WHERE DELIVERYCODE='" & DCode & "';" _
                    & "DELETE FROM DELIVERYDETAILS WHERE DELIVERYCODE='" & DCode & "'"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Else

                GenerateDeliveryCode()

                SQL = "delete from deliverymastertemp where deliverycode='" & DCode & "';" _
                    & "delete from deliverydetailstemp where deliverycode='" & DCode & "'"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            End If

            SQL = "insert into deliverymaster values ( " _
                & id & ", '" _
                & DCode & "','" _
                & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCLocation.SelectedValue & "," _
                & Val(lblTQty.Text) & "," _
                & Val(lblCAmt.Text) & "," _
                & Val(lblRAmt.Text) & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ")"


            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) > 0 Then

                    SQL = "insert into deliverydetails values (" _
                        & id & "," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(3, i).Value) & "," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & i + 1 & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            'If externalSource Then

            '    SQL = "update ccmaster set deliverycode='" _
            '        & DCode & "',completed=1 where eno=" _
            '        & externalNumber

            '    Cmd.CommandText = SQL
            '    Cmd.ExecuteNonQuery()

            'End If

            'Trn.Commit()
            'Con.Close()

            'If Edit = True Then

            '    SQL = "DELETE FROM DELIVERYMASTERTEMP WHERE DELIVERYCODE='" & DCode & "';" _
            '        & "DELETE FROM DELIVERYDETAILSTEMP WHERE DELIVERYCODE='" & DCode & "'"

            '    Cmd.CommandText = SQL
            '    Cmd.ExecuteNonQuery()

            'Else

            '    GenerateDeliveryCode()

            'End If

            'SQL = "insert into deliverymastertemp values ('" _
            '    & DCode & "','" _
            '    & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
            '    & ShopID & "," _
            '    & cmbDCLocation.SelectedValue & "," _
            '    & Val(lblTQty.Text) & "," _
            '    & Val(lblCAmt.Text) & "," _
            '    & Val(lblRAmt.Text) & ",0,'" _
            '    & txtRemarks.Text.Trim & "'," _
            '    & UserID & ",0,'" _
            '    & Format(Now, "yyyyMMddHHmmss") & "')"

            'Cmd.CommandText = SQL
            'Cmd.ExecuteNonQuery()

            'For i As Short = 0 To TG.Rows.Count - 1

            '    SQL = "insert into deliverydetailstemp values ('" _
            '        & DCode & "'," _
            '        & Val(TG.Item(0, i).Value) & "," _
            '        & Val(TG.Item(3, i).Value) & "," _
            '        & Val(TG.Item(4, i).Value) & "," _
            '        & Val(TG.Item(5, i).Value) & "," _
            '        & ShopID & "," _
            '        & cmbDCLocation.SelectedValue & "," _
            '        & i + 1 & ",0)"

            '    Cmd.CommandText = SQL
            '    Cmd.ExecuteNonQuery()

            'Next

            'If externalSource Then

            '    SQL = "update ccmaster set deliverycode='',completed=1 where eno=" _
            '        & externalNumber

            '    Cmd.CommandText = SQL
            '    Cmd.ExecuteNonQuery()

            'End If

            Trn.Commit()
            Con.Close()
            If MsgBox("Delivered successfully, Do you want to print challan..!", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                PrintDeliveryReport(id)
            End If
            RefreshForms()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub PrintDeliveryReport(id As Integer)

        Dim Rpt As New RptDeliveryChallan

        SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
            & "s1.shopname dfrom,s2.shopname dto from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
            & "m.deliveryfrom = s.shopid And m.id = d.id And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
            & " And m.deliveryto = s2.shopid and m.id=" & id & " order by d.sno"

        ESSA.OpenConnection()

        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                Rpt.PrintToPrinter(1, False, 0, 0)
            End Using
        End Using

        Con.Close()

    End Sub

    Private externalSource As Boolean = False
    Private externalNumber As Integer = 0

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    Private Sub RefreshForms()

        Edit = False
        lblStock.Text = "0"
        lblTQty.Text = "0"
        lblCAmt.Text = "0.00"
        lblRAmt.Text = "0 "
        txtRemarks.Clear()
        TG.Rows.Clear()
        ResetField()

    End Sub

    Private Sub ResetField()

        txtCode.Clear()
        txtProduct.Clear()
        txtQty.Clear()
        lblStock.Text = "0"
        txtCode.Focus()

    End Sub

    Private Sub GenerateDeliveryCode()

        'SQL = "select count(*) from deliverymastertemp where deliveryfrom=" & ShopID
        'DeliveryID = ESSA.GenerateID(SQL)
        'DCode = "Temp" & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

        SQL = "select max(CONVERT(INT,SUBSTRING(DELIVERYCODE,LEN(DELIVERYCODE)-4,LEN(DELIVERYCODE)))) ID from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        DeliveryID = ESSA.GenerateID(SQL)
        DCode = ShopCode & Strings.Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select p.pluid,plucode,pluname,v.stock,p.costprice,p.retailprice from productmaster p,v_stockpos v where p.pluid=v.pluid and v.location_id = " & ShopID & " and  plucode='" & txtCode.Text.Trim & "'"
            With ESSA.OpenReader(SQL)
                If .Read Then

                    PluID = .Item(0)
                    txtCode.Text = .GetString(1).Trim
                    txtProduct.Text = .GetString(2).Trim
                    lblStock.Text = .Item(3)
                    CostPrice = .Item(4)
                    RetailPrice = .Item(5)

                    SQL = "select pluid,batchid 'BATCH',rate 'PRICE' from productbatch where pluid=" & .Item(0) & " order by batchid"
                    ESSA.LoadDataGrid(TGBatch, SQL)
                    TGBatch.Columns(0).Visible = False
                    TGBatch.Columns(1).Width = 60
                    TGBatch.Columns(2).Width = 101

                    If TGBatch.Rows.Count > 1 Then
                        pnlBatch.Visible = True
                        txtBatchID.Text = "1"
                        txtBatchID.SelectAll()
                        txtBatchID.Focus()
                    Else
                        If IsAutomatic Then
                            txtQty.Text = 1
                            AutomatedEntry()
                        Else
                            txtQty.Focus()
                        End If
                    End If

                Else
                    txtCode.SelectAll()
                    TTip.Show("Sorry, Product code not found..!", txtCode, 0, 25, 2000)
                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Val(txtQty.Text) <= 0 Then
                TTip.Show("Quantity should not be zero..!", txtQty, 0, 25, 2000)
                Exit Sub
            End If

            AutomatedEntry()

            'Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)

            'If NRI = -1 Then

            '    If Val(txtQty.Text) > Val(lblStock.Text) Then
            '        txtQty.SelectAll()
            '        TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
            '        Exit Sub
            '    End If

            'Else

            '    If Val(TG.Item(3, NRI).Value) + Val(txtQty.Text) > Val(lblStock.Text) Then
            '        txtQty.SelectAll()
            '        TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
            '        Exit Sub
            '    End If

            'End If

            'If NRI = -1 Then NRI = TG.Rows.Add

            'TG.Item(0, NRI).Value = PluID
            'TG.Item(1, NRI).Value = txtCode.Text
            'TG.Item(2, NRI).Value = txtProduct.Text
            'TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtQty.Text)
            'TG.Item(4, NRI).Value = Format(CostPrice, "0.00")
            'TG.Item(5, NRI).Value = Format(RetailPrice, "0.00")
            'TG.Item(6, NRI).Value = Val(lblStock.Text)

            'CalculateTotal()

            'txtCode.Clear()
            'txtProduct.Clear()
            'txtQty.Clear()
            'lblStock.Text = "0"
            'txtCode.Focus()

        End If

    End Sub

    Private Sub AutomatedEntry()

        Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)

        If NRI = -1 Then

            If Val(txtQty.Text) > Val(lblStock.Text) Then
                txtQty.SelectAll()
                TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
                Exit Sub
            End If

        Else

            If Val(TG.Item(3, NRI).Value) + Val(txtQty.Text) > Val(lblStock.Text) Then
                txtQty.SelectAll()
                TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
                Exit Sub
            End If

        End If

        If NRI = -1 Then NRI = TG.Rows.Add

        TG.Item(0, NRI).Value = PluID
        TG.Item(1, NRI).Value = txtCode.Text
        TG.Item(2, NRI).Value = txtProduct.Text
        TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtQty.Text)
        TG.Item(4, NRI).Value = Format(CostPrice, "0.00")
        TG.Item(5, NRI).Value = Format(RetailPrice, "0.00")
        TG.Item(6, NRI).Value = Val(lblStock.Text)

        CalculateTotal()

        txtCode.Clear()
        txtProduct.Clear()
        txtQty.Clear()
        lblStock.Text = "0"
        txtCode.Focus()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Double = 0
        Dim CAmt As Double = 0
        Dim RAmt As Double = 0
        Dim Tmp As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1
            Tot += Val(TG.Item(3, i).Value)
            Tmp = Val(TG.Item(3, i).Value) * Val(TG.Item(4, i).Value)
            CAmt += Tmp
            Tmp = Val(TG.Item(3, i).Value) * Val(TG.Item(5, i).Value)
            RAmt += Tmp
        Next

        lblTQty.Text = Tot
        lblCAmt.Text = Format(CAmt, "0.00")
        lblRAmt.Text = Format(RAmt, "0.00")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnImportGRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportGRN.Click

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVdr, SQL, "vendorname", "vendorid", "All Vendor(s)")

        pnlGList.Visible = True
        cmbVdr.Focus()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        TGGrn.Rows.Clear()

        SQL = "select m.grnno,m.grndt,v.vendorname,m.totalquantity from " _
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
            End While
            .Close()
        End With

    End Sub

    Private Sub TGGrn_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGGrn.CellClick

        If e.ColumnIndex = 4 Then

            SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,D.QTY,D.COSTPRICE,P.RETAILPRICE, V.STOCK FROM " _
                & "PRODUCTMASTER P,GRNDETAILS D, V_STOCKPOS V WHERE P.PLUID=D.PLUID AND P.PLUID = V.PLUID AND V.LOCATION_ID = " & ShopID & "  AND D.GRNNO=" & TGGrn.Item(0, e.RowIndex).Value & " ORDER BY D.SNO"

            With ESSA.OpenReader(SQL)

                TG.Rows.Clear()

                While .Read

                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                    TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                    TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = .Item(6)

                End While

                .Close()

            End With

            pnlGList.Visible = False
            CalculateTotal()

        End If

    End Sub

    Private Sub ProductDeliveryMaster_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlAlter, Me)
        ESSA.MovetoCenter(pnlExcelImport, Me)
        ESSA.MovetoCenter(pnlEntryType, Me)

        pnlGList.Top = (Me.Height - pnlGList.Height) / 2
        pnlGList.Left = (Me.Width - pnlGList.Width) / 2

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub txtBatchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatchID.KeyDown

        TGBatch_KeyDown(sender, e)

    End Sub

    Private Sub txtBatchID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatchID.KeyUp

        If e.KeyCode = Keys.Down Then
            TGBatch.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TGBatch, 1, txtBatchID.Text.Trim)
        End If

    End Sub

    Private Sub TGBatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TGBatch.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RetailPrice = TGBatch.Item(2, TGBatch.CurrentRow.Index).Value
            txtBatchID.Clear()
            pnlBatch.Visible = False
            If IsAutomatic Then
                txtQty.Text = 1
                AutomatedEntry()
            Else
                txtQty.Focus()
            End If
        End If

    End Sub

    Private Sub btnAlter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlter.Click

        If IsAdmin Then
            pnlAlter.Visible = True
            cmbLocation2.Focus()
        End If

        'Select Case UserID
        '    Case UserID = 1
        '        pnlAlter.Visible = True
        '        cmbLocation2.Focus()
        '    Case UserID = 9
        '        pnlAlter.Visible = True
        '        cmbLocation2.Focus()
        '    Case Else
        '        MsgBox("Access Denied", MsgBoxStyle.Critical)
        '        Exit Sub
        'End Select


    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        SQL = "select deliverycode,deliverydate,totalqty from deliverymaster where status = 0 and deliveryto=" & cmbLocation2.SelectedValue & " order by deliverycode"

        With ESSA.OpenReader(SQL)
            TGAlter.Rows.Clear()
            While .Read
                TGAlter.Rows.Add()
                TGAlter.Item(0, TGAlter.Rows.Count - 1).Value = .GetString(0)
                TGAlter.Item(1, TGAlter.Rows.Count - 1).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                TGAlter.Item(2, TGAlter.Rows.Count - 1).Value = .Item(2)
                TGAlter.Item(3, TGAlter.Rows.Count - 1).Value = "ALTER"
                TGAlter.Item(4, TGAlter.Rows.Count - 1).Value = "DELETE"
            End While
            .Close()
        End With

    End Sub

    Private Sub BtnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHide.Click

        pnlAlter.Visible = False
        TGAlter.Rows.Clear()

    End Sub

    Private Sub TGAlter_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGAlter.CellClick

        If e.ColumnIndex = 3 Then

            'If Not InputBox("Enter Password", "ALTER DELIVERY") = "e##a" Then
            '    Exit Sub
            'End If

            SQL = "SELECT DELIVERYCODE,DELIVERYDATE,DELIVERYTO,REMARKS FROM DELIVERYMASTER " _
                & "WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "';" _
                & "SELECT D.PLUID,P.PLUCODE,P.PLUNAME,D.QUANTITY,D.COSTPRICE,D.RETAILPRICE,V.STOCK FROM " _
                & "DELIVERYDETAILS D,PRODUCTMASTER P, V_STOCKPOS V,DELIVERYMASTER M WHERE D.ID = M.ID AND D.PLUID = V.PLUID AND D.PLUID=P.PLUID AND V.LOCATION_ID = " & ShopID & " AND M.DELIVERYCODE='" _
                & TGAlter.Item(0, e.RowIndex).Value & "' ORDER BY D.SNO"

            TG.Rows.Clear()

            With ESSA.OpenReader(SQL)

                If .Read Then

                    Edit = True
                    DCode = .GetString(0)
                    cmbDCLocation.SelectedValue = .Item(2)
                    txtRemarks.Text = .GetString(3).Trim

                End If

                .NextResult()

                While .Read

                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                    TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                    TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = .Item(6)

                End While

                .Close()

            End With

            CalculateTotal()
            TGAlter.Rows.Clear()
            pnlAlter.Visible = False

        ElseIf e.ColumnIndex = 4 Then

            'If Not InputBox("Enter Password", "DELETE DELIVERY") = "taqua" Then
            '    Exit Sub
            'End If

            If MsgBox("Are you sure, do you want to delete..!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = $"update deliverymaster set status = 4 where deliverycode = '{ TGAlter.Item(0, e.RowIndex).Value }' "

            'SQL = "DELETE FROM DELIVERYMASTERTEMP WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "';" _
            '    & "DELETE FROM DELIVERYDETAILSTEMP WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "'"

            ESSA.Execute(SQL)
            MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)
            TGAlter.Rows.Clear()
            pnlAlter.Visible = False

        End If

    End Sub

    Private Sub TGAlter_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGAlter.CellContentClick

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        OFD.ShowDialog()
        txtFileName.Text = OFD.FileName

        If txtFileName.Text.Trim.Length > 0 Then

            lblLoading.Visible = True
            lblLoading.Refresh()

            Try

                Dim connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtFileName.Text + ";Extended Properties=""Excel 8.0;HDR=YES;"""
                TGExl.Rows.Clear()

                Using icon As New OleDbConnection(connectionString)
                    icon.Open()
                    Using Cmd As New OleDbCommand("select code,sum(qty) as qty1 from [sheet1$] group by code", icon)
                        Dim Rs = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        While Rs.Read
                            TGExl.Rows.Add()
                            TGExl.Item(1, TGExl.Rows.Count - 1).Value = Rs.Item(0)
                            TGExl.Item(3, TGExl.Rows.Count - 1).Value = Rs.Item(1)
                        End While
                    End Using
                    icon.Close()
                End Using


            Catch ex As Exception

                If ex.Message.Contains("valid name") Then
                    MsgBox("Worksheet name should be Sheet1", MsgBoxStyle.Critical)
                Else
                    MsgBox(ex.Message)
                End If

            End Try

        End If

        '// Step 2 : Update other database information

        ESSA.OpenConnection()
        Dim nCmd = Con.CreateCommand

        For i As Short = 0 To TGExl.Rows.Count - 1

            SQL = "select p.pluid,p.pluname,p.costprice,p.retailprice,v.stock from productmaster p,v_stockpos v " _
                & "where p.pluid=v.pluid and v.location_id = " & ShopID & "  and p.plucode='" & Trim(TGExl.Item(1, i).Value) & "'"

            nCmd.CommandText = SQL
            Dim Rs = nCmd.ExecuteReader(CommandBehavior.Default)

            With Rs

                If .Read Then
                    TGExl.Item(0, i).Value = .Item(0)
                    TGExl.Item(2, i).Value = .GetString(1).Trim
                    TGExl.Item(4, i).Value = Format(.Item(2), "0.00")
                    TGExl.Item(5, i).Value = Format(.Item(3), "0.00")
                    TGExl.Item(6, i).Value = .Item(4)
                Else
                    TGExl.Item(0, i).Value = 0
                    TGExl.Rows(i).DefaultCellStyle.BackColor = Color.Aqua
                End If

                .Close()

            End With

        Next

        Con.Close()

        lblLoading.Visible = False

    End Sub

    Private Sub btnHide2_Click(sender As Object, e As EventArgs) Handles btnHide2.Click

        pnlExcelImport.Visible = False

    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click

        pnlExcelImport.Visible = True
        txtFileName.Focus()

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        '// Check Stock Overflow

        For i As Short = 0 To TGExl.Rows.Count - 1

            If Val(TGExl.Item(0, i).Value) > 0 Then

                If Val(TGExl.Item(3, i).Value) > Val(TGExl.Item(6, i).Value) Then
                    MsgBox("Insufficient Stock..!", MsgBoxStyle.Critical)
                    Exit Sub
                    Exit For
                End If

            End If

        Next

        For i As Short = 0 To TGExl.Rows.Count - 1

            If Val(TGExl.Item(0, i).Value) = 0 Then

                MsgBox("Product not found..!", MsgBoxStyle.Critical)
                Exit Sub
                Exit For

            End If

        Next

        TG.Rows.Clear()

        For i As Short = 0 To TGExl.Rows.Count - 1

            If Val(TGExl.Item(0, i).Value) > 0 Then

                Dim NRI = TG.Rows.Add
                TG.Item(0, NRI).Value = Val(TGExl.Item(0, i).Value)
                TG.Item(1, NRI).Value = Trim(TGExl.Item(1, i).Value)
                TG.Item(2, NRI).Value = Trim(TGExl.Item(2, i).Value)
                TG.Item(3, NRI).Value = Val(TGExl.Item(3, i).Value)
                TG.Item(4, NRI).Value = Format(Val(TGExl.Item(4, i).Value), "0.00")
                TG.Item(5, NRI).Value = Format(Val(TGExl.Item(5, i).Value), "0.00")
                TG.Item(6, NRI).Value = Val(TGExl.Item(6, i).Value)
            End If
        Next

        CalculateTotal()
        pnlExcelImport.Visible = False

    End Sub

    Private Sub TGExl_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TGExl.CellEndEdit

        If Val(TGExl.Item(3, e.RowIndex).Value) > Val(TGExl.Item(6, e.RowIndex).Value) Then
            TGExl.Item(3, e.RowIndex).Value = Val(TGExl.Item(6, e.RowIndex).Value)
            MsgBox("Insufficient Stock..!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnAutomatic_Click(sender As Object, e As EventArgs) Handles btnAutomatic.Click

        lblMode.Text = "Automatic"
        lblMode.ForeColor = Color.Maroon

        IsAutomatic = True
        txtQty.Enabled = IsAutomatic
        pnlEntryType.Hide()
        txtCode.Select()

    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click

        lblMode.Text = "Manual"
        lblMode.ForeColor = Color.Navy

        IsAutomatic = False
        txtQty.Enabled = Not IsAutomatic
        pnlEntryType.Hide()
        txtCode.Select()

    End Sub

    Private Sub TG_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TG.CellFormatting

        For i As Integer = 0 To TG.Rows.Count - 1
            If Val(TG.Item(3, i).Value) > Val(TG.Item(6, i).Value) Then
                TG.Item(6, i).Style.ForeColor = Color.Red
            End If
        Next

    End Sub

    Private Function ExistanceCheck() As Boolean

        ExistanceCheck = False
        Dim Qry = "SELECT PluId FROM DeliveryDetailsTemp"
        With ESSA.OpenReader(Qry)
            While .Read
                For i As Integer = 0 To TG.Rows.Count - 1
                    If Val(TG.Item(0, i).Value) = .Item(0) Then
                        ExistanceCheck = True
                    End If
                Next
            End While
            .Close()
        End With

    End Function

    Private Function IsReceived() As Boolean

        IsReceived = True
        Dim Qry = $"select dd.pluid	 
        from deliverydetails dd
        inner join deliverymaster dm on dd.deliverycode = dm.deliverycode 
        and dm.status = 0"
        With ESSA.OpenReader(Qry)
            While .Read
                For i As Integer = 0 To TG.Rows.Count - 1
                    If Val(TG.Item(0, i).Value) = .Item(0) Then
                        IsReceived = True
                    End If
                Next
            End While
            .Close()
        End With

    End Function

    Private Function StockCheck() As Boolean

        StockCheck = True
        For i As Integer = 0 To TG.Rows.Count - 1
            If TG.Item(3, i).Value > TG.Item(6, i).Value Then
                StockCheck = False
            End If
        Next

    End Function

End Class