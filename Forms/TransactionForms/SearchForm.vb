Public Class SearchForm

    ' 🔥 This holds the ACTUAL open Sales form
    Public Property SalesForm As FrmSalesTransaction

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedecine()
    End Sub

    Private Sub LoadMedecine()

        DGV_ProductList.DataSource = Nothing

        Dim searchText As String = TxtSearch.Text.Trim()

        Dim tbl_medicine = (
            From t1 In db.tbl_products
            Where t1.BrandName.Contains(searchText) _
               Or t1.GenericName.Contains(searchText)
            Select New With {
                .MCode = t1.ProductCode,
                .BrandName = t1.BrandName,
                .GenericName = t1.GenericName,
                .DrugType = t1.DrugType,
                .Unit = t1.Unit,
                .UnitValue = t1.UnitValue,
                .Quantity = t1.Quantity
            }
        ).ToList()

        DGV_ProductList.DataSource = tbl_medicine

    End Sub

    Private Sub TxtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles TxtSearch.TextChanged

        LoadMedecine()

    End Sub

    ' ✅ DOUBLE CLICK → SEND MCODE
    Private Sub DGV_ProductList_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles DGV_ProductList.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = DGV_ProductList.Rows(e.RowIndex)
        Dim mcode As String = row.Cells("MCode").Value.ToString()

        ' 🔥 USE PASSED INSTANCE
        If SalesForm IsNot Nothing Then
            With SalesForm.txtProductCode   ' ComboBox
                .Text = mcode     ' ✅ CORRECT
                .Focus()
            End With
        End If

        Me.Close()

    End Sub


End Class
