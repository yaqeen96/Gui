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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbpink = New System.Windows.Forms.RadioButton()
        Me.rbyellow = New System.Windows.Forms.RadioButton()
        Me.rbcyan = New System.Windows.Forms.RadioButton()
        Me.rbblue = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"form", "combobox", "lable", "button"})
        Me.ComboBox1.Location = New System.Drawing.Point(281, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbblue)
        Me.GroupBox1.Controls.Add(Me.rbcyan)
        Me.GroupBox1.Controls.Add(Me.rbyellow)
        Me.GroupBox1.Controls.Add(Me.rbpink)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbpink
        '
        Me.rbpink.AutoSize = True
        Me.rbpink.Location = New System.Drawing.Point(16, 19)
        Me.rbpink.Name = "rbpink"
        Me.rbpink.Size = New System.Drawing.Size(102, 23)
        Me.rbpink.TabIndex = 0
        Me.rbpink.TabStop = True
        Me.rbpink.Text = "deeppink"
        Me.rbpink.UseVisualStyleBackColor = True
        '
        'rbyellow
        '
        Me.rbyellow.AutoSize = True
        Me.rbyellow.Location = New System.Drawing.Point(16, 45)
        Me.rbyellow.Name = "rbyellow"
        Me.rbyellow.Size = New System.Drawing.Size(80, 23)
        Me.rbyellow.TabIndex = 1
        Me.rbyellow.TabStop = True
        Me.rbyellow.Text = "yellow"
        Me.rbyellow.UseVisualStyleBackColor = True
        '
        'rbcyan
        '
        Me.rbcyan.AutoSize = True
        Me.rbcyan.Location = New System.Drawing.Point(16, 68)
        Me.rbcyan.Name = "rbcyan"
        Me.rbcyan.Size = New System.Drawing.Size(64, 23)
        Me.rbcyan.TabIndex = 2
        Me.rbcyan.TabStop = True
        Me.rbcyan.Text = "cyan"
        Me.rbcyan.UseVisualStyleBackColor = True
        '
        'rbblue
        '
        Me.rbblue.AutoSize = True
        Me.rbblue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbblue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbblue.Location = New System.Drawing.Point(16, 91)
        Me.rbblue.Name = "rbblue"
        Me.rbblue.Size = New System.Drawing.Size(62, 23)
        Me.rbblue.TabIndex = 3
        Me.rbblue.TabStop = True
        Me.rbblue.Text = "blue"
        Me.rbblue.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(490, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbblue As System.Windows.Forms.RadioButton
    Friend WithEvents rbcyan As System.Windows.Forms.RadioButton
    Friend WithEvents rbyellow As System.Windows.Forms.RadioButton
    Friend WithEvents rbpink As System.Windows.Forms.RadioButton

End Class
