'******************************** In the name of Allah, Most Merciful, Most Compassionate **************************
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class DeliveryValueReportT

    Private Rpt1 As New RptDeliveryValueReport
    Private Rpt2 As New RptDeliveryValueReportNew
    Private Rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If cmbLocation.SelectedIndex = -1 Then
            MsgBox("Delivery Location not found..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Using nCon As New SqlConnection(ConStr)

            nCon.Open()

            Try

                Rpt = IIf(chkOmitCP.Checked, Rpt2, Rpt1)

                If chkOmitCP.Checked Then

                    SQL = "SELECT M.DeliveryCode,M.DeliveryDate,P.Category,SUM(D.Quantity) Qty,SUM(D.Quantity * D.RetailPrice) TotalRP,U.UserName " _
                    & "FROM DeliveryMaster M, DeliveryDetails D, Users U,ProductAttributes P " _
                    & "WHERE M.Id = D.Id AND M.UserID = U.UserID AND D.PluID = P.PluId AND M.DeliveryTo = " & cmbLocation.SelectedValue & " AND M.DeliveryDate BETWEEN '" _
                    & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
                    & "GROUP BY M.DeliveryCode,M.DeliveryDate,P.Category,U.UserName ORDER BY M.DeliveryCode"

                    'SQL = "SELECT M.DeliveryCode,M.DeliveryDate,P.Category,SUM(D.Quantity) Qty,SUM(D.Quantity * D.RetailPrice) TotalRP,U.UserName " _
                    '& "FROM DeliveryMaster M, DeliveryDetails D, Users U,ProductAttributes P " _
                    '& "WHERE M.Id = D.Id AND M.UserID = U.UserID AND D.PluID = P.PluId AND M.DeliveryTo = " & cmbLocation.SelectedValue & " AND M.DeliveryDate BETWEEN '" _
                    '& Format(mebFrom.Value, "yyyy-MM-dd HH:mm") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd HH:mm") & "' " _
                    '& "GROUP BY M.DeliveryCode,M.DeliveryDate,P.Category,U.UserName ORDER BY M.DeliveryCode"

                Else

                    SQL = "select deliverycode,deliverydate,Totalqty,totcp TotalCP,totrp TotalRP,U.UserName from deliverymaster,Users U where DeliveryMaster.UserID = U.UserID AND deliveryto=" _
                    & cmbLocation.SelectedValue & " and deliverydate " _
                    & "between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'" _
                    & " order by deliverydate"

                End If


                Using Adp As New SqlDataAdapter(SQL, nCon)

                    Using Tbl As New DataTable
                        Adp.Fill(Tbl)
                        Rpt.SetDataSource(Tbl)
                        Rpt.SetParameterValue("Location", cmbLocation.Text.Trim)
                        Rpt.SetParameterValue("Duration", Format(mebFrom.Value, "dd-MM-yyyy") & " to " & Format(mebTo.Value, " dd-MM-yyyy"))
                        'Rpt.SetParameterValue("Duration", Format(mebFrom.Value, "dd-MM-yyyy HH:mm") & " to " & Format(mebTo.Value, " dd-MM-yyyy HH:mm"))
                        CRpt.ReportSource = Rpt
                    End Using

                End Using

            Catch ex As SqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            nCon.Close()

        End Using

    End Sub

    Private Sub DeliveryValueReportT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname + ' - ' + shopcode) sname from shops where shopid<>" & ShopID _
            & " order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "sname", "shopid")

        'mebFrom.CustomFormat = "dd-MM-yyyy HH:mm"
        'mebTo.CustomFormat = "dd-MM-yyyy HH:mm"

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

End Class