<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorUpdater
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.cmbGRN = New System.Windows.Forms.ComboBox()
        Me.cmbNVendor = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbNVendor2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGRN2 = New System.Windows.Forms.ComboBox()
        Me.cmbVendor2 = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbLRPaid = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdate3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGRN3 = New System.Windows.Forms.ComboBox()
        Me.cmbVendor3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtLR = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(482, 42)
        Me.Panel3.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(8, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(237, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Vendor and LR Updater"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(397, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Current Vendor Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "GRN No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "New Vendor Name"
        '
        'cmbVendor
        '
        Me.cmbVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(24, 42)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(294, 22)
        Me.cmbVendor.TabIndex = 0
        '
        'cmbGRN
        '
        Me.cmbGRN.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGRN.FormattingEnabled = True
        Me.cmbGRN.Location = New System.Drawing.Point(327, 42)
        Me.cmbGRN.Name = "cmbGRN"
        Me.cmbGRN.Size = New System.Drawing.Size(97, 22)
        Me.cmbGRN.TabIndex = 1
        '
        'cmbNVendor
        '
        Me.cmbNVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNVendor.FormattingEnabled = True
        Me.cmbNVendor.Location = New System.Drawing.Point(24, 90)
        Me.cmbNVendor.Name = "cmbNVendor"
        Me.cmbNVendor.Size = New System.Drawing.Size(294, 22)
        Me.cmbNVendor.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(327, 79)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Tag = "1"
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(456, 167)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmbNVendor)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmbGRN)
        Me.TabPage1.Controls.Add(Me.cmbVendor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(448, 140)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "GRN"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnUpdate2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cmbNVendor2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cmbGRN2)
        Me.TabPage2.Controls.Add(Me.cmbVendor2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(448, 140)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchase Return"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Current Vendor Name"
        '
        'btnUpdate2
        '
        Me.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate2.FlatAppearance.BorderSize = 0
        Me.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.ForeColor = System.Drawing.Color.White
        Me.btnUpdate2.Location = New System.Drawing.Point(327, 79)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate2.TabIndex = 3
        Me.btnUpdate2.Tag = "1"
        Me.btnUpdate2.Text = "UPDATE"
        Me.btnUpdate2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "New Vendor Name"
        '
        'cmbNVendor2
        '
        Me.cmbNVendor2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNVendor2.FormattingEnabled = True
        Me.cmbNVendor2.Location = New System.Drawing.Point(24, 90)
        Me.cmbNVendor2.Name = "cmbNVendor2"
        Me.cmbNVendor2.Size = New System.Drawing.Size(294, 22)
        Me.cmbNVendor2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Vch No"
        '
        'cmbGRN2
        '
        Me.cmbGRN2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGRN2.FormattingEnabled = True
        Me.cmbGRN2.Location = New System.Drawing.Point(327, 42)
        Me.cmbGRN2.Name = "cmbGRN2"
        Me.cmbGRN2.Size = New System.Drawing.Size(97, 22)
        Me.cmbGRN2.TabIndex = 1
        '
        'cmbVendor2
        '
        Me.cmbVendor2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor2.FormattingEnabled = True
        Me.cmbVendor2.Location = New System.Drawing.Point(24, 42)
        Me.cmbVendor2.Name = "cmbVendor2"
        Me.cmbVendor2.Size = New System.Drawing.Size(294, 22)
        Me.cmbVendor2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TxtLR)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.cmbLRPaid)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.btnUpdate3)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.cmbGRN3)
        Me.TabPage3.Controls.Add(Me.cmbVendor3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(448, 140)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LR Status"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 14)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "LR Paid ?"
        '
        'cmbLRPaid
        '
        Me.cmbLRPaid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLRPaid.FormattingEnabled = True
        Me.cmbLRPaid.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbLRPaid.Location = New System.Drawing.Point(26, 93)
        Me.cmbLRPaid.Name = "cmbLRPaid"
        Me.cmbLRPaid.Size = New System.Drawing.Size(79, 22)
        Me.cmbLRPaid.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 14)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Vendor Name"
        '
        'btnUpdate3
        '
        Me.btnUpdate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate3.FlatAppearance.BorderSize = 0
        Me.btnUpdate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate3.ForeColor = System.Drawing.Color.White
        Me.btnUpdate3.Location = New System.Drawing.Point(329, 82)
        Me.btnUpdate3.Name = "btnUpdate3"
        Me.btnUpdate3.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate3.TabIndex = 3
        Me.btnUpdate3.Tag = "1"
        Me.btnUpdate3.Text = "UPDATE"
        Me.btnUpdate3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(326, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "GRN No"
        '
        'cmbGRN3
        '
        Me.cmbGRN3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGRN3.FormattingEnabled = True
        Me.cmbGRN3.Location = New System.Drawing.Point(329, 45)
        Me.cmbGRN3.Name = "cmbGRN3"
        Me.cmbGRN3.Size = New System.Drawing.Size(97, 22)
        Me.cmbGRN3.TabIndex = 1
        '
        'cmbVendor3
        '
        Me.cmbVendor3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor3.FormattingEnabled = True
        Me.cmbVendor3.Location = New System.Drawing.Point(26, 45)
        Me.cmbVendor3.Name = "cmbVendor3"
        Me.cmbVendor3.Size = New System.Drawing.Size(294, 22)
        Me.cmbVendor3.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 14)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "LR Amount"
        '
        'TxtLR
        '
        Me.TxtLR.Location = New System.Drawing.Point(111, 94)
        Me.TxtLR.Name = "TxtLR"
        Me.TxtLR.Size = New System.Drawing.Size(100, 22)
        Me.TxtLR.TabIndex = 42
        '
        'VendorUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 241)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorUpdater"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "37"
        Me.Text = "Vendor & LR Updater"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGRN As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNVendor As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbNVendor2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbGRN2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVendor2 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbLRPaid As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdate3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbGRN3 As ComboBox
    Friend WithEvents cmbVendor3 As ComboBox
    Friend WithEvents TxtLR As TextBox
    Friend WithEvents Label10 As Label
End Class
