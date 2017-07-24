Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim h As Random = New Random()
        Dim u As Integer = h.Next(0, 100)

        If u Mod 2 = 0 Then
            tb1.Text += CStr(u) + vbNewLine
        Else
            tb2.Text += CStr(u) + vbNewLine
        End If
    End Sub
End Class
