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

        If DGV_SalesHistory.Columns("colView") Is Nothing Then
            Dim btn As New DataGridViewButtonColumn()
            btn.Name = "colView"
            btn.HeaderText = "Action"
            btn.Text = "View"
            btn.UseColumnTextForButtonValue = True
            btn.Width = 50
            DGV_SalesHistory.Columns.Add(btn)
        End If

        With DGV_SalesHistory

            .Columns(0).Width = 30
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).Width = 150
            .Columns(6).Visible = false
            .Columns(7).Width = 100

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
            row.TransactionID,
            "View")
            i += 1
        Next

        ' ✅ Update pagination label
        lblPageInfo.Text = $"Page {currentPage} of {totalPages}"

        UpdatePaginationButtons()
        DGV_SalesHistory.ClearSelection()
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

    Private Sub DGV_SalesHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_SalesHistory.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        ' Option A: If you fixed column Name = "Actions"
        If e.ColumnIndex = 7 Then
            Dim transactionID As String = DGV_SalesHistory.Rows(e.RowIndex).Cells(6).Value.ToString()
            setPrintLayout()
            LoadInvoiceReport(transactionID)
        End If
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