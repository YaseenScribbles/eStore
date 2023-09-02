<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankRegister
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddNewBank = New System.Windows.Forms.Button()
        Me.pnlAddNewBank = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBankCount = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddNewBank.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeight = 25
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column3, Me.Column4})
        Me.dgv.Location = New System.Drawing.Point(15, 15)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv.Size = New System.Drawing.Size(376, 450)
        Me.dgv.TabIndex = 2
        '
        'Column5
        '
        Me.Column5.HeaderText = "BankID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name of Bank"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "Edit"
        Me.Column3.UseColumnTextForButtonValue = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 23
        '
        'btnAddNewBank
        '
        Me.btnAddNewBank.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBank.Location = New System.Drawing.Point(243, 478)
        Me.btnAddNewBank.Name = "btnAddNewBank"
        Me.btnAddNewBank.Size = New System.Drawing.Size(148, 30)
        Me.btnAddNewBank.TabIndex = 4
        Me.btnAddNewBank.Text = "&Add New Bank"
        Me.btnAddNewBank.UseVisualStyleBackColor = True
        '
        'pnlAddNewBank
        '
        Me.pnlAddNewBank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAddNewBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddNewBank.Controls.Add(Me.btnUpdate)
        Me.pnlAddNewBank.Controls.Add(Me.txtBankName)
        Me.pnlAddNewBank.Controls.Add(Me.Label1)
        Me.pnlAddNewBank.Controls.Add(Me.Panel2)
        Me.pnlAddNewBank.Location = New System.Drawing.Point(22, 180)
        Me.pnlAddNewBank.Name = "pnlAddNewBank"
        Me.pnlAddNewBank.Size = New System.Drawing.Size(360, 156)
        Me.pnlAddNewBank.TabIndex = 5
        Me.pnlAddNewBank.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(243, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtBankName
        '
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(18, 68)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(325, 23)
        Me.txtBankName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bank Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnHide)
        Me.Panel2.Controls.Add(Me.lblHead)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 30)
        Me.Panel2.TabIndex = 6
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Red
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(326, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(30, 28)
        Me.btnHide.TabIndex = 7
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'lblHead
        '
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHead.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.Color.Yellow
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(356, 28)
        Me.lblHead.TabIndex = 0
        Me.lblHead.Text = "Add New Bank"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No of Banks  :"
        '
        'lblBankCount
        '
        Me.lblBankCount.AutoSize = True
        Me.lblBankCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankCount.ForeColor = System.Drawing.Color.Purple
        Me.lblBankCount.Location = New System.Drawing.Point(93, 488)
        Me.lblBankCount.Name = "lblBankCount"
        Me.lblBankCount.Size = New System.Drawing.Size(14, 13)
        Me.lblBankCount.TabIndex = 7
        Me.lblBankCount.Text = "0"
        '
        'frmBankRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 517)
        Me.Controls.Add(Me.lblBankCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlAddNewBank)
        Me.Controls.Add(Me.btnAddNewBank)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBankRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Register"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddNewBank.ResumeLayout(False)
        Me.pnlAddNewBank.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddNewBank As System.Windows.Forms.Button
    Friend WithEvents pnlAddNewBank As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBankCount As System.Windows.Forms.Label
End Class
