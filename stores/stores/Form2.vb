Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class Form2

    Dim con As New SqlConnection("data source =DESKTOP-FN2IUNS ;initial catalog= store1 ; integrated security = true")
    Dim dt As New DataTable
    Dim da As SqlDataAdapter
    Dim cmdb As New SqlCommandBuilder
    Dim oldId As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rr As String = "SELECT * from item "
        da = New SqlDataAdapter(rr, con)
        da.Fill(dt)
        dgv1.DataSource = dt
        dt.Constraints.Add("primary", dt.Columns("item_id"), True)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim row As DataRow = dt.NewRow
        row(0) = tbid.Text
        row(1) = tbname.Text
        row(2) = tbcount.Text
        row(3) = dtp.Value
        row(4) = tbserial.Text
        row(5) = tbdesc.Text
        row(6) = tbstatus.Text
        row(7) = tbava.Text
        dt.Rows.Add(row)
        cmdb = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تمت الاضافة بنجاح")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim row As DataRow = dt.Rows.Find(oldId)

        row(0) = tbid.Text
        row(1) = tbname.Text
        row(2) = tbcount.Text
        row(3) = dtp.Value
        row(4) = tbserial.Text
        row(5) = tbdesc.Text
        row(6) = tbava.Text
        row(7) = tbstatus.Text

        cmdb = New SqlCommandBuilder(da)
        da.Update(dt)
        MsgBox("تم التعديل بنجاح", MsgBoxStyle.Information, "التعديل")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataRow = dt.Rows.Find(tbid.Text)
        If row Is Nothing Then
            MsgBox("هذه المادة غير موجودة")
        Else
            row.Delete()
            cmdb = New SqlCommandBuilder(da)
            da.Update(dt)
            MsgBox("تم الحذف بنجاح")
        End If
    End Sub

    Private Sub tb1_Validated(sender As Object, e As EventArgs) Handles tbid.Validated

    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnserach_Click(sender As Object, e As EventArgs) Handles btnserach.Click
        Try
            Dim row As DataRow = dt.Rows.Find(tbid.Text)

            If row IsNot Nothing Then
                oldId = row(0)
                row(1) = tbname.Text
                row(2) = tbcount.Text
                row(3) = dtp.Value
                row(4) = tbserial.Text
                row(5) = tbdesc.Text
                row(6) = tbava.Text
                row(7) = tbstatus.Text
            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class
