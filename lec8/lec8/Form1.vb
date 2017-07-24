Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim y() As String = tb1.Text.Split(vbCr)

        For i = 0 To y.Length - 1
            If Val(y(i)) Mod 2 = 0 Then
                tb2.Text += y(i) + vbNewLine
            Else
                tb3.Text += y(i) + vbNewLine
            End If
        Next
    End Sub
End Class
