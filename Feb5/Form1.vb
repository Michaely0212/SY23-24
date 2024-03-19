Public Class Form1
    Dim c As New Clicker
    Dim d As New Clicker
    Dim f As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.Increment = NumericUpDown1.Value
        c.Click()
        TextBox1.Text = c.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.Reset()
        TextBox1.Text = c.Count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        d.Increment = NumericUpDown2.Value
        d.Click()
        TextBox2.Text = d.Count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        d.Reset()
        TextBox2.Text = d.Count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        f.Increment = NumericUpDown2.Value
        f.Click()
        TextBox3.Text = f.Count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        f.Reset()
        TextBox3.Text = f.Count
    End Sub
End Class
