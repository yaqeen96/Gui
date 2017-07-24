Imports System.IO
Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sr As StreamReader = New StreamReader("d.txt", True)
        While sr.Peek() > 0
            Dim st() As String = sr.ReadLine().Split(";")
            lv1.Items.Add(New ListViewItem(New String() {st(0), st(1), st(2)}))
            dgv1.Rows.Add(New String() {st(0), st(1), st(2)})
        End While
        sr.Close()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim sw As StreamWriter = New StreamWriter("d.txt", True)
        For i = 0 To dgv1.Rows.Count - 1
            sw.WriteLine(dgv1.Rows(i).Cells(0).Value + ";" + dgv1.Rows(i).Cells(1).Value + ";" + dgv1.Rows(i).Cells(2).Value)
        Next
        sw.Close()
    End Sub
End Class
