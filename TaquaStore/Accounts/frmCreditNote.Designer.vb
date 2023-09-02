<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditNote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVNo = New System.Windows.Forms.TextBox()
        Me.txtVDt = New System.Windows.Forms.MaskedTextBox()
        Me.cmbLedger = New System.Windows.Forms.ComboBox()
        Me.cmbPaid = New System.Windows.Forms.ComboBox()
        Me.txtRefDt = New System.Windows.Forms.MaskedTextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "V.No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "V.Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ledger Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Paid By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ref No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ref Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Remarks"
        '
        'txtVNo
        '
        Me.txtVNo.Enabled = False
        Me.txtVNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVNo.Location = New System.Drawing.Point(15, 74)
        Me.txtVNo.Name = "txtVNo"
        Me.txtVNo.Size = New System.Drawing.Size(84, 22)
        Me.txtVNo.TabIndex = 0
        '
        'txtVDt
        '
        Me.txtVDt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVDt.Location = New System.Drawing.Point(105, 74)
        Me.txtVDt.Mask = "00/00/0000"
        Me.txtVDt.Name = "txtVDt"
        Me.txtVDt.Size = New System.Drawing.Size(84, 22)
        Me.txtVDt.TabIndex = 1
        Me.txtVDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVDt.ValidatingType = GetType(Date)
        '
        'cmbLedger
        '
        Me.cmbLedger.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedger.FormattingEnabled = True
        Me.cmbLedger.Location = New System.Drawing.Point(218, 74)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(315, 22)
        Me.cmbLedger.TabIndex = 2
        '
        'cmbPaid
        '
        Me.cmbPaid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaid.FormattingEnabled = True
        Me.cmbPaid.Items.AddRange(New Object() {"Cash", "Cheque", "RTGS"})
        Me.cmbPaid.Location = New System.Drawing.Point(15, 129)
        Me.cmbPaid.Name = "cmbPaid"
        Me.cmbPaid.Size = New System.Drawing.Size(174, 22)
        Me.cmbPaid.TabIndex = 3
        '
        'txtRefDt
        '
        Me.txtRefDt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefDt.Location = New System.Drawing.Point(353, 129)
        Me.txtRefDt.Mask = "00/00/0000"
        Me.txtRefDt.Name = "txtRefDt"
        Me.txtRefDt.Size = New System.Drawing.Size(84, 22)
        Me.txtRefDt.TabIndex = 5
        Me.txtRefDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRefDt.ValidatingType = GetType(Date)
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(218, 129)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(129, 22)
        Me.txtRefNo.TabIndex = 4
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(443, 129)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(90, 22)
        Me.txtAmt.TabIndex = 6
        Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(15, 182)
        Me.txtRemarks.MaxLength = 60
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(518, 22)
        Me.txtRemarks.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 14)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "VOUCHER INFO"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.LightGray
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(15, 36)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(518, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 12
        Me.SimpleLine1.UseGradient = False
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.LightGray
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(15, 244)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(518, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 14
        Me.SimpleLine2.UseGradient = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "OPTIONS"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(409, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 30)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save Voucher"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCreditNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 313)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.txtRefDt)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.cmbPaid)
        Me.Controls.Add(Me.cmbLedger)
        Me.Controls.Add(Me.txtVDt)
        Me.Controls.Add(Me.txtVNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCreditNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit Note"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVNo As System.Windows.Forms.TextBox
    Friend WithEvents txtVDt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPaid As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefDt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
