

Imports System.Drawing

Imports System.Collections

Imports System.ComponentModel

Imports System.Windows.Forms

Imports System.Data





Namespace transcontroldemo


    Public Class TransPanel
        Inherits Panel




        Private Wriggler As New Timer()



        Public Sub New()


            '

            ' TODO: Add constructor logic here

            '



            'Wriggler.Tick += New EventHandler(AddressOf TickHandler)

            'AddHandler Wriggler.Tick, AddressOf TickHandler

            'Me.Wriggler.Interval = 500


            'Me.Wriggler.Enabled = True
        End Sub



        'Protected Sub TickHandler(sender As Object, e As EventArgs)


        '    Me.InvalidateEx()

        'End Sub



        Protected Overrides ReadOnly Property CreateParams() As CreateParams


            Get


                Dim cp As CreateParams = MyBase.CreateParams

                cp.ExStyle = cp.ExStyle Or &H20
                'WS_EX_TRANSPARENT

                Return cp
            End Get
        End Property




        Protected Sub InvalidateEx()


            If Parent Is Nothing Then

                Return
            End If



            Dim rc As New Rectangle(Me.Location, Me.Size)

            Parent.Invalidate(rc, True)

        End Sub



        Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)


            'do not allow the background to be painted 

        End Sub



        Private r As New Random()



        Protected Overrides Sub OnPaint(e As PaintEventArgs)


            Dim h As Integer = Me.Height / 2

            Dim w As Integer = Me.Width / 2



            Dim p As New Pen(Color.Black, 2)

            Dim x As Integer, y As Integer

            x = 0
            y = 0
            While x < w



                e.Graphics.DrawEllipse(p, x + r.[Next](10) - 5, y + r.[Next](10) - 5, Me.Width - (2 * x), Me.Height - (2 * y))
                x += w / 10
                y += h / 10
            End While



            p.Dispose()

        End Sub





    End Class

End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
