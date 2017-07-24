Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str() As String
        ReDim str(15)
        For i = 1 To 15
            For j = 1 To 15
                str(j) = i * j
            Next
            DataGridView1.Rows.Add(str)
        Next

    End Sub
End Class
