<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReportLocationWise
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkEDBF = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mebToDt = New System.Windows.Forms.DateTimePicker()
        Me.mebFrDt = New System.Windows.Forms.DateTimePicker()
        Me.chkUseDateWise = New System.Windows.Forms.CheckBox()
        Me.mebTillDt = New System.Windows.Forms.DateTimePicker()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkEZQ = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(1070, 39)
        Me.Panel3.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(281, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Stock Report (Location Wise)"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(997, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.cmbMaterial)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.cmbStyle)
        Me.Panel4.Controls.Add(Me.cmbCat)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.chkEDBF)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.mebToDt)
        Me.Panel4.Controls.Add(Me.mebFrDt)
        Me.Panel4.Controls.Add(Me.chkUseDateWise)
        Me.Panel4.Controls.Add(Me.mebTillDt)
        Me.Panel4.Controls.Add(Me.SimpleLine1)
        Me.Panel4.Controls.Add(Me.cmbDept)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmbVendor)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.chkEZQ)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnDisplay)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.cmbLocation)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1070, 191)
        Me.Panel4.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(272, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "CATALOG"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMaterial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(275, 152)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(247, 23)
        Me.cmbMaterial.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(272, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "STYLE"
        '
        'cmbStyle
        '
        Me.cmbStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Location = New System.Drawing.Point(275, 100)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(247, 23)
        Me.cmbStyle.TabIndex = 41
        '
        'cmbCat
        '
        Me.cmbCat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(275, 53)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(247, 23)
        Me.cmbCat.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(272, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "CATEGORY"
        '
        'chkEDBF
        '
        Me.chkEDBF.AutoSize = True
        Me.chkEDBF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEDBF.ForeColor = System.Drawing.Color.Gray
        Me.chkEDBF.Location = New System.Drawing.Point(553, 84)
        Me.chkEDBF.Name = "chkEDBF"
        Me.chkEDBF.Size = New System.Drawing.Size(195, 17)
        Me.chkEDBF.TabIndex = 38
        Me.chkEDBF.Text = "ENABLE DELIVERY BASED FILTER"
        Me.chkEDBF.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(550, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "DELIVERY FILTER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(653, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "TO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "FROM"
        '
        'mebToDt
        '
        Me.mebToDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebToDt.Location = New System.Drawing.Point(656, 53)
        Me.mebToDt.Name = "mebToDt"
        Me.mebToDt.Size = New System.Drawing.Size(86, 22)
        Me.mebToDt.TabIndex = 35
        '
        'mebFrDt
        '
        Me.mebFrDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebFrDt.Location = New System.Drawing.Point(553, 54)
        Me.mebFrDt.Name = "mebFrDt"
        Me.mebFrDt.Size = New System.Drawing.Size(86, 22)
        Me.mebFrDt.TabIndex = 35
        '
        'chkUseDateWise
        '
        Me.chkUseDateWise.AutoSize = True
        Me.chkUseDateWise.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseDateWise.ForeColor = System.Drawing.Color.Gray
        Me.chkUseDateWise.Location = New System.Drawing.Point(637, 128)
        Me.chkUseDateWise.Name = "chkUseDateWise"
        Me.chkUseDateWise.Size = New System.Drawing.Size(115, 17)
        Me.chkUseDateWise.TabIndex = 34
        Me.chkUseDateWise.Text = "FILTER DATEWISE"
        Me.chkUseDateWise.UseVisualStyleBackColor = True
        '
        'mebTillDt
        '
        Me.mebTillDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebTillDt.Location = New System.Drawing.Point(553, 125)
        Me.mebTillDt.Name = "mebTillDt"
        Me.mebTillDt.Size = New System.Drawing.Size(78, 22)
        Me.mebTillDt.TabIndex = 33
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = True
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 190)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(1070, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 32
        Me.SimpleLine1.UseGradient = False
        '
        'cmbDept
        '
        Me.cmbDept.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDept.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(12, 152)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(247, 23)
        Me.cmbDept.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(550, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "TILL DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "DEPARTMENT"
        '
        'cmbVendor
        '
        Me.cmbVendor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(12, 100)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(247, 23)
        Me.cmbVendor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "VENDOR"
        '
        'chkEZQ
        '
        Me.chkEZQ.AutoSize = True
        Me.chkEZQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEZQ.ForeColor = System.Drawing.Color.Gray
        Me.chkEZQ.Location = New System.Drawing.Point(553, 156)
        Me.chkEZQ.Name = "chkEZQ"
        Me.chkEZQ.Size = New System.Drawing.Size(163, 17)
        Me.chkEZQ.TabIndex = 3
        Me.chkEZQ.Text = "EXCLUDE ZERO QUANTITY"
        Me.chkEZQ.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(775, 7)
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
        Me.btnDisplay.Location = New System.Drawing.Point(778, 53)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(181, 120)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(9, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "SEARCH FILTER"
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(12, 53)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(247, 23)
        Me.cmbLocation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOCATIONS"
        '
        'CRpt
        '
        Me.CRpt.ActiveViewIndex = -1
        Me.CRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRpt.Location = New System.Drawing.Point(0, 230)
        Me.CRpt.Name = "CRpt"
        Me.CRpt.Size = New System.Drawing.Size(1070, 248)
        Me.CRpt.TabIndex = 2
        Me.CRpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'StockReportLocationWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 478)
        Me.Controls.Add(Me.CRpt)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StockReportLocationWise"
        Me.Tag = "27"
        Me.Text = "StockReportLocationWise"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chkEZQ As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents CRpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents mebTillDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkUseDateWise As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkEDBF As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mebToDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents mebFrDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
