'************************* In the name of Allah, Most Merciful, Most Compassionate ***********************
Imports System.Data.SqlClient
Public Class DeliveryUpdaters

    Private Sub DeliveryUpdaters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "shopdesc", "shopid")

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "select deliverycode,deliverydate from deliverymaster where deliveryto=" & cmbLocation.SelectedValue _
            & " order by deliverydate"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0).Trim
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = "Send"
                TG.Item(3, TG.Rows.Count - 1).Value = "Send"
            End While
            .Close()
        End With

    End Sub

    Private Sub TG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellClick

        If e.ColumnIndex = 2 Then

            If MsgBox("Are you sure, do you want send delivery...!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = "update deliverymaster set isupdated=0 where deliverycode='" & TG.Item(0, e.RowIndex).Value & "';" _
                & "update deliverydetails set isupdated=0 where deliverycode='" & TG.Item(0, e.RowIndex).Value & "'"
            ESSA.Execute(SQL)
            MsgBox("Changes updated successfully..!", MsgBoxStyle.Information)

        ElseIf e.ColumnIndex = 3 Then

            If MsgBox("Are you sure, do you want send delivery...!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = "update productmaster set isupdated=0 where pluid in (" _
                & "select distinct pluid from deliverydetails where " _
                & "deliverycode='" & TG.Item(0, e.RowIndex).Value & "');" _
                & "update productlevels set isupdated=0 where pluid in (" _
                & "select distinct pluid from deliverydetails where " _
                & "deliverycode='" & TG.Item(0, e.RowIndex).Value & "');" _
                & "update productbatch set isupdated=0 where pluid in (" _
                & "select distinct pluid from deliverydetails where " _
                & "deliverycode='" & TG.Item(0, e.RowIndex).Value & "')"

            ESSA.Execute(SQL)
            MsgBox("Changes updated successfully..!", MsgBoxStyle.Information)

        End If

    End Sub

End Class