Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb4.Text = "Student           Subject          Mark" + vbNewLine
        tb4.Text += "------------------------------------------" + vbNewLine

        Dim sr As StreamReader = New StreamReader("g.csv", True)
        While sr.Peek() > 0
            Dim st() As String = sr.ReadLine.Split(";")
            tb4.Text += (st(0) + "            " + st(1) + "                " + st(2) + vbNewLine)
            lv1.Items.Add(New ListViewItem(New String() {st(0), st(1), st(2)}))
        End While
        sr.Close()
    End Sub

    
End Class
