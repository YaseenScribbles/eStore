<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReportHSNwise
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.dgvSummary = New System.Windows.Forms.DataGridView()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbTotal = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.LinkLabel()
        Me.rbGST = New System.Windows.Forms.RadioButton()
        Me.rbReturn = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VIEWBILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Sales Report - HSN Wise"
        '
        'pnlLine
        '
        Me.pnlLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLine.ForeColor = System.Drawing.Color.Gray
        Me.pnlLine.Location = New System.Drawing.Point(17, 36)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(1055, 1)
        Me.pnlLine.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(20, 71)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(103, 23)
        Me.dtpFrom.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(129, 71)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(103, 23)
        Me.dtpTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To"
        '
        'cmbLocation
        '
        Me.cmbLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(238, 71)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(209, 23)
        Me.cmbLocation.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Locations"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderSize = 0
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(461, 71)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(548, 71)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(17, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 1)
        Me.Panel1.TabIndex = 10
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AllowUserToResizeColumns = False
        Me.dgvReport.AllowUserToResizeRows = False
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.EnableHeadersVisualStyles = False
        Me.dgvReport.Location = New System.Drawing.Point(0, 106)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.Size = New System.Drawing.Size(1085, 243)
        Me.dgvReport.TabIndex = 11
        '
        'dgvSummary
        '
        Me.dgvSummary.AllowUserToAddRows = False
        Me.dgvSummary.AllowUserToDeleteRows = False
        Me.dgvSummary.AllowUserToResizeColumns = False
        Me.dgvSummary.AllowUserToResizeRows = False
        Me.dgvSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSummary.ColumnHeadersHeight = 41
        Me.dgvSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        Me.dgvSummary.EnableHeadersVisualStyles = False
        Me.dgvSummary.Location = New System.Drawing.Point(403, 21)
        Me.dgvSummary.Name = "dgvSummary"
        Me.dgvSummary.RowHeadersVisible = False
        Me.dgvSummary.Size = New System.Drawing.Size(364, 175)
        Me.dgvSummary.TabIndex = 12
        '
        'Column16
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column16.HeaderText = "Taxable Amount"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column17.HeaderText = "Tax Perc."
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 50
        '
        'Column18
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column18.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column18.HeaderText = "Tax Value"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column19.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column19.HeaderText = "Total Value"
        Me.Column19.Name = "Column19"
        '
        'Column20
        '
        Me.Column20.HeaderText = ""
        Me.Column20.Name = "Column20"
        Me.Column20.Width = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SUMMARY :"
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(1009, 179)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(64, 17)
        Me.lblLoading.TabIndex = 15
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbTotal)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnExport)
        Me.Panel3.Controls.Add(Me.rbGST)
        Me.Panel3.Controls.Add(Me.btnDisplay)
        Me.Panel3.Controls.Add(Me.rbReturn)
        Me.Panel3.Controls.Add(Me.cmbLocation)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dtpTo)
        Me.Panel3.Controls.Add(Me.rbNormal)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1085, 106)
        Me.Panel3.TabIndex = 16
        '
        'rbTotal
        '
        Me.rbTotal.AutoSize = True
        Me.rbTotal.Location = New System.Drawing.Point(939, 43)
        Me.rbTotal.Name = "rbTotal"
        Me.rbTotal.Size = New System.Drawing.Size(56, 17)
        Me.rbTotal.TabIndex = 12
        Me.rbTotal.TabStop = True
        Me.rbTotal.Text = "TOTAL"
        Me.rbTotal.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(634, 71)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.Location = New System.Drawing.Point(980, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 13)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.TabStop = True
        Me.btnUpdate.Text = "Update GST bills"
        Me.btnUpdate.Visible = False
        '
        'rbGST
        '
        Me.rbGST.AutoSize = True
        Me.rbGST.Location = New System.Drawing.Point(1001, 62)
        Me.rbGST.Name = "rbGST"
        Me.rbGST.Size = New System.Drawing.Size(45, 17)
        Me.rbGST.TabIndex = 9
        Me.rbGST.Text = "GST"
        Me.rbGST.UseVisualStyleBackColor = True
        '
        'rbReturn
        '
        Me.rbReturn.AutoSize = True
        Me.rbReturn.Location = New System.Drawing.Point(1001, 81)
        Me.rbReturn.Name = "rbReturn"
        Me.rbReturn.Size = New System.Drawing.Size(67, 17)
        Me.rbReturn.TabIndex = 10
        Me.rbReturn.Text = "RETURN"
        Me.rbReturn.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Checked = True
        Me.rbNormal.Location = New System.Drawing.Point(1001, 43)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(71, 17)
        Me.rbNormal.TabIndex = 8
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "NORMAL"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.dgvSummary)
        Me.Panel4.Controls.Add(Me.lblLoading)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 349)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1085, 208)
        Me.Panel4.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.ForeColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(18, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 1)
        Me.Panel2.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWBILLToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 26)
        '
        'VIEWBILLToolStripMenuItem
        '
        Me.VIEWBILLToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.VIEWBILLToolStripMenuItem.Name = "VIEWBILLToolStripMenuItem"
        Me.VIEWBILLToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VIEWBILLToolStripMenuItem.Text = "VIEW BILL"
        '
        'SalesReportHSNwise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1085, 557)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.pnlLine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "SalesReportHSNwise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReportHSNwise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLine As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents dgvSummary As DataGridView
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbGST As RadioButton
    Friend WithEvents rbReturn As RadioButton
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents btnUpdate As LinkLabel
    Friend WithEvents btnClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VIEWBILLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbTotal As RadioButton
End Class
