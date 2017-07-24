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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbDepart = New System.Windows.Forms.TextBox()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.Maskedphone = New System.Windows.Forms.MaskedTextBox()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbDeeppink = New System.Windows.Forms.RadioButton()
        Me.rbBluesea = New System.Windows.Forms.RadioButton()
        Me.rbLigthgreen = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.CheckBoxMessage = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Maskedphone)
        Me.GroupBox1.Controls.Add(Me.tbDepart)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbGreen)
        Me.GroupBox2.Controls.Add(Me.rbBlack)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(343, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Text Color"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbLigthgreen)
        Me.GroupBox3.Controls.Add(Me.rbBluesea)
        Me.GroupBox3.Controls.Add(Me.rbDeeppink)
        Me.GroupBox3.Controls.Add(Me.rbRed)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(448, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 157)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Background Color"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(11, 272)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(104, 54)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Message"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(121, 272)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 54)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(247, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 54)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Depart"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Output :"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(72, 26)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(226, 25)
        Me.tbName.TabIndex = 4
        '
        'tbDepart
        '
        Me.tbDepart.Location = New System.Drawing.Point(72, 65)
        Me.tbDepart.Name = "tbDepart"
        Me.tbDepart.Size = New System.Drawing.Size(226, 25)
        Me.tbDepart.TabIndex = 5
        '
        'tbOutput
        '
        Me.tbOutput.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOutput.Location = New System.Drawing.Point(84, 165)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(168, 64)
        Me.tbOutput.TabIndex = 6
        '
        'Maskedphone
        '
        Me.Maskedphone.Location = New System.Drawing.Point(72, 106)
        Me.Maskedphone.Mask = "(999)000-0000"
        Me.Maskedphone.Name = "Maskedphone"
        Me.Maskedphone.Size = New System.Drawing.Size(226, 25)
        Me.Maskedphone.TabIndex = 7
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(18, 40)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(51, 22)
        Me.rbRed.TabIndex = 0
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbDeeppink
        '
        Me.rbDeeppink.AutoSize = True
        Me.rbDeeppink.Location = New System.Drawing.Point(18, 68)
        Me.rbDeeppink.Name = "rbDeeppink"
        Me.rbDeeppink.Size = New System.Drawing.Size(88, 22)
        Me.rbDeeppink.TabIndex = 1
        Me.rbDeeppink.TabStop = True
        Me.rbDeeppink.Text = "DeepPink"
        Me.rbDeeppink.UseVisualStyleBackColor = True
        '
        'rbBluesea
        '
        Me.rbBluesea.AutoSize = True
        Me.rbBluesea.Location = New System.Drawing.Point(18, 102)
        Me.rbBluesea.Name = "rbBluesea"
        Me.rbBluesea.Size = New System.Drawing.Size(78, 22)
        Me.rbBluesea.TabIndex = 2
        Me.rbBluesea.TabStop = True
        Me.rbBluesea.Text = "BlueSea"
        Me.rbBluesea.UseVisualStyleBackColor = True
        '
        'rbLigthgreen
        '
        Me.rbLigthgreen.AutoSize = True
        Me.rbLigthgreen.Location = New System.Drawing.Point(18, 136)
        Me.rbLigthgreen.Name = "rbLigthgreen"
        Me.rbLigthgreen.Size = New System.Drawing.Size(98, 22)
        Me.rbLigthgreen.TabIndex = 3
        Me.rbLigthgreen.TabStop = True
        Me.rbLigthgreen.Text = "LigthGreen"
        Me.rbLigthgreen.UseVisualStyleBackColor = True
        '
        'rbBlack
        '
        Me.rbBlack.AutoSize = True
        Me.rbBlack.Location = New System.Drawing.Point(18, 38)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(63, 22)
        Me.rbBlack.TabIndex = 1
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "Black"
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(18, 84)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(65, 22)
        Me.rbGreen.TabIndex = 2
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'CheckBoxMessage
        '
        Me.CheckBoxMessage.AutoSize = True
        Me.CheckBoxMessage.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMessage.Location = New System.Drawing.Point(84, 235)
        Me.CheckBoxMessage.Name = "CheckBoxMessage"
        Me.CheckBoxMessage.Size = New System.Drawing.Size(126, 22)
        Me.CheckBoxMessage.TabIndex = 6
        Me.CheckBoxMessage.Text = "Message Visible"
        Me.CheckBoxMessage.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(382, 221)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(280, 126)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 63)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(727, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CheckBoxMessage)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Maskedphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbOutput As System.Windows.Forms.TextBox
    Friend WithEvents tbDepart As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents rbGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlack As System.Windows.Forms.RadioButton
    Friend WithEvents rbLigthgreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbBluesea As System.Windows.Forms.RadioButton
    Friend WithEvents rbDeeppink As System.Windows.Forms.RadioButton
    Friend WithEvents rbRed As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxMessage As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
