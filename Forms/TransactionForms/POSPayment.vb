Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class POSPayment


    Private Sub POSPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Calculate()

        TxtCustomerName.Focus()
        Me.ReportViewer1.RefreshReport()
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
            txtCashReceived.Text = value.ToString("N2")
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
#Disable Warning IDE1006 ' Naming Styles
    Private Sub savePOSTransaction()
#Enable Warning IDE1006 ' Naming Styles
        Dim CustomerName As String = TxtCustomerName.Text
        Dim totalAmount As Decimal = CDec(txtTotalAmount.Text)

        ' Payment Method
        Dim paymentMethod As String
        If radioCash.Checked Then
            paymentMethod = "Cash"
        ElseIf radioCard.Checked Then
            paymentMethod = "Card"
        Else
            paymentMethod = "Unknown"
        End If

        Dim cashReceived As Decimal = CDec(txtCashReceived.Text)
        Dim changeAmount As Decimal = CDec(txtChangeAmount.Text)



        Try
            db.SP_InsertPOSTransaction(CustomerName,
                                       TotalItems,
                                       vatSales,
                                       vatExemptSales,
                                       totalSales,
                                       vatAmount,
                                       totalAmount,
                                       paymentMethod,
                                       cashReceived,
                                       changeAmount,
                                       createdBy)

            MessageBox.Show("Transaction saved successfully!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message, "POS Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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


    Private Sub POSPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TxtCustomerName.Clear()
        radioCash.Checked = True
        txtCashReceived.Text = 0.00

    End Sub

    Private Sub SaveTransactions()
        savePOSTransaction()

        Dim frm As FrmSalesTransaction = Application.OpenForms.OfType(Of FrmSalesTransaction).FirstOrDefault()

        If frm IsNot Nothing Then
            frm.InsertPOSDetails(frm.txtInvoiceNo.Text, frm.Guna2DataGridView1)
            FrmSalesTransaction.UpdateProductQuantities(frm.Guna2DataGridView1)
        End If

        setPrintLayout()
        LoadInvoiceReport(InvoiceID.Text)
    End Sub
End Class