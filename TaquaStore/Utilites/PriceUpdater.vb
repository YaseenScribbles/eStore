Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class PriceUpdater

    Private FileName As String = ""
    Private DTbl As New DataTable

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        Dim ISMC As Boolean = False 'IS Multi-Column

        OFD.ShowDialog()
        FileName = OFD.FileName

        If FileName.Trim.Length > 0 Then

            Dim connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=""Excel 8.0;HDR=YES;"""
            TG.Rows.Clear()

            Using icon As New OleDbConnection(connectionString)
                Using Adp As New OleDbDataAdapter("select * from [sheet1$]", icon)
                    Try

                        DTbl.Clear()
                        Adp.Fill(DTbl)

                    Catch ex As OleDbException
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                End Using
                icon.Close()
            End Using

            ESSA.OpenConnection()
            Dim Cmd = Con.CreateCommand

            SQL = "delete from codeimport"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            If DTbl.Columns.Count > 1 Then
                ISMC = True
            Else
                ISMC = False
            End If

            For i As Short = 0 To DTbl.Rows.Count - 1

                If ISMC = True Then
                    SQL = "insert into codeimport values ('" _
                        & DTbl.Rows(i).Item(0) & "'," _
                        & DTbl.Rows(i).Item(1) & ")"
                Else
                    SQL = "insert into codeimport values ('" _
                        & DTbl.Rows(i).Item(0) & "',0)"
                End If

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Con.Close()

            If ISMC = True Then

                SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,SUM(C.QTY) NOS,P.RETAILPRICE,P.ID,P.COSTPRICE " _
                    & "FROM CODEIMPORT C,PRODUCTMASTER P WHERE C.CODE=P.PLUCODE " _
                    & "GROUP BY P.PLUID,P.PLUCODE,P.PLUNAME,P.RETAILPRICE,P.ID,P.COSTPRICE ORDER BY P.PLUCODE"

            Else

                SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,COUNT(*) NOS,P.RETAILPRICE,P.ID,P.COSTPRICE " _
                    & "FROM CODEIMPORT C,PRODUCTMASTER P WHERE C.CODE=P.PLUCODE " _
                    & "GROUP BY P.PLUID,P.PLUCODE,P.PLUNAME,P.RETAILPRICE,P.ID,P.COSTPRICE ORDER BY P.PLUCODE"

            End If

            With ESSA.OpenReader(SQL)
                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                    TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                    TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = ESSA.GetData("select max(batchid) from productbatch where pluid=" & .Item(0))
                    TG.Item(7, TG.Rows.Count - 1).Value = .GetString(5).Trim
                    TG.Item(8, TG.Rows.Count - 1).Value = Format(.Item(6), "0.00")
                End While
                .Close()
            End With

        End If

    End Sub

    Private Sub PriceUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If MsgBox("Are you sure, do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        Try

            For I As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(6, I).Value) > 0 Then

                    SQL = "INSERT INTO PRODUCTBATCH VALUES (" _
                        & Val(TG.Item(6, I).Value) + 1 & "," _
                        & Val(TG.Item(0, I).Value) & "," _
                        & Val(TG.Item(5, I).Value) & ",0,'" _
                        & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                        & ShopID & "," _
                        & UserID & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Con.Close()

        Catch ex As SqlException
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("Product batch updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If MsgBox("Are you sure, do you want to print lable..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        LablePrinting.TG.Rows.Clear()

        For i As Short = 0 To TG.Rows.Count - 1

            With LablePrinting.TG

                .Rows.Add()
                .Item(0, .Rows.Count - 1).Value = TG.Item(0, i).Value
                .Item(1, .Rows.Count - 1).Value = TG.Item(1, i).Value
                .Item(2, .Rows.Count - 1).Value = TG.Item(2, i).Value
                .Item(3, .Rows.Count - 1).Value = TG.Item(3, i).Value
                .Item(4, .Rows.Count - 1).Value = Format(Val(TG.Item(5, i).Value), "0.00")
                .Item(5, .Rows.Count - 1).Value = TG.Item(7, i).Value

            End With

        Next

        MainWindowX.AddTab(LablePrinting)
        'LablePrinting.Visible = False
        'LablePrinting.Show(MainWindowX)

    End Sub

    Private Sub btnAPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPrice.Click

        For i As Short = 0 To TG.Rows.Count - 1
            TG.Item(5, i).Value = Format(Val(TG.Item(4, i).Value), "0.00")
        Next

    End Sub

End Class