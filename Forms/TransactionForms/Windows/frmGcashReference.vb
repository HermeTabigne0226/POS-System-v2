Public Class frmGcashReference
    Private Sub txtReference_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReference.KeyDown
        If e.KeyCode = Keys.Enter Then
            POSPayment.GcashRef.Text = txtReference.Text

            ' Optional: prevent ding sound
            e.SuppressKeyPress = True

            Me.Close()

        End If
    End Sub

    Private Sub frmGcashReference_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtReference.Clear()
    End Sub
End Class