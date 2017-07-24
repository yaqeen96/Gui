Public Class Form1

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        lb1.Text = e.X
        lb2.Text = e.Y

        btn1.Left = e.X
        btn1.Top = e.Y

    End Sub
End Class
