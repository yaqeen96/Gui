Public Class Form1



    Private Sub rbblack_CheckedChanged(sender As Object, e As EventArgs) Handles rbblack.CheckedChanged
        pb1.BackColor = Color.Black
    End Sub

    Private Sub rbred_CheckedChanged(sender As Object, e As EventArgs) Handles rbred.CheckedChanged
        pb1.BackColor = Color.Red
    End Sub

    Private Sub rbgreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbgreen.CheckedChanged
        pb1.BackColor = Color.Green
    End Sub

    Private Sub rbloadimg_CheckedChanged(sender As Object, e As EventArgs) Handles rbloadimg.CheckedChanged
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pb1.Load(ofd.FileName)
        End If
    End Sub
End Class
