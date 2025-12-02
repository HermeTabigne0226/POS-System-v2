Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True





        'If TestConnection() Then
        '    MessageBox.Show("Connected to SQL Server!", "Success")
        'Else
        '    MessageBox.Show("Failed to connect. Please check the connection string.", "Connection Error")
        '    Exit Sub
        'End If

        'Try
        '    ' Use LINQ to load users
        '    Dim userList = (From u In db.tbl_users Select u).ToList()

        '    If userList.Any() Then
        '        MessageBox.Show("Total users found: " & userList.Count.ToString())
        '    Else
        '        MessageBox.Show("No users found.")
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("Error loading users: " & ex.Message)
        'End Try
    End Sub

    Private isPasswordVisible As Boolean = False

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        isPasswordVisible = Not isPasswordVisible

        If isPasswordVisible Then
            txtPassword.UseSystemPasswordChar = False
            Guna2CirclePictureBox2.Image = My.Resources.eye ' 👁 show password icon
        Else
            txtPassword.UseSystemPasswordChar = True
            Guna2CirclePictureBox2.Image = My.Resources.hide ' 🙈 hide password icon
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim f As New Functions()
        Dim isLoggedIn = f.Login(txtUsername.Text.Trim(), txtPassword.Text)

        If isLoggedIn Then

        End If
    End Sub







End Class
