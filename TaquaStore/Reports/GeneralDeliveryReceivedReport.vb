Imports System.Data.SqlClient
Public Class GeneralDeliveryReceivedReport

    Private Rpt As New RptLocalDRReport

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If rdoDC.Checked = True Then

            SQL = "SELECT M.VCHNO,M.VCHDT,P.PLUCODE,P.PLUNAME,D.QTY QUANTITY,D.RATE,(D.QTY*D.RATE) AMOUNT,C.CUSTOMERNAME VENDORNAME FROM " _
                & "DCMAST M,DCDET D,PRODUCTMASTER P,CUSTOMERS C WHERE M.CUSTID=C.CUSTOMERID AND M.VCHNO=D.VCHNO AND D.PLUID=P.PLUID AND M.VCHDT " _
                & "BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        Else

            SQL = "SELECT M.VCHNO,M.VCHDT,P.PLUCODE,P.PLUNAME,D.QTY QUANTITY,D.RATE,(D.QTY*D.RATE) AMOUNT,C.CUSTOMERNAME VENDORNAME FROM " _
                & "RCMAST M,RCDET D,PRODUCTMASTER P,CUSTOMERS C WHERE M.CUSTID=C.CUSTOMERID AND M.VCHNO=D.VCHNO AND D.PLUID=P.PLUID AND M.VCHDT " _
                & "BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        End If

        If cmbCust.SelectedIndex > 0 Then
            SQL &= " AND M.CUSTID=" & cmbCust.SelectedValue
        End If

        SQL &= " ORDER BY M.VCHNO"

        'SQL = "SELECT M.VCHNO,M.VCHDT,V.VENDORNAME,M.REMARKS,P.PLUCODE,P.PLUNAME,D.QTY QUANTITY,D.RATE,(D.QTY*D.RATE) AMOUNT FROM " _
        '    & "RVCHMASTER M,RVCHDETAILS D,VENDORS V,PRODUCTMASTER P WHERE M.VCHNO=D.VCHNO AND M.VENDORID=V.VENDORID AND " _
        '    & "D.PLUID=P.PLUID AND M.VCHNO=" & iVchNo & " ORDER BY D.SNO"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt.SetDataSource(Tbl)

                If rdoDC.Checked = True Then
                    Rpt.SetParameterValue("ReportHead", "Delivery Report - Local")
                    ReportViewer.Text = "Delivery Report - Local"
                Else
                    Rpt.SetParameterValue("ReportHead", "Received Report - Local")
                    ReportViewer.Text = "Received Report - Local"
                End If

                CRpt.ReportSource = Rpt

            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub GeneralDeliveryReceivedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "SELECT CUSTOMERID,CUSTOMERNAME FROM CUSTOMERS ORDER BY CUSTOMERNAME"
        ESSA.LoadCombo(cmbCust, SQL, "CUSTOMERNAME", "CUSTOMERID", "All Customer(s)")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        MainWindowX.CloseTab(Me.Tag)

    End Sub

End Class