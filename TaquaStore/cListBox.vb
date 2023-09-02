Imports System.Data.SqlClient

Public Class cListBox

    Private NameFlag As String = ""
    Private IDFlag As String = ""
    Private cListHeader As String = "Untitled"
    Private LstTbl As New DataTable

    Public Property ListHeader() As String
        Get
            Return cListHeader
        End Get
        Set(ByVal value As String)
            cListHeader = value
            LstHead.Text = cListHeader
        End Set
    End Property

    'Public Sub ProcessKeyDown(TargetCtl As Control, NxtCtl As Control, e As KeyEventArgs)

    '    If e.KeyCode = Keys.Down Then
    '        ChangeSelection(True)
    '    ElseIf e.KeyCode = Keys.Up Then
    '        ChangeSelection(False)
    '    ElseIf e.KeyCode = Keys.Enter Then
    '        'e.SuppressKeyPress = True
    '        'If LstAgt.Lst.SelectedIndex = -1 Then Exit Sub
    '        'AgentID = LstAgt.Lst.SelectedValue
    '        'txtAgent.Text = LstAgt.Lst.Text
    '        NxtCtl.Focus()
    '    End If

    'End Sub

    Private Sub GetData(iSQL As String)

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(iSQL, Con)
            LstTbl.Clear()
            Adp.Fill(LstTbl)
        End Using
        Con.Close()

    End Sub

    Public Sub LoadListItems(iSQL As String, vName As String, vID As String)

        GetData(iSQL)
        NameFlag = vName
        IDFlag = vID

        Lst.DataSource = LstTbl
        Lst.DisplayMember = NameFlag
        Lst.ValueMember = IDFlag

    End Sub

    Public Sub FilterListItems(FilterValue As String)

        Try

            Dim DR = LstTbl.Select(NameFlag & " LIKE '%" & FilterValue & "%'").CopyToDataTable
            Lst.DataSource = DR
            Lst.DisplayMember = NameFlag
            Lst.ValueMember = IDFlag

        Catch ex As Exception

            Lst.DataSource = Nothing

        End Try

    End Sub

    Public Sub ChangeSelection(ISDown As Boolean)

        If Lst.Items.Count <= 0 Then Exit Sub

        If ISDown = True Then
            If Lst.SelectedIndex = Lst.Items.Count - 1 Then Exit Sub
            Lst.SelectedIndex += 1
        Else
            If Lst.SelectedIndex = 0 Then Exit Sub
            Lst.SelectedIndex -= 1
        End If

    End Sub

    Public Sub InitManual()

        LstTbl.Clear()
        LstTbl.Columns.Add("ID", System.Type.GetType("System.String"))
        LstTbl.Columns.Add("Name", System.Type.GetType("System.String"))
        IDFlag = "ID"
        NameFlag = "Name"

    End Sub

    Public Sub AddListItems(DisplayText As String, IDValue As String)

        Dim Dr = LstTbl.NewRow
        Dr(0) = IDValue
        Dr(1) = DisplayText
        LstTbl.Rows.Add(Dr)

    End Sub

End Class
