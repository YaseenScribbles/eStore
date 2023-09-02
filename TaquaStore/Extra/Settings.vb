'*************************************** Bismillah ******************************************
Public Class Settings

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            cmbLableFormat.Items.Clear()
            Dim DI As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\Lables\")
            Dim Fl As IO.FileInfo() = DI.GetFiles()
            For Each nfl In Fl
                cmbLableFormat.Items.Add(nfl.Name.Trim)
            Next
            If cmbLableFormat.Items.Count > 0 Then
                cmbLableFormat.SelectedIndex = 0
            End If
        Catch ex As IO.DirectoryNotFoundException
            MsgBox("Sorry, Lable Format Directory not defined..!", MsgBoxStyle.Information)
        End Try

        LoadSettings()

    End Sub

    Private Sub LoadSettings()

        SQL = "select * from settings"
        With ESSA.OpenReader(SQL)
            While .Read
                If .GetString(0) = "LableFormat" Then
                    cmbLableFormat.Text = .GetString(1).Trim
                ElseIf .GetString(0) = "BarcodeFileLocation" Then
                    txtBFL.Text = .GetString(1).Trim
                ElseIf .GetString(0) = "BarcodeBatchLocation" Then
                    txtBBL.Text = .GetString(1).Trim
                ElseIf .GetString(0) = "ExportFileLocation" Then
                    txtExportFileLocatio.Text = .GetString(1).Trim
                End If
            End While
            .Close()
        End With

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        SQL = "update settings set param_value='" & cmbLableFormat.Text.Trim & "'" _
            & " where param_name='LableFormat';" _
            & "update settings set param_value='" & txtBFL.Text.Trim & "'" _
            & " where param_name='BarcodeFileLocation';" _
            & "update settings set param_value='" & txtBBL.Text.Trim & "'" _
            & " where param_name='BarcodeBatchLocation';" _
            & "update settings set param_value='" & txtExportFileLocatio.Text.Trim & "'" _
            & " where param_name='ExportFileLocation'"

        ESSA.Execute(SQL)
        MsgBox("Updated successfully..!", vbInformation)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub lblImportTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblImportTools.Click

        ImportTools.Show()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

        LocationSettings.Show()

    End Sub

End Class