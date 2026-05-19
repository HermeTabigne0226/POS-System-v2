Public Class Functions

    Public Function Login(username As String, password As String) As Boolean
        Try
            Dim tbl_users = (From u In db.tbl_users
                             Where u.username = username And u.password = password And u.account_status = "Active"
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

    Public Sub InsertAuditTrail(
    ActionType As String,
    ModuleName As String,
    RecordID As String,
    Description As String,
    OldValue As String,
    NewValue As String,
    CurrentUserName As String,
    CurrentUserRole As String
    )

        Try
            db.SP_InsertAuditTrail(
            ActionType,
            ModuleName,
            RecordID,
            Description,
            If(String.IsNullOrEmpty(OldValue), Nothing, OldValue),
            If(String.IsNullOrEmpty(NewValue), Nothing, NewValue),
            CurrentUserName,              ' PerformedBy
            CurrentUserRole,              ' UserRole
            GetLocalIPAddress(),           ' IPAddress
            Environment.MachineName        ' ComputerName
        )

        Catch ex As Exception
            Debug.WriteLine("AuditTrail Error: " & ex.Message)
        End Try

    End Sub

    Private Function GetLocalIPAddress() As String
        Try
            Dim host = Net.Dns.GetHostEntry(Net.Dns.GetHostName())
            For Each ip In host.AddressList
                If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    Return ip.ToString()
                End If
            Next
        Catch
        End Try
        Return "Unknown"
    End Function





End Class
