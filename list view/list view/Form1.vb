Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.CheckBoxes = True
        ListView1.Columns.Add("Id")
        ListView1.Columns.Add("Name")
        ListView1.Columns.Add("info")
        Dim lv As New ListViewItem("001", imageIndex:=4)
        lv.SubItems.Add("yyy")
        lv.SubItems.Add("dddd")
        Dim lv1 As New ListViewItem("002", imageIndex:=0)
        lv1.SubItems.Add("yy")
        lv1.SubItems.Add("ddd")
        ListView1.Items.AddRange(New ListViewItem() {lv, lv1})
        ListView1.Items.Add("0003", 2)
        ListView1.Items(2).SubItems.Add("ghg")
        ListView1.Items(2).SubItems.Add("ghlllg")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer = ComboBox1.SelectedIndex
        If index = 0 Then
            ListView1.View = View.LargeIcon
        ElseIf index = 1 Then
            ListView1.View = View.SmallIcon
        ElseIf index = 2 Then
            ListView1.View = View.Details
        ElseIf index = 3 Then
            ListView1.View = View.Tile
        ElseIf index = 4 Then
            ListView1.View = View.List




        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'For Each item As ListViewItem In ListView1.CheckedItems
        '    MsgBox(String.Format("id is : (0) , name is : (1) ,info is : (2)", item.SubItems(0).Text, item.SubItems(1).Text, item.SubItems(2).Text))
        '    ListView1.Items.RemoveAt(item.Index)

        'Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Groups.Add("Group1", "Group2")
        ListView1.Items(0).Group = ListView1.Groups(0)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TreeView1.ImageList = ImageList1

        TreeView1.Nodes.Add("p1", "progming", 4, 4)
        TreeView1.Nodes(0).Nodes.Add("", "vb", 5, 5)
        TreeView1.Nodes(0).Nodes.Add("", "java", 5, 5)
        TreeView1.Nodes(0).Nodes.Add("", "c#", 5, 5)
        TreeView1.Nodes(0).Nodes.Add("", "html", 5, 5)

        TreeView1.Nodes.Add("boooks", "progming books", 2, 2)
        TreeView1.Nodes(1).Nodes.Add("", "htl", 1, 1)
        TreeView1.Nodes(1).Nodes.Add("", "htdcdml", 1, 1)
        TreeView1.Nodes(1).Nodes.Add("", "htddddml", 1, 1)
        TreeView1.Nodes(1).Nodes.Add("", "hdddtml", 1, 1)

        TreeView1.Nodes.Add("com.", "computer", 4, 4)




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox(TreeView1.SelectedNode.Text)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        MsgBox("the selected item is " & e.Node.Text)
    End Sub
End Class
