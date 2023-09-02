<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTabHeader
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TabBorder = New simpleline.assemblies.simpleLine()
        Me.lbltmp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TabBorder
        '
        Me.TabBorder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabBorder.FillColor = System.Drawing.Color.Transparent
        Me.TabBorder.FitToParent = False
        Me.TabBorder.Gradient = System.Drawing.Color.Transparent
        Me.TabBorder.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.TabBorder.LineColor = System.Drawing.Color.Black
        Me.TabBorder.LineWidth = 1
        Me.TabBorder.Location = New System.Drawing.Point(0, 89)
        Me.TabBorder.Name = "TabBorder"
        Me.TabBorder.Size = New System.Drawing.Size(535, 1)
        Me.TabBorder.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.TabBorder.TabIndex = 0
        Me.TabBorder.UseGradient = False
        '
        'lbltmp
        '
        Me.lbltmp.AutoSize = True
        Me.lbltmp.Location = New System.Drawing.Point(-100, 41)
        Me.lbltmp.Name = "lbltmp"
        Me.lbltmp.Size = New System.Drawing.Size(39, 14)
        Me.lbltmp.TabIndex = 1
        Me.lbltmp.Text = "Label1"
        '
        'ucTabHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbltmp)
        Me.Controls.Add(Me.TabBorder)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ucTabHeader"
        Me.Size = New System.Drawing.Size(535, 90)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabBorder As simpleline.assemblies.simpleLine
    Friend WithEvents lbltmp As System.Windows.Forms.Label

End Class
