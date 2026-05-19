Imports System.Data.SqlClient

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

        txtUsername.Focus()
        Guna2Panel3.Location = New Point(829, 414)

        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipTitle = "POS System"
        NotifyIcon1.BalloonTipText = "You have successfully logged in."
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.ShowBalloonTip(5000)
    End Sub

    Private isPasswordVisible As Boolean = False

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        isPasswordVisible = Not isPasswordVisible

        If isPasswordVisible Then
            txtPassword.UseSystemPasswordChar = False
            Guna2CirclePictureBox2.Image = My.Resources.eye ' 👁 show password icon
        Else
            txtPassword.UseSystemPasswordChar = True
            Guna2CirclePictureBox2.Image = My.Resources.hide ' 🙈 hide password icon
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Login()
    End Sub


    Private Sub Login()
        Dim f As New Functions()
        Dim isLoggedIn = f.Login(txtUsername.Text.Trim(), txtPassword.Text)



        If isLoggedIn Then
            LoginSuccess.Show()
            AdminHome.Show()
            AdminHome.username = txtUsername.Text

            f.InsertAuditTrail(
                "LOGIN",
                "Authentication",
                Nothing,                              ' RecordID
                "User logged in successfully",        ' Description
                Nothing,                              ' OldValue
                Nothing,                              ' NewValue
                txtUsername.Text.Trim(),              ' CurrentUserName
                AdminHome.Guna2HtmlLabel1.Text        ' CurrentUserRole
            )


            Me.Close()
        Else
            InvalidAccount.Show()
        End If
    End Sub



    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click
        SetDatabase.ShowDialog()

    End Sub


    Private isAtLocation1 As Boolean = False
    Private targetLocation As Point
    Private WithEvents SlideTimer As New Timer With {.Interval = 10}

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If isAtLocation1 Then
            targetLocation = New Point(829, 414)
            PictureBox1.Image = My.Resources.left_arrow
        Else
            targetLocation = New Point(781, 414)
            PictureBox1.Image = My.Resources.right_arrow
        End If

        slideTimer.Start()
    End Sub

    Private Sub SlideTimer_Tick(sender As Object, e As EventArgs) Handles SlideTimer.Tick
        Dim stepSize As Integer = 5
        Dim dx As Integer = targetLocation.X - Guna2Panel3.Location.X
        Dim dy As Integer = targetLocation.Y - Guna2Panel3.Location.Y

        If Math.Abs(dx) <= stepSize AndAlso Math.Abs(dy) <= stepSize Then
            Guna2Panel3.Location = targetLocation
            SlideTimer.Stop()
            isAtLocation1 = Not isAtLocation1
        Else
            ' Move panel step by step
            Dim newX As Integer = Guna2Panel3.Location.X + Math.Sign(dx) * stepSize
            Dim newY As Integer = Guna2Panel3.Location.Y + Math.Sign(dy) * stepSize
            Guna2Panel3.Location = New Point(newX, newY)
        End If
    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If ConfirmExit.Show = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
