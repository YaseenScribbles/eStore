Imports System.Data.SqlClient

Public Class ImportTool

    Private LSERVER As String = ""
    Private DBASE As String = ""

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportAll.Click

        Close()

    End Sub

    Private Sub ImportTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbLocation, SQL, "shopdesc", "shopid")

    End Sub

    Private Sub GetConnectionString()

        SQL = "select * from locationsettings where shopid=" & cmbLocation.SelectedValue
        With ESSA.OpenReader(SQL)
            If .Read Then
                LSERVER = .GetString(1)
                DBASE = .GetString(4)
            End If
            .Close()
        End With

    End Sub

    Private Function LSTBL(ByVal Tbl As String, ByVal Alis As String) As String
        LSTBL = LSERVER & "." & DBASE & ".DBO." & Tbl & " " & Alis
    End Function

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        lblStatus.Text = "Loading, Please wait...!"
        pnlLoading.Visible = True
        pnlLoading.Refresh()

        GetConnectionString()

        SQL = "SELECT DELIVERYCODE FROM " & LSTBL("DELIVERYMASTER", "") _
            & " WHERE DELIVERYCODE NOT IN (SELECT * FROM V_RECEIVEDCODE) ORDER BY DELIVERYDATE"

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0)
                TG.Item(3, TG.Rows.Count - 1).Value = 0
            End While
            .Close()
        End With

        pnlLoading.Visible = False

    End Sub


    Private Sub TG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 1 Then

            lblStatus.Text = "Importing, Please wait...!"
            pnlLoading.Visible = True
            pnlLoading.Refresh()

            ESSA.OpenConnection()
            Dim Cmd = Con.CreateCommand
            Dim Trn = Con.BeginTransaction
            Cmd.Transaction = Trn

            Try

                SQL = "delete from receivedmastertemp where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "';" _
                    & "delete from receiveddetailstemp where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                SQL = "insert into receivedmastertemp " _
                    & "select * from " & LSTBL("DELIVERYMASTER", "") & " where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "';" _
                    & "insert into receiveddetailstemp " _
                    & "select * from " & LSTBL("deliverydetails", "") & " where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                Trn.Commit()
                Con.Close()

            Catch ex As SqlException
                pnlLoading.Visible = False
                Trn.Rollback()
                Con.Close()
                MsgBox("Sorry, Unable to import products, Please try again later..!", MsgBoxStyle.Critical)
                Exit Sub
            End Try

            pnlLoading.Visible = False
            MsgBox("Delivery code imported successfully...!", MsgBoxStyle.Information)
            TG.Rows.RemoveAt(e.RowIndex)
            TG.Focus()

        End If

    End Sub

    Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub

    Private Sub pnlLoading_Paint(sender As Object, e As PaintEventArgs) Handles pnlLoading.Paint

    End Sub
End Class