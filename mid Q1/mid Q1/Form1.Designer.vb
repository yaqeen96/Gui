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
        Me.btnresult = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbequal = New System.Windows.Forms.RadioButton()
        Me.rbmin = New System.Windows.Forms.RadioButton()
        Me.rbmax = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnresult
        '
        Me.btnresult.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresult.Location = New System.Drawing.Point(222, 214)
        Me.btnresult.Name = "btnresult"
        Me.btnresult.Size = New System.Drawing.Size(73, 29)
        Me.btnresult.TabIndex = 0
        Me.btnresult.Text = "result"
        Me.btnresult.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(65, 164)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 1
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(205, 164)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 2
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(341, 163)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(100, 20)
        Me.tb3.TabIndex = 3
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(205, 268)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(100, 20)
        Me.tb4.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbequal)
        Me.GroupBox1.Controls.Add(Me.rbmin)
        Me.GroupBox1.Controls.Add(Me.rbmax)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbequal
        '
        Me.rbequal.AutoSize = True
        Me.rbequal.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbequal.Location = New System.Drawing.Point(21, 66)
        Me.rbequal.Name = "rbequal"
        Me.rbequal.Size = New System.Drawing.Size(72, 23)
        Me.rbequal.TabIndex = 2
        Me.rbequal.TabStop = True
        Me.rbequal.Text = "equal"
        Me.rbequal.UseVisualStyleBackColor = True
        '
        'rbmin
        '
        Me.rbmin.AutoSize = True
        Me.rbmin.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmin.Location = New System.Drawing.Point(21, 43)
        Me.rbmin.Name = "rbmin"
        Me.rbmin.Size = New System.Drawing.Size(57, 23)
        Me.rbmin.TabIndex = 1
        Me.rbmin.TabStop = True
        Me.rbmin.Text = "min"
        Me.rbmin.UseVisualStyleBackColor = True
        '
        'rbmax
        '
        Me.rbmax.AutoSize = True
        Me.rbmax.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmax.Location = New System.Drawing.Point(21, 20)
        Me.rbmax.Name = "rbmax"
        Me.rbmax.Size = New System.Drawing.Size(62, 23)
        Me.rbmax.TabIndex = 0
        Me.rbmax.TabStop = True
        Me.rbmax.Text = "max"
        Me.rbmax.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(672, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.btnresult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnresult As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents tb3 As System.Windows.Forms.TextBox
    Friend WithEvents tb4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbequal As System.Windows.Forms.RadioButton
    Friend WithEvents rbmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbmax As System.Windows.Forms.RadioButton

End Class
