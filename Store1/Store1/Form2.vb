Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection("data source =DESKTOP-FN2IUNS ;initial catalog= stores ; integrated security = true")
    Dim dt As New DataTable
    Dim da As SqlDataAdapter
    Dim cmd As New SqlCommandBuilder
    Dim oldId As Integer


    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim row As DataRow = dt.NewRow
        row(0) = tbID.Text
        row(1) = tbName.Text
        row(2) = tbCount.Text
        row(3) = dtp.Value
        row(4) = tbSerial.Text
        row(5) = tbDescp.Text
        row(6) = tbAva.Text
        row(7) = tbStatuas.Text
        dt.Rows.Add(row)
        cmd = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تمت الاضافة بنجاح")
    End Sub


    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim row As DataRow = dt.Rows.Find(tbID.Text)
        If row IsNot Nothing Then
            oldId = row(0)
            tbName.Text = row(1)
            tbCount.Text = row(2)
            dtp.Text = row(3)
            tbSerial.Text = row(4)
            tbDescp.Text = row(5)
            tbAva.Text = row(6)
            tbStatuas.Text = row(7)
        End If
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Dim row As DataRow = dt.Rows.Find(oldId)
        row(0) = oldId
        row(1) = tbName.Text
        row(2) = tbCount.Text
        row(3) = dtp.Value.Date
        row(4) = tbSerial.Text
        row(5) = tbDescp.Text
        row(6) = tbAva.Text
        row(7) = tbStatuas.Text
        cmd = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تم التعديل بنجاح")
    End Sub

    Private Sub btnDELET_Click(sender As Object, e As EventArgs) Handles btnDELET.Click
        Dim row As DataRow = dt.Rows.Find(tbID.Text)
        If row Is Nothing Then
            MsgBox("هذه المادة غير موجودة")
        Else
            row.Delete()
            cmd = New SqlCommandBuilder(da)
            da.Update(dt)
            MsgBox("تم الحذف بنجاح")
        End If
        tbID.Text = ""
        tbName.Text = ""
        tbCount.Text = ""
        tbSerial.Text = ""
        tbDescp.Text = ""
        tbAva.Text = ""
        tbStatuas.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rr As String = "select * from item"
        da = New SqlDataAdapter(rr, con)
        da.Fill(dt)
        dgv.DataSource = dt
        dt.Constraints.Add("primary", dt.Columns("itemId"), True)
    End Sub

    Private Sub btngoto_Click(sender As Object, e As EventArgs) Handles btngoto.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class