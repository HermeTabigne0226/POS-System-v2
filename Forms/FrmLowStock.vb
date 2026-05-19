Public Class FrmLowStock

    Private Sub FrmLowStock_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadNotifications()

    End Sub

    Private Sub LoadNotifications()

        Dim tbl_notif = (
            From t1 In db.tbl_Notifications
            Select New With {
                .Code = t1.productID,
                .Message = t1.Message,
                .Quantity = t1.quantity,
                .TimeCreated = t1.CreatedAt
            }
        ).ToList()

        DGV_Notification.DataSource = tbl_notif

    End Sub
    Public Sub OpenChildForm(childForm As Form, parentPanel As Panel, formLabel As String, Image As String)
        parentPanel.Controls.Clear() ' Remove existing controls
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        parentPanel.Controls.Add(childForm)
        parentPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        AdminHome.TxtFormLabel.Text = formLabel

        AdminHome.iconPicture.Image = CType(My.Resources.ResourceManager.GetObject(Image), Image)

    End Sub

    ' ✅ DOUBLE CLICK → OPEN INVENTORY
    Private Sub DGV_Notification_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles DGV_Notification.CellDoubleClick

        OpenChildForm(New FrmMedicineInv(), AdminHome.panelParent, "Medicine Inventory", "drugs")
    End Sub







End Class
