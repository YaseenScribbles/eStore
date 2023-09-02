<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoryList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TGLst = New System.Windows.Forms.DataGridView()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TGLst
        '
        Me.TGLst.AllowUserToAddRows = False
        Me.TGLst.AllowUserToDeleteRows = False
        Me.TGLst.AllowUserToResizeColumns = False
        Me.TGLst.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TGLst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TGLst.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TGLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TGLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TGLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TGLst.DefaultCellStyle = DataGridViewCellStyle3
        Me.TGLst.EnableHeadersVisualStyles = False
        Me.TGLst.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TGLst.Location = New System.Drawing.Point(17, 61)
        Me.TGLst.Name = "TGLst"
        Me.TGLst.ReadOnly = True
        Me.TGLst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TGLst.RowHeadersVisible = False
        Me.TGLst.RowTemplate.Height = 23
        Me.TGLst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TGLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TGLst.Size = New System.Drawing.Size(600, 396)
        Me.TGLst.TabIndex = 1
        Me.TGLst.Tag = "1"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFind.Location = New System.Drawing.Point(17, 32)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(600, 23)
        Me.txtFind.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Find Category"
        '
        'frmCategoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 470)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.TGLst)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCategoryList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category List"
        CType(Me.TGLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TGLst As DataGridView
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label1 As Label
End Class
