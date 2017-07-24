Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim sr As StreamReader = New StreamReader("b.txt", True)
        'While sr.Peek > 0
        '    Dim st() As String = sr.ReadLine.Split(";")
        '    dgv1.Rows.Add(New String() {st(0), st(1), st(2)})
        'End While
        'sr.Close()

        'Dim sr1 As StreamReader = New StreamReader("d.txt", True)
        'While sr1.Peek > 0
        '    Dim st1() As String = sr1.ReadLine.Split(";")
        '    dgv2.Rows.Add(New String() {st1(0), st1(1), st1(2)})
        'End While
        'sr1.Close()
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'File.Delete("d.txt")
        'Dim sw As StreamWriter = New StreamWriter("d.txt", True)
        'For i = 0 To dgv2.Rows.Count - 1
        '    sw.WriteLine(dgv2.Item(0, i).Value + ";" + dgv2.Item(1, i).Value + ";" +
        '                 dgv2.Item(2, i).Value)
        'Next
        'sw.Close()

        Dim st() As String = File.ReadAllLines("b.txt")
        For i = 0 To st.Length - 1
            Dim tmp() As String = st(i).Split(";")
            dgv2.Rows.Add(tmp)

        Next
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
 
        Dim sw As StreamWriter = New StreamWriter("b.txt", True)
        For i = 0 To dgv2.Rows.Count - 1
            sw.WriteLine(dgv2.Rows(i).Cells(0).Value + ";" + dgv2.Rows(i).Cells(1).Value + ";" +
                         dgv2.Rows(i).Cells(2).Value)
        Next
        sw.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv2.Rows.Clear()
    End Sub
End Class
