
Public Class MainWindowX4
    Private Sub MainWindowX4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' VS2005Style.Extender.SetSchema(DockPanel1, VS2005Style.Extender.Schema.FromBase)

        'DockPanel

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        Agents.Show(DockPanel)

    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Vendors.Show(DockPanel)

    End Sub

End Class