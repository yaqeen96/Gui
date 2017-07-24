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
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbage = New System.Windows.Forms.TextBox()
        Me.tbdept = New System.Windows.Forms.TextBox()
        Me.tblevel = New System.Windows.Forms.TextBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv.Location = New System.Drawing.Point(197, 148)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(245, 207)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "age"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "dept"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "level"
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(109, 74)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(100, 20)
        Me.tbname.TabIndex = 1
        '
        'tbage
        '
        Me.tbage.Location = New System.Drawing.Point(215, 74)
        Me.tbage.Name = "tbage"
        Me.tbage.Size = New System.Drawing.Size(100, 20)
        Me.tbage.TabIndex = 2
        '
        'tbdept
        '
        Me.tbdept.Location = New System.Drawing.Point(321, 74)
        Me.tbdept.Name = "tbdept"
        Me.tbdept.Size = New System.Drawing.Size(100, 20)
        Me.tbdept.TabIndex = 3
        '
        'tblevel
        '
        Me.tblevel.Location = New System.Drawing.Point(427, 74)
        Me.tblevel.Name = "tblevel"
        Me.tblevel.Size = New System.Drawing.Size(100, 20)
        Me.tblevel.TabIndex = 4
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(276, 100)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(94, 42)
        Me.btnADD.TabIndex = 5
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(675, 367)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.tblevel)
        Me.Controls.Add(Me.tbdept)
        Me.Controls.Add(Me.tbage)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.lv)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents tbage As System.Windows.Forms.TextBox
    Friend WithEvents tbdept As System.Windows.Forms.TextBox
    Friend WithEvents tblevel As System.Windows.Forms.TextBox
    Friend WithEvents btnADD As System.Windows.Forms.Button

End Class
