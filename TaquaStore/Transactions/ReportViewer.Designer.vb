<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CViewer
        '
        Me.CViewer.ActiveViewIndex = -1
        Me.CViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CViewer.Location = New System.Drawing.Point(0, 0)
        Me.CViewer.Name = "CViewer"
        Me.CViewer.Size = New System.Drawing.Size(753, 492)
        Me.CViewer.TabIndex = 0
        Me.CViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 492)
        Me.Controls.Add(Me.CViewer)
        Me.Name = "ReportViewer"
        Me.Text = "ReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
