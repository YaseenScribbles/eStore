Public Class frmHSNUpdater

    Private Sub frmHSNUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)

        LoadListOfYears()

    End Sub

    Private Sub LoadListOfYears()

        SQL = "SELECT DISTINCT CONVERT(VARCHAR,YEAR(GrnDt)) Yr,YEAR(GrnDt) Yr2 FROM GRNMaster ORDER	BY Yr2"
        ESSA.LoadCombo(cmbYear, SQL, "Yr", "", "ALL")
        cmbYear.SelectedIndex = cmbYear.Items.Count - 1

    End Sub

    Private Sub LoadPurchaseList()

        SQL = "SELECT GrnNo,GrnDt,InvNo,VendorName,TotalQuantity,TotalAmount FROM " _
            & "GRNMaster G,Vendors V WHERE G.VendorId=V.VendorId "

        If cmbYear.SelectedIndex > 0 Then
            SQL &= " AND YEAR(G.GrnDt) BETWEEN " & Val(cmbYear.Text) & " AND " & Val(cmbYear.Text)
        End If

        SQL &= " ORDER BY GrnNo"

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0")
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
            End While
            .Close()
        End With

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        LoadPurchaseList()

    End Sub

    Private Sub LoadGRN(iGrnNo As Integer)

        SQL = "SELECT P.PluId,P.PluName,P.CatLink,P.HsnCode FROM ProductMaster P,GRNMaster G " _
            & "P.PluId=G.PluId AND G.GrnId=" & iGrnNo & " ORDER BY Sno"

        With ESSA.OpenReader(SQL)
            TGL.Rows.Clear()
            While .Read
                TGL.Rows.Add()
                TGL.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TGL.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TGL.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TGL.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
            End While
            .Close()
        End With

    End Sub

End Class