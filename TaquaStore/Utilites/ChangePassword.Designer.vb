<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNP = New System.Windows.Forms.TextBox()
        Me.txtRP = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Retype Password"
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(17, 34)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCP.Size = New System.Drawing.Size(265, 22)
        Me.txtCP.TabIndex = 0
        Me.txtCP.UseSystemPasswordChar = True
        '
        'txtNP
        '
        Me.txtNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNP.Location = New System.Drawing.Point(17, 88)
        Me.txtNP.Name = "txtNP"
        Me.txtNP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNP.Size = New System.Drawing.Size(265, 22)
        Me.txtNP.TabIndex = 1
        Me.txtNP.UseSystemPasswordChar = True
        '
        'txtRP
        '
        Me.txtRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRP.Location = New System.Drawing.Point(17, 142)
        Me.txtRP.Name = "txtRP"
        Me.txtRP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRP.Size = New System.Drawing.Size(265, 22)
        Me.txtRP.TabIndex = 2
        Me.txtRP.UseSystemPasswordChar = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(167, 184)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 27)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 227)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtRP)
        Me.Controls.Add(Me.txtNP)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtNP As System.Windows.Forms.TextBox
    Friend WithEvents txtRP As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
