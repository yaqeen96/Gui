Imports System.IO
Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ofd.ShowDialog()
        sfd.ShowDialog()
        Dim p1, p2 As String
        p1 = ofd.FileName
        p2 = sfd.FileName

        ' File.Copy(p1, p2)
        Dim a() As Byte
        Dim b() As Byte
        a = File.ReadAllBytes(p1)
        b = File.ReadAllBytes(p1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim p1, p2 As String
        Dim a() As Byte
        Dim b() As Byte
        Dim c() As Byte

        ofd.ShowDialog()
        p1 = ofd.FileName
        a = File.ReadAllBytes(p1)

        ofd.ShowDialog()
        p1 = ofd.FileName
        b = File.ReadAllBytes(p1)

        sfd.ShowDialog()
        p2 = sfd.FileName

        ReDim c(a.Length / 4 + b.Length * 3 / 4)
        For i = 0 To a.Length / 4 - 1
            c(i) = a(i)
        Next
        For i = 0 To b.Length * 3 / 4 - 1
            c(i + a.Length / 4) = b(i)
        Next
        sfd.ShowDialog()
        p2 = sfd.FileName
        File.WriteAllBytes(p2, c)

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim p1, p2 As String
        Dim a() As Byte
        Dim b() As Byte
        Dim c() As Byte

        ofd.ShowDialog()
        p1 = ofd.FileName
        a = File.ReadAllBytes(p1)
        ofd.ShowDialog()
        p1 = ofd.FileName
        b = File.ReadAllBytes(p1)
        sfd.ShowDialog()
        p2 = sfd.FileName

        ReDim c(a.Length / 4 + b.Length * 3 / 4)
        Array.Copy(a, c, a.Length \ 4)
        Array.Copy(b, 0, c, a.Length \ 4, b.Length * 3 \ 4)

        sfd.ShowDialog()
        p2 = sfd.FileName
        File.WriteAllBytes(p2, c)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim p1 As String
        fbd.ShowDialog()
        p1 = fbd.SelectedPath
        Dim st() As String = Directory.GetFiles(p1)
        '     lb1.Items.AddRange(st)
        'dgv.Rows.Add(p1)

        ListView1.Items.Add(p1)
    End Sub
End Class
