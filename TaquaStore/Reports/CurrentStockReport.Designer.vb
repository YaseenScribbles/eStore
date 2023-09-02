<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentStockReport
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkIZQ = New System.Windows.Forms.CheckBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.pnlCat = New System.Windows.Forms.Panel()
        Me.tvCat = New System.Windows.Forms.TreeView()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlCat.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(1017, 39)
        Me.Panel3.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(146, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Stock Report"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(944, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.cmbLoc)
        Me.Panel4.Controls.Add(Me.chkIZQ)
        Me.Panel4.Controls.Add(Me.btnAll)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnDisplay)
        Me.Panel4.Controls.Add(Me.btnPick)
        Me.Panel4.Controls.Add(Me.txtCat)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtCode)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmbVendor)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1017, 140)
        Me.Panel4.TabIndex = 0
        '
        'chkIZQ
        '
        Me.chkIZQ.AutoSize = True
        Me.chkIZQ.Checked = True
        Me.chkIZQ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIZQ.Location = New System.Drawing.Point(430, 93)
        Me.chkIZQ.Name = "chkIZQ"
        Me.chkIZQ.Size = New System.Drawing.Size(134, 17)
        Me.chkIZQ.TabIndex = 27
        Me.chkIZQ.Text = "Include Zero Quantiy"
        Me.chkIZQ.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(375, 105)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(34, 21)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "ALL"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(605, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "OPTIONS"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderSize = 0
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(608, 56)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(87, 31)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnPick
        '
        Me.btnPick.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPick.FlatAppearance.BorderSize = 0
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPick.ForeColor = System.Drawing.Color.White
        Me.btnPick.Location = New System.Drawing.Point(608, 93)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(87, 33)
        Me.btnPick.TabIndex = 5
        Me.btnPick.Text = "PICK"
        Me.btnPick.UseVisualStyleBackColor = False
        '
        'txtCat
        '
        Me.txtCat.BackColor = System.Drawing.SystemColors.Window
        Me.txtCat.Location = New System.Drawing.Point(12, 105)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.ReadOnly = True
        Me.txtCat.Size = New System.Drawing.Size(357, 22)
        Me.txtCat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CATEGORY"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(12, 56)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(111, 22)
        Me.txtCode.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(9, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "PRODUCT FILTER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PRODUCT CODE"
        '
        'cmbVendor
        '
        Me.cmbVendor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(129, 56)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(280, 23)
        Me.cmbVendor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VENDOR"
        '
        'CRpt
        '
        Me.CRpt.ActiveViewIndex = -1
        Me.CRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRpt.CachedPageNumberPerDoc = 10
        Me.CRpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRpt.Location = New System.Drawing.Point(0, 179)
        Me.CRpt.Name = "CRpt"
        Me.CRpt.Size = New System.Drawing.Size(1017, 321)
        Me.CRpt.TabIndex = 1
        Me.CRpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'pnlCat
        '
        Me.pnlCat.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlCat.Controls.Add(Me.tvCat)
        Me.pnlCat.Location = New System.Drawing.Point(430, 172)
        Me.pnlCat.Name = "pnlCat"
        Me.pnlCat.Size = New System.Drawing.Size(267, 304)
        Me.pnlCat.TabIndex = 3
        Me.pnlCat.Visible = False
        '
        'tvCat
        '
        Me.tvCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvCat.Location = New System.Drawing.Point(3, 3)
        Me.tvCat.Name = "tvCat"
        Me.tvCat.PathSeparator = "->"
        Me.tvCat.Size = New System.Drawing.Size(261, 298)
        Me.tvCat.TabIndex = 0
        '
        'cmbLoc
        '
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(415, 56)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(187, 21)
        Me.cmbLoc.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(412, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "LOCATION"
        '
        'CurrentStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 500)
        Me.Controls.Add(Me.pnlCat)
        Me.Controls.Add(Me.CRpt)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CurrentStockReport"
        Me.Tag = "21"
        Me.Text = "Stock Report"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlCat.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CRpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents pnlCat As System.Windows.Forms.Panel
    Friend WithEvents tvCat As System.Windows.Forms.TreeView
    Friend WithEvents chkIZQ As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbLoc As System.Windows.Forms.ComboBox
End Class
