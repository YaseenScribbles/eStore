Imports System.Data.SqlClient
Public Class UnusedProducts

    Private Stock As Double = 0
    Private PluID As Integer = 0
    Private RPrice As Double = 0
    Private CPrice As Double = 0
    Private Rpt As New RptUnused
    Private Sub UnusedProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select


    End Sub

    Private Sub UnusedProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateNo()

        txtEDt.Text = Format(Now.Date, "dd-MM-yyyy")

        txtRmk.Select()

        ESSA.AlignHeader(TGLst, 2, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TGLst, 3, DataGridViewContentAlignment.MiddleRight)

        'SQL = "select count(*) from unusedproducts"
        'lbltpcs.Text = ESSA.GenerateID(SQL) - 1

    End Sub

    Private Sub GenerateNo()

        SQL = "select max(entryno) from unusedmast"
        txtENo.Text = ESSA.GenerateID(SQL)

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True


            If Val(txtQty.Text) <= 0 Then
                Exit Sub
            ElseIf PluID <= 0 Then
                Exit Sub
            End If

            'If Val(txtQty.Text) > Stock Then
            '    MsgBox("Insufficient stock..!" & vbCrLf & " Available Stock : " & Stock, MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

            Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)
            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = PluID
            TG.Item(1, NRI).Value = txtCode.Text
            TG.Item(2, NRI).Value = txtDesc.Text
            TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtQty.Text)
            TG.Item(4, NRI).Value = Format(CPrice, "0.00")
            TG.Item(5, NRI).Value = RPrice
            TG.Item(6, NRI).Value = Format(Val(TG.Item(3, NRI).Value) * CPrice, "0.00")

            GetTotal()

            PluID = 0
            txtCode.Clear()
            txtDesc.Clear()
            txtQty.Clear()
            txtCode.Focus()

        End If

    End Sub

    Private Sub GetTotal()

        Dim TItm As Double = 0
        Dim TAmt As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TItm += Val(TG.Item(3, i).Value)
            TAmt += Val(TG.Item(6, i).Value)

        Next

        lbltpcs.Text = Format(TItm, "0.00")
        lbltamt.Text = Format(TAmt, "0.00")

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select p.pluid,p.pluname,p.costprice,p.retailprice,v.stock from productmaster p,v_stockpos v where " _
                & "p.plucode='" & txtCode.Text.Trim & "' and p.pluid=v.pluid"

            With ESSA.OpenReader(SQL)

                If .Read Then

                    PluID = .Item(0)
                    txtDesc.Text = .GetString(1)
                    CPrice = .Item(2)
                    RPrice = .Item(3)
                    Stock = .Item(4)

                    txtQty.Text = "1"
                    txtQty.Focus()

                End If

                .Close()

            End With

        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If TG.Rows.Count = 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure, do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            GenerateNo()

            SQL = "insert into unusedmast values (" _
                & Val(txtENo.Text) & ",'" _
                & Format(CDate(txtEDt.Text).Date, "yyyy-MM-dd") & "','" _
                & txtRmk.Text.Trim & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into unuseddet values (" _
                    & Val(txtENo.Text) & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(3, i).Value) & "," _
                    & Val(TG.Item(4, i).Value) & "," _
                    & Val(TG.Item(5, i).Value) & "," _
                    & i + 1 & ")"

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

        If MsgBox("Entry saved successfully, Do you want to print..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PrintPurchaseOrder(Val(txtENo.Text))
        End If

        RefreshForm()

    End Sub

    Private Sub RefreshForm()

        TG.Rows.Clear()
        txtRmk.Clear()
        GenerateNo()
        GetTotal()
        txtRmk.Focus()


    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
            GetTotal()
        End If

    End Sub

    Private Sub btnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprint.Click

        Dim Qty As Double = 0

        SQL = "SELECT M.ENTRYNO,M.ENTRYDT,SUM(D.QUANTITY),SUM(D.QUANTITY*D.RETAILPRICE) FROM UNUSEDMAST M,UNUSEDDET D " _
            & "WHERE M.ENTRYNO=D.ENTRYNO GROUP BY M.ENTRYNO,M.ENTRYDT ORDER BY M.ENTRYNO"

        With ESSA.OpenReader(SQL)
            TGLst.Rows.Clear()
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .Item(2)
                TGLst.Item(3, TGLst.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                TGLst.Item(4, TGLst.Rows.Count - 1).Value = "REPRINT"
                Qty += Val(.Item(2))
            End While
            .Close()
        End With

        lblQty.Text = Qty

        pnlLst.Visible = True

    End Sub

    Private Sub PrintPurchaseOrder(ByVal iVchNo As Short)

        SQL = "SELECT M.ENTRYNO VCHNO,M.ENTRYDT VCHDT,'DAMAGE PRODUCT' VENDORNAME,M.REMARKS,P.PLUCODE,P.PLUNAME,D.QUANTITY,D.RETAILPRICE RATE,(D.QUANTITY*D.RETAILPRICE) AMOUNT FROM " _
            & "UNUSEDMAST M,UNUSEDDET D,PRODUCTMASTER P WHERE M.ENTRYNO=D.ENTRYNO AND " _
            & "D.PLUID=P.PLUID AND M.ENTRYNO=" & iVchNo & " ORDER BY D.SNO"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)
                Rpt.SetParameterValue("ReportHead", "Damage Product Report")
                ReportViewer.CViewer.ReportSource = Rpt
                ReportViewer.Text = "Damage Product Report"
                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlLst.Visible = False

    End Sub

    Private Sub TGLst_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGLst.CellClick

        If e.ColumnIndex = 4 Then
            PrintPurchaseOrder(TGLst.Item(0, e.RowIndex).Value)
        End If

    End Sub

End Class