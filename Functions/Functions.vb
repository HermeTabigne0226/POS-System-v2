Public Class Functions

    Public Function Login(username As String, password As String) As Boolean
        Try
            Dim tbl_users = (From u In db.tbl_users
                             Where u.username = username And u.password = password
                             Select u).FirstOrDefault()

            If tbl_users IsNot Nothing Then
                Dim userID = tbl_users.user_id
                Dim userType = tbl_users.account_type

                AdminHome.txtUserID.Text = userID
                AdminHome.Guna2HtmlLabel1.Text = userType.ToUpper
                Return True
            Else
                Dim form As New Login
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
            Return False
        End Try
    End Function





End Class
