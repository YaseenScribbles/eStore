<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnVerifier
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TGDCode = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.TGTst = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewProduct = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.radGD = New System.Windows.Forms.RadioButton()
        Me.radSR = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TGDCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TGTst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 39)
        Me.Panel3.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(503, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(67, 30)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Tag = "1"
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 25)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Return Verifier"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(576, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Tag = "1"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TG.ColumnHeadersHeight = 25
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle3
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(12, 98)
        Me.TG.MultiSelect = False
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(162, 376)
        Me.TG.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.HeaderText = "SNO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(12, 70)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(162, 22)
        Me.txtCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PLUCODE"
        '
        'TGDCode
        '
        Me.TGDCode.AllowUserToAddRows = False
        Me.TGDCode.AllowUserToResizeColumns = False
        Me.TGDCode.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TGDCode.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TGDCode.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TGDCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGDCode.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TGDCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGDCode.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TGDCode.ColumnHeadersHeight = 25
        Me.TGDCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGDCode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column8})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGDCode.DefaultCellStyle = DataGridViewCellStyle6
        Me.TGDCode.EnableHeadersVisualStyles = False
        Me.TGDCode.Location = New System.Drawing.Point(180, 98)
        Me.TGDCode.MultiSelect = False
        Me.TGDCode.Name = "TGDCode"
        Me.TGDCode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGDCode.RowHeadersVisible = False
        Me.TGDCode.RowTemplate.Height = 30
        Me.TGDCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGDCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TGDCode.Size = New System.Drawing.Size(140, 276)
        Me.TGDCode.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.FalseValue = "0"
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.TrueValue = "1"
        Me.Column3.Width = 20
        '
        'Column8
        '
        Me.Column8.HeaderText = "DELIVERY  CODE"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 120
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.Location = New System.Drawing.Point(276, 70)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(44, 22)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Tag = "1"
        Me.btnReload.Text = "LOAD"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'TGTst
        '
        Me.TGTst.AllowUserToAddRows = False
        Me.TGTst.AllowUserToResizeColumns = False
        Me.TGTst.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TGTst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TGTst.BackgroundColor = System.Drawing.Color.White
        Me.TGTst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TGTst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TGTst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGTst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.TGTst.ColumnHeadersHeight = 25
        Me.TGTst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TGTst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGTst.DefaultCellStyle = DataGridViewCellStyle9
        Me.TGTst.EnableHeadersVisualStyles = False
        Me.TGTst.Location = New System.Drawing.Point(327, 98)
        Me.TGTst.MultiSelect = False
        Me.TGTst.Name = "TGTst"
        Me.TGTst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TGTst.RowHeadersVisible = False
        Me.TGTst.RowTemplate.Height = 30
        Me.TGTst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGTst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TGTst.Size = New System.Drawing.Size(311, 376)
        Me.TGTst.TabIndex = 6
        '
        'Column4
        '
        Me.Column4.HeaderText = "CODE"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "REQUIRED"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "ACTUAL"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "VARIATION"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 90
        '
        'btnViewProduct
        '
        Me.btnViewProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnViewProduct.FlatAppearance.BorderSize = 0
        Me.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProduct.ForeColor = System.Drawing.Color.White
        Me.btnViewProduct.Location = New System.Drawing.Point(180, 389)
        Me.btnViewProduct.Name = "btnViewProduct"
        Me.btnViewProduct.Size = New System.Drawing.Size(140, 34)
        Me.btnViewProduct.TabIndex = 4
        Me.btnViewProduct.Tag = "1"
        Me.btnViewProduct.Text = "VERIFY PRODUCT"
        Me.btnViewProduct.UseVisualStyleBackColor = False
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClearList.FlatAppearance.BorderSize = 0
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.ForeColor = System.Drawing.Color.White
        Me.btnClearList.Location = New System.Drawing.Point(180, 440)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(140, 34)
        Me.btnClearList.TabIndex = 5
        Me.btnClearList.Tag = "1"
        Me.btnClearList.Text = "CLEAR LIST"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'radGD
        '
        Me.radGD.Location = New System.Drawing.Point(228, 70)
        Me.radGD.Name = "radGD"
        Me.radGD.Size = New System.Drawing.Size(42, 22)
        Me.radGD.TabIndex = 7
        Me.radGD.Text = "GD"
        Me.radGD.UseVisualStyleBackColor = True
        '
        'radSR
        '
        Me.radSR.Checked = True
        Me.radSR.Location = New System.Drawing.Point(180, 70)
        Me.radSR.Name = "radSR"
        Me.radSR.Size = New System.Drawing.Size(42, 22)
        Me.radSR.TabIndex = 8
        Me.radSR.TabStop = True
        Me.radSR.Text = "SR"
        Me.radSR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "* SR - SHOP RETURN "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "* GD - GENERAL DELIVERY "
        '
        'ReturnVerifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(649, 486)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radSR)
        Me.Controls.Add(Me.radGD)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnViewProduct)
        Me.Controls.Add(Me.TGTst)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.TGDCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReturnVerifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "40"
        Me.Text = "Return Verifier"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TGDCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TGTst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TGDCode As System.Windows.Forms.DataGridView
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents TGTst As System.Windows.Forms.DataGridView
    Friend WithEvents btnViewProduct As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Button
    Friend WithEvents radGD As RadioButton
    Friend WithEvents radSR As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
