Imports System.Data.SqlClient

Public Class Dummy


    Private Rpt1 As New RptDummy

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim NetAmt As Double = 0
        Dim DbtDes As String = ""

        SQL = "SELECT L.LEDGERNAME,T.PERC,T.AMOUNT,M.NETAMT,M.DBTDESC FROM LEDGER L,PAYMENTTAX T,PAYMENTMASTER M WHERE " _
            & "L.LEDGERID=T.LEDGERID AND T.BILLNO=14 AND M.BILLNO=T.BILLNO ORDER BY T.SNO"

        With ESSA.OpenReader(SQL)
            If .Read Then
                NetAmt = .Item(3)
                DbtDes = .GetString(4)
            End If
            .Close()
        End With


        SQL = "SELECT L.LEDGERNAME,T.PERC,T.AMOUNT,M.NETAMT,M.DBTDESC FROM LEDGER L,PAYMENTTAX T,PAYMENTMASTER M WHERE " _
            & "L.LEDGERID=T.LEDGERID AND T.BILLNO=14 AND M.BILLNO=T.BILLNO ORDER BY T.SNO"

        Dim STbl As New DataTable
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Adp.Fill(STbl)
        End Using
        Con.Close()

        Dim iGRNNo As String = ""

        SQL = "select grnno from grnmaster where billno=452 order by grnno"
        With ESSA.OpenReader(SQL)
            While .Read
                iGRNNo &= .Item(0) & ","
            End While
        End With

        If iGRNNo.Length > 0 Then
            iGRNNo = Mid(iGRNNo, 1, iGRNNo.Length - 1)
        End If

        SQL = "SELECT A.GRNNO,A.GRNDT,B.SCATDESC1,A.PQTY,SUM(B.D1) DC1,SUM(B.S1) SLS1,SUM(B.K1) STK1,SUM(B.D2) DC2,SUM(B.S2) SLS2,SUM(B.K2) STK2,0 AMOUNT,0 PERC FROM " _
            & "(SELECT GRNNO,GRNDT,TOTALQUANTITY PQTY FROM GRNMASTER WHERE GRNNO in (" & iGRNNo & ")) A " _
            & "LEFT OUTER JOIN " _
            & "(SELECT V.GRNNO,V.GRNDT,V.SCATDESC1,SUM(V.DC) D1,SUM(V.SALES) S1,SUM((V.DC-V.SALES)+V.RTN) K1,0 D2,0 S2,0 K2 " _
            & "FROM V_GRNWISESTATUS V WHERE V.DELIVERYTO=2 AND GRNNO in (" & iGRNNo & ") GROUP BY V.GRNNO,V.GRNDT,V.SCATDESC1 " _
            & "UNION ALL " _
            & "SELECT V.GRNNO,V.GRNDT,V.SCATDESC1,0,0,0,SUM(V.DC),SUM(V.SALES),SUM((V.DC-V.SALES)+V.RTN) " _
            & "FROM V_GRNWISESTATUS V WHERE V.DELIVERYTO=3 AND GRNNO in (" & iGRNNo & ") GROUP BY V.GRNNO,V.GRNDT,V.SCATDESC1) B ON A.GRNNO=B.GRNNO " _
            & "GROUP BY A.GRNNO,A.GRNDT,B.SCATDESC1,A.PQTY"

        Dim STbl2 As New DataTable
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Adp.Fill(STbl2)
        End Using
        Con.Close()

        SQL = "SELECT INVNO,INVDT,REFDT,SUBCATDESC1,ISNULL([0],0) [0],	ISNULL([1],0) [1],	ISNULL([2],0) [2],	ISNULL([3],0) [3],	ISNULL([4],0) [4],	ISNULL([5],0) [5],	ISNULL([6],0) [6],	ISNULL([7],0) [7],	ISNULL([8],0) [8],	ISNULL([9],0) [9],	ISNULL([10],0) [10],	ISNULL([11],0) [11],	ISNULL([S],0) [S],	ISNULL([M],0) [M],	ISNULL([L],0) [L],	ISNULL([XL],0) [XL],	ISNULL([XXL],0) [XXL],	ISNULL([XXXL],0) [XXXL],	ISNULL([XXXXL],0) [XXXXL],COSTPRICE FROM " _
            & "(SELECT M.GRNNO,L.SCATDESC1 SUBCATDESC1,D.QTY,D.COSTPRICE,V.NID,M.REFDT,M.INVNO,M.INVDT,S.ISNO FROM GRNDETAILS D,PRODUCTLEVELS L,GRNMASTER M,V_CODEWITHNID V,V_GRNLISTSNOWISE S " _
            & "WHERE M.GRNNO=S.GRNNO AND D.COSTPRICE=S.COSTPRICE AND L.PLUID=D.PLUID AND M.GRNNO=D.GRNNO AND D.PLUID=V.PLUID AND M.BILLNO=152) B PIVOT " _
            & "(sum(qty) for NID in ([0],[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[S],[M],[L],[XL],[XXL],[XXXL],[XXXXL])) A ORDER BY GRNNO,COSTPRICE,ISNO"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt1.SetDataSource(Tbl)
                'Rpt1.OpenSubreport("RptGrnWiseStatus").SetDataSource(STbl2)

                Rpt1.Subreports.Item(0).SetDataSource(STbl)


                'Rpt.Subreports.Item(0).SetParameterValue("GTotal", NetAmt)
                'Rpt1.SetParameterValue("Vendor", "Bill No")
                'Rpt1.SetParameterValue("BillNo", 1751)
                'Rpt1.SetParameterValue("BillDt", "12-10-19")
                'Rpt1.SetParameterValue("Duration", "essa")
                'Rpt1.SetParameterValue("Debit", 100.2)
                'Rpt1.SetParameterValue("DbtDesc", DbtDes)
                Rpt1.Subreports.Item(1).SetDataSource(STbl2)
                ReportViewer.CViewer.ReportSource = Rpt1

                ReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

End Class