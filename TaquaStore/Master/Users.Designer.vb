<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRtype = New System.Windows.Forms.TextBox()
        Me.rdoAdmin = New System.Windows.Forms.RadioButton()
        Me.rdoUser = New System.Windows.Forms.RadioButton()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Retype Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "User info"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(13, 64)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(301, 22)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(13, 119)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(301, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtRtype
        '
        Me.txtRtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRtype.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRtype.Location = New System.Drawing.Point(13, 174)
        Me.txtRtype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRtype.Name = "txtRtype"
        Me.txtRtype.Size = New System.Drawing.Size(301, 22)
        Me.txtRtype.TabIndex = 2
        Me.txtRtype.UseSystemPasswordChar = True
        '
        'rdoAdmin
        '
        Me.rdoAdmin.AutoSize = True
        Me.rdoAdmin.Checked = True
        Me.rdoAdmin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdmin.ForeColor = System.Drawing.Color.Black
        Me.rdoAdmin.Location = New System.Drawing.Point(70, 254)
        Me.rdoAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoAdmin.Name = "rdoAdmin"
        Me.rdoAdmin.Size = New System.Drawing.Size(110, 18)
        Me.rdoAdmin.TabIndex = 3
        Me.rdoAdmin.TabStop = True
        Me.rdoAdmin.Text = "Administrator"
        Me.rdoAdmin.UseVisualStyleBackColor = False
        '
        'rdoUser
        '
        Me.rdoUser.AutoSize = True
        Me.rdoUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoUser.ForeColor = System.Drawing.Color.Black
        Me.rdoUser.Location = New System.Drawing.Point(198, 254)
        Me.rdoUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoUser.Name = "rdoUser"
        Me.rdoUser.Size = New System.Drawing.Size(57, 18)
        Me.rdoUser.TabIndex = 4
        Me.rdoUser.Text = "Users"
        Me.rdoUser.UseVisualStyleBackColor = False
        '
        'TTip
        '
        Me.TTip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error..!"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Gray
        Me.RadioButton1.Location = New System.Drawing.Point(13, 304)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(105, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Administrator"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Maroon
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(13, 34)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(301, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 8
        Me.SimpleLine1.UseGradient = False
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Maroon
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(13, 235)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(301, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 10
        Me.SimpleLine2.UseGradient = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User Type"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(63, 9)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(83, 26)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(152, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Location = New System.Drawing.Point(12, 295)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 44)
        Me.Panel1.TabIndex = 5
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(325, 346)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.rdoUser)
        Me.Controls.Add(Me.rdoAdmin)
        Me.Controls.Add(Me.txtRtype)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Users"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "8"
        Me.Text = "User Register"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRtype As System.Windows.Forms.TextBox
    Friend WithEvents rdoAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUser As System.Windows.Forms.RadioButton
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
End Class
