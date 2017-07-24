Imports System.IO
Public Class Form1

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim sr As StreamReader = New StreamReader("c.txt")
        Dim i, n1, n2 As Integer
        n1 = 0
        n2 = 0
        Do While sr.Peek > 0
            i = Val(sr.ReadLine())
            If i Mod 2 = 0 Then
                TextBox1.Text += CStr(i)
                TextBox1.Text += vbNewLine
                n1 += i
            Else
                TextBox2.Text += CStr(i)
                TextBox2.Text += vbNewLine
                n2 += i
            End If
        Loop
        Label4.Text = n1
        Label5.Text = n2
        sr.Close()
    End Sub
End Class
