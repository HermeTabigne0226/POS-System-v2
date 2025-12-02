Public Class FrmActivityHistory


    Private Sub FrmActivityHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountLogs()
    End Sub

    Private Sub LoadAccountLogs()
        DGV_AccountList.Rows.Clear()

        Dim tbl_userAccountLogs = From t1 In db.tbl_account_logs Join t2 In db.tbl_users On t1.user_id Equals t2.user_id Order By t1.id Descending
                                  Select t1.user_id, t2.fullname, t1.date, t1.time, t1.history_log

        For Each log In tbl_userAccountLogs
            Dim formattedDate As String = Format(CDate(log.date), "MMMM dd, yyyy")
            DGV_AccountList.Rows.Add(log.user_id, log.fullname, formattedDate, log.time, log.history_log)
        Next

        DGV_AccountList.Columns(0).Width = 100
        DGV_AccountList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_AccountList.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_AccountList.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_AccountList.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

End Class