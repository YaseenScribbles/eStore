Public Class VendorViewer
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        If chkAgent.Checked = False Then

            SQL = "select a.agentname,v.address1,v.address2,v.address3,v.city,v.state,v.country,v.phone,v.mobile,v.email,v.vat,v.gst from " _
                & " vendors v,agents a where v.agentid=a.agentid and v.vendorid=" & cmbVendor.SelectedValue

        Else

            SQL = "select agentname,address1,address2,'',city,state,'',phone,mobile,email,'','' from " _
                & "agents where agentid=" & cmbVendor.SelectedValue

        End If

        With ESSA.OpenReader(SQL)
            If .Read Then
                txtV1.Text = .GetString(0).Trim
                txtV2.Text = .GetString(1).Trim
                txtV3.Text = .GetString(2).Trim
                txtV4.Text = .GetString(3).Trim
                txtV5.Text = .GetString(4).Trim
                txtV6.Text = .GetString(5).Trim
                txtV7.Text = .GetString(6).Trim
                txtV8.Text = .GetString(7).Trim
                txtV9.Text = .GetString(8).Trim
                txtV10.Text = .GetString(9).Trim
                txtV11.Text = .GetString(10).Trim
                txtV12.Text = .GetString(11).Trim
            End If
            .Close()
        End With

    End Sub

    Private Sub cmbVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbVendor.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnView.PerformClick()
        End If

    End Sub

    Private Sub VendorViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape

                If MsgBox("Are you sure, Do you want to exit..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Sub VendorViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vendor_list()

    End Sub

    Private Sub chkAgent_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgent.CheckedChanged

        If chkAgent.Checked = True Then
            agent_list()
        Else
            vendor_list()
        End If

        ESSA.ClearTextBox(Me)

    End Sub

    Private Sub agent_list()

        SQL = "select agentid,agentname from agents order by agentname"
        ESSA.LoadCombo(cmbVendor, SQL, "agentname", "agentid")

    End Sub

    Private Sub vendor_list()

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

End Class