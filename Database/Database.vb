Imports System.Data.SqlClient

Module Database

    Public ServerName As String = My.Settings.ServerName
    Public DatabaseName As String = My.Settings.DBName
    Public Username As String = My.Settings.DBUsername
    Public Password As String = My.Settings.DBPassword

    ' === ReadOnly Connection String Property ===
    Public ReadOnly Property CurrentConnectionString As String
        Get
            Return $"Data Source={ServerName};Initial Catalog={DatabaseName};User ID={Username};Password={Password};MultipleActiveResultSets=True;"
        End Get
    End Property

    ' === Public LINQ to SQL DataContext ===
    Public db As POS_DBDataContext = CreateDataContext(CurrentConnectionString) ' Capital "C"

    ' === Function to get current connection string ===
    Public Function GetConnectionString() As String
        Return CurrentConnectionString
    End Function

    ' === Update the SQL Server connection dynamically ===
    Public Sub UpdateConnectionString(dataSource As String, database As String, username As String, password As String)
        ' Update the values
        ServerName = dataSource
        DatabaseName = database
        username = username
        password = password

        ' Save them to My.Settings
        My.Settings.ServerName = dataSource
        My.Settings.DBName = database
        My.Settings.DBUsername = username
        My.Settings.DBPassword = password
        My.Settings.Save()

        ' Recreate the DataContext with updated connection string
        db = CreateDataContext(CurrentConnectionString)
    End Sub

    ' === Helper to create and configure DataContext ===
    Private Function CreateDataContext(connStr As String) As POS_DBDataContext
        Return New POS_DBDataContext(connStr) With {
            .CommandTimeout = 10000
        }
    End Function

End Module
