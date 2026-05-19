Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class POSPayment


    Private Sub POSPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Calculate()

        TxtCustomerName.Focus()
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.Visible = False
        Me.POS_DBDataSet.SP_InvoicePrint.Clear()

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtCashReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCashReceived.TextChanged
#Enable Warning IDE1006 ' Naming Styles
        Calculate()
    End Sub

    Private Sub Calculate()
        Dim cashReceived As Decimal = 0
        Dim totalAmount As Decimal = 0
        Dim changeAmount As Decimal = 0

        Decimal.TryParse(txtCashReceived.Text, cashReceived)
        Decimal.TryParse(txtTotalAmount.Text, totalAmount)

        changeAmount = cashReceived - totalAmount

        txtChangeAmount.Text = changeAmount.ToString("N2")
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtCashReceived_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashReceived.KeyPress
#Enable Warning IDE1006 ' Naming Styles
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not txtCashReceived.Text.Contains(".") Then
            Return
        End If

        e.Handled = True
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtCashReceived_Leave(sender As Object, e As EventArgs) Handles txtCashReceived.Leave
#Enable Warning IDE1006 ' Naming Styles
        Dim value As Decimal = 0



        If Decimal.TryParse(txtCashReceived.Text, value) Then
            If txtCashReceived.Text.Trim() <> "" Then
                txtCashReceived.Text = value.ToString("N2")
            Else
                txtCashReceived.Text = "0.00"
            End If
        Else
            txtCashReceived.Text = "0.00"
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        If txtChangeAmount.Text < 0 Then
            negativeWarning.Show()
            txtCashReceived.Focus()

            Exit Sub
        Else
            If confirmSave.Show = DialogResult.OK Then
                SaveTransactions()

            Else
                Exit Sub

            End If
        End If

    End Sub
    Private Sub LoadInvoiceReport(ID As String)
        Me.POS_DBDataSet.EnforceConstraints = False
        Me.SP_InvoicePrintTableAdapter.Fill(Me.POS_DBDataSet.SP_InvoicePrint, ID)
        ReportViewer1.RefreshReport()
        PrintReport()
    End Sub

    Private Sub PrintReport()
        Dim printDialog As New PrintDialog()
        Dim printDoc As New PrintDocument()


        printDialog.Document = printDoc
        If printDialog.ShowDialog() = DialogResult.OK Then
            ReportViewer1.PrintDialog()
        End If
    End Sub





    Private Sub setPrintLayout()
        ReportViewer1.Visible = True
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
    End Sub


    Public TotalItems As Integer
    Public vatSales As Decimal
    Public vatExemptSales As Decimal
    Public totalSales As Decimal
    Public vatAmount As Decimal
    Public createdBy As String

    Private Function savePOSTransaction() As Integer

        Dim CustomerName As String = TxtCustomerName.Text
        Dim totalAmount As Decimal = CDec(txtTotalAmount.Text)

        Dim paymentMethod As String =
        If(radioCash.Checked, "Cash",
        If(radioGcash.Checked, "Gcash", "Unknown"))

        Dim cashReceived As Decimal = CDec(txtCashReceived.Text)
        Dim changeAmount As Decimal = CDec(txtChangeAmount.Text)

        Dim newTransactionID As Integer = 0

        Try
            ' 🔹 Save transaction (HEADER)
            db.SP_InsertPOSTransaction(
            CustomerName,
            TotalItems,
            vatSales,
            vatExemptSales,
            totalSales,
            vatAmount,
            totalAmount,
            paymentMethod,
            cashReceived,
            changeAmount,
            createdBy,
            GcashRef.Text,
            newTransactionID        ' 🔥 OUTPUT PARAM
        )

            ' 🔹 AUDIT TRAIL (AFTER SUCCESS)
            Dim f As New Functions()

            f.InsertAuditTrail(
            "INSERT",
            "POS Transaction",
            newTransactionID.ToString(),
            "Created POS transaction | Total: " & totalAmount.ToString("N2") &
            " | Payment: " & paymentMethod,
            Nothing,                    ' OldValue
            Nothing,                    ' NewValue
            AdminHome.username.Trim(),
            AdminHome.Guna2HtmlLabel1.Text
        )

            MessageBox.Show("Transaction saved successfully!",
                        "POS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message,
                        "POS Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

        Return newTransactionID

    End Function



    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover

        Guna2Button1.FillColor = Color.FromArgb(85, 96, 128)
        Guna2Button1.ForeColor = Color.FromArgb(225, 225, 225)

    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave


        Guna2Button1.FillColor = Color.FromArgb(216, 228, 242)
        Guna2Button1.ForeColor = Color.FromArgb(85, 96, 128)


    End Sub

    Private Sub TxtCashReceived_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCashReceived.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtChangeAmount.Text < 0 Then
                negativeWarning.Show()
                txtCashReceived.Focus()

                Exit Sub
            Else
                If confirmSave.Show = DialogResult.OK Then
                    SaveTransactions()
                Else
                    Exit Sub

                End If
            End If
        Else
            Exit Sub

        End If
    End Sub



    Private Sub SaveTransactions()

        ' 1️⃣ SAVE HEADER
        Dim transactionID As Integer = savePOSTransaction()
        If transactionID <= 0 Then
            MessageBox.Show("Header not saved.", "POS Error")
            Exit Sub
        End If

        ' 2️⃣ GET SALES FORM
        Dim frm As FrmSalesTransaction =
        Application.OpenForms.OfType(Of FrmSalesTransaction).FirstOrDefault()

        If frm Is Nothing Then
            MessageBox.Show("Sales form not found.", "POS Error")
            Exit Sub
        End If

        ' 🔥 IMPORTANT: COPY GRID REFERENCE NOW
        Dim dgv As DataGridView = frm.Guna2DataGridView1

        If dgv.Rows.Cast(Of DataGridViewRow)().
        All(Function(r) r.IsNewRow) Then

            MessageBox.Show("No rows in grid to save.", "DEBUG")
            Exit Sub
        End If

        Try
            ' 3️⃣ SAVE DETAILS (GRID MUST STILL HAVE DATA)
            Dim success As Boolean =
            frm.InsertPOSDetails(dgv, transactionID)

            If Not success Then Exit Sub

            ' 4️⃣ UPDATE STOCK
            frm.UpdateProductQuantities(dgv)

            ' 5️⃣ PRINT (AFTER SAVE)
            setPrintLayout()
            LoadInvoiceReport(transactionID.ToString())

            ' 6️⃣ RESET UI LAST (VERY LAST)
            'frm.ResetTransaction()
            ResetPayment()

        Catch ex As Exception
            MessageBox.Show("Transaction failed: " & ex.Message,
                        "POS Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub




    Public Sub ResetPayment()

        ' Clear text fields
        TxtCustomerName.Clear()
        txtCashReceived.Text = "0.00"
        txtChangeAmount.Text = "0.00"

        ' Reset radio buttons
        radioCash.Checked = True
        radioGcash.Checked = False

        ' Reset totals
        txtTotalAmount.Text = "0.00"


    End Sub






    Private Sub radioGcash_CheckedChanged(sender As Object, e As EventArgs) Handles radioGcash.CheckedChanged
        If radioGcash.Checked = True Then
            frmGcashReference.ShowDialog()
        End If
    End Sub

    Private Sub POSPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.Visible = False
    End Sub
End Class