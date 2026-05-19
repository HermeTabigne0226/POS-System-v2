<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSalesHistory
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_InvoicePrintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POS_DBDataSet = New POS_System.POS_DBDataSet()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.backBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_SalesHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.printInvoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtTotalAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGcashInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCashInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotalItems = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPageInfo = New System.Windows.Forms.Label()
        Me.BtnNext = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnLastPage = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnPrev = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnFirstPage = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbRows = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtTotalInvoice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SP_InvoicePrintTableAdapter = New POS_System.POS_DBDataSetTableAdapters.SP_InvoicePrintTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GcashRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmDelete = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Me.SP_InvoicePrintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DGV_SalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_InvoicePrintBindingSource
        '
        Me.SP_InvoicePrintBindingSource.DataMember = "SP_InvoicePrint"
        Me.SP_InvoicePrintBindingSource.DataSource = Me.POS_DBDataSet
        '
        'POS_DBDataSet
        '
        Me.POS_DBDataSet.DataSetName = "POS_DBDataSet"
        Me.POS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(14, 894)
        Me.Guna2Panel1.TabIndex = 5
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
        Me.Guna2CustomGradientPanel1.TabIndex = 6
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
        Me.Label1.Text = "Sales History"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.Controls.Add(Me.backBtn)
        Me.Guna2Panel3.Controls.Add(Me.DGV_SalesHistory)
        Me.Guna2Panel3.Controls.Add(Me.printInvoice)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel3.Location = New System.Drawing.Point(14, 190)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(975, 704)
        Me.Guna2Panel3.TabIndex = 8
        '
        'backBtn
        '
        Me.backBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backBtn.Animated = True
        Me.backBtn.AutoRoundedCorners = True
        Me.backBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.backBtn.BorderRadius = 9
        Me.backBtn.BorderThickness = 1
        Me.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.backBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.backBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(906, 11)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(57, 21)
        Me.backBtn.TabIndex = 3
        Me.backBtn.Text = "Back"
        Me.backBtn.Visible = False
        '
        'DGV_SalesHistory
        '
        Me.DGV_SalesHistory.AllowUserToAddRows = False
        Me.DGV_SalesHistory.AllowUserToDeleteRows = False
        Me.DGV_SalesHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_SalesHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_SalesHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_SalesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_SalesHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_SalesHistory.ColumnHeadersHeight = 35
        Me.DGV_SalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_SalesHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.GcashRef, Me.Column7})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_SalesHistory.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_SalesHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_SalesHistory.Location = New System.Drawing.Point(8, 8)
        Me.DGV_SalesHistory.Name = "DGV_SalesHistory"
        Me.DGV_SalesHistory.ReadOnly = True
        Me.DGV_SalesHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_SalesHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_SalesHistory.RowHeadersVisible = False
        Me.DGV_SalesHistory.RowTemplate.Height = 28
        Me.DGV_SalesHistory.Size = New System.Drawing.Size(959, 687)
        Me.DGV_SalesHistory.TabIndex = 0
        Me.DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_SalesHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_SalesHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_SalesHistory.ThemeStyle.HeaderStyle.Height = 35
        Me.DGV_SalesHistory.ThemeStyle.ReadOnly = True
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.Height = 28
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DGV_SalesHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'printInvoice
        '
        Me.printInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "InvoiceDetails"
        ReportDataSource2.Value = Me.SP_InvoicePrintBindingSource
        Me.printInvoice.LocalReport.DataSources.Add(ReportDataSource2)
        Me.printInvoice.LocalReport.ReportEmbeddedResource = "POS_System.Invoice.rdlc"
        Me.printInvoice.Location = New System.Drawing.Point(8, 8)
        Me.printInvoice.Name = "printInvoice"
        Me.printInvoice.ServerReport.BearerToken = Nothing
        Me.printInvoice.Size = New System.Drawing.Size(959, 688)
        Me.printInvoice.TabIndex = 2
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.txtTotalAmount)
        Me.Guna2Panel5.Controls.Add(Me.txtGcashInvoice)
        Me.Guna2Panel5.Controls.Add(Me.txtCashInvoice)
        Me.Guna2Panel5.Controls.Add(Me.txtTotalItems)
        Me.Guna2Panel5.Controls.Add(Me.Label20)
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Controls.Add(Me.Label13)
        Me.Guna2Panel5.Controls.Add(Me.Label9)
        Me.Guna2Panel5.Controls.Add(Me.Label11)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel5.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel5.Location = New System.Drawing.Point(996, 190)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(324, 704)
        Me.Guna2Panel5.TabIndex = 9
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtTotalAmount.Location = New System.Drawing.Point(127, 154)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalAmount.PlaceholderText = ""
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.SelectedText = ""
        Me.txtTotalAmount.Size = New System.Drawing.Size(186, 37)
        Me.txtTotalAmount.TabIndex = 2
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGcashInvoice
        '
        Me.txtGcashInvoice.BorderColor = System.Drawing.Color.Gray
        Me.txtGcashInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGcashInvoice.DefaultText = "116.00"
        Me.txtGcashInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGcashInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGcashInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGcashInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGcashInvoice.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtGcashInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGcashInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGcashInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGcashInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGcashInvoice.Location = New System.Drawing.Point(159, 123)
        Me.txtGcashInvoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGcashInvoice.Name = "txtGcashInvoice"
        Me.txtGcashInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGcashInvoice.PlaceholderText = ""
        Me.txtGcashInvoice.ReadOnly = True
        Me.txtGcashInvoice.SelectedText = ""
        Me.txtGcashInvoice.Size = New System.Drawing.Size(154, 24)
        Me.txtGcashInvoice.TabIndex = 2
        Me.txtGcashInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCashInvoice
        '
        Me.txtCashInvoice.BorderColor = System.Drawing.Color.Gray
        Me.txtCashInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCashInvoice.DefaultText = "116.00"
        Me.txtCashInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCashInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCashInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashInvoice.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtCashInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCashInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashInvoice.Location = New System.Drawing.Point(159, 92)
        Me.txtCashInvoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCashInvoice.Name = "txtCashInvoice"
        Me.txtCashInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCashInvoice.PlaceholderText = ""
        Me.txtCashInvoice.ReadOnly = True
        Me.txtCashInvoice.SelectedText = ""
        Me.txtCashInvoice.Size = New System.Drawing.Size(154, 24)
        Me.txtCashInvoice.TabIndex = 2
        Me.txtCashInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalItems
        '
        Me.txtTotalItems.BorderColor = System.Drawing.Color.Gray
        Me.txtTotalItems.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalItems.DefaultText = "116.00"
        Me.txtTotalItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalItems.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTotalItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalItems.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalItems.Location = New System.Drawing.Point(159, 61)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalItems.PlaceholderText = ""
        Me.txtTotalItems.ReadOnly = True
        Me.txtTotalItems.SelectedText = ""
        Me.txtTotalItems.Size = New System.Drawing.Size(154, 24)
        Me.txtTotalItems.TabIndex = 2
        Me.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(17, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Total GCash Invoice/s :"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 163)
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
        Me.Label13.Location = New System.Drawing.Point(17, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Total Cash Invoice/s :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Items/s :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Sales Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Filter Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From :"
        '
        'FromDate
        '
        Me.FromDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FromDate.CustomFormat = "MMM - dd - yyyy"
        Me.FromDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(61, 37)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(150, 25)
        Me.FromDate.TabIndex = 2
        '
        'ToDate
        '
        Me.ToDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToDate.CustomFormat = "MMM - dd - yyyy"
        Me.ToDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(249, 37)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(150, 25)
        Me.ToDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(217, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "To :"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel6.Controls.Add(Me.lblPageInfo)
        Me.Guna2Panel6.Controls.Add(Me.BtnNext)
        Me.Guna2Panel6.Controls.Add(Me.BtnLastPage)
        Me.Guna2Panel6.Controls.Add(Me.BtnPrev)
        Me.Guna2Panel6.Controls.Add(Me.BtnFirstPage)
        Me.Guna2Panel6.Location = New System.Drawing.Point(738, 38)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(223, 25)
        Me.Guna2Panel6.TabIndex = 5
        '
        'lblPageInfo
        '
        Me.lblPageInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPageInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageInfo.ForeColor = System.Drawing.Color.White
        Me.lblPageInfo.Location = New System.Drawing.Point(48, 0)
        Me.lblPageInfo.Name = "lblPageInfo"
        Me.lblPageInfo.Size = New System.Drawing.Size(127, 25)
        Me.lblPageInfo.TabIndex = 10
        Me.lblPageInfo.Text = "Page 1 of 10"
        Me.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnNext.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNext.HoverState.ImageSize = New System.Drawing.Size(19, 19)
        Me.BtnNext.Image = Global.POS_System.My.Resources.Resources.right_white
        Me.BtnNext.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnNext.ImageRotate = 0!
        Me.BtnNext.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnNext.IndicateFocus = True
        Me.BtnNext.Location = New System.Drawing.Point(175, 0)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnNext.Size = New System.Drawing.Size(24, 25)
        Me.BtnNext.TabIndex = 6
        Me.BtnNext.UseTransparentBackground = True
        '
        'BtnLastPage
        '
        Me.BtnLastPage.BackColor = System.Drawing.Color.Transparent
        Me.BtnLastPage.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnLastPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLastPage.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnLastPage.HoverState.ImageSize = New System.Drawing.Size(19, 19)
        Me.BtnLastPage.Image = Global.POS_System.My.Resources.Resources.forward
        Me.BtnLastPage.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnLastPage.ImageRotate = 0!
        Me.BtnLastPage.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnLastPage.IndicateFocus = True
        Me.BtnLastPage.Location = New System.Drawing.Point(199, 0)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnLastPage.Size = New System.Drawing.Size(24, 25)
        Me.BtnLastPage.TabIndex = 7
        Me.BtnLastPage.UseTransparentBackground = True
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrev.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrev.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPrev.HoverState.ImageSize = New System.Drawing.Size(19, 19)
        Me.BtnPrev.Image = Global.POS_System.My.Resources.Resources.left_white
        Me.BtnPrev.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnPrev.ImageRotate = 0!
        Me.BtnPrev.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPrev.IndicateFocus = True
        Me.BtnPrev.Location = New System.Drawing.Point(24, 0)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnPrev.Size = New System.Drawing.Size(24, 25)
        Me.BtnPrev.TabIndex = 5
        Me.BtnPrev.UseTransparentBackground = True
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.BackColor = System.Drawing.Color.Transparent
        Me.BtnFirstPage.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFirstPage.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFirstPage.HoverState.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnFirstPage.Image = Global.POS_System.My.Resources.Resources.back
        Me.BtnFirstPage.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnFirstPage.ImageRotate = 0!
        Me.BtnFirstPage.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnFirstPage.IndicateFocus = True
        Me.BtnFirstPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnFirstPage.Size = New System.Drawing.Size(24, 25)
        Me.BtnFirstPage.TabIndex = 4
        Me.BtnFirstPage.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.cmbRows)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.ToDate)
        Me.Guna2Panel2.Controls.Add(Me.FromDate)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 107)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(975, 77)
        Me.Guna2Panel2.TabIndex = 7
        '
        'cmbRows
        '
        Me.cmbRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRows.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbRows.FormattingEnabled = True
        Me.cmbRows.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbRows.Location = New System.Drawing.Point(684, 37)
        Me.cmbRows.Name = "cmbRows"
        Me.cmbRows.Size = New System.Drawing.Size(48, 25)
        Me.cmbRows.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(630, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Rows"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.txtTotalInvoice)
        Me.Guna2Panel4.Controls.Add(Me.Label5)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(8)
        Me.Guna2Panel4.Location = New System.Drawing.Point(995, 107)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(324, 77)
        Me.Guna2Panel4.TabIndex = 10
        '
        'txtTotalInvoice
        '
        Me.txtTotalInvoice.AutoSize = True
        Me.txtTotalInvoice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalInvoice.ForeColor = System.Drawing.Color.White
        Me.txtTotalInvoice.Location = New System.Drawing.Point(187, 24)
        Me.txtTotalInvoice.Name = "txtTotalInvoice"
        Me.txtTotalInvoice.Size = New System.Drawing.Size(25, 30)
        Me.txtTotalInvoice.TabIndex = 1
        Me.txtTotalInvoice.Text = "0"
        Me.txtTotalInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Invoice/s :"
        '
        'SP_InvoicePrintTableAdapter
        '
        Me.SP_InvoicePrintTableAdapter.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Customer"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Items"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Payment Method"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GcashRef
        '
        Me.GcashRef.HeaderText = "Gcash Ref No"
        Me.GcashRef.Name = "GcashRef"
        Me.GcashRef.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "TransactionID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'ConfirmDelete
        '
        Me.ConfirmDelete.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.ConfirmDelete.Caption = Nothing
        Me.ConfirmDelete.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.ConfirmDelete.Parent = Me
        Me.ConfirmDelete.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.ConfirmDelete.Text = Nothing
        '
        'FrmSalesHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 894)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "FrmSalesHistory"
        Me.Text = "FrmSalesHistory"
        CType(Me.SP_InvoicePrintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.DGV_SalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtGcashInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCashInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotalItems As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FromDate As DateTimePicker
    Friend WithEvents ToDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbRows As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPageInfo As Label
    Friend WithEvents BtnPrev As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnFirstPage As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnNext As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnLastPage As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents txtTotalAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DGV_SalesHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTotalInvoice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SP_InvoicePrintBindingSource As BindingSource
    Friend WithEvents POS_DBDataSet As POS_DBDataSet
    Friend WithEvents SP_InvoicePrintTableAdapter As POS_DBDataSetTableAdapters.SP_InvoicePrintTableAdapter
    Friend WithEvents printInvoice As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents backBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GcashRef As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ConfirmDelete As Guna.UI2.WinForms.Guna2MessageDialog
End Class
