'**************************** In the name of Allah, Most Merciful, Most Compassionate ********************************
Imports System.Data.SqlClient
Public Class ProductStatusReport

    'Private Rpt As New RptProductStatusReport
    Private Rpt As New ProductStatusReportNew

    Private Sub ProductStatusReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid", "All Vendors")

        SQL = "select DISTINCT state from vendors order by state"
        ESSA.LoadCombo(cmbState, SQL, "state", "", "All States")

        SQL = "SELECT DISTINCT DeptId, Department FROM TSDepartment ORDER BY Department"
        ESSA.LoadCombo(cmbDept, SQL, "Department", "Deptid", "All Departments")

        SQL = "SELECT DISTINCT CatId, Category FROM TSCategory ORDER BY Category"
        ESSA.LoadCombo(cmbCat, SQL, "Category", "CatId", "All Categories")

        SQL = "SELECT DISTINCT StyleId, Style FROM TSStyle ORDER BY Style"
        ESSA.LoadCombo(cmbStyle, SQL, "Style", "StyleId", "All Styles")

        SQL = "SELECT DISTINCT MaterialId, Material FROM TSMaterial ORDER BY Material"
        ESSA.LoadCombo(cmbMat, SQL, "Material", "MaterialId", "All Materials")

        TG.Columns(3).HeaderText = "L02" & vbCrLf & "SALES"
        TG.Columns(4).HeaderText = "L02" & vbCrLf & "STOCK"
        TG.Columns(5).HeaderText = "L04" & vbCrLf & "SALES"
        TG.Columns(6).HeaderText = "L04" & vbCrLf & "STOCK"
        TG.Columns(7).HeaderText = "L05" & vbCrLf & "SALES"
        TG.Columns(8).HeaderText = "L05" & vbCrLf & "STOCK"

        TG.Columns(9).HeaderText = "NOT" & vbCrLf & "RECEIVED"
        TG.Columns(10).HeaderText = "PARTY" & vbCrLf & "RETURN"
        TG.Columns(11).HeaderText = "GENERAL" & vbCrLf & "DELIVERY"
        TG.Columns(12).HeaderText = "WAREHOUSE" & vbCrLf & " STOCK "

        TG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'TG.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'TG.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'TG.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'TG.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        TG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        mebFrom.Select()



        'SQL = "Select shopid,shopcode from shops where shoptype='RETAIL' order by shopid"
        'With ESSA.OpenReader(SQL)
        '    While .Read

        '        Dim CI = TG.Columns.Add("", .Item(0))
        '        TG.Columns(CI).Visible = False

        '        CI = TG.Columns.Add("", .GetString(1) & vbCrLf & "Sales")
        '        TG.Columns(CI).Width = 60
        '        TG.Columns(CI).SortMode = DataGridViewColumnSortMode.NotSortable
        '        TG.Columns(CI).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        TG.Columns(CI).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '        CI = TG.Columns.Add("", .GetString(1) & vbCrLf & "Stock")
        '        TG.Columns(CI).Width = 60
        '        TG.Columns(CI).SortMode = DataGridViewColumnSortMode.NotSortable
        '        TG.Columns(CI).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        TG.Columns(CI).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '    End While
        '    .Close()
        'End With

        'Dim CIA = TG.Columns.Add("", "Party" & vbCrLf & "Return")
        'TG.Columns(CIA).Width = 80
        'TG.Columns(CIA).SortMode = DataGridViewColumnSortMode.NotSortable
        'TG.Columns(CIA).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'TG.Columns(CIA).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'CIA = TG.Columns.Add("", "General" & vbCrLf & "Delivery")
        'TG.Columns(CIA).Width = 80
        'TG.Columns(CIA).SortMode = DataGridViewColumnSortMode.NotSortable
        'TG.Columns(CIA).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'TG.Columns(CIA).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'CIA = TG.Columns.Add("", "Warehouse" & vbCrLf & "Stock")
        'TG.Columns(CIA).Width = 80
        'TG.Columns(CIA).SortMode = DataGridViewColumnSortMode.NotSortable
        'TG.Columns(CIA).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'TG.Columns(CIA).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        SQL = "SELECT DISTINCT V.VendorName,PS.Category, " _
            & "SUM(PS.Purchase) PURCHASE," _
            & "SUM(PS.SalesL2) SalesL2,SUM(StockL2) StockL2, " _
            & "SUM(PS.SalesL4) SalesL4,SUM(StockL4) StockL4, " _
            & "SUM(PS.SalesL5) SalesL5,SUM(StockL5) StockL5, " _
            & "SUM(PS.NotReceived) NotReceived,SUM(PS.PartyReturn) PartyReturn,SUM(PS.GeneralDelivery) GeneralDelivery,SUM(PS.WHStock) WHStock " _
            & "FROM V_ProductStatus PS INNER JOIN Vendors V ON V.VendorId = PS.VendorId  WHERE GrnDt BETWEEN '" _
            & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " And PS.VendorId = " & cmbVendor.SelectedValue
        End If

        If cmbState.SelectedIndex > 0 Then
            SQL &= " And V.State = '" & cmbState.Text.Trim & "'"
        End If

        If cmbDept.SelectedIndex > 0 Then
            SQL &= " And PS.Department = '" & cmbDept.Text.Trim & "'"
        End If

        If cmbCat.SelectedIndex > 0 Then
            SQL &= " And PS.Category = '" & cmbCat.Text.Trim & "'"
        End If

        If cmbStyle.SelectedIndex > 0 Then
            SQL &= " And PS.Style = '" & cmbStyle.Text.Trim & "'"
        End If

        If cmbMat.SelectedIndex > 0 Then
            SQL &= " And PS.Material = '" & cmbMat.Text.Trim & "'"
        End If

        If chkSGW.Checked = True Then
            SQL &= " And PS.GrnNo = " & Val(cmbGRN.Text.Trim)
        End If

        SQL &= " GROUP BY PS.Category,V.VendorName ORDER BY V.VendorName,PS.Category"

        pnlLoad.Show() : pnlLoad.Refresh()

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                Dim Row = TG.Rows.Add()
                TG.Item(0, Row).Value = .GetString(0).Trim
                TG.Item(1, Row).Value = .GetString(1).Trim
                TG.Item(2, Row).Value = Val(.Item(2))
                TG.Item(3, Row).Value = Val(.Item(3))
                TG.Item(4, Row).Value = Val(.Item(4))
                TG.Item(5, Row).Value = Val(.Item(5))
                TG.Item(6, Row).Value = Val(.Item(6))
                TG.Item(7, Row).Value = Val(.Item(7))
                TG.Item(8, Row).Value = Val(.Item(8))
                TG.Item(9, Row).Value = Val(.Item(9))
                TG.Item(10, Row).Value = Val(.Item(10))
                TG.Item(11, Row).Value = Val(.Item(11))
                TG.Item(12, Row).Value = Val(.Item(12))
            End While
            .Close()

        End With

        For i As Short = 0 To TG.Rows.Count - 1
            For j As Short = 3 To TG.Columns.Count - 1
                If Val(TG.Item(j, i).Value) = 0 Then
                    TG.Item(j, i).Value = ""
                End If
            Next
        Next

        pnlLoad.Hide()

        'SQL = "Select A.CatId,A.Category, SUM(D.Qty ) PURCHASE
        '       FROM GRNMaster M, GRNDetails D, ProductAttributes A
        '       WHERE M.GrnNo = D.GRNNo AND D.PluID = A.PluId AND M.GrnDt BETWEEN '" _
        '       & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        'SQL &= " and m.vendorid=" & cmbVendor.SelectedValue

        'If chkSGW.Checked = True Then
        '    SQL &= " and m.grnno=" & cmbGRN.Text.Trim
        'End If

        'If cmbCat.SelectedIndex > 0 Then
        '    SQL &= " and A.CatId=" & cmbCat.SelectedValue
        'End If

        'If cmbSCat1.SelectedIndex > 0 Then
        '    SQL &= " and A.StyleId=" & cmbSCat1.SelectedValue
        'End If

        'SQL &= "GROUP BY A.CatId,A.Category ORDER BY A.Category"

        'TG.Rows.Clear()

        'With ESSA.OpenReader(SQL)

        '    While .Read

        '        TG.Rows.Add()
        '        TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
        '        TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
        '        TG.Item(2, TG.Rows.Count - 1).Value = .Item(2)

        '    End While

        '    .Close()

        'End With

        'pnlLoad.Show() : pnlLoad.Refresh()
        'LoadSales()
        'pnlLoad.Hide()

    End Sub

    Private Sub LoadSales()

        Dim Tot As Double = 0
        Dim ReturnToParty As Double = 0
        Dim GenDelivery As Double = 0
        Dim WHStock As Double = 0

        For j As Short = 0 To TG.Rows.Count - 1

            Tot = 0
            ReturnToParty = 0
            GenDelivery = 0
            WHStock = 0


            For i As SByte = 3 To TG.Columns.Count - 3 Step 3

                'SQL = "select a.scatdesc1,a.sales,isnull((b.dc-a.sales),b.dc) stock  from" _
                '    & "(select l.scatid1,l.scatdesc1,sum(bd.qty) sales from billdetails bd,grndetails gd,productlevels l,grnmaster gm where " _
                '    & "bd.pluid=l.pluid and gd.pluid=l.pluid and gm.grnno=gd.grnno and bd.shopid=" & Val(TG.Columns(i).HeaderText) _
                '    & " and l.scatid1=" & Val(TG.Item(0, j).Value) & " and gm.grndt between '" _
                '    & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

                SQL = "SELECT A.Category,SUM(A.Sales) Sales, SUM(A.Delivery - A.Sales- A.R2WH) Stock, SUM(A.R2P) PartyReturn, SUM(A.GD) GenDelivery FROM " _
                    & "(SELECT PA.Category,SUM(BD.Qty) Sales, 0 Delivery, 0 R2WH, 0 R2P , 0 GD " _
                    & "FROM BILLDETAILS BD,ProductMaster PM, ProductAttributes PA, GrnDetails GD, GrnMaster GM " _
                    & "WHERE BD.PluID = PM.PluId And PA.PluID = PM.PluId AND GD.PluId = PM.Size AND GD.GrnNo = GM.GrnNo " _
                    & " AND BD.ShopID=" & Val(TG.Columns(i).HeaderText) _
                    & " AND PA.Category = '" & TG.Item(1, j).Value & "'" _
                    & " And GM.GrnDt BETWEEN '" _
                    & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

                SQL &= " and GM.VendorId =" & cmbVendor.SelectedValue
                'End If

                If chkSGW.Checked = True Then
                    SQL &= " and GM.GrnNo =" & cmbGRN.Text.Trim
                End If

                'If cmbCat.SelectedIndex > 0 Then
                '    SQL &= " and l.catid=" & cmbCat.SelectedValue
                'End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= " and PA.CatId =" & cmbCat.SelectedValue
                End If

                'If cmbSCat1.SelectedIndex > 0 Then
                '    SQL &= " and l.scatid1=" & cmbSCat1.SelectedValue
                'End If

                If cmbMat.SelectedIndex > 0 Then
                    SQL &= " and PA.StyleId=" & cmbMat.SelectedValue
                End If

                'SQL &= " group by l.scatdesc1,l.scatid1) a left outer join " _
                '    & "(select l.scatid1,sum(d.quantity) dc from deliverymaster m,deliverydetails d,productlevels l,grndetails gd,grnmaster gm where m.deliverycode=d.deliverycode and " _
                '    & "l.pluid=d.pluid and gm.grnno=gd.grnno and gd.pluid=d.pluid and l.scatid1=" & Val(TG.Item(0, j).Value) & " and m.deliveryto=" & Val(TG.Columns(i).HeaderText) _
                '    & " and gm.grndt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

                SQL &= " GROUP BY PA.Category UNION ALL " _
                    & " SELECT PA.Category,0 Sales,SUM(DD.Quantity) Delivery , 0 R2WH, 0 R2P ,0 GD" _
                    & " FROM DeliveryDetails DD,ProductAttributes PA,ProductMaster PM, GrnDetails GD, GrnMaster GM " _
                    & " WHERE PM.PluID = DD.PluID And PM.PluId = PA.Pluid AND GD.PluId = PM.Size AND GD.GrnNo = GM.GrnNo " _
                    & " And DD.DeliveryTo = " & Val(TG.Columns(i).HeaderText) _
                    & " AND PA.Category = '" & TG.Item(1, j).Value & "'" _
                    & " And GM.GrnDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

                SQL &= " and GM.VendorId =" & cmbVendor.SelectedValue

                If chkSGW.Checked = True Then
                    SQL &= " and GM.GrnNo =" & cmbGRN.Text.Trim
                End If

                'If cmbCat.SelectedIndex > 0 Then
                '    SQL &= " and l.catid=" & cmbCat.SelectedValue
                'End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= " and PA.CatId =" & cmbCat.SelectedValue
                End If

                'If cmbSCat1.SelectedIndex > 0 Then
                '    SQL &= " and l.scatid1=" & cmbSCat1.SelectedValue
                'End If

                If cmbMat.SelectedIndex > 0 Then
                    SQL &= " and PA.StyleId =" & cmbMat.SelectedValue
                End If

                'SQL &= " group by l.scatid1) b on a.scatid1=b.scatid1"

                SQL &= " GROUP BY PA.Category UNION ALL " _
                    & " SELECT PA.Category,0 Sales,0 Delivery , 0 R2WH, 0 R2P, SUM(DC.Qty) GD" _
                    & " FROM DCDet DC,ProductAttributes PA,ProductMaster PM, GrnDetails GD,GrnMaster GM " _
                    & " WHERE PM.PluID = DC.PluID And PM.PluId = PA.Pluid AND GD.PluId = PM.Size AND GM.GrnNo = GD.GrnNo " _
                    & " AND PA.Category = '" & TG.Item(1, j).Value & "'" _
                    & " And GM.GrnDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

                SQL &= " and GM.VendorId =" & cmbVendor.SelectedValue

                If chkSGW.Checked = True Then
                    SQL &= " and GM.GrnNo =" & cmbGRN.Text.Trim
                End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= " and PA.CatId =" & cmbCat.SelectedValue
                End If

                If cmbMat.SelectedIndex > 0 Then
                    SQL &= " and PA.StyleId =" & cmbMat.SelectedValue
                End If

                SQL &= " GROUP BY PA.Category UNION ALL " _
                    & " SELECT PA.Category,0 Sales, 0 Delivery , SUM(RD.Quantity) R2WH, 0 R2P, 0 GD " _
                    & " FROM ReceivedDetails RD,ProductMaster PM, GrnDetails GD,ProductAttributes PA,GrnMaster GM " _
                    & " WHERE RD.PluId = PM.PluId And PM.PluID = PA.PluId And GD.PluId = PM.Size AND GM.GrnNo = GD.GrnNo AND RD.DeliveryFrom = " & Val(TG.Columns(i).HeaderText) _
                    & " And GM.GrnDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'" _
                    & " AND PA.Category = '" & TG.Item(1, j).Value & "'" _
                    & " AND GM.VendorId = " & cmbVendor.SelectedValue

                If chkSGW.Checked = True Then
                    SQL &= " and GM.GrnNo=" & cmbGRN.Text.Trim
                End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= " and PA.CatId=" & cmbCat.SelectedValue
                End If

                If cmbMat.SelectedIndex > 0 Then
                    SQL &= " and PA.StyleId=" & cmbMat.SelectedValue
                End If

                SQL &= " GROUP BY PA.Category UNION ALL " _
                    & " SELECT PA.Category,0 Sales, 0 Delivery,0 R2WH, SUM(RD.Qty) R2P, 0 GD FROM " _
                    & " RvchDetails RD, ProductAttributes PA, ProductMaster PM, GrnDetails GD, GrnMaster GM " _
                    & " WHERE RD.PluId = PA.PluId AND RD.PluId = PM.PLuId AND GD.PluId = PM.Size AND GD.GrnNo = GM.GrnNo " _
                    & " AND PA.Category = '" & TG.Item(1, j).Value & "'" _
                    & " AND GM.GrnDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'" _
                    & " AND GM.VendorId = " & cmbVendor.SelectedValue

                If chkSGW.Checked = True Then
                    SQL &= " and GM.GrnNo =" & cmbGRN.Text.Trim
                End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= " and PA.CatId =" & cmbCat.SelectedValue
                End If

                If cmbMat.SelectedIndex > 0 Then
                    SQL &= " and PA.StyleId =" & cmbMat.SelectedValue
                End If

                SQL &= " GROUP BY PA.Category) A GROUP BY A.Category"

                With ESSA.OpenReader(SQL)
                    If .Read Then
                        TG.Item(i + 1, j).Value = .Item(1)
                        TG.Item(i + 2, j).Value = .Item(2)
                        Tot += .Item(1) + .Item(2)
                        ReturnToParty = .Item(3)
                        GenDelivery = .Item(4)
                    End If
                    .Close()
                End With

                WHStock = Val(TG.Item(2, j).Value) - Tot - ReturnToParty - GenDelivery

                TG.Item(TG.Columns.Count - 3, j).Value = ReturnToParty
                TG.Item(TG.Columns.Count - 2, j).Value = GenDelivery
                TG.Item(TG.Columns.Count - 1, j).Value = WHStock

                If TG.Item(i + 1, j).Value = 0 And TG.Item(i + 2, j).Value = 0 Then
                    TG.Item(i + 1, j).Value = ""
                    TG.Item(i + 2, j).Value = ""
                End If

            Next
        Next

    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged

        'If cmbCat.SelectedIndex = -1 Then Exit Sub

        'SQL = "select scatid,scatdesc from subcategory1"

        'If cmbCat.SelectedIndex > 0 Then
        '    SQL &= " where pvscatid=" & cmbCat.SelectedValue
        'End If

        'SQL &= " order by scatdesc"

        'ESSA.LoadCombo(cmbSCat1, SQL, "scatdesc", "scatid", "All")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If TG.Rows.Count <= 0 Then
            MsgBox("No details to print..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "delete from mt_psr"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                'SQL = "insert into mt_psr values ('" _
                '    & TG.Item(1, i).Value & "'," _
                '    & Val(TG.Item(2, i).Value) & "," _
                '    & Val(TG.Item(4, i).Value) & "," _
                '    & Val(TG.Item(5, i).Value) & "," _
                '    & Val(TG.Item(7, i).Value) & "," _
                '    & Val(TG.Item(8, i).Value) & "," _
                '    & Val(TG.Item(10, i).Value) & "," _
                '    & Val(TG.Item(11, i).Value) & "," _
                '    & Val(TG.Item(12, i).Value) & "," _
                '    & i + 1 & ")"

                SQL = "insert into mt_psr values ('" _
                    & TG.Item(0, i).Value & "','" _
                    & TG.Item(1, i).Value & "'," _
                    & Val(TG.Item(2, i).Value) & "," _
                    & Val(TG.Item(3, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & "," _
                    & Val(TG.Item(5, i).Value) & "," _
                    & Val(TG.Item(6, i).Value) & "," _
                    & Val(TG.Item(12, i).Value) & "," _
                    & Val(TG.Item(10, i).Value) & "," _
                    & i + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()

            Using Adp As New SqlDataAdapter("select * from mt_psr order by sno", Con)
                Using Tbl As New DataTable
                    Adp.Fill(Tbl)
                    Rpt.SetDataSource(Tbl)
                    'Rpt.SetParameterValue("Vendor", cmbVendor.Text.Trim)
                    ReportViewer.CViewer.ReportSource = Rpt
                    ReportViewer.Visible = False
                    ReportViewer.Show(Me)
                End Using
            End Using

            Con.Close()

        Catch ex As SqlException
            Trn.Commit()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub ProductStatusReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlLoad, Me)

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex > 0 Then
            SQL = "select grnno from grnmaster where vendorid=" & cmbVendor.SelectedValue
            ESSA.LoadCombo(cmbGRN, SQL, "grnno")
        End If

    End Sub
End Class