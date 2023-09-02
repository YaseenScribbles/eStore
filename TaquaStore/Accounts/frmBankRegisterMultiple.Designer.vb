<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankRegisterMultiple
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.txtACName = New System.Windows.Forms.TextBox()
        Me.txtACNo = New System.Windows.Forms.TextBox()
        Me.cmbACType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddBank = New System.Windows.Forms.Button()
        Me.SimpleLine4 = New simpleline.assemblies.simpleLine()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Label()
        Me.lblEM = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblIFSC = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReloadBankList = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIFSC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bank Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "A/C Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "A/C Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "IFSC Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "A/C Type"
        '
        'cmbVendor
        '
        Me.cmbVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVendor.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(146, 39)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(344, 22)
        Me.cmbVendor.TabIndex = 0
        '
        'cmbBank
        '
        Me.cmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBank.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(272, 142)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(340, 21)
        Me.cmbBank.TabIndex = 1
        '
        'txtACName
        '
        Me.txtACName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtACName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACName.Location = New System.Drawing.Point(272, 193)
        Me.txtACName.Name = "txtACName"
        Me.txtACName.Size = New System.Drawing.Size(340, 21)
        Me.txtACName.TabIndex = 2
        '
        'txtACNo
        '
        Me.txtACNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACNo.Location = New System.Drawing.Point(272, 248)
        Me.txtACNo.Name = "txtACNo"
        Me.txtACNo.Size = New System.Drawing.Size(340, 21)
        Me.txtACNo.TabIndex = 3
        '
        'cmbACType
        '
        Me.cmbACType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbACType.FormattingEnabled = True
        Me.cmbACType.Items.AddRange(New Object() {"SAVINGS", "CURRENT"})
        Me.cmbACType.Location = New System.Drawing.Point(512, 362)
        Me.cmbACType.Name = "cmbACType"
        Me.cmbACType.Size = New System.Drawing.Size(100, 21)
        Me.cmbACType.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.SimpleLine1)
        Me.Panel1.Controls.Add(Me.cmbVendor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 81)
        Me.Panel1.TabIndex = 0
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Silver
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 80)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(632, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 2
        Me.SimpleLine1.UseGradient = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "List of Accounts"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.LightGray
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(15, 113)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(226, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 8
        Me.SimpleLine2.UseGradient = False
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3})
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(15, 126)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersVisible = False
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(226, 334)
        Me.TG.TabIndex = 8
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
        Me.Column2.HeaderText = "Account Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Text = "2"
        Me.Column4.Width = 30
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 23
        '
        'SimpleLine3
        '
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.LightGray
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(272, 113)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(340, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 11
        Me.SimpleLine3.UseGradient = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Bank Details"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(512, 435)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 25)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddBank
        '
        Me.btnAddBank.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBank.Location = New System.Drawing.Point(272, 435)
        Me.btnAddBank.Name = "btnAddBank"
        Me.btnAddBank.Size = New System.Drawing.Size(100, 25)
        Me.btnAddBank.TabIndex = 10
        Me.btnAddBank.Text = "&Add Bank"
        Me.btnAddBank.UseVisualStyleBackColor = True
        '
        'SimpleLine4
        '
        Me.SimpleLine4.Enabled = False
        Me.SimpleLine4.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine4.FitToParent = False
        Me.SimpleLine4.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine4.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine4.LineColor = System.Drawing.Color.LightGray
        Me.SimpleLine4.LineWidth = 1
        Me.SimpleLine4.Location = New System.Drawing.Point(272, 418)
        Me.SimpleLine4.Name = "SimpleLine4"
        Me.SimpleLine4.Size = New System.Drawing.Size(340, 1)
        Me.SimpleLine4.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine4.TabIndex = 15
        Me.SimpleLine4.UseGradient = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(269, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Options"
        '
        'btnReload
        '
        Me.btnReload.AutoSize = True
        Me.btnReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReload.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReload.Location = New System.Drawing.Point(195, 91)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(46, 13)
        Me.btnReload.TabIndex = 9
        Me.btnReload.Text = "&Reload"
        '
        'lblEM
        '
        Me.lblEM.AutoSize = True
        Me.lblEM.BackColor = System.Drawing.Color.Red
        Me.lblEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEM.ForeColor = System.Drawing.Color.White
        Me.lblEM.Location = New System.Drawing.Point(544, 91)
        Me.lblEM.Name = "lblEM"
        Me.lblEM.Size = New System.Drawing.Size(68, 13)
        Me.lblEM.TabIndex = 17
        Me.lblEM.Text = "EDIT MODE"
        Me.lblEM.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(378, 435)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 25)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblIFSC
        '
        Me.lblIFSC.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIFSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIFSC.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIFSC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIFSC.Location = New System.Drawing.Point(389, 308)
        Me.lblIFSC.Name = "lblIFSC"
        Me.lblIFSC.Size = New System.Drawing.Size(223, 22)
        Me.lblIFSC.TabIndex = 19
        Me.lblIFSC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbBranch
        '
        Me.cmbBranch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(272, 362)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(234, 21)
        Me.cmbBranch.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(269, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Branch"
        '
        'TTip
        '
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error !"
        '
        'btnReloadBankList
        '
        Me.btnReloadBankList.AutoSize = True
        Me.btnReloadBankList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReloadBankList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadBankList.ForeColor = System.Drawing.Color.Purple
        Me.btnReloadBankList.Location = New System.Drawing.Point(512, 125)
        Me.btnReloadBankList.Name = "btnReloadBankList"
        Me.btnReloadBankList.Size = New System.Drawing.Size(100, 13)
        Me.btnReloadBankList.TabIndex = 22
        Me.btnReloadBankList.Text = "Reload &Bank List"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(483, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "F4 To Copy Vendor Name"
        '
        'txtIFSC
        '
        Me.txtIFSC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtIFSC.Location = New System.Drawing.Point(272, 309)
        Me.txtIFSC.MaxLength = 11
        Me.txtIFSC.Name = "txtIFSC"
        Me.txtIFSC.Size = New System.Drawing.Size(100, 21)
        Me.txtIFSC.TabIndex = 4
        Me.txtIFSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(387, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "IFSC Description"
        '
        'frmBankRegisterMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 472)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIFSC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnReloadBankList)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.lblIFSC)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblEM)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.SimpleLine4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAddBank)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.SimpleLine3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbACType)
        Me.Controls.Add(Me.txtACNo)
        Me.Controls.Add(Me.txtACName)
        Me.Controls.Add(Me.cmbBank)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBankRegisterMultiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Register - Multiple"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents txtACName As System.Windows.Forms.TextBox
    Friend WithEvents txtACNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbACType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAddBank As System.Windows.Forms.Button
    Friend WithEvents SimpleLine4 As simpleline.assemblies.simpleLine
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReload As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEM As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblIFSC As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnReloadBankList As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIFSC As TextBox
    Friend WithEvents Label13 As Label
End Class
