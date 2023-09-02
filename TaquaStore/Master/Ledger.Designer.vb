<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ledger
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbDR = New System.Windows.Forms.ComboBox()
        Me.cmbLGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrpHead = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.txtLedgerID = New System.Windows.Forms.TextBox()
        Me.txtLedgerName = New System.Windows.Forms.TextBox()
        Me.txtOBal = New System.Windows.Forms.TextBox()
        Me.txtGrpID = New TaquaStore.cTextBox()
        Me.txtGrpNm = New TaquaStore.cTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(43, 258)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 30)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE : [ &S ]"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(169, 258)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 30)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "RESET : [ &R ]"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(295, 258)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Tag = "4"
        Me.btnClose.Text = "EXIT : [ &X ]"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbDR
        '
        Me.cmbDR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDR.ForeColor = System.Drawing.Color.Black
        Me.cmbDR.FormattingEnabled = True
        Me.cmbDR.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbDR.Location = New System.Drawing.Point(249, 171)
        Me.cmbDR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDR.Name = "cmbDR"
        Me.cmbDR.Size = New System.Drawing.Size(46, 24)
        Me.cmbDR.TabIndex = 4
        '
        'cmbLGroup
        '
        Me.cmbLGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLGroup.ForeColor = System.Drawing.Color.Black
        Me.cmbLGroup.FormattingEnabled = True
        Me.cmbLGroup.Location = New System.Drawing.Point(144, 129)
        Me.cmbLGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbLGroup.Name = "cmbLGroup"
        Me.cmbLGroup.Size = New System.Drawing.Size(298, 24)
        Me.cmbLGroup.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "O.Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Ledger Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Ledger Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Ledger ID"
        '
        'cmbGrpHead
        '
        Me.cmbGrpHead.FormattingEnabled = True
        Me.cmbGrpHead.Location = New System.Drawing.Point(122, 91)
        Me.cmbGrpHead.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbGrpHead.Name = "cmbGrpHead"
        Me.cmbGrpHead.Size = New System.Drawing.Size(298, 24)
        Me.cmbGrpHead.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Group Head"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Group Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Group ID"
        '
        'TTip
        '
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error..!"
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
        Me.SimpleLine1.Location = New System.Drawing.Point(17, 33)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(425, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 37
        Me.SimpleLine1.UseGradient = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(118, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(118, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(118, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtGrpID)
        Me.Panel1.Controls.Add(Me.txtGrpNm)
        Me.Panel1.Controls.Add(Me.cmbGrpHead)
        Me.Panel1.Location = New System.Drawing.Point(396, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(12, 11)
        Me.Panel1.TabIndex = 48
        Me.Panel1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(14, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "LEDGER INFO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(14, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "OPTIONS"
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
        Me.SimpleLine2.Location = New System.Drawing.Point(17, 239)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(425, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 51
        Me.SimpleLine2.UseGradient = False
        '
        'txtLedgerID
        '
        Me.txtLedgerID.Location = New System.Drawing.Point(144, 49)
        Me.txtLedgerID.Name = "txtLedgerID"
        Me.txtLedgerID.Size = New System.Drawing.Size(100, 23)
        Me.txtLedgerID.TabIndex = 0
        '
        'txtLedgerName
        '
        Me.txtLedgerName.Location = New System.Drawing.Point(144, 89)
        Me.txtLedgerName.Name = "txtLedgerName"
        Me.txtLedgerName.Size = New System.Drawing.Size(298, 23)
        Me.txtLedgerName.TabIndex = 1
        '
        'txtOBal
        '
        Me.txtOBal.Location = New System.Drawing.Point(144, 171)
        Me.txtOBal.Name = "txtOBal"
        Me.txtOBal.Size = New System.Drawing.Size(100, 23)
        Me.txtOBal.TabIndex = 3
        '
        'txtGrpID
        '
        Me.txtGrpID.AcceptBackwards = True
        Me.txtGrpID.AcceptEmptyWords = True
        Me.txtGrpID.BorderColor = System.Drawing.Color.Black
        Me.txtGrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrpID.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtGrpID.Enabled = False
        Me.txtGrpID.FocusBackColor = System.Drawing.Color.Empty
        Me.txtGrpID.FocusBorderColor = System.Drawing.Color.Empty
        Me.txtGrpID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrpID.Location = New System.Drawing.Point(122, 9)
        Me.txtGrpID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrpID.Name = "txtGrpID"
        Me.txtGrpID.NormalBackColor = System.Drawing.Color.Empty
        Me.txtGrpID.NormalBorderColor = System.Drawing.Color.Empty
        Me.txtGrpID.Size = New System.Drawing.Size(98, 25)
        Me.txtGrpID.TabIndex = 41
        Me.txtGrpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrpNm
        '
        Me.txtGrpNm.AcceptBackwards = True
        Me.txtGrpNm.AcceptEmptyWords = True
        Me.txtGrpNm.BorderColor = System.Drawing.Color.Black
        Me.txtGrpNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrpNm.BorderStyleCustom = TaquaStore.cTextBox.CustomBorderStyles.CustomColor
        Me.txtGrpNm.FocusBackColor = System.Drawing.Color.Empty
        Me.txtGrpNm.FocusBorderColor = System.Drawing.Color.Empty
        Me.txtGrpNm.Location = New System.Drawing.Point(122, 50)
        Me.txtGrpNm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrpNm.Name = "txtGrpNm"
        Me.txtGrpNm.NormalBackColor = System.Drawing.Color.Empty
        Me.txtGrpNm.NormalBorderColor = System.Drawing.Color.Empty
        Me.txtGrpNm.Size = New System.Drawing.Size(298, 23)
        Me.txtGrpNm.TabIndex = 42
        '
        'Ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(459, 306)
        Me.Controls.Add(Me.txtOBal)
        Me.Controls.Add(Me.txtLedgerName)
        Me.Controls.Add(Me.txtLedgerID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDR)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ledger"
        Me.Tag = "17"
        Me.Text = "Ledger Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbDR As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrpHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtGrpNm As TaquaStore.cTextBox
    Friend WithEvents txtGrpID As TaquaStore.cTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents txtLedgerID As System.Windows.Forms.TextBox
    Friend WithEvents txtLedgerName As System.Windows.Forms.TextBox
    Friend WithEvents txtOBal As System.Windows.Forms.TextBox
End Class
