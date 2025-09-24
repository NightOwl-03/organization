Imports MySql.Data.MySqlClient

Public Class dash
    Private Sub LoadUserData()

        Dim connectionString As String = "Data Source=localhost; userid=root; password=; database=db_organization"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()


                Dim sql As String = "SELECT StudID, LNAME, FNAME, GENDER, DEPT, PROG, YEAR, ORG FROM record"
                Dim command As New MySqlCommand(sql, connection)

                Dim dataTable As New DataTable()
                Dim dataAdapter As New MySqlDataAdapter(command)

                dataAdapter.Fill(dataTable)


                dgvNames.DataSource = dataTable

                dgvNames.AllowUserToAddRows = False
                dgvNames.ReadOnly = True

            Catch ex As Exception
                MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim searchTerm As String = inputSEARCH.Text.Trim()

        If String.IsNullOrWhiteSpace(searchTerm) Then
            MessageBox.Show("Please enter a name or an organization to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            LoadUserData()
            Return
        End If

        Dim connectionString As String = "Data Source=localhost; userid=root; password=; database=db_organization"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()


                Dim sql As String = "SELECT StudID, LNAME, FNAME, GENDER, DEPT, PROG, YEAR, ORG FROM record WHERE LNAME LIKE @SearchTerm OR FNAME LIKE @SearchTerm OR ORG LIKE @SearchTerm"
                Dim command As New MySqlCommand(sql, connection)


                command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

                Dim dataTable As New DataTable()
                Dim dataAdapter As New MySqlDataAdapter(command)
                dataAdapter.Fill(dataTable)

                dgvNames.DataSource = dataTable

                If dataTable.Rows.Count = 0 Then
                    MessageBox.Show("No records found for that search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred during the search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class