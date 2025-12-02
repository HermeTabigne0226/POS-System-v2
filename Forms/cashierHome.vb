Public Class CashierHome
    Private Sub CashierHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New FrmDashboard(), panelParent)
    End Sub










#Region "Method"
    Private Sub OpenChildForm(childForm As Form, parentPanel As Panel)
        parentPanel.Controls.Clear() ' Remove existing controls
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        parentPanel.Controls.Add(childForm)
        parentPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Guna2TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2TabControl1.SelectedIndexChanged
        If Guna2TabControl1.SelectedTab Is dashboardBtn Then
            OpenChildForm(New FrmDashboard(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is InventoryBtn Then
            OpenChildForm(New FrmInventory(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is POSBtn Then
            OpenChildForm(New FrmPOS(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is PurchaseBtn Then
            OpenChildForm(New FrmPurchase(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is CustomersBtn Then
            OpenChildForm(New FrmCustomers(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is SalesHistoryBtn Then
            OpenChildForm(New frmSalesHistory(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is ReportsBtn Then
            OpenChildForm(New FrmReports(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is SuppliersBtn Then
            OpenChildForm(New FrmSuppliers(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is ExpiryMonitorBtn Then
            OpenChildForm(New FrmExpiry(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is UserAccountsBtn Then
            OpenChildForm(New FrmUserAccounts(), panelParent)
        ElseIf Guna2TabControl1.SelectedTab Is SettingsBtn Then
            OpenChildForm(New FrmSettings(), panelParent)
        End If
    End Sub

#End Region
End Class