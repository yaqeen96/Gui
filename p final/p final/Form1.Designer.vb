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
        Me.btn_in = New System.Windows.Forms.Button()
        Me.btn_out = New System.Windows.Forms.Button()
        Me.cb = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chb = New System.Windows.Forms.CheckBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pb1.Location = New System.Drawing.Point(12, 55)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(320, 188)
        Me.pb1.TabIndex = 1
        Me.pb1.TabStop = False
        '
        'btn_in
        '
        Me.btn_in.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_in.Location = New System.Drawing.Point(375, 39)
        Me.btn_in.Name = "btn_in"
        Me.btn_in.Size = New System.Drawing.Size(217, 36)
        Me.btn_in.TabIndex = 2
        Me.btn_in.Text = "zoom"
        Me.btn_in.UseVisualStyleBackColor = True
        '
        'btn_out
        '
        Me.btn_out.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_out.Location = New System.Drawing.Point(375, 80)
        Me.btn_out.Name = "btn_out"
        Me.btn_out.Size = New System.Drawing.Size(217, 36)
        Me.btn_out.TabIndex = 3
        Me.btn_out.Text = "reduce zoom"
        Me.btn_out.UseVisualStyleBackColor = True
        '
        'cb
        '
        Me.cb.FormattingEnabled = True
        Me.cb.Items.AddRange(New Object() {"blue", "red"})
        Me.cb.Location = New System.Drawing.Point(88, 28)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(121, 21)
        Me.cb.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(375, 125)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(217, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chb
        '
        Me.chb.AutoSize = True
        Me.chb.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb.Location = New System.Drawing.Point(413, 178)
        Me.chb.Name = "chb"
        Me.chb.Size = New System.Drawing.Size(120, 29)
        Me.chb.TabIndex = 11
        Me.chb.Text = "Drawing"
        Me.chb.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(710, 437)
        Me.Controls.Add(Me.chb)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.btn_out)
        Me.Controls.Add(Me.btn_in)
        Me.Controls.Add(Me.pb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_in As System.Windows.Forms.Button
    Friend WithEvents btn_out As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chb As System.Windows.Forms.CheckBox

End Class
