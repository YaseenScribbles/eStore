<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cListBox
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
        Me.LstHead = New System.Windows.Forms.Label()
        Me.Lst = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LstHead
        '
        Me.LstHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LstHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstHead.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstHead.ForeColor = System.Drawing.Color.White
        Me.LstHead.Location = New System.Drawing.Point(0, 0)
        Me.LstHead.Name = "LstHead"
        Me.LstHead.Size = New System.Drawing.Size(303, 20)
        Me.LstHead.TabIndex = 0
        Me.LstHead.Text = "UNTITLED"
        Me.LstHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lst
        '
        Me.Lst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst.FormattingEnabled = True
        Me.Lst.IntegralHeight = False
        Me.Lst.ItemHeight = 14
        Me.Lst.Location = New System.Drawing.Point(0, 20)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(303, 343)
        Me.Lst.TabIndex = 1
        '
        'cListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.LstHead)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "cListBox"
        Me.Size = New System.Drawing.Size(303, 363)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstHead As System.Windows.Forms.Label
    Friend WithEvents Lst As System.Windows.Forms.ListBox

End Class
