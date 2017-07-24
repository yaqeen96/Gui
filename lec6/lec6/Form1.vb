Public Class Form1
    'ندخل معلومات وعند الضغط على بووتن ينضافن على التيكست بوكس 4 او 5 حسب الشرط
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb4.Text = "Name         Leve         Age" + vbNewLine
        tb4.Text += "------------------------------------" + vbNewLine
        tb5.Text = "Name         Leve         Age" + vbNewLine
        tb5.Text += "------------------------------------" + vbNewLine
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Val(tb3.Text) >= 18 Then
            tb4.Text += (tb1.Text + "        " + tb2.Text + "          " + tb3.Text + vbNewLine)
        Else
            tb5.Text += (tb1.Text + "        " + tb2.Text + "          " + tb3.Text + vbNewLine)
        End If
        tb1.Text = ""
        tb2.Text = ""
        tb3.Text = ""
    End Sub

    
End Class
