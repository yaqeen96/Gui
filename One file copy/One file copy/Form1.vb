Imports System.IO
Public Class Form1
    'transfer file
    Private Sub btncopy_Click(sender As Object, e As EventArgs) Handles btncopy.Click
        ofd.ShowDialog()
        sfd.ShowDialog()
        Dim p1, p2 As String
        p1 = ofd.FileName
        p2 = sfd.FileName
        File.Copy(p1, p2)
    End Sub
End Class
