<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBillGenerator
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExcelToExport = New System.Windows.Forms.Button()
        Me.chkLCDA = New System.Windows.Forms.CheckBox()
        Me.chkDBL = New System.Windows.Forms.CheckBox()
        Me.mebBillDt = New System.Windows.Forms.DateTimePicker()
        Me.mebTo = New System.Windows.Forms.DateTimePicker()
        Me.mebFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnAlter = New System.Windows.Forms.Button()
        Me.btnATax = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LstGRN = New System.Windows.Forms.ListBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNett = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.lblDebit = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBillAmt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.pnlTax = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TGTax = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbLedger = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlAlter = New System.Windows.Forms.Panel()
        Me.pnlRemarks = New System.Windows.Forms.Panel()
        Me.dtpCheque = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblBillDate = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.TGEdt = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cmbVendor2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlBill = New System.Windows.Forms.Panel()
        Me.btnHide2 = New System.Windows.Forms.Button()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.TGBill = New System.Windows.Forms.DataGridView()
        Me.Column16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBankList = New System.Windows.Forms.Panel()
        Me.btnCashOnly = New System.Windows.Forms.Button()
        Me.btnHide3 = New System.Windows.Forms.Button()
        Me.btnRefBankList = New System.Windows.Forms.Button()
        Me.btnAddNewBank = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TGBank = New System.Windows.Forms.DataGridView()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlExcelExport = New System.Windows.Forms.Panel()
        Me.btnHide4 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SaveDiag = New System.Windows.Forms.SaveFileDialog()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column34 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTax.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TGTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlter.SuspendLayout()
        Me.pnlRemarks.SuspendLayout()
        CType(Me.TGEdt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBill.SuspendLayout()
        CType(Me.TGBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBankList.SuspendLayout()
        CType(Me.TGBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExcelExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnExcelToExport)
        Me.Panel1.Controls.Add(Me.chkLCDA)
        Me.Panel1.Controls.Add(Me.chkDBL)
        Me.Panel1.Controls.Add(Me.mebBillDt)
        Me.Panel1.Controls.Add(Me.mebTo)
        Me.Panel1.Controls.Add(Me.mebFrom)
        Me.Panel1.Controls.Add(Me.btnAlter)
        Me.Panel1.Controls.Add(Me.btnATax)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtBillNo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.cmbVendor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1261, 88)
        Me.Panel1.TabIndex = 0
        '
        'btnExcelToExport
        '
        Me.btnExcelToExport.BackColor = System.Drawing.Color.DimGray
        Me.btnExcelToExport.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnExcelToExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelToExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcelToExport.ForeColor = System.Drawing.Color.White
        Me.btnExcelToExport.Location = New System.Drawing.Point(1037, 45)
        Me.btnExcelToExport.Name = "btnExcelToExport"
        Me.btnExcelToExport.Size = New System.Drawing.Size(149, 26)
        Me.btnExcelToExport.TabIndex = 15
        Me.btnExcelToExport.Text = "&Export To Excel"
        Me.btnExcelToExport.UseVisualStyleBackColor = False
        '
        'chkLCDA
        '
        Me.chkLCDA.AutoSize = True
        Me.chkLCDA.Checked = True
        Me.chkLCDA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLCDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLCDA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkLCDA.Location = New System.Drawing.Point(845, 21)
        Me.chkLCDA.Name = "chkLCDA"
        Me.chkLCDA.Size = New System.Drawing.Size(188, 18)
        Me.chkLCDA.TabIndex = 14
        Me.chkLCDA.Text = "Load Complete Debit Amount"
        Me.chkLCDA.UseVisualStyleBackColor = True
        '
        'chkDBL
        '
        Me.chkDBL.AutoSize = True
        Me.chkDBL.Checked = True
        Me.chkDBL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDBL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDBL.ForeColor = System.Drawing.Color.Yellow
        Me.chkDBL.Location = New System.Drawing.Point(561, 25)
        Me.chkDBL.Name = "chkDBL"
        Me.chkDBL.Size = New System.Drawing.Size(108, 18)
        Me.chkDBL.TabIndex = 13
        Me.chkDBL.Text = "Display Bill List"
        Me.chkDBL.UseVisualStyleBackColor = True
        '
        'mebBillDt
        '
        Me.mebBillDt.Enabled = False
        Me.mebBillDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebBillDt.Location = New System.Drawing.Point(93, 51)
        Me.mebBillDt.Name = "mebBillDt"
        Me.mebBillDt.Size = New System.Drawing.Size(95, 20)
        Me.mebBillDt.TabIndex = 1
        '
        'mebTo
        '
        Me.mebTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebTo.Location = New System.Drawing.Point(307, 51)
        Me.mebTo.Name = "mebTo"
        Me.mebTo.Size = New System.Drawing.Size(95, 20)
        Me.mebTo.TabIndex = 3
        '
        'mebFrom
        '
        Me.mebFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebFrom.Location = New System.Drawing.Point(206, 51)
        Me.mebFrom.Name = "mebFrom"
        Me.mebFrom.Size = New System.Drawing.Size(95, 20)
        Me.mebFrom.TabIndex = 2
        '
        'btnAlter
        '
        Me.btnAlter.BackColor = System.Drawing.Color.DimGray
        Me.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlter.ForeColor = System.Drawing.Color.White
        Me.btnAlter.Location = New System.Drawing.Point(772, 45)
        Me.btnAlter.Name = "btnAlter"
        Me.btnAlter.Size = New System.Drawing.Size(75, 26)
        Me.btnAlter.TabIndex = 6
        Me.btnAlter.Text = "&Reprint"
        Me.btnAlter.UseVisualStyleBackColor = False
        '
        'btnATax
        '
        Me.btnATax.BackColor = System.Drawing.Color.Gray
        Me.btnATax.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnATax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnATax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnATax.ForeColor = System.Drawing.Color.White
        Me.btnATax.Location = New System.Drawing.Point(934, 45)
        Me.btnATax.Name = "btnATax"
        Me.btnATax.Size = New System.Drawing.Size(97, 26)
        Me.btnATax.TabIndex = 8
        Me.btnATax.Text = "&Apply Tax"
        Me.btnATax.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(90, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 14)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Bill Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 14)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Bill No"
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(15, 51)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(72, 20)
        Me.txtBillNo.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 14)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "BILL INFO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(688, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "OPTIONS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(423, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "VENDOR FILTER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(203, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DURATION"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DimGray
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(853, 45)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 26)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.DimGray
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(691, 45)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 26)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'cmbVendor
        '
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(426, 49)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(243, 22)
        Me.cmbVendor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(423, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Vendor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(304, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.LstGRN)
        Me.Panel2.Controls.Add(Me.lblQty)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblNett)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblAdvance)
        Me.Panel2.Controls.Add(Me.lblDebit)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblBillAmt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.SimpleLine1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1261, 74)
        Me.Panel2.TabIndex = 1
        '
        'LstGRN
        '
        Me.LstGRN.FormattingEnabled = True
        Me.LstGRN.ItemHeight = 14
        Me.LstGRN.Location = New System.Drawing.Point(611, 8)
        Me.LstGRN.Name = "LstGRN"
        Me.LstGRN.Size = New System.Drawing.Size(73, 60)
        Me.LstGRN.TabIndex = 9
        Me.LstGRN.Visible = False
        '
        'lblQty
        '
        Me.lblQty.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQty.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblQty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.White
        Me.lblQty.Location = New System.Drawing.Point(934, 23)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(99, 27)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "0.00"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(824, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 27)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "TOTAL QUANTITY"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNett
        '
        Me.lblNett.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNett.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblNett.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNett.ForeColor = System.Drawing.Color.White
        Me.lblNett.Location = New System.Drawing.Point(1150, 23)
        Me.lblNett.Name = "lblNett"
        Me.lblNett.Size = New System.Drawing.Size(99, 27)
        Me.lblNett.TabIndex = 6
        Me.lblNett.Text = "0.00"
        Me.lblNett.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1051, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 27)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "NETT AMOUNT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdvance
        '
        Me.lblAdvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAdvance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvance.ForeColor = System.Drawing.Color.White
        Me.lblAdvance.Location = New System.Drawing.Point(301, 23)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(99, 27)
        Me.lblAdvance.TabIndex = 4
        Me.lblAdvance.Text = "0.00"
        Me.lblAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDebit
        '
        Me.lblDebit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDebit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.ForeColor = System.Drawing.Color.White
        Me.lblDebit.Location = New System.Drawing.Point(506, 23)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(99, 27)
        Me.lblDebit.TabIndex = 4
        Me.lblDebit.Text = "0.00"
        Me.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Gray
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(201, 23)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 27)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "ADV. AMOUNT"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gray
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(406, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 27)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "DEBIT AMOUNT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBillAmt
        '
        Me.lblBillAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBillAmt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmt.ForeColor = System.Drawing.Color.White
        Me.lblBillAmt.Location = New System.Drawing.Point(96, 23)
        Me.lblBillAmt.Name = "lblBillAmt"
        Me.lblBillAmt.Size = New System.Drawing.Size(99, 27)
        Me.lblBillAmt.TabIndex = 2
        Me.lblBillAmt.Text = "0.00"
        Me.lblBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 27)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "BILL AMOUNT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SimpleLine1.LineWidth = 2
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(1261, 2)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 0
        Me.SimpleLine1.UseGradient = False
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle2
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.Gray
        Me.TG.Location = New System.Drawing.Point(0, 88)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(1261, 353)
        Me.TG.TabIndex = 2
        '
        'pnlTax
        '
        Me.pnlTax.BackColor = System.Drawing.Color.Gray
        Me.pnlTax.Controls.Add(Me.Panel4)
        Me.pnlTax.Location = New System.Drawing.Point(293, 105)
        Me.pnlTax.Name = "pnlTax"
        Me.pnlTax.Size = New System.Drawing.Size(421, 304)
        Me.pnlTax.TabIndex = 3
        Me.pnlTax.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.btnHide)
        Me.Panel4.Controls.Add(Me.btnUpdate)
        Me.Panel4.Controls.Add(Me.TGTax)
        Me.Panel4.Controls.Add(Me.lblAmt)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.SimpleLine2)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txtAmount)
        Me.Panel4.Controls.Add(Me.txtPerc)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.cmbMode)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.cmbLedger)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(6, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(408, 291)
        Me.Panel4.TabIndex = 0
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Gray
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(72, 11)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(41, 26)
        Me.btnHide.TabIndex = 6
        Me.btnHide.Text = "HIDE"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(14, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 26)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'TGTax
        '
        Me.TGTax.AllowUserToAddRows = False
        Me.TGTax.AllowUserToDeleteRows = False
        Me.TGTax.AllowUserToResizeColumns = False
        Me.TGTax.AllowUserToResizeRows = False
        Me.TGTax.BackgroundColor = System.Drawing.Color.White
        Me.TGTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGTax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TGTax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGTax.ColumnHeadersHeight = 25
        Me.TGTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGTax.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGTax.DefaultCellStyle = DataGridViewCellStyle3
        Me.TGTax.EnableHeadersVisualStyles = False
        Me.TGTax.GridColor = System.Drawing.Color.Gray
        Me.TGTax.Location = New System.Drawing.Point(14, 114)
        Me.TGTax.Name = "TGTax"
        Me.TGTax.ReadOnly = True
        Me.TGTax.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGTax.RowHeadersVisible = False
        Me.TGTax.RowTemplate.Height = 25
        Me.TGTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TGTax.Size = New System.Drawing.Size(383, 146)
        Me.TGTax.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "LedgerID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ledger Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mode"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Per (%)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "OAmount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'lblAmt
        '
        Me.lblAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(308, 15)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(89, 19)
        Me.lblAmt.TabIndex = 9
        Me.lblAmt.Text = "0.00"
        Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(168, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 19)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "TOTAL AMOUNT"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(4, 50)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(401, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 8
        Me.SimpleLine2.UseGradient = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(353, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 14)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(316, 86)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(81, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Tag = "1"
        '
        'txtPerc
        '
        Me.txtPerc.Location = New System.Drawing.Point(245, 86)
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(65, 20)
        Me.txtPerc.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(242, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 14)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Perc (%)"
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"Add", "Less"})
        Me.cmbMode.Location = New System.Drawing.Point(172, 86)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(65, 22)
        Me.cmbMode.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(169, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 14)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Mode"
        '
        'cmbLedger
        '
        Me.cmbLedger.FormattingEnabled = True
        Me.cmbLedger.Location = New System.Drawing.Point(14, 86)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(150, 22)
        Me.cmbLedger.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 14)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tax Ledger"
        '
        'pnlAlter
        '
        Me.pnlAlter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAlter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAlter.Controls.Add(Me.pnlRemarks)
        Me.pnlAlter.Controls.Add(Me.TGEdt)
        Me.pnlAlter.Controls.Add(Me.Button1)
        Me.pnlAlter.Controls.Add(Me.btnFilter)
        Me.pnlAlter.Controls.Add(Me.cmbVendor2)
        Me.pnlAlter.Controls.Add(Me.Label8)
        Me.pnlAlter.Controls.Add(Me.Label11)
        Me.pnlAlter.Location = New System.Drawing.Point(238, 107)
        Me.pnlAlter.Name = "pnlAlter"
        Me.pnlAlter.Size = New System.Drawing.Size(692, 301)
        Me.pnlAlter.TabIndex = 9
        Me.pnlAlter.Visible = False
        '
        'pnlRemarks
        '
        Me.pnlRemarks.BackColor = System.Drawing.Color.White
        Me.pnlRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRemarks.Controls.Add(Me.dtpCheque)
        Me.pnlRemarks.Controls.Add(Me.Label28)
        Me.pnlRemarks.Controls.Add(Me.lblBillDate)
        Me.pnlRemarks.Controls.Add(Me.btnClose)
        Me.pnlRemarks.Controls.Add(Me.btnSave)
        Me.pnlRemarks.Controls.Add(Me.lblBillNo)
        Me.pnlRemarks.Controls.Add(Me.Label27)
        Me.pnlRemarks.Controls.Add(Me.lblVendor)
        Me.pnlRemarks.Controls.Add(Me.Label29)
        Me.pnlRemarks.Controls.Add(Me.Label26)
        Me.pnlRemarks.Controls.Add(Me.Label25)
        Me.pnlRemarks.Controls.Add(Me.txtCheque)
        Me.pnlRemarks.Controls.Add(Me.txtNotes)
        Me.pnlRemarks.Location = New System.Drawing.Point(120, 84)
        Me.pnlRemarks.Name = "pnlRemarks"
        Me.pnlRemarks.Size = New System.Drawing.Size(451, 187)
        Me.pnlRemarks.TabIndex = 6
        Me.pnlRemarks.Visible = False
        '
        'dtpCheque
        '
        Me.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheque.Location = New System.Drawing.Point(206, 134)
        Me.dtpCheque.Name = "dtpCheque"
        Me.dtpCheque.Size = New System.Drawing.Size(102, 20)
        Me.dtpCheque.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(317, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Bill Date : "
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDate.Location = New System.Drawing.Point(377, 34)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(52, 13)
        Me.lblBillDate.TabIndex = 2
        Me.lblBillDate.Text = "@BillDate"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(379, 131)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(59, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gray
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(314, 131)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(59, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(269, 34)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(42, 13)
        Me.lblBillNo.TabIndex = 2
        Me.lblBillNo.Text = "@BillNo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(223, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Bill No : "
        '
        'lblVendor
        '
        Me.lblVendor.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVendor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendor.Location = New System.Drawing.Point(0, 0)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(449, 25)
        Me.lblVendor.TabIndex = 2
        Me.lblVendor.Text = "@Vendor"
        Me.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(202, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Date :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Cheque No :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Notes : "
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(12, 134)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(188, 20)
        Me.txtCheque.TabIndex = 1
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(12, 51)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(426, 57)
        Me.txtNotes.TabIndex = 0
        '
        'TGEdt
        '
        Me.TGEdt.AllowUserToAddRows = False
        Me.TGEdt.AllowUserToDeleteRows = False
        Me.TGEdt.AllowUserToResizeColumns = False
        Me.TGEdt.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TGEdt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TGEdt.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TGEdt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGEdt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TGEdt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGEdt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TGEdt.ColumnHeadersHeight = 30
        Me.TGEdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGEdt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column22, Me.Column34, Me.Column15, Me.Column18, Me.Column19, Me.Column20, Me.Column33, Me.Column35})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGEdt.DefaultCellStyle = DataGridViewCellStyle6
        Me.TGEdt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TGEdt.EnableHeadersVisualStyles = False
        Me.TGEdt.Location = New System.Drawing.Point(0, 54)
        Me.TGEdt.MultiSelect = False
        Me.TGEdt.Name = "TGEdt"
        Me.TGEdt.ReadOnly = True
        Me.TGEdt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGEdt.RowHeadersVisible = False
        Me.TGEdt.RowTemplate.Height = 30
        Me.TGEdt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGEdt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TGEdt.Size = New System.Drawing.Size(690, 245)
        Me.TGEdt.TabIndex = 6
        Me.TGEdt.Tag = "1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(589, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Hide"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Gray
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(399, 25)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(184, 23)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbVendor2
        '
        Me.cmbVendor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbVendor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVendor2.BackColor = System.Drawing.Color.White
        Me.cmbVendor2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor2.FormattingEnabled = True
        Me.cmbVendor2.Location = New System.Drawing.Point(66, 25)
        Me.cmbVendor2.Name = "cmbVendor2"
        Me.cmbVendor2.Size = New System.Drawing.Size(327, 23)
        Me.cmbVendor2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "OPTIONS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "VENDOR"
        '
        'pnlBill
        '
        Me.pnlBill.BackColor = System.Drawing.Color.DimGray
        Me.pnlBill.Controls.Add(Me.btnHide2)
        Me.pnlBill.Controls.Add(Me.btnPick)
        Me.pnlBill.Controls.Add(Me.TGBill)
        Me.pnlBill.Location = New System.Drawing.Point(691, 77)
        Me.pnlBill.Name = "pnlBill"
        Me.pnlBill.Size = New System.Drawing.Size(206, 351)
        Me.pnlBill.TabIndex = 10
        Me.pnlBill.Visible = False
        '
        'btnHide2
        '
        Me.btnHide2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHide2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide2.ForeColor = System.Drawing.Color.White
        Me.btnHide2.Location = New System.Drawing.Point(154, 321)
        Me.btnHide2.Name = "btnHide2"
        Me.btnHide2.Size = New System.Drawing.Size(49, 26)
        Me.btnHide2.TabIndex = 2
        Me.btnHide2.Text = "Hide"
        Me.btnHide2.UseVisualStyleBackColor = False
        '
        'btnPick
        '
        Me.btnPick.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPick.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPick.ForeColor = System.Drawing.Color.White
        Me.btnPick.Location = New System.Drawing.Point(101, 321)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(49, 26)
        Me.btnPick.TabIndex = 1
        Me.btnPick.Text = "Pick"
        Me.btnPick.UseVisualStyleBackColor = False
        '
        'TGBill
        '
        Me.TGBill.AllowUserToAddRows = False
        Me.TGBill.AllowUserToDeleteRows = False
        Me.TGBill.AllowUserToResizeColumns = False
        Me.TGBill.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TGBill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TGBill.BackgroundColor = System.Drawing.Color.White
        Me.TGBill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TGBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGBill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.TGBill.ColumnHeadersHeight = 30
        Me.TGBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column16, Me.Column7, Me.Column8, Me.Column17, Me.Column21})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGBill.DefaultCellStyle = DataGridViewCellStyle9
        Me.TGBill.EnableHeadersVisualStyles = False
        Me.TGBill.Location = New System.Drawing.Point(3, 3)
        Me.TGBill.MultiSelect = False
        Me.TGBill.Name = "TGBill"
        Me.TGBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGBill.RowHeadersVisible = False
        Me.TGBill.RowTemplate.Height = 30
        Me.TGBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGBill.Size = New System.Drawing.Size(200, 312)
        Me.TGBill.TabIndex = 0
        Me.TGBill.Tag = "1"
        '
        'Column16
        '
        Me.Column16.FalseValue = "0"
        Me.Column16.HeaderText = ""
        Me.Column16.Name = "Column16"
        Me.Column16.TrueValue = "1"
        Me.Column16.Width = 20
        '
        'Column7
        '
        Me.Column7.HeaderText = "INV NO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "DATE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'Column17
        '
        Me.Column17.HeaderText = ""
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 20
        '
        'Column21
        '
        Me.Column21.HeaderText = "GRNNO"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Visible = False
        '
        'pnlBankList
        '
        Me.pnlBankList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBankList.Controls.Add(Me.btnCashOnly)
        Me.pnlBankList.Controls.Add(Me.btnHide3)
        Me.pnlBankList.Controls.Add(Me.btnRefBankList)
        Me.pnlBankList.Controls.Add(Me.btnAddNewBank)
        Me.pnlBankList.Controls.Add(Me.Label21)
        Me.pnlBankList.Controls.Add(Me.TGBank)
        Me.pnlBankList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBankList.Location = New System.Drawing.Point(226, 130)
        Me.pnlBankList.Name = "pnlBankList"
        Me.pnlBankList.Size = New System.Drawing.Size(656, 255)
        Me.pnlBankList.TabIndex = 11
        Me.pnlBankList.Visible = False
        '
        'btnCashOnly
        '
        Me.btnCashOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCashOnly.Location = New System.Drawing.Point(565, 222)
        Me.btnCashOnly.Name = "btnCashOnly"
        Me.btnCashOnly.Size = New System.Drawing.Size(85, 26)
        Me.btnCashOnly.TabIndex = 5
        Me.btnCashOnly.Text = "&Cash Only"
        Me.btnCashOnly.UseVisualStyleBackColor = True
        '
        'btnHide3
        '
        Me.btnHide3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHide3.FlatAppearance.BorderSize = 0
        Me.btnHide3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide3.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide3.ForeColor = System.Drawing.Color.Black
        Me.btnHide3.Location = New System.Drawing.Point(616, 6)
        Me.btnHide3.Name = "btnHide3"
        Me.btnHide3.Size = New System.Drawing.Size(34, 28)
        Me.btnHide3.TabIndex = 4
        Me.btnHide3.Text = "r"
        Me.btnHide3.UseVisualStyleBackColor = False
        '
        'btnRefBankList
        '
        Me.btnRefBankList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefBankList.ForeColor = System.Drawing.Color.Purple
        Me.btnRefBankList.Location = New System.Drawing.Point(132, 222)
        Me.btnRefBankList.Name = "btnRefBankList"
        Me.btnRefBankList.Size = New System.Drawing.Size(122, 26)
        Me.btnRefBankList.TabIndex = 3
        Me.btnRefBankList.Text = "&Refresh Bank List"
        Me.btnRefBankList.UseVisualStyleBackColor = True
        '
        'btnAddNewBank
        '
        Me.btnAddNewBank.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddNewBank.Location = New System.Drawing.Point(4, 222)
        Me.btnAddNewBank.Name = "btnAddNewBank"
        Me.btnAddNewBank.Size = New System.Drawing.Size(122, 26)
        Me.btnAddNewBank.TabIndex = 2
        Me.btnAddNewBank.Text = "&Add New Bank"
        Me.btnAddNewBank.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(282, 11)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 16)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "List of Banks"
        '
        'TGBank
        '
        Me.TGBank.AllowUserToAddRows = False
        Me.TGBank.AllowUserToDeleteRows = False
        Me.TGBank.AllowUserToResizeColumns = False
        Me.TGBank.AllowUserToResizeRows = False
        Me.TGBank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGBank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column23, Me.Column30, Me.Column24, Me.Column25, Me.Column26, Me.Column27, Me.Column31, Me.Column32, Me.Column28, Me.Column29})
        Me.TGBank.EnableHeadersVisualStyles = False
        Me.TGBank.Location = New System.Drawing.Point(4, 43)
        Me.TGBank.Name = "TGBank"
        Me.TGBank.ReadOnly = True
        Me.TGBank.RowHeadersVisible = False
        Me.TGBank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGBank.Size = New System.Drawing.Size(646, 174)
        Me.TGBank.TabIndex = 0
        '
        'Column23
        '
        Me.Column23.HeaderText = "ID"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Visible = False
        '
        'Column30
        '
        Me.Column30.HeaderText = "Sno"
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.Width = 40
        '
        'Column24
        '
        Me.Column24.HeaderText = "Bank"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Width = 150
        '
        'Column25
        '
        Me.Column25.HeaderText = "A/C No"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Width = 120
        '
        'Column26
        '
        Me.Column26.HeaderText = "A/C Name"
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.Width = 150
        '
        'Column27
        '
        Me.Column27.HeaderText = "IFSC"
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        '
        'Column31
        '
        Me.Column31.HeaderText = "ACType"
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.Visible = False
        '
        'Column32
        '
        Me.Column32.HeaderText = "BankID"
        Me.Column32.Name = "Column32"
        Me.Column32.ReadOnly = True
        Me.Column32.Visible = False
        '
        'Column28
        '
        Me.Column28.HeaderText = ""
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.Text = "Select"
        Me.Column28.UseColumnTextForButtonValue = True
        Me.Column28.Width = 60
        '
        'Column29
        '
        Me.Column29.HeaderText = ""
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.Width = 23
        '
        'pnlExcelExport
        '
        Me.pnlExcelExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExcelExport.Controls.Add(Me.btnHide4)
        Me.pnlExcelExport.Controls.Add(Me.btnExport)
        Me.pnlExcelExport.Controls.Add(Me.dtpTo)
        Me.pnlExcelExport.Controls.Add(Me.Label24)
        Me.pnlExcelExport.Controls.Add(Me.dtpFrom)
        Me.pnlExcelExport.Controls.Add(Me.Label23)
        Me.pnlExcelExport.Controls.Add(Me.Label22)
        Me.pnlExcelExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlExcelExport.Location = New System.Drawing.Point(489, 175)
        Me.pnlExcelExport.Name = "pnlExcelExport"
        Me.pnlExcelExport.Size = New System.Drawing.Size(282, 165)
        Me.pnlExcelExport.TabIndex = 12
        Me.pnlExcelExport.Visible = False
        '
        'btnHide4
        '
        Me.btnHide4.FlatAppearance.BorderSize = 0
        Me.btnHide4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide4.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide4.ForeColor = System.Drawing.Color.Red
        Me.btnHide4.Location = New System.Drawing.Point(248, 5)
        Me.btnHide4.Name = "btnHide4"
        Me.btnHide4.Size = New System.Drawing.Size(25, 28)
        Me.btnHide4.TabIndex = 3
        Me.btnHide4.Text = "r"
        Me.btnHide4.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExport.Location = New System.Drawing.Point(90, 117)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 25)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(145, 70)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(112, 21)
        Me.dtpTo.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(142, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "To"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(26, 70)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(112, 21)
        Me.dtpFrom.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "From"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(88, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Export To Excel"
        '
        'SaveDiag
        '
        Me.SaveDiag.DefaultExt = "xlsx"
        Me.SaveDiag.Filter = "Excel Files | *.xlsx"
        Me.SaveDiag.Title = "Choose File Location"
        '
        'Column9
        '
        Me.Column9.HeaderText = "BILL NO"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 70
        '
        'Column10
        '
        Me.Column10.HeaderText = "DATE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 80
        '
        'Column11
        '
        Me.Column11.HeaderText = "VENDOR NAME"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 200
        '
        'Column12
        '
        Me.Column12.HeaderText = "AMOUNT"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        Me.Column13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column13.HeaderText = "VIEW"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Text = "VIEW"
        Me.Column13.UseColumnTextForButtonValue = True
        Me.Column13.Width = 60
        '
        'Column14
        '
        Me.Column14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column14.HeaderText = "DELETE"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Text = "DELETE"
        Me.Column14.UseColumnTextForButtonValue = True
        Me.Column14.Width = 60
        '
        'Column22
        '
        Me.Column22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column22.HeaderText = "STATUS"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Text = "STATUS"
        Me.Column22.UseColumnTextForButtonValue = True
        Me.Column22.Width = 60
        '
        'Column34
        '
        Me.Column34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column34.HeaderText = "REMARKS"
        Me.Column34.Name = "Column34"
        Me.Column34.ReadOnly = True
        Me.Column34.Text = "REMARKS"
        Me.Column34.UseColumnTextForButtonValue = True
        Me.Column34.Width = 60
        '
        'Column15
        '
        Me.Column15.HeaderText = ""
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 20
        '
        'Column18
        '
        Me.Column18.HeaderText = "FROM"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Visible = False
        '
        'Column19
        '
        Me.Column19.HeaderText = "TO"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Visible = False
        '
        'Column20
        '
        Me.Column20.HeaderText = "DEBIT"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Visible = False
        '
        'Column33
        '
        Me.Column33.HeaderText = "VendorId"
        Me.Column33.Name = "Column33"
        Me.Column33.ReadOnly = True
        Me.Column33.Visible = False
        '
        'Column35
        '
        Me.Column35.HeaderText = "ADVANCE"
        Me.Column35.Name = "Column35"
        Me.Column35.ReadOnly = True
        Me.Column35.Visible = False
        '
        'NewBillGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1261, 515)
        Me.Controls.Add(Me.pnlBankList)
        Me.Controls.Add(Me.pnlAlter)
        Me.Controls.Add(Me.pnlExcelExport)
        Me.Controls.Add(Me.pnlBill)
        Me.Controls.Add(Me.pnlTax)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "NewBillGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Generator - New"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTax.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TGTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlter.ResumeLayout(False)
        Me.pnlAlter.PerformLayout()
        Me.pnlRemarks.ResumeLayout(False)
        Me.pnlRemarks.PerformLayout()
        CType(Me.TGEdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBill.ResumeLayout(False)
        CType(Me.TGBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBankList.ResumeLayout(False)
        Me.pnlBankList.PerformLayout()
        CType(Me.TGBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExcelExport.ResumeLayout(False)
        Me.pnlExcelExport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNett As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblBillAmt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlTax As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPerc As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TGTax As System.Windows.Forms.DataGridView
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnATax As System.Windows.Forms.Button
    Friend WithEvents btnAlter As System.Windows.Forms.Button
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlAlter As System.Windows.Forms.Panel
    Friend WithEvents TGEdt As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents cmbVendor2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mebBillDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents mebTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents mebFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDBL As System.Windows.Forms.CheckBox
    Friend WithEvents pnlBill As System.Windows.Forms.Panel
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents TGBill As System.Windows.Forms.DataGridView
    Friend WithEvents btnHide2 As System.Windows.Forms.Button
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstGRN As System.Windows.Forms.ListBox
    Friend WithEvents chkLCDA As System.Windows.Forms.CheckBox
    Friend WithEvents pnlBankList As System.Windows.Forms.Panel
    Friend WithEvents TGBank As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefBankList As System.Windows.Forms.Button
    Friend WithEvents btnAddNewBank As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnHide3 As System.Windows.Forms.Button
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column28 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCashOnly As System.Windows.Forms.Button
    Friend WithEvents btnExcelToExport As System.Windows.Forms.Button
    Friend WithEvents pnlExcelExport As System.Windows.Forms.Panel
    Friend WithEvents btnHide4 As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SaveDiag As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlRemarks As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents lblBillDate As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblVendor As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents dtpCheque As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents lblAdvance As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewButtonColumn
    Friend WithEvents Column14 As DataGridViewButtonColumn
    Friend WithEvents Column22 As DataGridViewButtonColumn
    Friend WithEvents Column34 As DataGridViewButtonColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column33 As DataGridViewTextBoxColumn
    Friend WithEvents Column35 As DataGridViewTextBoxColumn
End Class
