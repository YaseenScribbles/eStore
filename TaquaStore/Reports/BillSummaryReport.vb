'**************************in the name of Allah, most merciful, most compassionate *******************************
Imports System.Data.SqlClient
Public Class BillSummaryReport

    Private Rpt As New RptBillSummaryReport

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "SELECT P.BILLNO,P.BILLDT,P.FRDT,P.TODT,V.VENDORNAME,P.DEBITAMT,P.NETAMT FROM " _
            & "PAYMENTMASTER P,VENDORS V WHERE P.VENDORID=V.VENDORID AND P.BILLDT BETWEEN '" _
            & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= " AND P.VENDORID=" & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY P.BILLNO"

        ESSA.OpenConnection()
        Try
            Using Adp As New SqlDataAdapter(SQL, Con)
                Using Tbl As New DataTable
                    Adp.Fill(Tbl)
                    Rpt.SetDataSource(Tbl)
                    CRpt.ReportSource = Rpt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Con.Close()

    End Sub

    Private Sub BillSummaryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from paymentmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid", "All Vendor(s)")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Name)

    End Sub

End Class