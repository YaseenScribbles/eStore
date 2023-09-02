Imports System.Reflection

Public Class frmMainScreen
    Private Sub frmMainScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            If MdiChildren.Length > 0 Then Exit Sub
            If xMessage.ShowMsg("Do you want to exit application..?", True, Me, 0, xMessage.MsgStyle.iExit) = False Then Exit Sub
            Close()
        End If

    End Sub

    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SBDate.Text = FormatDateTime(Now, DateFormat.LongDate)


        For Each control As Control In Me.Controls

            If TypeOf control Is MdiClient Then

                Dim method As MethodInfo = DirectCast(control, MdiClient).[GetType]().GetMethod("SetStyle", BindingFlags.Instance Or BindingFlags.NonPublic)

                method.Invoke(DirectCast(control, MdiClient), New [Object]() {ControlStyles.OptimizedDoubleBuffer, True})

            End If

        Next

    End Sub

    Private Sub frmMainScreen_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Dim bgfile = Me.BackgroundImage
        Me.SuspendLayout()
        Me.BackgroundImage = Nothing
        Me.BackgroundImage = bgfile
        Me.ResumeLayout()

        lblCompany.Width = (TStrip.Width - (TS1.Width + TS2.Width + TS3.Width + TS4.Width)) - 100

    End Sub

    Private Sub VendorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorsToolStripMenuItem.Click

        ShowForm(Vendors)

    End Sub

    Private Sub VendorGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorGroupsToolStripMenuItem.Click

        ShowForm(Agents)

    End Sub

    Private Sub ShowForm(iForm As Form)

        With iForm

            iForm.FormBorderStyle = FormBorderStyle.None
            iForm.Left = 0
            iForm.Top = 0
            iForm.Width = Me.Width - 140
            iForm.Height = Me.Height - 114

            iForm.MdiParent = Me
            iForm.Show()

        End With

    End Sub

    Private Sub ContactViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactViewerToolStripMenuItem.Click

        frmContactViewer.MdiParent = Me
        frmContactViewer.Show()

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click

        Customer.MdiParent = Me
        Customer.Show()

    End Sub

    Private Sub ProductCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCategoryToolStripMenuItem.Click

        frmParentCategory.MdiParent = Me
        frmParentCategory.Show()

    End Sub

    Private Sub SubCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoryToolStripMenuItem.Click

        frmCategory.MdiParent = Me
        frmCategory.Show()

    End Sub

    Private Sub LocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationsToolStripMenuItem.Click

        ShowForm(Shop)

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        ChangePassword.MdiParent = Me
        ChangePassword.Show()

    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click

        Users.MdiParent = Me
        Users.Show()

    End Sub

    Private Sub ColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorsToolStripMenuItem.Click

        Colors.MdiParent = Me
        Colors.Show()

    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click

        frmProducts.MdiParent = Me
        frmProducts.Show()

    End Sub

End Class