Imports System.IO
Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim f1, f2, f3, f4, f5 As String
        Dim b1(), b2(), b3(), b4(), b5() As Byte
        Dim ofd As New OpenFileDialog
        Dim sfd As New SaveFileDialog
        ofd.ShowDialog()
        f1 = ofd.FileName
        ofd.ShowDialog()
        f2 = ofd.FileName
        ofd.ShowDialog()
        f3 = ofd.FileName
        ofd.ShowDialog()
        f4 = ofd.FileName

        b1 = File.ReadAllBytes(f1)
        b2 = File.ReadAllBytes(f2)
        b3 = File.ReadAllBytes(f3)
        b4 = File.ReadAllBytes(f4)
        ReDim b5(b1.Length * 1 \ 4 + b2.Length * 1 \ 4 + b3.Length * 1 \ 4 + b4.Length * 1 \ 4)
        Array.Copy(b1, b5, b1.Length * 1 \ 4)
        Array.Copy(b2, 0, b5, b1.Length * 1 \ 4, b2.Length * 1 \ 4)
        Array.Copy(b3, 0, b5, b1.Length * 1 \ 4 + b2.Length * 1 \ 4, b3.Length * 1 \ 4)
        Array.Copy(b4, 0, b5, b3.Length * 1 \ 4 + b1.Length * 1 \ 4 + b2.Length * 1 \ 4, b4.Length * 1 \ 4)
        sfd.ShowDialog()
        File.WriteAllBytes(sfd.FileName, b5)
    End Sub
End Class
