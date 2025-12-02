Public Class FrmSalesTransaction


    Private Sub FrmSalesTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductCodes()
        LoadUserDetails()
        SetDGV()
        CalculateTotals()
        LoadLatestTransactionID()

        Me.KeyPreview = True
        Guna2DataGridView1.StandardTab = True
    End Sub

#Region "Method"

    Private Sub SetDGV()


        With Guna2DataGridView1
            .ReadOnly = False
            .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False

            .Columns(0).Width = 80
            ' === Price ===
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Format = "N2"

            ' === Quantity ===
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Format = "N0"

            ' === Extend Price ===
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Format = "N2"

            ' === Discount Amount (RED TEXT) ===
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Format = "N2"
            .Columns(5).DefaultCellStyle.ForeColor = Color.Red

            ' === Total Price (BOLD TEXT) ===
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Format = "N2"
            .Columns(6).DefaultCellStyle.Font = New Font(.Font, FontStyle.Bold)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black


            For Each col As DataGridViewColumn In .Columns
                col.ReadOnly = True
            Next

            .Columns(3).ReadOnly = False
            .Columns(5).ReadOnly = False


        End With




    End Sub

    Private Sub Guna2DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Guna2DataGridView1.EditingControlShowing
        Dim tb As TextBox = TryCast(e.Control, TextBox)

        If tb IsNot Nothing Then
            ' Remove any existing handler (to avoid duplicates)
            RemoveHandler tb.KeyPress, AddressOf NumericTextBox_KeyPress

            ' Apply only on specific columns (Quantity = index 3, Discount = index 5)
            If Guna2DataGridView1.CurrentCell.ColumnIndex = 3 OrElse Guna2DataGridView1.CurrentCell.ColumnIndex = 5 Then
                AddHandler tb.KeyPress, AddressOf NumericTextBox_KeyPress
            End If
        End If
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow digits, control keys (like backspace), and one dot
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one dot
        Dim tb As TextBox = CType(sender, TextBox)
        If e.KeyChar = "."c AndAlso tb.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellEndEdit
        Try
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)

            ' Safely convert values (default if empty)
            Dim price As Decimal = If(IsNumeric(row.Cells(2).Value), CDec(row.Cells(2).Value), 0D)
            Dim qty As Decimal = If(IsNumeric(row.Cells(3).Value), CDec(row.Cells(3).Value), 1D)
            Dim discount As Decimal = If(IsNumeric(row.Cells(5).Value), CDec(row.Cells(5).Value), 0D)

            ' Force minimum qty = 1
            If qty <= 0 Then qty = 1D

            ' Calculate
            Dim extendPrice As Decimal = price * qty
            Dim totalPrice As Decimal = extendPrice - discount
            If totalPrice < 0 Then totalPrice = 0D

            ' Update grid (formatted N2)
            row.Cells(3).Value = qty.ToString("N0")
            row.Cells(4).Value = extendPrice.ToString("N2")
            row.Cells(5).Value = discount.ToString("N2")
            row.Cells(6).Value = totalPrice.ToString("N2")



        Catch

        Finally
            CalculateTotals()
            Guna2DataGridView1.ClearSelection()
        End Try

        Guna2DataGridView1.ClearSelection()
    End Sub

    Private Sub LoadLatestTransactionID()
        ' Get the latest TransactionID from POSTransaction table
        Dim latest = (From t In db.tbl_POSTransactions
                      Order By t.TransactionID Descending
                      Select t.TransactionID).FirstOrDefault()

        ' If no transactions, start with 1
        If latest > 0 Then
            txtInvoiceNo.Text = (latest + 1).ToString("D6")  ' Next ID, formatted to 6 digits
        Else
            txtInvoiceNo.Text = "000001"
        End If
    End Sub





    Private Sub LoadUserDetails()
        Dim txtID As String = AdminHome.txtUserID.Text

        Dim tbl_users = (From t1 In db.tbl_users
                         Where t1.user_id = txtID
                         Select t1).FirstOrDefault()

        If tbl_users IsNot Nothing Then
            txtName.Text = tbl_users.fullname.ToUpper
            txtPosition.Text = tbl_users.account_type.ToUpper
        Else
            txtName.Text = ""
            txtPosition.Text = ""
        End If
    End Sub

    Private Sub LoadProductCodes()

        ' Assuming db is your DataContext or DataSet
        Dim productCodes = (From t1 In db.tbl_products
                            Select t1.ProductCode).ToList()


        Dim auto As New AutoCompleteStringCollection()
        For Each code In productCodes
            auto.Add(code)
        Next

        txtProductCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtProductCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtProductCode.AutoCompleteCustomSource = auto

        productCodes.Insert(0, "")

        txtProductCode.DataSource = productCodes


    End Sub

    Private Sub TxtproductCode_Enter(sender As Object, e As EventArgs)
        If txtProductCode.Text = "" Then
            ' Trick: send a fake key to trigger the dropdown
            SendKeys.Send("{DOWN}")
        End If
    End Sub

    Private Sub TxtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        loadItemDescription()
    End Sub


#Disable Warning IDE1006 ' Naming Styles
    Private Sub loadItemDescription()
#Enable Warning IDE1006 ' Naming Styles
        Dim prodCode As String = txtProductCode.Text

        Dim product = (From t1 In db.tbl_products
                       Where t1.ProductCode = prodCode
                       Select t1).FirstOrDefault()

        If product IsNot Nothing Then
            txtItemDesc.Text = product.BrandName & " - " & product.GenericName & " " & product.UnitValue & " " & product.Unit
            txtAvailableQty.Text = product.Quantity.ToString()

            ' Change color based on quantity
            Dim qty As Integer = Convert.ToInt32(product.Quantity)

            If qty = 0 Then
                txtAvailableQty.ForeColor = Color.Red
            ElseIf qty >= 10 AndAlso qty <= 20 Then
                txtAvailableQty.ForeColor = Color.Orange
            ElseIf qty > 20 AndAlso qty <= 50 Then
                txtAvailableQty.ForeColor = Color.Goldenrod ' Yellow-ish
            Else
                txtAvailableQty.ForeColor = Color.FromArgb(85, 96, 128)
            End If
        Else
            txtItemDesc.Text = ""
            txtAvailableQty.Text = ""
            txtAvailableQty.ForeColor = Color.FromArgb(85, 96, 128)
        End If

        Guna2DataGridView1.ClearSelection()
    End Sub


    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click

        insertProduct()
        CalculateTotals()
        Guna2DataGridView1.ClearSelection()
    End Sub

    Private Sub CalculateTotals()
        Dim totalItems As Integer = 0
        Dim totalAmount As Decimal = 0
        Dim vatRate As Decimal = 0.12D ' 12% VAT (adjust as needed)

        ' Loop through DataGridView rows
        For Each row As DataGridViewRow In Guna2DataGridView1.Rows
            If Not row.IsNewRow Then
                ' Count total items (sum of quantity)
                totalItems += Convert.ToInt32(row.Cells(3).Value)

                ' Sum up Total Price column (already VAT-inclusive)
                totalAmount += Convert.ToDecimal(row.Cells(6).Value)
            End If
        Next

        ' Compute VAT breakdown
        Dim vatSales As Decimal = totalAmount / (1 + vatRate)    ' VATable Sales
        Dim vatAmount As Decimal = totalAmount - vatSales        ' VAT Amount
        Dim vatExemptSales As Decimal = 0                        ' Change if you add exempt items
        Dim totalSales As Decimal = vatSales + vatExemptSales    ' Total Sales (before VAT)

        ' Display values
        txtTotalItems.Text = totalItems.ToString()
        txtVatSales.Text = vatSales.ToString("N2")
        txtVatExemptSales.Text = vatExemptSales.ToString("N2")
        txtTotalSales.Text = totalSales.ToString("N2")
        txtVatAmount.Text = vatAmount.ToString("N2")
        txtTotalAmount.Text = totalAmount.ToString("N2")
        POSPayment.txtTotalAmount.Text = totalAmount.ToString("N2")
    End Sub





#Disable Warning IDE1006 ' Naming Styles
    Private Sub insertProduct()
#Enable Warning IDE1006 ' Naming Styles

        If txtProductCode.Text = "" Or txtItemDesc.Text = "" Then
            Exit Sub
        Else
            ' Check if product already exists in DataGridView
            For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                If Not row.IsNewRow AndAlso row.Cells(0).Value.ToString() = txtProductCode.Text Then

                    warningDuplicate.Show()

                    row.Selected = True
                    Guna2DataGridView1.CurrentCell = row.Cells(3)
                    Guna2DataGridView1.BeginEdit(True)
                    Exit Sub
                End If
            Next

            ' If not duplicate, insert new product
            Dim price = (From t1 In db.tbl_products
                         Where t1.ProductCode = txtProductCode.Text
                         Select t1.SellingPrice).FirstOrDefault

            Dim quantity As Decimal = 1
            Dim Extend_Price As Decimal = price * quantity
            Dim discount As Decimal = 0.00
            Dim Total As Decimal = Extend_Price + discount

            Guna2DataGridView1.Rows.Add(txtProductCode.Text, txtItemDesc.Text, price, quantity, Extend_Price, discount, Total)
            Guna2DataGridView1.ClearSelection()
        End If

    End Sub


    Private Sub Guna2DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2DataGridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' Clear selection
            Guna2DataGridView1.ClearSelection()
        ElseIf e.KeyCode = Keys.Enter Then

            Guna2DataGridView1.ClearSelection()

        ElseIf e.KeyCode = Keys.F2 Then
            ' Remove selected row
            If Guna2DataGridView1.SelectedRows.Count > 0 AndAlso Not Guna2DataGridView1.SelectedRows(0).IsNewRow Then
                If confirmRemove.Show = DialogResult.OK Then
                    Guna2DataGridView1.Rows.Remove(Guna2DataGridView1.SelectedRows(0))
                    CalculateTotals()
                End If
            Else
                noProductMsg.Show()

            End If

        ElseIf e.KeyCode = Keys.F6 Then
            ' Focus on Quantity cell (index 3) of the current row
            If Guna2DataGridView1.CurrentRow IsNot Nothing AndAlso Not Guna2DataGridView1.CurrentRow.IsNewRow Then
                Guna2DataGridView1.CurrentCell = Guna2DataGridView1.CurrentRow.Cells(3) ' Qty column
                Guna2DataGridView1.BeginEdit(True)
            End If




        End If
    End Sub


    Private Sub TxtProductCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAvailableQty.Text <= 20 Then
                CheckLowStock()
            End If
            insertProduct()
            CalculateTotals()
        End If
    End Sub

    Private Sub FrmSalesTransaction_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then

            If Guna2DataGridView1.Rows.Count > 0 AndAlso Not (Guna2DataGridView1.Rows.Count = 1 AndAlso Guna2DataGridView1.Rows(0).IsNewRow) Then

                    e.SuppressKeyPress = True
                    LoadValuePOSPayments()
                    POSPayment.ShowDialog()
                Else
                    noProductMsg.Show()
                End If

        ElseIf e.KeyCode = Keys.F1 Then
            If newTransaction.Show() = DialogResult.OK Then
                Me.Close()
                POSPayment.Close()

                AdminHome.OpenChildForm(New FrmSalesTransaction(), AdminHome.panelParent, "Sales Transaction", "shoppingCart")
            Else
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F12 Then
            InsertPOSDetails(txtInvoiceNo.Text, Guna2DataGridView1)
        End If

    End Sub

    Private Sub CheckLowStock()
        Dim qty As Integer = 0
        Dim productID = txtProductCode.Text

        If Integer.TryParse(txtAvailableQty.Text, qty) Then
            If qty <= 20 Then
                lowStackWarning.Caption = "Low Stock Warning"
                lowStackWarning.Text = "⚠️ Stock is running low!" & vbCrLf &
                   "Remaining Quantity: " & qty & vbCrLf & vbCrLf &
                   "Do you want to notify the Admin?"

                lowStackWarning.Buttons = MessageBoxButtons.YesNo
                lowStackWarning.Icon = MessageBoxIcon.Warning

                If lowStackWarning.Show = DialogResult.Yes Then
                    Try
                        ' 🔹 Use duplicate-safe function
                        checkDuplicateLowStock(productID, qty)

                        MessageBox.Show("Notification saved/updated and will be visible to Admin.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        MessageBox.Show("Failed to save notification: " & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub checkDuplicateLowStock(productID As String, qty As Integer)
        ' 🔹 Check if a notification for this product already exists
        Dim tbl_lowstock = (From t1 In db.tbl_Notifications
                            Where t1.productID = productID
                            Select t1).FirstOrDefault()

        If tbl_lowstock Is Nothing Then
            ' No existing notification → create new
            Dim notif As New tbl_Notification With {
            .productID = productID,
            .quantity = qty,
            .Message = "Low Stock Alert: " & txtItemDesc.Text &
                       " → Remaining Qty: " & qty,
            .CreatedAt = DateTime.Now,
            .Seen = False
        }

            db.tbl_Notifications.InsertOnSubmit(notif)
            db.SubmitChanges()
        Else
            ' If exists → update quantity/message
            tbl_lowstock.quantity = qty
            tbl_lowstock.Message = "Low Stock Alert: " & txtItemDesc.Text &
                               " → Remaining Qty: " & qty
            tbl_lowstock.CreatedAt = DateTime.Now
            tbl_lowstock.Seen = False

            db.SubmitChanges()
        End If
    End Sub






    Public Sub InsertPOSDetails(transactionId As Integer, dgv As DataGridView)
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                db.SP_InsertPOSTransactionDetails(
                transactionId,                                     ' FK TransactionID
                row.Cells(0).Value.ToString(),                     ' ProductID
                row.Cells(1).Value.ToString(),                     ' ProductName
                Convert.ToDecimal(row.Cells(2).Value),             ' Price
                Convert.ToInt32(row.Cells(3).Value),               ' Quantity
                Convert.ToDecimal(row.Cells(4).Value),             ' ExtendPrice
                Convert.ToDecimal(row.Cells(5).Value),             ' Discount
                Convert.ToDecimal(row.Cells(6).Value)              ' Total
            )
            End If
        Next
        db.SubmitChanges()
    End Sub

    Public Sub UpdateProductQuantities(dgv As DataGridView)
        Try
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    Dim productCode As String = row.Cells(0).Value.ToString()
                    Dim soldQty As Integer = Convert.ToInt32(row.Cells(3).Value)

                    Dim product = (From p In db.tbl_products
                                   Where p.ProductCode = productCode
                                   Select p).FirstOrDefault()

                    If product IsNot Nothing Then
                        product.Quantity = product.Quantity - soldQty

                        If product.Quantity < 0 Then
                            product.Quantity = 0
                        End If
                    End If
                End If
            Next

            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Failed to update product quantities: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub Guna2Panel8_Click(sender As Object, e As EventArgs) Handles Guna2Panel8.Click

        If Guna2DataGridView1.Rows.Count > 0 AndAlso
           Not (Guna2DataGridView1.Rows.Count = 1 AndAlso Guna2DataGridView1.Rows(0).IsNewRow) Then

            LoadValuePOSPayments()
            POSPayment.ShowDialog()
        Else
            noProductMsg.Show()
        End If
    End Sub



    Private Sub LoadValuePOSPayments()

        POSPayment.TotalItems = CInt(txtTotalItems.Text)
        POSPayment.vatSales = CDec(txtVatSales.Text)
        POSPayment.vatExemptSales = CDec(txtVatExemptSales.Text)
        POSPayment.totalSales = CDec(txtTotalSales.Text)
        POSPayment.vatAmount = CDec(txtVatAmount.Text)
        POSPayment.createdBy = txtName.Text
        POSPayment.InvoiceID.Text = txtInvoiceNo.Text

    End Sub




#End Region
End Class