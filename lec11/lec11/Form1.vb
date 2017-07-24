Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As StreamReader = New StreamReader("x.csv")
        While sr.Peek() > 0
            Dim st() As String = sr.ReadLine().Split(";")
            lv1.Items.Add(New ListViewItem(New String() {st(0), st(1), st(2)}))
            dgv1.Rows.Add(New String() {st(0), st(1), st(2)})
        End While
        sr.Close()
    End Sub

    Private Sub lv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged
        tb1.Text = lv1.SelectedItems.Item(0).Text
        tb2.Text = lv1.SelectedItems.Item(0).SubItems(1).Text
        tb3.Text = lv1.SelectedItems.Item(0).SubItems(2).Text

    End Sub
End Class
