﻿Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("data source =DESKTOP-FN2IUNS ;initial catalog= store ; integrated security = true")
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim un As String = "select * from Table_1 where username ='" & tb1.Text & "' and passward ='" & tb2.Text & "'"
        Dim cmd As New SqlCommand(un, con)
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            MsgBox("تم تسجيل الدخول بنجاح ", MsgBoxStyle.Information, "الدخول")
            Me.Hide()
            Form2.Show()

        Else
            MsgBox("عفوا هذا المستخدم غير موجود", MsgBoxStyle.Information, "الدخول")

        End If
        reader.Close()
        con.Close()


    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.Close()
    End Sub
End Class
