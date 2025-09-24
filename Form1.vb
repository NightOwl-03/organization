Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If Not AreAllFieldsFilled() Then
            MessageBox.Show("Please fill out all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedOrgs As New List(Of String)
        For Each item As String In CheckORG.CheckedItems
            selectedOrgs.Add(item)
        Next

        Dim orgsAsString As String = String.Join(", ", selectedOrgs)

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(inputPASS.Text)

        Dim connectionString As String = "Data Source=localhost; userid=root; password=; database=db_organization"

        Using connection As New MySqlConnection(connectionString)
            Try

                Dim sql As String = "INSERT INTO record (StudID, LNAME, FNAME, GENDER, DEPT, PROG, YEAR, ORG, USERN, PASS) VALUES (@StudID, @LNAME, @FNAME, @GENDER, @DEPT, @PROG, @YEAR, @ORG, @USERN, @PASS)"
                Dim command As New MySqlCommand(sql, connection)

                command.Parameters.AddWithValue("@StudID", inputstudid.Text)
                command.Parameters.AddWithValue("@LNAME", inputLNAME.Text)
                command.Parameters.AddWithValue("@FNAME", inputFNAME.Text)
                command.Parameters.AddWithValue("@GENDER", inputGENDER.SelectedItem.ToString())
                command.Parameters.AddWithValue("@DEPT", inputDEPT.SelectedItem.ToString())
                command.Parameters.AddWithValue("@PROG", inputPROG.SelectedItem.ToString())
                command.Parameters.AddWithValue("@YEAR", inputYL.SelectedItem.ToString())

                command.Parameters.AddWithValue("@ORG", orgsAsString)

                command.Parameters.AddWithValue("@USERN", inputUSER.Text)
                command.Parameters.AddWithValue("@PASS", hashedPassword)

                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Record submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function AreAllFieldsFilled() As Boolean

        If String.IsNullOrWhiteSpace(inputstudid.Text) Then Return False
        If String.IsNullOrWhiteSpace(inputLNAME.Text) Then Return False
        If String.IsNullOrWhiteSpace(inputFNAME.Text) Then Return False
        If String.IsNullOrWhiteSpace(inputUSER.Text) Then Return False
        If String.IsNullOrWhiteSpace(inputPASS.Text) Then Return False

        If inputGENDER.SelectedItem Is Nothing Then Return False
        If inputDEPT.SelectedItem Is Nothing Then Return False
        If inputPROG.SelectedItem Is Nothing Then Return False
        If inputYL.SelectedItem Is Nothing Then Return False

        If CheckORG.CheckedItems.Count > 2 Then
            MessageBox.Show("Only select 2 Organizations.", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim loginForm As New login()

        loginForm.Show()

        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inputPASS.PasswordChar = "*"c
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then

            inputPASS.PasswordChar = ControlChars.NullChar
        Else

            inputPASS.PasswordChar = "*"c
        End If
    End Sub

End Class
