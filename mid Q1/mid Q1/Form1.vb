Public Class Form1

    Private Sub btnresult_Click(sender As Object, e As EventArgs) Handles btnresult.Click
        Dim max, min As Integer

        If rbmax.Checked = True Then
            max = Val(tb1.Text)
            If Val(tb2.Text) > max Then
                max = Val(tb2.Text)
            End If
            If Val(tb3.Text) > max Then
                max = Val(tb3.Text)
            End If
            tb4.Text = max
        End If
        If rbmin.Checked = True Then
            min = Val(tb1.Text)

            If Val(tb2.Text) < min Then
                min = Val(tb2.Text)
            End If
            If Val(tb3.Text) < min Then
                min = Val(tb3.Text)
            End If
            tb4.Text = min
        End If

        If rbequal.Checked = True Then
            Dim equal
            If Val(tb1.Text) = Val(tb2.Text) = Val(tb3.Text) Then

            End If
            tb4.Text = " equal"
        End If

    End Sub
End Class
