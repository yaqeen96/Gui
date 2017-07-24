Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As StreamReader = New StreamReader("p.txt", True)
        While sr.Peek() > 0
            Dim st() As String = sr.ReadLine().Split(";")
            dgv.Rows.Add(New String() {st(0), st(1), st(2)})
        End While
        sr.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        File.Delete("p.txt")
        Dim sw As StreamWriter = New StreamWriter("p.txt", True)
        For i = 0 To dgv.Rows.Count - 1
            sw.WriteLine(dgv.Rows(i).Cells(0).Value + ";" + dgv.Rows(i).Cells(1).Value + ";" + dgv.Rows(i).Cells(2).Value)
        Next
        sw.Close()
    End Sub
End Class
