Imports System.Data.SqlClient

Public Class AgentList

    Private TblVdr As New DataTable
    Private GridHt As Short = 0
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs)

        TG.Columns.Clear()
        LoadData()

    End Sub

    Private Sub LoadData()

        SQL = "select agentid,agentcode 'Code',agentname 'Agent Name',Address1,Address2,City,State,Phone,Mobile,Email From " _
            & "agents order by agentname"

        'SQL = "select vendorcode 'Code',vendorname 'Vendor Name',agentname 'Group',v.Address1,v.City,v.State,v.Phone,v.Mobile,'' 'A/C Balance','' '  ' " _
        '    & "from vendors v,agents a " _
        '    & "where v.agentid=a.agentid " _
        '    & "order by vendorname"

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)

            Adp.Fill(TblVdr)

            For i As SByte = 1 To GetEmptyRowCount(TblVdr.Rows.Count)
                TblVdr.Rows.Add()
            Next

            TG.DataSource = TblVdr

        End Using
        Con.Close()

    End Sub

    Private Sub AlignReportHeader()

        If TG.Rows.Count <= 0 Then Exit Sub

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        TG.Columns(2).DefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)

        TG.Columns(0).Visible = False

        ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleLeft, 80)
        'ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleLeft, 300)
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleLeft, 200)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleLeft, 200)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 9, DataGridViewContentAlignment.MiddleLeft, 100)

        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleLeft, wSpaceWidth - 980)


    End Sub

    Private Function GetEmptyRowCount(RowCount As Integer) As SByte

        GetEmptyRowCount = 0

        Dim VRC As SByte = GridHt / 23
        Dim MRC As SByte = RowCount Mod VRC

        If MRC > 0 Then

            Dim FRC As SByte = VRC - MRC
            FRC = FRC - 1

            If FRC > 0 Then
                GetEmptyRowCount = FRC
            End If

        End If

    End Function

    Private Sub VendorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GridHt = wSpaceHeight - (Panel2.Height + Panel3.Height)

        LoadData()

        LstSch.InitManual()
        LstSch.AddListItems("Code", "")
        LstSch.AddListItems("Name", "")
        LstSch.AddListItems("Group", "")
        LstSch.AddListItems("Address", "")
        LstSch.AddListItems("City", "")
        LstSch.AddListItems("State", "")

        AlignReportHeader()

    End Sub

    Private Sub VendorList_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        SimpleLine5.Width = Me.Width
        pSearch.Left = (pnlSearch.Width - pSearch.Width) / 2

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        lblHead.BackColor = Color.FromArgb(202, 210, 216)
        pnlSearch.Visible = True
        txtfType.Focus()

    End Sub

    Private Sub txtfType_Enter(sender As Object, e As EventArgs) Handles txtfType.Enter

        LstSch.Visible = True

    End Sub

    Private Sub txtfType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfType.KeyDown

        If e.KeyCode = Keys.Down Then
            LstSch.ChangeSelection(True)
        ElseIf e.KeyCode = Keys.Up Then
            LstSch.ChangeSelection(False)
        ElseIf e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If LstSch.Lst.SelectedIndex = -1 Then Exit Sub
            'AgentID = LstAgt.Lst.SelectedValue
            txtfType.Text = LstSch.Lst.Text
            Me.ProcessTabKey(True)
        End If

    End Sub

    Private Sub txtfType_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfType.KeyUp

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then

        ElseIf e.KeyCode <> Keys.Enter Then
            LstSch.FilterListItems(txtfType.Text)
        End If

    End Sub

    Private Sub txtfType_Leave(sender As Object, e As EventArgs) Handles txtfType.Leave

        LstSch.Visible = False

    End Sub

    Private Sub txtFWord_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFWord.KeyUp

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then

        ElseIf e.KeyCode <> Keys.Enter Then
            FilterListItems(txtFWord.Text)
        End If

    End Sub

    Private Function GetFilterColumn(FieldName As String) As String

        GetFilterColumn = ""

        Select Case FieldName

            Case "Code"
                GetFilterColumn = "Code"
            Case "Name"
                GetFilterColumn = "[Agent Name]"

        End Select

    End Function

    Public Sub FilterListItems(FilterValue As String)

        Try

            Dim DR = TblVdr.Select(GetFilterColumn(txtfType.Text) & " LIKE '%" & FilterValue & "%'").CopyToDataTable

            For i As SByte = 1 To GetEmptyRowCount(DR.Rows.Count)
                DR.Rows.Add()
            Next

            TG.DataSource = DR

        Catch ex As Exception

            TG.DataSource = Nothing

        End Try

        AlignReportHeader()

    End Sub

End Class