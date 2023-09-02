<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CodeReaderAdvOld
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCA = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMacID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPattern = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMts = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Label()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.lblCatTree = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSleeve = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbCatalog = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbIsStich = New System.Windows.Forms.ComboBox()
        Me.btnEntryViewer = New System.Windows.Forms.Button()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlList.SuspendLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Code Here"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(12, 36)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(280, 22)
        Me.txtCode.TabIndex = 0
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.TG.Location = New System.Drawing.Point(12, 64)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersVisible = False
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(278, 385)
        Me.TG.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "PluID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sno"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "Code"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Text = "r"
        Me.Column4.UseColumnTextForButtonValue = True
        Me.Column4.Width = 30
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 25
        '
        'btnCA
        '
        Me.btnCA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCA.Location = New System.Drawing.Point(218, 456)
        Me.btnCA.Name = "btnCA"
        Me.btnCA.Size = New System.Drawing.Size(72, 23)
        Me.btnCA.TabIndex = 14
        Me.btnCA.Text = "&Clear All"
        Me.btnCA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 461)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mac ID :"
        '
        'lblMacID
        '
        Me.lblMacID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMacID.ForeColor = System.Drawing.Color.Navy
        Me.lblMacID.Location = New System.Drawing.Point(56, 461)
        Me.lblMacID.Name = "lblMacID"
        Me.lblMacID.Size = New System.Drawing.Size(80, 13)
        Me.lblMacID.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(669, 244)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 38)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department"
        '
        'cmbDept
        '
        Me.cmbDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDept.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(319, 61)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(317, 22)
        Me.cmbDept.TabIndex = 2
        '
        'cmbCat
        '
        Me.cmbCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(319, 122)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(317, 22)
        Me.cmbCat.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Category"
        '
        'cmbStyle
        '
        Me.cmbStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Location = New System.Drawing.Point(319, 183)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(317, 22)
        Me.cmbStyle.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Style"
        '
        'cmbPattern
        '
        Me.cmbPattern.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPattern.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPattern.FormattingEnabled = True
        Me.cmbPattern.Location = New System.Drawing.Point(319, 244)
        Me.cmbPattern.Name = "cmbPattern"
        Me.cmbPattern.Size = New System.Drawing.Size(317, 22)
        Me.cmbPattern.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pattern"
        '
        'cmbMts
        '
        Me.cmbMts.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbMts.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMts.FormattingEnabled = True
        Me.cmbMts.Location = New System.Drawing.Point(319, 305)
        Me.cmbMts.Name = "cmbMts"
        Me.cmbMts.Size = New System.Drawing.Size(317, 22)
        Me.cmbMts.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Material"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "CATGORY INFO"
        '
        'btnReload
        '
        Me.btnReload.AutoSize = True
        Me.btnReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReload.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReload.Location = New System.Drawing.Point(868, 17)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(118, 13)
        Me.btnReload.TabIndex = 16
        Me.btnReload.Text = "Reload Department"
        '
        'pnlList
        '
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.lblCatTree)
        Me.pnlList.Controls.Add(Me.Label10)
        Me.pnlList.Controls.Add(Me.btnClose)
        Me.pnlList.Controls.Add(Me.TGLst)
        Me.pnlList.Controls.Add(Me.Label9)
        Me.pnlList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlList.Location = New System.Drawing.Point(-1000, 51)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(602, 387)
        Me.pnlList.TabIndex = 17
        Me.pnlList.Tag = ""
        Me.pnlList.Visible = False
        '
        'lblCatTree
        '
        Me.lblCatTree.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatTree.ForeColor = System.Drawing.Color.Blue
        Me.lblCatTree.Location = New System.Drawing.Point(75, 338)
        Me.lblCatTree.Name = "lblCatTree"
        Me.lblCatTree.Size = New System.Drawing.Size(518, 40)
        Me.lblCatTree.TabIndex = 4
        Me.lblCatTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Category :"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(554, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column8, Me.Column9, Me.Column10, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21})
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.Location = New System.Drawing.Point(7, 34)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGLst.Size = New System.Drawing.Size(586, 301)
        Me.TGLst.TabIndex = 1
        '
        'Column6
        '
        Me.Column6.HeaderText = "E.No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'Column11
        '
        Me.Column11.HeaderText = "Department"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Category"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Sub Category"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Sub Category - 2"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "Sub Category - 3"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'Column16
        '
        Me.Column16.HeaderText = "Sub Category - 4"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Quantity"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = ""
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Text = "View"
        Me.Column9.UseColumnTextForButtonValue = True
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 23
        '
        'Column17
        '
        Me.Column17.HeaderText = "DeptID"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Visible = False
        '
        'Column18
        '
        Me.Column18.HeaderText = "CatID"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Visible = False
        '
        'Column19
        '
        Me.Column19.HeaderText = "SCatID1"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Visible = False
        '
        'Column20
        '
        Me.Column20.HeaderText = "SCatID2"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Visible = False
        '
        'Column21
        '
        Me.Column21.HeaderText = "SCatID3"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "List of Entries"
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.Red
        Me.lblEdit.Location = New System.Drawing.Point(705, 360)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(248, 25)
        Me.lblEdit.TabIndex = 19
        Me.lblEdit.Text = "Currently In Edit Mode"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEdit.Visible = False
        '
        'cmbColor
        '
        Me.cmbColor.BackColor = System.Drawing.Color.Khaki
        Me.cmbColor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(319, 366)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(317, 22)
        Me.cmbColor.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Colors"
        '
        'cmbSleeve
        '
        Me.cmbSleeve.BackColor = System.Drawing.Color.Thistle
        Me.cmbSleeve.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSleeve.FormattingEnabled = True
        Me.cmbSleeve.Location = New System.Drawing.Point(319, 427)
        Me.cmbSleeve.Name = "cmbSleeve"
        Me.cmbSleeve.Size = New System.Drawing.Size(317, 22)
        Me.cmbSleeve.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 409)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 14)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Sleeve"
        '
        'cmbBrand
        '
        Me.cmbBrand.BackColor = System.Drawing.Color.Lavender
        Me.cmbBrand.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(669, 61)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(317, 22)
        Me.cmbBrand.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(666, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 14)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Brand"
        '
        'cmbCatalog
        '
        Me.cmbCatalog.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmbCatalog.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCatalog.FormattingEnabled = True
        Me.cmbCatalog.Location = New System.Drawing.Point(669, 122)
        Me.cmbCatalog.Name = "cmbCatalog"
        Me.cmbCatalog.Size = New System.Drawing.Size(317, 22)
        Me.cmbCatalog.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(666, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 14)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Catalog"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(666, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Stitched ?"
        '
        'cmbIsStich
        '
        Me.cmbIsStich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsStich.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIsStich.FormattingEnabled = True
        Me.cmbIsStich.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbIsStich.Location = New System.Drawing.Point(669, 183)
        Me.cmbIsStich.Name = "cmbIsStich"
        Me.cmbIsStich.Size = New System.Drawing.Size(95, 22)
        Me.cmbIsStich.TabIndex = 11
        '
        'btnEntryViewer
        '
        Me.btnEntryViewer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntryViewer.Location = New System.Drawing.Point(834, 244)
        Me.btnEntryViewer.Name = "btnEntryViewer"
        Me.btnEntryViewer.Size = New System.Drawing.Size(152, 38)
        Me.btnEntryViewer.TabIndex = 31
        Me.btnEntryViewer.Text = "Entry Viewer"
        Me.btnEntryViewer.UseVisualStyleBackColor = True
        '
        'CodeReaderAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 489)
        Me.Controls.Add(Me.btnEntryViewer)
        Me.Controls.Add(Me.cmbIsStich)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbCatalog)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbBrand)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbSleeve)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbMts)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPattern)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbStyle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblMacID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCA)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "CodeReaderAdv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Reader"
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCA As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMacID As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPattern As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbMts As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnReload As System.Windows.Forms.Label
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TGLst As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCatTree As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEdit As System.Windows.Forms.Label
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbSleeve As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbCatalog As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbIsStich As ComboBox
    Friend WithEvents btnEntryViewer As Button
End Class
