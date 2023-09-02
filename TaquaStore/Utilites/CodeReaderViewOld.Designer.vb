<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeReaderViewOld
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAlter = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlList.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.btnAlter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 65)
        Me.Panel1.TabIndex = 0
        '
        'btnAlter
        '
        Me.btnAlter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlter.Location = New System.Drawing.Point(753, 12)
        Me.btnAlter.Name = "btnAlter"
        Me.btnAlter.Size = New System.Drawing.Size(159, 38)
        Me.btnAlter.TabIndex = 14
        Me.btnAlter.Text = "&Alter Category"
        Me.btnAlter.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 403)
        Me.Panel2.TabIndex = 1
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGrid.Size = New System.Drawing.Size(924, 403)
        Me.DataGrid.TabIndex = 2
        '
        'pnlList
        '
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.btnClose)
        Me.pnlList.Controls.Add(Me.TG)
        Me.pnlList.Controls.Add(Me.Label9)
        Me.pnlList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlList.Location = New System.Drawing.Point(211, 63)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(503, 343)
        Me.pnlList.TabIndex = 18
        Me.pnlList.Tag = ""
        Me.pnlList.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(455, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column1, Me.Column8, Me.Column2, Me.Column9, Me.Column10})
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(7, 34)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersVisible = False
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(487, 301)
        Me.TG.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(202, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "List of Entries"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(12, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(102, 16)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Total Items : 0"
        '
        'Column6
        '
        Me.Column6.HeaderText = "E.No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "MacId"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Quantity"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "User"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = ""
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Text = "View"
        Me.Column9.UseColumnTextForButtonValue = True
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 23
        '
        'CodeReaderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 468)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CodeReaderView"
        Me.Text = "CodeReaderView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents pnlList As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents TG As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAlter As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewButtonColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
