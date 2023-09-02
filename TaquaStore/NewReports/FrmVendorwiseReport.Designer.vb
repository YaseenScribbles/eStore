<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVendorwiseReport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbCat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.CmbDept = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New Zuby.ADGV.AdvancedDataGridView()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1293, 115)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.CmbMaterial)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CmbCat)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnExport)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.SimpleLine2)
        Me.Panel2.Controls.Add(Me.btnDisplay)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpBegin)
        Me.Panel2.Controls.Add(Me.dtpEnd)
        Me.Panel2.Controls.Add(Me.CmbDept)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(133, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 104)
        Me.Panel2.TabIndex = 0
        '
        'CmbMaterial
        '
        Me.CmbMaterial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMaterial.FormattingEnabled = True
        Me.CmbMaterial.Location = New System.Drawing.Point(608, 65)
        Me.CmbMaterial.Name = "CmbMaterial"
        Me.CmbMaterial.Size = New System.Drawing.Size(175, 23)
        Me.CmbMaterial.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Material"
        '
        'CmbCat
        '
        Me.CmbCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCat.FormattingEnabled = True
        Me.CmbCat.Location = New System.Drawing.Point(427, 65)
        Me.CmbCat.Name = "CmbCat"
        Me.CmbCat.Size = New System.Drawing.Size(175, 23)
        Me.CmbCat.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Category"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(951, 63)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(870, 63)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 25)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DURATION && FILTER"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(24, 34)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(975, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 7
        Me.SimpleLine2.UseGradient = False
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(789, 63)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 25)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'dtpBegin
        '
        Me.dtpBegin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBegin.Location = New System.Drawing.Point(24, 65)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(105, 23)
        Me.dtpBegin.TabIndex = 0
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(135, 65)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(105, 23)
        Me.dtpEnd.TabIndex = 1
        '
        'CmbDept
        '
        Me.CmbDept.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDept.FormattingEnabled = True
        Me.CmbDept.Location = New System.Drawing.Point(246, 65)
        Me.CmbDept.Name = "CmbDept"
        Me.CmbDept.Size = New System.Drawing.Size(175, 23)
        Me.CmbDept.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.ColumnHeadersHeight = 24
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.FilterAndSortEnabled = True
        Me.dgvReport.GridColor = System.Drawing.Color.LightGray
        Me.dgvReport.Location = New System.Drawing.Point(0, 115)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvReport.RowHeadersWidth = 30
        Me.dgvReport.Size = New System.Drawing.Size(1293, 502)
        Me.dgvReport.TabIndex = 3
        '
        'pnlLoad
        '
        Me.pnlLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLoad.Controls.Add(Me.Label7)
        Me.pnlLoad.Location = New System.Drawing.Point(532, 280)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(229, 57)
        Me.pnlLoad.TabIndex = 21
        Me.pnlLoad.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Loading, Please Wait !"
        '
        'FrmVendorwiseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1293, 617)
        Me.Controls.Add(Me.pnlLoad)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmVendorwiseReport"
        Me.Tag = "FrmVendorwiseReport"
        Me.Text = "Vendor Report"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoad.ResumeLayout(False)
        Me.pnlLoad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBegin As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents CmbDept As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbMaterial As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbCat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvReport As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents Label7 As Label
End Class
