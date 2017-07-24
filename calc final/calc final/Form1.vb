Public Class Form1
    Dim x, y, z As Integer
    Dim op As String

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op = "" Then
            x = Val(Button1.Text) + x
        Else
            y = Val(Button1.Text) + y
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If op = "" Then
            x = Val(Button2.Text) + x
        Else
            y = Val(Button2.Text) + y
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If op = "" Then
            x = Val(Button3.Text) + x
        Else
            y = Val(Button3.Text) + y
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If op = "" Then
            x = Val(Button4.Text) + x
        Else
            y = Val(Button4.Text) + y
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If op = "" Then
            x = Val(Button5.Text) + x
        Else
            y = Val(Button5.Text) + y
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If op = "" Then
            x = Val(Button6.Text) + x
        Else
            y = Val(Button6.Text) + y
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If op = "" Then
            x = Val(Button7.Text) + x
        Else
            y = Val(Button7.Text) + y
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If op = "" Then
            x = Val(Button8.Text) + x
        Else
            y = Val(Button8.Text) + y
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If op = "" Then
            x = Val(Button9.Text) + x
        Else
            y = Val(Button9.Text) + y
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If op = "" Then
            x = Val(Button10.Text) + x
        Else
            y = Val(Button10.Text) + y
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If op = "+" Then
            lb1.Text = x + y
        ElseIf op = "-" Then
            lb1.Text = x - y
        ElseIf op = "/" Then
            lb1.Text = x / y
        ElseIf op = "*" Then
            lb1.Text = x * y
        Else
            lb1.Text = Math.Pow(x, y)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        op = Button12.Text

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        op = Button13.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        op = Button14.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        op = Button15.Text
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        op = Button16.Text
    End Sub
End Class
