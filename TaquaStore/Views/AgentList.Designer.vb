<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgentList
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpleLine5 = New simpleline.assemblies.simpleLine()
        Me.SimpleLine4 = New simpleline.assemblies.simpleLine()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SimpleLine7 = New simpleline.assemblies.simpleLine()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.SimpleLine8 = New simpleline.assemblies.simpleLine()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SimpleLine9 = New simpleline.assemblies.simpleLine()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.pSearch = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.LstSch = New TaquaStore.cListBox()
        Me.txtfType = New TaquaStore.cTextBox()
        Me.txtFWord = New TaquaStore.cTextBox()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pSearch.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(108, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Total Vendors :"
        '
        'SimpleLine5
        '
        Me.SimpleLine5.Enabled = False
        Me.SimpleLine5.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine5.FitToParent = True
        Me.SimpleLine5.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine5.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine5.LineColor = System.Drawing.Color.Black
        Me.SimpleLine5.LineWidth = 2
        Me.SimpleLine5.Location = New System.Drawing.Point(0, 26)
        Me.SimpleLine5.Name = "SimpleLine5"
        Me.SimpleLine5.Size = New System.Drawing.Size(1147, 2)
        Me.SimpleLine5.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine5.TabIndex = 58
        Me.SimpleLine5.UseGradient = False
        '
        'SimpleLine4
        '
        Me.SimpleLine4.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleLine4.Enabled = False
        Me.SimpleLine4.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine4.FitToParent = False
        Me.SimpleLine4.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine4.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine4.LineColor = System.Drawing.Color.Black
        Me.SimpleLine4.LineWidth = 1
        Me.SimpleLine4.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLine4.Name = "SimpleLine4"
        Me.SimpleLine4.Size = New System.Drawing.Size(1147, 1)
        Me.SimpleLine4.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine4.TabIndex = 57
        Me.SimpleLine4.UseGradient = False
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle2
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.Black
        Me.TG.Location = New System.Drawing.Point(0, 148)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 23
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(1147, 276)
        Me.TG.TabIndex = 65
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.SimpleLine7)
        Me.Panel3.Controls.Add(Me.btnFilter)
        Me.Panel3.Controls.Add(Me.SimpleLine8)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.SimpleLine9)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1147, 29)
        Me.Panel3.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(213, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 29)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "X : E&XIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SimpleLine7
        '
        Me.SimpleLine7.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleLine7.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine7.FitToParent = False
        Me.SimpleLine7.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine7.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine7.LineColor = System.Drawing.Color.Black
        Me.SimpleLine7.LineWidth = 1
        Me.SimpleLine7.Location = New System.Drawing.Point(212, 0)
        Me.SimpleLine7.Name = "SimpleLine7"
        Me.SimpleLine7.Size = New System.Drawing.Size(1, 29)
        Me.SimpleLine7.Style = simpleline.assemblies.LineStyle.Vertical
        Me.SimpleLine7.TabIndex = 14
        Me.SimpleLine7.UseGradient = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(142, 0)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(70, 29)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "F : &Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'SimpleLine8
        '
        Me.SimpleLine8.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleLine8.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine8.FitToParent = False
        Me.SimpleLine8.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine8.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine8.LineColor = System.Drawing.Color.Black
        Me.SimpleLine8.LineWidth = 1
        Me.SimpleLine8.Location = New System.Drawing.Point(141, 0)
        Me.SimpleLine8.Name = "SimpleLine8"
        Me.SimpleLine8.Size = New System.Drawing.Size(1, 29)
        Me.SimpleLine8.Style = simpleline.assemblies.LineStyle.Vertical
        Me.SimpleLine8.TabIndex = 12
        Me.SimpleLine8.UseGradient = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(71, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "P : Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SimpleLine9
        '
        Me.SimpleLine9.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleLine9.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine9.FitToParent = False
        Me.SimpleLine9.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine9.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine9.LineColor = System.Drawing.Color.Black
        Me.SimpleLine9.LineWidth = 1
        Me.SimpleLine9.Location = New System.Drawing.Point(70, 0)
        Me.SimpleLine9.Name = "SimpleLine9"
        Me.SimpleLine9.Size = New System.Drawing.Size(1, 29)
        Me.SimpleLine9.Style = simpleline.assemblies.LineStyle.Vertical
        Me.SimpleLine9.TabIndex = 11
        Me.SimpleLine9.UseGradient = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 29)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "E : &Export"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.SimpleLine5)
        Me.Panel2.Controls.Add(Me.SimpleLine4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1147, 70)
        Me.Panel2.TabIndex = 64
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Black
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(0, 116)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(1147, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 61
        Me.SimpleLine2.UseGradient = False
        '
        'SimpleLine3
        '
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(17, 37)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(454, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 56
        Me.SimpleLine3.UseGradient = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Search Field :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(13, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(102, 14)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = "SEARCH BY WORD"
        '
        'pSearch
        '
        Me.pSearch.Controls.Add(Me.Label28)
        Me.pSearch.Controls.Add(Me.txtfType)
        Me.pSearch.Controls.Add(Me.SimpleLine3)
        Me.pSearch.Controls.Add(Me.Label1)
        Me.pSearch.Controls.Add(Me.txtFWord)
        Me.pSearch.Controls.Add(Me.Label2)
        Me.pSearch.Location = New System.Drawing.Point(374, 4)
        Me.pSearch.Name = "pSearch"
        Me.pSearch.Size = New System.Drawing.Size(487, 109)
        Me.pSearch.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Search Word:"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlSearch.Controls.Add(Me.pSearch)
        Me.pnlSearch.Controls.Add(Me.SimpleLine2)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 31)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1147, 117)
        Me.pnlSearch.TabIndex = 63
        Me.pnlSearch.Visible = False
        '
        'lblHead
        '
        Me.lblHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHead.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.Color.Black
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(1147, 31)
        Me.lblHead.TabIndex = 62
        Me.lblHead.Text = "List of Agents"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstSch
        '
        Me.LstSch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstSch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSch.ListHeader = "Search By"
        Me.LstSch.Location = New System.Drawing.Point(391, 132)
        Me.LstSch.Name = "LstSch"
        Me.LstSch.Size = New System.Drawing.Size(127, 264)
        Me.LstSch.TabIndex = 66
        Me.LstSch.Visible = False
        '
        'txtfType
        '
        Me.txtfType.AcceptBackwards = False
        Me.txtfType.AcceptEmptyWords = False
        Me.txtfType.BackColor = System.Drawing.Color.White
        Me.txtfType.BorderColor = System.Drawing.Color.DimGray
        Me.txtfType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfType.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtfType.FocusBackColor = System.Drawing.Color.Black
        Me.txtfType.FocusBorderColor = System.Drawing.Color.Black
        Me.txtfType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfType.Location = New System.Drawing.Point(17, 71)
        Me.txtfType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfType.MaxLength = 6
        Me.txtfType.Name = "txtfType"
        Me.txtfType.NormalBackColor = System.Drawing.Color.White
        Me.txtfType.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtfType.Size = New System.Drawing.Size(127, 21)
        Me.txtfType.TabIndex = 0
        '
        'txtFWord
        '
        Me.txtFWord.AcceptBackwards = False
        Me.txtFWord.AcceptEmptyWords = False
        Me.txtFWord.BackColor = System.Drawing.Color.White
        Me.txtFWord.BorderColor = System.Drawing.Color.DimGray
        Me.txtFWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFWord.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtFWord.FocusBackColor = System.Drawing.Color.Black
        Me.txtFWord.FocusBorderColor = System.Drawing.Color.Black
        Me.txtFWord.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFWord.Location = New System.Drawing.Point(150, 71)
        Me.txtFWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFWord.MaxLength = 6
        Me.txtFWord.Name = "txtFWord"
        Me.txtFWord.NormalBackColor = System.Drawing.Color.White
        Me.txtFWord.NormalBorderColor = System.Drawing.Color.DimGray
        Me.txtFWord.Size = New System.Drawing.Size(321, 21)
        Me.txtFWord.TabIndex = 1
        '
        'AgentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 494)
        Me.Controls.Add(Me.LstSch)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.lblHead)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AgentList"
        Me.Text = "AgentList"
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pSearch.ResumeLayout(False)
        Me.pSearch.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstSch As TaquaStore.cListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine5 As simpleline.assemblies.simpleLine
    Friend WithEvents SimpleLine4 As simpleline.assemblies.simpleLine
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SimpleLine7 As simpleline.assemblies.simpleLine
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents SimpleLine8 As simpleline.assemblies.simpleLine
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SimpleLine9 As simpleline.assemblies.simpleLine
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFWord As TaquaStore.cTextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtfType As TaquaStore.cTextBox
    Friend WithEvents pSearch As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblHead As System.Windows.Forms.Label
End Class
