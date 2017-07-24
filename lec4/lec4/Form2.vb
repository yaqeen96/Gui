Public Class Form2
    Dim o As Boolean
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As Pen

        If o = True And e.Button = Windows.Forms.MouseButtons.Left Then
            'رسم بالكلك الايسر
            If cb.SelectedText = "red" Then
                Dim p1 As New Pen(Color.Red, 20)
                g.DrawLine(p1, e.X, e.Y, e.X + 1, e.Y + 1)

            ElseIf cb.SelectedText = "blue" Then
                Dim p2 As New Pen(Color.Blue, 20)
                g.DrawLine(p2, e.X, e.Y, e.X + 1, e.Y + 1)

            End If
        ElseIf o = True And e.Button = Windows.Forms.MouseButtons.Right Then
        'مسح بلون خلفية البكجربوكس
            p = New Pen(PictureBox1.BackColor, 100)
        g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        o = True
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        o = False
    End Sub
End Class