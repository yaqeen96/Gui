Imports System.IO
Public Class Form1
    Dim stinfo(,) As String
    Dim count = 0
    Public Sub getinfo()
        ReDim stinfo(4, 4)
        Dim sr As StreamReader = New StreamReader("info.txt")
        While sr.Peek > 0
            Dim st() As String = sr.ReadLine.Split(";")
            For i = 0 To st.Length - 1
                stinfo(i, count) = st(i)
            Next
            count += 1

            cb1.Items.Add(st(0))
        End While

    End Sub
    Public Sub display()
        For i = 0 To 4
            If cb1.SelectedItem = stinfo(i, 0) Then
                tbName.Text = stinfo(i, 1)
                dtp1.Text = stinfo(i, 3)
                If stinfo(i, 2) = rb1.Text Then
                    rb1.Checked = True
                Else
                    rb2.Checked() = True
                End If
                dgv1.Rows.Add(stinfo)

            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getinfo()
    End Sub

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        display()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class
