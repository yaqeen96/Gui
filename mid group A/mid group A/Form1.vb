Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As StreamReader = New StreamReader("info.txt", True)
        While sr.Peek() > 0
            Dim st() As String = sr.ReadLine().Split(";")
            lv.Items.Add(New ListViewItem(New String() {st(0), st(1), st(2), st(3)}))
        End While
        sr.Close()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim sw As StreamWriter = New StreamWriter("info.txt", True)
        sw.WriteLine(tbname.Text + ";" + tbage.Text + ";" + tbdept.Text + ";" + tblevel.Text)
        sw.Close()
    End Sub
End Class
