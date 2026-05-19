<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSalesTransaction
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtProductCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAvailableQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtInvoiceNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPosition = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtTotalAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtVatAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotalSales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtVatExemptSales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtVatSales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalItems = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confirmRemove = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.warningDuplicate = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.noProductMsg = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.newTransaction = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.lowStackWarning = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ErrorQty = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel10.SuspendLayout()
        Me.Guna2Panel11.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox6)
        Me.Guna2Panel1.Controls.Add(Me.txtProductCode)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtAvailableQty)
        Me.Guna2Panel1.Controls.Add(Me.txtItemDesc)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel1.Location = New System.Drawing.Point(14, 107)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(975, 77)
        Me.Guna2Panel1.TabIndex = 1
        '
        'txtProductCode
        '
        Me.txtProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProductCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtProductCode.FormattingEnabled = True
        Me.txtProductCode.Location = New System.Drawing.Point(16, 33)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(107, 29)
        Me.txtProductCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(431, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Avail. Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Item Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Code"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAvailableQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAvailableQty.DefaultText = ""
        Me.txtAvailableQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAvailableQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAvailableQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAvailableQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAvailableQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAvailableQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAvailableQty.Location = New System.Drawing.Point(434, 34)
        Me.txtAvailableQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAvailableQty.PlaceholderText = ""
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.SelectedText = ""
        Me.txtAvailableQty.Size = New System.Drawing.Size(63, 28)
        Me.txtAvailableQty.TabIndex = 0
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemDesc.DefaultText = ""
        Me.txtItemDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtItemDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemDesc.Location = New System.Drawing.Point(141, 34)
        Me.txtItemDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemDesc.PlaceholderText = "Item Description"
        Me.txtItemDesc.ReadOnly = True
        Me.txtItemDesc.SelectedText = ""
        Me.txtItemDesc.Size = New System.Drawing.Size(277, 28)
        Me.txtItemDesc.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 190)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(975, 704)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 35
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.availQty, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 28
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(959, 687)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'availQty
        '
        Me.availQty.HeaderText = "Avail. Qty"
        Me.availQty.Name = "availQty"
        Me.availQty.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Extend Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Discount Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.txtInvoiceNo)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel3.Location = New System.Drawing.Point(995, 107)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(324, 77)
        Me.Guna2Panel3.TabIndex = 2
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.AutoSize = True
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.White
        Me.txtInvoiceNo.Location = New System.Drawing.Point(151, 24)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(97, 30)
        Me.txtInvoiceNo.TabIndex = 1
        Me.txtInvoiceNo.Text = "1000000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Invoice No :"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.txtName)
        Me.Guna2Panel4.Controls.Add(Me.txtPosition)
        Me.Guna2Panel4.Controls.Add(Me.Label8)
        Me.Guna2Panel4.Controls.Add(Me.Label7)
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel4.Location = New System.Drawing.Point(996, 190)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(324, 141)
        Me.Guna2Panel4.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.Gray
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = "Name"
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(99, 84)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(211, 24)
        Me.txtName.TabIndex = 2
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPosition
        '
        Me.txtPosition.BorderColor = System.Drawing.Color.Gray
        Me.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPosition.DefaultText = "Position"
        Me.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPosition.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPosition.Location = New System.Drawing.Point(99, 54)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosition.PlaceholderText = ""
        Me.txtPosition.SelectedText = ""
        Me.txtPosition.Size = New System.Drawing.Size(211, 24)
        Me.txtPosition.TabIndex = 2
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Position :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Staff Information"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.txtTotalAmount)
        Me.Guna2Panel5.Controls.Add(Me.txtVatAmount)
        Me.Guna2Panel5.Controls.Add(Me.txtTotalSales)
        Me.Guna2Panel5.Controls.Add(Me.txtVatExemptSales)
        Me.Guna2Panel5.Controls.Add(Me.Label21)
        Me.Guna2Panel5.Controls.Add(Me.txtVatSales)
        Me.Guna2Panel5.Controls.Add(Me.Label20)
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Controls.Add(Me.Label13)
        Me.Guna2Panel5.Controls.Add(Me.txtTotalItems)
        Me.Guna2Panel5.Controls.Add(Me.Label9)
        Me.Guna2Panel5.Controls.Add(Me.Label10)
        Me.Guna2Panel5.Controls.Add(Me.Label11)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel5.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel5.Location = New System.Drawing.Point(996, 337)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(324, 266)
        Me.Guna2Panel5.TabIndex = 2
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount.BorderColor = System.Drawing.Color.Gray
        Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmount.DefaultText = "132.00"
        Me.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Location = New System.Drawing.Point(124, 214)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalAmount.PlaceholderText = ""
        Me.txtTotalAmount.SelectedText = ""
        Me.txtTotalAmount.Size = New System.Drawing.Size(186, 37)
        Me.txtTotalAmount.TabIndex = 2
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatAmount
        '
        Me.txtVatAmount.BorderColor = System.Drawing.Color.Gray
        Me.txtVatAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVatAmount.DefaultText = "116.00"
        Me.txtVatAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVatAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVatAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtVatAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtVatAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatAmount.Location = New System.Drawing.Point(157, 178)
        Me.txtVatAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVatAmount.PlaceholderText = ""
        Me.txtVatAmount.SelectedText = ""
        Me.txtVatAmount.Size = New System.Drawing.Size(154, 24)
        Me.txtVatAmount.TabIndex = 2
        Me.txtVatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BorderColor = System.Drawing.Color.Gray
        Me.txtTotalSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalSales.DefaultText = "116.00"
        Me.txtTotalSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalSales.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTotalSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalSales.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalSales.Location = New System.Drawing.Point(156, 146)
        Me.txtTotalSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalSales.PlaceholderText = ""
        Me.txtTotalSales.SelectedText = ""
        Me.txtTotalSales.Size = New System.Drawing.Size(154, 24)
        Me.txtTotalSales.TabIndex = 2
        Me.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatExemptSales
        '
        Me.txtVatExemptSales.BorderColor = System.Drawing.Color.Gray
        Me.txtVatExemptSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVatExemptSales.DefaultText = "116.00"
        Me.txtVatExemptSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVatExemptSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVatExemptSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatExemptSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatExemptSales.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtVatExemptSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatExemptSales.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatExemptSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtVatExemptSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatExemptSales.Location = New System.Drawing.Point(156, 114)
        Me.txtVatExemptSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVatExemptSales.Name = "txtVatExemptSales"
        Me.txtVatExemptSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVatExemptSales.PlaceholderText = ""
        Me.txtVatExemptSales.SelectedText = ""
        Me.txtVatExemptSales.Size = New System.Drawing.Size(154, 24)
        Me.txtVatExemptSales.TabIndex = 2
        Me.txtVatExemptSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(16, 184)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Vat Amount:"
        '
        'txtVatSales
        '
        Me.txtVatSales.BorderColor = System.Drawing.Color.Gray
        Me.txtVatSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVatSales.DefaultText = "116.00"
        Me.txtVatSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVatSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVatSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVatSales.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtVatSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatSales.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtVatSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVatSales.Location = New System.Drawing.Point(156, 84)
        Me.txtVatSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVatSales.Name = "txtVatSales"
        Me.txtVatSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVatSales.PlaceholderText = ""
        Me.txtVatSales.SelectedText = ""
        Me.txtVatSales.Size = New System.Drawing.Size(154, 24)
        Me.txtVatSales.TabIndex = 2
        Me.txtVatSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(15, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Total Sales:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(15, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Amount:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(15, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Vat-Exempt Sales:"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.BorderColor = System.Drawing.Color.Gray
        Me.txtTotalItems.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalItems.DefaultText = "1000"
        Me.txtTotalItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalItems.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTotalItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalItems.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalItems.Location = New System.Drawing.Point(156, 54)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalItems.PlaceholderText = ""
        Me.txtTotalItems.SelectedText = ""
        Me.txtTotalItems.Size = New System.Drawing.Size(154, 24)
        Me.txtTotalItems.TabIndex = 2
        Me.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Vat Sales:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Items:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount Information"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel6.BackColor = System.Drawing.Color.White
        Me.Guna2Panel6.Controls.Add(Me.Guna2PictureBox5)
        Me.Guna2Panel6.Controls.Add(Me.Label19)
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel6.Location = New System.Drawing.Point(995, 608)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel6.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(124, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(195, 28)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "New Transaction [F1] "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel7.BackColor = System.Drawing.Color.White
        Me.Guna2Panel7.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2Panel7.Controls.Add(Me.Label18)
        Me.Guna2Panel7.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel7.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel7.Location = New System.Drawing.Point(995, 655)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel7.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(124, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(195, 28)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Remove Item [F2] "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel8.BackColor = System.Drawing.Color.White
        Me.Guna2Panel8.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel8.Controls.Add(Me.Label17)
        Me.Guna2Panel8.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel8.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel8.Location = New System.Drawing.Point(996, 702)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel8.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(124, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(195, 28)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Settle Payment [F3] "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel9.BackColor = System.Drawing.Color.White
        Me.Guna2Panel9.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel9.Controls.Add(Me.Label16)
        Me.Guna2Panel9.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel9.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel9.Location = New System.Drawing.Point(995, 749)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel9.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(124, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(195, 28)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Enter Quantity [F6] "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel10.BackColor = System.Drawing.Color.White
        Me.Guna2Panel10.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel10.Controls.Add(Me.Label15)
        Me.Guna2Panel10.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel10.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel10.Location = New System.Drawing.Point(996, 796)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel10.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(124, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(195, 28)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Search Product [F7] "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel11.BackColor = System.Drawing.Color.White
        Me.Guna2Panel11.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel11.Controls.Add(Me.Label14)
        Me.Guna2Panel11.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel11.CustomBorderThickness = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel11.Location = New System.Drawing.Point(996, 843)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.Size = New System.Drawing.Size(324, 41)
        Me.Guna2Panel11.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(124, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 28)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Close [F8] "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.Size = New System.Drawing.Size(14, 894)
        Me.Guna2Panel12.TabIndex = 0
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(14, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1306, 101)
        Me.Guna2CustomGradientPanel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1287, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pharmacy Point of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'confirmRemove
        '
        Me.confirmRemove.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel
        Me.confirmRemove.Caption = "Remove Item"
        Me.confirmRemove.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        Me.confirmRemove.Parent = Nothing
        Me.confirmRemove.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.confirmRemove.Text = "Click Ok to Proceed."
        '
        'warningDuplicate
        '
        Me.warningDuplicate.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.warningDuplicate.Caption = "Duplicate Item"
        Me.warningDuplicate.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Me.warningDuplicate.Parent = Nothing
        Me.warningDuplicate.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.warningDuplicate.Text = "Duplicate item detected. You can edit the quantity instead."
        '
        'noProductMsg
        '
        Me.noProductMsg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.noProductMsg.Caption = "Point of Sale"
        Me.noProductMsg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Me.noProductMsg.Parent = Nothing
        Me.noProductMsg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.noProductMsg.Text = "No products or items in the transaction."
        '
        'newTransaction
        '
        Me.newTransaction.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel
        Me.newTransaction.Caption = "New Transaction"
        Me.newTransaction.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        Me.newTransaction.Parent = Nothing
        Me.newTransaction.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.newTransaction.Text = "Click Okay To Proceed"
        '
        'lowStackWarning
        '
        Me.lowStackWarning.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        Me.lowStackWarning.Caption = "Low Stocks"
        Me.lowStackWarning.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Me.lowStackWarning.Parent = Nothing
        Me.lowStackWarning.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.lowStackWarning.Text = "The I"
        '
        'ErrorQty
        '
        Me.ErrorQty.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.ErrorQty.Caption = Nothing
        Me.ErrorQty.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.ErrorQty.Parent = Nothing
        Me.ErrorQty.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.ErrorQty.Text = Nothing
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.POS_System.My.Resources.Resources.inspection1
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(17, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.POS_System.My.Resources.Resources.switch
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(17, 6)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.POS_System.My.Resources.Resources.count
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(17, 6)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 2
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.POS_System.My.Resources.Resources.peso1
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(16, 6)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 2
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = Global.POS_System.My.Resources.Resources.remove__1_
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(17, 6)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 2
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = Global.POS_System.My.Resources.Resources.exchange
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(17, 6)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 2
        Me.Guna2PictureBox5.TabStop = False
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox6.Image = Global.POS_System.My.Resources.Resources.plus
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(503, 34)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(29, 26)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 1
        Me.Guna2PictureBox6.TabStop = False
        '
        'FrmSalesTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 894)
        Me.Controls.Add(Me.Guna2Panel10)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2Panel12)
        Me.Controls.Add(Me.Guna2Panel11)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSalesTransaction"
        Me.Text = "Point Of Sale"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel11.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtInvoiceNo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPosition As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTotalAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtVatExemptSales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtVatSales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalItems As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtProductCode As ComboBox
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents confirmRemove As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents warningDuplicate As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents txtVatAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotalSales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents noProductMsg As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents newTransaction As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAvailableQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lowStackWarning As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents availQty As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ErrorQty As Guna.UI2.WinForms.Guna2MessageDialog
End Class
