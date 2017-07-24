<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDELET = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btngoto = New System.Windows.Forms.Button()
        Me.btnback1 = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.tbnote = New System.Windows.Forms.TextBox()
        Me.tbempID = New System.Windows.Forms.TextBox()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(683, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم المادة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(669, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "رقم الموضف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(660, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "تاريخ الاستلام"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(692, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ملاحظات"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDELET)
        Me.GroupBox1.Controls.Add(Me.btnEDIT)
        Me.GroupBox1.Controls.Add(Me.btnSEARCH)
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btngoto)
        Me.GroupBox1.Controls.Add(Me.btnback1)
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.tbnote)
        Me.GroupBox1.Controls.Add(Me.tbempID)
        Me.GroupBox1.Controls.Add(Me.tbid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 288)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اعدادات الاستلام"
        '
        'btnDELET
        '
        Me.btnDELET.BackColor = System.Drawing.Color.Snow
        Me.btnDELET.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnDELET.Location = New System.Drawing.Point(15, 47)
        Me.btnDELET.Name = "btnDELET"
        Me.btnDELET.Size = New System.Drawing.Size(149, 44)
        Me.btnDELET.TabIndex = 24
        Me.btnDELET.Text = "حذف"
        Me.btnDELET.UseVisualStyleBackColor = False
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.Snow
        Me.btnEDIT.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnEDIT.Location = New System.Drawing.Point(15, 100)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(149, 44)
        Me.btnEDIT.TabIndex = 23
        Me.btnEDIT.Text = "تعديل"
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'btnSEARCH
        '
        Me.btnSEARCH.BackColor = System.Drawing.Color.Snow
        Me.btnSEARCH.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnSEARCH.Location = New System.Drawing.Point(170, 100)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(149, 44)
        Me.btnSEARCH.TabIndex = 22
        Me.btnSEARCH.Text = "بحث"
        Me.btnSEARCH.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Snow
        Me.btnADD.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnADD.Location = New System.Drawing.Point(170, 47)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(149, 44)
        Me.btnADD.TabIndex = 21
        Me.btnADD.Text = "اضافة"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btngoto
        '
        Me.btngoto.BackColor = System.Drawing.Color.Snow
        Me.btngoto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngoto.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btngoto.Location = New System.Drawing.Point(52, 202)
        Me.btngoto.Name = "btngoto"
        Me.btngoto.Size = New System.Drawing.Size(228, 38)
        Me.btngoto.TabIndex = 19
        Me.btngoto.Text = "الذهاب الى اعدادات الاستلام"
        Me.btngoto.UseVisualStyleBackColor = False
        '
        'btnback1
        '
        Me.btnback1.BackColor = System.Drawing.Color.Snow
        Me.btnback1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnback1.Location = New System.Drawing.Point(52, 160)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(228, 36)
        Me.btnback1.TabIndex = 10
        Me.btnback1.Text = "الذهاب الى اعدادات التسليم"
        Me.btnback1.UseVisualStyleBackColor = False
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Location = New System.Drawing.Point(364, 77)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(275, 22)
        Me.dtp2.TabIndex = 7
        '
        'tbnote
        '
        Me.tbnote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnote.Location = New System.Drawing.Point(364, 105)
        Me.tbnote.Name = "tbnote"
        Me.tbnote.Size = New System.Drawing.Size(275, 22)
        Me.tbnote.TabIndex = 6
        '
        'tbempID
        '
        Me.tbempID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbempID.Location = New System.Drawing.Point(364, 47)
        Me.tbempID.Name = "tbempID"
        Me.tbempID.Size = New System.Drawing.Size(275, 22)
        Me.tbempID.TabIndex = 5
        '
        'tbid
        '
        Me.tbid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbid.Location = New System.Drawing.Point(364, 18)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(275, 22)
        Me.tbid.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(783, 312)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "اعدادات الاستلام"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbempID As System.Windows.Forms.TextBox
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents tbnote As System.Windows.Forms.TextBox
    Friend WithEvents btnback1 As System.Windows.Forms.Button
    Friend WithEvents btngoto As System.Windows.Forms.Button
    Friend WithEvents btnDELET As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
End Class
