<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodeConvertor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tgLst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLocations = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.tgTmp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlLoading = New System.Windows.Forms.Label()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnHideMe = New System.Windows.Forms.Button()
        Me.btnPrinting = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tgView = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLoadTemp = New System.Windows.Forms.Label()
        CType(Me.tgLst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgTmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlView.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        CType(Me.tgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(12, 32)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(94, 23)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "1"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(112, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(180, 23)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(298, 32)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(94, 23)
        Me.txtQty.TabIndex = 2
        Me.txtQty.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity"
        '
        'tgLst
        '
        Me.tgLst.AllowUserToAddRows = False
        Me.tgLst.AllowUserToDeleteRows = False
        Me.tgLst.AllowUserToResizeColumns = False
        Me.tgLst.AllowUserToResizeRows = False
        Me.tgLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tgLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column14, Me.Column5, Me.Column6})
        Me.tgLst.EnableHeadersVisualStyles = False
        Me.tgLst.Location = New System.Drawing.Point(12, 64)
        Me.tgLst.Name = "tgLst"
        Me.tgLst.ReadOnly = True
        Me.tgLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgLst.RowHeadersVisible = False
        Me.tgLst.RowTemplate.Height = 23
        Me.tgLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tgLst.Size = New System.Drawing.Size(580, 345)
        Me.tgLst.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 187
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Rate"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Text = "r"
        Me.Column5.UseColumnTextForButtonValue = True
        Me.Column5.Width = 40
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 55
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(398, 32)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(94, 23)
        Me.txtRate.TabIndex = 3
        Me.txtRate.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(395, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rate"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(386, 429)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Location"
        '
        'cmbLocations
        '
        Me.cmbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocations.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocations.FormattingEnabled = True
        Me.cmbLocations.Location = New System.Drawing.Point(12, 437)
        Me.cmbLocations.Name = "cmbLocations"
        Me.cmbLocations.Size = New System.Drawing.Size(252, 22)
        Me.cmbLocations.TabIndex = 7
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(492, 429)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 30)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'tgTmp
        '
        Me.tgTmp.AllowUserToAddRows = False
        Me.tgTmp.AllowUserToDeleteRows = False
        Me.tgTmp.AllowUserToResizeColumns = False
        Me.tgTmp.AllowUserToResizeRows = False
        Me.tgTmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgTmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tgTmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column15, Me.Column17})
        Me.tgTmp.EnableHeadersVisualStyles = False
        Me.tgTmp.Location = New System.Drawing.Point(189, 151)
        Me.tgTmp.Name = "tgTmp"
        Me.tgTmp.ReadOnly = True
        Me.tgTmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgTmp.RowHeadersVisible = False
        Me.tgTmp.RowTemplate.Height = 23
        Me.tgTmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tgTmp.Size = New System.Drawing.Size(403, 258)
        Me.tgTmp.TabIndex = 6
        Me.tgTmp.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "New Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Rate"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "Code"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Visible = False
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pnlLoading.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlLoading.ForeColor = System.Drawing.Color.Maroon
        Me.pnlLoading.Location = New System.Drawing.Point(127, 211)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(250, 50)
        Me.pnlLoading.TabIndex = 11
        Me.pnlLoading.Text = "Generating Data, Please Wait..!"
        Me.pnlLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnlLoading.Visible = False
        '
        'pnlView
        '
        Me.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlView.Controls.Add(Me.pnlOptions)
        Me.pnlView.Controls.Add(Me.btnHide)
        Me.pnlView.Controls.Add(Me.Label6)
        Me.pnlView.Controls.Add(Me.tgView)
        Me.pnlView.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlView.Location = New System.Drawing.Point(80, 85)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(444, 303)
        Me.pnlView.TabIndex = 10
        Me.pnlView.Visible = False
        '
        'pnlOptions
        '
        Me.pnlOptions.BackColor = System.Drawing.Color.White
        Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOptions.Controls.Add(Me.btnHideMe)
        Me.pnlOptions.Controls.Add(Me.btnPrinting)
        Me.pnlOptions.Controls.Add(Me.btnDelivery)
        Me.pnlOptions.Controls.Add(Me.Label7)
        Me.pnlOptions.Location = New System.Drawing.Point(126, 79)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(190, 183)
        Me.pnlOptions.TabIndex = 1
        Me.pnlOptions.Visible = False
        '
        'btnHideMe
        '
        Me.btnHideMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideMe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHideMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHideMe.Location = New System.Drawing.Point(19, 125)
        Me.btnHideMe.Name = "btnHideMe"
        Me.btnHideMe.Size = New System.Drawing.Size(150, 40)
        Me.btnHideMe.TabIndex = 2
        Me.btnHideMe.Text = "&Hide Me"
        Me.btnHideMe.UseVisualStyleBackColor = True
        '
        'btnPrinting
        '
        Me.btnPrinting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrinting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrinting.Location = New System.Drawing.Point(19, 79)
        Me.btnPrinting.Name = "btnPrinting"
        Me.btnPrinting.Size = New System.Drawing.Size(150, 40)
        Me.btnPrinting.TabIndex = 1
        Me.btnPrinting.Text = "&Lable Printing"
        Me.btnPrinting.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelivery.Location = New System.Drawing.Point(19, 33)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(150, 40)
        Me.btnDelivery.TabIndex = 0
        Me.btnDelivery.Text = "&Send To Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Options"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Silver
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.Location = New System.Drawing.Point(409, -7)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(30, 30)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Text = "r"
        Me.btnHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "List of Deliveries"
        '
        'tgView
        '
        Me.tgView.AllowUserToAddRows = False
        Me.tgView.AllowUserToDeleteRows = False
        Me.tgView.AllowUserToResizeColumns = False
        Me.tgView.AllowUserToResizeRows = False
        Me.tgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column16})
        Me.tgView.EnableHeadersVisualStyles = False
        Me.tgView.Location = New System.Drawing.Point(3, 29)
        Me.tgView.Name = "tgView"
        Me.tgView.ReadOnly = True
        Me.tgView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tgView.RowHeadersVisible = False
        Me.tgView.RowTemplate.Height = 23
        Me.tgView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tgView.Size = New System.Drawing.Size(436, 269)
        Me.tgView.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "ENo"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Date"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = "Location"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Quantity"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 60
        '
        'Column11
        '
        Me.Column11.HeaderText = "Status"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 60
        '
        'Column12
        '
        Me.Column12.HeaderText = ""
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Text = "Options"
        Me.Column12.UseColumnTextForButtonValue = True
        Me.Column12.Width = 70
        '
        'Column13
        '
        Me.Column13.HeaderText = ""
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 23
        '
        'Column16
        '
        Me.Column16.HeaderText = "LocId"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Visible = False
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.SystemColors.Window
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(498, 32)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(94, 23)
        Me.txtStock.TabIndex = 4
        Me.txtStock.Tag = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(495, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Stock"
        '
        'btnLoadTemp
        '
        Me.btnLoadTemp.AutoSize = True
        Me.btnLoadTemp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadTemp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadTemp.ForeColor = System.Drawing.Color.Navy
        Me.btnLoadTemp.Location = New System.Drawing.Point(295, 436)
        Me.btnLoadTemp.Name = "btnLoadTemp"
        Me.btnLoadTemp.Size = New System.Drawing.Size(78, 16)
        Me.btnLoadTemp.TabIndex = 17
        Me.btnLoadTemp.Text = "Load Entry"
        '
        'frmCodeConvertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 473)
        Me.Controls.Add(Me.btnLoadTemp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.tgTmp)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cmbLocations)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.tgLst)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCodeConvertor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Convertor"
        CType(Me.tgLst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgTmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlView.ResumeLayout(False)
        Me.pnlView.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        CType(Me.tgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tgLst As DataGridView
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbLocations As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents tgTmp As DataGridView
    Friend WithEvents pnlLoading As Label
    Friend WithEvents pnlView As Panel
    Friend WithEvents tgView As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnHideMe As Button
    Friend WithEvents btnPrinting As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewButtonColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents btnLoadTemp As Label
End Class
