Public Class AdminHome
    Public username As String
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Screen.PrimaryScreen.WorkingArea

        OpenChildForm(New FrmDashboard(), panelParent, "Dashboard", "house")
        dateLabel.Text = DateTime.Now.ToString("MM-dd-yyyy")
        timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Timer1.Interval = 1000 ' 1 second
        Timer1.Start()

        ActivityLog("Logged In")


        ApplyUserRole(Guna2HtmlLabel1.Text)

        Guna2NotificationPaint1.TargetControl = LowStockBtn
        Guna2NotificationPaint1.Location = New Point(LowStockBtn.Width - 15, 5)
        Guna2NotificationPaint1.Text = "5" ' Example count
        NotificationBroadCast()

    End Sub

    Private Sub ApplyUserRole(role As String)

        If role = "CASHIER" Then
            'CASHIER ACCESS
            dashboardBtn.Parent = Guna2TabControl1
            salesTransactionBtn.Parent = Guna2TabControl1
            customerRecordsBtn.Parent = Guna2TabControl1


            'CASHIER RESTRICTED
            medicineInventoryBtn.Parent = Nothing
            salesHistoryButton.Parent = Nothing
            logsBtn.Parent = Nothing
            expiryMonitorButton.Parent = Nothing
            LowStockBtn.Parent = Nothing
            UserAccountsBtn.Parent = Nothing
            SettingsBtn.Parent = Nothing

        ElseIf role = "ADMIN" Then

            'ADMIN ACCESS ALL
            salesTransactionBtn.Parent = Guna2TabControl1
            medicineInventoryBtn.Parent = Guna2TabControl1
            logsBtn.Parent = Guna2TabControl1
            UserAccountsBtn.Parent = Guna2TabControl1
            SettingsBtn.Parent = Guna2TabControl1
            salesHistoryButton.Parent = Guna2TabControl1
            LowStockBtn.Parent = Guna2TabControl1


            customerRecordsBtn.Parent = Nothing
            expiryMonitorButton.Parent = Nothing
            dashboardBtn.Parent = Guna2TabControl1

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateLabel.Text = DateTime.Now.ToString("MM-dd-yyyy")
        timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub


#Region "Method"


    Private Sub ActivityLog(history As String)

        Dim logs As New tbl_account_log With {
            .user_id = txtUserID.Text,
            .[date] = DateTime.Now.ToString("yyyy-MM-dd"),
            .time = DateTime.Now.ToString("hh:mm:ss tt"),
            .history_log = history
            }

        Try
            db.tbl_account_logs.InsertOnSubmit(logs)
            db.SubmitChanges()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

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
        TxtFormLabel.Text = formLabel

        iconPicture.Image = CType(My.Resources.ResourceManager.GetObject(Image), Image)

    End Sub

    Private Sub Guna2TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2TabControl1.SelectedIndexChanged
        If Guna2TabControl1.SelectedTab Is dashboardBtn Then
            OpenChildForm(New FrmDashboard(), panelParent, "Dashboard", "house")
        ElseIf Guna2TabControl1.SelectedTab Is medicineInventoryBtn Then
            OpenChildForm(New FrmMedicineInv(), panelParent, "Medicine Inventory", "drugs")
        ElseIf Guna2TabControl1.SelectedTab Is salesTransactionBtn Then
            OpenChildForm(New FrmSalesTransaction(), panelParent, "Sales Transaction", "shoppingCart")
        ElseIf Guna2TabControl1.SelectedTab Is customerRecordsBtn Then
            OpenChildForm(New FrmCustomerRecord(), panelParent, "Customer Records", "checklist")
        ElseIf Guna2TabControl1.SelectedTab Is salesHistoryButton Then
            OpenChildForm(New FrmSalesHistory(), panelParent, "Sales History", "clipboard")
        ElseIf Guna2TabControl1.SelectedTab Is logsBtn Then
            OpenChildForm(New FrmActivityHistory(), panelParent, "Activity History", "activity-log")
        ElseIf Guna2TabControl1.SelectedTab Is expiryMonitorButton Then
            OpenChildForm(New FrmExpiry(), panelParent, "Expiry Monitory", "expired")
        ElseIf Guna2TabControl1.SelectedTab Is LowStockBtn Then
            OpenChildForm(New FrmLowStock(), panelParent, "Low Stock Monitor", "checklist")
        ElseIf Guna2TabControl1.SelectedTab Is UserAccountsBtn Then
            OpenChildForm(New FrmUserAccounts(), panelParent, "User Accounts", "profile")
        ElseIf Guna2TabControl1.SelectedTab Is SettingsBtn Then
            OpenChildForm(New FrmSettings(), panelParent, "Settings", "settings2")
        End If

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseHover
        Guna2CirclePictureBox1.BackColor = Color.White
    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseLeave
        Guna2CirclePictureBox1.BackColor = Color.Transparent

    End Sub



#Disable Warning IDE1006 ' Naming Styles
    Private Sub logoutBtn_MouseHover(sender As Object, e As EventArgs) Handles logoutBtn.MouseHover
#Enable Warning IDE1006 ' Naming Styles
        logoutBtn.BackColor = Color.FromArgb(243, 130, 132)

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub logoutBtn_MouseLeave(sender As Object, e As EventArgs) Handles logoutBtn.MouseLeave
#Enable Warning IDE1006 ' Naming Styles
        logoutBtn.BackColor = Color.White

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim f As New Functions()
        If ConfirmLogout.Show = DialogResult.Yes Then

            ActivityLog("Logged Out")
            Login.Show()


            f.InsertAuditTrail(
                "LOGOUT",
                "Authentication",
                Nothing,                              ' RecordID
                "User logged Out successfully",        ' Description
                Nothing,                              ' OldValue
                Nothing,                              ' NewValue
                username.Trim(),              ' CurrentUserName
                Guna2HtmlLabel1.Text        ' CurrentUserRole
            )


            Me.Close()

        Else
            Exit Sub
        End If
    End Sub

    Private Sub NotificationTimer_Tick(sender As Object, e As EventArgs) Handles NotificationTimer.Tick
        NotificationBroadCast()
    End Sub

    Private Sub NotificationBroadCast()
        Try
            Dim notif = (From n In db.tbl_Notifications
                         Where n.Seen = False AndAlso n.user_id <> txtUserID.Text
                         Order By n.ID Ascending
                         Select n).FirstOrDefault()

            If notif IsNot Nothing Then
                NotifyIcon1.BalloonTipTitle = "System Notification"
                NotifyIcon1.BalloonTipText = notif.Message
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(5000)

                notif.Seen = True
                db.SubmitChanges()
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to check notifications: " & ex.Message)
        End Try
    End Sub


#End Region
End Class