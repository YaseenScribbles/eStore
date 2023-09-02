Public Class frmContactViewer
    Private Sub frmContactViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT VENDORID,VENDORNAME FROM VENDORS ORDER BY VENDORNAME"
        ESSA.LoadCombo(cmbVendor, SQL, "VENDORNAME", "VENDORID")

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        SQL = "SELECT ADDRESS1,ADDRESS2,CITY,STATE,COUNTRY,PHONE,MOBILE,FAX,EMAIL FROM VENDORS WHERE VENDORID=" & cmbVendor.SelectedValue
        With ESSA.OpenReader(SQL)
            If .Read Then
                lblAdd1.Text = .GetString(0).Trim
                lblAdd2.Text = .GetString(1).Trim
                lblCity.Text = .GetString(2).Trim
                lblState.Text = .GetString(3).Trim
                lblCountry.Text = .GetString(4).Trim
                lblPhone.Text = .GetString(5).Trim
                lblMobile.Text = .GetString(6).Trim
                lblWApp.Text = .GetString(7).Trim
                lblEmailID.Text = .GetString(8).Trim
            End If
            .Close()
        End With

        cmbVendor.Focus()

    End Sub

    Private Sub frmContactViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                Close()

        End Select

    End Sub

End Class