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
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.cd = New System.Windows.Forms.ColorDialog()
        Me.btn1 = New System.Windows.Forms.Button()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Turquoise
        Me.pb1.Location = New System.Drawing.Point(44, 12)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(358, 248)
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"red", "blue"})
        Me.cb1.Location = New System.Drawing.Point(424, 33)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 21)
        Me.cb1.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn1.Location = New System.Drawing.Point(424, 145)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(111, 62)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "paint"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(557, 335)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.pb1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents cd As System.Windows.Forms.ColorDialog
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class
