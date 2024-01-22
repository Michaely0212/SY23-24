Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        savetofile()
    End Sub
    Sub savetofile()
        Dim r As String
        r += Field1.Text
        r += "|"
        r += Field2.Text
        r += "|"
        r += Field3.Text
        r += "|"
        r += Field4.Text
        r += "|"
        r += Field5.Text
        r += "|"
        r += PictureBox1.ImageLocation
        If count = 0 Then count = 1
        records(current) = r
        Dim outfile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outfile.WriteLine(records(index))
        Next
        outfile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            showrecord(0)
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        PictureBox1.Image = Nothing
        If records(index) <> Nothing Then
            Dim fields() As String
            fields = records(index).Split("|")
            Field1.Text = fields(0)
            Field2.Text = fields(1)
            Field3.Text = fields(2)
            Field4.Text = fields(3)
            Field5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub firstbutton_Click(sender As Object, e As EventArgs) Handles firstbutton.Click
        savetofile()
        current = 0
        showrecord(current)
    End Sub

    Private Sub lastbutton_Click(sender As Object, e As EventArgs) Handles lastbutton.Click
        savetofile()
        If count > 0 Then
            current = count - 1
        End If
        showrecord(current)
    End Sub
    Private Sub prevbutton_Click(sender As Object, e As EventArgs) Handles prevbutton.Click
        savetofile()
        If current > 0 Then
            current = current - 1
        End If
        showrecord(current)
    End Sub

    Private Sub nextbutton_Click(sender As Object, e As EventArgs) Handles nextbutton.Click
        savetofile()
        If current < count - 1 Then
            current = current + 1
        End If
        showrecord(current)
    End Sub
End Class
