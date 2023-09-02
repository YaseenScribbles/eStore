'********************************** in the name of Allah, most merciful, most compassionate ************************
Imports System.Data.SqlClient
Public Class ReturnVerifier

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtCode.Text.Trim = "" Then
                Exit Sub
            ElseIf ESSA.ISFound("select pluid from productmaster where plucode='" & txtCode.Text.Trim & "'") = False Then
                txtCode.SelectAll()
                Exit Sub
            End If

            TG.Rows.Add()
            TG.Item(0, TG.Rows.Count - 1).Value = TG.Rows.Count
            TG.Item(1, TG.Rows.Count - 1).Value = txtCode.Text.Trim
            txtCode.Clear()

        End If

    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click

        LoadDeliveryCode()

    End Sub

    Private Sub LoadDeliveryCode()

        If radSR.Checked Then
            SQL = "select deliverycode from receivedmastertemp order by deliverydate"
        ElseIf radGD.Checked Then
            SQL = "SELECT DISTINCT VchNo FROM GDeliveryVerify"
        End If

        With ESSA.OpenReader(SQL)
            TGDCode.Rows.Clear()
            While .Read
                TGDCode.Rows.Add()
                TGDCode.Item(1, TGDCode.Rows.Count - 1).Value = .Item(0)
            End While
            .Close()
        End With

    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click

        TG.Rows.Clear()
        TGTst.Rows.Clear()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub ReturnVerifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDeliveryCode()

    End Sub

    Private Sub btnViewProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewProduct.Click

        If MsgBox("Are you sure, do you want to verify..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        Try

            SQL = "delete from rvcode"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into rvcode values ('" _
                    & TG.Item(1, i).Value & "')"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Con.Close()

        Catch ex As Exception

            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        If radGD.Checked Then

            SQL = "select p.plucode,sum(req) rq,sum(act) at from productmaster p," _
            & "(select pluid,variation req,0 act from V_GDelivery where Variation > 0 AND " _
            & "VchNo in " & GetVchNo() _
            & " union all " _
            & "select pluid,0,qty from v_rvcode) a where a.pluid=p.pluid " _
            & "group by p.plucode order by plucode"

        ElseIf radSR.Checked Then

            SQL = "select p.plucode,sum(req) rq,sum(act) at from productmaster p," _
            & "(select pluid,quantity req,0 act from receiveddetailstemp where " _
            & "deliverycode in " & GetDeliveryCode() _
            & " union all " _
            & "select pluid,0,qty from v_rvcode) a where a.pluid=p.pluid " _
            & "group by p.plucode order by plucode"

        End If

        TGTst.Rows.Clear()

        With ESSA.OpenReader(SQL)
            While .Read
                TGTst.Rows.Add()
                TGTst.Item(0, TGTst.Rows.Count - 1).Value = .GetString(0).Trim
                TGTst.Item(1, TGTst.Rows.Count - 1).Value = .Item(1)
                TGTst.Item(2, TGTst.Rows.Count - 1).Value = .Item(2)
                TGTst.Item(3, TGTst.Rows.Count - 1).Value = .Item(1) - .Item(2)
            End While
            .Close()
        End With

    End Sub

    Private Function GetDeliveryCode() As String

        GetDeliveryCode = "("

        For i As Short = 0 To TGDCode.Rows.Count - 1

            If TGDCode.Item(0, i).Value = 1 Then

                GetDeliveryCode &= "'" & TGDCode.Item(1, i).Value & "',"

            End If

        Next

        GetDeliveryCode = Mid(GetDeliveryCode, 1, GetDeliveryCode.Length - 1) & ")"

    End Function

    Private Function GetVchNo() As String

        GetVchNo = "("

        For i As Short = 0 To TGDCode.Rows.Count - 1

            If TGDCode.Item(0, i).Value = 1 Then

                GetVchNo &= TGDCode.Item(1, i).Value & ","

            End If

        Next

        GetVchNo = Mid(GetVchNo, 1, GetVchNo.Length - 1) & ")"

    End Function

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        For i As Short = 0 To TGTst.Rows.Count - 1

            SQL = "UPDATE GDeliveryVerify SET RQty = " _
                & TGTst.Item(2, i).Value & " " _
                & "FROM ProductMaster P WHERE GDeliveryVerify.PluId = P.PluId AND GDeliveryVerify.VchNo in " & GetVchNo() & " AND P.PluCode = '" _
                & TGTst.Item(0, i).Value & "'"

            ESSA.Execute(SQL)

        Next

    End Sub

End Class