<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xMessage))
        Me.lblHead = New System.Windows.Forms.Panel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHead.Controls.Add(Me.btnNo)
        Me.lblHead.Controls.Add(Me.btnYes)
        Me.lblHead.Controls.Add(Me.lblMsg)
        Me.lblHead.Controls.Add(Me.Label1)
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHead.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(309, 139)
        Me.lblHead.TabIndex = 0
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(156, 99)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 25)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "&No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(75, 99)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 25)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "&Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg.ImageIndex = 0
        Me.lblMsg.ImageList = Me.ImageList1
        Me.lblMsg.Location = New System.Drawing.Point(9, 33)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(289, 49)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Do you want to save...?"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1481659064_Help.ico")
        Me.ImageList1.Images.SetKeyName(1, "1481659076_Cancel.ico")
        Me.ImageList1.Images.SetKeyName(2, "1481659087_Info.ico")
        Me.ImageList1.Images.SetKeyName(3, "1481662804_Gnome-Application-Exit-32.ico")
        Me.ImageList1.Images.SetKeyName(4, "1481662727_Print.ico")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  Alert !"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 139)
        Me.Controls.Add(Me.lblHead)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "xMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "xMessage"
        Me.lblHead.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHead As System.Windows.Forms.Panel
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents ImageList1 As ImageList
End Class
