<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindowX2
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuBar = New CustomizableStrips.CustomizableMenuStrip()
        Me.MenuAppearance = New CustomizableStrips.AppearanceControl()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SBPanel = New System.Windows.Forms.Panel()
        Me.SBList = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBHead = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.MenuBar.SuspendLayout()
        Me.SBPanel.SuspendLayout()
        CType(Me.SBList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SBHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Appearance = Me.MenuAppearance
        Me.MenuBar.AutoSize = False
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.PURCHASEToolStripMenuItem, Me.TRANSACTIONSToolStripMenuItem, Me.ACCOUNTSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.TOOLSToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(707, 30)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "CustomizableMenuStrip1"
        '
        'MenuAppearance
        '
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intBackground = -16273
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intBorderHighlight = -13410648
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientBegin = -8294
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientEnd = -22964
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientMiddle = -15500
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intHighlight = -3878683
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intPressedBackground = -98242
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.CheckedAppearance.intSelectedBackground = -98242
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intBorder = -16777088
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intBorderHighlight = -13410648
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientBegin = -98242
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientEnd = -8294
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientMiddle = -20115
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.PressedAppearance.intHighlight = -6771246
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.BorderHighlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorder = -16777088
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorderHighlight = -16777088
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientBegin = -34
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientEnd = -13432
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientMiddle = -7764
        Me.MenuAppearance.CustomAppearance.ButtonAppearance.SelectedAppearance.intHighlight = -3878683
        Me.MenuAppearance.CustomAppearance.GripAppearance.intDark = -14204554
        Me.MenuAppearance.CustomAppearance.GripAppearance.intLight = -1
        Me.MenuAppearance.CustomAppearance.GripAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.GradientMiddle = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.intGradientBegin = -1380097
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.intGradientEnd = -1380097
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Normal.intGradientMiddle = -1380097
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.GradientMiddle = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.intGradientBegin = -1380097
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.intGradientEnd = -1380097
        Me.MenuAppearance.CustomAppearance.ImageMarginAppearance.Revealed.intGradientMiddle = -1380097
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intBorder = -1719451
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intPressedGradientBegin = -1380097
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intPressedGradientEnd = -1380097
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intPressedGradientMiddle = -1380097
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intSelected = -133953
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intSelectedGradientBegin = -133953
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.intSelectedGradientEnd = -133953
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.PressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.PressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.PressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.Selected = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.SelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuItemAppearance.SelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intBorder = -6576201
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intGradientBegin = -14591640
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intGradientEnd = -14591640
        Me.MenuAppearance.CustomAppearance.OverflowButtonAppearance.intGradientBegin = -8408582
        Me.MenuAppearance.CustomAppearance.OverflowButtonAppearance.intGradientEnd = -16763503
        Me.MenuAppearance.CustomAppearance.OverflowButtonAppearance.intGradientMiddle = -11370544
        Me.MenuAppearance.CustomAppearance.RaftingContainerAppearance.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.RaftingContainerAppearance.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.RaftingContainerAppearance.intGradientBegin = -4128769
        Me.MenuAppearance.CustomAppearance.RaftingContainerAppearance.intGradientEnd = -4128769
        Me.MenuAppearance.CustomAppearance.SeparatorAppearance.Dark = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.SeparatorAppearance.intDark = -4275253
        Me.MenuAppearance.CustomAppearance.SeparatorAppearance.intLight = -4275253
        Me.MenuAppearance.CustomAppearance.SeparatorAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.StatusStripAppearance.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.StatusStripAppearance.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.StatusStripAppearance.intGradientBegin = -16425319
        Me.MenuAppearance.CustomAppearance.StatusStripAppearance.intGradientEnd = -16425319
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intBorder = -12885604
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intContentPanelGradientBegin = -6373643
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intContentPanelGradientEnd = -3876102
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intDropDownBackground = -592138
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intGradientBegin = -1839105
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intGradientEnd = -8674080
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intGradientMiddle = -3415556
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intPanelGradientBegin = -6373643
        Me.MenuAppearance.CustomAppearance.ToolStripAppearance.intPanelGradientEnd = -3876102
        Me.MenuAppearance.Preset = CustomizableStrips.AppearanceControl.enumPresetStyles.Custom
        Me.MenuAppearance.Renderer.RoundedEdges = True
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MASTERToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.MASTERToolStripMenuItem.Text = "&MASTER"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeyDisplayString = "A"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem1.Text = "&Agents"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeyDisplayString = "V"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem2.Text = "&Vendors"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeyDisplayString = "P"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem3.Text = "&Products"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeyDisplayString = "C"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem4.Text = "&Category"
        '
        'PURCHASEToolStripMenuItem
        '
        Me.PURCHASEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PURCHASEToolStripMenuItem.Name = "PURCHASEToolStripMenuItem"
        Me.PURCHASEToolStripMenuItem.Size = New System.Drawing.Size(78, 26)
        Me.PURCHASEToolStripMenuItem.Text = "&PURCHASE"
        '
        'TRANSACTIONSToolStripMenuItem
        '
        Me.TRANSACTIONSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TRANSACTIONSToolStripMenuItem.Name = "TRANSACTIONSToolStripMenuItem"
        Me.TRANSACTIONSToolStripMenuItem.Size = New System.Drawing.Size(106, 26)
        Me.TRANSACTIONSToolStripMenuItem.Text = "&TRANSACTIONS"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.ACCOUNTSToolStripMenuItem.Text = "&ACCOUNTS"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(68, 26)
        Me.REPORTSToolStripMenuItem.Text = "&REPORTS"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(56, 26)
        Me.TOOLSToolStripMenuItem.Text = "&TOOLS"
        '
        'SBPanel
        '
        Me.SBPanel.Controls.Add(Me.SBList)
        Me.SBPanel.Controls.Add(Me.SBHead)
        Me.SBPanel.Controls.Add(Me.SimpleLine1)
        Me.SBPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SBPanel.Location = New System.Drawing.Point(707, 0)
        Me.SBPanel.Name = "SBPanel"
        Me.SBPanel.Size = New System.Drawing.Size(135, 532)
        Me.SBPanel.TabIndex = 2
        '
        'SBList
        '
        Me.SBList.AllowUserToAddRows = False
        Me.SBList.AllowUserToDeleteRows = False
        Me.SBList.AllowUserToResizeColumns = False
        Me.SBList.AllowUserToResizeRows = False
        Me.SBList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SBList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SBList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SBList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SBList.ColumnHeadersVisible = False
        Me.SBList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column3, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SBList.DefaultCellStyle = DataGridViewCellStyle3
        Me.SBList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SBList.EnableHeadersVisualStyles = False
        Me.SBList.GridColor = System.Drawing.Color.Black
        Me.SBList.Location = New System.Drawing.Point(1, 29)
        Me.SBList.MultiSelect = False
        Me.SBList.Name = "SBList"
        Me.SBList.ReadOnly = True
        Me.SBList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SBList.RowHeadersVisible = False
        Me.SBList.RowTemplate.Height = 28
        Me.SBList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SBList.Size = New System.Drawing.Size(134, 503)
        Me.SBList.TabIndex = 12
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 5
        '
        'Column1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 28
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 10
        '
        'Column2
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 91
        '
        'SBHead
        '
        Me.SBHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.SBHead.Controls.Add(Me.Label2)
        Me.SBHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.SBHead.Location = New System.Drawing.Point(1, 0)
        Me.SBHead.Name = "SBHead"
        Me.SBHead.Size = New System.Drawing.Size(134, 29)
        Me.SBHead.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Quick Launch"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Black
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(1, 532)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Vertical
        Me.SimpleLine1.TabIndex = 3
        Me.SimpleLine1.UseGradient = False
        '
        'pMain
        '
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 30)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(707, 502)
        Me.pMain.TabIndex = 3
        '
        'MainWindowX2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 532)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.SBPanel)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainWindowX2"
        Me.Text = "MainWindowX2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.SBPanel.ResumeLayout(False)
        CType(Me.SBList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SBHead.ResumeLayout(False)
        Me.SBHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuBar As CustomizableStrips.CustomizableMenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PURCHASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAppearance As CustomizableStrips.AppearanceControl
    Friend WithEvents SBPanel As System.Windows.Forms.Panel
    Friend WithEvents SBList As System.Windows.Forms.DataGridView
    Friend WithEvents SBHead As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
