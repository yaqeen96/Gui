Public Class Form1

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, fact As Integer
        fact = 1
        num = Val(TB1.Text)
        If num > 1 Then
            For i = 1 To num
                fact = fact * i
            Next
            lb2.Text = fact
        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y As Integer
        lb5.Text = CStr(Math.Pow(x, y))
    End Sub
End Class
