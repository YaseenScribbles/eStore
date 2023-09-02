'********************************** in the name of Allah, most merciful, most compassionate **************************
Imports System.Data.SqlClient
Public Class VendorUpdater

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub VendorUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from grnmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbNVendor, SQL, "vendorname", "vendorid")

        '- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from rvchmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor2, SQL, "vendorname", "vendorid")

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbNVendor2, SQL, "vendorname", "vendorid")

        '- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmbVendor3, SQL, "vendorname", "vendorid")


    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub
        SQL = "select grnno from grnmaster where vendorid=" & IIf(cmbVendor.SelectedValue.ToString.Contains("Row"), 0, cmbVendor.SelectedValue) & " order by grnno"
        ESSA.LoadCombo(cmbGRN, SQL, "grnno")

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If EnableUpdate() Then

            If cmbNVendor.SelectedIndex = -1 Then
                Exit Sub
            ElseIf cmbGRN.SelectedIndex = -1 Then
                Exit Sub
            ElseIf ESSA.ISFound("select grnno from grnmaster where grnno=" & Val(cmbGRN.Text) & " and billno<>0") = True Then
                MsgBox("Cannot update, Bill is currently locked..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            SQL = "update grnmaster set vendorid=" & cmbNVendor.SelectedValue & " where grnno=" _
                & Val(cmbGRN.Text) & ";update ordermaster set vendorid=" & cmbNVendor.SelectedValue & " where " _
                & " grnno=" & Val(cmbGRN.Text)
            ESSA.Execute(SQL)

            SQL = "UPDATE ProductMaster SET VendorId = " & cmbNVendor.SelectedValue & ", IsUpdated = 0 WHERE PluID IN (" _
                   & "SELECT PluID FROM GRNDetails WHERE GrnNo = " & Val(cmbGRN.Text) & ")"
            ESSA.Execute(SQL)

            MsgBox("Updated successfully..!", MsgBoxStyle.Information)
            cmbVendor.Focus()

        Else

            MsgBox("Access Denied", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click

        If cmbNVendor2.SelectedIndex = -1 Then
            Exit Sub
        ElseIf cmbGRN2.SelectedIndex = -1 Then
            Exit Sub
        ElseIf ESSA.ISFound("select vchno from rvchmaster where vchno=" & Val(cmbGRN2.Text) & " and billno<>0") = True Then
            MsgBox("Cannot update, Bill is currently locked..!", MsgBoxStyle.Critical)
            Exit Sub

        End If

        If EnableUpdate() Then

            SQL = "update rvchmaster set vendorid=" & cmbNVendor2.SelectedValue & " where vchno=" & Val(cmbGRN2.Text)

            ESSA.Execute(SQL)

            MsgBox("Updated successfully..!", MsgBoxStyle.Information)
            cmbVendor2.Focus()

        Else

            MsgBox("Access Denied", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub cmbVendor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor2.SelectedIndexChanged

        If cmbVendor2.SelectedIndex = -1 Then Exit Sub
        SQL = "select vchno from rvchmaster where vendorid=" & IIf(cmbVendor2.SelectedValue.ToString.Contains("Row"), 0, cmbVendor2.SelectedValue) & " order by vchno"
        ESSA.LoadCombo(cmbGRN2, SQL, "vchno")

    End Sub

    Private Sub cmbVendor3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor3.SelectedIndexChanged

        If cmbVendor3.SelectedIndex > 0 Then
            SQL = "select grnno from grnmaster where vendorid=" & IIf(cmbVendor3.SelectedValue.ToString.Contains("Row"), 0, cmbVendor3.SelectedValue) & " order by grnno"
            ESSA.LoadCombo(cmbGRN3, SQL, "grnno")
        End If

    End Sub

    Private Sub cmbGRN3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGRN3.SelectedIndexChanged

        SQL = "SELECT PaidStatus,ISNULL(Paid,0) FROM LR_Payment WHERE GrnNo =" & Val(cmbGRN3.Text)
        With ESSA.OpenReader(SQL)
            If .Read Then
                cmbLRPaid.SelectedIndex = IIf(.Item(0) = 1, 0, 1)
                TxtLR.Text = Format(.Item(2), "0.00")
            Else
                cmbLRPaid.SelectedIndex = -1
            End If
            .Close()
        End With

    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click

        If EnableUpdate() Then

            If ifExist() Then
                SQL = "UPDATE LR_Payment SET PaidStatus =" & IIf(cmbLRPaid.SelectedIndex = 0, 1, 0) & ",Paid = " & Val(TxtLR.Text) & " WHERE GrnNo =" & Val(cmbGRN3.Text)
                ESSA.Execute(SQL)
            Else
                SQL = "INSERT INTO LR_Payment VALUES ( " _
                    & Val(cmbGRN3.Text) & "," _
                    & IIf(cmbLRPaid.SelectedIndex = 0, 1, 0) & "," _
                    & IIf(cmbLRPaid.SelectedIndex = 0, Val(TxtLR.Text), 0) & ")"
                ESSA.Execute(SQL)
            End If

            MsgBox("Updated successfully..!", MsgBoxStyle.Information)
            cmbVendor3.Focus()

        Else

            MsgBox("Access Denied", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Function ifExist() As Boolean

        ifExist = False
        SQL = "SELECT * FROM LR_Payment WHERE GrnNo = " & Val(cmbGRN3.Text)
        With ESSA.OpenReader(SQL)

            If .Read Then
                ifExist = True
            End If
            .Close()
        End With

    End Function

    Private Function EnableUpdate() As Boolean

        Select Case UserID
            Case 1
                EnableUpdate = True
            Case 9
                EnableUpdate = True
            Case 10
                EnableUpdate = True
            Case 14
                EnableUpdate = True
            Case Else
                EnableUpdate = False
        End Select

    End Function

End Class