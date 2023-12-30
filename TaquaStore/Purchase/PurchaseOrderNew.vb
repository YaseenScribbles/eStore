'******************* in the name of Allah, most merciful, most compassionate ****************************
Imports System.Data.SqlClient
Public Class PurchaseOrderNew

    Private Rpt As New RptPurchaseOrderNew
    Private Edit As Boolean = False

    Private Sub PurchaseOrderNew_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub PurchaseOrderNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateOrderNo()
        mebOrderDt.Text = Format(Now.Date, "dd-MM-yyyy")
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
        mebEDDt.Select()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub GenerateOrderNo()

        SQL = "select max(orderno) from ordermaster_01"
        txtOrderNo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then

                SQL = "delete from ordermaster_01 where orderno=" & Val(txtOrderNo.Text) _
                    & ";delete from orderdetails_01 where orderno=" & Val(txtOrderNo.Text)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Else
                GenerateOrderNo()
            End If


            SQL = "insert into ordermaster_01 values (" _
                 & Val(txtOrderNo.Text) & ",'" _
                 & Format(CDate(mebEDDt.Text).Date, "yyyy-MM-dd") & "','" _
                 & Format(CDate(mebOrderDt.Text).Date, "yyyy-MM-dd") & "','" _
                 & txtVendor.Text.Trim & "','" _
                 & txtRmrks.Text.Trim & "'," _
                 & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into orderdetails_01 values (" _
                    & Val(txtOrderNo.Text) & ",'" _
                    & TG.Item(1, i).Value & "','" _
                    & TG.Item(2, i).Value & "','" _
                    & TG.Item(3, i).Value & "'," _
                    & TG.Item(4, i).Value & "," _
                    & TG.Item(5, i).Value & "," _
                    & TG.Item(0, i).Value & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        xMessageBox.ShowMessage("Purchase order has been created successfully..!", "Completed..!", xMessageBox.MessageBoxStyle.OKOnly)
        RefreshForm()

    End Sub

    Private Sub RefreshForm()

        Edit = False
        ESSA.ClearTextBox(Panel1)
        TG.Rows.Clear()
        GenerateOrderNo()
        CalculateTotal()
        mebEDDt.Focus()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForm()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Short = 0
        Dim Amt As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            Tot += Val(TG.Item(4, i).Value)
            Amt += Val(TG.Item(5, i).Value)

        Next

        lblTQty.Text = Tot
        lblTAmt.Text = Format(Amt, "0.00")

    End Sub

    Private Sub txtAmt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmt.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            TG.Rows.Add()
            TG.Item(0, TG.Rows.Count - 1).Value = TG.Rows.Count
            TG.Item(1, TG.Rows.Count - 1).Value = txtName.Text.Trim
            TG.Item(2, TG.Rows.Count - 1).Value = txtCat.Text.Trim
            TG.Item(3, TG.Rows.Count - 1).Value = txtRange.Text.Trim
            TG.Item(4, TG.Rows.Count - 1).Value = Val(txtQty.Text)
            TG.Item(5, TG.Rows.Count - 1).Value = Format(Val(txtAmt.Text), "0.00")
            CalculateTotal()

            txtName.Clear()
            txtCat.Clear()
            txtRange.Clear()
            txtQty.Clear()
            txtAmt.Clear()
            txtName.Focus()

        End If

    End Sub

    Private Sub mebEDDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mebEDDt.Leave

        If IsDate(mebEDDt.Text) = False Then
            mebEDDt.Text = Format(Now.Date, "dd-MM-yyyy")
        End If

    End Sub

    Private Sub PrintPurchaseOrder(ByVal iORDERNO As Short)

        SQL = "SELECT M.ORDERNO,M.ORDERDT,M.EDDT,M.VENDORNAME,M.REMARKS,D.VENDOR,D.CATEGORY,D.RANGE,D.QUANTITY,D.AMOUNT FROM " _
            & "ORDERMASTER_01 M,ORDERDETAILS_01 D WHERE M.ORDERNO=D.ORDERNO AND M.ORDERNO=" & iORDERNO & " ORDER BY D.SNO"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                ReportViewer.CViewer.ReportSource = Rpt
                ReportViewer.Text = "Purchae Order - New"
                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub btnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PrintPurchaseOrder(1)

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlPOList.Visible = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        TGLst.Rows.Clear()

        SQL = "SELECT M.ORDERNO,M.ORDERDT,M.VENDORNAME,SUM(D.QUANTITY) QTY,SUM(D.AMOUNT) AMT FROM " _
            & "ORDERMASTER_01 M,ORDERDETAILS_01 D WHERE M.ORDERNO=D.ORDERNO " _
            & "GROUP BY M.ORDERNO,M.ORDERDT,M.VENDORNAME ORDER BY M.ORDERNO"

        With ESSA.OpenReader(SQL)
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MMM-yyyy")
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2)
                TGLst.Item(3, TGLst.Rows.Count - 1).Value = .Item(3)
                TGLst.Item(4, TGLst.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            End While
            .Close()
        End With

        pnlPOList.Visible = True

    End Sub

    Private Sub PurchaseOrderNew_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlPOList, Me)

    End Sub

    Private Sub TGLst_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGLst.CellClick

        If e.ColumnIndex = 5 Then
            EditPurchaseOrder(TGLst.Item(0, e.RowIndex).Value)
        ElseIf e.ColumnIndex = 6 Then
            PrintPurchaseOrder(TGLst.Item(0, e.RowIndex).Value)
        End If

    End Sub

    Private Sub EditPurchaseOrder(ByVal iOrderNo As Short)

        SQL = "select * from ordermaster_01 where orderno=" & iOrderNo & ";" _
            & "select * from orderdetails_01 where orderno=" & iOrderNo & " order by sno"

        With ESSA.OpenReader(SQL)

            If .Read Then

                Edit = True
                txtOrderNo.Text = .Item(0)
                mebOrderDt.Text = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                mebEDDt.Text = Format(.GetDateTime(2).Date, "dd-MM-yyyy")
                txtVendor.Text = .GetString(3).Trim
                txtRmrks.Text = .GetString(4).Trim

            End If

            .NextResult()

            TG.Rows.Clear()
            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = TG.Rows.Count
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(4)
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")

            End While

            .Close()

        End With

        CalculateTotal()
        pnlPOList.Visible = False

    End Sub

    Private Sub TGLst_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGLst.CellContentClick

    End Sub
End Class