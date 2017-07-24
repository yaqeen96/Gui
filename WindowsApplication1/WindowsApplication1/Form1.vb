Public Class Form1

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        Me.BackColor = Color.Black
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.ForeColor = Color.Aqua
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.ForeColor = Color.Azure
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If tb1.Text <> String.Empty Then
            lb1.Items.Add(tb1.Text)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lb1.Items.RemoveAt(lb1.SelectedIndex)
    End Sub

    Private Sub btnRemoveAllItems_Click(sender As Object, e As EventArgs) Handles btnRemoveAllItems.Click
        lb1.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        MsgBox("The count is " & lb1.Items.Count)
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        lb1.Sorted = True
    End Sub
End Class
