<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryMaster
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlUpdate = New System.Windows.Forms.Panel()
        Me.lblCatID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtNewCat = New System.Windows.Forms.TextBox()
        Me.txtOldCat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUpdate.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle2
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.Gainsboro
        Me.TG.Location = New System.Drawing.Point(15, 68)
        Me.TG.MultiSelect = False
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 25
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TG.Size = New System.Drawing.Size(315, 370)
        Me.TG.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 240
        '
        'Column1
        '
        Me.Column1.HeaderText = "Edit"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Edit"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 23
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(15, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 23)
        Me.txtName.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Purple
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(293, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(37, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Category Name :"
        '
        'pnlUpdate
        '
        Me.pnlUpdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUpdate.Controls.Add(Me.lblCatID)
        Me.pnlUpdate.Controls.Add(Me.btnUpdate)
        Me.pnlUpdate.Controls.Add(Me.txtNewCat)
        Me.pnlUpdate.Controls.Add(Me.txtOldCat)
        Me.pnlUpdate.Controls.Add(Me.Label4)
        Me.pnlUpdate.Controls.Add(Me.Label3)
        Me.pnlUpdate.Controls.Add(Me.Panel2)
        Me.pnlUpdate.Location = New System.Drawing.Point(3, 115)
        Me.pnlUpdate.Name = "pnlUpdate"
        Me.pnlUpdate.Size = New System.Drawing.Size(340, 222)
        Me.pnlUpdate.TabIndex = 8
        Me.pnlUpdate.Visible = False
        '
        'lblCatID
        '
        Me.lblCatID.AutoSize = True
        Me.lblCatID.Location = New System.Drawing.Point(8, 174)
        Me.lblCatID.Name = "lblCatID"
        Me.lblCatID.Size = New System.Drawing.Size(51, 16)
        Me.lblCatID.TabIndex = 12
        Me.lblCatID.Text = "{CatID}"
        Me.lblCatID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Navy
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(210, 165)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 35)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtNewCat
        '
        Me.txtNewCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCat.Location = New System.Drawing.Point(11, 126)
        Me.txtNewCat.Name = "txtNewCat"
        Me.txtNewCat.Size = New System.Drawing.Size(315, 23)
        Me.txtNewCat.TabIndex = 1
        '
        'txtOldCat
        '
        Me.txtOldCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOldCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldCat.Location = New System.Drawing.Point(11, 65)
        Me.txtOldCat.Name = "txtOldCat"
        Me.txtOldCat.ReadOnly = True
        Me.txtOldCat.Size = New System.Drawing.Size(315, 23)
        Me.txtOldCat.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "New Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Old Category"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnHide)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 32)
        Me.Panel2.TabIndex = 3
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Navy
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(301, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(37, 30)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Category"
        '
        'frmCategoryMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 452)
        Me.Controls.Add(Me.pnlUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.TG)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCategoryMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Master"
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUpdate.ResumeLayout(False)
        Me.pnlUpdate.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlUpdate As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtNewCat As System.Windows.Forms.TextBox
    Friend WithEvents txtOldCat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents lblCatID As System.Windows.Forms.Label
End Class
