<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agents
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHidePnl = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWApp = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.pnlMain)
        Me.Panel1.Controls.Add(Me.pHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 561)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnHidePnl, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRefresh, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnList, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 527)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1051, 32)
        Me.TableLayoutPanel1.TabIndex = 84
        '
        'btnHidePnl
        '
        Me.btnHidePnl.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHidePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHidePnl.FlatAppearance.BorderSize = 0
        Me.btnHidePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHidePnl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHidePnl.Location = New System.Drawing.Point(452, 5)
        Me.btnHidePnl.Name = "btnHidePnl"
        Me.btnHidePnl.Size = New System.Drawing.Size(141, 22)
        Me.btnHidePnl.TabIndex = 85
        Me.btnHidePnl.Text = "&X  : Hide"
        Me.btnHidePnl.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(303, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(141, 22)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&R : Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(5, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 22)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&S : Save Entry"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(154, 5)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(141, 22)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "&L : List Agents"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Controls.Add(Me.Label17)
        Me.pnlMain.Controls.Add(Me.txtWApp)
        Me.pnlMain.Controls.Add(Me.txtAdd2)
        Me.pnlMain.Controls.Add(Me.txtAdd1)
        Me.pnlMain.Controls.Add(Me.Label12)
        Me.pnlMain.Controls.Add(Me.txtCity)
        Me.pnlMain.Controls.Add(Me.lblEdit)
        Me.pnlMain.Controls.Add(Me.Label18)
        Me.pnlMain.Controls.Add(Me.txtComm)
        Me.pnlMain.Controls.Add(Me.cmbState)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.Label10)
        Me.pnlMain.Controls.Add(Me.Label11)
        Me.pnlMain.Controls.Add(Me.SimpleLine2)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.Label9)
        Me.pnlMain.Controls.Add(Me.Label19)
        Me.pnlMain.Controls.Add(Me.txtAgentCode)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.txtEmail)
        Me.pnlMain.Controls.Add(Me.SimpleLine3)
        Me.pnlMain.Controls.Add(Me.txtVName)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.txtMobile)
        Me.pnlMain.Controls.Add(Me.SimpleLine1)
        Me.pnlMain.Controls.Add(Me.Label7)
        Me.pnlMain.Controls.Add(Me.Label8)
        Me.pnlMain.Controls.Add(Me.txtPhone)
        Me.pnlMain.Controls.Add(Me.Label6)
        Me.pnlMain.Location = New System.Drawing.Point(-1, 26)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(514, 471)
        Me.pnlMain.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 16)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Agent Info (F8)"
        '
        'txtWApp
        '
        Me.txtWApp.BackColor = System.Drawing.Color.White
        Me.txtWApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWApp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWApp.ForeColor = System.Drawing.Color.Black
        Me.txtWApp.Location = New System.Drawing.Point(128, 392)
        Me.txtWApp.Name = "txtWApp"
        Me.txtWApp.Size = New System.Drawing.Size(361, 23)
        Me.txtWApp.TabIndex = 59
        '
        'txtAdd2
        '
        Me.txtAdd2.BackColor = System.Drawing.Color.White
        Me.txtAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.ForeColor = System.Drawing.Color.Black
        Me.txtAdd2.Location = New System.Drawing.Point(128, 193)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd2.TabIndex = 54
        '
        'txtAdd1
        '
        Me.txtAdd1.BackColor = System.Drawing.Color.White
        Me.txtAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.ForeColor = System.Drawing.Color.Black
        Me.txtAdd1.Location = New System.Drawing.Point(128, 164)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(361, 23)
        Me.txtAdd1.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(459, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 16)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "(%)"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.txtCity.Location = New System.Drawing.Point(128, 222)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(361, 23)
        Me.txtCity.TabIndex = 55
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Red
        Me.lblEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(413, 12)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(76, 16)
        Me.lblEdit.TabIndex = 81
        Me.lblEdit.Text = "EDIT MODE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 16)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Address Info"
        '
        'txtComm
        '
        Me.txtComm.BackColor = System.Drawing.Color.White
        Me.txtComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComm.Location = New System.Drawing.Point(398, 53)
        Me.txtComm.Name = "txtComm"
        Me.txtComm.Size = New System.Drawing.Size(55, 23)
        Me.txtComm.TabIndex = 51
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.Color.White
        Me.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbState.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.ForeColor = System.Drawing.Color.Black
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(128, 251)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(361, 22)
        Me.cmbState.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Agent Code :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Mobile Number :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Commission :"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Chocolate
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(18, 146)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 73
        Me.SimpleLine2.UseGradient = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Agent Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "WhatsApp No :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 295)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 16)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Contact Info"
        '
        'txtAgentCode
        '
        Me.txtAgentCode.BackColor = System.Drawing.Color.White
        Me.txtAgentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgentCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAgentCode.Location = New System.Drawing.Point(128, 52)
        Me.txtAgentCode.Name = "txtAgentCode"
        Me.txtAgentCode.Size = New System.Drawing.Size(100, 23)
        Me.txtAgentCode.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Address Line 2 :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(128, 421)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 23)
        Me.txtEmail.TabIndex = 60
        '
        'SimpleLine3
        '
        Me.SimpleLine3.BackColor = System.Drawing.Color.LightSalmon
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.Chocolate
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(18, 314)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 75
        Me.SimpleLine3.UseGradient = False
        '
        'txtVName
        '
        Me.txtVName.BackColor = System.Drawing.Color.White
        Me.txtVName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVName.Location = New System.Drawing.Point(128, 82)
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(361, 23)
        Me.txtVName.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Address Line 1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Email ID :"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.Location = New System.Drawing.Point(128, 363)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(361, 23)
        Me.txtMobile.TabIndex = 58
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Chocolate
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(18, 33)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(471, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 65
        Me.SimpleLine1.UseGradient = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Phone Number :"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(128, 334)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(361, 23)
        Me.txtPhone.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "City :"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pHeader.Controls.Add(Me.Label14)
        Me.pHeader.Controls.Add(Me.Label13)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1051, 26)
        Me.pHeader.TabIndex = 82
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(14, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 14)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Agent Register"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1021, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 21)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "r"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlList.Controls.Add(Me.btnHide)
        Me.pnlList.Controls.Add(Me.Label26)
        Me.pnlList.Location = New System.Drawing.Point(0, 0)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(879, 496)
        Me.pnlList.TabIndex = 81
        Me.pnlList.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Silver
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TGLst, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(877, 469)
        Me.TableLayoutPanel2.TabIndex = 47
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        Me.TGLst.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TGLst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
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
        Me.TGLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TGLst.Location = New System.Drawing.Point(250, 96)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.RowTemplate.Height = 23
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.None
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
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.txtFind)
        Me.Panel2.Location = New System.Drawing.Point(277, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 87)
        Me.Panel2.TabIndex = 46
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(119, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 16)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Find Agents"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.Black
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFind.ForeColor = System.Drawing.Color.White
        Me.txtFind.Location = New System.Drawing.Point(9, 46)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(304, 23)
        Me.txtFind.TabIndex = 2
        Me.txtFind.Tag = "1"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(839, 1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(35, 25)
        Me.btnHide.TabIndex = 46
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        Me.btnHide.Visible = False
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(877, 25)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "   List of Agents"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Agents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1053, 561)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Agents"
        Me.Tag = "Agents"
        Me.Text = "Agent Register"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pHeader.ResumeLayout(False)
        Me.pHeader.PerformLayout()
        Me.pnlList.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pHeader As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
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
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlList As Panel
    Friend WithEvents btnHide As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TGLst As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnHidePnl As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
End Class
