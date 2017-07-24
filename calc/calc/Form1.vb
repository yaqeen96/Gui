Public Class Form1
    Dim num1, num2 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
        lb3.Text = Val(tb1.Text) + Val(tb2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lb3.Text = Val(tb1.Text) - Val(tb2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lb3.Text = Val(tb1.Text) / Val(tb2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lb3.Text = Val(tb1.Text) * Val(tb2.Text)
    End Sub

  
End Class
