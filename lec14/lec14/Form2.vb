Imports System.IO
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("your username is " + Form1.tb1.Text)
        MessageBox.Show("your password is " + Form1.tb2.Text)
        Dim st() As String = File.ReadAllLines("t.txt")
        For i = 0 To st.Length - 1
            Dim tmp() = st(i).Split(";")
            dgv.Rows.Add(tmp)
        Next
    End Sub
End Class