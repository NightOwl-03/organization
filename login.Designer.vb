<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        TextBox6 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox3 = New GroupBox()
        chekShowPassword = New CheckBox()
        btnLOGIN = New Button()
        inputPASS = New TextBox()
        Label13 = New Label()
        inputUSER = New TextBox()
        Label14 = New Label()
        btnSIGNUP = New Button()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(30, 91)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(451, 45)
        TextBox6.TabIndex = 17
        TextBox6.Text = "MANAGEMENT"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Showcard Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(30, 32)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(451, 60)
        TextBox1.TabIndex = 16
        TextBox1.Text = "ORGANIZATION "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chekShowPassword)
        GroupBox3.Controls.Add(btnLOGIN)
        GroupBox3.Controls.Add(inputPASS)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(inputUSER)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Location = New Point(104, 180)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(297, 171)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        ' 
        ' chekShowPassword
        ' 
        chekShowPassword.AutoSize = True
        chekShowPassword.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chekShowPassword.Location = New Point(153, 94)
        chekShowPassword.Name = "chekShowPassword"
        chekShowPassword.Size = New Size(133, 24)
        chekShowPassword.TabIndex = 12
        chekShowPassword.Text = "Show Password"
        chekShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.BackColor = SystemColors.ButtonShadow
        btnLOGIN.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnLOGIN.Location = New Point(9, 124)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(277, 32)
        btnLOGIN.TabIndex = 10
        btnLOGIN.Text = "LOG IN"
        btnLOGIN.UseVisualStyleBackColor = False
        ' 
        ' inputPASS
        ' 
        inputPASS.Location = New Point(99, 63)
        inputPASS.Multiline = True
        inputPASS.Name = "inputPASS"
        inputPASS.Size = New Size(187, 25)
        inputPASS.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(9, 63)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 20)
        Label13.TabIndex = 8
        Label13.Text = "Password:"
        ' 
        ' inputUSER
        ' 
        inputUSER.Location = New Point(99, 32)
        inputUSER.Multiline = True
        inputUSER.Name = "inputUSER"
        inputUSER.Size = New Size(187, 25)
        inputUSER.TabIndex = 7
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(9, 32)
        Label14.Name = "Label14"
        Label14.Size = New Size(84, 20)
        Label14.TabIndex = 6
        Label14.Text = "Username:"
        ' 
        ' btnSIGNUP
        ' 
        btnSIGNUP.BackColor = SystemColors.ActiveCaption
        btnSIGNUP.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnSIGNUP.Location = New Point(104, 357)
        btnSIGNUP.Name = "btnSIGNUP"
        btnSIGNUP.Size = New Size(297, 32)
        btnSIGNUP.TabIndex = 21
        btnSIGNUP.Text = "SIGN UP"
        btnSIGNUP.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(511, 451)
        Controls.Add(btnSIGNUP)
        Controls.Add(GroupBox3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox1)
        Name = "login"
        Text = "login"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents inputPASS As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents inputUSER As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSIGNUP As Button
    Friend WithEvents chekShowPassword As CheckBox
End Class
