Public Class Form1

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        MsgBox("you are choosed :" & cb1.Text)
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cb1.Items.Add("yaqeen")
        cb1.Items.Add("hanene")
        cb1.Items.Add("riyam")
        cb1.Items.Add("yaqon")
        cb1.Items.Add("yaqen")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("the items count is " & cb1.Items.Count)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cb1.Items.RemoveAt(cb1.SelectedIndex)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        PictureBox2.Image = Image.FromFile("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SelectionColor = Color.Aqua
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SelectionFont = New Font("red", 15)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.SelectionBackColor = Color.Black
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fisrtdate, seconddate As DateTime
        fisrtdate = DateTimePicker1.Value
        seconddate = DateTimePicker2.Value
        'Dim result As TimeSpan = seconddate.Subtract(fisrtdate)

        'Label3.Text = result.TotalDays
        ' Label3.Text = seconddate.Subtract(fisrtdate).Days
        ' Label3.Text = DateDiff(DateInterval.Month, fisrtdate, seconddate)
        '  Label3.Text = DateAdd(DateInterval.Day, 15, fisrtdate)
        'Label3.Text = DatePart(DateInterval.Year, fisrtdate)
        Label3.Text = Now
    End Sub
End Class
