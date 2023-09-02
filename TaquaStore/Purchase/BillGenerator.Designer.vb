<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillGenerator
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAlter = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.mebTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mebFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblBillDt = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblGrandTot = New System.Windows.Forms.Label()
        Me.lblDebit = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSubTot = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAlter = New System.Windows.Forms.Panel()
        Me.TGEdt = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cmbVendor2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlter.SuspendLayout()
        CType(Me.TGEdt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Size = New System.Drawing.Size(879, 39)
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
        Me.Label22.Size = New System.Drawing.Size(234, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Payment Bill Generator"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(809, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAlter)
        Me.Panel4.Controls.Add(Me.btnUpdate)
        Me.Panel4.Controls.Add(Me.btnDisplay)
        Me.Panel4.Controls.Add(Me.mebTo)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.mebFrom)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmbVendor)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(879, 93)
        Me.Panel4.TabIndex = 0
        '
        'btnAlter
        '
        Me.btnAlter.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAlter.FlatAppearance.BorderSize = 0
        Me.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlter.ForeColor = System.Drawing.Color.White
        Me.btnAlter.Location = New System.Drawing.Point(651, 47)
        Me.btnAlter.Name = "btnAlter"
        Me.btnAlter.Size = New System.Drawing.Size(96, 31)
        Me.btnAlter.TabIndex = 4
        Me.btnAlter.Text = "ALTER"
        Me.btnAlter.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(753, 47)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 31)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderSize = 0
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(549, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 31)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
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
        Me.Label3.TabIndex = 35
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "FROM"
        '
        'cmbVendor
        '
        Me.cmbVendor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(245, 55)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(285, 23)
        Me.cmbVendor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "VENDORS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(546, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "OPTIONS"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(9, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "DURATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VENDOR"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 391)
        Me.Panel2.TabIndex = 6
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.White
        Me.pnlFooter.Controls.Add(Me.lblBillDt)
        Me.pnlFooter.Controls.Add(Me.lblBillNo)
        Me.pnlFooter.Controls.Add(Me.Label10)
        Me.pnlFooter.Controls.Add(Me.Label9)
        Me.pnlFooter.Controls.Add(Me.lblGrandTot)
        Me.pnlFooter.Controls.Add(Me.lblDebit)
        Me.pnlFooter.Controls.Add(Me.Label8)
        Me.pnlFooter.Controls.Add(Me.Label7)
        Me.pnlFooter.Controls.Add(Me.lblSubTot)
        Me.pnlFooter.Controls.Add(Me.Label6)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(10, 403)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(869, 120)
        Me.pnlFooter.TabIndex = 7
        '
        'lblBillDt
        '
        Me.lblBillDt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBillDt.Location = New System.Drawing.Point(110, 38)
        Me.lblBillDt.Name = "lblBillDt"
        Me.lblBillDt.Size = New System.Drawing.Size(105, 30)
        Me.lblBillDt.TabIndex = 4
        Me.lblBillDt.Text = "BILL NO      :"
        Me.lblBillDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBillNo
        '
        Me.lblBillNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBillNo.Location = New System.Drawing.Point(110, 7)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(105, 30)
        Me.lblBillNo.TabIndex = 4
        Me.lblBillNo.Text = "BILL NO      :"
        Me.lblBillNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 30)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "BILL DATE  :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 30)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "BILL NO      :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrandTot
        '
        Me.lblGrandTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGrandTot.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTot.Location = New System.Drawing.Point(691, 69)
        Me.lblGrandTot.Name = "lblGrandTot"
        Me.lblGrandTot.Size = New System.Drawing.Size(148, 30)
        Me.lblGrandTot.TabIndex = 2
        Me.lblGrandTot.Text = "0.00"
        Me.lblGrandTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDebit
        '
        Me.lblDebit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDebit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.Location = New System.Drawing.Point(691, 38)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(148, 30)
        Me.lblDebit.TabIndex = 1
        Me.lblDebit.Text = "0.00"
        Me.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(472, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 30)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "GRAND TOTAL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DEBIT (-)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTot
        '
        Me.lblSubTot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSubTot.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTot.Location = New System.Drawing.Point(691, 7)
        Me.lblSubTot.Name = "lblSubTot"
        Me.lblSubTot.Size = New System.Drawing.Size(148, 30)
        Me.lblSubTot.TabIndex = 0
        Me.lblSubTot.Text = "0.00"
        Me.lblSubTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(472, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 30)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SUB TOTAL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column16, Me.Column17, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle3
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(10, 132)
        Me.TG.MultiSelect = False
        Me.TG.Name = "TG"
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TG.Size = New System.Drawing.Size(869, 271)
        Me.TG.TabIndex = 1
        Me.TG.Tag = "1"
        '
        'Column1
        '
        Me.Column1.HeaderText = "G.R.N No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "INV.NO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "INV.DATE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column16
        '
        Me.Column16.HeaderText = "REF.NO"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 60
        '
        'Column17
        '
        Me.Column17.HeaderText = "REF.DATE"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "VENDOR NAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "DEBIT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "NET AMT"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'pnlAlter
        '
        Me.pnlAlter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAlter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAlter.Controls.Add(Me.TGEdt)
        Me.pnlAlter.Controls.Add(Me.btnHide)
        Me.pnlAlter.Controls.Add(Me.btnFilter)
        Me.pnlAlter.Controls.Add(Me.cmbVendor2)
        Me.pnlAlter.Controls.Add(Me.Label12)
        Me.pnlAlter.Controls.Add(Me.Label11)
        Me.pnlAlter.Location = New System.Drawing.Point(175, 120)
        Me.pnlAlter.Name = "pnlAlter"
        Me.pnlAlter.Size = New System.Drawing.Size(573, 301)
        Me.pnlAlter.TabIndex = 8
        Me.pnlAlter.Visible = False
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
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGEdt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TGEdt.ColumnHeadersHeight = 30
        Me.TGEdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGEdt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column18, Me.Column19, Me.Column20})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.TGEdt.Size = New System.Drawing.Size(571, 245)
        Me.TGEdt.TabIndex = 5
        Me.TGEdt.Tag = "1"
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
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(529, 25)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(39, 23)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(339, 25)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(184, 23)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbVendor2
        '
        Me.cmbVendor2.BackColor = System.Drawing.Color.White
        Me.cmbVendor2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor2.FormattingEnabled = True
        Me.cmbVendor2.Location = New System.Drawing.Point(6, 25)
        Me.cmbVendor2.Name = "cmbVendor2"
        Me.cmbVendor2.Size = New System.Drawing.Size(327, 23)
        Me.cmbVendor2.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(336, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "OPTIONS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "VENDOR"
        '
        'BillGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 523)
        Me.Controls.Add(Me.pnlAlter)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BillGenerator"
        Me.Tag = "34"
        Me.Text = "Bill Generator"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlter.ResumeLayout(False)
        Me.pnlAlter.PerformLayout()
        CType(Me.TGEdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents mebTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mebFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnAlter As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTot As System.Windows.Forms.Label
    Friend WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents lblSubTot As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBillDt As System.Windows.Forms.Label
    Friend WithEvents lblBillNo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlAlter As System.Windows.Forms.Panel
    Friend WithEvents TGEdt As System.Windows.Forms.DataGridView
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents cmbVendor2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
