<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindowX3
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
        Me.WelcomeAdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.Panel()
        Me.SBNow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GapT = New System.Windows.Forms.Panel()
        Me.GapB = New System.Windows.Forms.Panel()
        Me.GapR = New System.Windows.Forms.Panel()
        Me.GapL = New System.Windows.Forms.Panel()
        Me.SPMain = New System.Windows.Forms.SplitContainer()
        Me.SBPanel = New System.Windows.Forms.Panel()
        Me.SBList = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBHead = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineSBR = New simpleline.assemblies.simpleLine()
        Me.LineSBL = New simpleline.assemblies.simpleLine()
        Me.LineSBT = New simpleline.assemblies.simpleLine()
        Me.LineSBB = New simpleline.assemblies.simpleLine()
        Me.LineMPB = New simpleline.assemblies.simpleLine()
        Me.tabMain = New Dotnetrix.Controls.TabControlEX()
        Me.LineMPT = New simpleline.assemblies.simpleLine()
        Me.LineMPL = New simpleline.assemblies.simpleLine()
        Me.LineMPR = New simpleline.assemblies.simpleLine()
        Me.TabHead = New TaquaStore.ucTabHeader()
        Me.MenuBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        CType(Me.SPMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SPMain.Panel1.SuspendLayout()
        Me.SPMain.Panel2.SuspendLayout()
        Me.SPMain.SuspendLayout()
        Me.SBPanel.SuspendLayout()
        CType(Me.SBList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SBHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Appearance = Me.MenuAppearance
        Me.MenuBar.AutoSize = False
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.PURCHASEToolStripMenuItem, Me.TRANSACTIONSToolStripMenuItem, Me.ACCOUNTSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.TOOLSToolStripMenuItem, Me.WelcomeAdministratorToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1344, 30)
        Me.MenuBar.TabIndex = 0
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
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.GradientBegin = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intBorder = -6576201
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intGradientBegin = -2696215
        Me.MenuAppearance.CustomAppearance.MenuStripAppearance.intGradientEnd = -2696215
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
        Me.PURCHASEToolStripMenuItem.Name = "PURCHASEToolStripMenuItem"
        Me.PURCHASEToolStripMenuItem.Size = New System.Drawing.Size(78, 26)
        Me.PURCHASEToolStripMenuItem.Text = "&PURCHASE"
        '
        'TRANSACTIONSToolStripMenuItem
        '
        Me.TRANSACTIONSToolStripMenuItem.Name = "TRANSACTIONSToolStripMenuItem"
        Me.TRANSACTIONSToolStripMenuItem.Size = New System.Drawing.Size(106, 26)
        Me.TRANSACTIONSToolStripMenuItem.Text = "&TRANSACTIONS"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.ACCOUNTSToolStripMenuItem.Text = "&ACCOUNTS"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(68, 26)
        Me.REPORTSToolStripMenuItem.Text = "&REPORTS"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(56, 26)
        Me.TOOLSToolStripMenuItem.Text = "&TOOLS"
        '
        'WelcomeAdministratorToolStripMenuItem
        '
        Me.WelcomeAdministratorToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.WelcomeAdministratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.WelcomeAdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignOutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator1, Me.UserManagementToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.WelcomeAdministratorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeAdministratorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.WelcomeAdministratorToolStripMenuItem.Name = "WelcomeAdministratorToolStripMenuItem"
        Me.WelcomeAdministratorToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.WelcomeAdministratorToolStripMenuItem.Text = "  Welcome, Administrator"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SignOutToolStripMenuItem.Text = "&Sign Out"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UserManagementToolStripMenuItem.Text = "User Manager"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusBar.Controls.Add(Me.SBNow)
        Me.StatusBar.Controls.Add(Me.Label1)
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar.Location = New System.Drawing.Point(0, 720)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1344, 30)
        Me.StatusBar.TabIndex = 1
        '
        'SBNow
        '
        Me.SBNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SBNow.ForeColor = System.Drawing.Color.White
        Me.SBNow.Location = New System.Drawing.Point(1086, 8)
        Me.SBNow.Name = "SBNow"
        Me.SBNow.Size = New System.Drawing.Size(250, 14)
        Me.SBNow.TabIndex = 1
        Me.SBNow.Text = "Ready"
        Me.SBNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ready"
        '
        'GapT
        '
        Me.GapT.Dock = System.Windows.Forms.DockStyle.Top
        Me.GapT.Location = New System.Drawing.Point(0, 30)
        Me.GapT.Name = "GapT"
        Me.GapT.Size = New System.Drawing.Size(1344, 8)
        Me.GapT.TabIndex = 2
        '
        'GapB
        '
        Me.GapB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GapB.Location = New System.Drawing.Point(0, 712)
        Me.GapB.Name = "GapB"
        Me.GapB.Size = New System.Drawing.Size(1344, 8)
        Me.GapB.TabIndex = 3
        '
        'GapR
        '
        Me.GapR.Dock = System.Windows.Forms.DockStyle.Right
        Me.GapR.Location = New System.Drawing.Point(1336, 38)
        Me.GapR.Name = "GapR"
        Me.GapR.Size = New System.Drawing.Size(8, 674)
        Me.GapR.TabIndex = 4
        '
        'GapL
        '
        Me.GapL.Dock = System.Windows.Forms.DockStyle.Left
        Me.GapL.Location = New System.Drawing.Point(0, 38)
        Me.GapL.Name = "GapL"
        Me.GapL.Size = New System.Drawing.Size(8, 674)
        Me.GapL.TabIndex = 5
        '
        'SPMain
        '
        Me.SPMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SPMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SPMain.Location = New System.Drawing.Point(8, 38)
        Me.SPMain.Name = "SPMain"
        '
        'SPMain.Panel1
        '
        Me.SPMain.Panel1.Controls.Add(Me.SBPanel)
        Me.SPMain.Panel1.Controls.Add(Me.LineSBR)
        Me.SPMain.Panel1.Controls.Add(Me.LineSBL)
        Me.SPMain.Panel1.Controls.Add(Me.LineSBT)
        Me.SPMain.Panel1.Controls.Add(Me.LineSBB)
        '
        'SPMain.Panel2
        '
        Me.SPMain.Panel2.Controls.Add(Me.LineMPB)
        Me.SPMain.Panel2.Controls.Add(Me.tabMain)
        Me.SPMain.Panel2.Controls.Add(Me.TabHead)
        Me.SPMain.Panel2.Controls.Add(Me.LineMPT)
        Me.SPMain.Panel2.Controls.Add(Me.LineMPL)
        Me.SPMain.Panel2.Controls.Add(Me.LineMPR)
        Me.SPMain.Size = New System.Drawing.Size(1328, 674)
        Me.SPMain.SplitterDistance = 160
        Me.SPMain.SplitterWidth = 8
        Me.SPMain.TabIndex = 6
        '
        'SBPanel
        '
        Me.SBPanel.Controls.Add(Me.SBList)
        Me.SBPanel.Controls.Add(Me.SBHead)
        Me.SBPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SBPanel.Location = New System.Drawing.Point(1, 1)
        Me.SBPanel.Name = "SBPanel"
        Me.SBPanel.Size = New System.Drawing.Size(158, 672)
        Me.SBPanel.TabIndex = 0
        '
        'SBList
        '
        Me.SBList.AllowUserToAddRows = False
        Me.SBList.AllowUserToDeleteRows = False
        Me.SBList.AllowUserToResizeColumns = False
        Me.SBList.AllowUserToResizeRows = False
        Me.SBList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SBList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SBList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SBList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SBList.ColumnHeadersVisible = False
        Me.SBList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column3, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SBList.DefaultCellStyle = DataGridViewCellStyle3
        Me.SBList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SBList.EnableHeadersVisualStyles = False
        Me.SBList.GridColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.SBList.Location = New System.Drawing.Point(0, 30)
        Me.SBList.MultiSelect = False
        Me.SBList.Name = "SBList"
        Me.SBList.ReadOnly = True
        Me.SBList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SBList.RowHeadersVisible = False
        Me.SBList.RowTemplate.Height = 28
        Me.SBList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SBList.Size = New System.Drawing.Size(158, 642)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
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
        Me.Column2.Width = 115
        '
        'SBHead
        '
        Me.SBHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.SBHead.Controls.Add(Me.Label2)
        Me.SBHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.SBHead.Location = New System.Drawing.Point(0, 0)
        Me.SBHead.Name = "SBHead"
        Me.SBHead.Size = New System.Drawing.Size(158, 30)
        Me.SBHead.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Quick Launch"
        '
        'LineSBR
        '
        Me.LineSBR.Dock = System.Windows.Forms.DockStyle.Right
        Me.LineSBR.FillColor = System.Drawing.Color.Transparent
        Me.LineSBR.FitToParent = False
        Me.LineSBR.Gradient = System.Drawing.Color.Transparent
        Me.LineSBR.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineSBR.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineSBR.LineWidth = 1
        Me.LineSBR.Location = New System.Drawing.Point(159, 1)
        Me.LineSBR.Name = "LineSBR"
        Me.LineSBR.Size = New System.Drawing.Size(1, 672)
        Me.LineSBR.Style = simpleline.assemblies.LineStyle.Vertical
        Me.LineSBR.TabIndex = 3
        Me.LineSBR.UseGradient = False
        '
        'LineSBL
        '
        Me.LineSBL.Dock = System.Windows.Forms.DockStyle.Left
        Me.LineSBL.FillColor = System.Drawing.Color.Transparent
        Me.LineSBL.FitToParent = False
        Me.LineSBL.Gradient = System.Drawing.Color.Transparent
        Me.LineSBL.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineSBL.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineSBL.LineWidth = 1
        Me.LineSBL.Location = New System.Drawing.Point(0, 1)
        Me.LineSBL.Name = "LineSBL"
        Me.LineSBL.Size = New System.Drawing.Size(1, 672)
        Me.LineSBL.Style = simpleline.assemblies.LineStyle.Vertical
        Me.LineSBL.TabIndex = 4
        Me.LineSBL.UseGradient = False
        '
        'LineSBT
        '
        Me.LineSBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.LineSBT.FillColor = System.Drawing.Color.Transparent
        Me.LineSBT.FitToParent = False
        Me.LineSBT.Gradient = System.Drawing.Color.Transparent
        Me.LineSBT.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineSBT.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineSBT.LineWidth = 1
        Me.LineSBT.Location = New System.Drawing.Point(0, 0)
        Me.LineSBT.Name = "LineSBT"
        Me.LineSBT.Size = New System.Drawing.Size(160, 1)
        Me.LineSBT.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.LineSBT.TabIndex = 1
        Me.LineSBT.UseGradient = False
        '
        'LineSBB
        '
        Me.LineSBB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LineSBB.FillColor = System.Drawing.Color.Transparent
        Me.LineSBB.FitToParent = False
        Me.LineSBB.Gradient = System.Drawing.Color.Transparent
        Me.LineSBB.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineSBB.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineSBB.LineWidth = 1
        Me.LineSBB.Location = New System.Drawing.Point(0, 673)
        Me.LineSBB.Name = "LineSBB"
        Me.LineSBB.Size = New System.Drawing.Size(160, 1)
        Me.LineSBB.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.LineSBB.TabIndex = 2
        Me.LineSBB.UseGradient = False
        '
        'LineMPB
        '
        Me.LineMPB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LineMPB.FillColor = System.Drawing.Color.Transparent
        Me.LineMPB.FitToParent = False
        Me.LineMPB.Gradient = System.Drawing.Color.Transparent
        Me.LineMPB.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineMPB.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineMPB.LineWidth = 1
        Me.LineMPB.Location = New System.Drawing.Point(1, 673)
        Me.LineMPB.Name = "LineMPB"
        Me.LineMPB.Size = New System.Drawing.Size(1158, 1)
        Me.LineMPB.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.LineMPB.TabIndex = 24
        Me.LineMPB.UseGradient = False
        '
        'tabMain
        '
        Me.tabMain.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab
        Me.tabMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FlatBorderColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(1, 32)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1158, 642)
        Me.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMain.TabColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tabMain.TabIndex = 22
        Me.tabMain.UseVisualStyles = False
        '
        'LineMPT
        '
        Me.LineMPT.Dock = System.Windows.Forms.DockStyle.Top
        Me.LineMPT.FillColor = System.Drawing.Color.Transparent
        Me.LineMPT.FitToParent = False
        Me.LineMPT.Gradient = System.Drawing.Color.Transparent
        Me.LineMPT.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineMPT.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineMPT.LineWidth = 1
        Me.LineMPT.Location = New System.Drawing.Point(1, 0)
        Me.LineMPT.Name = "LineMPT"
        Me.LineMPT.Size = New System.Drawing.Size(1158, 1)
        Me.LineMPT.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.LineMPT.TabIndex = 23
        Me.LineMPT.UseGradient = False
        '
        'LineMPL
        '
        Me.LineMPL.Dock = System.Windows.Forms.DockStyle.Left
        Me.LineMPL.FillColor = System.Drawing.Color.Transparent
        Me.LineMPL.FitToParent = False
        Me.LineMPL.Gradient = System.Drawing.Color.Transparent
        Me.LineMPL.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineMPL.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineMPL.LineWidth = 1
        Me.LineMPL.Location = New System.Drawing.Point(0, 0)
        Me.LineMPL.Name = "LineMPL"
        Me.LineMPL.Size = New System.Drawing.Size(1, 674)
        Me.LineMPL.Style = simpleline.assemblies.LineStyle.Vertical
        Me.LineMPL.TabIndex = 25
        Me.LineMPL.UseGradient = False
        '
        'LineMPR
        '
        Me.LineMPR.Dock = System.Windows.Forms.DockStyle.Right
        Me.LineMPR.FillColor = System.Drawing.Color.Transparent
        Me.LineMPR.FitToParent = False
        Me.LineMPR.Gradient = System.Drawing.Color.Transparent
        Me.LineMPR.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.LineMPR.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LineMPR.LineWidth = 1
        Me.LineMPR.Location = New System.Drawing.Point(1159, 0)
        Me.LineMPR.Name = "LineMPR"
        Me.LineMPR.Size = New System.Drawing.Size(1, 674)
        Me.LineMPR.Style = simpleline.assemblies.LineStyle.Vertical
        Me.LineMPR.TabIndex = 26
        Me.LineMPR.UseGradient = False
        '
        'TabHead
        '
        Me.TabHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TabHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabHead.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabHead.Location = New System.Drawing.Point(1, 1)
        Me.TabHead.Name = "TabHead"
        Me.TabHead.Size = New System.Drawing.Size(1158, 31)
        Me.TabHead.TabFocusBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TabHead.TabFocusForeColor = System.Drawing.Color.Black
        Me.TabHead.TabHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TabHead.TabIndex = 0
        Me.TabHead.TabLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TabHead.TabNormalBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TabHead.TabNormalForeColor = System.Drawing.Color.White
        '
        'MainWindowX3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 750)
        Me.Controls.Add(Me.SPMain)
        Me.Controls.Add(Me.GapL)
        Me.Controls.Add(Me.GapR)
        Me.Controls.Add(Me.GapB)
        Me.Controls.Add(Me.GapT)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "MainWindowX3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taqua Store - ESSA WAREHOUSE, TIRUUR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.SPMain.Panel1.ResumeLayout(False)
        Me.SPMain.Panel2.ResumeLayout(False)
        CType(Me.SPMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SPMain.ResumeLayout(False)
        Me.SBPanel.ResumeLayout(False)
        CType(Me.SBList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SBHead.ResumeLayout(False)
        Me.SBHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuBar As CustomizableStrips.CustomizableMenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PURCHASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAppearance As CustomizableStrips.AppearanceControl
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBar As System.Windows.Forms.Panel
    Friend WithEvents GapT As System.Windows.Forms.Panel
    Friend WithEvents GapB As System.Windows.Forms.Panel
    Friend WithEvents GapR As System.Windows.Forms.Panel
    Friend WithEvents GapL As System.Windows.Forms.Panel
    Friend WithEvents SPMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SBPanel As System.Windows.Forms.Panel
    Friend WithEvents SBList As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBHead As System.Windows.Forms.Panel
    Friend WithEvents LineSBL As simpleline.assemblies.simpleLine
    Friend WithEvents LineSBR As simpleline.assemblies.simpleLine
    Friend WithEvents LineSBB As simpleline.assemblies.simpleLine
    Friend WithEvents LineSBT As simpleline.assemblies.simpleLine
    Friend WithEvents tabMain As Dotnetrix.Controls.TabControlEX
    Friend WithEvents TabHead As TaquaStore.ucTabHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SBNow As System.Windows.Forms.Label
    Friend WithEvents LineMPL As simpleline.assemblies.simpleLine
    Friend WithEvents LineMPB As simpleline.assemblies.simpleLine
    Friend WithEvents LineMPT As simpleline.assemblies.simpleLine
    Friend WithEvents LineMPR As simpleline.assemblies.simpleLine
    Friend WithEvents WelcomeAdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
