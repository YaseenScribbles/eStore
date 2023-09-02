'********************************************* Bismillah ************************************
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class SalesSummaryReport

    Private Rpt As New RptSalesSummary

    Private Sub SalesSummaryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "shopdesc", "shopid")

        mebFrom.Text = "01-" & Now.Month & "-" & Now.Year

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        'SQL = "SELECT A.BILLDT,CH,CD,NETAMT,TERM1 TERM_1, TERM2 TERM_2 FROM" _
        '    & "(select billdt,sum(cash) ch,sum(card) cd,sum(cash+card) netamt from V_PAYMENTSUMMARYREPORT where " _
        '    & "billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
        '    & Format(mebTo.Value, "yyyy-MM-dd") & "' and shopid=" & cmbLocation.SelectedValue _
        '    & " group by billdt) A LEFT OUTER JOIN " _
        '    & "(SELECT BILLDT,MAX(TERM_1) TERM1,MAX(TERM_2) TERM2 FROM V_BILLSERIES WHERE BILLDT BETWEEN '" _
        '    & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
        '    & Format(mebTo.Value, "yyyy-MM-dd") & "' and shopid=" & cmbLocation.SelectedValue & " GROUP BY BILLDT) B ON " _
        '    & "A.BILLDT=B.BILLDT ORDER BY A.BILLDT"

        SQL = "SELECT A.BILLDT,CH,CD,UPI,NETAMT,TERM1 TERM_1, TERM2 TERM_2 FROM" _
            & "(select billdt,sum(cash) ch,sum(card) cd,sum(upi) upi, sum(cash+card+upi) netamt from V_PaymentSummaryReportNew where " _
            & "billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "' and shopid=" & cmbLocation.SelectedValue _
            & " group by billdt) A LEFT OUTER JOIN " _
            & "(SELECT BILLDT,MAX(TERM_1) TERM1,MAX(TERM_2) TERM2 FROM V_BILLSERIES WHERE BILLDT BETWEEN '" _
            & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "' and shopid=" & cmbLocation.SelectedValue & " GROUP BY BILLDT) B ON " _
            & "A.BILLDT=B.BILLDT ORDER BY A.BILLDT"

        ESSA.OpenConnection()

        Try
            Using Adp As New SqlDataAdapter(SQL, Con)
                Using Tbl As New DataTable
                    Adp.Fill(Tbl)
                    Rpt.SetDataSource(Tbl)
                    Rpt.SetParameterValue("Duration", Format(mebFrom.Value, "dd-MM-yyyy") & " to " & Format(mebTo.Value, "dd-MM-yyyy"))
                    Rpt.SetParameterValue("Location", cmbLocation.Text)
                    CRpt.ReportSource = Rpt
                End Using
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Con.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

End Class