Public Class MainWindowX5

    Private Sub MainWindowX5_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Escape Then
            If xMessage.ShowMsg("Do you want to exit..?", True, Me, 0) = False Then Exit Sub
            CloseWindow(Me.Name, True)
            Close()
        End If

    End Sub

    Private Sub MainWindowX5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SimpleLine2.Height = 113
        SimpleLine3.Height = 113
        SimpleLine4.Height = 113

        wSpaceWidth = pMain.Width
        wSpaceHeight = pMain.Height

    End Sub

    Public Sub CloseWindow(FormName As String, Optional CloseAll As Boolean = False)

        For Each ctl As Control In pMain.Controls

            If CloseAll = True Then
                ctl.Dispose()
            Else
                If ctl.Name = FormName Then
                    ctl.Dispose()
                    Exit For
                End If
            End If

        Next

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        ShowForm(Agents, Agents.txtAgentCode, True)

    End Sub

    Public Sub ShowForm(MyForm As Form, FocusCtl As Control, IsCenter As Boolean)

        With MyForm

            For Each ctl As Control In pMain.Controls
                If ctl.Name = MyForm.Name Then
                    .BringToFront()
                    FocusCtl.Select()
                    Exit For
                    Exit Sub
                End If
            Next

            .TopLevel = False
            pMain.Controls.Add(MyForm)
            .Dock = DockStyle.Fill
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Show()

            '.Left = (pMain.Width - .Width) / 2
            '.Top = (pMain.Height - .Height) / 2
            .BringToFront()

            FocusCtl.Select()

        End With

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        'ShowForm(Vendors, Vendors.txtVendorCode, False)

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click

        ShowForm(Customer, Customer.txtCustCode, False)

    End Sub

    Private Sub GodownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GodownToolStripMenuItem.Click

        ShowForm(Godown, Godown.txtGDNCode, True)

    End Sub

    Private Sub LedgersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LedgersToolStripMenuItem.Click

        ShowForm(Ledger, Ledger.txtLedgerID, True)

    End Sub

    Private Sub ShopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsToolStripMenuItem.Click

        ShowForm(Shop, Shop.txtLCode, True)

    End Sub

    Private Sub ColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorsToolStripMenuItem.Click

        ShowForm(Colors, Colors.txtCode, True)

    End Sub


    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click

        ShowForm(Agt, Agt.CTextBox8, True)

    End Sub

    Private Sub VendorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorListToolStripMenuItem.Click

        ShowForm(VendorList, VendorList, True)

    End Sub

    Private Sub AgentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentListToolStripMenuItem.Click

        ShowForm(AgentList, AgentList, True)

    End Sub

End Class