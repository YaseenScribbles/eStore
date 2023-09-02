'******************************************* Bismillah ****************************************************
Imports System.Data.SqlClient
Public Class MainWindow

    Private Sub InitializeMenuItems()

        TG.Rows.Clear()
        SQL = "select * from menulist where parentid=0 order by menuid"
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .Item(2)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(3, TG.Rows.Count - 1).Value = ""
                TG.Item(4, TG.Rows.Count - 1).Value = "|"
                TG.Item(5, TG.Rows.Count - 1).Value = .Item(3)
                SQL = "select * from menulist where parentid=" & .Item(0) & " order by menuid"
                With ESSA.OpenReader(SQL)
                    While .Read

                        TG.Rows.Add()
                        TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                        TG.Item(1, TG.Rows.Count - 1).Value = .Item(2)
                        TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1)
                        'TG.Item(3, TG.Rows.Count - 1).Value = ""
                        TG.Item(4, TG.Rows.Count - 1).Value = "|"
                        TG.Item(5, TG.Rows.Count - 1).Value = .Item(3)
                        TG.Rows(TG.Rows.Count - 1).Visible = False

                    End While
                    .Close()
                End With
              
            End While
            .Close()
        End With

    End Sub

    Private Sub ShowSubMenu()

        If TG.Item(5, TG.CurrentRow.Index).Value = 0 Then

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(5, i).Value) > 0 Then
                    TG.Rows(i).Visible = False
                End If

            Next

            Dim J As SByte = TG.CurrentRow.Index
            Dim S As SByte = J
            Do Until J = -5

                S += 1
                If Val(TG.Item(5, S).Value) > 0 Then
                    TG.Rows(S).Visible = True
                Else
                    J = -5
                End If

            Loop

        End If

    End Sub

    Private Sub AddSelectedTabs()

    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblStoreName.Text = ShopNm
        InitializeMenuItems()

    End Sub

    Private Sub TG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellClick

        If Val(TG.Item(5, e.RowIndex).Value) > 0 Then
            LoadForm(TG.Item(0, e.RowIndex).Value)
        End If

    End Sub

    Private Sub TG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellDoubleClick

        If Val(TG.Item(5, e.RowIndex).Value) = 0 Then
            ShowSubMenu()
        End If

    End Sub

    Private Sub LoadForm(ByVal FormID As Short)

        Select Case FormID

            Case 7
                LaunchForm(New Products)
            Case 8
                LaunchForm(New Category)
            Case 9
                LaunchForm(New Vendors)
            Case 10
                LaunchForm(New Agents)

        End Select

    End Sub

    Private Sub LaunchForm(ByVal MyForm As Form)

        If CheckTabExist(MyForm) = True Then Exit Sub

        Dim TPage As New Dotnetrix.Controls.TabPageEX
        MyForm.TopLevel = False
        TPage.Name = MyForm.Tag
        TPage.Controls.Add(MyForm)
        TPage.Text = MyForm.Text & " "
        TabControlEX1.TabPages.Add(TPage)
        MyForm.Dock = DockStyle.Fill
        'MyForm.FormBorderStyle = Windows.Forms. 
        TabControlEX1.SelectedTab = TPage
        MyForm.Show()
        'TPage.Focus()

    End Sub

    Private Function CheckTabExist(ByVal MyForm As Form) As Boolean

        CheckTabExist = False

        For Each tc As Dotnetrix.Controls.TabPageEX In TabControlEX1.TabPages
            If tc.Name = MyForm.Tag Then
                TabControlEX1.SelectedTab = tc
                CheckTabExist = True
                Exit For
            End If
        Next

    End Function

    Private Sub AddSelectedTab()

    End Sub


    Private Sub TG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub
End Class
