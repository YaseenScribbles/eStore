Public Class ucTabHeader

    Private cLineColor As Color = Color.Black
    Private cTabNormalBackColor As Color = Color.Black
    Private cTabNormalForeColor As Color = Color.Black
    Private cTabFocusBackColor As Color = Color.Black
    Private cTabFocusForeColor As Color = Color.Black
    Private cTabHoverBackColor As Color = Color.Black
    Private ActiveTabKey As String = ""
    Public Property TabLineColor() As Color
        Get
            Return cLineColor
        End Get
        Set(ByVal value As Color)
            cLineColor = value
            TabBorder.LineColor = cLineColor
        End Set
    End Property

    Public Property TabNormalBackColor() As Color
        Get
            Return cTabNormalBackColor
        End Get
        Set(ByVal value As Color)
            cTabNormalBackColor = value
        End Set
    End Property

    Public Property TabNormalForeColor() As Color
        Get
            Return cTabNormalForeColor
        End Get
        Set(ByVal value As Color)
            cTabNormalForeColor = value
        End Set
    End Property

    Public Property TabFocusBackColor() As Color
        Get
            Return cTabFocusBackColor
        End Get
        Set(ByVal value As Color)
            cTabFocusBackColor = value
        End Set
    End Property

    Public Property TabFocusForeColor() As Color
        Get
            Return cTabFocusForeColor
        End Get
        Set(ByVal value As Color)
            cTabFocusForeColor = value
        End Set
    End Property

    Public Property TabHoverBackColor() As Color
        Get
            Return cTabHoverBackColor
        End Get
        Set(ByVal value As Color)
            cTabHoverBackColor = value
        End Set
    End Property

    Private Sub ClickButton(Sender As Object, e As EventArgs)

        'If CType(Sender, Button).Name <> ActiveTabKey Then

        ActivateTab(CType(Sender, Button).Name)

        'End If

    End Sub
    Public Sub AddTab(TabText As String, FindKey As String)

        For Each ctl As Control In MyBase.Controls

            If TypeOf ctl Is Button Then

                If ctl.Name = FindKey Then
                    ActivateTab(FindKey)
                    Exit Sub
                    Exit For
                End If

            End If

        Next

        Dim ibtn As New Button
        lbltmp.Text = TabText

        AddHandler ibtn.Click, AddressOf ClickButton

        With ibtn

            MyBase.Controls.Add(ibtn)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Width = lbltmp.Width + 25
            .Text = TabText
            .Name = FindKey
            .Dock = DockStyle.Left
            .BringToFront()

        End With

        ActivateTab(FindKey)

    End Sub

    Public Sub ActivateTab(iName As String)

        For Each ctl As Control In MyBase.Controls

            If TypeOf ctl Is Button Then

                If ctl.Name = iName Then
                    MainWindowX3.tabMain.SelectTab(ctl.Name)
                    ActiveTabKey = iName
                    CType(ctl, Button).FlatAppearance.MouseOverBackColor = TabFocusBackColor
                    CType(ctl, Button).FlatAppearance.MouseDownBackColor = TabFocusBackColor
                    ctl.BackColor = TabFocusBackColor
                    ctl.ForeColor = TabFocusForeColor
                    ctl.Font = New Font(ctl.Font, FontStyle.Bold)
                Else
                    CType(ctl, Button).FlatAppearance.MouseOverBackColor = cTabHoverBackColor
                    CType(ctl, Button).FlatAppearance.MouseDownBackColor = cTabHoverBackColor
                    ctl.BackColor = TabNormalBackColor
                    ctl.ForeColor = TabNormalForeColor
                    ctl.Font = New Font(ctl.Font, FontStyle.Regular)
                End If

            End If

        Next

    End Sub

    Public Sub CloseTab(iName As String)

        For Each ctl As Control In MyBase.Controls

            If ctl.Name = iName Then
                ctl.Dispose()
            End If

        Next

    End Sub


End Class
