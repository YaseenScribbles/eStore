<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseSettings
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.txtShopCode = New System.Windows.Forms.TextBox()
        Me.txtVersionPath = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSQLServer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrinterName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.pnlSelectPrinter = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.cmbPrinter = New System.Windows.Forms.ComboBox()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlSelectPrinter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnClose.Location = New System.Drawing.Point(427, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 27)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.pnlSelectPrinter)
        Me.Panel1.Controls.Add(Me.txtPrinterName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.SimpleLine2)
        Me.Panel1.Controls.Add(Me.txtShopCode)
        Me.Panel1.Controls.Add(Me.txtVersionPath)
        Me.Panel1.Controls.Add(Me.txtDatabase)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtSQLServer)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 460)
        Me.Panel1.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(357, 406)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 35)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(19, 387)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(430, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 17
        Me.SimpleLine2.UseGradient = False
        '
        'txtShopCode
        '
        Me.txtShopCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopCode.ForeColor = System.Drawing.Color.DimGray
        Me.txtShopCode.Location = New System.Drawing.Point(125, 294)
        Me.txtShopCode.Name = "txtShopCode"
        Me.txtShopCode.Size = New System.Drawing.Size(77, 27)
        Me.txtShopCode.TabIndex = 5
        Me.txtShopCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVersionPath
        '
        Me.txtVersionPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersionPath.ForeColor = System.Drawing.Color.DimGray
        Me.txtVersionPath.Location = New System.Drawing.Point(125, 252)
        Me.txtVersionPath.Name = "txtVersionPath"
        Me.txtVersionPath.Size = New System.Drawing.Size(324, 27)
        Me.txtVersionPath.TabIndex = 4
        '
        'txtDatabase
        '
        Me.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatabase.ForeColor = System.Drawing.Color.DimGray
        Me.txtDatabase.Location = New System.Drawing.Point(125, 207)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(324, 27)
        Me.txtDatabase.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(125, 162)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(324, 27)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(125, 117)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(324, 27)
        Me.txtUsername.TabIndex = 1
        '
        'txtSQLServer
        '
        Me.txtSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQLServer.ForeColor = System.Drawing.Color.DimGray
        Me.txtSQLServer.Location = New System.Drawing.Point(125, 72)
        Me.txtSQLServer.Name = "txtSQLServer"
        Me.txtSQLServer.Size = New System.Drawing.Size(324, 27)
        Me.txtSQLServer.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Shop code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "FTP Version"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SQL Server"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 45)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = " Database Settings"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(476, 472)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TTip
        '
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTip.ToolTipTitle = "Taqua Store"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "* Printer Name"
        '
        'txtPrinterName
        '
        Me.txtPrinterName.BackColor = System.Drawing.Color.White
        Me.txtPrinterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrinterName.ForeColor = System.Drawing.Color.DimGray
        Me.txtPrinterName.Location = New System.Drawing.Point(125, 336)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.ReadOnly = True
        Me.txtPrinterName.Size = New System.Drawing.Size(324, 27)
        Me.txtPrinterName.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoSize = True
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(376, 315)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(77, 13)
        Me.btnBrowse.TabIndex = 20
        Me.btnBrowse.Text = "Browse Printer"
        '
        'pnlSelectPrinter
        '
        Me.pnlSelectPrinter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSelectPrinter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelectPrinter.Controls.Add(Me.btnHide)
        Me.pnlSelectPrinter.Controls.Add(Me.Label11)
        Me.pnlSelectPrinter.Controls.Add(Me.btnPick)
        Me.pnlSelectPrinter.Controls.Add(Me.cmbPrinter)
        Me.pnlSelectPrinter.Controls.Add(Me.SimpleLine1)
        Me.pnlSelectPrinter.Controls.Add(Me.Label10)
        Me.pnlSelectPrinter.Location = New System.Drawing.Point(44, 131)
        Me.pnlSelectPrinter.Name = "pnlSelectPrinter"
        Me.pnlSelectPrinter.Size = New System.Drawing.Size(376, 198)
        Me.pnlSelectPrinter.TabIndex = 21
        Me.pnlSelectPrinter.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Select Printer"
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
        Me.SimpleLine1.Location = New System.Drawing.Point(22, 47)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(335, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 18
        Me.SimpleLine1.UseGradient = False
        '
        'cmbPrinter
        '
        Me.cmbPrinter.FormattingEnabled = True
        Me.cmbPrinter.Location = New System.Drawing.Point(22, 88)
        Me.cmbPrinter.Name = "cmbPrinter"
        Me.cmbPrinter.Size = New System.Drawing.Size(335, 28)
        Me.cmbPrinter.TabIndex = 0
        '
        'btnPick
        '
        Me.btnPick.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnPick.FlatAppearance.BorderSize = 0
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPick.ForeColor = System.Drawing.Color.White
        Me.btnPick.Location = New System.Drawing.Point(265, 138)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(92, 35)
        Me.btnPick.TabIndex = 1
        Me.btnPick.Text = "&Pick"
        Me.btnPick.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "List of Printers"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.Black
        Me.btnHide.Location = New System.Drawing.Point(343, -1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 28)
        Me.btnHide.TabIndex = 22
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "* Label Printer"
        '
        'DatabaseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DatabaseSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlSelectPrinter.ResumeLayout(False)
        Me.pnlSelectPrinter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtShopCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtSQLServer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtVersionPath As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrinterName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents pnlSelectPrinter As System.Windows.Forms.Panel
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents cmbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
