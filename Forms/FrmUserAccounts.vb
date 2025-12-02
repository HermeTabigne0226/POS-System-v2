Public Class FrmUserAccounts

    Private Sub FrmUserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDetails()

        LoadAccounts()
        DatagridviewSetProperties()
    End Sub
    Private Sub DGV_userAccounts_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DGV_userAccounts.RowPrePaint
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

        If row.Cells(7).Value IsNot Nothing Then
            Dim status As String = row.Cells(7).Value.ToString().Trim().ToLower()

            If status = "in-active" Then
                ' For In-Active row
                ' Simulate disabled look for In-Active rows
                row.DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230)    ' Light gray
                row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 150, 150)    ' Medium gray
                row.Cells(7).Style.ForeColor = Color.FromArgb(255, 99, 99)
                row.Cells(7).Style.Font = New Font(dgv.Font, FontStyle.Italic)



            ElseIf status = "active" Then
                ' Green bold text only for the Status cell
                row.Cells(7).Style.ForeColor = Color.Green
                row.Cells(7).Style.Font = New Font(dgv.Font, FontStyle.Bold)
            End If
        End If
    End Sub

    Private Sub DatagridviewSetProperties()
        DGV_userAccounts.RowTemplate.Height = 80
        DGV_userAccounts.Columns("Image").Width = 80
        DGV_userAccounts.Columns(0).Visible = False

        DGV_userAccounts.Columns("AccountType").HeaderText = "Account Type"
        DGV_userAccounts.Columns("Status").HeaderText = "Account Status"

        DGV_userAccounts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        DGV_userAccounts.Columns(1).DefaultCellStyle.Padding = New Padding(10, 10, 10, 10)


    End Sub


    Public Sub LoadAccounts()
        Dim tbl_users = (From t1 In db.tbl_users
                         Select New With {
                     .UserID = t1.user_id,
            .Image = If(t1.image IsNot Nothing, t1.image.ToArray(), Nothing),
                     .Fullname = t1.fullname,
                     .Username = t1.username,
                     .Password = t1.password,
                     .Contact = t1.contact,
                     .AccountType = t1.account_type,
                     .Status = t1.account_status
                 }).ToList()



        DGV_userAccounts.DataSource = tbl_users

        ' Convert byte array to Image for display
        For Each row As DataGridViewRow In DGV_userAccounts.Rows
            If row.Cells("Image").Value IsNot Nothing Then
                Dim bytes As Byte() = CType(row.Cells("Image").Value, Byte())
                Using ms As New IO.MemoryStream(bytes)
                    row.Cells("Image").Value = Image.FromStream(ms)
                End Using

            Else
                row.Cells("Image").Value = My.Resources.user21
            End If
        Next

        ' Format DataGridView for image display
        If DGV_userAccounts.Columns.Contains("Image") Then

            ' Set ImageLayout correctly
            Dim imageCol As DataGridViewImageColumn = TryCast(DGV_userAccounts.Columns("Image"), DataGridViewImageColumn)
            If imageCol IsNot Nothing Then
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            End If
        End If





    End Sub


    Private Sub DGV_userAccounts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_userAccounts.CellFormatting
        If DGV_userAccounts.Columns(e.ColumnIndex).Name = "Image" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is Byte() Then
                Dim bytes As Byte() = DirectCast(e.Value, Byte())
                Using ms As New IO.MemoryStream(bytes)
                    e.Value = Image.FromStream(ms)
                End Using
            End If
        End If
    End Sub
    Private Sub SetEditForm()
        txtFullname.Focus()
        UserAccountLabel.Text = "Edit User Account"
        AddUserBtn.Visible = False
        detailsPanel.Enabled = True
        deleteBtn.Visible = True
        SaveBtn.Text = "Update"
    End Sub

    Private Sub SetAddForm()
        txtFullname.Focus()
        UserAccountLabel.Text = "Add User Account"
        AddUserBtn.Visible = True
        detailsPanel.Enabled = True
        deleteBtn.Visible = False
        SaveBtn.Text = "Save"
    End Sub

    Private Sub DGV_userAccounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_userAccounts.CellDoubleClick
        SetEditForm()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_userAccounts.Rows(e.RowIndex)

            UserIDTxt.Text = row.Cells("UserID").Value?.ToString()
            txtFullname.Text = row.Cells("Fullname").Value?.ToString()
            txtUsername.Text = row.Cells("Username").Value?.ToString()
            txtPassword.Text = row.Cells("Password").Value?.ToString()
            txtContact.Text = row.Cells("Contact").Value?.ToString()
            txtAccountType.Text = row.Cells("AccountType").Value?.ToString()
            txtAccountStatus.Text = row.Cells("Status").Value?.ToString()

            ' ✅ This works because your LINQ query already does .ToArray()
            If row.Cells("Image").Value IsNot Nothing AndAlso TypeOf row.Cells("Image").Value Is Byte() Then
                Dim bytes As Byte() = CType(row.Cells("Image").Value, Byte())
                Using ms As New IO.MemoryStream(bytes)
                    userImage.Image = Image.FromStream(ms)
                End Using
            Else
                userImage.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        'If createAccountBtn.Text = "Create" Then
        '    ' First click: Enable form
        '    detailsPanel.Enabled = True
        '    createAccountBtn.Text = "Save"
        'ElseIf createAccountBtn.Text = "Save" Then
        '    ' Second click: Save logic goes here
        '    InsertUserAccounts()
        '    MessageBox.Show("Account saved successfully!")

        '    ' Reset the form after saving\
        '    detailsPanel.Enabled = False
        '    createAccountBtn.Text = "Create"
        '    ClearDetails()
        '    LoadAccounts()
        'End If
    End Sub


    Private Sub ClearDetails()
        txtFullname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtContact.Clear()
        txtAccountType.SelectedIndex = 1
        txtAccountStatus.SelectedIndex = 1
        userImage.Image = My.Resources.user21
        detailsPanel.Enabled = False
        deleteBtn.Visible = False
        AddUserBtn.Visible = True
        UserAccountLabel.Text = "Add User Account"
        SaveBtn.Text = "Save"
    End Sub



    Private Sub InsertUserAccounts()

        If (txtAccountStatus.SelectedIndex < 2) Then
            MsgBox("Please select a valid Account Status.", MsgBoxStyle.Exclamation)
            txtAccountStatus.Focus()
            Exit Sub
        ElseIf (txtAccountType.SelectedIndex < 2) Then
            MsgBox("Please select a valid Account Type.", MsgBoxStyle.Exclamation)
            txtAccountType.Focus()
            Exit Sub

        End If
        Try
            Dim imgData As Byte() = If(userImage.Image IsNot Nothing,
            Function()
                Using ms As New IO.MemoryStream()
                    Using cloneImg As Image = New Bitmap(userImage.Image)
                        cloneImg.Save(ms, Imaging.ImageFormat.Png) ' Use PNG if your image was PNG
                    End Using
                    Return ms.ToArray()
                End Using
            End Function.Invoke(),
            Nothing)

            Dim newUser As New tbl_user With {
            .fullname = txtFullname.Text.Trim(),
            .Username = txtUsername.Text.Trim(),
            .Password = txtPassword.Text.Trim(),
            .contact = txtContact.Text.Trim(),
            .account_type = txtAccountType.Text.Trim(),
            .account_status = txtAccountStatus.Text.Trim(),
            .Image = imgData
        }

            db.tbl_users.InsertOnSubmit(newUser)
            db.SubmitChanges()

            MessageBox.Show("Account saved successfully!")


            ClearDetails()
            LoadAccounts()
        Catch ex As Exception
            MessageBox.Show("Error while saving user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub TxtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged
        FullnameTxt.Text = txtFullname.Text
    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        usernameTxt.Text = txtUsername.Text
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        passwordTxt.Text = txtPassword.Text
    End Sub



    Private Sub TxtAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAccountType.SelectedIndexChanged
        accountTypeTxt.Text = txtAccountType.Text
    End Sub


    Private Sub txtAccountStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAccountStatus.SelectedIndexChanged
        txtLabelStatus.Text = txtAccountStatus.Text
    End Sub
    Private Sub TxtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        ContactTxt.Text = txtContact.Text
    End Sub

    Private Function ConvertToNonTransparent(img As Image) As Image
        Dim bmp As New Bitmap(img.Width, img.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White) ' Use white as the background for transparency
            g.DrawImage(img, 0, 0, img.Width, img.Height)
        End Using
        Return bmp
    End Function


    Private Sub BtnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.Title = "Select Profile Image"

            If ofd.ShowDialog() = DialogResult.OK Then
                ' Load the original image
                Dim originalImage As Image = Image.FromFile(ofd.FileName)

                ' Convert to JPEG with white background (no transparency)
                Dim jpegImage As Image = ConvertToNonTransparent(originalImage)

                ' Assign to PictureBox
                userImage.Image = jpegImage
            End If
        End Using
    End Sub


    Private Sub BtnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        userImage.Image = My.Resources.user
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        SetAddForm()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If SaveBtn.Text = "Save" Then
            InsertUserAccounts()
        ElseIf SaveBtn.Text = "Update" Then
            UpdateUserAccounts()
        End If

    End Sub

    Private Sub UpdateUserAccounts()
        ' Validate dropdown selections
        If txtAccountStatus.SelectedIndex <= 1 Then
            MsgBox("Please select a valid Account Status.", MsgBoxStyle.Exclamation)
            txtAccountStatus.Focus()
            Exit Sub
        ElseIf txtAccountType.SelectedIndex <= 1 Then
            MsgBox("Please select a valid Account Type.", MsgBoxStyle.Exclamation)
            txtAccountType.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(UserIDTxt.Text) Then
            MsgBox("User ID is missing. Cannot update.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            ' Find existing user by ID
            Dim existingUser = (From u In db.tbl_users
                                Where u.user_id = UserIDTxt.Text.Trim()
                                Select u).FirstOrDefault()

            If existingUser Is Nothing Then
                MsgBox("User not found!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            ' Convert image to byte array (optional)
            Dim imgData As Byte() = If(userImage.Image IsNot Nothing,
            Function()
                Using ms As New IO.MemoryStream()
                    Using cloneImg As Image = New Bitmap(userImage.Image)
                        cloneImg.Save(ms, Imaging.ImageFormat.Png)
                    End Using
                    Return ms.ToArray()
                End Using
            End Function.Invoke(),
            Nothing)

            ' Update fields
            existingUser.fullname = txtFullname.Text.Trim()
            existingUser.username = txtUsername.Text.Trim()
            existingUser.password = txtPassword.Text.Trim()
            existingUser.contact = txtContact.Text.Trim()
            existingUser.account_type = txtAccountType.Text.Trim()
            existingUser.account_status = txtAccountStatus.Text.Trim()
            existingUser.image = imgData

            ' Save changes
            db.SubmitChanges()

            MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearDetails()
            LoadAccounts()

        Catch ex As Exception
            MessageBox.Show("Error while updating user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        SetAddForm()
        ClearDetails()
        LoadAccounts()

    End Sub
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If String.IsNullOrWhiteSpace(UserIDTxt.Text) Then
            MsgBox("Please select a user to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.No Then Exit Sub

        Try
            ' Find user by ID
            Dim userToDelete = (From u In db.tbl_users
                                Where u.user_id = UserIDTxt.Text.Trim()
                                Select u).FirstOrDefault()

            If userToDelete Is Nothing Then
                MsgBox("User not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            ' Delete user
            db.tbl_users.DeleteOnSubmit(userToDelete)
            db.SubmitChanges()

            MsgBox("User deleted successfully!", MsgBoxStyle.Information)

            ClearDetails()
            LoadAccounts()

        Catch ex As Exception
            MessageBox.Show("Error while deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
