<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        CheckORG = New CheckedListBox()
        inputPROG = New ComboBox()
        inputYL = New ComboBox()
        inputDEPT = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        inputGENDER = New ComboBox()
        inputFNAME = New TextBox()
        Label7 = New Label()
        inputLNAME = New TextBox()
        Label2 = New Label()
        inputstudid = New TextBox()
        Label1 = New Label()
        TextBox8 = New TextBox()
        GroupBox3 = New GroupBox()
        chkShowPassword = New CheckBox()
        btnSubmit = New Button()
        inputPASS = New TextBox()
        Label13 = New Label()
        inputUSER = New TextBox()
        Label14 = New Label()
        TextBox1 = New TextBox()
        btnLogin = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(CheckORG)
        GroupBox2.Controls.Add(inputPROG)
        GroupBox2.Controls.Add(inputYL)
        GroupBox2.Controls.Add(inputDEPT)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(390, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(297, 297)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        GroupBox2.Text = "INFORMATION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 25
        Label3.Text = "Organization:"
        ' 
        ' CheckORG
        ' 
        CheckORG.FormattingEnabled = True
        CheckORG.Items.AddRange(New Object() {"PSITS", "PGITS", "GMITS", "SSRI", "GLEE", "IC.PEP.SE", "SWAN"})
        CheckORG.Location = New Point(136, 133)
        CheckORG.Name = "CheckORG"
        CheckORG.Size = New Size(150, 151)
        CheckORG.TabIndex = 24
        ' 
        ' inputPROG
        ' 
        inputPROG.FormattingEnabled = True
        inputPROG.Items.AddRange(New Object() {"BSIT", "BSBA", "BSCPE", "BSSW", "BSCRIM"})
        inputPROG.Location = New Point(136, 68)
        inputPROG.Name = "inputPROG"
        inputPROG.Size = New Size(150, 26)
        inputPROG.TabIndex = 23
        ' 
        ' inputYL
        ' 
        inputYL.FormattingEnabled = True
        inputYL.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year"})
        inputYL.Location = New Point(136, 99)
        inputYL.Name = "inputYL"
        inputYL.Size = New Size(150, 26)
        inputYL.TabIndex = 22
        ' 
        ' inputDEPT
        ' 
        inputDEPT.FormattingEnabled = True
        inputDEPT.Items.AddRange(New Object() {"DTP", "DBA", "DAS", "DTE", "DAE", "DCJE", "SENIOR HIGH"})
        inputDEPT.Location = New Point(136, 37)
        inputDEPT.Name = "inputDEPT"
        inputDEPT.Size = New Size(150, 26)
        inputDEPT.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 101)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 20)
        Label10.TabIndex = 19
        Label10.Text = "Year Level:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(6, 70)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 17
        Label9.Text = "Program:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 15
        Label6.Text = "Department:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(45, 75)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(642, 45)
        TextBox6.TabIndex = 15
        TextBox6.Text = "MANAGEMENT"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(inputGENDER)
        GroupBox1.Controls.Add(inputFNAME)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(inputLNAME)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(inputstudid)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(45, 204)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(285, 173)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "INFORMATION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(16, 133)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 20)
        Label8.TabIndex = 11
        Label8.Text = "Gender:"
        ' 
        ' inputGENDER
        ' 
        inputGENDER.FormattingEnabled = True
        inputGENDER.Items.AddRange(New Object() {"MALE ", "FEMALE", "OTHERS..."})
        inputGENDER.Location = New Point(110, 128)
        inputGENDER.Name = "inputGENDER"
        inputGENDER.Size = New Size(150, 26)
        inputGENDER.TabIndex = 10
        ' 
        ' inputFNAME
        ' 
        inputFNAME.Location = New Point(110, 96)
        inputFNAME.Multiline = True
        inputFNAME.Name = "inputFNAME"
        inputFNAME.Size = New Size(150, 25)
        inputFNAME.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(16, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 4
        Label7.Text = "First Name:"
        ' 
        ' inputLNAME
        ' 
        inputLNAME.Location = New Point(110, 65)
        inputLNAME.Multiline = True
        inputLNAME.Name = "inputLNAME"
        inputLNAME.Size = New Size(150, 25)
        inputLNAME.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 2
        Label2.Text = "Last Name:"
        ' 
        ' inputstudid
        ' 
        inputstudid.Location = New Point(110, 34)
        inputstudid.Multiline = True
        inputstudid.Name = "inputstudid"
        inputstudid.Size = New Size(150, 25)
        inputstudid.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student ID:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(45, 126)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(642, 45)
        TextBox8.TabIndex = 17
        TextBox8.Text = "Sign Up "
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chkShowPassword)
        GroupBox3.Controls.Add(btnSubmit)
        GroupBox3.Controls.Add(inputPASS)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(inputUSER)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Location = New Point(45, 383)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(285, 180)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Location = New Point(127, 94)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(133, 24)
        chkShowPassword.TabIndex = 11
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ButtonShadow
        btnSubmit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnSubmit.Location = New Point(13, 133)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(247, 32)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' inputPASS
        ' 
        inputPASS.Location = New Point(99, 63)
        inputPASS.Multiline = True
        inputPASS.Name = "inputPASS"
        inputPASS.Size = New Size(161, 25)
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
        inputUSER.Size = New Size(161, 25)
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
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Showcard Gothic", 30F, FontStyle.Bold)
        TextBox1.Location = New Point(45, 21)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(642, 58)
        TextBox1.TabIndex = 19
        TextBox1.Text = "ORGANIZATION "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaption
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnLogin.Location = New Point(390, 516)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(297, 32)
        btnLogin.TabIndex = 11
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 635)
        Controls.Add(btnLogin)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox3)
        Controls.Add(TextBox8)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox6)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents inputGENDER As ComboBox
    Friend WithEvents inputFNAME As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents inputLNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inputstudid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents inputPASS As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents inputUSER As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents inputDEPT As ComboBox
    Friend WithEvents inputPROG As ComboBox
    Friend WithEvents inputYL As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckORG As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkShowPassword As CheckBox

End Class
