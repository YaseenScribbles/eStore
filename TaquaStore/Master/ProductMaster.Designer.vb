<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductMaster
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.cmbTaxable = New System.Windows.Forms.ComboBox()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWholeSale = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMRP = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRack = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.pnlSide = New System.Windows.Forms.TableLayoutPanel()
        Me.TV2 = New System.Windows.Forms.TreeView()
        Me.TGProd = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbPrintName = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbHSN = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.chkUTax = New System.Windows.Forms.CheckBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSide.SuspendLayout()
        CType(Me.TGProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnReset, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(816, 39)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(540, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save (F2)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(633, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 33)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset (F5)"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(726, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 33)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "4"
        Me.btnClose.Text = "Close (Esc)"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(169, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = " Product Master"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Product Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Plucode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Product Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cost Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Units"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Vendor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Tax Type"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(12, 107)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 22)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "1"
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(118, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(206, 22)
        Me.txtName.TabIndex = 1
        '
        'cmbUnits
        '
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Location = New System.Drawing.Point(330, 107)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(100, 21)
        Me.cmbUnits.TabIndex = 2
        '
        'cmbVendor
        '
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(12, 198)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(312, 21)
        Me.cmbVendor.TabIndex = 4
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(12, 151)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(370, 22)
        Me.txtCat.TabIndex = 3
        '
        'cmbTaxable
        '
        Me.cmbTaxable.FormattingEnabled = True
        Me.cmbTaxable.Items.AddRange(New Object() {"Taxable", "Non-Taxable"})
        Me.cmbTaxable.Location = New System.Drawing.Point(330, 198)
        Me.cmbTaxable.Name = "cmbTaxable"
        Me.cmbTaxable.Size = New System.Drawing.Size(100, 21)
        Me.cmbTaxable.TabIndex = 5
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(12, 247)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtCostPrice.TabIndex = 6
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(118, 247)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(100, 22)
        Me.txtRetail.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Retail Price"
        '
        'txtWholeSale
        '
        Me.txtWholeSale.Location = New System.Drawing.Point(224, 247)
        Me.txtWholeSale.Name = "txtWholeSale"
        Me.txtWholeSale.Size = New System.Drawing.Size(100, 22)
        Me.txtWholeSale.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "MRP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(221, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Wholesale"
        '
        'txtMRP
        '
        Me.txtMRP.Location = New System.Drawing.Point(330, 247)
        Me.txtMRP.Name = "txtMRP"
        Me.txtMRP.Size = New System.Drawing.Size(100, 22)
        Me.txtMRP.TabIndex = 9
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(12, 298)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscount.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 282)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(118, 298)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 22)
        Me.txtSize.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(221, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(224, 298)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(381, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Rack No"
        Me.Label16.Visible = False
        '
        'txtRack
        '
        Me.txtRack.Location = New System.Drawing.Point(384, 66)
        Me.txtRack.Name = "txtRack"
        Me.txtRack.Size = New System.Drawing.Size(46, 22)
        Me.txtRack.TabIndex = 13
        Me.txtRack.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(4, 381)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 21)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Product Batch"
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeight = 25
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle3
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.WhiteSmoke
        Me.TG.Location = New System.Drawing.Point(12, 416)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 25
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(202, 141)
        Me.TG.TabIndex = 17
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSide.ColumnCount = 2
        Me.pnlSide.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlSide.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.pnlSide.Controls.Add(Me.TV2, 1, 1)
        Me.pnlSide.Controls.Add(Me.TGProd, 0, 1)
        Me.pnlSide.Controls.Add(Me.Label18, 0, 0)
        Me.pnlSide.Controls.Add(Me.Label19, 1, 0)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSide.Location = New System.Drawing.Point(475, 39)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.RowCount = 2
        Me.pnlSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.793456!))
        Me.pnlSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.20654!))
        Me.pnlSide.Size = New System.Drawing.Size(341, 655)
        Me.pnlSide.TabIndex = 17
        '
        'TV2
        '
        Me.TV2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV2.FullRowSelect = True
        Me.TV2.Indent = 30
        Me.TV2.ItemHeight = 30
        Me.TV2.Location = New System.Drawing.Point(344, 60)
        Me.TV2.Name = "TV2"
        Me.TV2.PathSeparator = "->"
        Me.TV2.ShowLines = False
        Me.TV2.Size = New System.Drawing.Size(1, 592)
        Me.TV2.TabIndex = 58
        '
        'TGProd
        '
        Me.TGProd.AllowUserToAddRows = False
        Me.TGProd.AllowUserToDeleteRows = False
        Me.TGProd.AllowUserToResizeColumns = False
        Me.TGProd.AllowUserToResizeRows = False
        Me.TGProd.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TGProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TGProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TGProd.ColumnHeadersHeight = 25
        Me.TGProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGProd.DefaultCellStyle = DataGridViewCellStyle5
        Me.TGProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TGProd.EnableHeadersVisualStyles = False
        Me.TGProd.GridColor = System.Drawing.Color.Gainsboro
        Me.TGProd.Location = New System.Drawing.Point(3, 60)
        Me.TGProd.MultiSelect = False
        Me.TGProd.Name = "TGProd"
        Me.TGProd.ReadOnly = True
        Me.TGProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGProd.RowHeadersVisible = False
        Me.TGProd.RowTemplate.Height = 25
        Me.TGProd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TGProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGProd.Size = New System.Drawing.Size(335, 592)
        Me.TGProd.TabIndex = 57
        Me.TGProd.Tag = "1"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(3, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 21)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "  List of Products"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(344, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(1, 21)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Pick Category"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(474, 39)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(1, 655)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Vertical
        Me.SimpleLine1.TabIndex = 56
        Me.SimpleLine1.UseGradient = False
        '
        'btnPick
        '
        Me.btnPick.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPick.FlatAppearance.BorderSize = 0
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.ForeColor = System.Drawing.Color.White
        Me.btnPick.Location = New System.Drawing.Point(388, 151)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(42, 22)
        Me.btnPick.TabIndex = 16
        Me.btnPick.Text = "Pick"
        Me.btnPick.UseVisualStyleBackColor = False
        '
        'TTip
        '
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error..!"
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(330, 299)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(100, 21)
        Me.cmbColor.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(327, 283)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Color"
        '
        'cmbPrintName
        '
        Me.cmbPrintName.FormattingEnabled = True
        Me.cmbPrintName.Location = New System.Drawing.Point(12, 344)
        Me.cmbPrintName.Name = "cmbPrintName"
        Me.cmbPrintName.Size = New System.Drawing.Size(206, 21)
        Me.cmbPrintName.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 328)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Printable Name"
        '
        'cmbHSN
        '
        Me.cmbHSN.FormattingEnabled = True
        Me.cmbHSN.Location = New System.Drawing.Point(224, 344)
        Me.cmbHSN.Name = "cmbHSN"
        Me.cmbHSN.Size = New System.Drawing.Size(100, 21)
        Me.cmbHSN.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(221, 328)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "HSN Code"
        '
        'chkUTax
        '
        Me.chkUTax.AutoSize = True
        Me.chkUTax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chkUTax.Location = New System.Drawing.Point(330, 345)
        Me.chkUTax.Name = "chkUTax"
        Me.chkUTax.Size = New System.Drawing.Size(88, 19)
        Me.chkUTax.TabIndex = 16
        Me.chkUTax.Text = "Unique Tax"
        Me.chkUTax.UseVisualStyleBackColor = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PLUID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "BATCH NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "RATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "ORATE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'ProductMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(816, 694)
        Me.Controls.Add(Me.chkUTax)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmbHSN)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmbPrintName)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtRack)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMRP)
        Me.Controls.Add(Me.txtWholeSale)
        Me.Controls.Add(Me.txtRetail)
        Me.Controls.Add(Me.txtCostPrice)
        Me.Controls.Add(Me.cmbTaxable)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.cmbVendor)
        Me.Controls.Add(Me.cmbUnits)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ProductMaster"
        Me.Tag = "25"
        Me.Text = "ProductMaster"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSide.ResumeLayout(False)
        Me.pnlSide.PerformLayout()
        CType(Me.TGProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents cmbTaxable As System.Windows.Forms.ComboBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRetail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWholeSale As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMRP As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRack As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSide As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TGProd As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TV2 As System.Windows.Forms.TreeView
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbPrintName As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbHSN As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkUTax As System.Windows.Forms.CheckBox
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
