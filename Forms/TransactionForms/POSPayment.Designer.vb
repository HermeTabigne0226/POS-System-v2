<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSPayment))
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.radioCard = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radioCash = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtChangeAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCashReceived = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotalAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.confirmSave = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.negativeWarning = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InvoiceID = New System.Windows.Forms.Label()
        Me.POS_DBDataSet = New POS_System.POS_DBDataSet()
        Me.SP_InvoicePrintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_InvoicePrintTableAdapter = New POS_System.POS_DBDataSetTableAdapters.SP_InvoicePrintTableAdapter()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.POS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_InvoicePrintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.ReportViewer1)
        Me.Guna2Panel5.Controls.Add(Me.InvoiceID)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel5.Controls.Add(Me.radioCard)
        Me.Guna2Panel5.Controls.Add(Me.radioCash)
        Me.Guna2Panel5.Controls.Add(Me.txtChangeAmount)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.Controls.Add(Me.txtCashReceived)
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.Controls.Add(Me.TxtCustomerName)
        Me.Guna2Panel5.Controls.Add(Me.txtTotalAmount)
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.Controls.Add(Me.Label3)
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Controls.Add(Me.Label11)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel5.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(437, 388)
        Me.Guna2Panel5.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Guna2Panel1.Location = New System.Drawing.Point(22, 107)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(402, 10)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(282, 329)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(143, 36)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "Print And Save"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'radioCard
        '
        Me.radioCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioCard.AutoSize = True
        Me.radioCard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radioCard.CheckedState.BorderThickness = 0
        Me.radioCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radioCard.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radioCard.CheckedState.InnerOffset = -4
        Me.radioCard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.radioCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radioCard.Location = New System.Drawing.Point(366, 129)
        Me.radioCard.Name = "radioCard"
        Me.radioCard.Size = New System.Drawing.Size(59, 23)
        Me.radioCard.TabIndex = 3
        Me.radioCard.Text = "Card"
        Me.radioCard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radioCard.UncheckedState.BorderThickness = 2
        Me.radioCard.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radioCard.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radioCash
        '
        Me.radioCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioCash.AutoSize = True
        Me.radioCash.Checked = True
        Me.radioCash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radioCash.CheckedState.BorderThickness = 0
        Me.radioCash.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radioCash.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radioCash.CheckedState.InnerOffset = -4
        Me.radioCash.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.radioCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radioCash.Location = New System.Drawing.Point(282, 129)
        Me.radioCash.Name = "radioCash"
        Me.radioCash.Size = New System.Drawing.Size(58, 23)
        Me.radioCash.TabIndex = 3
        Me.radioCash.TabStop = True
        Me.radioCash.Text = "Cash"
        Me.radioCash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radioCash.UncheckedState.BorderThickness = 2
        Me.radioCash.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radioCash.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtChangeAmount
        '
        Me.txtChangeAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChangeAmount.BorderColor = System.Drawing.Color.Gray
        Me.txtChangeAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChangeAmount.DefaultText = "0.00"
        Me.txtChangeAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChangeAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChangeAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChangeAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChangeAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtChangeAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChangeAmount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtChangeAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChangeAmount.Location = New System.Drawing.Point(225, 273)
        Me.txtChangeAmount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtChangeAmount.Name = "txtChangeAmount"
        Me.txtChangeAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChangeAmount.PlaceholderText = ""
        Me.txtChangeAmount.ReadOnly = True
        Me.txtChangeAmount.SelectedText = ""
        Me.txtChangeAmount.Size = New System.Drawing.Size(200, 37)
        Me.txtChangeAmount.TabIndex = 2
        Me.txtChangeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Change Amount:"
        '
        'txtCashReceived
        '
        Me.txtCashReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCashReceived.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCashReceived.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCashReceived.DefaultText = "0.00"
        Me.txtCashReceived.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCashReceived.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCashReceived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashReceived.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashReceived.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtCashReceived.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashReceived.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCashReceived.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashReceived.Location = New System.Drawing.Point(282, 211)
        Me.txtCashReceived.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCashReceived.Name = "txtCashReceived"
        Me.txtCashReceived.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCashReceived.PlaceholderText = ""
        Me.txtCashReceived.SelectedText = ""
        Me.txtCashReceived.Size = New System.Drawing.Size(143, 35)
        Me.txtCashReceived.TabIndex = 1
        Me.txtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cash Received:"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCustomerName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCustomerName.DefaultText = ""
        Me.TxtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerName.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TxtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerName.Location = New System.Drawing.Point(225, 66)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCustomerName.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtCustomerName.PlaceholderText = "Customer Name"
        Me.TxtCustomerName.SelectedText = ""
        Me.TxtCustomerName.Size = New System.Drawing.Size(199, 31)
        Me.TxtCustomerName.TabIndex = 0
        Me.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount.BorderColor = System.Drawing.Color.Gray
        Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmount.DefaultText = "1,000,000.00"
        Me.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Location = New System.Drawing.Point(282, 164)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalAmount.PlaceholderText = ""
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.SelectedText = ""
        Me.txtTotalAmount.Size = New System.Drawing.Size(143, 31)
        Me.txtTotalAmount.TabIndex = 2
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Payment Method:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(18, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Amount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Payment Information"
        '
        'Guna2MessageDialog1
        '
        Me.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.Guna2MessageDialog1.Caption = Nothing
        Me.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Guna2MessageDialog1.Parent = Nothing
        Me.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.Guna2MessageDialog1.Text = Nothing
        '
        'confirmSave
        '
        Me.confirmSave.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel
        Me.confirmSave.Caption = "Save Transaction"
        Me.confirmSave.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        Me.confirmSave.Parent = Nothing
        Me.confirmSave.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.confirmSave.Text = "Click OK to Proceed."
        '
        'negativeWarning
        '
        Me.negativeWarning.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.negativeWarning.Caption = "Invalid Payment"
        Me.negativeWarning.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Me.negativeWarning.Parent = Nothing
        Me.negativeWarning.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.negativeWarning.Text = "Change amount cannot be negative. Please check the cash received."
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "InvoiceDetails"
        ReportDataSource1.Value = Me.SP_InvoicePrintBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POS_System.Invoice.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(437, 388)
        Me.ReportViewer1.TabIndex = 6
        Me.ReportViewer1.Visible = False
        '
        'InvoiceID
        '
        Me.InvoiceID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InvoiceID.AutoSize = True
        Me.InvoiceID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InvoiceID.Location = New System.Drawing.Point(346, 34)
        Me.InvoiceID.Name = "InvoiceID"
        Me.InvoiceID.Size = New System.Drawing.Size(78, 19)
        Me.InvoiceID.TabIndex = 7
        Me.InvoiceID.Text = "Customer:"
        Me.InvoiceID.Visible = False
        '
        'POS_DBDataSet
        '
        Me.POS_DBDataSet.DataSetName = "POS_DBDataSet"
        Me.POS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_InvoicePrintBindingSource
        '
        Me.SP_InvoicePrintBindingSource.DataMember = "SP_InvoicePrint"
        Me.SP_InvoicePrintBindingSource.DataSource = Me.POS_DBDataSet
        '
        'SP_InvoicePrintTableAdapter
        '
        Me.SP_InvoicePrintTableAdapter.ClearBeforeFill = True
        '
        'POSPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 388)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POSPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POSPayment"
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        CType(Me.POS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_InvoicePrintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTotalAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents radioCard As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radioCash As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtChangeAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCashReceived As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents confirmSave As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents negativeWarning As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InvoiceID As Label
    Friend WithEvents SP_InvoicePrintBindingSource As BindingSource
    Friend WithEvents POS_DBDataSet As POS_DBDataSet
    Friend WithEvents SP_InvoicePrintTableAdapter As POS_DBDataSetTableAdapters.SP_InvoicePrintTableAdapter
End Class
