Public Class Form1

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        lb2.Text = Val(tb1.Text) + Val(tb2.Text)
    End Sub

    Private Sub tb4_TextChanged(sender As Object, e As EventArgs) Handles tb4.TextChanged
        lb4.Text = Val(tb3.Text) * Val(tb4.Text)
    End Sub

End Class
