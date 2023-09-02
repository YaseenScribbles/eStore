<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtWApp = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.chkIsReceivable = New System.Windows.Forms.CheckBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.pnlList.SuspendLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.btnHide)
        Me.pnlList.Controls.Add(Me.Label27)
        Me.pnlList.Controls.Add(Me.txtFind)
        Me.pnlList.Controls.Add(Me.Label26)
        Me.pnlList.Controls.Add(Me.TGLst)
        Me.pnlList.Location = New System.Drawing.Point(54, 32)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(405, 496)
        Me.pnlList.TabIndex = 80
        Me.pnlList.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(368, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(35, 25)
        Me.btnHide.TabIndex = 46
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(108, 16)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Customer Name :"
        '
        'txtFind
        '
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFind.Location = New System.Drawing.Point(11, 56)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(383, 23)
        Me.txtFind.TabIndex = 2
        Me.txtFind.Tag = "1"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(403, 25)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "List of Customers"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TGLst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TGLst.BackgroundColor = System.Drawing.Color.White
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TGLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGLst.DefaultCellStyle = DataGridViewCellStyle6
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TGLst.Location = New System.Drawing.Point(11, 86)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.RowTemplate.Height = 23
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGLst.Size = New System.Drawing.Size(383, 396)
        Me.TGLst.TabIndex = 0
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
        Me.Column3.HeaderText = "Customer Name"
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnList)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(22, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 59)
        Me.Panel1.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(233, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&R : Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(127, 12)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(100, 30)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "&L : List "
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(21, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&S : Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(132, 428)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 23)
        Me.txtEmail.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Email ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Phone Number :"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(132, 341)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(361, 23)
        Me.txtPhone.TabIndex = 6
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.Location = New System.Drawing.Point(132, 370)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(361, 23)
        Me.txtMobile.TabIndex = 7
        '
        'SimpleLine3
        '
        Me.SimpleLine3.BackColor = System.Drawing.Color.LightSalmon
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(22, 321)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 106
        Me.SimpleLine3.UseGradient = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 302)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Contact Info"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(22, 153)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 104
        Me.SimpleLine2.UseGradient = False
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.Color.White
        Me.cmbState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.ForeColor = System.Drawing.Color.Black
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(132, 258)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(361, 24)
        Me.cmbState.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.txtCity.Location = New System.Drawing.Point(132, 229)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(361, 23)
        Me.txtCity.TabIndex = 4
        '
        'txtAdd2
        '
        Me.txtAdd2.BackColor = System.Drawing.Color.White
        Me.txtAdd2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.ForeColor = System.Drawing.Color.Black
        Me.txtAdd2.Location = New System.Drawing.Point(132, 200)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd2.TabIndex = 3
        '
        'txtWApp
        '
        Me.txtWApp.BackColor = System.Drawing.Color.White
        Me.txtWApp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWApp.ForeColor = System.Drawing.Color.Black
        Me.txtWApp.Location = New System.Drawing.Point(132, 399)
        Me.txtWApp.Name = "txtWApp"
        Me.txtWApp.Size = New System.Drawing.Size(361, 23)
        Me.txtWApp.TabIndex = 8
        '
        'txtAdd1
        '
        Me.txtAdd1.BackColor = System.Drawing.Color.White
        Me.txtAdd1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.ForeColor = System.Drawing.Color.Black
        Me.txtAdd1.Location = New System.Drawing.Point(132, 171)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd1.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Address Info"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Mobile Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "WhatsApp No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Address Line 2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Address Line 1 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "City :"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(22, 40)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 96
        Me.SimpleLine1.UseGradient = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 16)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Customer Info"
        '
        'txtVName
        '
        Me.txtVName.BackColor = System.Drawing.Color.White
        Me.txtVName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVName.Location = New System.Drawing.Point(132, 89)
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(361, 23)
        Me.txtVName.TabIndex = 1
        '
        'txtCustCode
        '
        Me.txtCustCode.BackColor = System.Drawing.Color.White
        Me.txtCustCode.Enabled = False
        Me.txtCustCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCustCode.Location = New System.Drawing.Point(132, 59)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(100, 23)
        Me.txtCustCode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Customer Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Customer Code :"
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Red
        Me.lblEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(417, 19)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(75, 16)
        Me.lblEdit.TabIndex = 111
        Me.lblEdit.Text = "EDIT MODE"
        Me.lblEdit.Visible = False
        '
        'chkIsReceivable
        '
        Me.chkIsReceivable.AutoSize = True
        Me.chkIsReceivable.Location = New System.Drawing.Point(381, 457)
        Me.chkIsReceivable.Name = "chkIsReceivable"
        Me.chkIsReceivable.Size = New System.Drawing.Size(111, 20)
        Me.chkIsReceivable.TabIndex = 10
        Me.chkIsReceivable.Text = "Is Receivable ?"
        Me.chkIsReceivable.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(339, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 30)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "&C : Close "
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 561)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.chkIsReceivable)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.SimpleLine3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtWApp)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtVName)
        Me.Controls.Add(Me.txtCustCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "3"
        Me.Text = "Customer Register"
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlList As Panel
    Friend WithEvents btnHide As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TGLst As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnList As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents Label19 As Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtWApp As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label17 As Label
    Friend WithEvents txtVName As TextBox
    Friend WithEvents txtCustCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEdit As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents chkIsReceivable As CheckBox
    Friend WithEvents BtnClose As Button
End Class
