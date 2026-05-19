Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmDashboard

    ' ===============================
    ' FORM LOAD
    ' ===============================
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPeriodCombo()
        cboPeriod.SelectedIndex = 0   ' Today
    End Sub




    ' ===============================
    ' LOAD PERIOD COMBO
    ' ===============================
    Private Sub LoadPeriodCombo()
        cboPeriod.Items.Clear()
        cboPeriod.Items.Add("Today")
        cboPeriod.Items.Add("Monthly")
        cboPeriod.Items.Add("Yearly")
    End Sub

    ' ===============================
    ' PERIOD CHANGED
    ' ===============================
    Private Sub cboPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboPeriod.SelectedIndexChanged

        cboValue.Items.Clear()

        Select Case cboPeriod.Text
            Case "Today"
                cboValue.Items.Add(0)
                cboValue.SelectedIndex = 0

            Case "Monthly"
                For m As Integer = 1 To 12
                    cboValue.Items.Add(m)
                Next
                cboValue.SelectedIndex = Date.Now.Month - 1

            Case "Yearly"
                LoadYears()
        End Select
    End Sub

    ' ===============================
    ' LOAD YEARS FROM DB
    ' ===============================
    Private Sub LoadYears()

        Dim years = (
            From t In db.tbl_POSTransactions
            Select t.TransactionDate.Year
        ).Distinct().OrderByDescending(Function(y) y).ToList()

        cboValue.Items.Clear()

        For Each y In years
            cboValue.Items.Add(y)
        Next

        If cboValue.Items.Count > 0 Then
            cboValue.SelectedIndex = 0
        End If

    End Sub

    ' ===============================
    ' VALUE CHANGED
    ' ===============================
    Private Sub cboValue_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboValue.SelectedIndexChanged

        If cboValue.SelectedIndex = -1 Then Exit Sub

        LoadDashboard()
        LoadSalesChart()
        LoadSalesComparison()
    End Sub

    ' ===============================
    ' DASHBOARD TOTALS
    ' ===============================
    Private Sub LoadDashboard()

        Dim startDate As Date
        Dim endDate As Date

        Select Case cboPeriod.Text

            Case "Today"
                startDate = Date.Today
                endDate = Date.Today.AddDays(1)
                LoadTopSales(startDate, endDate)
            Case "Monthly"
                Dim month As Integer = CInt(cboValue.Text)
                Dim year As Integer = Date.Now.Year
                startDate = New DateTime(year, month, 1)
                endDate = startDate.AddMonths(1)
                LoadTopSales(startDate, endDate)
            Case "Yearly"
                Dim year As Integer = CInt(cboValue.Text)
                startDate = New DateTime(year, 1, 1)
                endDate = startDate.AddYears(1)
                LoadTopSales(startDate, endDate)
            Case Else
                Exit Sub
        End Select

        Dim sales = (
            From t In db.tbl_POSTransactions
            Where t.TransactionDate >= startDate AndAlso
                  t.TransactionDate < endDate
        ).ToList()

        Dim totalSales = sales.Sum(Function(x) x.TotalAmount)
        Dim totalItems = sales.Sum(Function(x) x.TotalItems)
        Dim totalRevenue = sales.Sum(Function(x) x.TotalSales)
        Dim totalVat = sales.Sum(Function(x) x.VatAmount)

        txtTodaySales.Text = "₱ " & totalSales.ToString("N2")
        txtTotalItems.Text = totalItems.ToString("N0")
        txtTotalRevenue.Text = "₱ " & totalRevenue
        txtTotalVAT.Text = "₱ " & totalVat.ToString("N2")

    End Sub

    ' ===============================
    ' RESET CHART
    ' ===============================
    Private Sub ResetChart()
        chartSales.Series.Clear()
        chartSales.ChartAreas(0).AxisX.Title = ""
        chartSales.ChartAreas(0).AxisY.Title = "Sales Amount"
    End Sub


    ' =========================================
    ' GET DATE RANGE BASED ON PERIOD + VALUE
    ' =========================================
    Private Sub GetSelectedDateRange(ByRef startDate As Date, ByRef endDate As Date)

        Select Case cboPeriod.Text

            Case "Today"
                startDate = Date.Today
                endDate = Date.Today.AddDays(1)

            Case "Monthly"
                Dim month As Integer = CInt(cboValue.Text)
                Dim year As Integer = Date.Now.Year

                startDate = New DateTime(year, month, 1)
                endDate = startDate.AddMonths(1)

            Case "Yearly"
                Dim year As Integer = CInt(cboValue.Text)

                startDate = New DateTime(year, 1, 1)
                endDate = startDate.AddYears(1)

            Case Else
                startDate = Date.Today
                endDate = Date.Today
        End Select

    End Sub


    ' ===============================
    ' LOAD SALES CHART
    ' ===============================
    Private Sub LoadSalesChart()

        ResetChart()

        Dim series As New Series("Sales")
        series.ChartType = SeriesChartType.Line
        series.BorderWidth = 3
        series.IsValueShownAsLabel = True

        Select Case cboPeriod.Text

            ' -------- TODAY --------
            Case "Today"

                chartSales.ChartAreas(0).AxisX.Title = "Hour"

                Dim data = (
                    From t In db.tbl_POSTransactions
                    Where t.TransactionDate >= Date.Today AndAlso
                          t.TransactionDate < Date.Today.AddDays(1)
                    Group By Hr = t.TransactionDate.Hour
                    Into Total = Sum(t.TotalAmount)
                    Order By Hr
                )

                For Each d In data
                    series.Points.AddXY(d.Hr & ":00", d.Total)
                Next

            ' -------- MONTHLY --------
            Case "Monthly"

                chartSales.ChartAreas(0).AxisX.Title = "Day"

                Dim startDate As Date
                Dim endDate As Date
                GetSelectedDateRange(startDate, endDate)

                ' Get actual sales grouped by day
                Dim salesData = (
                From t In db.tbl_POSTransactions
                Where t.TransactionDate >= startDate AndAlso
                      t.TransactionDate < endDate
                Group By d = t.TransactionDate.Day
                Into Total = Sum(t.TotalAmount)
            ).ToDictionary(Function(x) x.d, Function(x) x.Total)

                Dim daysInMonth As Integer =
               Date.DaysInMonth(startDate.Year, startDate.Month)

                ' Fill all days
                For day As Integer = 1 To daysInMonth
                    Dim amount As Decimal = 0D
                    If salesData.ContainsKey(day) Then
                        amount = salesData(day)
                    End If

                    series.Points.AddXY("Day " & day, amount)
                Next

            ' -------- YEARLY --------
            Case "Yearly"

                Dim year As Integer = CInt(cboValue.Text)

                Dim startYear = New DateTime(year, 1, 1)
                Dim endYear = startYear.AddYears(1)

                chartSales.ChartAreas(0).AxisX.Title = "Month"

                Dim data = (
                    From t In db.tbl_POSTransactions
                    Where t.TransactionDate >= startYear AndAlso
                          t.TransactionDate < endYear
                    Group By M = t.TransactionDate.Month
                    Into Total = Sum(t.TotalAmount)
                    Order By M
                )

                For Each d In data
                    series.Points.AddXY(MonthName(d.M), d.Total)
                Next

        End Select

        chartSales.Series.Add(series)

    End Sub

    Private Sub LoadSalesComparison()

        Dim currStart As Date
        Dim currEnd As Date
        Dim prevStart As Date
        Dim prevEnd As Date
        Dim periodLabel As String = ""

        Select Case cboPeriod.Text

            Case "Today"
                currStart = Date.Today
                currEnd = Date.Today.AddDays(1)

                prevStart = Date.Today.AddDays(-1)
                prevEnd = Date.Today

                periodLabel = "yesterday"

            Case "Monthly"
                Dim month As Integer = CInt(cboValue.Text)
                Dim year As Integer = Date.Now.Year

                currStart = New DateTime(year, month, 1)
                currEnd = currStart.AddMonths(1)

                prevStart = currStart.AddMonths(-1)
                prevEnd = currStart

                periodLabel = "last month"

            Case "Yearly"
                Dim year As Integer = CInt(cboValue.Text)

                currStart = New DateTime(year, 1, 1)
                currEnd = currStart.AddYears(1)

                prevStart = currStart.AddYears(-1)
                prevEnd = currStart

                periodLabel = "last year"

            Case Else
                Exit Sub
        End Select

        ' =============================
        ' CURRENT SALES
        ' =============================
        Dim currentSalesNullable As Decimal? =
            (From t In db.tbl_POSTransactions
             Where t.TransactionDate >= currStart AndAlso
                   t.TransactionDate < currEnd
             Select CType(t.TotalAmount, Nullable(Of Decimal))
            ).Sum()

        Dim currentSales As Decimal =
            If(currentSalesNullable.HasValue, currentSalesNullable.Value, 0D)

        ' =============================
        ' PREVIOUS SALES
        ' =============================
        Dim previousSalesNullable As Decimal? =
            (From t In db.tbl_POSTransactions
             Where t.TransactionDate >= prevStart AndAlso
                   t.TransactionDate < prevEnd
             Select CType(t.TotalAmount, Nullable(Of Decimal))
            ).Sum()

        Dim previousSales As Decimal =
            If(previousSalesNullable.HasValue, previousSalesNullable.Value, 0D)

        ' =============================
        ' PERCENT CHANGE
        ' =============================
        Dim percentChange As Decimal = 0D

        If previousSales > 0 Then
            percentChange =
                ((currentSales - previousSales) / previousSales) * 100
        End If

        ' =============================
        ' UPDATE UI
        ' =============================
        lblCurrentSales.Text = "₱ " & currentSales.ToString("N2")
        lblPreviousSales.Text = "₱ " & previousSales.ToString("N2")

        If previousSales = 0 AndAlso currentSales > 0 Then
            lblComparison.Text = "↑ New sales vs " & periodLabel
            lblComparison.ForeColor = Color.Green

        ElseIf percentChange > 0 Then
            lblComparison.Text =
                "↑ " & percentChange.ToString("N2") & "% vs " & periodLabel
            lblComparison.ForeColor = Color.Green

        ElseIf percentChange < 0 Then
            lblComparison.Text =
                "↓ " & Math.Abs(percentChange).ToString("N2") & "% vs " & periodLabel
            lblComparison.ForeColor = Color.Red

        Else
            lblComparison.Text = "No change vs " & periodLabel
            lblComparison.ForeColor = Color.Gray
        End If

    End Sub


    Private Sub LoadTopSales(startDate As Date, endDate As Date)

        dgvTopSales.Rows.Clear()

        Dim topSales = (
            From d In db.tbl_POSTransactionDetails
            Join h In db.tbl_POSTransactions
                On d.TransactionID Equals h.TransactionID
            Where h.TransactionDate >= startDate AndAlso
                  h.TransactionDate < endDate
            Group By d.ProductName Into
                Qty = Sum(d.Quantity),
                Amount = Sum(d.Total)
            Order By Amount Descending
            Select ProductName, Qty, Amount
        ).Take(5).ToList()

        Dim rank As Integer = 1

        For Each item In topSales
            dgvTopSales.Rows.Add(
                rank,
                item.ProductName,
                item.Qty.ToString("N0"),
                item.Amount
            )
            rank += 1
        Next

    End Sub



End Class
