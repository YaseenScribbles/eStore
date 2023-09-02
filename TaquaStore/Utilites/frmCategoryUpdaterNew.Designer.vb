<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryUpdaterNew
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.cmbSCat1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSCat2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSCat3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbSCat4NC = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbSCat4 = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbDeptNC = New System.Windows.Forms.ComboBox()
        Me.cmbSCat3NC = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSCat1NC = New System.Windows.Forms.ComboBox()
        Me.cmbSCat2NC = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSUC = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'cmbDept
        '
        Me.cmbDept.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(18, 65)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(250, 21)
        Me.cmbDept.TabIndex = 0
        '
        'cmbSCat1
        '
        Me.cmbSCat1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat1.FormattingEnabled = True
        Me.cmbSCat1.Location = New System.Drawing.Point(277, 65)
        Me.cmbSCat1.Name = "cmbSCat1"
        Me.cmbSCat1.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sub Category - 1"
        '
        'cmbSCat2
        '
        Me.cmbSCat2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat2.FormattingEnabled = True
        Me.cmbSCat2.Location = New System.Drawing.Point(18, 120)
        Me.cmbSCat2.Name = "cmbSCat2"
        Me.cmbSCat2.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sub Category - 2"
        '
        'cmbSCat3
        '
        Me.cmbSCat3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat3.FormattingEnabled = True
        Me.cmbSCat3.Location = New System.Drawing.Point(277, 120)
        Me.cmbSCat3.Name = "cmbSCat3"
        Me.cmbSCat3.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sub Category - 3"
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(429, 212)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(98, 26)
        Me.btnResult.TabIndex = 6
        Me.btnResult.Text = "&Show Results"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.chkSUC)
        Me.Panel1.Controls.Add(Me.cmbSCat4NC)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbVendor)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbSCat4)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnReload)
        Me.Panel1.Controls.Add(Me.SimpleLine2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.cmbDeptNC)
        Me.Panel1.Controls.Add(Me.cmbSCat3NC)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbSCat1NC)
        Me.Panel1.Controls.Add(Me.cmbSCat2NC)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.SimpleLine1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnResult)
        Me.Panel1.Controls.Add(Me.cmbDept)
        Me.Panel1.Controls.Add(Me.cmbSCat3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbSCat1)
        Me.Panel1.Controls.Add(Me.cmbSCat2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(37, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 250)
        Me.Panel1.TabIndex = 7
        '
        'cmbSCat4NC
        '
        Me.cmbSCat4NC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat4NC.FormattingEnabled = True
        Me.cmbSCat4NC.Location = New System.Drawing.Point(545, 174)
        Me.cmbSCat4NC.Name = "cmbSCat4NC"
        Me.cmbSCat4NC.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat4NC.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(542, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Sub Category - 4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(274, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Vendor"
        '
        'cmbVendor
        '
        Me.cmbVendor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(277, 175)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(250, 21)
        Me.cmbVendor.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Sub Category - 4"
        '
        'cmbSCat4
        '
        Me.cmbSCat4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat4.FormattingEnabled = True
        Me.cmbSCat4.Location = New System.Drawing.Point(18, 175)
        Me.cmbSCat4.Name = "cmbSCat4"
        Me.cmbSCat4.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat4.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(985, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 13)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "CLOSE - [X]"
        '
        'btnReload
        '
        Me.btnReload.AutoSize = True
        Me.btnReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReload.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReload.Location = New System.Drawing.Point(941, 212)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(113, 13)
        Me.btnReload.TabIndex = 20
        Me.btnReload.Text = "RELOAD CATEGORY"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Silver
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(545, 34)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(509, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 19
        Me.SimpleLine2.UseGradient = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(542, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "NEW CATEGORY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(542, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Department"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(804, 172)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(250, 26)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "&Update Category"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbDeptNC
        '
        Me.cmbDeptNC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeptNC.FormattingEnabled = True
        Me.cmbDeptNC.Location = New System.Drawing.Point(545, 65)
        Me.cmbDeptNC.Name = "cmbDeptNC"
        Me.cmbDeptNC.Size = New System.Drawing.Size(250, 21)
        Me.cmbDeptNC.TabIndex = 10
        '
        'cmbSCat3NC
        '
        Me.cmbSCat3NC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat3NC.FormattingEnabled = True
        Me.cmbSCat3NC.Location = New System.Drawing.Point(804, 120)
        Me.cmbSCat3NC.Name = "cmbSCat3NC"
        Me.cmbSCat3NC.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat3NC.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(801, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sub Category - 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(801, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Sub Category - 3"
        '
        'cmbSCat1NC
        '
        Me.cmbSCat1NC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat1NC.FormattingEnabled = True
        Me.cmbSCat1NC.Location = New System.Drawing.Point(804, 65)
        Me.cmbSCat1NC.Name = "cmbSCat1NC"
        Me.cmbSCat1NC.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat1NC.TabIndex = 11
        '
        'cmbSCat2NC
        '
        Me.cmbSCat2NC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSCat2NC.FormattingEnabled = True
        Me.cmbSCat2NC.Location = New System.Drawing.Point(545, 120)
        Me.cmbSCat2NC.Name = "cmbSCat2NC"
        Me.cmbSCat2NC.Size = New System.Drawing.Size(250, 21)
        Me.cmbSCat2NC.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(542, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Sub Category - 2"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Silver
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(18, 34)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(509, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 8
        Me.SimpleLine1.UseGradient = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CURRENT CATEGORY"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1150, 258)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(0, 258)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersWidth = 20
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(1150, 221)
        Me.TG.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "PLUCODE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "DEPARTMENT"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "CATEGORY"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "SUB CATEGORY - 1"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 120
        '
        'Column8
        '
        Me.Column8.HeaderText = "SUB CATEGORY - 2"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 120
        '
        'Column9
        '
        Me.Column9.HeaderText = "SUB CATEGORY - 3"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 120
        '
        'Column10
        '
        Me.Column10.HeaderText = "VENDOR"
        Me.Column10.Name = "Column10"
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.Teal
        Me.pnlLoad.Controls.Add(Me.Label11)
        Me.pnlLoad.Location = New System.Drawing.Point(465, 306)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(220, 70)
        Me.pnlLoad.TabIndex = 10
        Me.pnlLoad.Visible = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 50)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Loading, Please be patient..!"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkSUC
        '
        Me.chkSUC.AutoSize = True
        Me.chkSUC.Location = New System.Drawing.Point(277, 216)
        Me.chkSUC.Name = "chkSUC"
        Me.chkSUC.Size = New System.Drawing.Size(144, 17)
        Me.chkSUC.TabIndex = 28
        Me.chkSUC.Text = "Show Updated Category"
        Me.chkSUC.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 212)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 21)
        Me.TextBox1.TabIndex = 29
        '
        'frmCategoryUpdaterNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 479)
        Me.Controls.Add(Me.pnlLoad)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCategoryUpdaterNew"
        Me.Text = "Category Updater"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSCat2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSCat3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnResult As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbDeptNC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat3NC As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbSCat1NC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat2NC As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents btnReload As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents pnlLoad As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbSCat4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat4NC As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkSUC As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
