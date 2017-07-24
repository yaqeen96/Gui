Public Class Form1
    Private Sub btn_in_Click(sender As Object, e As EventArgs) Handles btn_in.Click
        pb1.Width = (pb1.Width + 20)
        pb1.Height = (pb1.Height + 20)

    End Sub

    Private Sub btn_out_Click(sender As Object, e As EventArgs) Handles btn_out.Click
        pb1.Width = (pb1.Width - 20)
        pb1.Height = (pb1.Height - 20)

    End Sub

    Private Sub pb1_MouseMove(sender As Object, e As MouseEventArgs) Handles pb1.MouseMove
        Dim g As Graphics = pb1.CreateGraphics()
        Dim p As New Pen(Color.LightGreen, 30)
        If chb.Checked = True Then
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1)
        End If
    End Sub

    Private Sub cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb.SelectedIndexChanged
        'pb1.Load(cb.SelectedText)
        If cb.Text = "blue" Then
            cb.BackColor = Color.Blue
        ElseIf cb.Text = "red" Then
            Me.BackColor = Color.Red
        End If



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pb1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.Bisque

    End Sub
End Class
