<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Me.txtParent = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Parent Category"
        '
        'txtParent
        '
        Me.txtParent.BackColor = System.Drawing.SystemColors.Window
        Me.txtParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParent.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParent.ForeColor = System.Drawing.Color.Black
        Me.txtParent.Location = New System.Drawing.Point(16, 47)
        Me.txtParent.Name = "txtParent"
        Me.txtParent.ReadOnly = True
        Me.txtParent.Size = New System.Drawing.Size(606, 23)
        Me.txtParent.TabIndex = 0
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.Location = New System.Drawing.Point(16, 119)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(606, 23)
        Me.txtCat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sub Category Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAddCat)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnList)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(15, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 59)
        Me.Panel1.TabIndex = 2
        '
        'btnAddCat
        '
        Me.btnAddCat.Enabled = False
        Me.btnAddCat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat.Location = New System.Drawing.Point(445, 12)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(135, 30)
        Me.btnAddCat.TabIndex = 3
        Me.btnAddCat.Text = "&A : Add Category"
        Me.btnAddCat.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(304, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(135, 30)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&R : Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(163, 12)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(135, 30)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "&L : List Category"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(22, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&S : Save Category"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.txtParent)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Register"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtParent As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddCat As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnList As Button
    Friend WithEvents btnSave As Button
End Class
