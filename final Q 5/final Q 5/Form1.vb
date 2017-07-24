Public Class Form1

    Private Sub rbred_CheckedChanged(sender As Object, e As EventArgs) Handles rbred.CheckedChanged

        Me.BackColor = Color.Red

    End Sub

    Private Sub rbBlack_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlack.CheckedChanged
        btn1.BackColor = Color.Black
    End Sub

    Private Sub rbCyan_CheckedChanged(sender As Object, e As EventArgs) Handles rbCyan.CheckedChanged
        comboBox2.BackColor = Color.Cyan
    End Sub

    Private Sub rbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged
        lb1.BackColor = Color.Green
    End Sub
End Class
