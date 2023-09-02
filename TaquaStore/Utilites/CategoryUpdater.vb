Public Class CategoryUpdater

    Private CatID(0 To 5) As Byte
    Private CatDesc(0 To 5) As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub


    Private Sub PopulateTreeview()

        SQL = "select catid,catdesc from category order by catid;" _
            & "select pvscatid,scatid,scatdesc from categorylevels where cattype=1 order by pvscatid,scatid"

        With ESSA.OpenReader(SQL)

            TVCat.Nodes.Clear()

            While .Read
                TVCat.Nodes.Add(.Item(0), .GetString(1).Trim)
            End While

            .NextResult()

            While .Read

                Dim TN As TreeNode() = TVCat.Nodes.Find(.Item(0), True)
                If TN.Length > 0 Then
                    TN(0).Nodes.Add(.Item(1), .GetString(2).Trim)
                End If

            End While

            .Close()

        End With

    End Sub

    Private Sub CategoryUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopulateTreeview()

        SQL = "select vendorid,vendorname from vendors where vendorid in (" _
            & "select distinct vendorid from grnmaster) order by vendorname"
        ESSA.LoadCombo(cmbVendor, SQL, "vendorname", "vendorid")

    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendor.SelectedIndexChanged

        If cmbVendor.SelectedIndex = -1 Then Exit Sub
        SQL = "select grnno from grnmaster where vendorid=" & IIf(cmbVendor.SelectedValue.ToString.Contains("Row"), 0, cmbVendor.SelectedValue) & " order by grnno"
        ESSA.LoadCombo(cmbGRN, SQL, "grnno")

    End Sub

    Private Sub tvCat_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCat.NodeMouseDoubleClick

        If e.Node Is Nothing Then Exit Sub

        For i As Byte = 0 To 5
            CatID(i) = 0
            CatDesc(i) = ""
        Next

        txtSCat.Text = e.Node.FullPath
        CatID(e.Node.Level) = e.Node.Name
        CatDesc(e.Node.Level) = e.Node.Text

        Dim t = e.Node.Parent
        Do Until t Is Nothing
            CatID(t.Level) = t.Name
            CatDesc(t.Level) = t.Text
            t = t.Parent
        Loop

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If cmbGRN.SelectedIndex = -1 Then Exit Sub
        If txtSCat.Text.Trim = "" Then Exit Sub

        If MsgBox("Are you sure, do you want to update!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        SQL = "UPDATE PRODUCTMASTER SET CATLINK='" & txtSCat.Text.Trim & "' WHERE " _
            & "PLUID IN (SELECT DISTINCT PLUID FROM GRNDETAILS WHERE GRNNO=" & Val(cmbGRN.Text) & ");"

        SQL &= "UPDATE PRODUCTLEVELS SET CATID=" & CatID(0) & "," _
            & "CATDESC='" & CatDesc(0) & "'," _
            & "SCATID1=" & CatID(1) & "," _
            & "SCATDESC1='" & CatDesc(1) & "'," _
            & "SCATID2=" & CatID(2) & "," _
            & "SCATDESC2='" & CatDesc(2) & "'," _
            & "SCATID3=" & CatID(3) & "," _
            & "SCATDESC3='" & CatDesc(3) & "'," _
            & "SCATID4=" & CatID(4) & "," _
            & "SCATDESC4='" & CatDesc(4) & "'," _
            & "SCATID55=" & CatID(5) & "," _
            & "SCATDESC5='" & CatDesc(5) & "' WHERE PLUID IN " _
            & "(SELECT DISTINCT PLUID FROM GRNDETAILS WHERE GRNNO=" & Val(cmbGRN.Text) & ")"

        ESSA.Execute(SQL)
        MsgBox("Product updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub tvCat_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvCat.AfterSelect

    End Sub
End Class