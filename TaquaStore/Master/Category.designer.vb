<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TV2 = New System.Windows.Forms.TreeView()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomPanel2 = New CustomPanel.CustomPanel()
        Me.lblSCat = New System.Windows.Forms.Label()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddSubCat = New System.Windows.Forms.Button()
        Me.txtSubCat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLMsg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(7, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = " Category"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 39)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(632, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = " RELOAD CATEGORY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(812, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category List"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TV2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 367.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(377, 638)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TV2
        '
        Me.TV2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV2.FullRowSelect = True
        Me.TV2.Indent = 30
        Me.TV2.ItemHeight = 30
        Me.TV2.Location = New System.Drawing.Point(3, 33)
        Me.TV2.Name = "TV2"
        Me.TV2.PathSeparator = "->"
        Me.TV2.ShowLines = False
        Me.TV2.Size = New System.Drawing.Size(371, 602)
        Me.TV2.TabIndex = 1
        '
        'SimpleLine1
        '
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(390, 391)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(324, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 14
        Me.SimpleLine1.UseGradient = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(385, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = " Selected Category"
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.Controls.Add(Me.lblSCat)
        Me.CustomPanel2.Curvature = 1
        Me.CustomPanel2.CurveMode = CustomPanel.CornerCurveMode.BottomRight
        Me.CustomPanel2.Location = New System.Drawing.Point(389, 442)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(326, 113)
        Me.CustomPanel2.TabIndex = 12
        '
        'lblSCat
        '
        Me.lblSCat.ForeColor = System.Drawing.Color.DarkGray
        Me.lblSCat.Location = New System.Drawing.Point(8, 12)
        Me.lblSCat.Name = "lblSCat"
        Me.lblSCat.Size = New System.Drawing.Size(311, 99)
        Me.lblSCat.TabIndex = 0
        '
        'btnAddCat
        '
        Me.btnAddCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAddCat.FlatAppearance.BorderSize = 0
        Me.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCat.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat.ForeColor = System.Drawing.Color.White
        Me.btnAddCat.Location = New System.Drawing.Point(569, 163)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(146, 32)
        Me.btnAddCat.TabIndex = 10
        Me.btnAddCat.Text = "Add Category "
        Me.btnAddCat.UseVisualStyleBackColor = False
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(389, 119)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(326, 25)
        Me.txtCat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Category Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(383, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Create Category"
        '
        'btnAddSubCat
        '
        Me.btnAddSubCat.BackColor = System.Drawing.Color.Teal
        Me.btnAddSubCat.FlatAppearance.BorderSize = 0
        Me.btnAddSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubCat.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubCat.ForeColor = System.Drawing.Color.White
        Me.btnAddSubCat.Location = New System.Drawing.Point(569, 335)
        Me.btnAddSubCat.Name = "btnAddSubCat"
        Me.btnAddSubCat.Size = New System.Drawing.Size(146, 32)
        Me.btnAddSubCat.TabIndex = 17
        Me.btnAddSubCat.Text = "Add Sub Category "
        Me.btnAddSubCat.UseVisualStyleBackColor = False
        '
        'txtSubCat
        '
        Me.txtSubCat.Location = New System.Drawing.Point(389, 291)
        Me.txtSubCat.Name = "txtSubCat"
        Me.txtSubCat.Size = New System.Drawing.Size(326, 25)
        Me.txtSubCat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SubCategory Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(383, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Create SubCategory"
        '
        'LBLMsg
        '
        Me.LBLMsg.AutoSize = True
        Me.LBLMsg.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMsg.ForeColor = System.Drawing.Color.Teal
        Me.LBLMsg.Location = New System.Drawing.Point(387, 371)
        Me.LBLMsg.Name = "LBLMsg"
        Me.LBLMsg.Size = New System.Drawing.Size(0, 17)
        Me.LBLMsg.TabIndex = 19
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 677)
        Me.Controls.Add(Me.LBLMsg)
        Me.Controls.Add(Me.btnAddSubCat)
        Me.Controls.Add(Me.txtSubCat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SimpleLine1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustomPanel2)
        Me.Controls.Add(Me.btnAddCat)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Category"
        Me.Tag = "2"
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.CustomPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TV2 As System.Windows.Forms.TreeView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomPanel2 As CustomPanel.CustomPanel
    Friend WithEvents lblSCat As System.Windows.Forms.Label
    Friend WithEvents btnAddCat As System.Windows.Forms.Button
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddSubCat As System.Windows.Forms.Button
    Friend WithEvents txtSubCat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LBLMsg As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
