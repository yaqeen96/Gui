Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If tb1.Text = "abc" And tb2.Text = "tre" Then
            MsgBox("match")
            Me.BackColor = Color.Cyan
        Else : MsgBox("not match")
            Me.BackColor = Color.Black
        End If
    End Sub
End Class
