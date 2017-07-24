Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class Form3

    Dim con As New SqlConnection("data source =DESKTOP-FN2IUNS ;initial catalog= stores ; integrated security = true")
    Dim dt As New DataTable
    Dim da As SqlDataAdapter
    Dim cmd As New SqlCommandBuilder
    Dim oldId As Integer
    Private Sub btnback1_Click(sender As Object, e As EventArgs) Handles btnback1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btngoto_Click(sender As Object, e As EventArgs) Handles btngoto.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim row As DataRow = dt.NewRow
        row(0) = tbid.Text
        row(1) = tbempID.Text
        row(2) = dtp2.Value
        row(3) = tbnote.Text
        
        dt.Rows.Add(row)
        cmd = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تمت الاضافة بنجاح")
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim row As DataRow = dt.Rows.Find(tbid.Text)
        If row IsNot Nothing Then
            oldId = row(0)
            tbempID.Text = row(1)
            dtp2.Text = row(2)
            tbnote.Text = row(3)
           
        End If
    End Sub

    Private Sub btnDELET_Click(sender As Object, e As EventArgs) Handles btnDELET.Click
        Dim row As DataRow = dt.Rows.Find(tbid.Text)
        If row Is Nothing Then
            MsgBox("هذه المادة غير موجودة")
        Else
            row.Delete()
            cmd = New SqlCommandBuilder(da)
            da.Update(dt)
            MsgBox("تم الحذف بنجاح")
        End If
        tbid.Text = ""
        tbempID.Text = ""
        dtp2.Text = ""
        tbnote.Text = ""
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Dim row As DataRow = dt.Rows.Find(oldId)
        row(0) = oldId
        row(1) = tbid.Text
        row(2) = dtp2.Value.Date
        row(3) = tbnote.Text

        cmd = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تم التعديل بنجاح")
    End Sub
End Class