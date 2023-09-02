'************************************************ Bismillah ****************************************************
Imports System.Data.SqlClient
Public Class ImportTools

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        SQL = "select plucode,pluname,0 qoh,unitdesc,0 vendor,convert(smallint,inclusivetax),costprice,retailprice,retailprice,retailprice,discount,0 size,plushortdesc,'','',0," _
            & "'2013-04-29',1 from eSmartStoreWH.dbo.plumaster " _
            & "where plucode not in (select plucode from productmaster) order by plucode"

        ESSA.LoadDataGrid(TG, SQL)

        If TG.Rows.Count = 0 Then
            MsgBox("No details to import..!", MsgBoxStyle.Information)
            Exit Sub
        End If

        pbar.Value = 0
        pbar.Maximum = TG.Rows.Count
        pbar.Step = 1

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            Dim id As Integer = ESSA.GenerateID("select max(pluid) from productmaster")

            For i As Integer = 0 To TG.Rows.Count - 1

                SQL = "insert into productmaster values (" _
                     & id & ",'" _
                     & TG.Item(0, i).Value & "','" _
                     & TG.Item(1, i).Value & "'," _
                     & TG.Item(2, i).Value & ",'" _
                     & TG.Item(3, i).Value & "'," _
                     & TG.Item(4, i).Value & "," _
                     & TG.Item(5, i).Value & "," _
                     & TG.Item(6, i).Value & "," _
                     & TG.Item(7, i).Value & "," _
                     & TG.Item(8, i).Value & "," _
                     & TG.Item(9, i).Value & "," _
                     & TG.Item(10, i).Value & "," _
                     & TG.Item(11, i).Value & ",'" _
                     & TG.Item(12, i).Value & "','" _
                     & TG.Item(13, i).Value & "','" _
                     & TG.Item(14, i).Value & "'," _
                     & TG.Item(15, i).Value & ",'" _
                     & TG.Item(16, i).Value & "'," _
                     & TG.Item(17, i).Value & ");" _
                     & "insert into productlevels values (" _
                     & id & ",0,'',0,'',0,'',0,'',0,'',0,'',0);" _
                     & "insert into productbatch values (1," _
                     & id & "," _
                     & TG.Item(7, i).Value & ",0,'" _
                     & TG.Item(16, i).Value & "',1,1)"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                pbar.PerformStep()

                id += 1

            Next

            Trn.Commit()
            Con.Close()

            MsgBox("Data imported successfully..!", MsgBoxStyle.Information)

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub

End Class