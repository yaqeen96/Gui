Public Class Form1
    Private Sub rbpink_CheckedChanged(sender As Object, e As EventArgs) Handles rbpink.CheckedChanged
        If ComboBox1.SelectedItem = "form" Then
            If rbpink.Checked = True Then
                Me.BackColor = Color.Pink
            End If
        End If
    End Sub

    Private Sub rbyellow_CheckedChanged(sender As Object, e As EventArgs) Handles rbyellow.CheckedChanged
        If ComboBox1.SelectedItem = "combobox" Then
            If rbyellow.Checked = True Then
                ComboBox1.BackColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub rbcyan_CheckedChanged(sender As Object, e As EventArgs) Handles rbcyan.CheckedChanged
        If ComboBox1.SelectedItem = "lable" Then
            If rbcyan.Checked = True Then
                Label1.BackColor = Color.Cyan
            End If
        End If
    End Sub

    Private Sub rbblue_CheckedChanged(sender As Object, e As EventArgs) Handles rbblue.CheckedChanged
        If ComboBox1.SelectedItem = "button" Then
            If rbblue.Checked = True Then
                Button1.BackColor = Color.Blue
            End If
        End If
    End Sub
End Class
