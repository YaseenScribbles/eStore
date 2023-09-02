<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Godown
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlWS = New System.Windows.Forms.Panel()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFindGdn = New TaquaStore.cTextBox()
        Me.txtCity = New TaquaStore.cTextBox()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEmailID = New TaquaStore.cTextBox()
        Me.txtGDNCode = New TaquaStore.cTextBox()
        Me.txtPhone = New TaquaStore.cTextBox()
        Me.txtAddress2 = New TaquaStore.cTextBox()
        Me.txtAddress1 = New TaquaStore.cTextBox()
        Me.txtgdnName = New TaquaStore.cTextBox()
        Me.txtCat = New TaquaStore.cTextBox()
        Me.pnlWS.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Godown Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Godown Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Email ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Phone"
        '
        'pnlWS
        '
        Me.pnlWS.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlWS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWS.Controls.Add(Me.SimpleLine1)
        Me.pnlWS.Controls.Add(Me.btnClose)
        Me.pnlWS.Controls.Add(Me.Label13)
        Me.pnlWS.Controls.Add(Me.Label12)
        Me.pnlWS.Controls.Add(Me.btnReset)
        Me.pnlWS.Controls.Add(Me.Label10)
        Me.pnlWS.Controls.Add(Me.Label9)
        Me.pnlWS.Controls.Add(Me.btnSave)
        Me.pnlWS.Controls.Add(Me.Label8)
        Me.pnlWS.Controls.Add(Me.Label2)
        Me.pnlWS.Controls.Add(Me.Label11)
        Me.pnlWS.Controls.Add(Me.txtFindGdn)
        Me.pnlWS.Controls.Add(Me.txtCity)
        Me.pnlWS.Controls.Add(Me.TG)
        Me.pnlWS.Controls.Add(Me.Label3)
        Me.pnlWS.Controls.Add(Me.txtEmailID)
        Me.pnlWS.Controls.Add(Me.txtGDNCode)
        Me.pnlWS.Controls.Add(Me.txtPhone)
        Me.pnlWS.Controls.Add(Me.Label1)
        Me.pnlWS.Controls.Add(Me.txtAddress2)
        Me.pnlWS.Controls.Add(Me.Label4)
        Me.pnlWS.Controls.Add(Me.Label6)
        Me.pnlWS.Controls.Add(Me.txtAddress1)
        Me.pnlWS.Controls.Add(Me.Label5)
        Me.pnlWS.Controls.Add(Me.txtgdnName)
        Me.pnlWS.Controls.Add(Me.Label7)
        Me.pnlWS.Location = New System.Drawing.Point(0, 0)
        Me.pnlWS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlWS.Name = "pnlWS"
        Me.pnlWS.Size = New System.Drawing.Size(413, 335)
        Me.pnlWS.TabIndex = 0
        '
        'SimpleLine1
        '
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(15, 278)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(380, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 27
        Me.SimpleLine1.UseGradient = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(324, 290)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 29)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "X : E&XIT"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(411, 31)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Godown Register"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 14)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = ":"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(251, 290)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(70, 29)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "R : RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(115, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 14)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(115, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 14)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = ":"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(178, 290)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 29)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "S : &SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 14)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 14)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(115, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 14)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = ":"
        '
        'txtFindGdn
        '
        Me.txtFindGdn.AcceptBackwards = True
        Me.txtFindGdn.AcceptEmptyWords = True
        Me.txtFindGdn.BackColor = System.Drawing.Color.White
        Me.txtFindGdn.BorderColor = System.Drawing.Color.DimGray
        Me.txtFindGdn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindGdn.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtFindGdn.Enabled = False
        Me.txtFindGdn.FocusBackColor = System.Drawing.Color.Black
        Me.txtFindGdn.FocusBorderColor = System.Drawing.Color.Black
        Me.txtFindGdn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindGdn.Location = New System.Drawing.Point(604, 407)
        Me.txtFindGdn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFindGdn.Name = "txtFindGdn"
        Me.txtFindGdn.NormalBackColor = System.Drawing.Color.White
        Me.txtFindGdn.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtFindGdn.Size = New System.Drawing.Size(104, 21)
        Me.txtFindGdn.TabIndex = 15
        Me.txtFindGdn.Tag = "1"
        '
        'txtCity
        '
        Me.txtCity.AcceptBackwards = True
        Me.txtCity.AcceptEmptyWords = True
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderColor = System.Drawing.Color.DimGray
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtCity.FocusBackColor = System.Drawing.Color.Black
        Me.txtCity.FocusBorderColor = System.Drawing.Color.Black
        Me.txtCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(136, 172)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.NormalBackColor = System.Drawing.Color.White
        Me.txtCity.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtCity.Size = New System.Drawing.Size(259, 21)
        Me.txtCity.TabIndex = 4
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle4
        Me.TG.Enabled = False
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.Gainsboro
        Me.TG.Location = New System.Drawing.Point(604, 457)
        Me.TG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(104, 18)
        Me.TG.TabIndex = 16
        Me.TG.Tag = "1"
        '
        'Column1
        '
        Me.Column1.HeaderText = "CustID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "GODOWN NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 230
        '
        'txtEmailID
        '
        Me.txtEmailID.AcceptBackwards = True
        Me.txtEmailID.AcceptEmptyWords = True
        Me.txtEmailID.BackColor = System.Drawing.Color.White
        Me.txtEmailID.BorderColor = System.Drawing.Color.DimGray
        Me.txtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailID.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtEmailID.FocusBackColor = System.Drawing.Color.Black
        Me.txtEmailID.FocusBorderColor = System.Drawing.Color.Black
        Me.txtEmailID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID.Location = New System.Drawing.Point(136, 234)
        Me.txtEmailID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.NormalBackColor = System.Drawing.Color.White
        Me.txtEmailID.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtEmailID.Size = New System.Drawing.Size(259, 21)
        Me.txtEmailID.TabIndex = 6
        '
        'txtGDNCode
        '
        Me.txtGDNCode.AcceptBackwards = True
        Me.txtGDNCode.AcceptEmptyWords = True
        Me.txtGDNCode.BackColor = System.Drawing.Color.White
        Me.txtGDNCode.BorderColor = System.Drawing.Color.DimGray
        Me.txtGDNCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGDNCode.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtGDNCode.Enabled = False
        Me.txtGDNCode.FocusBackColor = System.Drawing.Color.Black
        Me.txtGDNCode.FocusBorderColor = System.Drawing.Color.Black
        Me.txtGDNCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGDNCode.Location = New System.Drawing.Point(136, 48)
        Me.txtGDNCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGDNCode.Name = "txtGDNCode"
        Me.txtGDNCode.NormalBackColor = System.Drawing.Color.White
        Me.txtGDNCode.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtGDNCode.Size = New System.Drawing.Size(77, 21)
        Me.txtGDNCode.TabIndex = 0
        Me.txtGDNCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhone
        '
        Me.txtPhone.AcceptBackwards = True
        Me.txtPhone.AcceptEmptyWords = True
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderColor = System.Drawing.Color.DimGray
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtPhone.FocusBackColor = System.Drawing.Color.Black
        Me.txtPhone.FocusBorderColor = System.Drawing.Color.Black
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(136, 203)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.NormalBackColor = System.Drawing.Color.White
        Me.txtPhone.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtPhone.Size = New System.Drawing.Size(259, 21)
        Me.txtPhone.TabIndex = 5
        '
        'txtAddress2
        '
        Me.txtAddress2.AcceptBackwards = True
        Me.txtAddress2.AcceptEmptyWords = True
        Me.txtAddress2.BackColor = System.Drawing.Color.White
        Me.txtAddress2.BorderColor = System.Drawing.Color.DimGray
        Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress2.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtAddress2.FocusBackColor = System.Drawing.Color.Black
        Me.txtAddress2.FocusBorderColor = System.Drawing.Color.Black
        Me.txtAddress2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(136, 141)
        Me.txtAddress2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.NormalBackColor = System.Drawing.Color.White
        Me.txtAddress2.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtAddress2.Size = New System.Drawing.Size(259, 21)
        Me.txtAddress2.TabIndex = 3
        '
        'txtAddress1
        '
        Me.txtAddress1.AcceptBackwards = True
        Me.txtAddress1.AcceptEmptyWords = True
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.BorderColor = System.Drawing.Color.DimGray
        Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress1.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtAddress1.FocusBackColor = System.Drawing.Color.Black
        Me.txtAddress1.FocusBorderColor = System.Drawing.Color.Black
        Me.txtAddress1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(136, 110)
        Me.txtAddress1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.NormalBackColor = System.Drawing.Color.White
        Me.txtAddress1.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtAddress1.Size = New System.Drawing.Size(259, 21)
        Me.txtAddress1.TabIndex = 2
        '
        'txtgdnName
        '
        Me.txtgdnName.AcceptBackwards = True
        Me.txtgdnName.AcceptEmptyWords = True
        Me.txtgdnName.BackColor = System.Drawing.Color.White
        Me.txtgdnName.BorderColor = System.Drawing.Color.DimGray
        Me.txtgdnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgdnName.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtgdnName.FocusBackColor = System.Drawing.Color.Black
        Me.txtgdnName.FocusBorderColor = System.Drawing.Color.Black
        Me.txtgdnName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgdnName.Location = New System.Drawing.Point(136, 79)
        Me.txtgdnName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtgdnName.Name = "txtgdnName"
        Me.txtgdnName.NormalBackColor = System.Drawing.Color.White
        Me.txtgdnName.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtgdnName.Size = New System.Drawing.Size(259, 21)
        Me.txtgdnName.TabIndex = 1
        '
        'txtCat
        '
        Me.txtCat.AcceptBackwards = True
        Me.txtCat.AcceptEmptyWords = True
        Me.txtCat.BorderColor = System.Drawing.Color.Black
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtCat.FocusBackColor = System.Drawing.Color.Empty
        Me.txtCat.FocusBorderColor = System.Drawing.Color.Empty
        Me.txtCat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.Location = New System.Drawing.Point(128, 89)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.NormalBackColor = System.Drawing.Color.Empty
        Me.txtCat.NormalBorderColor = System.Drawing.Color.Empty
        Me.txtCat.Size = New System.Drawing.Size(89, 25)
        Me.txtCat.TabIndex = 0
        Me.txtCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Godown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 570)
        Me.Controls.Add(Me.pnlWS)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Godown"
        Me.Tag = "13"
        Me.Text = "Godown"
        Me.pnlWS.ResumeLayout(False)
        Me.pnlWS.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents pnlWS As System.Windows.Forms.Panel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtGDNCode As TaquaStore.cTextBox
    Friend WithEvents txtgdnName As TaquaStore.cTextBox
    Friend WithEvents txtAddress1 As TaquaStore.cTextBox
    Friend WithEvents txtCity As TaquaStore.cTextBox
    Friend WithEvents txtAddress2 As TaquaStore.cTextBox
    Friend WithEvents txtPhone As TaquaStore.cTextBox
    Friend WithEvents txtEmailID As TaquaStore.cTextBox
    Friend WithEvents txtCat As TaquaStore.cTextBox
    Friend WithEvents txtFindGdn As TaquaStore.cTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
End Class
