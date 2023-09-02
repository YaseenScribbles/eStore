<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attributes
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnRevert = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(12, 78)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(279, 21)
        Me.txtName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(297, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Group"
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(12, 25)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(360, 21)
        Me.cmbGroup.TabIndex = 0
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
        Me.SimpleLine1.Location = New System.Drawing.Point(12, 117)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(360, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 5
        Me.SimpleLine1.UseGradient = False
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.AllowUserToResizeColumns = False
        Me.dataGrid.AllowUserToResizeRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dataGrid.Location = New System.Drawing.Point(12, 133)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.RowHeadersVisible = False
        Me.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataGrid.Size = New System.Drawing.Size(360, 316)
        Me.dataGrid.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 303
        '
        'Column5
        '
        Me.Column5.HeaderText = "IsActive"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "2"
        Me.Column3.UseColumnTextForButtonValue = True
        Me.Column3.Width = 30
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 23
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.Silver
        Me.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEdit.Controls.Add(Me.btnHide)
        Me.pnlEdit.Controls.Add(Me.btnRevert)
        Me.pnlEdit.Controls.Add(Me.Label4)
        Me.pnlEdit.Controls.Add(Me.chkActive)
        Me.pnlEdit.Controls.Add(Me.btnUpdate)
        Me.pnlEdit.Controls.Add(Me.Label3)
        Me.pnlEdit.Controls.Add(Me.txtEdit)
        Me.pnlEdit.Location = New System.Drawing.Point(21, 180)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(343, 166)
        Me.pnlEdit.TabIndex = 6
        Me.pnlEdit.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.DimGray
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(308, -4)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(34, 27)
        Me.btnHide.TabIndex = 6
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnRevert
        '
        Me.btnRevert.AutoSize = True
        Me.btnRevert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRevert.ForeColor = System.Drawing.Color.Navy
        Me.btnRevert.Location = New System.Drawing.Point(222, 56)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.Size = New System.Drawing.Size(89, 13)
        Me.btnRevert.TabIndex = 5
        Me.btnRevert.Text = "Revert Old Name"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(341, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Update"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.Location = New System.Drawing.Point(32, 112)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(62, 17)
        Me.chkActive.TabIndex = 2
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(236, 110)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'txtEdit
        '
        Me.txtEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdit.Location = New System.Drawing.Point(32, 73)
        Me.txtEdit.MaxLength = 50
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(279, 21)
        Me.txtEdit.TabIndex = 0
        '
        'Attributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Attributes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attributes"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEdit As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRevert As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
