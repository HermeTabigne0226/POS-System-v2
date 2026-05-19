

Public Class FrmMedicineInv

    Private Sub FrmMedicineInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicineInventory()

        setDefaultButtons()
        loadMedicine_Unit_Types()
    End Sub
#Disable Warning IDE1006 ' Naming Styles


    Private Sub setDGV()

        If DGV_MedicineList.Columns.Contains("ID") Then
            DGV_MedicineList.Columns("ID").Visible = False
        End If

        With DGV_MedicineList.Columns
            .Item("Medicine_Code").HeaderText = "Mcode"
            .Item("Medicine_Name").HeaderText = "Medicine Name"
            .Item("Brand_Name").HeaderText = "Brand Name"
            .Item("Medicine_Type").HeaderText = "Type"
            .Item("Unit").HeaderText = "Unit"
            .Item("Unit_Value").HeaderText = "Unit Value"
            .Item("Cost_Price").HeaderText = "Cost Price"
            .Item("Profit_Percent").HeaderText = "Profit Percent"
            .Item("Selling_Price").HeaderText = "Selling Price"
            .Item("Expiry_Date").HeaderText = "Expiry Date"
            .Item("Quantity").HeaderText = "Quantity"
            .Item("dateAdded").HeaderText = "Date Added"
            .Item("LowStockQty").HeaderText = "Low Stock Qty"
        End With

        DGV_MedicineList.Columns("Expiry_Date").DefaultCellStyle.Format = "MM-dd-yyyy"
        DGV_MedicineList.Columns("dateAdded").DefaultCellStyle.Format = "MM-dd-yyyy"

    End Sub

    Private Sub LoadMedicine_Unit_Types()

        txtMType.Items.Clear()
        txtMType.Items.Add("")
        txtMType.Items.Add("Type")

        Dim tbl_medicine = From t1 In db.tbl_medicine_types
                           Where t1.Status = "Active"
                           Order By t1.Medicine_Type Ascending
                           Select t1.Medicine_Type

        For Each medType In tbl_medicine
            txtMType.Items.Add(medType)
        Next




        txtMUnit.Items.Clear()
        txtMUnit.Items.Add("")
        txtMUnit.Items.Add("Unit")

        Dim tbl_unit = From t1 In db.tbl_unit_types
                       Where t1.Status = "Active"
                       Order By t1.Unit_Name Ascending
                       Select t1.Unit_Name


        For Each UnitName In tbl_unit
            txtMUnit.Items.Add(UnitName)
        Next

        txtMType.SelectedIndex = 1
        txtMUnit.SelectedIndex = 1

    End Sub
    Private Sub LoadMedicineInventory()

        DGV_MedicineList.DataSource = Nothing

        Try
            Dim products = (From t1 In db.tbl_products
                            Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            .Quantity = t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


            DGV_MedicineList.DataSource = products
            setDGV()
        Catch ex As Exception
            MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
        End Try
    End Sub

    Private Sub saveMedicine()
        Try
            ' -------------------------------
            ' VALIDATE & PARSE SAFELY
            ' -------------------------------
            Dim costPrice As Decimal
            Dim sellingPrice As Decimal
            Dim profitPercent As Decimal
            Dim quantity As Integer
            Dim lowStockQty As Integer

            If Not Decimal.TryParse(txtPrice.Text, costPrice) Then
                MessageBox.Show("Invalid cost price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtSellingPrice.Text, sellingPrice) Then
                MessageBox.Show("Invalid selling price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtProfit.Text, profitPercent) Then
                MessageBox.Show("Invalid profit percent.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MessageBox.Show("Invalid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not Integer.TryParse(txtLowStockQty.Text, lowStockQty) Then
                MessageBox.Show("Invalid low stock quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' -------------------------------
            ' CREATE ENTITY
            ' -------------------------------
            Dim newProduct As New tbl_product With {
                .ProductCode = txtMCode.Text.Trim(),
                .GenericName = txtMName.Text.Trim(),
                .BrandName = txtBrand.Text.Trim(),
                .DrugType = txtMType.Text.Trim(),
                .Unit = txtMUnit.Text.Trim(),
                .UnitValue = txtUnitValue.Text.Trim(),
                .CostPrice = costPrice,
                .ProfitPercent = profitPercent,
                .SellingPrice = sellingPrice,
                .ExpiryDate = txtExprDate.Value.Date,
                .Quantity = quantity,
                .LowStockQty = lowStockQty,
                .dateAdded = DateTime.Now
            }

            ' -------------------------------
            ' SAVE TO DB
            ' -------------------------------
            db.tbl_products.InsertOnSubmit(newProduct)
            db.SubmitChanges()

            MessageBox.Show("Medicine saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            LoadMedicineInventory()
            ClearFields()

            ' -------------------------------
            ' AUDIT TRAIL (ONLY ON SUCCESS)
            ' -------------------------------
            Dim f As New Functions()
            f.InsertAuditTrail(
                "INSERT",
                "Medicine",
                newProduct.ProductCode,
                $"Added new medicine: {newProduct.BrandName} ({newProduct.GenericName})",
                Nothing,
                Nothing,
                AdminHome.username.Trim(),
                AdminHome.Guna2HtmlLabel1.Text
            )

        Catch ex As Exception
            MessageBox.Show("Error saving medicine: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ClearFields()
        txtMCode.Clear()
        txtMName.Clear()
        txtBrand.Clear()
        txtMType.SelectedIndex = 1
        txtMUnit.SelectedIndex = 1
        txtUnitValue.Clear()
        txtPrice.Text = ""
        txtProfit.Clear()
        txtSellingPrice.Clear()
        txtExprDate.Value = DateTime.Now
        txtQuantity.Text = "0"
        txtLowStockQty.Text = "0"
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveMedicine()
    End Sub

    Private Sub TxtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        If txtPrice.Text.Trim() <> "" Then
            Dim value As Decimal
            If Decimal.TryParse(txtPrice.Text, value) Then
                txtPrice.Text = value.ToString("N2") ' Format with 2 decimals
            Else
                txtPrice.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress

        ' Allow control keys (backspace, delete, etc.)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If
        ' Allow digits
        If Char.IsDigit(e.KeyChar) Then
            Return
        End If
        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso Not txtPrice.Text.Contains(".") Then
            Return
        End If
        ' If none of the above, block input
        e.Handled = True
    End Sub


    Private Sub setUpdateButtons()

        searchBtn.Enabled = False
        'ClearBtn.Enabled = False
        'saveBtn.Enabled = False
        'reloadBtn.Enabled = False


        'DeleteBtn.Enabled = True
        'UpdateBtn.Enabled = True
        'CancelBtn.Enabled = True



        UDC_Panel.Visible = True
        SCR_Panel.Visible = False

    End Sub


    Private Sub setDefaultButtons()
        searchBtn.Enabled = True
        'ClearBtn.Enabled = True
        'saveBtn.Enabled = True
        'reloadBtn.Enabled = True

        'DeleteBtn.Enabled = False
        'UpdateBtn.Enabled = False
        'CancelBtn.Enabled = False


        UDC_Panel.Visible = False
        SCR_Panel.Visible = True

    End Sub


    Private Sub DGV_MedicineList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MedicineList.CellDoubleClick
        setUpdateButtons()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_MedicineList.Rows(e.RowIndex)

            txtMID.Text = row.Cells(0).Value?.ToString()
            txtMCode.Text = row.Cells(1).Value?.ToString()
            txtMName.Text = row.Cells(2).Value?.ToString()
            txtBrand.Text = row.Cells(3).Value?.ToString()
            txtMType.Text = row.Cells(4).Value?.ToString()
            txtMUnit.Text = row.Cells(5).Value?.ToString()
            txtUnitValue.Text = row.Cells(6).Value?.ToString()
            txtPrice.Text = Convert.ToDecimal(row.Cells(7).Value).ToString("N2")
            txtProfit.Text = Convert.ToDecimal(row.Cells(8).Value).ToString("N2")
            txtSellingPrice.Text = Convert.ToDecimal(row.Cells(9).Value).ToString("N2")

            Dim expDate As DateTime = Convert.ToDateTime(row.Cells(10).Value)
            txtExprDate.Value = If(expDate < txtExprDate.MinDate, txtExprDate.MinDate, expDate)

            txtQuantity.Text = row.Cells(11).Value?.ToString()
            txtLowStockQty.Text = row.Cells(13).Value?.ToString()
        End If

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearFields()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        setDefaultButtons()
        ClearFields()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        If confirmDelete.Show = DialogResult.Yes Then
            deleteMedicine()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub DeleteMedicine()
        Try
            ' -------------------------------
            ' VALIDATE ID
            ' -------------------------------
            Dim medicineId As Integer
            If Not Integer.TryParse(txtMID.Text.Trim(), medicineId) Then
                MessageBox.Show("Invalid Medicine ID.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' -------------------------------
            ' FETCH MEDICINE
            ' -------------------------------
            Dim medicineToDelete = (From m In db.tbl_products
                                    Where m.ProductID = medicineId
                                    Select m).FirstOrDefault()

            If medicineToDelete Is Nothing Then
                MessageBox.Show("Medicine not found.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' -------------------------------
            ' CONFIRM DELETE (RECOMMENDED)
            ' -------------------------------
            If MessageBox.Show($"Are you sure you want to delete '{medicineToDelete.BrandName}'?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) <> DialogResult.Yes Then
                Exit Sub
            End If

            ' -------------------------------
            ' CAPTURE OLD VALUES (AUDIT)
            ' -------------------------------
            Dim oldValue As String =
            $"Code={medicineToDelete.ProductCode}, " &
            $"Name={medicineToDelete.BrandName}, " &
            $"Generic={medicineToDelete.GenericName}, " &
            $"Qty={medicineToDelete.Quantity}, " &
            $"Price={medicineToDelete.SellingPrice}"

            ' -------------------------------
            ' DELETE
            ' -------------------------------
            db.tbl_products.DeleteOnSubmit(medicineToDelete)
            db.SubmitChanges()

            MessageBox.Show("Medicine deleted successfully.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            LoadMedicineInventory()
            setDefaultButtons()

            ' -------------------------------
            ' AUDIT TRAIL (SUCCESS ONLY)
            ' -------------------------------
            Dim f As New Functions()
            f.InsertAuditTrail(
            "DELETE",
            "Medicine",
            medicineToDelete.ProductCode,
            $"Deleted medicine: {medicineToDelete.BrandName}",
            oldValue,
            Nothing,
            AdminHome.username.Trim(),
            AdminHome.Guna2HtmlLabel1.Text
        )

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If confirmUpdate.Show = DialogResult.Yes Then
            UpdateMedicine()
        Else
            Exit Sub
        End If
    End Sub


    Private Sub UpdateMedicine()
        Try
            ' -------------------------------
            ' VALIDATE ID
            ' -------------------------------
            Dim ID As Integer
            If Not Integer.TryParse(txtMID.Text.Trim(), ID) Then
                MessageBox.Show("Invalid Medicine ID.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' -------------------------------
            ' FETCH MEDICINE
            ' -------------------------------
            Dim medicine = (From m In db.tbl_products
                            Where m.ProductID = ID
                            Select m).FirstOrDefault()

            If medicine Is Nothing Then
                MessageBox.Show("Medicine not found.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                Exit Sub
            End If

            ' -------------------------------
            ' CAPTURE OLD VALUES (AUDIT)
            ' -------------------------------
            Dim oldValue As String =
            $"Code={medicine.ProductCode}, " &
            $"Name={medicine.BrandName}, " &
            $"Generic={medicine.GenericName}, " &
            $"Cost={medicine.CostPrice}, " &
            $"Price={medicine.SellingPrice}, " &
            $"Qty={medicine.Quantity}"

            ' -------------------------------
            ' SAFE PARSING
            ' -------------------------------
            Dim costPrice As Decimal
            Dim sellingPrice As Decimal
            Dim profitPercent As Decimal
            Dim quantity As Integer
            Dim lowStockQty As Integer

            If Not Decimal.TryParse(txtPrice.Text, costPrice) OrElse
           Not Decimal.TryParse(txtSellingPrice.Text, sellingPrice) OrElse
           Not Decimal.TryParse(txtProfit.Text, profitPercent) OrElse
           Not Integer.TryParse(txtQuantity.Text, quantity) OrElse
           Not Integer.TryParse(txtLowStockQty.Text, lowStockQty) Then

                MessageBox.Show("Please enter valid numeric values.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' -------------------------------
            ' UPDATE FIELDS
            ' -------------------------------
            medicine.ProductCode = txtMCode.Text.Trim()
            medicine.GenericName = txtMName.Text.Trim()
            medicine.BrandName = txtBrand.Text.Trim()
            medicine.DrugType = txtMType.Text.Trim()
            medicine.Unit = txtMUnit.Text.Trim()
            medicine.UnitValue = txtUnitValue.Text.Trim()
            medicine.CostPrice = costPrice
            medicine.ProfitPercent = profitPercent
            medicine.SellingPrice = sellingPrice
            medicine.ExpiryDate = txtExprDate.Value.Date
            medicine.Quantity = quantity
            medicine.LowStockQty = lowStockQty

            ' -------------------------------
            ' SAVE CHANGES
            ' -------------------------------
            db.SubmitChanges()

            MessageBox.Show("Medicine updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            LoadMedicineInventory()

            ' -------------------------------
            ' AUDIT TRAIL (SUCCESS ONLY)
            ' -------------------------------
            Dim newValue As String =
            $"Code={medicine.ProductCode}, " &
            $"Name={medicine.BrandName}, " &
            $"Generic={medicine.GenericName}, " &
            $"Cost={medicine.CostPrice}, " &
            $"Price={medicine.SellingPrice}, " &
            $"Qty={medicine.Quantity}"

            Dim f As New Functions()
            f.InsertAuditTrail(
            "UPDATE",
            "Medicine",
            medicine.ProductCode,
            $"Updated medicine: {medicine.BrandName}",
            oldValue,
            newValue,
            AdminHome.username.Trim(),
            AdminHome.Guna2HtmlLabel1.Text
        )

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        searchMedicine()
    End Sub
    Private Sub SearchText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchText.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Prevents the "ding" sound when pressing Enter
            searchMedicine()
        End If

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub searchMedicine()
#Enable Warning IDE1006 ' Naming Styles
        Dim txtsearch = searchText.Text
        If searchType.SelectedIndex = 2 Then

            DGV_MedicineList.DataSource = Nothing

            Try
                Dim products = (From t1 In db.tbl_products
                                Where txtsearch = "" Or t1.ProductCode.Contains(txtsearch)
                                Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


                DGV_MedicineList.DataSource = products
                setDGV()
            Catch ex As Exception
                MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
            End Try




        ElseIf searchType.SelectedIndex = 3 Then

            Try
                Dim products = (From t1 In db.tbl_products
                                Where txtsearch = "" Or t1.GenericName.Contains(txtsearch)
                                Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


                DGV_MedicineList.DataSource = products
                setDGV()
            Catch ex As Exception
                MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
            End Try


        ElseIf searchType.SelectedIndex = 4 Then
            Try
                Dim products = (From t1 In db.tbl_products
                                Where txtsearch = "" Or t1.BrandName.Contains(txtsearch)
                                Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


                DGV_MedicineList.DataSource = products
                setDGV()
            Catch ex As Exception
                MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
            End Try


        ElseIf searchType.SelectedIndex = 5 Then

            Try
                Dim products = (From t1 In db.tbl_products
                                Where txtsearch = "" Or t1.DrugType.Contains(txtsearch)
                                Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


                DGV_MedicineList.DataSource = products
                setDGV()
            Catch ex As Exception
                MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
            End Try



        ElseIf searchType.SelectedIndex = 6 Then
            Try
                Dim products = (From t1 In db.tbl_products
                                Where txtsearch = "" Or t1.Unit.Contains(txtsearch)
                                Select New With {
                            .ID = t1.ProductID,
                            .Medicine_Code = t1.ProductCode,
                            .Medicine_Name = t1.GenericName,
                            .Brand_Name = t1.BrandName,
                            .Medicine_Type = t1.DrugType,
                            t1.Unit,
                            .Unit_Value = t1.UnitValue,
                            .Cost_Price = t1.CostPrice,
                            .Profit_Percent = t1.ProfitPercent,
                            .Selling_Price = t1.SellingPrice,
                            .Expiry_Date = t1.ExpiryDate,
                            t1.Quantity,
                            .dateAdded = t1.dateAdded,
                            .LowStockQty = t1.LowStockQty
            }).ToList


                DGV_MedicineList.DataSource = products
                setDGV()
            Catch ex As Exception
                MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
            End Try

        Else
            LoadMedicineInventory()
            setDefaultButtons()
        End If
    End Sub

    Private Sub ReloadBtn_Click(sender As Object, e As EventArgs) Handles reloadBtn.Click
        LoadMedicineInventory()
        setDefaultButtons()

        searchType.SelectedIndex = 1
        searchText.Clear()

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProfit.KeyPress
#Enable Warning IDE1006 ' Naming Styles
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not txtProfit.Text.Contains(".") Then
            Return
        End If

        e.Handled = True
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtPercent_Leave(sender As Object, e As EventArgs) Handles txtProfit.Leave, txtPrice.Leave
#Enable Warning IDE1006 ' Naming Styles
        Dim costPrice As Decimal
        Dim profit As Decimal

        If Decimal.TryParse(txtPrice.Text, costPrice) AndAlso Decimal.TryParse(txtProfit.Text, profit) Then
            txtSellingPrice.Text = (costPrice + profit).ToString("0.00")
        Else
            txtSellingPrice.Text = "0.00"
        End If
    End Sub

End Class
