<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSearch
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSCat3 = New System.Windows.Forms.TextBox()
        Me.txtSCat2 = New System.Windows.Forms.TextBox()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.txtSCat1 = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.pnlLOG = New System.Windows.Forms.Panel()
        Me.TGGrn = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlLoading = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLOG.SuspendLayout()
        CType(Me.TGGrn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(767, 39)
        Me.Panel3.TabIndex = 24
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = " Product Search"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(694, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtSCat3)
        Me.Panel4.Controls.Add(Me.txtSCat2)
        Me.Panel4.Controls.Add(Me.txtVendor)
        Me.Panel4.Controls.Add(Me.txtSCat1)
        Me.Panel4.Controls.Add(Me.txtCat)
        Me.Panel4.Controls.Add(Me.txtName)
        Me.Panel4.Controls.Add(Me.txtCode)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(767, 136)
        Me.Panel4.TabIndex = 25
        '
        'txtSCat3
        '
        Me.txtSCat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCat3.Location = New System.Drawing.Point(181, 99)
        Me.txtSCat3.Name = "txtSCat3"
        Me.txtSCat3.Size = New System.Drawing.Size(164, 22)
        Me.txtSCat3.TabIndex = 3
        '
        'txtSCat2
        '
        Me.txtSCat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCat2.Location = New System.Drawing.Point(11, 99)
        Me.txtSCat2.Name = "txtSCat2"
        Me.txtSCat2.Size = New System.Drawing.Size(164, 22)
        Me.txtSCat2.TabIndex = 2
        '
        'txtVendor
        '
        Me.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendor.Location = New System.Drawing.Point(351, 51)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(293, 22)
        Me.txtVendor.TabIndex = 3
        '
        'txtSCat1
        '
        Me.txtSCat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCat1.Location = New System.Drawing.Point(181, 51)
        Me.txtSCat1.Name = "txtSCat1"
        Me.txtSCat1.Size = New System.Drawing.Size(164, 22)
        Me.txtSCat1.TabIndex = 1
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.Location = New System.Drawing.Point(11, 51)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(164, 22)
        Me.txtCat.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(447, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(197, 22)
        Me.txtName.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(351, 99)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(89, 22)
        Me.txtCode.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "SUBCATEGORY - 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SUBCATEGORY - 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SUBCATEGORY - 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "VENDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PRODUCT DESCRIPTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PLUCODE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(9, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(118, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "CATEGORY FILTER"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TG, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 175)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 301)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle6
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(11, 3)
        Me.TG.MultiSelect = False
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(753, 295)
        Me.TG.TabIndex = 0
        Me.TG.Tag = "1"
        '
        'pnlLOG
        '
        Me.pnlLOG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLOG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLOG.Controls.Add(Me.TGGrn)
        Me.pnlLOG.Controls.Add(Me.btnHide)
        Me.pnlLOG.Controls.Add(Me.Label8)
        Me.pnlLOG.Location = New System.Drawing.Point(287, 109)
        Me.pnlLOG.Name = "pnlLOG"
        Me.pnlLOG.Size = New System.Drawing.Size(192, 327)
        Me.pnlLOG.TabIndex = 27
        Me.pnlLOG.Visible = False
        '
        'TGGrn
        '
        Me.TGGrn.AllowUserToAddRows = False
        Me.TGGrn.AllowUserToDeleteRows = False
        Me.TGGrn.AllowUserToResizeColumns = False
        Me.TGGrn.AllowUserToResizeRows = False
        Me.TGGrn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGGrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGGrn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.TGGrn.EnableHeadersVisualStyles = False
        Me.TGGrn.Location = New System.Drawing.Point(4, 28)
        Me.TGGrn.Name = "TGGrn"
        Me.TGGrn.ReadOnly = True
        Me.TGGrn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGGrn.RowHeadersVisible = False
        Me.TGGrn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGGrn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TGGrn.Size = New System.Drawing.Size(183, 255)
        Me.TGGrn.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "GRN NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 20
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(4, 289)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(183, 33)
        Me.btnHide.TabIndex = 1
        Me.btnHide.Text = "&Close"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "LIST OF GRN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLoading.Controls.Add(Me.Label9)
        Me.pnlLoading.Location = New System.Drawing.Point(283, 201)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(200, 75)
        Me.pnlLoading.TabIndex = 28
        Me.pnlLoading.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Loading, Please Wait..!"
        '
        'ProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(767, 476)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.pnlLOG)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ProductSearch"
        Me.Text = "ProductSearch"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLOG.ResumeLayout(False)
        CType(Me.TGGrn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoading.ResumeLayout(False)
        Me.pnlLoading.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSCat3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSCat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtVendor As System.Windows.Forms.TextBox
    Friend WithEvents txtSCat1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents pnlLOG As Panel
    Friend WithEvents btnHide As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TGGrn As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents pnlLoading As Panel
    Friend WithEvents Label9 As Label
End Class
