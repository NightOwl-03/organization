Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Generators
Imports BCrypt.Net

Public Class login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click

        Dim username As String = inputUSER.Text
        Dim password As String = inputPASS.Text


        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "Data Source=localhost; userid=root; password=; database=db_organization"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim sql As String = "SELECT PASS FROM record WHERE USERN = @USERN"
                Dim command As New MySqlCommand(sql, connection)
                command.Parameters.AddWithValue("@USERN", username)


                Dim storedHash As Object = command.ExecuteScalar()

                If storedHash IsNot Nothing Then

                    If BCrypt.Net.BCrypt.Verify(password, storedHash.ToString()) Then

                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim mainForm As New dash()
                        mainForm.Show()
                        Me.Hide()

                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else

                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSIGNUP.Click

        Dim SignupForm As New Form1()

        SignupForm.Show()

        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inputPASS.PasswordChar = "*"c
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chekShowPassword.CheckedChanged
        If chekShowPassword.Checked Then

            inputPASS.PasswordChar = ControlChars.NullChar
        Else

            inputPASS.PasswordChar = "*"c
        End If
    End Sub


End Class