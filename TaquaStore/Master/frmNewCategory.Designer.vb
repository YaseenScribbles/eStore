<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCategory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDept = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.dgvCat1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddCat1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddCat2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvCat2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddCat3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvCat3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_cat = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnHide2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnReloadCat = New System.Windows.Forms.Button()
        Me.btnClearText2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFindCat = New System.Windows.Forms.TextBox()
        Me.TGCat = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlDiag = New System.Windows.Forms.Panel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCatID = New System.Windows.Forms.Label()
        Me.btn_clear_text = New System.Windows.Forms.Label()
        Me.lbl_err = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_hide = New System.Windows.Forms.Button()
        Me.lbl_head = New System.Windows.Forms.Label()
        Me.pnl_head = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCategoryRegister = New System.Windows.Forms.Button()
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCat3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cat.SuspendLayout()
        CType(Me.TGCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDiag.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPARTMENT"
        '
        'dgvDept
        '
        Me.dgvDept.AllowUserToAddRows = False
        Me.dgvDept.AllowUserToDeleteRows = False
        Me.dgvDept.AllowUserToResizeColumns = False
        Me.dgvDept.AllowUserToResizeRows = False
        Me.dgvDept.BackgroundColor = System.Drawing.Color.White
        Me.dgvDept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDept.ColumnHeadersVisible = False
        Me.dgvDept.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDept.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDept.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvDept.Location = New System.Drawing.Point(16, 119)
        Me.dgvDept.MultiSelect = False
        Me.dgvDept.Name = "dgvDept"
        Me.dgvDept.ReadOnly = True
        Me.dgvDept.RowHeadersVisible = False
        Me.dgvDept.RowTemplate.Height = 25
        Me.dgvDept.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDept.Size = New System.Drawing.Size(200, 300)
        Me.dgvDept.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 240
        '
        'btnAddDept
        '
        Me.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDept.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDept.Location = New System.Drawing.Point(166, 85)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(50, 23)
        Me.btnAddDept.TabIndex = 0
        Me.btnAddDept.Text = "Add"
        Me.btnAddDept.UseVisualStyleBackColor = True
        '
        'dgvCat1
        '
        Me.dgvCat1.AllowUserToAddRows = False
        Me.dgvCat1.AllowUserToDeleteRows = False
        Me.dgvCat1.AllowUserToResizeColumns = False
        Me.dgvCat1.AllowUserToResizeRows = False
        Me.dgvCat1.BackgroundColor = System.Drawing.Color.White
        Me.dgvCat1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCat1.ColumnHeadersVisible = False
        Me.dgvCat1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCat1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCat1.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvCat1.Location = New System.Drawing.Point(264, 119)
        Me.dgvCat1.MultiSelect = False
        Me.dgvCat1.Name = "dgvCat1"
        Me.dgvCat1.ReadOnly = True
        Me.dgvCat1.RowHeadersVisible = False
        Me.dgvCat1.RowTemplate.Height = 25
        Me.dgvCat1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCat1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCat1.Size = New System.Drawing.Size(200, 300)
        Me.dgvCat1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 240
        '
        'btnAddCat1
        '
        Me.btnAddCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCat1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat1.ForeColor = System.Drawing.Color.Purple
        Me.btnAddCat1.Location = New System.Drawing.Point(414, 85)
        Me.btnAddCat1.Name = "btnAddCat1"
        Me.btnAddCat1.Size = New System.Drawing.Size(50, 23)
        Me.btnAddCat1.TabIndex = 2
        Me.btnAddCat1.Text = "Add"
        Me.btnAddCat1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(261, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(226, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Æ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(474, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Æ"
        '
        'btnAddCat2
        '
        Me.btnAddCat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCat2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddCat2.Location = New System.Drawing.Point(662, 85)
        Me.btnAddCat2.Name = "btnAddCat2"
        Me.btnAddCat2.Size = New System.Drawing.Size(50, 23)
        Me.btnAddCat2.TabIndex = 4
        Me.btnAddCat2.Text = "Add"
        Me.btnAddCat2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(509, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "STYLE"
        '
        'dgvCat2
        '
        Me.dgvCat2.AllowUserToAddRows = False
        Me.dgvCat2.AllowUserToDeleteRows = False
        Me.dgvCat2.AllowUserToResizeColumns = False
        Me.dgvCat2.AllowUserToResizeRows = False
        Me.dgvCat2.BackgroundColor = System.Drawing.Color.White
        Me.dgvCat2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCat2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCat2.ColumnHeadersVisible = False
        Me.dgvCat2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCat2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCat2.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvCat2.Location = New System.Drawing.Point(512, 119)
        Me.dgvCat2.MultiSelect = False
        Me.dgvCat2.Name = "dgvCat2"
        Me.dgvCat2.ReadOnly = True
        Me.dgvCat2.RowHeadersVisible = False
        Me.dgvCat2.RowTemplate.Height = 25
        Me.dgvCat2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCat2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCat2.Size = New System.Drawing.Size(200, 299)
        Me.dgvCat2.TabIndex = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 240
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Wingdings 3", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(722, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Æ"
        '
        'btnAddCat3
        '
        Me.btnAddCat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCat3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat3.ForeColor = System.Drawing.Color.Green
        Me.btnAddCat3.Location = New System.Drawing.Point(910, 85)
        Me.btnAddCat3.Name = "btnAddCat3"
        Me.btnAddCat3.Size = New System.Drawing.Size(50, 23)
        Me.btnAddCat3.TabIndex = 6
        Me.btnAddCat3.Text = "Add"
        Me.btnAddCat3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(757, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SUB STYLE"
        '
        'dgvCat3
        '
        Me.dgvCat3.AllowUserToAddRows = False
        Me.dgvCat3.AllowUserToDeleteRows = False
        Me.dgvCat3.AllowUserToResizeColumns = False
        Me.dgvCat3.AllowUserToResizeRows = False
        Me.dgvCat3.BackgroundColor = System.Drawing.Color.White
        Me.dgvCat3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCat3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCat3.ColumnHeadersVisible = False
        Me.dgvCat3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCat3.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCat3.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvCat3.Location = New System.Drawing.Point(760, 119)
        Me.dgvCat3.MultiSelect = False
        Me.dgvCat3.Name = "dgvCat3"
        Me.dgvCat3.ReadOnly = True
        Me.dgvCat3.RowHeadersVisible = False
        Me.dgvCat3.RowTemplate.Height = 25
        Me.dgvCat3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCat3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCat3.Size = New System.Drawing.Size(200, 299)
        Me.dgvCat3.TabIndex = 7
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 240
        '
        'pnl_cat
        '
        Me.pnl_cat.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnl_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_cat.Controls.Add(Me.lblStatus)
        Me.pnl_cat.Controls.Add(Me.btnHide2)
        Me.pnl_cat.Controls.Add(Me.Label11)
        Me.pnl_cat.Controls.Add(Me.btnReloadCat)
        Me.pnl_cat.Controls.Add(Me.btnClearText2)
        Me.pnl_cat.Controls.Add(Me.Label10)
        Me.pnl_cat.Controls.Add(Me.txtFindCat)
        Me.pnl_cat.Controls.Add(Me.TGCat)
        Me.pnl_cat.Controls.Add(Me.Label8)
        Me.pnl_cat.Controls.Add(Me.pnlDiag)
        Me.pnl_cat.Location = New System.Drawing.Point(0, 0)
        Me.pnl_cat.Name = "pnl_cat"
        Me.pnl_cat.Size = New System.Drawing.Size(284, 469)
        Me.pnl_cat.TabIndex = 16
        Me.pnl_cat.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(13, 424)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 14)
        Me.lblStatus.TabIndex = 28
        '
        'btnHide2
        '
        Me.btnHide2.BackColor = System.Drawing.Color.Black
        Me.btnHide2.FlatAppearance.BorderSize = 0
        Me.btnHide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide2.ForeColor = System.Drawing.Color.White
        Me.btnHide2.Location = New System.Drawing.Point(249, 0)
        Me.btnHide2.Name = "btnHide2"
        Me.btnHide2.Size = New System.Drawing.Size(36, 26)
        Me.btnHide2.TabIndex = 27
        Me.btnHide2.Text = "r"
        Me.btnHide2.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(282, 26)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "   Category Picker"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReloadCat
        '
        Me.btnReloadCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReloadCat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReloadCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReloadCat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadCat.ForeColor = System.Drawing.Color.Black
        Me.btnReloadCat.Location = New System.Drawing.Point(145, 416)
        Me.btnReloadCat.Name = "btnReloadCat"
        Me.btnReloadCat.Size = New System.Drawing.Size(121, 30)
        Me.btnReloadCat.TabIndex = 2
        Me.btnReloadCat.Text = "&Reload Category"
        Me.btnReloadCat.UseVisualStyleBackColor = False
        '
        'btnClearText2
        '
        Me.btnClearText2.AutoSize = True
        Me.btnClearText2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearText2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearText2.Location = New System.Drawing.Point(209, 62)
        Me.btnClearText2.Name = "btnClearText2"
        Me.btnClearText2.Size = New System.Drawing.Size(57, 13)
        Me.btnClearText2.TabIndex = 23
        Me.btnClearText2.Text = "Clear Text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 14)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Find Category"
        '
        'txtFindCat
        '
        Me.txtFindCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindCat.Location = New System.Drawing.Point(16, 81)
        Me.txtFindCat.Name = "txtFindCat"
        Me.txtFindCat.Size = New System.Drawing.Size(250, 22)
        Me.txtFindCat.TabIndex = 0
        '
        'TGCat
        '
        Me.TGCat.AllowUserToAddRows = False
        Me.TGCat.AllowUserToDeleteRows = False
        Me.TGCat.AllowUserToResizeColumns = False
        Me.TGCat.AllowUserToResizeRows = False
        Me.TGCat.BackgroundColor = System.Drawing.Color.White
        Me.TGCat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TGCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGCat.ColumnHeadersVisible = False
        Me.TGCat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGCat.DefaultCellStyle = DataGridViewCellStyle5
        Me.TGCat.GridColor = System.Drawing.Color.Gainsboro
        Me.TGCat.Location = New System.Drawing.Point(16, 109)
        Me.TGCat.MultiSelect = False
        Me.TGCat.Name = "TGCat"
        Me.TGCat.ReadOnly = True
        Me.TGCat.RowHeadersVisible = False
        Me.TGCat.RowTemplate.Height = 25
        Me.TGCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGCat.Size = New System.Drawing.Size(250, 300)
        Me.TGCat.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 240
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(418, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "DEPARTMENT -> CATEGORY -> STYLE -> SUB STYLE"
        Me.Label8.Visible = False
        '
        'pnlDiag
        '
        Me.pnlDiag.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDiag.Controls.Add(Me.txtName)
        Me.pnlDiag.Controls.Add(Me.lblCatID)
        Me.pnlDiag.Controls.Add(Me.btn_clear_text)
        Me.pnlDiag.Controls.Add(Me.lbl_err)
        Me.pnlDiag.Controls.Add(Me.btn_save)
        Me.pnlDiag.Controls.Add(Me.btn_hide)
        Me.pnlDiag.Controls.Add(Me.lbl_head)
        Me.pnlDiag.Controls.Add(Me.pnl_head)
        Me.pnlDiag.Enabled = False
        Me.pnlDiag.Location = New System.Drawing.Point(352, 170)
        Me.pnlDiag.Name = "pnlDiag"
        Me.pnlDiag.Size = New System.Drawing.Size(381, 174)
        Me.pnlDiag.TabIndex = 17
        Me.pnlDiag.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 22)
        Me.txtName.TabIndex = 10
        '
        'lblCatID
        '
        Me.lblCatID.AutoSize = True
        Me.lblCatID.Location = New System.Drawing.Point(321, 147)
        Me.lblCatID.Name = "lblCatID"
        Me.lblCatID.Size = New System.Drawing.Size(45, 14)
        Me.lblCatID.TabIndex = 9
        Me.lblCatID.Text = "{error}"
        Me.lblCatID.Visible = False
        '
        'btn_clear_text
        '
        Me.btn_clear_text.AutoSize = True
        Me.btn_clear_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_text.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_text.Location = New System.Drawing.Point(313, 48)
        Me.btn_clear_text.Name = "btn_clear_text"
        Me.btn_clear_text.Size = New System.Drawing.Size(57, 13)
        Me.btn_clear_text.TabIndex = 8
        Me.btn_clear_text.Text = "Clear Text"
        '
        'lbl_err
        '
        Me.lbl_err.AutoSize = True
        Me.lbl_err.Location = New System.Drawing.Point(13, 119)
        Me.lbl_err.Name = "lbl_err"
        Me.lbl_err.Size = New System.Drawing.Size(45, 14)
        Me.lbl_err.TabIndex = 7
        Me.lbl_err.Text = "{error}"
        Me.lbl_err.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Purple
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(266, 111)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 30)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "&Update"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_hide
        '
        Me.btn_hide.BackColor = System.Drawing.Color.Purple
        Me.btn_hide.FlatAppearance.BorderSize = 0
        Me.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_hide.ForeColor = System.Drawing.Color.White
        Me.btn_hide.Location = New System.Drawing.Point(345, -1)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(40, 27)
        Me.btn_hide.TabIndex = 2
        Me.btn_hide.Text = "r"
        Me.btn_hide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_hide.UseVisualStyleBackColor = False
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Location = New System.Drawing.Point(13, 47)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(81, 14)
        Me.lbl_head.TabIndex = 6
        Me.lbl_head.Text = "{Input Head}"
        '
        'pnl_head
        '
        Me.pnl_head.BackColor = System.Drawing.Color.Purple
        Me.pnl_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_head.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_head.ForeColor = System.Drawing.Color.White
        Me.pnl_head.Location = New System.Drawing.Point(0, 0)
        Me.pnl_head.Name = "pnl_head"
        Me.pnl_head.Size = New System.Drawing.Size(379, 26)
        Me.pnl_head.TabIndex = 5
        Me.pnl_head.Text = "{Title}"
        Me.pnl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(757, 429)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(42, 14)
        Me.lblD.TabIndex = 17
        Me.lblD.Text = "Label5"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(509, 429)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(42, 14)
        Me.lblC.TabIndex = 18
        Me.lblC.Text = "Label5"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(261, 429)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(42, 14)
        Me.lblB.TabIndex = 19
        Me.lblB.Text = "Label5"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(13, 429)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(42, 14)
        Me.lblA.TabIndex = 20
        Me.lblA.Text = "Label5"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(16, 57)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(948, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 21
        Me.SimpleLine1.UseGradient = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "CATEGORY ASSIGNER"
        '
        'btnCategoryRegister
        '
        Me.btnCategoryRegister.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategoryRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryRegister.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryRegister.Location = New System.Drawing.Point(826, 14)
        Me.btnCategoryRegister.Name = "btnCategoryRegister"
        Me.btnCategoryRegister.Size = New System.Drawing.Size(134, 30)
        Me.btnCategoryRegister.TabIndex = 23
        Me.btnCategoryRegister.Text = "Category Register"
        Me.btnCategoryRegister.UseVisualStyleBackColor = False
        '
        'frmNewCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 469)
        Me.Controls.Add(Me.pnl_cat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddCat3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvCat3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddCat2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvCat2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddCat1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCat1)
        Me.Controls.Add(Me.btnAddDept)
        Me.Controls.Add(Me.dgvDept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnCategoryRegister)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmNewCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Category"
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCat3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cat.ResumeLayout(False)
        Me.pnl_cat.PerformLayout()
        CType(Me.TGCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDiag.ResumeLayout(False)
        Me.pnlDiag.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDept As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddDept As System.Windows.Forms.Button
    Friend WithEvents dgvCat1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddCat1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAddCat2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvCat2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAddCat3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvCat3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_cat As System.Windows.Forms.Panel
    Friend WithEvents pnlDiag As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_hide As System.Windows.Forms.Button
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents pnl_head As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_err As System.Windows.Forms.Label
    Friend WithEvents btn_clear_text As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCategoryRegister As System.Windows.Forms.Button
    Friend WithEvents TGCat As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFindCat As System.Windows.Forms.TextBox
    Friend WithEvents btnReloadCat As System.Windows.Forms.Button
    Friend WithEvents btnClearText2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCatID As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnHide2 As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
