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
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb1.Location = New System.Drawing.Point(93, 5)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(162, 20)
        Me.tb1.TabIndex = 0
        '
        'tb2
        '
        Me.tb2.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb2.Location = New System.Drawing.Point(93, 53)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(162, 20)
        Me.tb2.TabIndex = 1
        '
        'tb3
        '
        Me.tb3.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb3.Location = New System.Drawing.Point(93, 92)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(162, 20)
        Me.tb3.TabIndex = 2
        '
        'tb4
        '
        Me.tb4.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb4.Location = New System.Drawing.Point(12, 157)
        Me.tb4.Multiline = True
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(175, 229)
        Me.tb4.TabIndex = 3
        '
        'tb5
        '
        Me.tb5.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb5.Location = New System.Drawing.Point(193, 157)
        Me.tb5.Multiline = True
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(174, 229)
        Me.tb5.TabIndex = 4
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn1.Location = New System.Drawing.Point(158, 118)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "Add"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Age"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(373, 394)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents tb3 As System.Windows.Forms.TextBox
    Friend WithEvents tb4 As System.Windows.Forms.TextBox
    Friend WithEvents tb5 As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
