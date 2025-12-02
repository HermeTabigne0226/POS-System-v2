

Public Class FrmMedicineInv

    Private Sub FrmMedicineInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicineInventory()

        setDefaultButtons()
        loadMedicine_Unit_Types()
    End Sub
#Disable Warning IDE1006 ' Naming Styles


    Private Sub setDGV()
#Enable Warning IDE1006 ' Naming Styles
        ' Setup DateTimePicker
        txtExprDate.Text = Date.Today.ToString("yyyy-MM-dd")
        txtExprDate.MinDate = New DateTime(DateTime.Today.Year, 1, 1)


        ' Hide ID column
        If DGV_MedicineList.Columns.Contains("ID") Then
            DGV_MedicineList.Columns("ID").Visible = False
        End If

        ' Format Date Added column
        If DGV_MedicineList.Columns.Contains("dateAdded") Then
            DGV_MedicineList.Columns("dateAdded").HeaderText = "Date Added"
            DGV_MedicineList.Columns("dateAdded").DefaultCellStyle.Format = "MM-dd-yyyy"
        End If

        ' Format Expiry Date column
        If DGV_MedicineList.Columns.Contains("Expiry_Date") Then
            DGV_MedicineList.Columns("Expiry_Date").HeaderText = "Expiry Date"
            DGV_MedicineList.Columns("Expiry_Date").DefaultCellStyle.Format = "MM-dd-yyyy"
        End If

    End Sub

    Private Sub LoadMedicine_Unit_Types()

        txtMType.Items.Clear()
        txtMType.Items.Add("")
        txtMType.Items.Add("Type")

        Dim tbl_medicine = From t1 In db.tbl_medicine_types
                           Order By t1.Medicine_Type Ascending
                           Select t1.Medicine_Type

        For Each medType In tbl_medicine
            txtMType.Items.Add(medType)
        Next




        txtMUnit.Items.Clear()
        txtMUnit.Items.Add("")
        txtMUnit.Items.Add("Unit")

        Dim tbl_unit = From t1 In db.tbl_unit_types
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
                            .dateAdded = t1.dateAdded
            }).ToList


            DGV_MedicineList.DataSource = products
            setDGV()
        Catch ex As Exception
            MessageBox.Show("Failed to load medicine inventory: " & ex.Message)
        End Try
    End Sub

    Private Sub saveMedicine()
        Try


            Dim newProduct As New tbl_product With {
                .ProductCode = txtMCode.Text.Trim(),
                .GenericName = txtMName.Text.Trim(),
                .BrandName = txtBrand.Text.Trim(),
                .DrugType = txtMType.Text,
                .Unit = txtMUnit.Text,
                .UnitValue = txtUnitValue.Text,
                .CostPrice = Decimal.Parse(txtPrice.Text),
                .ProfitPercent = txtPercent.Text,
                .SellingPrice = Decimal.Parse(txtSellingPrice.Text),
                .ExpiryDate = txtExprDate.Value.Date,
                .Quantity = Integer.Parse(txtQuantity.Text),
                .dateAdded = DateTime.Now
            }


            db.tbl_products.InsertOnSubmit(newProduct)
            db.SubmitChanges()

            MessageBox.Show("Medicine saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadMedicineInventory()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error saving medicine: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtPercent.Clear()
        txtSellingPrice.Clear()
        txtExprDate.Value = DateTime.Now
        txtQuantity.Text = "0"
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
        ClearBtn.Enabled = False
        saveBtn.Enabled = False
        reloadBtn.Enabled = False


        DeleteBtn.Enabled = True
        UpdateBtn.Enabled = True
        CancelBtn.Enabled = True

    End Sub


    Private Sub setDefaultButtons()
        searchBtn.Enabled = True
        ClearBtn.Enabled = True
        saveBtn.Enabled = True
        reloadBtn.Enabled = True

        DeleteBtn.Enabled = False
        UpdateBtn.Enabled = False
        CancelBtn.Enabled = False
    End Sub


    Private Sub DGV_MedicineList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MedicineList.CellDoubleClick
        setUpdateButtons()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_MedicineList.Rows(e.RowIndex)

            ' Fill the textboxes with row values
            txtMID.Text = row.Cells(0).Value?.ToString()
            txtMCode.Text = row.Cells(1).Value?.ToString()
            txtMName.Text = row.Cells(2).Value?.ToString()
            txtBrand.Text = row.Cells(3).Value?.ToString()
            txtMType.Text = row.Cells(4).Value?.ToString()
            txtMUnit.Text = row.Cells(5).Value?.ToString()
            txtUnitValue.Text = row.Cells(6).Value?.ToString()
            txtPrice.Text = Convert.ToDecimal(row.Cells(7).Value).ToString("N2")
            txtPercent.Text = Convert.ToDecimal(row.Cells(8).Value).ToString("N2")
            txtSellingPrice.Text = Convert.ToDecimal(row.Cells(9).Value).ToString("N2")
            txtExprDate.Value = Convert.ToDateTime(row.Cells(10).Value)
            txtQuantity.Text = row.Cells(11).Value?.ToString()


            'txtReorderLvl.Text = row.Cells(7).Value?.ToString()
            'txtExprDate.Value = Convert.ToDateTime(row.Cells(8).Value)
            'txtPrice.Text = Convert.ToDecimal(row.Cells(9).Value).ToString("N2")
            'TxtSupplier.Text = row.Cells(10).Value?.ToString()

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

#Disable Warning IDE1006 ' Naming Styles
    Private Sub deleteMedicine()
#Enable Warning IDE1006 ' Naming Styles
        Dim medicineId As String = txtMID.Text.Trim()

        Dim medicineToDelete = (From m In db.tbl_medicine_inventories
                                Where m.medicine_id = medicineId
                                Select m).FirstOrDefault()

        If medicineToDelete IsNot Nothing Then
            db.tbl_medicine_inventories.DeleteOnSubmit(medicineToDelete)

            db.SubmitChanges()

            MessageBox.Show("Medicine deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMedicineInventory()
            setDefaultButtons()

        Else
            MessageBox.Show("Medicine ID not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
            Dim ID As String = txtMID.Text.Trim()

            If String.IsNullOrEmpty(ID) Then
                MessageBox.Show("Please enter Medicine Code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim medicine = (From m In db.tbl_products
                            Where m.ProductID = ID
                            Select m).FirstOrDefault()


            If medicine IsNot Nothing Then
                medicine.ProductCode = txtMCode.Text.Trim()
                medicine.GenericName = txtMName.Text.Trim()
                medicine.BrandName = txtBrand.Text.Trim()
                medicine.DrugType = txtMType.Text
                medicine.Unit = txtMUnit.Text
                medicine.UnitValue = txtUnitValue.Text
                medicine.CostPrice = Decimal.Parse(txtPrice.Text)
                medicine.ProfitPercent = txtPercent.Text
                medicine.SellingPrice = Decimal.Parse(txtSellingPrice.Text)
                medicine.ExpiryDate = txtExprDate.Value.Date
                medicine.Quantity = Integer.Parse(txtQuantity.Text)

                db.SubmitChanges()
                MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMedicineInventory()
            Else
                MessageBox.Show("Medicine code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As FormatException
            MessageBox.Show("Please enter valid numeric values for Quantity, Reorder Level, and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                            .dateAdded = t1.dateAdded
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
                            .dateAdded = t1.dateAdded
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
                            .dateAdded = t1.dateAdded
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
                            .dateAdded = t1.dateAdded
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
                            .dateAdded = t1.dateAdded
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
    Private Sub txtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercent.KeyPress
#Enable Warning IDE1006 ' Naming Styles
        ' Allow control keys (backspace, delete, etc.)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow digits
        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso Not txtPercent.Text.Contains(".") Then
            Return
        End If

        ' If none of the above, block input
        e.Handled = True
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtPercent_Leave(sender As Object, e As EventArgs) Handles txtPercent.Leave, txtPrice.Leave
#Enable Warning IDE1006 ' Naming Styles
        Dim costPrice As Decimal
        Dim percent As Decimal

        If Decimal.TryParse(txtPrice.Text, costPrice) AndAlso Decimal.TryParse(txtPercent.Text, percent) Then
            txtSellingPrice.Text = (costPrice + (costPrice * percent / 100)).ToString("0.00")
        Else
            txtSellingPrice.Text = "0.00"
        End If
    End Sub
End Class
