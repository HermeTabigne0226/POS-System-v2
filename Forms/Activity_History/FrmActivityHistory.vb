Public Class FrmActivityHistory

    Private Sub FrmActivityHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureGrid()
        LoadAccountLogs()
    End Sub

    ' =====================================================
    ' GRID CONFIGURATION (ONE-TIME SETUP)
    ' =====================================================
    Private Sub ConfigureGrid()

        With DGV_ActivityHistory

            .SuspendLayout()

            ' 🔹 General behavior
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ScrollBars = ScrollBars.Both

            ' 🔹 Disable expensive autosize during load
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .DefaultCellStyle.WrapMode = DataGridViewTriState.False

            ' 🔹 Small columns → autosize
            .Columns(0).Width = 100                              ' #
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Action
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Module
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' RecordID
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Description

            ' 🔥 Long text columns → FIXED WIDTH + WRAP
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' OldValue
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' NewValue

            .Columns(5).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns(6).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

            ' 🔹 Remaining columns
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' User
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Role
            .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' IP
            .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Computer
            .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ' Date

            .ResumeLayout()

        End With

    End Sub

    ' =====================================================
    ' LOAD DATA (FAST & NON-BLOCKING)
    ' =====================================================
    Private Sub LoadAccountLogs()

        With DGV_ActivityHistory
            .SuspendLayout()
            .Rows.Clear()
        End With

        Dim logs = From t In db.tbl_auditTrails
                   Order By t.ActionDate Descending
                   Select t

        Dim rowNo As Integer = 1

        For Each log In logs

            DGV_ActivityHistory.Rows.Add(
                rowNo,
                log.ActionType,
                log.ModuleName,
                log.RecordID,
                log.Description,
                log.OldValue,
                log.NewValue,
                log.PerformedBy,
                log.UserRole,
                log.IPAddress,
                log.ComputerName,
                log.ActionDate.ToString("MMMM dd, yyyy")
            )

            rowNo += 1
        Next

        ' 🔥 Enable row auto-height AFTER data is loaded
        With DGV_ActivityHistory
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            .ResumeLayout()
        End With

    End Sub

End Class
