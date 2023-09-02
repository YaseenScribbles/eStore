Public Class frmChequeDetails

    Private Sub frmChequeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT VendorId,VendorName FROM Vendors ORDER BY VendorName"
        ESSA.LoadCombo(cmbVendor, SQL, "VendorName", "VendorId", "All Vendors")

        dtpFrom.Select()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        MainWindowX.CloseTab(Me.Name)

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        SQL = "SELECT A.BillNo,B.VendorName,A.ChequeNo,A.ChequeDate,A.Notes FROM " _
        & "(SELECT * FROM PaymentNotes) A " _
        & "LEFT JOIN " _
        & "(SELECT M.BillNo,M.BillDt,V.VendorName,M.VendorId FROM PaymentMaster M, Vendors V WHERE M.VendorID = V.VendorID) B " _
        & "ON A.BillNo = B.BillNo WHERE B.BillDt BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

        If cmbVendor.SelectedIndex > 0 Then
            SQL &= "  AND B.VendorId =" & cmbVendor.SelectedValue
        End If

        SQL &= " ORDER BY A.BillNo"

        With ESSA.OpenReader(SQL)
            dgvCheque.Rows.Clear()
            While .Read

                Dim Notes As String = ""
                Dim Row = dgvCheque.Rows.Add()
                dgvCheque.Item(0, Row).Value = .Item(0)
                dgvCheque.Item(1, Row).Value = .GetString(1).Trim
                dgvCheque.Item(2, Row).Value = .GetString(2).Trim
                dgvCheque.Item(3, Row).Value = Format(.GetDateTime(3), "dd-MM-yyyy")
                'Notes = .GetString(4).Trim
                'Notes = String.Replace("                                                                                                       ", "")
                dgvCheque.Item(4, Row).Value = removeWhiteSpaces(.GetString(4).Trim)

            End While
            .Close()
        End With

    End Sub

    Public Function removeWhiteSpaces(text As String) As String

        Dim result As String = String.Empty

        Dim textCharArr As Char() = text.ToCharArray
        Dim prevChar As Char = " "c

        For i As Integer = 0 To textCharArr.Length - 1

            Dim CurrentChar = textCharArr(i)
            If prevChar = " "c AndAlso CurrentChar = prevChar Then
                Continue For
            Else
                result = result + CurrentChar
            End If
            prevChar = CurrentChar

        Next

        Return result

    End Function

End Class