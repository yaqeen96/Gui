Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataGridView.DataGridViewControlCollection
Public Class Form2

    Dim con As New SqlConnection("data source =DESKTOP-FN2IUNS ;initial catalog= store ; integrated security = true")
    Dim dt As New DataTable
    Dim da As SqlDataAdapter
    Dim cmdb As New SqlCommandBuilder

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            Dim row As DataRow = dt.NewRow
            row(0) = tb1.Text
            row(1) = tb2.Text
            row(2) = dtp.Value
            row(3) = tb3.Text
            row(4) = tb4.Text
            row(5) = tb5.Text
            dt.Rows.Add(row)
            cmdb = New SqlCommandBuilder(da)
            da.Update(dt)
            MsgBox("تمت الاضافة بنجاح")
        Catch ex As Exception
            MsgBox("enter your info")
        End Try
      
    End Sub
    Dim oldId As Integer

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim row As DataRow = dt.Rows.Find(oldId)

        row(0) = tb1.Text
        row(1) = tb2.Text
        row(2) = dtp.Value.Date
        row(3) = tb3.Text
        row(4) = tb4.Text
        row(5) = tb5.Text

        cmdb = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تم التعديل بنجاح", MsgBoxStyle.Information, "التعديل")
    End Sub

    Private Sub tb1_Validated(sender As Object, e As EventArgs) Handles tb1.Validated
        Dim row As DataRow = dt.Rows.Find(tb1.Text)

        If row IsNot Nothing Then
            oldId = row(0)
            tb2.Text = row(1)
            dtp.Text = row(2)
            tb3.Text = row(3)
            tb4.Text = row(4)
            tb5.Text = row(5)

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim row As DataRow = dt.Rows.Find(tb1.Text)
        If row Is Nothing Then
            MsgBox("هذه المادة غير موجودة")
        Else
            row.Delete()
            cmdb = New SqlCommandBuilder(da)
            da.Update(dt)
            MsgBox("تم الحذف بنجاح")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rr As String = "SELECT * from المواد "
        da = New SqlDataAdapter(rr, con)
        da.Fill(dt)
        dgv1.DataSource = dt
        dt.Constraints.Add("primary", dt.Columns("المعرف"), True)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        dgv1.DataSource = Nothing
        dgv1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataRow = dt.Rows.Find(tb1.Text)


        If row IsNot Nothing Then
            oldId = row(0)
            tb2.Text = row(1)
            dtp.Text = row(2)
            tb3.Text = row(3)
            tb4.Text = row(4)
            tb5.Text = row(5)
        End If
    End Sub
End Class