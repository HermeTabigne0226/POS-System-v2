Imports Microsoft.Reporting.WinForms

Public Class FrmSalesHistory

    Private Sub FrmSalesHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultDateRange()

        SetDGV()
        LoadSalesHistoryPage()
        currentPage = 1

        If cmbRows.Items.Count > 0 Then
            cmbRows.SelectedIndex = 0
        End If
        LoadInvoiceReport(215)
    End Sub

    Private Sub LoadInvoiceReport(ID As String)
        Me.POS_DBDataSet.EnforceConstraints = False
        Me.SP_InvoicePrintTableAdapter.Fill(Me.POS_DBDataSet.SP_InvoicePrint, ID)
        printInvoice.RefreshReport()
    End Sub



    Private Sub SetDefaultDateRange()
        Dim today As Date = Date.Now

        Dim firstDay As New Date(today.Year, today.Month, 1)

        Dim lastDay As Date = firstDay.AddMonths(1).AddDays(-1)

        FromDate.Value = firstDay
        ToDate.Value = lastDay
    End Sub

    Private Sub SetDGV()

        ' ===== VIEW BUTTON =====
        If DGV_SalesHistory.Columns("colView") Is Nothing Then
            Dim btnView As New DataGridViewButtonColumn()
            btnView.Name = "colView"
            btnView.HeaderText = "View"
            btnView.Text = "View"
            btnView.UseColumnTextForButtonValue = True
            btnView.Width = 60
            btnView.FlatStyle = FlatStyle.Standard
            DGV_SalesHistory.Columns.Add(btnView)
        End If

        ' ===== DELETE BUTTON =====
        If DGV_SalesHistory.Columns("colDelete") Is Nothing Then
            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "colDelete"
            btnDelete.HeaderText = "Delete"   ' no header text (still under Action visually)
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True
            btnDelete.Width = 60
            btnDelete.FlatStyle = FlatStyle.Standard
            DGV_SalesHistory.Columns.Add(btnDelete)
        End If

        With DGV_SalesHistory

            .Columns(0).Width = 30
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(7).Visible = False

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

    End Sub


    Private currentPage As Integer = 1
    Private totalPages As Integer = 1
    Private totalRecords As Integer = 0



    Private Sub DGV_SalesHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV_SalesHistory.KeyDown
        If e.KeyCode = Keys.Escape Then
            DGV_SalesHistory.ClearSelection()

        End If
    End Sub


    Private Sub CmbRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRows.SelectedIndexChanged
        currentPage = 1
        LoadSalesHistoryPage()
    End Sub

    Private Sub LoadSalesHistoryPage()
        ' ✅ Make sure we cover the entire day(s)
        Dim txtfromDate As DateTime = FromDate.Value.Date
        Dim txttoDate As DateTime = ToDate.Value.Date.AddDays(1).AddSeconds(-1)
        Dim rowsPerPage As Integer = 0
        If cmbRows.SelectedItem IsNot Nothing Then
            rowsPerPage = Convert.ToInt32(cmbRows.SelectedItem)
        End If

        ' ✅ Query with corrected date range
        Dim SalesHistory = (From t1 In db.tbl_POSTransactions
                            Where t1.TransactionDate >= txtfromDate AndAlso t1.TransactionDate <= txttoDate
                            Order By t1.TransactionID Descending
                            Select t1).ToList()

        totalRecords = SalesHistory.Count

        ' ✅ Avoid divide by zero
        If rowsPerPage > 0 Then
            totalPages = CInt(Math.Ceiling(CDec(totalRecords) / CDec(rowsPerPage)))
        Else
            totalPages = 1
            rowsPerPage = totalRecords ' show all
        End If

        ' ✅ Skip and Take for pagination
        Dim pagedData = SalesHistory.Skip((currentPage - 1) * rowsPerPage).Take(rowsPerPage)

        ' ✅ Fill grid
        DGV_SalesHistory.Rows.Clear()
        Dim i As Integer = ((currentPage - 1) * rowsPerPage) + 1
        For Each row In pagedData
            DGV_SalesHistory.Rows.Add(i,
            row.TransactionDate.ToString("MMMM dd, yyyy - hh:mm:ss tt"),
            row.CustomerName,
            row.TotalAmount,
            row.TotalItems,
            row.PaymentMethod,
            row.GcashRef,
            row.TransactionID,
            "View")
            i += 1
        Next

        ' ✅ Update pagination label
        lblPageInfo.Text = $"Page {currentPage} of {totalPages}"

        UpdatePaginationButtons()

        DGV_SalesHistory.ClearSelection()
        ' Total invoices
        txtTotalInvoice.Text = totalRecords.ToString()

        ' Total items sold (all invoices)
        txtTotalItems.Text = SalesHistory.Sum(Function(x) x.TotalItems).ToString()

        txtTotalAmount.Text = SalesHistory.Sum(Function(x) x.TotalAmount).ToString()

        txtCashInvoice.Text =
    SalesHistory.Where(Function(x) x.PaymentMethod = "Cash").Count().ToString()

        txtGcashInvoice.Text =
    SalesHistory.Where(Function(x) x.PaymentMethod = "Gcash").Count().ToString()

    End Sub


    ' ✅ Update navigation buttons depending on current page
    Private Sub UpdatePaginationButtons()
        BtnFirstPage.Enabled = (currentPage > 1)
        BtnPrev.Enabled = (currentPage > 1)
        BtnNext.Enabled = (currentPage < totalPages)
        BtnLastPage.Enabled = (currentPage < totalPages)
    End Sub

    ' ✅ First Page
    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click
        If currentPage > 1 Then
            currentPage = 1
            LoadSalesHistoryPage()
        End If
    End Sub

    ' ✅ Previous Page
    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadSalesHistoryPage()
        End If
    End Sub

    ' ✅ Next Page
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadSalesHistoryPage()
        End If
    End Sub

    ' ✅ Last Page
    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click
        If currentPage < totalPages Then
            currentPage = totalPages
            LoadSalesHistoryPage()
        End If
    End Sub

    Private Sub FromDate_ValueChanged(sender As Object, e As EventArgs) Handles FromDate.ValueChanged
        currentPage = 1
        LoadSalesHistoryPage()
    End Sub

    Private Sub ToDate_ValueChanged(sender As Object, e As EventArgs) Handles ToDate.ValueChanged
        currentPage = 1
        LoadSalesHistoryPage()
    End Sub

    Private Sub DGV_SalesHistory_CellContentClick(
    sender As Object, e As DataGridViewCellEventArgs
) Handles DGV_SalesHistory.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        Dim transactionID As String =
        DGV_SalesHistory.Rows(e.RowIndex).Cells(7).Value.ToString()

        ' ===== VIEW =====
        If e.ColumnIndex = 8 Then
            setPrintLayout()
            LoadInvoiceReport(transactionID)

            ' ===== DELETE =====
        ElseIf e.ColumnIndex = 9 Then
            ConfirmAndDeleteTransaction(transactionID)
        End If

    End Sub

    Private Sub ConfirmAndDeleteTransaction(transactionID As String)

        Dim dlg As New Guna.UI2.WinForms.Guna2MessageDialog With {
        .Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo,
        .Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning,
        .Style = Guna.UI2.WinForms.MessageDialogStyle.Light,
        .Text = "Are you sure you want to delete this transaction?" & vbCrLf &
                "This action cannot be undone.",
        .Caption = "Confirm Delete"
    }

        If dlg.Show() = DialogResult.Yes Then
            DeleteTransaction(transactionID)
        End If

    End Sub


    Private Sub DeleteTransaction(transactionID As String)

        Try
            ' 🔹 1. GET DETAILS BEFORE DELETE (IMPORTANT)
            Dim trans = (From t In db.tbl_POSTransactions
                         Where t.TransactionID = transactionID
                         Select t).FirstOrDefault()

            If trans Is Nothing Then
                MessageBox.Show("Transaction not found.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Save values for audit
            Dim auditDescription As String =
            $"Deleted POS transaction | Customer: {trans.CustomerName} | " &
            $"Total: {trans.TotalAmount:N2} | Payment: {trans.PaymentMethod}"

            ' 🔹 2. DELETE (Stored Procedure)
            db.SP_DELETE_POS_TRANSACTION(transactionID)

            ' 🔹 3. AUDIT TRAIL
            Dim f As New Functions()
            f.InsertAuditTrail(
            "DELETE",
            "POS Transaction",
            transactionID,
            auditDescription,
            Nothing,                    ' OldValue (optional)
            Nothing,                    ' NewValue (optional)
            AdminHome.username.Trim(),
            AdminHome.Guna2HtmlLabel1.Text
        )

            ' 🔹 4. REFRESH CONTEXT
            db = New POS_DBDataContext()

            MessageBox.Show("Transaction deleted successfully.",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            ' 🔹 5. RELOAD GRID
            LoadSalesHistoryPage()

        Catch ex As Exception
            MessageBox.Show("Failed to delete transaction." & vbCrLf & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub






    Private Sub setPrintLayout()
        DGV_SalesHistory.Visible = False
        Guna2Panel2.Enabled = False
        printInvoice.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        backBtn.Visible = True
    End Sub

    Private Sub setSalesHistory()
        DGV_SalesHistory.Visible = True
        Guna2Panel2.Enabled = True
        backBtn.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        setSalesHistory()
    End Sub

End Class