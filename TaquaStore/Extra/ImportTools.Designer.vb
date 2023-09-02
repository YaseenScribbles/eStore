<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportTools
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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.TG = New System.Windows.Forms.DataGridView()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(190, 47)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import Master (Variation)"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 84)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(190, 47)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(102, 157)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(100, 18)
        Me.pbar.TabIndex = 2
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TG.Location = New System.Drawing.Point(322, 33)
        Me.TG.Name = "TG"
        Me.TG.Size = New System.Drawing.Size(166, 141)
        Me.TG.TabIndex = 3
        '
        'ImportTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(210, 187)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnImport)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImportTools"
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents TG As System.Windows.Forms.DataGridView
End Class
