<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDueReport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkDateWise = New System.Windows.Forms.CheckBox()
        Me.chkGrnWise = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.cmbGrn = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.CmbVendor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvList = New Zuby.ADGV.AdvancedDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
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
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.chkDateWise)
        Me.Panel2.Controls.Add(Me.chkGrnWise)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnExport)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.SimpleLine2)
        Me.Panel2.Controls.Add(Me.cmbGrn)
        Me.Panel2.Controls.Add(Me.btnDisplay)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpBegin)
        Me.Panel2.Controls.Add(Me.dtpEnd)
        Me.Panel2.Controls.Add(Me.CmbVendor)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbLocation)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(102, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 104)
        Me.Panel2.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel1.Location = New System.Drawing.Point(750, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 15)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "GRN No"
        '
        'chkDateWise
        '
        Me.chkDateWise.AutoSize = True
        Me.chkDateWise.Location = New System.Drawing.Point(585, 42)
        Me.chkDateWise.Name = "chkDateWise"
        Me.chkDateWise.Size = New System.Drawing.Size(78, 19)
        Me.chkDateWise.TabIndex = 13
        Me.chkDateWise.Text = "Date Wise"
        Me.chkDateWise.UseVisualStyleBackColor = True
        '
        'chkGrnWise
        '
        Me.chkGrnWise.AutoSize = True
        Me.chkGrnWise.Location = New System.Drawing.Point(669, 42)
        Me.chkGrnWise.Name = "chkGrnWise"
        Me.chkGrnWise.Size = New System.Drawing.Size(78, 19)
        Me.chkGrnWise.TabIndex = 12
        Me.chkGrnWise.Text = "GRN Wise"
        Me.chkGrnWise.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1001, 62)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(920, 62)
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
        Me.Label5.Location = New System.Drawing.Point(15, 15)
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
        Me.SimpleLine2.Location = New System.Drawing.Point(18, 33)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(1033, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 7
        Me.SimpleLine2.UseGradient = False
        '
        'cmbGrn
        '
        Me.cmbGrn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrn.FormattingEnabled = True
        Me.cmbGrn.Location = New System.Drawing.Point(753, 64)
        Me.cmbGrn.Name = "cmbGrn"
        Me.cmbGrn.Size = New System.Drawing.Size(80, 23)
        Me.cmbGrn.TabIndex = 4
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(839, 62)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 25)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'dtpBegin
        '
        Me.dtpBegin.Enabled = False
        Me.dtpBegin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBegin.Location = New System.Drawing.Point(18, 64)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(105, 23)
        Me.dtpBegin.TabIndex = 0
        '
        'dtpEnd
        '
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(129, 64)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(105, 23)
        Me.dtpEnd.TabIndex = 1
        '
        'CmbVendor
        '
        Me.CmbVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVendor.FormattingEnabled = True
        Me.CmbVendor.Location = New System.Drawing.Point(476, 64)
        Me.CmbVendor.Name = "CmbVendor"
        Me.CmbVendor.Size = New System.Drawing.Size(271, 23)
        Me.CmbVendor.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vendor"
        '
        'cmbLocation
        '
        Me.cmbLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(240, 64)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(230, 23)
        Me.cmbLocation.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.BackgroundColor = System.Drawing.Color.White
        Me.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvList.ColumnHeadersHeight = 24
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvList.FilterAndSortEnabled = True
        Me.dgvList.GridColor = System.Drawing.Color.LightGray
        Me.dgvList.Location = New System.Drawing.Point(0, 115)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvList.RowHeadersWidth = 30
        Me.dgvList.Size = New System.Drawing.Size(1293, 499)
        Me.dgvList.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.lblQty)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblAmount)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.SimpleLine3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 614)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1293, 47)
        Me.Panel3.TabIndex = 5
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Purple
        Me.lblQty.Location = New System.Drawing.Point(197, 13)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(18, 20)
        Me.lblQty.TabIndex = 6
        Me.lblQty.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "TOTAL QUANTITY :"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Blue
        Me.lblAmount.Location = New System.Drawing.Point(442, 13)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(18, 20)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "TOTAL AMOUNT :"
        '
        'SimpleLine3
        '
        Me.SimpleLine3.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(1293, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 0
        Me.SimpleLine3.UseGradient = False
        '
        'pnlLoad
        '
        Me.pnlLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLoad.Controls.Add(Me.Label4)
        Me.pnlLoad.Location = New System.Drawing.Point(532, 302)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(229, 57)
        Me.pnlLoad.TabIndex = 20
        Me.pnlLoad.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Loading, Please Wait !"
        '
        'frmDueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 661)
        Me.Controls.Add(Me.pnlLoad)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDueReport"
        Me.Tag = "frmDueReport"
        Me.Text = "Due Days Report"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents cmbGrn As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBegin As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvList As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents CmbVendor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkGrnWise As CheckBox
    Friend WithEvents chkDateWise As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblQty As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents Label4 As Label
End Class
