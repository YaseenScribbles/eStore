Option Explicit On
Option Strict On

Imports System.ComponentModel

Public Class cTextBox
    Inherits TextBox

    Private clrBorder As Color = Color.Black
    Private style As CustomBorderStyles = BorderStyleCustom.CustomColor
    Private blnCustomChange As Boolean



#Region "Properties and Enum"
    'the enumeration for my new property
    Enum CustomBorderStyles As Integer
        None = 0
        FixedSingle = 1
        Fixed3D = 2
        CustomColor = 3
    End Enum

    'New property. It will switch the textbox's borderstyle so it will be drawn correctly
    <Category("Appearance"), Description("Type of border around the control")> _
    Public Property BorderStyleCustom() As CustomBorderStyles
        Get
            Return style
        End Get
        Set(ByVal value As CustomBorderStyles)
            style = value
            blnCustomChange = True
            If value = CustomBorderStyles.CustomColor Then
                Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            Else
                If value = CustomBorderStyles.Fixed3D Then
                    Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                End If
                If value = CustomBorderStyles.FixedSingle Then
                    Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                End If
                If value = CustomBorderStyles.None Then
                    Me.BorderStyle = Windows.Forms.BorderStyle.None
                End If
            End If
            blnCustomChange = False
        End Set
    End Property

    'The color of the border (if selected)
    <Category("Appearance"), Description("Color of the Single border if BorderStyles is CustomColor")> _
    Public Property BorderColor() As Color
        Get
            Return clrBorder
        End Get
        Set(ByVal value As Color)
            clrBorder = value
        End Set
    End Property
#End Region

    'This is so the custom border isn't drawn when the textbox's original borderstyle is changed
    'Note: I did it this way because I was having a few issues with overloading the
    'textbox's original BorderStyle property
    Private Sub TextboxCustBorder_BorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.BorderStyleChanged
        If blnCustomChange = False Then
            Dim int As Integer = CInt(Me.BorderStyle)
            Me.BorderStyleCustom = CType(int, CustomBorderStyles)
        End If
    End Sub

    'Invalidate the textbox so the border is redrawn
    Private Sub TextboxCustBorder_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Me.Invalidate()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        'this is where the actually drawing occurs
        If m.Msg = 15 And Me.BorderStyleCustom = CustomBorderStyles.CustomColor Then
            Dim g As Graphics = Me.CreateGraphics
            g.DrawRectangle(New Pen(clrBorder, 1), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            g.Dispose()
        End If
    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        Me.BackColor = nFocusBackColor
        Me.ForeColor = Color.White
        clrBorder = nFocusBorderColor
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        Me.BackColor = nNormalBackColor
        Me.ForeColor = Color.Black
        clrBorder = nNormalBorderColor
        Me.Invalidate()
    End Sub

    Private nNormalBackColor As Color
    Private nFocusBackColor As Color
    Private nNormalBorderColor As Color
    Private nFocusBorderColor As Color
    Private nAcceptEmptyWords As Boolean = True
    Private nAcceptBackwards As Boolean = True

    Public Property NormalBackColor() As Color
        Get
            Return nNormalBackColor
        End Get
        Set(ByVal value As Color)
            nNormalBackColor = value
        End Set
    End Property

    Public Property FocusBackColor() As Color
        Get
            Return nFocusBackColor
        End Get
        Set(ByVal value As Color)
            nFocusBackColor = value
        End Set
    End Property
    Public Property FocusBorderColor() As Color
        Get
            Return nFocusBorderColor
        End Get
        Set(ByVal value As Color)
            nFocusBorderColor = value
        End Set
    End Property

    Public Property NormalBorderColor() As Color
        Get
            Return nNormalBorderColor
        End Get
        Set(ByVal value As Color)
            nNormalBorderColor = value
        End Set
    End Property

    Public Property AcceptEmptyWords() As Boolean
        Get
            Return nAcceptEmptyWords
        End Get
        Set(ByVal value As Boolean)
            nAcceptEmptyWords = value
        End Set
    End Property

    Public Property AcceptBackwards() As Boolean
        Get
            Return nAcceptBackwards
        End Get
        Set(ByVal value As Boolean)
            nAcceptBackwards = value
        End Set
    End Property

End Class
