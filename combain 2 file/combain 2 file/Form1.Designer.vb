<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.btncopy = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.Lb1 = New System.Windows.Forms.ListBox()
        Me.btnlb = New System.Windows.Forms.Button()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncopy
        '
        Me.btncopy.Location = New System.Drawing.Point(12, 1)
        Me.btncopy.Name = "btncopy"
        Me.btncopy.Size = New System.Drawing.Size(145, 67)
        Me.btncopy.TabIndex = 0
        Me.btncopy.Text = "Button1"
        Me.btncopy.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Lb1
        '
        Me.Lb1.FormattingEnabled = True
        Me.Lb1.Location = New System.Drawing.Point(93, 94)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lb1.Size = New System.Drawing.Size(167, 199)
        Me.Lb1.TabIndex = 1
        '
        'btnlb
        '
        Me.btnlb.Location = New System.Drawing.Point(12, 94)
        Me.btnlb.Name = "btnlb"
        Me.btnlb.Size = New System.Drawing.Size(75, 23)
        Me.btnlb.TabIndex = 2
        Me.btnlb.Text = "Button1"
        Me.btnlb.UseVisualStyleBackColor = True
        '
        'lv1
        '
        Me.lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lv1.GridLines = True
        Me.lv1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lv1.Location = New System.Drawing.Point(290, 94)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(265, 199)
        Me.lv1.TabIndex = 3
        Me.lv1.UseCompatibleStateImageBehavior = False
        Me.lv1.View = System.Windows.Forms.View.Details
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgv.Location = New System.Drawing.Point(603, 104)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(143, 199)
        Me.dgv.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(893, 333)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.btnlb)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.btncopy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncopy As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Lb1 As System.Windows.Forms.ListBox
    Friend WithEvents btnlb As System.Windows.Forms.Button
    Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lv1 As System.Windows.Forms.ListView
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

End Class
