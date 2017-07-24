Public Class Form1
    Dim o As Boolean
    'استدعاء نافذة الالوان
    Dim k As Color
    Private Sub pb1_MouseMove(sender As Object, e As MouseEventArgs) Handles pb1.MouseMove
        Dim g As Graphics = pb1.CreateGraphics()
        Dim p As Pen

        If o = True And e.Button = Windows.Forms.MouseButtons.Left Then
            'رسم بالكلك الايسر
            p = New Pen(k, 10)
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1)

        ElseIf o = True And e.Button = Windows.Forms.MouseButtons.Right Then
            'مسح بلون خلفية البكجربوكس
            p = New Pen(pb1.BackColor, 10)
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1)
        End If
        'Me.Hide()
        'Form2.Show()
    End Sub

    Private Sub pb1_MouseDown(sender As Object, e As MouseEventArgs) Handles pb1.MouseDown
        o = True
    End Sub

    Private Sub pb1_MouseUp(sender As Object, e As MouseEventArgs) Handles pb1.MouseUp
        o = False
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            k = cd.Color
        End If
    End Sub

   
End Class
