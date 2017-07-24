Imports System.IO
Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim arr() As String = File.ReadAllLines("t.txt")
        Dim x As Boolean = False
        For i = 0 To arr.Length - 1
            Dim tmp() = arr(i).Split(";")
            If tmp(0) = tb1.Text And tmp(1) = tb2.Text Then
                x = True
            End If
        Next

        If x = True Then
            MsgBox("login successfully")
            Form2.Show()
            Me.Hide()
        ElseIf x = False Then
            MsgBox("the user name or password invaild")
        End If
    End Sub


    Private Sub tb2_MouseDown(sender As Object, e As MouseEventArgs) Handles tb2.MouseDown
        tb2.UseSystemPasswordChar = False
    End Sub

    Private Sub tb2_MouseUp(sender As Object, e As MouseEventArgs) Handles tb2.MouseUp
        tb2.UseSystemPasswordChar = True

    End Sub
End Class
