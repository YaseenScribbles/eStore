<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vendors2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.pnlBankDetails = New System.Windows.Forms.Panel()
        Me.btnHide2 = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.txtIFSC = New System.Windows.Forms.TextBox()
        Me.txtACName = New System.Windows.Forms.TextBox()
        Me.txtACNo = New System.Windows.Forms.TextBox()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.txtCLimit = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbDR = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtOBal = New System.Windows.Forms.TextBox()
        Me.txtPAN = New System.Windows.Forms.TextBox()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.txtCST = New System.Windows.Forms.TextBox()
        Me.txtTIN = New System.Windows.Forms.TextBox()
        Me.txtWhatApp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtCPerson = New System.Windows.Forms.TextBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.cmbVGroup = New System.Windows.Forms.ComboBox()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.txtVCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlList.SuspendLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBankDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.SystemColors.Control
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.Label27)
        Me.pnlList.Controls.Add(Me.txtFind)
        Me.pnlList.Controls.Add(Me.TGLst)
        Me.pnlList.Controls.Add(Me.btnHide)
        Me.pnlList.Controls.Add(Me.Label26)
        Me.pnlList.Location = New System.Drawing.Point(51, 47)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(404, 417)
        Me.pnlList.TabIndex = 82
        Me.pnlList.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 16)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Find Vendors"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.ForeColor = System.Drawing.Color.White
        Me.txtFind.Location = New System.Drawing.Point(10, 52)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(383, 23)
        Me.txtFind.TabIndex = 0
        Me.txtFind.Tag = "1"
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TGLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGLst.DefaultCellStyle = DataGridViewCellStyle2
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.Location = New System.Drawing.Point(10, 82)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.RowTemplate.Height = 23
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGLst.Size = New System.Drawing.Size(383, 321)
        Me.TGLst.TabIndex = 1
        Me.TGLst.Tag = "1"
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
        Me.Column2.HeaderText = "Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Vendor Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 20
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(368, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(35, 25)
        Me.btnHide.TabIndex = 46
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        Me.btnHide.Visible = False
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Orange
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(402, 25)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "  List of Vendors"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBankDetails
        '
        Me.pnlBankDetails.BackColor = System.Drawing.Color.Silver
        Me.pnlBankDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBankDetails.Controls.Add(Me.btnHide2)
        Me.pnlBankDetails.Controls.Add(Me.btnDone)
        Me.pnlBankDetails.Controls.Add(Me.txtBranch)
        Me.pnlBankDetails.Controls.Add(Me.txtIFSC)
        Me.pnlBankDetails.Controls.Add(Me.txtACName)
        Me.pnlBankDetails.Controls.Add(Me.txtACNo)
        Me.pnlBankDetails.Controls.Add(Me.cmbBank)
        Me.pnlBankDetails.Controls.Add(Me.Label33)
        Me.pnlBankDetails.Controls.Add(Me.Label32)
        Me.pnlBankDetails.Controls.Add(Me.Label31)
        Me.pnlBankDetails.Controls.Add(Me.Label30)
        Me.pnlBankDetails.Controls.Add(Me.Label28)
        Me.pnlBankDetails.Controls.Add(Me.Label29)
        Me.pnlBankDetails.Location = New System.Drawing.Point(20, 134)
        Me.pnlBankDetails.Name = "pnlBankDetails"
        Me.pnlBankDetails.Size = New System.Drawing.Size(467, 275)
        Me.pnlBankDetails.TabIndex = 100
        Me.pnlBankDetails.Tag = "467, 279"
        Me.pnlBankDetails.Visible = False
        '
        'btnHide2
        '
        Me.btnHide2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHide2.FlatAppearance.BorderSize = 0
        Me.btnHide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide2.Font = New System.Drawing.Font("Webdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide2.ForeColor = System.Drawing.Color.White
        Me.btnHide2.Location = New System.Drawing.Point(431, 0)
        Me.btnHide2.Name = "btnHide2"
        Me.btnHide2.Size = New System.Drawing.Size(35, 25)
        Me.btnHide2.TabIndex = 54
        Me.btnHide2.Text = "r"
        Me.btnHide2.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(294, 226)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(152, 30)
        Me.btnDone.TabIndex = 53
        Me.btnDone.Text = "F2 : &Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'txtBranch
        '
        Me.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Location = New System.Drawing.Point(121, 181)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(325, 23)
        Me.txtBranch.TabIndex = 51
        '
        'txtIFSC
        '
        Me.txtIFSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIFSC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIFSC.Location = New System.Drawing.Point(121, 146)
        Me.txtIFSC.Name = "txtIFSC"
        Me.txtIFSC.Size = New System.Drawing.Size(325, 23)
        Me.txtIFSC.TabIndex = 50
        '
        'txtACName
        '
        Me.txtACName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACName.Location = New System.Drawing.Point(121, 111)
        Me.txtACName.Name = "txtACName"
        Me.txtACName.Size = New System.Drawing.Size(325, 23)
        Me.txtACName.TabIndex = 49
        '
        'txtACNo
        '
        Me.txtACNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACNo.Location = New System.Drawing.Point(121, 76)
        Me.txtACNo.Name = "txtACNo"
        Me.txtACNo.Size = New System.Drawing.Size(325, 23)
        Me.txtACNo.TabIndex = 48
        '
        'cmbBank
        '
        Me.cmbBank.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cmbBank.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(121, 40)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(325, 24)
        Me.cmbBank.TabIndex = 47
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(19, 184)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(84, 16)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "Branch        :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(19, 149)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(85, 16)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "IFSC Code   :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(19, 114)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 16)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "A/C Name    :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(19, 79)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(87, 16)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "A/C Number :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(19, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 16)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "Bank Name   :"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(465, 25)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Add Bank Details"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Red
        Me.lblEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(413, 13)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(76, 16)
        Me.lblEdit.TabIndex = 188
        Me.lblEdit.Text = "EDIT MODE"
        Me.lblEdit.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(321, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 30)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close - [ &X ]"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(220, 465)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 30)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh - [ &R ]"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(18, 465)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 30)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save - [ &S ]"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.SystemColors.Control
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(119, 465)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(95, 30)
        Me.btnList.TabIndex = 19
        Me.btnList.Text = "List - [ &L ]"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'txtCLimit
        '
        Me.txtCLimit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCLimit.Location = New System.Drawing.Point(437, 418)
        Me.txtCLimit.Name = "txtCLimit"
        Me.txtCLimit.Size = New System.Drawing.Size(52, 23)
        Me.txtCLimit.TabIndex = 17
        Me.txtCLimit.Tag = "1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(349, 421)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 16)
        Me.Label23.TabIndex = 186
        Me.Label23.Text = "Credit Limit"
        '
        'cmbDR
        '
        Me.cmbDR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbDR.FormattingEnabled = True
        Me.cmbDR.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbDR.Location = New System.Drawing.Point(265, 418)
        Me.cmbDR.Name = "cmbDR"
        Me.cmbDR.Size = New System.Drawing.Size(51, 24)
        Me.cmbDR.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 421)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 16)
        Me.Label22.TabIndex = 185
        Me.Label22.Text = "Opening Bal"
        '
        'txtOBal
        '
        Me.txtOBal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtOBal.Location = New System.Drawing.Point(128, 418)
        Me.txtOBal.Name = "txtOBal"
        Me.txtOBal.Size = New System.Drawing.Size(131, 23)
        Me.txtOBal.TabIndex = 15
        '
        'txtPAN
        '
        Me.txtPAN.BackColor = System.Drawing.Color.White
        Me.txtPAN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAN.ForeColor = System.Drawing.Color.Black
        Me.txtPAN.Location = New System.Drawing.Point(128, 389)
        Me.txtPAN.Name = "txtPAN"
        Me.txtPAN.Size = New System.Drawing.Size(361, 23)
        Me.txtPAN.TabIndex = 14
        '
        'txtGST
        '
        Me.txtGST.BackColor = System.Drawing.Color.White
        Me.txtGST.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGST.ForeColor = System.Drawing.Color.Black
        Me.txtGST.Location = New System.Drawing.Point(128, 360)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(361, 23)
        Me.txtGST.TabIndex = 13
        '
        'txtCST
        '
        Me.txtCST.BackColor = System.Drawing.Color.White
        Me.txtCST.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCST.ForeColor = System.Drawing.Color.Black
        Me.txtCST.Location = New System.Drawing.Point(768, 168)
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(15, 23)
        Me.txtCST.TabIndex = 178
        Me.txtCST.Visible = False
        '
        'txtTIN
        '
        Me.txtTIN.BackColor = System.Drawing.Color.White
        Me.txtTIN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIN.ForeColor = System.Drawing.Color.Black
        Me.txtTIN.Location = New System.Drawing.Point(768, 139)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(15, 23)
        Me.txtTIN.TabIndex = 177
        Me.txtTIN.Visible = False
        '
        'txtWhatApp
        '
        Me.txtWhatApp.BackColor = System.Drawing.Color.White
        Me.txtWhatApp.ForeColor = System.Drawing.Color.Black
        Me.txtWhatApp.Location = New System.Drawing.Point(128, 331)
        Me.txtWhatApp.Name = "txtWhatApp"
        Me.txtWhatApp.Size = New System.Drawing.Size(361, 23)
        Me.txtWhatApp.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(128, 302)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 23)
        Me.txtEmail.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(128, 273)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(361, 23)
        Me.txtPhone.TabIndex = 10
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.Location = New System.Drawing.Point(128, 244)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(361, 23)
        Me.txtMobile.TabIndex = 9
        '
        'txtCPerson
        '
        Me.txtCPerson.BackColor = System.Drawing.Color.White
        Me.txtCPerson.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPerson.ForeColor = System.Drawing.Color.Black
        Me.txtCPerson.Location = New System.Drawing.Point(128, 215)
        Me.txtCPerson.Name = "txtCPerson"
        Me.txtCPerson.Size = New System.Drawing.Size(361, 23)
        Me.txtCPerson.TabIndex = 8
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.Color.White
        Me.cmbCountry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.ForeColor = System.Drawing.Color.Black
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(329, 185)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(160, 24)
        Me.cmbCountry.TabIndex = 7
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.Color.White
        Me.cmbState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.ForeColor = System.Drawing.Color.Black
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(128, 185)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(195, 24)
        Me.cmbState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.txtCity.Location = New System.Drawing.Point(128, 156)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(361, 23)
        Me.txtCity.TabIndex = 5
        '
        'txtAdd2
        '
        Me.txtAdd2.BackColor = System.Drawing.Color.White
        Me.txtAdd2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.ForeColor = System.Drawing.Color.Black
        Me.txtAdd2.Location = New System.Drawing.Point(128, 127)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd2.TabIndex = 4
        '
        'txtAdd1
        '
        Me.txtAdd1.BackColor = System.Drawing.Color.White
        Me.txtAdd1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.ForeColor = System.Drawing.Color.Black
        Me.txtAdd1.Location = New System.Drawing.Point(128, 98)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd1.TabIndex = 3
        '
        'cmbVGroup
        '
        Me.cmbVGroup.BackColor = System.Drawing.Color.White
        Me.cmbVGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVGroup.ForeColor = System.Drawing.Color.Black
        Me.cmbVGroup.FormattingEnabled = True
        Me.cmbVGroup.Location = New System.Drawing.Point(128, 68)
        Me.cmbVGroup.Name = "cmbVGroup"
        Me.cmbVGroup.Size = New System.Drawing.Size(361, 24)
        Me.cmbVGroup.TabIndex = 2
        '
        'txtVName
        '
        Me.txtVName.BackColor = System.Drawing.Color.White
        Me.txtVName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVName.Location = New System.Drawing.Point(128, 39)
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(361, 23)
        Me.txtVName.TabIndex = 1
        '
        'txtVCode
        '
        Me.txtVCode.BackColor = System.Drawing.Color.White
        Me.txtVCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVCode.Location = New System.Drawing.Point(128, 10)
        Me.txtVCode.Name = "txtVCode"
        Me.txtVCode.Size = New System.Drawing.Size(100, 23)
        Me.txtVCode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Vendor Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Vendor Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 392)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "PAN No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 364)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "GST No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(706, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "CST No :"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(706, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "TIN No :"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "WhatsApp No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Mobile Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Contact Person"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Address Line 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Address Line 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "State && Country"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Vendor Code"
        '
        'Vendors2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 510)
        Me.Controls.Add(Me.pnlBankDetails)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.txtCST)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.txtCLimit)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbDR)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtOBal)
        Me.Controls.Add(Me.txtPAN)
        Me.Controls.Add(Me.txtGST)
        Me.Controls.Add(Me.txtWhatApp)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtCPerson)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.cmbVGroup)
        Me.Controls.Add(Me.txtVName)
        Me.Controls.Add(Me.txtVCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Vendors2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "9"
        Me.Text = "Vendor Register"
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBankDetails.ResumeLayout(False)
        Me.pnlBankDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlList As Panel
    Friend WithEvents btnHide As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents TGLst As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBankDetails As System.Windows.Forms.Panel
    Friend WithEvents btnHide2 As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents txtIFSC As System.Windows.Forms.TextBox
    Friend WithEvents txtACName As System.Windows.Forms.TextBox
    Friend WithEvents txtACNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblEdit As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents txtCLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbDR As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtOBal As System.Windows.Forms.TextBox
    Friend WithEvents txtPAN As System.Windows.Forms.TextBox
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents txtCST As System.Windows.Forms.TextBox
    Friend WithEvents txtTIN As System.Windows.Forms.TextBox
    Friend WithEvents txtWhatApp As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtCPerson As System.Windows.Forms.TextBox
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbVGroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtVName As System.Windows.Forms.TextBox
    Friend WithEvents txtVCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
