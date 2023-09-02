'********************************************* Bismillah *****************************************
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports System.IO

Public Class ProductDelivery

    Private DeliveryID As UShort
    Private Rpt As New RptDeliveryChallan
    Private ELCode As String = ""
    Private UniqueID As String = ""
    Private iCode As String = ""
    Private Edit As Boolean = False

    Private externalSource As Boolean = False
    Private externalNumber As Integer = 0

    Private Sub ProductDelivery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                MainWindowX.CloseTab(Me.Name)
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub RefreshForms()

        externalNumber = 0
        externalSource = 0
        Edit = False
        cmbDCode.Text = ""
        GenerateDeliveryCode()
        lblTQty.Text = "0"
        txtRemarks.Clear()
        TG.Rows.Clear()

    End Sub

    Private Sub ProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbDCLocation, SQL, "shopdesc", "shopid")

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation2, SQL, "shopdesc", "shopid")

        cmbDCLocation.Select()

    End Sub

    Private Sub GenerateDeliveryCode()

        'SQL = "select count(*) from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        SQL = "select max(CONVERT(INT,SUBSTRING(DELIVERYCODE,LEN(DELIVERYCODE)-4,LEN(DELIVERYCODE)))) ID from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        DeliveryID = ESSA.GenerateID(SQL)
        lblDCode.Text = ShopCode & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        If TG.Rows.Count = 0 Then
            TTip.Show("No details to proceed..!", btnSend, 0, 25, 2000)
            Exit Sub
        ElseIf cmbDCLocation.SelectedIndex = -1 Then
            TTip.Show("Delivery location not selected..!", cmbDCLocation, 0, 25, 2000)
            cmbDCLocation.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select deliverycode from deliverymaster where uniqueid='" & UniqueID & "'") = True Then
            TTip.Show("Delivery code already delivered..!", cmbDCLocation, 0, 25, 2000)
            cmbDCLocation.Focus()
            Exit Sub
        End If

        If MsgBox("Are you sure, do you want to send delivery..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction(IsolationLevel.Serializable)
        Cmd.Transaction = Trn

        ELCode = cmbDCLocation.Text.Trim
        ELCode = Mid(ELCode, ELCode.Length - 3, ELCode.Length)

        Try

            If Edit = True Then

                SQL = "DELETE FROM DELIVERYMASTER WHERE DELIVERYCODE='" & lblDCode.Text.Trim & "';" _
                    & "DELETE FROM DELIVERYDETAILS WHERE DELIVERYCODE='" & lblDCode.Text.Trim & "'"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Else

                GenerateDeliveryCode()

                SQL = "delete from deliverymastertemp where deliverycode='" & cmbDCode.Text.Trim & "';" _
                    & "delete from deliverydetailstemp where deliverycode='" & cmbDCode.Text.Trim & "'"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            End If

            SQL = "insert into deliverymaster values ('" _
                & lblDCode.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCLocation.SelectedValue & "," _
                & Val(lblTQty.Text) & "," _
                & Val(lblTCP.Text) & "," _
                & Val(lblTRP.Text) & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ",0,'" _
                & UniqueID & "')"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) > 0 Then

                    SQL = "insert into deliverydetails values ('" _
                        & lblDCode.Text.Trim & "'," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & Val(TG.Item(6, i).Value) & "," _
                        & ShopID & "," _
                        & cmbDCLocation.SelectedValue & "," _
                        & i + 1 & ",0)"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            If externalSource Then

                SQL = "update ccmaster set deliverycode='" _
                    & lblDCode.Text.Trim & "',completed=1 where eno=" _
                    & externalNumber

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            End If

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            btnSend.Enabled = False
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        iCode = lblDCode.Text.Trim
        RefreshForms()

        GenerateExportedData(iCode)

        If MsgBox("Challan delivered successfully, Do you want to print challan..!", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PrintDeliveryReport()
        End If

    End Sub

    Private Sub GenerateExportedData(ByVal iDCode As String)

        Dim iQry As String = ""

        SQL = "SELECT * FROM DELIVERYMASTER WHERE DELIVERYCODE='" & iDCode & "';" _
            & "SELECT * FROM DELIVERYDETAILS WHERE DELIVERYCODE='" & iDCode & "'"

        With ESSA.OpenReader(SQL)

            iQry = "DELETE FROM RECEIVEDMASTERTEMP WHERE DELIVERYCODE='" & iDCode & "'" & vbCrLf

            If .Read Then

                iQry &= "INSERT INTO RECEIVEDMASTERTEMP VALUES ('" _
                     & iDCode & "','" _
                     & Format(.GetDateTime(1), "yyyy-MM-dd hh:mm:ssss") & "'," _
                     & .Item(2) & "," _
                     & .Item(3) & "," _
                     & .Item(4) & "," _
                     & .Item(5) & "," _
                     & .Item(6) & "," _
                     & .Item(7) & ",'" _
                     & .GetString(8).Trim & "'," _
                     & .Item(9) & "," _
                     & .Item(10) & ")" & vbCrLf

            End If

            .NextResult()

            iQry &= "DELETE FROM RECEIVEDDETAILSTEMP WHERE DELIVERYCODE='" & iDCode & "'" & vbCrLf

            While .Read

                iQry &= "INSERT INTO RECEIVEDDETAILSTEMP VALUES ('" _
                     & .GetString(0).Trim & "'," _
                     & .Item(1) & "," _
                     & .Item(2) & "," _
                     & .Item(3) & "," _
                     & .Item(4) & "," _
                     & .Item(5) & "," _
                     & .Item(6) & "," _
                     & .Item(7) & "," _
                     & .Item(8) & ")" & vbCrLf

            End While

            .Close()

        End With

        'If iQry.Length > 0 Then

        '    Using sw As StreamWriter = New StreamWriter(ExportFileLocation & "\" & ELCode.Trim & "\" & ShopCode & Format(Now, "yyMMddhhmmss") & ".DAT", True)
        '        sw.Write(iQry)
        '    End Using

        'End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    Private Sub PrintDeliveryReport()

        SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
            & "s1.shopname dfrom,s2.shopname dto from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
            & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
            & " And m.deliveryto = s2.shopid and m.deliverycode='" & iCode & "' order by d.sno"

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

    Private Sub cmbDCLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDCLocation.SelectedIndexChanged

        If cmbDCLocation.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT REMARKS,DELIVERYCODE FROM DELIVERYMASTERTEMP WHERE DELIVERYTO=" & IIf(cmbDCLocation.SelectedValue.ToString.Contains("DataRow"), "0", cmbDCLocation.SelectedValue) _
            & " ORDER BY DELIVERYCODE"
        ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "REMARKS")

    End Sub

    Public Sub loadProductList(isLocal As Boolean, Optional entryNo As Integer = 0, Optional external As Boolean = False)

        If isLocal Then

            SQL = "select uniqueid from deliverymastertemp where deliverycode='" & cmbDCode.Text.Trim & "';" _
                & "select p.pluid,p.plucode,p.pluname,d.quantity,d.costprice,d.retailprice from productmaster p,deliverydetailstemp d " _
                & "where p.pluid=d.pluid and d.deliverycode='" & cmbDCode.Text.Trim & "' order by sno"

            txtRemarks.Text = cmbDCode.SelectedValue

        Else

            SQL = "SELECT Format(GetDate(),'yyyyMMddHHmmss');" _
                & "select p.pluid,p.plucode,p.pluname,d.qty,p.costprice,p.retailprice from productmaster p,ccdetails d " _
                & "where p.pluid=d.newcode and d.eno=" & entryNo & " order by sno"

        End If

        Dim Tot As Double = 0

        TG.Rows.Clear()

        With ESSA.OpenReader(SQL)

            If .Read Then
                UniqueID = .GetString(0).Trim
            End If

            .NextResult()

            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
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

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If cmbDCode.SelectedIndex = -1 Then
            TTip.Show("Delivery code not found..!", cmbDCode, 0, 25, 2000)
            Exit Sub
        End If

        loadProductList(True)

    End Sub

    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        If Val(TG.Item(4, e.RowIndex).Value) > Val(TG.Item(3, e.RowIndex).Value) Then
            TG.Item(4, e.RowIndex).Value = Val(TG.Item(3, e.RowIndex).Value)
        End If

        CalculateTotal()

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            If MsgBox("Are you sure, Do you want to remove product..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TG.Rows.RemoveAt(TG.CurrentRow.Index)
            End If
            TG.Focus()
        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Double = 0
        Dim Tmp As Double = 0
        Dim CTot As Double = 0
        Dim RTot As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            Tot += Val(TG.Item(4, i).Value)
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(5, i).Value)
            CTot += Tmp
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(6, i).Value)
            RTot += Tmp

        Next

        lblTQty.Text = Tot
        lblTCP.Text = Format(CTot, "0.00")
        lblTRP.Text = Format(RTot, "0.00")

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        SQL = "select deliverycode,deliverydate,totalqty from deliverymaster where deliveryto=" & cmbLocation2.SelectedValue & " order by deliverydate desc"

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

    Private Sub btnAlter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlter.Click

        If IsAdmin Then

            pnlAlter.Visible = True
            cmbLocation2.Focus()

        End If

    End Sub

    Private Sub ProductDelivery_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ESSA.MovetoCenter(pnlAlter, Me)

    End Sub

    Private Sub BtnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHide.Click

        pnlAlter.Visible = False
        TGAlter.Rows.Clear()

    End Sub

    Private Sub TGAlter_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGAlter.CellClick

        If e.ColumnIndex = 3 Then

            SQL = "SELECT DELIVERYCODE,DELIVERYDATE,DELIVERYTO,REMARKS FROM DELIVERYMASTER " _
                & "WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "';" _
                & "SELECT D.PLUID,P.PLUCODE,P.PLUNAME,D.QUANTITY,D.COSTPRICE,D.RETAILPRICE FROM " _
                & "DELIVERYDETAILS D,PRODUCTMASTER P WHERE D.PLUID=P.PLUID AND D.DELIVERYCODE='" _
                & TGAlter.Item(0, e.RowIndex).Value & "' ORDER BY D.SNO"

            TG.Rows.Clear()

            With ESSA.OpenReader(SQL)

                If .Read Then

                    Edit = True

                    lblDCode.Text = .GetString(0)
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
                    TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")

                End While

                .Close()

            End With

            CalculateTotal()
            TGAlter.Rows.Clear()
            pnlAlter.Visible = False

        ElseIf e.ColumnIndex = 4 Then

            'If MsgBox("Are you sure, do you want to delete..!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            'SQL = "DELETE FROM DELIVERYMASTERTEMP WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "';" _
            '    & "DELETE FROM DELIVERYDETAILSTEMP WHERE DELIVERYCODE='" & TGAlter.Item(0, e.RowIndex).Value & "'"

            'ESSA.Execute(SQL)
            'MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)
            'TGAlter.Rows.Clear()
            'pnlAlter.Visible = False

        End If

    End Sub

End Class