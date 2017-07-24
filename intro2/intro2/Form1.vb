Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        tbOutput.Text = "MyName : " & tbName.Text & ControlChars.NewLine &
            "Depart : " & tbDepart.Text & ControlChars.NewLine &
            "Local Phone : " & Maskedphone.Text

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset texts

        tbName.Text = ""
        tbDepart.Text = ""
        tbOutput.Text = ""
        ' reset backcolor
        rbLigthgreen.Checked = True
        rbBlack.Checked = True

        'reset message display
        CheckBoxMessage.Checked = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rbBlack_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlack.CheckedChanged
        Me.ForeColor = Color.Black
    End Sub

    Private Sub rbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged
        Me.ForeColor = Color.Green
    End Sub

    Private Sub rbRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbRed.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub rbDeeppink_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeeppink.CheckedChanged
        Me.BackColor = Color.DeepPink
    End Sub

    Private Sub rbBluesea_CheckedChanged(sender As Object, e As EventArgs) Handles rbBluesea.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub rbLigthgreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbLigthgreen.CheckedChanged
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub CheckBoxMessage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMessage.CheckedChanged
        tbOutput.Visible = CheckBoxMessage.Checked
        Label4.Visible = CheckBoxMessage.Checked

    End Sub
End Class
