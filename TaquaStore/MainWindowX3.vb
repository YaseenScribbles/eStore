Public Class MainWindowX3

  
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SPMain.Panel2.Paint

    End Sub

    Private Sub MainWindowX3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SBNow.Text = FormatDateTime(Now, DateFormat.LongDate)

        AddSideListItem("F2", "Vendors")
        AddSideListItem("F3", "Products")
        AddSideListItem("F4", "Category")

    End Sub

    Private Sub AddSideListItem(Shortcut As String, Item As String)

        SBList.Rows.Add()
        SBList.Item(1, SBList.Rows.Count - 1).Value = Shortcut
        SBList.Item(3, SBList.Rows.Count - 1).Value = Item

    End Sub

    Public Sub AddTab(ByVal MyForm As Form, FCtl As Control)

        For Each tn As Dotnetrix.Controls.TabPageEX In tabMain.TabPages
            If tn.Name = MyForm.Name Then
                tabMain.SelectedTab = tn
                TabHead.AddTab(MyForm.Text, MyForm.Name)
                Exit Sub
                Exit For
            End If
        Next


        Dim tb As New Dotnetrix.Controls.TabPageEX
        tabMain.ItemSize = New Size(0, 1)
        tb.Name = MyForm.Name
        tb.Text = "" ' MyForm.Text & " "
        MyForm.TopLevel = False
        MyForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        tb.Controls.Add(MyForm)
        MyForm.Dock = DockStyle.Fill
        tabMain.TabPages.Add(tb)
        TabHead.AddTab(MyForm.Text, MyForm.Name)
        tabMain.SelectedTab = tb
        MyForm.Show()
        FCtl.Focus()

    End Sub

    Public Sub CloseTab(ByVal FormTag As String)

        For Each tp As Dotnetrix.Controls.TabPageEX In tabMain.TabPages

            If tp.Name = FormTag Then
                tp.Dispose()
                TabHead.CloseTab(FormTag)
                Exit For
            End If

        Next

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        AddTab(Agents, Agents.txtAgentCode)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        'AddTab(Vendors, Vendors.txtVendorCode)

    End Sub

    Private Sub WelcomeAdministratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeAdministratorToolStripMenuItem.Click

    End Sub

    Private Sub WelcomeAdministratorToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles WelcomeAdministratorToolStripMenuItem.MouseEnter

        WelcomeAdministratorToolStripMenuItem.ForeColor = Color.Black

    End Sub

End Class