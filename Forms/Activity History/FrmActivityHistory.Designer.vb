<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActivityHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActivityHistory))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.History_Logs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nametxt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ActivityHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Record_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComputerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_ActivityHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(14, 737)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 15
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel4.Location = New System.Drawing.Point(20, 12)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1193, 713)
        Me.Guna2Panel4.TabIndex = 16
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.TabControl1)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(8, 9)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1182, 697)
        Me.Guna2Panel3.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1182, 697)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV_ActivityHistory)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1174, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Activity History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'History_Logs
        '
        Me.History_Logs.HeaderText = "Logs"
        Me.History_Logs.Name = "History_Logs"
        Me.History_Logs.ReadOnly = True
        '
        'TxtTime
        '
        Me.TxtTime.HeaderText = "Time"
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.ReadOnly = True
        '
        'txtDate
        '
        Me.txtDate.HeaderText = "Date"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        '
        'nametxt
        '
        Me.nametxt.HeaderText = "Fullname"
        Me.nametxt.Name = "nametxt"
        Me.nametxt.ReadOnly = True
        '
        'userID
        '
        Me.userID.HeaderText = "User ID"
        Me.userID.Name = "userID"
        Me.userID.ReadOnly = True
        '
        'DGV_ActivityHistory
        '
        Me.DGV_ActivityHistory.AllowUserToAddRows = False
        Me.DGV_ActivityHistory.AllowUserToDeleteRows = False
        Me.DGV_ActivityHistory.AllowUserToOrderColumns = True
        Me.DGV_ActivityHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ActivityHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ActivityHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_ActivityHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ActivityHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ActivityHistory.ColumnHeadersHeight = 50
        Me.DGV_ActivityHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_ActivityHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.ActionType, Me.ModuleName, Me.Record_ID, Me.Description, Me.OldValue, Me.NewValue, Me.PerformedBy, Me.UserRole, Me.IPAddress, Me.ComputerName, Me.ActionDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ActivityHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ActivityHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ActivityHistory.Location = New System.Drawing.Point(3, 6)
        Me.DGV_ActivityHistory.Name = "DGV_ActivityHistory"
        Me.DGV_ActivityHistory.ReadOnly = True
        Me.DGV_ActivityHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ActivityHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ActivityHistory.RowHeadersVisible = False
        Me.DGV_ActivityHistory.RowTemplate.Height = 35
        Me.DGV_ActivityHistory.Size = New System.Drawing.Size(1168, 655)
        Me.DGV_ActivityHistory.TabIndex = 7
        Me.DGV_ActivityHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ActivityHistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ActivityHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_ActivityHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ActivityHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_ActivityHistory.ThemeStyle.HeaderStyle.Height = 50
        Me.DGV_ActivityHistory.ThemeStyle.ReadOnly = True
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.Height = 35
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ActivityHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'ActionType
        '
        Me.ActionType.HeaderText = "Action Type"
        Me.ActionType.Name = "ActionType"
        Me.ActionType.ReadOnly = True
        '
        'ModuleName
        '
        Me.ModuleName.HeaderText = "Module"
        Me.ModuleName.Name = "ModuleName"
        Me.ModuleName.ReadOnly = True
        '
        'Record_ID
        '
        Me.Record_ID.HeaderText = "Record ID"
        Me.Record_ID.Name = "Record_ID"
        Me.Record_ID.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'OldValue
        '
        Me.OldValue.HeaderText = "Old Value"
        Me.OldValue.Name = "OldValue"
        Me.OldValue.ReadOnly = True
        '
        'NewValue
        '
        Me.NewValue.HeaderText = "New Value"
        Me.NewValue.Name = "NewValue"
        Me.NewValue.ReadOnly = True
        '
        'PerformedBy
        '
        Me.PerformedBy.HeaderText = "User"
        Me.PerformedBy.Name = "PerformedBy"
        Me.PerformedBy.ReadOnly = True
        '
        'UserRole
        '
        Me.UserRole.HeaderText = "Role"
        Me.UserRole.Name = "UserRole"
        Me.UserRole.ReadOnly = True
        '
        'IPAddress
        '
        Me.IPAddress.HeaderText = "IP Address"
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.ReadOnly = True
        '
        'ComputerName
        '
        Me.ComputerName.HeaderText = "Computer"
        Me.ComputerName.Name = "ComputerName"
        Me.ComputerName.ReadOnly = True
        '
        'ActionDate
        '
        Me.ActionDate.HeaderText = "Date"
        Me.ActionDate.Name = "ActionDate"
        Me.ActionDate.ReadOnly = True
        '
        'FrmActivityHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 737)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmActivityHistory"
        Me.Text = "FrmActivityHistory"
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV_ActivityHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGV_ActivityHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents History_Logs As DataGridViewTextBoxColumn
    Friend WithEvents TxtTime As DataGridViewTextBoxColumn
    Friend WithEvents txtDate As DataGridViewTextBoxColumn
    Friend WithEvents nametxt As DataGridViewTextBoxColumn
    Friend WithEvents userID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents ActionType As DataGridViewTextBoxColumn
    Friend WithEvents ModuleName As DataGridViewTextBoxColumn
    Friend WithEvents Record_ID As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents OldValue As DataGridViewTextBoxColumn
    Friend WithEvents NewValue As DataGridViewTextBoxColumn
    Friend WithEvents PerformedBy As DataGridViewTextBoxColumn
    Friend WithEvents UserRole As DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As DataGridViewTextBoxColumn
    Friend WithEvents ComputerName As DataGridViewTextBoxColumn
    Friend WithEvents ActionDate As DataGridViewTextBoxColumn
End Class
