Public Class MainWindowX2

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        ShowForm(Agents, Agents.txtAgentCode, True)

    End Sub

    Private Sub AddSideListItem(Shortcut As String, Item As String)

        SBList.Rows.Add()
        SBList.Item(1, SBList.Rows.Count - 1).Value = Shortcut
        SBList.Item(3, SBList.Rows.Count - 1).Value = Item

    End Sub

    Public Sub CloseTab(MyForm As Form)

        For Each ctl As Control In pMain.Controls
            If ctl.Name = MyForm.Name Then
                MyForm.Close()
                Exit For
            End If
        Next

    End Sub

    Private Sub ShowForm(MyForm As Form, FocusCtl As Control, IsCenter As Boolean)

        With MyForm

            .TopLevel = False
            pMain.Controls.Add(MyForm)
            .Dock = DockStyle.None
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Show()

            .Left = (pMain.Width - .Width) / 2
            .Top = (pMain.Height - .Height) / 2
            .BringToFront()

            FocusCtl.Select()

            .Enabled = False

        End With

    End Sub


    Private Sub MainWindowX2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddSideListItem("F2", "Vendors")
        AddSideListItem("F3", "Products")
        AddSideListItem("F4", "Category")


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        'ShowForm(Vendors, Vendors.txtVendorCode, True)

    End Sub

End Class