Imports System.Data.SqlClient

Public Class frmCategorywise_Bill

    Private Sub frmCategorywise_Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT VendorId, VendorName FROM Vendors ORDER BY VendorName"
        ESSA.LoadCombo(cmbVendor, SQL, "VendorName", "VendorId", "All Vendors")

        dtpBegin.Select()

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex > 0 Then

            SQL = "SELECT InvNo FROM GrnMaster WHERE VendorId = " _
                & cmbVendor.SelectedValue & " AND InvDt BETWEEN '" _
                & Format(dtpBegin.Value, "yyyy-MM-dd") & "' AND '" _
                & Format(dtpEnd.Value, "yyyy-MM-dd") & "'"

            ESSA.LoadCombo(cmbBills, SQL, "InvNo")

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) 

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub

    Private Sub frmCategorywise_Bill_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.Tag <> "1" Then
                Me.ProcessTabKey(True)
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If cmbBills.Text <> "" Then

            LoadCatLink()

        End If

    End Sub

    Private Sub LoadCatLink()

        SQL = "SELECT DISTINCT CatLink FROM ProductMaster M WHERE EXISTS " _
           & "(SELECT * FROM GrnMaster G,GRNDetails D WHERE G.GrnNo = D.GRNNo AND D.PluID = M.Size AND G.VendorId = " _
           & cmbVendor.SelectedValue & " AND G.InvNo = '" _
           & cmbBills.Text.Trim & "' AND G.InvDt BETWEEN '" _
           & Format(dtpBegin.Value, "yyyy-MM-dd") & "' AND '" _
           & Format(dtpEnd.Value, "yyyy-MM-dd") & "')"

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = .GetString(0).Trim
            End While
            .Close()
        End With

        cmbVendor.Focus()

    End Sub

    Private Sub cmbBills_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBills.KeyUp

        If e.KeyCode = Keys.Enter Then
            btnLoad.PerformClick()
        End If

    End Sub

End Class