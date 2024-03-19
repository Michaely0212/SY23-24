Public Class mover
    Public Property Speed As Integer = 10
    Public Property interval As Integer = 500
    Public Property sprite As PictureBox
    Dim Xdir As Integer = 1
    Dim Ydir As Integer = 0

    Private Sub mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = interval
        If Not sprite Is Nothing Then
            Timer1.Enabled = True
            sprite.Left = Me.Left
            sprite.Top = Me.Top
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += Xdir * Speed
            sprite.Top += Ydir * Speed
            If sprite.Left > Me.Left + Me.Width And Xdir = 1 Then
                Xdir = 0
                Ydir = 1
            End If
            If sprite.Left < Me.Left And Xdir = -1 Then
                Xdir = 0
                Ydir = -1
            End If
            If sprite.Top > Me.Top + Me.Height And Ydir = 1 Then
                Ydir = 0
                Xdir = -1
            End If
            If sprite.Top < Me.Top And Ydir = -1 Then
                Ydir = 0
                Xdir = 1
            End If
        End If
    End Sub
End Class
