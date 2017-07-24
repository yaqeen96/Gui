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
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbloadimg = New System.Windows.Forms.RadioButton()
        Me.rbgreen = New System.Windows.Forms.RadioButton()
        Me.rbred = New System.Windows.Forms.RadioButton()
        Me.rbblack = New System.Windows.Forms.RadioButton()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(12, 127)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(386, 168)
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbloadimg)
        Me.GroupBox1.Controls.Add(Me.rbgreen)
        Me.GroupBox1.Controls.Add(Me.rbred)
        Me.GroupBox1.Controls.Add(Me.rbblack)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbloadimg
        '
        Me.rbloadimg.AutoSize = True
        Me.rbloadimg.Location = New System.Drawing.Point(138, 44)
        Me.rbloadimg.Name = "rbloadimg"
        Me.rbloadimg.Size = New System.Drawing.Size(69, 17)
        Me.rbloadimg.TabIndex = 3
        Me.rbloadimg.TabStop = True
        Me.rbloadimg.Text = "Load Img"
        Me.rbloadimg.UseVisualStyleBackColor = True
        '
        'rbgreen
        '
        Me.rbgreen.AutoSize = True
        Me.rbgreen.Location = New System.Drawing.Point(138, 20)
        Me.rbgreen.Name = "rbgreen"
        Me.rbgreen.Size = New System.Drawing.Size(54, 17)
        Me.rbgreen.TabIndex = 2
        Me.rbgreen.TabStop = True
        Me.rbgreen.Text = "Green"
        Me.rbgreen.UseVisualStyleBackColor = True
        '
        'rbred
        '
        Me.rbred.AutoSize = True
        Me.rbred.Location = New System.Drawing.Point(17, 44)
        Me.rbred.Name = "rbred"
        Me.rbred.Size = New System.Drawing.Size(44, 17)
        Me.rbred.TabIndex = 1
        Me.rbred.TabStop = True
        Me.rbred.Text = "Red"
        Me.rbred.UseVisualStyleBackColor = True
        '
        'rbblack
        '
        Me.rbblack.AutoSize = True
        Me.rbblack.Location = New System.Drawing.Point(17, 20)
        Me.rbblack.Name = "rbblack"
        Me.rbblack.Size = New System.Drawing.Size(49, 17)
        Me.rbblack.TabIndex = 0
        Me.rbblack.TabStop = True
        Me.rbblack.Text = "Black"
        Me.rbblack.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(410, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbloadimg As System.Windows.Forms.RadioButton
    Friend WithEvents rbgreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbred As System.Windows.Forms.RadioButton
    Friend WithEvents rbblack As System.Windows.Forms.RadioButton

End Class
