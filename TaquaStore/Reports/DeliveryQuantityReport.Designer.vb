<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryQuantityReport
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
        Me.chkECF = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.cmbOrderBy = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.btnAdvanceSearch = New System.Windows.Forms.Button()
        Me.mebTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mebFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.pnlCatFilter = New System.Windows.Forms.Panel()
        Me.CMBGrn = New System.Windows.Forms.ComboBox()
        Me.lblGRN = New System.Windows.Forms.Label()
        Me.chkFGW = New System.Windows.Forms.CheckBox()
        Me.btnLoadGRN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlCatFilter.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(992, 39)
        Me.Panel3.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(169, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Delivery Report"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(919, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.chkECF)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.txtCode)
        Me.Panel4.Controls.Add(Me.cmbOrderBy)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.SimpleLine1)
        Me.Panel4.Controls.Add(Me.btnAdvanceSearch)
        Me.Panel4.Controls.Add(Me.mebTo)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.mebFrom)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnDisplay)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmbLocation)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(992, 91)
        Me.Panel4.TabIndex = 4
        '
        'chkECF
        '
        Me.chkECF.AutoSize = True
        Me.chkECF.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkECF.ForeColor = System.Drawing.Color.Black
        Me.chkECF.Location = New System.Drawing.Point(845, 24)
        Me.chkECF.Name = "chkECF"
        Me.chkECF.Size = New System.Drawing.Size(120, 17)
        Me.chkECF.TabIndex = 1
        Me.chkECF.Text = "Enable Code Filter"
        Me.chkECF.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(615, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "CODE"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(618, 55)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(115, 22)
        Me.txtCode.TabIndex = 33
        '
        'cmbOrderBy
        '
        Me.cmbOrderBy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrderBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderBy.FormattingEnabled = True
        Me.cmbOrderBy.Location = New System.Drawing.Point(498, 55)
        Me.cmbOrderBy.Name = "cmbOrderBy"
        Me.cmbOrderBy.Size = New System.Drawing.Size(114, 23)
        Me.cmbOrderBy.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(498, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "ORDER BY"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 90)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(992, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 31
        Me.SimpleLine1.UseGradient = False
        '
        'btnAdvanceSearch
        '
        Me.btnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdvanceSearch.FlatAppearance.BorderSize = 0
        Me.btnAdvanceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvanceSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanceSearch.ForeColor = System.Drawing.Color.White
        Me.btnAdvanceSearch.Location = New System.Drawing.Point(845, 47)
        Me.btnAdvanceSearch.Name = "btnAdvanceSearch"
        Me.btnAdvanceSearch.Size = New System.Drawing.Size(118, 31)
        Me.btnAdvanceSearch.TabIndex = 5
        Me.btnAdvanceSearch.Text = "ADVANCE SEARCH"
        Me.btnAdvanceSearch.UseVisualStyleBackColor = False
        '
        'mebTo
        '
        Me.mebTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebTo.Location = New System.Drawing.Point(124, 56)
        Me.mebTo.Name = "mebTo"
        Me.mebTo.Size = New System.Drawing.Size(106, 22)
        Me.mebTo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "TO"
        '
        'mebFrom
        '
        Me.mebFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebFrom.Location = New System.Drawing.Point(12, 56)
        Me.mebFrom.Name = "mebFrom"
        Me.mebFrom.Size = New System.Drawing.Size(106, 22)
        Me.mebFrom.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(749, 7)
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
        Me.btnDisplay.Location = New System.Drawing.Point(752, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(87, 31)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FROM"
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(245, 55)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(247, 23)
        Me.cmbLocation.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 40)
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
        Me.CRpt.Location = New System.Drawing.Point(0, 130)
        Me.CRpt.Name = "CRpt"
        Me.CRpt.Size = New System.Drawing.Size(992, 322)
        Me.CRpt.TabIndex = 24
        Me.CRpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'pnlCatFilter
        '
        Me.pnlCatFilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlCatFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatFilter.Controls.Add(Me.CMBGrn)
        Me.pnlCatFilter.Controls.Add(Me.lblGRN)
        Me.pnlCatFilter.Controls.Add(Me.chkFGW)
        Me.pnlCatFilter.Controls.Add(Me.btnLoadGRN)
        Me.pnlCatFilter.Controls.Add(Me.Label10)
        Me.pnlCatFilter.Controls.Add(Me.Label5)
        Me.pnlCatFilter.Controls.Add(Me.cmbVendor)
        Me.pnlCatFilter.Controls.Add(Me.btnFilter)
        Me.pnlCatFilter.Controls.Add(Me.btnHide)
        Me.pnlCatFilter.Controls.Add(Me.Label6)
        Me.pnlCatFilter.Controls.Add(Me.Label7)
        Me.pnlCatFilter.Controls.Add(Me.cmbMaterial)
        Me.pnlCatFilter.Controls.Add(Me.Label8)
        Me.pnlCatFilter.Controls.Add(Me.cmbStyle)
        Me.pnlCatFilter.Controls.Add(Me.Label9)
        Me.pnlCatFilter.Controls.Add(Me.cmbCat)
        Me.pnlCatFilter.Controls.Add(Me.cmbDept)
        Me.pnlCatFilter.Location = New System.Drawing.Point(660, 125)
        Me.pnlCatFilter.Name = "pnlCatFilter"
        Me.pnlCatFilter.Size = New System.Drawing.Size(302, 308)
        Me.pnlCatFilter.TabIndex = 6
        Me.pnlCatFilter.Visible = False
        '
        'CMBGrn
        '
        Me.CMBGrn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGrn.FormattingEnabled = True
        Me.CMBGrn.Location = New System.Drawing.Point(11, 270)
        Me.CMBGrn.Name = "CMBGrn"
        Me.CMBGrn.Size = New System.Drawing.Size(102, 21)
        Me.CMBGrn.TabIndex = 15
        Me.CMBGrn.Visible = False
        '
        'lblGRN
        '
        Me.lblGRN.AutoSize = True
        Me.lblGRN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGRN.ForeColor = System.Drawing.Color.Black
        Me.lblGRN.Location = New System.Drawing.Point(8, 254)
        Me.lblGRN.Name = "lblGRN"
        Me.lblGRN.Size = New System.Drawing.Size(51, 13)
        Me.lblGRN.TabIndex = 14
        Me.lblGRN.Text = "GRN NO"
        Me.lblGRN.Visible = False
        '
        'chkFGW
        '
        Me.chkFGW.AutoSize = True
        Me.chkFGW.Location = New System.Drawing.Point(184, 9)
        Me.chkFGW.Name = "chkFGW"
        Me.chkFGW.Size = New System.Drawing.Size(106, 17)
        Me.chkFGW.TabIndex = 13
        Me.chkFGW.Text = "Filter GRN Wise"
        Me.chkFGW.UseVisualStyleBackColor = True
        '
        'btnLoadGRN
        '
        Me.btnLoadGRN.AutoSize = True
        Me.btnLoadGRN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadGRN.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadGRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLoadGRN.Location = New System.Drawing.Point(230, 44)
        Me.btnLoadGRN.Name = "btnLoadGRN"
        Me.btnLoadGRN.Size = New System.Drawing.Size(60, 13)
        Me.btnLoadGRN.TabIndex = 12
        Me.btnLoadGRN.Text = "Load GRN"
        Me.btnLoadGRN.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "ADVANCE FILTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "VENDOR"
        '
        'cmbVendor
        '
        Me.cmbVendor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(10, 62)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(280, 21)
        Me.cmbVendor.TabIndex = 0
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(151, 264)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(67, 30)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "FILTER"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(224, 264)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(67, 30)
        Me.btnHide.TabIndex = 6
        Me.btnHide.Tag = "1"
        Me.btnHide.Text = "HIDE"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DEPARTMENT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "CATEGORY"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(10, 225)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(280, 21)
        Me.cmbMaterial.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "STYLE"
        '
        'cmbStyle
        '
        Me.cmbStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Location = New System.Drawing.Point(10, 185)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(280, 21)
        Me.cmbStyle.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Catalog"
        '
        'cmbCat
        '
        Me.cmbCat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(10, 145)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(280, 21)
        Me.cmbCat.TabIndex = 2
        '
        'cmbDept
        '
        Me.cmbDept.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(10, 105)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(280, 21)
        Me.cmbDept.TabIndex = 1
        '
        'DeliveryQuantityReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 452)
        Me.Controls.Add(Me.pnlCatFilter)
        Me.Controls.Add(Me.CRpt)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DeliveryQuantityReport"
        Me.Tag = "28"
        Me.Text = "Delivery Report"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlCatFilter.ResumeLayout(False)
        Me.pnlCatFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents mebTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mebFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdvanceSearch As System.Windows.Forms.Button
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents CRpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnlCatFilter As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkECF As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents chkFGW As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadGRN As System.Windows.Forms.Label
    Friend WithEvents CMBGrn As System.Windows.Forms.ComboBox
    Friend WithEvents lblGRN As System.Windows.Forms.Label
End Class
