Public Class DiscountUnlocker

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        txtCode.Text = GenerateCode(txtID.Text)

    End Sub

    Private Function GenerateCode(ByVal id As Integer) As Long

        GenerateCode = ((id * 3) + (17 + 21))
        GenerateCode = GenerateCode * (id * 3)

    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub DiscountUnlocker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtID.Select()

    End Sub

End Class