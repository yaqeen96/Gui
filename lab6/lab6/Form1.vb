Imports System.IO
Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim a() As Byte = File.ReadAllBytes("C:\Users\Taiba\Desktop\a.jpg")
        Dim b() As Byte = File.ReadAllBytes("C:\Users\Taiba\Desktop\b.jpg")
        Dim c() As Byte

        ReDim c(a.Length + b.Length)

        Array.Copy(a, c, a.Length)
        Array.Copy(b, 0, c, a.Length, b.Length)
        sfd.ShowDialog()
        File.WriteAllBytes(sfd.FileName, c)

    End Sub
End Class
