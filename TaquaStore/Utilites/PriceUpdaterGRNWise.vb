Public Class PriceUpdaterGRNWise

    Private Sub PriceUpdaterGRNWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from grnmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub
        SQL = "select grnno from grnmaster where vendorid=" & IIf(cmbVendor.SelectedValue.ToString.Contains("Row"), 0, cmbVendor.SelectedValue) & " order by grnno"
        ESSA.LoadCombo(cmbGRN, SQL, "grnno")

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "select p.pluid,p.plucode,p.pluname,d.costprice,p.retailprice from productmaster p,grndetails d " _
            & "where p.pluid=d.pluid and d.grnno=" & Val(cmbGRN.Text) & " order by d.sno"
        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            End While
            .Close()
        End With

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Tmp As Integer = 0
        Dim Abc As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            Tmp = Int(Val(TG.Item(3, i).Value) + (Val(TG.Item(3, i).Value) * Val(txtPerc.Text)) / 100)

            Abc = Int(Tmp Mod 10)
            Abc = Int(Abc)
            If Abc = 0 Then
                Abc = 0
            ElseIf Abc < 5 Then
                Abc = 5 - Abc
            ElseIf Abc > 5 Then
                Abc = 10 - Abc
            End If

            TG.Item(5, i).Value = Format(Tmp + Abc, "0.00")

        Next

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If MsgBox("Are you sure, do you want to update..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) <> Val(TG.Item(5, i).Value) Then

                    SQL = "update productmaster set isupdated=0,retailprice=" _
                        & Val(TG.Item(5, i).Value) & ",WholeSalePrice=" _
                        & Val(TG.Item(5, i).Value) & ",MRP=" _
                        & Val(TG.Item(5, i).Value) & " where pluid=" _
                        & Val(TG.Item(0, i).Value)

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                    SQL = "INSERT INTO PRODUCTBATCH VALUES (" _
                        & "2," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & ",0,'" _
                        & Format(Now.Date, "yyyy-MM-dd") & "'," _
                        & ShopID & "," _
                        & UserID & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As Exception

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        MsgBox("GRN updated successfully..!", MsgBoxStyle.Information)

    End Sub

End Class