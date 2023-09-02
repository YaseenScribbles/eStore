<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.MenuBar = New CustomizableStrips.CustomizableMenuStrip()
        Me.MenuAppCtl = New CustomizableStrips.AppearanceControl()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VendorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New CustomizableStrips.CustomizableStatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SBUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SBLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SBDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TStrip = New CustomizableStrips.CustomizableToolStrip()
        Me.TS1 = New System.Windows.Forms.ToolStripLabel()
        Me.TS2 = New System.Windows.Forms.ToolStripLabel()
        Me.TS4 = New System.Windows.Forms.ToolStripLabel()
        Me.TS3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCompany = New System.Windows.Forms.ToolStripLabel()
        Me.pSideBar = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.TStrip.SuspendLayout()
        Me.pSideBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Appearance = Me.MenuAppCtl
        Me.MenuBar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.MasterToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.FavoritesToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(767, 24)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "CustomizableMenuStrip1"
        '
        'MenuAppCtl
        '
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intBackground = -16273
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intBorderHighlight = -13410648
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientBegin = -8294
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientEnd = -22964
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientMiddle = -15500
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intHighlight = -3878683
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intPressedBackground = -98242
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.CheckedAppearance.intSelectedBackground = -98242
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intBorder = -16777088
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intBorderHighlight = -13410648
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientBegin = -98242
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientEnd = -8294
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientMiddle = -20115
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.PressedAppearance.intHighlight = -6771246
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.BorderHighlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorder = -16777088
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorderHighlight = -16777088
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientBegin = -34
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientEnd = -13432
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientMiddle = -7764
        Me.MenuAppCtl.CustomAppearance.ButtonAppearance.SelectedAppearance.intHighlight = -3878683
        Me.MenuAppCtl.CustomAppearance.GripAppearance.intDark = -14204554
        Me.MenuAppCtl.CustomAppearance.GripAppearance.intLight = -1
        Me.MenuAppCtl.CustomAppearance.GripAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Normal.intGradientBegin = -1839105
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Normal.intGradientEnd = -8674080
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Normal.intGradientMiddle = -3415556
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Revealed.intGradientBegin = -3416586
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Revealed.intGradientEnd = -9266217
        Me.MenuAppCtl.CustomAppearance.ImageMarginAppearance.Revealed.intGradientMiddle = -6175239
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intBorder = -16777088
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intPressedGradientBegin = -1839105
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intPressedGradientEnd = -8674080
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intPressedGradientMiddle = -6175239
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intSelected = -4414
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intSelectedGradientBegin = -34
        Me.MenuAppCtl.CustomAppearance.MenuItemAppearance.intSelectedGradientEnd = -13432
        Me.MenuAppCtl.CustomAppearance.MenuStripAppearance.intBorder = -16765546
        Me.MenuAppCtl.CustomAppearance.MenuStripAppearance.intGradientBegin = -6373643
        Me.MenuAppCtl.CustomAppearance.MenuStripAppearance.intGradientEnd = -3876102
        Me.MenuAppCtl.CustomAppearance.OverflowButtonAppearance.intGradientBegin = -8408582
        Me.MenuAppCtl.CustomAppearance.OverflowButtonAppearance.intGradientEnd = -16763503
        Me.MenuAppCtl.CustomAppearance.OverflowButtonAppearance.intGradientMiddle = -11370544
        Me.MenuAppCtl.CustomAppearance.RaftingContainerAppearance.intGradientBegin = -6373643
        Me.MenuAppCtl.CustomAppearance.RaftingContainerAppearance.intGradientEnd = -3876102
        Me.MenuAppCtl.CustomAppearance.SeparatorAppearance.intDark = -9794357
        Me.MenuAppCtl.CustomAppearance.SeparatorAppearance.intLight = -919041
        Me.MenuAppCtl.CustomAppearance.StatusStripAppearance.intGradientBegin = -6373643
        Me.MenuAppCtl.CustomAppearance.StatusStripAppearance.intGradientEnd = -3876102
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intBorder = -12885604
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intContentPanelGradientBegin = -6373643
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intContentPanelGradientEnd = -3876102
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intDropDownBackground = -592138
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intGradientBegin = -1839105
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intGradientEnd = -8674080
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intGradientMiddle = -3415556
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intPanelGradientBegin = -6373643
        Me.MenuAppCtl.CustomAppearance.ToolStripAppearance.intPanelGradientEnd = -3876102
        Me.MenuAppCtl.Preset = CustomizableStrips.AppearanceControl.enumPresetStyles.Custom
        Me.MenuAppCtl.Renderer.RoundedEdges = True
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.UserRightsToolStripMenuItem, Me.ToolStripSeparator4, Me.ChangePasswordToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AdminToolStripMenuItem.Text = "Admi&n"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UsersToolStripMenuItem.Text = "&Users"
        '
        'UserRightsToolStripMenuItem
        '
        Me.UserRightsToolStripMenuItem.Name = "UserRightsToolStripMenuItem"
        Me.UserRightsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UserRightsToolStripMenuItem.Text = "User &Rights"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(167, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.ProductCategoryToolStripMenuItem, Me.SubCategoryToolStripMenuItem, Me.ToolStripSeparator1, Me.VendorsToolStripMenuItem, Me.VendorGroupsToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.ToolStripSeparator2, Me.LocationsToolStripMenuItem, Me.ColorsToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "&Master"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'ProductCategoryToolStripMenuItem
        '
        Me.ProductCategoryToolStripMenuItem.Name = "ProductCategoryToolStripMenuItem"
        Me.ProductCategoryToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ProductCategoryToolStripMenuItem.Text = "Ca&tegory"
        '
        'SubCategoryToolStripMenuItem
        '
        Me.SubCategoryToolStripMenuItem.Name = "SubCategoryToolStripMenuItem"
        Me.SubCategoryToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SubCategoryToolStripMenuItem.Text = "&Sub Category"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'VendorsToolStripMenuItem
        '
        Me.VendorsToolStripMenuItem.Name = "VendorsToolStripMenuItem"
        Me.VendorsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.VendorsToolStripMenuItem.Text = "&Vendors"
        '
        'VendorGroupsToolStripMenuItem
        '
        Me.VendorGroupsToolStripMenuItem.Name = "VendorGroupsToolStripMenuItem"
        Me.VendorGroupsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.VendorGroupsToolStripMenuItem.Text = "&Agency"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CustomersToolStripMenuItem.Text = "&Customers"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        'LocationsToolStripMenuItem
        '
        Me.LocationsToolStripMenuItem.Name = "LocationsToolStripMenuItem"
        Me.LocationsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LocationsToolStripMenuItem.Text = "L&ocations"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ColorsToolStripMenuItem.Text = "Co&lors"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventoryToolStripMenuItem.Text = "&Inventory"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.TransactionsToolStripMenuItem.Text = "&Transactions"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactViewerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "T&ools"
        '
        'ContactViewerToolStripMenuItem
        '
        Me.ContactViewerToolStripMenuItem.Name = "ContactViewerToolStripMenuItem"
        Me.ContactViewerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ContactViewerToolStripMenuItem.Text = "&Contact Viewer"
        '
        'FavoritesToolStripMenuItem
        '
        Me.FavoritesToolStripMenuItem.Name = "FavoritesToolStripMenuItem"
        Me.FavoritesToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FavoritesToolStripMenuItem.Text = "&Favorites"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'StatusBar
        '
        Me.StatusBar.Appearance = Me.MenuAppCtl
        Me.StatusBar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.SBUser, Me.ToolStripStatusLabel3, Me.SBLogin, Me.SBDate})
        Me.StatusBar.Location = New System.Drawing.Point(0, 443)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(767, 23)
        Me.StatusBar.TabIndex = 2
        Me.StatusBar.Text = "CustomizableStatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 18)
        Me.ToolStripStatusLabel1.Text = "User :"
        '
        'SBUser
        '
        Me.SBUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SBUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.SBUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBUser.Name = "SBUser"
        Me.SBUser.Size = New System.Drawing.Size(74, 18)
        Me.SBUser.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(85, 18)
        Me.ToolStripStatusLabel3.Text = "Log In Time :"
        '
        'SBLogin
        '
        Me.SBLogin.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SBLogin.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.SBLogin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBLogin.Name = "SBLogin"
        Me.SBLogin.Size = New System.Drawing.Size(67, 18)
        Me.SBLogin.Text = "15:25:12"
        '
        'SBDate
        '
        Me.SBDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SBDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.SBDate.Name = "SBDate"
        Me.SBDate.Size = New System.Drawing.Size(483, 18)
        Me.SBDate.Spring = True
        Me.SBDate.Text = "ToolStripStatusLabel5"
        Me.SBDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TStrip
        '
        Me.TStrip.Appearance = Me.MenuAppCtl
        Me.TStrip.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS1, Me.TS2, Me.TS4, Me.TS3, Me.lblCompany})
        Me.TStrip.Location = New System.Drawing.Point(0, 24)
        Me.TStrip.Name = "TStrip"
        Me.TStrip.RoundedEdges = True
        Me.TStrip.Size = New System.Drawing.Size(767, 25)
        Me.TStrip.TabIndex = 3
        Me.TStrip.Text = "CustomizableToolStrip1"
        '
        'TS1
        '
        Me.TS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS1.Name = "TS1"
        Me.TS1.Size = New System.Drawing.Size(92, 22)
        Me.TS1.Text = "Location Type :"
        '
        'TS2
        '
        Me.TS2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TS2.Name = "TS2"
        Me.TS2.Size = New System.Drawing.Size(71, 22)
        Me.TS2.Text = "Warehouse"
        '
        'TS4
        '
        Me.TS4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TS4.Name = "TS4"
        Me.TS4.Size = New System.Drawing.Size(102, 22)
        Me.TS4.Text = "ESSA Warehouse"
        '
        'TS3
        '
        Me.TS3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS3.Name = "TS3"
        Me.TS3.Size = New System.Drawing.Size(96, 22)
        Me.TS3.Text = "Location Name :"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = False
        Me.lblCompany.BackColor = System.Drawing.Color.Red
        Me.lblCompany.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(100, 22)
        Me.lblCompany.Text = "Company Name (2016-2017)"
        '
        'pSideBar
        '
        Me.pSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pSideBar.Controls.Add(Me.Label11)
        Me.pSideBar.Controls.Add(Me.Label12)
        Me.pSideBar.Controls.Add(Me.Label13)
        Me.pSideBar.Controls.Add(Me.Label6)
        Me.pSideBar.Controls.Add(Me.Label7)
        Me.pSideBar.Controls.Add(Me.Label8)
        Me.pSideBar.Controls.Add(Me.Label9)
        Me.pSideBar.Controls.Add(Me.Label4)
        Me.pSideBar.Controls.Add(Me.Label5)
        Me.pSideBar.Controls.Add(Me.Label3)
        Me.pSideBar.Controls.Add(Me.Label2)
        Me.pSideBar.Controls.Add(Me.Label1)
        Me.pSideBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pSideBar.Location = New System.Drawing.Point(647, 49)
        Me.pSideBar.Name = "pSideBar"
        Me.pSideBar.Size = New System.Drawing.Size(120, 394)
        Me.pSideBar.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "L : Lable Print"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "D :  Discounts"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 25)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "C : Calculator"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "F9  : Payments"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "F8 : Received"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "F7 : Delivery"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "F6 : Bill Generate"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "F5 : Purchase"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "F4 : Vendors"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "F3 : Category"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "F2 : Products"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shortcuts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 466)
        Me.Controls.Add(Me.pSideBar)
        Me.Controls.Add(Me.TStrip)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmMainScreen"
        Me.Text = "Taqua Store 2.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.TStrip.ResumeLayout(False)
        Me.TStrip.PerformLayout()
        Me.pSideBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuBar As CustomizableStrips.CustomizableMenuStrip
    Friend WithEvents MenuAppCtl As CustomizableStrips.AppearanceControl
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBar As CustomizableStrips.CustomizableStatusStrip
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserRightsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents VendorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SBUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents SBLogin As ToolStripStatusLabel
    Friend WithEvents SBDate As ToolStripStatusLabel
    Friend WithEvents TStrip As CustomizableStrips.CustomizableToolStrip
    Friend WithEvents TS1 As ToolStripLabel
    Friend WithEvents TS2 As ToolStripLabel
    Friend WithEvents TS4 As ToolStripLabel
    Friend WithEvents TS3 As ToolStripLabel
    Friend WithEvents FavoritesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pSideBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCompany As ToolStripLabel
End Class
