Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        pb1.Load("C:\Users\Taiba\Desktop\a.jpg")
        'Dim ofd As OpenFileDialog = New OpenFileDialog()
        'If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    pb1.Load(ofd.FileName)
        'End If
        'ofd.Filter = "pnj|*.png"
    End Sub
End Class
