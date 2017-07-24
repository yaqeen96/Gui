Imports System.IO
Public Class Form1

    Private Sub btncopy_Click(sender As Object, e As EventArgs) Handles btncopy.Click
        Dim p1, p2 As String
        Dim a() As Byte
        Dim b() As Byte
        Dim c() As Byte

        ofd.ShowDialog()
        a = File.ReadAllBytes(ofd.FileName)

        ofd.ShowDialog()
        b = File.ReadAllBytes(ofd.FileName)

        ReDim c(a.Length + b.Length)

        'For i = 0 To a.Length - 1
        '    c(i) = a(i)
        'Next
        'For i = 0 To b.Length - 1
        '    c(i + a.Length) = b(i)
        'Next
        Array.Copy(a, c, a.Length)
        Array.Copy(b, 0, c, a.Length, b.Length)
        sfd.ShowDialog()
        File.WriteAllBytes(sfd.FileName, c)

    End Sub

    Private Sub btnlb_Click(sender As Object, e As EventArgs) Handles btnlb.Click
        Dim p1 As String
        fbd1.ShowDialog()
        p1 = fbd1.SelectedPath
        Dim st() As String = Directory.GetFiles(p1)
        'Lb1.Items.AddRange(st)
        ' lv1.Items.AddRange(st)
        dgv.Rows.AddRange(p1)
    End Sub
End Class
