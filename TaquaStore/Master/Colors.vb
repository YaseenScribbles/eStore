'**************************** IN THE NAME OF ALLAH, MOST MERCIFUL, MOST COMPASSIONATE ***************************
Imports System.Data.SqlClient
Public Class Colors

    Private Sub Colors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.Tag <> "1" Then
                e.SuppressKeyPress = True
                Me.ProcessTabKey(True)
            End If
        End If

    End Sub

    Private Sub Colors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        LoadColors()

    End Sub

    Private Sub LoadColors()

        SQL = "select ColorId,code,color from TSColor order by color"
        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtCode.Text.Trim = "" Or txtColor.Text.Trim = "" Then
            Exit Sub
        ElseIf ESSA.ISFound("select ColorId from TSColor where code='" & txtCode.Text.Trim & "'") = True Then
            TTip.Show("Code already exists..!", txtCode, 0, 25, 2000)
            txtCode.SelectAll()
            txtCode.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select ColorId from TSColor where color='" & txtColor.Text.Trim & "'") = True Then
            TTip.Show("Color already exists..!", txtColor, 0, 25, 2000)
            txtColor.SelectAll()
            txtColor.Focus()
            Exit Sub
        End If

        SQL = "insert into TSColor values (" _
            & ESSA.GenerateID("select max(ColorId) from TSColor") & ",'" _
            & txtColor.Text.Trim & "','" _
            & txtCode.Text.Trim & "', 1, 1)"

        ESSA.OpenConnection()
        Using Cmd As New SqlCommand(SQL, Con)
            Cmd.ExecuteNonQuery()
        End Using
        Con.Close()

        TG.Rows.Add()
        TG.Item(0, TG.Rows.Count - 1).Value = 0
        TG.Item(1, TG.Rows.Count - 1).Value = txtCode.Text
        TG.Item(2, TG.Rows.Count - 1).Value = txtColor.Text

        txtCode.Clear()
        txtColor.Clear()
        txtCode.Focus()

    End Sub

    Private Sub txtColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColor.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub


    'Private Sub Colors_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    '    ESSA.CenterToScreen(Me, pnlWS)

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged

    End Sub
End Class