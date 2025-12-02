Imports System.Data.SqlClient

Public Class SetDatabase

    Private Sub SetDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load RememberMe checkbox state
        RememberMe.Checked = My.Settings.RememberMe

        If My.Settings.RememberMe Then
            ' Load saved settings into textboxes
            txtServername.Text = My.Settings.ServerName
            txtDatabase.Text = My.Settings.DBName
            txtUsername.Text = My.Settings.DBUsername
            txtPassword.Text = My.Settings.DBPassword
        Else
            ' Clear fields if RememberMe is off
            txtServername.Clear()
            txtDatabase.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
        End If
    End Sub


    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        ' Get input from textboxes
        Dim server As String = txtServername.Text.Trim()
        Dim database As String = txtDatabase.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Build test connection string
        Dim testConnectionString As String =
        $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};MultipleActiveResultSets=True;"

        ' Try to test the connection
        Try
            Using conn As New SqlConnection(testConnectionString)
                conn.Open()
                ' If successful, save settings
                If RememberMe.Checked Then
                    My.Settings.ServerName = server
                    My.Settings.DBName = database
                    My.Settings.DBUsername = username
                    My.Settings.DBPassword = password
                Else
                    My.Settings.ServerName = ""
                    My.Settings.DBName = ""
                    My.Settings.DBUsername = ""
                    My.Settings.DBPassword = ""
                End If

                My.Settings.RememberMe = RememberMe.Checked
                My.Settings.Save()

                ' Apply connection globally
                UpdateConnectionString(server, database, username, password)

                MessageBox.Show("Connection settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the server. Please check your credentials and try again." & vbCrLf & vbCrLf &
                        "Error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles RememberMe.CheckedChanged
        ' Optional: instant save of checkbox toggle
        My.Settings.RememberMe = RememberMe.Checked
        My.Settings.Save()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
