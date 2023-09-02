Imports System.Data.SqlClient

Public Class frmCodeConvertor

    Private pluId As Integer = 0
    Private entryNo As Integer = 0
    Private entryDate As Date

    Private Sub frmCodeConvertor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tgLst.ColumnHeadersDefaultCellStyle.Font = New Font(tgLst.Font, FontStyle.Bold)
        tgView.ColumnHeadersDefaultCellStyle.Font = New Font(tgView.Font, FontStyle.Bold)

        loadLocationList()

    End Sub

    Private Sub printLabel(eno As Integer)

        SQL = "select m.pluid,m.plucode,m.pluname,d.qty,m.retailprice,m.id,substring(a.department,1,len(a.department) - 4) + '-' + a.category,a.style,a.material,a.color,d.plucode from " _
            & "productmaster m,ccdetails d,productattributes a where m.pluid=d.newcode and m.pluid = a.pluid " _
            & "And d.eno=" & eno & " order by d.sno"

        MainWindowX.AddTab(LablePrinting)

        LablePrinting.LoadProducts(SQL, True)
        LablePrinting.chkAlternate.Checked = True

    End Sub

    Private Sub loadLocationList()

        Dim sql = "SELECT ShopId, (ShopName + ' - ' + ShopCode) ShopName FROM Shops " _
                & "WHERE ShopType <> 'WAREHOUSE' AND Status=0 ORDER BY ShopId"

        ESSA.LoadCombo(cmbLocations, sql, "ShopName", "ShopId", "Select Location")

    End Sub

    Private Sub tgLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tgLst.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then
            tgLst.Rows.RemoveAt(e.RowIndex)
        End If

    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            fetchCode(txtCode.Text.Trim)

        End If

    End Sub

    Private Sub fetchCode(code As String)

        Dim sql = "SELECT M.PluId, M.Plucode, M.PluName, M.RetailPrice, V.Stock " _
                & "FROM V_StockPos V, ProductMaster M, ProductAttributes A " _
                & "WHERE A.PluId = M.PluId AND M.PluId = V.PluId AND " _
                & "M.Plucode = '" & code & "'"

        With ESSA.OpenReader(sql)
            If .Read Then
                pluId = .Item(0)
                txtCode.Text = .GetString(1).Trim
                txtName.Text = .GetString(2).Trim
                txtRate.Text = Format(.Item(3), "0.00")
                txtStock.Text = .Item(4)
                txtQty.Text = Val(txtStock.Text)
                txtQty.Focus()
            Else
                MsgBox("Product not found..!", MsgBoxStyle.Critical)
                pluId = 0
                txtCode.Focus()
            End If
            .Close()
        End With

    End Sub

    Private Sub txtRate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRate.KeyDown

        If e.KeyCode = Keys.Enter Then
            If pluId = 0 Then
                MsgBox("Product code not found..!", MsgBoxStyle.Critical)
                txtCode.Focus()
                Exit Sub
            ElseIf Val(txtQty.Text) <= 0 Then
                MsgBox("Quantity cannot be zero..!", MsgBoxStyle.Critical)
                txtQty.Focus()
                Exit Sub
            End If

            Dim rowIndex = ESSA.FindGridIndex(tgLst, 0, pluId)
            Dim quantity As Double = Val(txtQty.Text)
            If rowIndex <> -1 Then
                quantity += Val(tgLst.Item(3, rowIndex).Value)
            End If

            If quantity > Val(txtStock.Text) Then
                MsgBox("Insufficient stock or already in list..!", MsgBoxStyle.Critical)
                txtQty.Focus()
                Exit Sub
            End If

            e.SuppressKeyPress = True
            addRow(rowIndex, quantity)

        End If

    End Sub

    Private Sub addRow(rowIndex As Integer, quantity As Double)

        If rowIndex = -1 Then rowIndex = tgLst.Rows.Add

        tgLst.Item(0, rowIndex).Value = pluId
        tgLst.Item(1, rowIndex).Value = txtCode.Text.Trim
        tgLst.Item(2, rowIndex).Value = txtName.Text.Trim
        tgLst.Item(3, rowIndex).Value = quantity
        tgLst.Item(4, rowIndex).Value = Format(Val(txtRate.Text), "0.00")

        clearFields()

    End Sub

    Private Sub clearFields()

        pluId = 0
        txtCode.Clear()
        txtName.Clear()
        txtQty.Clear()
        txtRate.Clear()
        txtCode.Focus()

    End Sub

    Private edit As Boolean = False
    Private completed As Boolean = False

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbLocations.SelectedIndex = 0 Then
            MsgBox("Please select location..!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf tgLst.Rows.Count = 0 Then
            MsgBox("No data to save..!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        pnlLoading.Show()
        pnlLoading.Refresh()

        extractCode()

        ESSA.OpenConnection()
        Dim cmd = Con.CreateCommand
        Dim trn = Con.BeginTransaction
        cmd.Transaction = trn

        Try

            If edit Then
                SQL = "DELETE FROM CCMaster WHERE ENo={0};" _
                    & "DELETE FROM CCDetails WHERE ENo={0}"
                cmd.CommandText = String.Format(SQL, entryNo)
            Else
                entryNo = ESSA.GenerateID("SELECT MAX(ENo) FROM CCMaster")
                entryDate = Now.Date
            End If

            SQL = "INSERT INTO CCMaster VALUES (" _
                & entryNo & ",'" _
                & Format(entryDate, "yyyy-MM-dd") & "'," _
                & cmbLocations.SelectedValue & "," _
                & IIf(completed, 1, 0) & ",''," _
                & UserID & ")"

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            For i As Short = 0 To tgTmp.Rows.Count - 1

                SQL = "INSERT INTO CCDetails VALUES (" _
                    & entryNo & "," _
                    & Val(tgTmp.Item(0, i).Value) & ",'" _
                    & Trim(tgTmp.Item(4, i).Value) & "'," _
                    & 1 & "," _
                    & 0 & "," _
                    & Val(tgTmp.Item(3, i).Value) & "," _
                    & i + 1 & ")"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

            Next

            ' Create new products based on given values
            ' -----------------------------------------

            cmd.CommandType = CommandType.StoredProcedure

            For j As Short = 0 To tgTmp.Rows.Count - 1

                cmd.CommandText = "UpdateProduct"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PluId", Val(tgTmp.Item(0, j).Value))
                cmd.Parameters.AddWithValue("@ENo", entryNo)
                cmd.Parameters.AddWithValue("@UTax", 0)
                cmd.Parameters.AddWithValue("@SNo", j + 1)
                cmd.Parameters.AddWithValue("@CC", 1)
                cmd.Parameters.AddWithValue("@Rate", Val(tgTmp.Item(3, j).Value))
                cmd.ExecuteNonQuery()

            Next

            trn.Commit()
            Con.Close()
            pnlLoading.Hide()

            MsgBox("Entry saved successfully..!", MsgBoxStyle.Information)
            refreshForm()

        Catch ex As SqlException

            trn.Rollback()
            Con.Close()
            pnlLoading.Hide()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try


    End Sub

    Private Sub refreshForm()

        tgLst.Rows.Clear()
        tgTmp.Rows.Clear()

        clearFields()
        cmbLocations.SelectedIndex = 0
        txtCode.Focus()

    End Sub

    Private Sub extractCode()

        tgTmp.Rows.Clear()

        For i As Short = 0 To tgLst.Rows.Count - 1

            For j As Short = 1 To Val(tgLst.Item(3, i).Value)

                tgTmp.Rows.Add()
                tgTmp.Item(0, tgTmp.Rows.Count - 1).Value = Val(tgLst.Item(0, i).Value)
                tgTmp.Item(1, tgTmp.Rows.Count - 1).Value = 1
                tgTmp.Item(2, tgTmp.Rows.Count - 1).Value = 0
                tgTmp.Item(3, tgTmp.Rows.Count - 1).Value = Val(tgLst.Item(4, i).Value)
                tgTmp.Item(4, tgTmp.Rows.Count - 1).Value = Trim(tgLst.Item(1, i).Value)

            Next

        Next

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlView.Hide()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        Dim sql = "SELECT M.ENo, M.EDate, S.ShopCode, SUM(D.Qty) Quantity, M.Completed, S.ShopId " _
                & "FROM CCMaster M, CCDetails D, Shops S " _
                & "WHERE M.ENo = D.ENo AND M.ShopId = S.ShopID " _
                & "GROUP BY M.ENo, M.EDate, S.ShopCode, M.Completed, S.ShopId " _
                & "ORDER BY M.ENo"

        With ESSA.OpenReader(sql)
            tgView.Rows.Clear()
            While .Read
                tgView.Rows.Add()
                tgView.Item(0, tgView.Rows.Count - 1).Value = .Item(0)
                tgView.Item(1, tgView.Rows.Count - 1).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                tgView.Item(2, tgView.Rows.Count - 1).Value = .GetString(2).Trim
                tgView.Item(3, tgView.Rows.Count - 1).Value = .Item(3)
                tgView.Item(4, tgView.Rows.Count - 1).Value = IIf(.Item(4), "Completed", "Pending")
                tgView.Item(7, tgView.Rows.Count - 1).Value = .Item(5)
            End While
            .Close()
        End With

        If tgView.Rows.Count > 0 Then
            tgView.FirstDisplayedScrollingRowIndex = tgView.Rows.Count - 1
            pnlView.Show()
        End If

    End Sub

    Private Sub btnHideMe_Click(sender As Object, e As EventArgs) Handles btnHideMe.Click

        pnlOptions.Hide()

    End Sub

    Private Sub tgView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tgView.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then
            pnlOptions.Show()
            btnDelivery.Focus()
        End If

    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRate.Focus()
        End If

    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click

        MainWindowX.AddTab(ProductDeliveryMaster)
        ProductDeliveryMaster.loadProductList(Val(tgView.Item(0, tgView.CurrentRow.Index).Value), True)
        'ProductDelivery.cmbDCLocation.SelectedValue = Val(tgView.Item(7, tgView.CurrentRow.Index).Value)
        'ProductDelivery.cmbDCode.Text = ""
        pnlOptions.Hide()
        Me.Close()

    End Sub

    Private Sub btnPrinting_Click(sender As Object, e As EventArgs) Handles btnPrinting.Click

        printLabel(Val(tgView.Item(0, tgView.CurrentRow.Index).Value))
        Me.WindowState = FormWindowState.Minimized
        pnlOptions.Hide()

    End Sub

    Private Sub btnLoadTemp_Click(sender As Object, e As EventArgs) Handles btnLoadTemp.Click

        Dim entryNo As Integer = 0

        entryNo = Val(InputBox("Enter entry no :"))

        If entryNo = 0 Then
            MsgBox("Entry number cannot be zero!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        SQL = "SELECT D.PluID, D.Plucode, P.PluName, P.RetailPrice " _
            & "FROM CRMaster M, CRDetail D, ProductMaster P " _
            & "WHERE M.ENo = D.ENo AND D.PluID = P.PluID " _
            & "AND M.ENo = {0} ORDER BY D.ENo, D.Sno"

        With ESSA.OpenReader(String.Format(SQL, entryNo))
            tgLst.Rows.Clear()
            While .Read
                tgLst.Rows.Add()
                tgLst.Item(0, tgLst.Rows.Count - 1).Value = .Item(0)
                tgLst.Item(1, tgLst.Rows.Count - 1).Value = .GetString(1).Trim
                tgLst.Item(2, tgLst.Rows.Count - 1).Value = .GetString(2).Trim
                tgLst.Item(3, tgLst.Rows.Count - 1).Value = 1
                tgLst.Item(4, tgLst.Rows.Count - 1).Value = Format(.Item(3), "0.00")
            End While
            .Close()
        End With

    End Sub

End Class