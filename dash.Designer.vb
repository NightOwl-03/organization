<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dash
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
        TextBox1 = New TextBox()
        TextBox6 = New TextBox()
        GroupBox1 = New GroupBox()
        dgvNames = New DataGridView()
        inputSEARCH = New TextBox()
        btnSearch = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvNames, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Showcard Gothic", 30F, FontStyle.Bold)
        TextBox1.Location = New Point(23, 25)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(880, 58)
        TextBox1.TabIndex = 21
        TextBox1.Text = "ORGANIZATION "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(23, 79)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(880, 45)
        TextBox6.TabIndex = 20
        TextBox6.Text = "MANAGEMENT"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvNames)
        GroupBox1.Location = New Point(23, 212)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(880, 346)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        ' 
        ' dgvNames
        ' 
        dgvNames.AllowUserToAddRows = False
        dgvNames.AllowUserToDeleteRows = False
        dgvNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNames.Location = New Point(6, 15)
        dgvNames.Name = "dgvNames"
        dgvNames.ReadOnly = True
        dgvNames.Size = New Size(868, 325)
        dgvNames.TabIndex = 0
        ' 
        ' inputSEARCH
        ' 
        inputSEARCH.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inputSEARCH.Location = New Point(23, 172)
        inputSEARCH.Multiline = True
        inputSEARCH.Name = "inputSEARCH"
        inputSEARCH.Size = New Size(754, 34)
        inputSEARCH.TabIndex = 23
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnSearch.Location = New Point(783, 172)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(120, 34)
        btnSearch.TabIndex = 24
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dash
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 570)
        Controls.Add(btnSearch)
        Controls.Add(inputSEARCH)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox6)
        Name = "dash"
        Text = "dash"
        GroupBox1.ResumeLayout(False)
        CType(dgvNames, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvNames As DataGridView
    Friend WithEvents inputSEARCH As TextBox
    Friend WithEvents btnSearch As Button
End Class
