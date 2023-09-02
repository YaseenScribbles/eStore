'********************************************** Bismillah ***************************************
Imports System.Data.SqlClient
Imports System.Xml
Public Class DatabaseSettings

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()

    End Sub

    Private Sub DatabaseSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim ConnectionString As String = "Server=" & txtSQLServer.Text.Trim & ";" _
                        & "Initial Catalog=" & txtDatabase.Text.Trim & ";Persist Security Info=False;" _
                        & "User ID=" & txtUsername.Text.Trim & ";" _
                        & "Password=" & txtPassword.Text & ";" _
                        & "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

        Dim XTag As String = "<StoreSettings>" & vbCrLf _
                           & "<DBSettings>" & ClsEncodeDecode.Encode(ConnectionString) & "</DBSettings>" & vbCrLf _
                           & "<ShopCode>" & txtShopCode.Text.Trim & "</ShopCode>" & vbCrLf _
                           & "<VersionPath>" & txtVersionPath.Text.Trim & "</VersionPath>" & vbCrLf _
                           & "<SQLSERVER>" & txtSQLServer.Text.Trim & "</SQLSERVER>" & vbCrLf _
                           & "<USERID>" & txtUsername.Text.Trim & "</USERID>" & vbCrLf _
                           & "<PASSWORD>" & ClsEncodeDecode.Encode(txtPassword.Text) & "</PASSWORD>" & vbCrLf _
                           & "<DATABASE>" & txtDatabase.Text.Trim & "</DATABASE>" & vbCrLf _
                           & "<LABELPRINTER>" & txtPrinterName.Text.Trim & "</LABELPRINTER>" & vbCrLf _
                           & "</StoreSettings>"

        Dim nCon As New SqlConnection(ConnectionString)
        Try
            nCon.Open()
            If nCon.State = ConnectionState.Open Then
                nCon.Close()
            End If
            nCon.Dispose()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            nCon.Dispose()
            Exit Sub
        End Try

        Dim xDoc As New XmlDocument
        xDoc.LoadXml(XTag)
        xDoc.Save(My.Application.Info.DirectoryPath & "\StoreSettings.xml")
        MsgBox("Settings updated successfully..!", vbExclamation)

    End Sub

    Private Sub DatabaseSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\StoreSettings.xml") = True Then

            Dim xDoc As XmlReader = XmlReader.Create(My.Application.Info.DirectoryPath & "\StoreSettings.xml")
            While xDoc.Read
                If xDoc.Name = "SQLSERVER" Then
                    txtSQLServer.Text = xDoc.ReadElementString("SQLSERVER")
                ElseIf xDoc.Name = "USERID" Then
                    txtUsername.Text = xDoc.ReadElementString("USERID")
                ElseIf xDoc.Name = "PASSWORD" Then
                    txtPassword.Text = ClsEncodeDecode.DCode(xDoc.ReadElementString("PASSWORD"))
                ElseIf xDoc.Name = "DATABASE" Then
                    txtDatabase.Text = xDoc.ReadElementString("DATABASE")
                ElseIf xDoc.Name = "VersionPath" Then
                    txtVersionPath.Text = xDoc.ReadElementString("VersionPath")
                ElseIf xDoc.Name = "ShopCode" Then
                    txtShopCode.Text = xDoc.ReadElementString("ShopCode")
                ElseIf xDoc.Name = "LABELPRINTER" Then
                    txtPrinterName.Text = xDoc.ReadElementString("LABELPRINTER")
                End If
            End While
            xDoc.Close()

        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlSelectPrinter.Visible = False

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        loadPrinterList()
        pnlSelectPrinter.Visible = True

    End Sub

    Private Sub loadPrinterList()

        For Each sPrinters As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(sPrinters)
        Next

        If cmbPrinter.Items.Count > 0 Then
            cmbPrinter.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click

        txtPrinterName.Text = cmbPrinter.Text.Trim
        pnlSelectPrinter.Visible = False

    End Sub

End Class