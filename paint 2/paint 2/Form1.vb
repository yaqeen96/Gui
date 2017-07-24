Public Class Form1
    Dim t As Boolean
    Dim b As Color
    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        Dim p As String
        p = cb1.Text

        If p = "deeppink" Then
            pb1.BackColor = Color.DeepPink
        ElseIf p = "black" Then
            pb1.BackColor = Color.Black
        Else : p = "blue"
            pb1.BackColor = Color.Blue
        End If



    End Sub

    Private Sub pb1_MouseMove(sender As Object, e As MouseEventArgs) Handles pb1.MouseMove
        Dim g As Graphics = pb1.CreateGraphics()
        Dim p As New Pen(Color.LightGreen, 30)
        If CheckBox1.Checked = True Then
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            b = ColorDialog1.Color
        End If
    End Sub

    Private Sub pb1_MouseDown(sender As Object, e As MouseEventArgs) Handles pb1.MouseDown
        t = True
    End Sub

    Private Sub pb1_MouseUp(sender As Object, e As MouseEventArgs) Handles pb1.MouseUp
        t = False
    End Sub
End Class
