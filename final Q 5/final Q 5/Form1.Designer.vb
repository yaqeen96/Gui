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
        Me.lb1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbCyan = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.rbred = New System.Windows.Forms.RadioButton()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.Color.GhostWhite
        Me.lb1.Location = New System.Drawing.Point(243, 75)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(38, 13)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "Label1"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(228, 129)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbGreen)
        Me.GroupBox1.Controls.Add(Me.rbCyan)
        Me.GroupBox1.Controls.Add(Me.rbBlack)
        Me.GroupBox1.Controls.Add(Me.rbred)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 267)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select"
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(20, 154)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(71, 22)
        Me.rbGreen.TabIndex = 3
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbCyan
        '
        Me.rbCyan.AutoSize = True
        Me.rbCyan.Location = New System.Drawing.Point(20, 117)
        Me.rbCyan.Name = "rbCyan"
        Me.rbCyan.Size = New System.Drawing.Size(63, 22)
        Me.rbCyan.TabIndex = 2
        Me.rbCyan.TabStop = True
        Me.rbCyan.Text = "Cyan"
        Me.rbCyan.UseVisualStyleBackColor = True
        '
        'rbBlack
        '
        Me.rbBlack.AutoSize = True
        Me.rbBlack.Location = New System.Drawing.Point(20, 80)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(67, 22)
        Me.rbBlack.TabIndex = 1
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "Black"
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'rbred
        '
        Me.rbred.AutoSize = True
        Me.rbred.Location = New System.Drawing.Point(20, 39)
        Me.rbred.Name = "rbred"
        Me.rbred.Size = New System.Drawing.Size(55, 22)
        Me.rbred.TabIndex = 0
        Me.rbred.TabStop = True
        Me.rbred.Text = "Red"
        Me.rbred.UseVisualStyleBackColor = True
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Items.AddRange(New Object() {"form", "button", "combobox", "lable"})
        Me.comboBox2.Location = New System.Drawing.Point(206, 30)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(121, 21)
        Me.comboBox2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(591, 301)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbCyan As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlack As System.Windows.Forms.RadioButton
    Friend WithEvents rbred As System.Windows.Forms.RadioButton
    Friend WithEvents comboBox2 As System.Windows.Forms.ComboBox

End Class
