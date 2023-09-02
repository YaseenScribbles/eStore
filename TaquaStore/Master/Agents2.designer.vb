<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agents2
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWApp = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtComm = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAgentCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SimpleLine4 = New simpleline.assemblies.simpleLine()
        Me.btnHidePnl = New System.Windows.Forms.Button()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlList.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(131, 492)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 30)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh - [ &R ]"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(15, 492)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 30)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save - [ &S ]"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.SystemColors.Control
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(247, 492)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(110, 30)
        Me.btnList.TabIndex = 13
        Me.btnList.Text = "&L : List Agents"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 16)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Agent Info (F8)"
        '
        'txtWApp
        '
        Me.txtWApp.BackColor = System.Drawing.Color.White
        Me.txtWApp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWApp.ForeColor = System.Drawing.Color.Black
        Me.txtWApp.Location = New System.Drawing.Point(125, 387)
        Me.txtWApp.Name = "txtWApp"
        Me.txtWApp.Size = New System.Drawing.Size(361, 23)
        Me.txtWApp.TabIndex = 9
        '
        'txtAdd2
        '
        Me.txtAdd2.BackColor = System.Drawing.Color.White
        Me.txtAdd2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.ForeColor = System.Drawing.Color.Black
        Me.txtAdd2.Location = New System.Drawing.Point(125, 188)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd2.TabIndex = 4
        '
        'txtAdd1
        '
        Me.txtAdd1.BackColor = System.Drawing.Color.White
        Me.txtAdd1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.ForeColor = System.Drawing.Color.Black
        Me.txtAdd1.Location = New System.Drawing.Point(125, 159)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd1.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.txtCity.Location = New System.Drawing.Point(125, 217)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(361, 23)
        Me.txtCity.TabIndex = 5
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Red
        Me.lblEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(410, 7)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(76, 16)
        Me.lblEdit.TabIndex = 81
        Me.lblEdit.Text = "EDIT MODE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(12, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 16)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Address Info"
        '
        'txtComm
        '
        Me.txtComm.BackColor = System.Drawing.Color.White
        Me.txtComm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComm.Location = New System.Drawing.Point(431, 48)
        Me.txtComm.Name = "txtComm"
        Me.txtComm.Size = New System.Drawing.Size(55, 23)
        Me.txtComm.TabIndex = 1
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.Color.White
        Me.cmbState.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.ForeColor = System.Drawing.Color.Black
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(125, 246)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(361, 22)
        Me.cmbState.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Agent Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Mobile Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Commission % :"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(15, 141)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 73
        Me.SimpleLine2.UseGradient = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Agent Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "WhatsApp No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(12, 290)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 16)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Contact Info"
        '
        'txtAgentCode
        '
        Me.txtAgentCode.BackColor = System.Drawing.Color.White
        Me.txtAgentCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAgentCode.Location = New System.Drawing.Point(125, 47)
        Me.txtAgentCode.Name = "txtAgentCode"
        Me.txtAgentCode.Size = New System.Drawing.Size(100, 23)
        Me.txtAgentCode.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Address Line 2"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(125, 416)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 23)
        Me.txtEmail.TabIndex = 10
        '
        'SimpleLine3
        '
        Me.SimpleLine3.BackColor = System.Drawing.Color.LightSalmon
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(15, 309)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 75
        Me.SimpleLine3.UseGradient = False
        '
        'txtVName
        '
        Me.txtVName.BackColor = System.Drawing.Color.White
        Me.txtVName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVName.Location = New System.Drawing.Point(125, 77)
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(361, 23)
        Me.txtVName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Address Line 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Email ID"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.Location = New System.Drawing.Point(125, 358)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(361, 23)
        Me.txtMobile.TabIndex = 8
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(15, 28)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 65
        Me.SimpleLine1.UseGradient = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(125, 329)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(361, 23)
        Me.txtPhone.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "City"
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        Me.TGLst.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TGLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGLst.DefaultCellStyle = DataGridViewCellStyle4
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TGLst.Location = New System.Drawing.Point(6, 82)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.RowTemplate.Height = 23
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGLst.Size = New System.Drawing.Size(377, 370)
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
        Me.Column3.HeaderText = "Agent Name"
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 16)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Find Agent"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.ForeColor = System.Drawing.Color.Black
        Me.txtFind.Location = New System.Drawing.Point(6, 53)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(377, 23)
        Me.txtFind.TabIndex = 2
        Me.txtFind.Tag = "1"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Orange
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.Black
        Me.btnHide.Location = New System.Drawing.Point(360, -1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(29, 25)
        Me.btnHide.TabIndex = 46
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        Me.btnHide.Visible = False
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.SystemColors.Control
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.btnHide)
        Me.pnlList.Controls.Add(Me.Label27)
        Me.pnlList.Controls.Add(Me.TGLst)
        Me.pnlList.Controls.Add(Me.txtFind)
        Me.pnlList.Controls.Add(Me.Label15)
        Me.pnlList.Location = New System.Drawing.Point(54, 38)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(390, 459)
        Me.pnlList.TabIndex = 82
        Me.pnlList.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Orange
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(388, 25)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "List of Agents"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(12, 454)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Options"
        '
        'SimpleLine4
        '
        Me.SimpleLine4.BackColor = System.Drawing.Color.LightSalmon
        Me.SimpleLine4.Enabled = False
        Me.SimpleLine4.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine4.FitToParent = False
        Me.SimpleLine4.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine4.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine4.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine4.LineWidth = 1
        Me.SimpleLine4.Location = New System.Drawing.Point(15, 473)
        Me.SimpleLine4.Name = "SimpleLine4"
        Me.SimpleLine4.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine4.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine4.TabIndex = 87
        Me.SimpleLine4.UseGradient = False
        '
        'btnHidePnl
        '
        Me.btnHidePnl.BackColor = System.Drawing.SystemColors.Control
        Me.btnHidePnl.FlatAppearance.BorderSize = 0
        Me.btnHidePnl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHidePnl.Location = New System.Drawing.Point(363, 492)
        Me.btnHidePnl.Name = "btnHidePnl"
        Me.btnHidePnl.Size = New System.Drawing.Size(110, 30)
        Me.btnHidePnl.TabIndex = 14
        Me.btnHidePnl.Text = "Close - [ &X ]"
        Me.btnHidePnl.UseVisualStyleBackColor = True
        '
        'Agents2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(499, 535)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SimpleLine4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtWApp)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.btnHidePnl)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtComm)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVName)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SimpleLine3)
        Me.Controls.Add(Me.txtAgentCode)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Agents2"
        Me.Tag = "Agents"
        Me.Text = "Agent Register"
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents lblEdit As Label
    Friend WithEvents txtComm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnList As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAgentCode As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtVName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtWApp As TextBox
    Friend WithEvents btnHide As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents TGLst As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine4 As simpleline.assemblies.simpleLine
    Friend WithEvents btnHidePnl As System.Windows.Forms.Button
End Class
