Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Newcontrol1.spin()
        Newcontrol2.spin()
        Newcontrol3.spin()
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Newcontrol1.itemvalue
        Label2.Text = Newcontrol2.itemvalue
        Label3.Text = Newcontrol3.itemvalue
        Timer2.Enabled = False
        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then
            TextBox1.Text = "You Win"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = "1.00"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = ".25"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ".10"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ".05"
    End Sub
End Class
