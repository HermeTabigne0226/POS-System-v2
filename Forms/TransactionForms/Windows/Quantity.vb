Public Class Quantity

    Public Property InitialQuantity As Decimal
    Public Property SelectedQuantity As Decimal

    Private Sub Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQty.Text = InitialQuantity.ToString("0.##")
        txtQty.SelectAll()
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Dim qty As Decimal

            If Decimal.TryParse(txtQty.Text, qty) AndAlso qty > 0 Then
                SelectedQuantity = qty
                Me.DialogResult = DialogResult.OK   ' ⭐ THIS RETURNS DATA
                Me.Close()
            Else
                MessageBox.Show("Invalid quantity", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtQty.SelectAll()
            End If
        End If

    End Sub

End Class
