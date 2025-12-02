Public Class FrmSettings




    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicineType()

        setForSave()
        dataGridviewSEtup()



        loadUnitTypes()
    End Sub



    Private Sub LoadMedicineType()
        DGV_MedicineType.Rows.Clear()

        Dim tbl_medicine = From t1 In db.tbl_medicine_types
                           Order By t1.ID Ascending
                           Select t1.ID, t1.Medicine_Type, t1.Status, t1.dateCreated, t1.UpdatedOn

        For Each medList In tbl_medicine
            Dim formattedDate1 As String
            Dim formattedDate2 As String

            If medList.dateCreated IsNot Nothing Then
                formattedDate1 = Format(CDate(medList.dateCreated), "MMMM dd, yyyy - hh:mm:ss tt")
            Else
                formattedDate1 = ""
            End If

            If medList.UpdatedOn IsNot Nothing Then
                formattedDate2 = Format(CDate(medList.UpdatedOn), "MMMM dd, yyyy - hh:mm:ss tt")
            Else
                formattedDate2 = ""
            End If

            DGV_MedicineType.Rows.Add(medList.ID, medList.Medicine_Type, medList.Status, formattedDate1, formattedDate2)
        Next

    End Sub

    Private Sub LoadUnitTypes()

        dgv_UNIT.Rows.Clear()

        Dim tbl_unit = From t1 In db.tbl_unit_types
                       Order By t1.ID Ascending
                       Select t1.ID, t1.Unit_Name, t1.Status, t1.dateCreated, t1.UpdatedOn

        For Each units In tbl_unit
            Dim formattedDate1 As String
            Dim formattedDate2 As String

            If units.dateCreated IsNot Nothing Then
                formattedDate1 = Format(CDate(units.dateCreated), "MMMM dd, yyyy - hh:mm:ss tt")
            Else
                formattedDate1 = ""
            End If

            If units.UpdatedOn IsNot Nothing Then
                formattedDate2 = Format(CDate(units.UpdatedOn), "MMMM dd, yyyy - hh:mm:ss tt")
            Else
                formattedDate2 = ""
            End If

            dgv_UNIT.Rows.Add(units.ID, units.Unit_Name, units.Status, formattedDate1, formattedDate2)
        Next

    End Sub



    Private Sub DataGridviewSEtup()
        DGV_MedicineType.Columns(0).Width = 100
        DGV_MedicineType.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_MedicineType.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_MedicineType.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV_MedicineType.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



        dgv_UNIT.Columns(0).Width = 100
        dgv_UNIT.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv_UNIT.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv_UNIT.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgv_UNIT.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub LoadLatestTransactionID()

        Dim latest = (From t In db.tbl_medicine_types
                      Order By t.ID Descending
                      Select t.ID).FirstOrDefault()

        If latest > 0 Then
            txtID.Text = (latest + 1)
        Else
            txtID.Text = "1"
        End If

        Dim latest2 = (From t In db.tbl_unit_types
                       Order By t.ID Descending
                       Select t.ID).FirstOrDefault()

        If latest2 > 0 Then
            txtUnitID.Text = (latest2 + 1)
        Else
            txtUnitID.Text = "1"
        End If


    End Sub

    Private Sub DGV_MedicineType_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MedicineType.CellDoubleClick
        setForUpdate()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_MedicineType.Rows(e.RowIndex)

            txtID.Text = row.Cells(0).Value.ToString()
            txtMName.Text = row.Cells(1).Value.ToString()
            txtStatus.Text = row.Cells(2).Value.ToString()
        End If
    End Sub


    Private Sub SetForSave()
        saveBtn.Enabled = True
        UpdateBtn.Enabled = False
        CancelBtn.Enabled = False
        LoadLatestTransactionID()
    End Sub


    Private Sub SetForUpdate()
        saveBtn.Enabled = False
        UpdateBtn.Enabled = True
        CancelBtn.Enabled = True

    End Sub



    Private Sub SetForSave2()
        txtSaveUnitBtn.Enabled = True
        txtUpdateUnitBtn.Enabled = False
        txtCancelUnitBtn.Enabled = False
        LoadLatestTransactionID()
    End Sub


    Private Sub SetForUpdate2()
        txtSaveUnitBtn.Enabled = False
        txtUpdateUnitBtn.Enabled = True
        txtCancelUnitBtn.Enabled = True

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        setForSave()
        DGV_MedicineType.ClearSelection()

        txtMName.Clear()
        txtStatus.SelectedIndex = 0
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If confirmUpdate.Show = DialogResult.OK Then
            Try
                ' Find the record by ID
                Dim medType = (From t In db.tbl_medicine_types
                               Where t.ID = txtID.Text
                               Select t).FirstOrDefault()

                If medType IsNot Nothing Then
                    ' Update fields
                    medType.Medicine_Type = txtMName.Text
                    medType.Status = txtStatus.Text
                    medType.UpdatedOn = DateTime.Now
                    ' Save changes
                    db.SubmitChanges()

                    successUpdate.Show()

                    setForSave()
                    loadMedicineType()
                Else
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If confirmSave.Show = DialogResult.OK Then
            Try
                ' Create a new record
                Dim newMedType As New tbl_medicine_type With {
                    .Medicine_Type = txtMName.Text,
                    .Status = txtStatus.Text,
                    .dateCreated = DateTime.Today
                }

                ' Insert into database
                db.tbl_medicine_types.InsertOnSubmit(newMedType)
                db.SubmitChanges()

                SuccessSave.Show()

                setForSave()
                loadMedicineType()

            Catch ex As Exception
                MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtSaveUnitBtn_Click(sender As Object, e As EventArgs) Handles txtSaveUnitBtn.Click
        If confirmSave.Show = DialogResult.OK Then
            Try
                ' Create a new record
                Dim newUnits As New tbl_unit_type With {
                    .Unit_Name = txtUnitName.Text,
                    .Status = txtStatus.Text,
                    .dateCreated = DateTime.Today
                }

                ' Insert into database
                db.tbl_unit_types.InsertOnSubmit(newUnits)
                db.SubmitChanges()

                SuccessSave.Show()

                setForSave2()
                loadUnitTypes()

            Catch ex As Exception
                MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtUpdateUnitBtn_Click(sender As Object, e As EventArgs) Handles txtUpdateUnitBtn.Click

        If confirmUpdate.Show = DialogResult.OK Then
            Try
                ' Find the record by ID
                Dim units = (From t In db.tbl_unit_types
                             Where t.ID = txtUnitID.Text
                             Select t).FirstOrDefault()

                If units IsNot Nothing Then
                    ' Update fields
                    units.Unit_Name = txtUnitName.Text
                    units.Status = txtStatusUnit.Text
                    units.UpdatedOn = DateTime.Now
                    ' Save changes
                    db.SubmitChanges()

                    successUpdate.Show()

                    setForSave2()
                    loadUnitTypes()
                Else
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtCancelUnitBtn_Click(sender As Object, e As EventArgs) Handles txtCancelUnitBtn.Click
        setForSave2()
        dgv_UNIT.ClearSelection()

        txtUnitName.Clear()
        txtStatusUnit.SelectedIndex = 0
    End Sub

    Private Sub Dgv_UNIT_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UNIT.CellDoubleClick
        setForUpdate2()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_UNIT.Rows(e.RowIndex)

            txtUnitID.Text = row.Cells(0).Value.ToString()
            txtUnitName.Text = row.Cells(1).Value.ToString()
            txtStatusUnit.Text = row.Cells(2).Value.ToString()
        End If
    End Sub
End Class