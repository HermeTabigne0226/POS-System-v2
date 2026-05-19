<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTodaySales = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalItems = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalRevenue = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalVAT = New System.Windows.Forms.Label()
        Me.cboPeriod = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboValue = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblCurrentSales = New System.Windows.Forms.Label()
        Me.lblPreviousSales = New System.Windows.Forms.Label()
        Me.lblComparison = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvTopSales = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvTopSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.GroupBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(294, 211)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.POS_System.My.Resources.Resources.Untitled_design__1__removebg_preview
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.txtTodaySales)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Today Sales"
        '
        'txtTodaySales
        '
        Me.txtTodaySales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTodaySales.Location = New System.Drawing.Point(3, 76)
        Me.txtTodaySales.Name = "txtTodaySales"
        Me.txtTodaySales.Size = New System.Drawing.Size(285, 34)
        Me.txtTodaySales.TabIndex = 1
        Me.txtTodaySales.Text = "₱ 10,000.00"
        Me.txtTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.Controls.Add(Me.GroupBox2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(312, 55)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(294, 211)
        Me.Guna2Panel2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.POS_System.My.Resources.Resources.Untitled_design__1__removebg_preview
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox2.Controls.Add(Me.txtTotalItems)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 211)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Items"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.Location = New System.Drawing.Point(3, 76)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Size = New System.Drawing.Size(285, 34)
        Me.txtTotalItems.TabIndex = 1
        Me.txtTotalItems.Text = "₱ 10,000.00"
        Me.txtTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel3.Controls.Add(Me.GroupBox3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(612, 55)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(294, 211)
        Me.Guna2Panel3.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.POS_System.My.Resources.Resources.Untitled_design__1__removebg_preview
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox3.Controls.Add(Me.txtTotalRevenue)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 211)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Revenue"
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRevenue.Location = New System.Drawing.Point(3, 76)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.Size = New System.Drawing.Size(285, 34)
        Me.txtTotalRevenue.TabIndex = 1
        Me.txtTotalRevenue.Text = "₱ 10,000.00"
        Me.txtTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel4.Controls.Add(Me.GroupBox4)
        Me.Guna2Panel4.Location = New System.Drawing.Point(912, 55)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(294, 211)
        Me.Guna2Panel4.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.POS_System.My.Resources.Resources.Untitled_design__1__removebg_preview
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox4.Controls.Add(Me.txtTotalVAT)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 211)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total VAT Collected"
        '
        'txtTotalVAT
        '
        Me.txtTotalVAT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVAT.Location = New System.Drawing.Point(3, 76)
        Me.txtTotalVAT.Name = "txtTotalVAT"
        Me.txtTotalVAT.Size = New System.Drawing.Size(285, 34)
        Me.txtTotalVAT.TabIndex = 1
        Me.txtTotalVAT.Text = "₱ 10,000.00"
        Me.txtTotalVAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboPeriod
        '
        Me.cboPeriod.BackColor = System.Drawing.Color.Transparent
        Me.cboPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPeriod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPeriod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPeriod.ItemHeight = 30
        Me.cboPeriod.Items.AddRange(New Object() {"Today", "Monthly", "Yearly"})
        Me.cboPeriod.Location = New System.Drawing.Point(12, 12)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(110, 36)
        Me.cboPeriod.TabIndex = 6
        '
        'cboValue
        '
        Me.cboValue.BackColor = System.Drawing.Color.Transparent
        Me.cboValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboValue.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboValue.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboValue.ItemHeight = 30
        Me.cboValue.Location = New System.Drawing.Point(128, 12)
        Me.cboValue.Name = "cboValue"
        Me.cboValue.Size = New System.Drawing.Size(82, 36)
        Me.cboValue.TabIndex = 7
        '
        'chartSales
        '
        Me.chartSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend1)
        Me.chartSales.Location = New System.Drawing.Point(12, 272)
        Me.chartSales.Name = "chartSales"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartSales.Series.Add(Series1)
        Me.chartSales.Size = New System.Drawing.Size(1194, 411)
        Me.chartSales.TabIndex = 8
        Me.chartSales.Text = "Sales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.lblComparison)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.lblPreviousSales)
        Me.GroupBox5.Controls.Add(Me.lblCurrentSales)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 723)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(570, 303)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sales Comparison"
        '
        'lblCurrentSales
        '
        Me.lblCurrentSales.AutoSize = True
        Me.lblCurrentSales.Location = New System.Drawing.Point(140, 46)
        Me.lblCurrentSales.Name = "lblCurrentSales"
        Me.lblCurrentSales.Size = New System.Drawing.Size(60, 21)
        Me.lblCurrentSales.TabIndex = 0
        Me.lblCurrentSales.Text = "Label1"
        '
        'lblPreviousSales
        '
        Me.lblPreviousSales.AutoSize = True
        Me.lblPreviousSales.Location = New System.Drawing.Point(140, 90)
        Me.lblPreviousSales.Name = "lblPreviousSales"
        Me.lblPreviousSales.Size = New System.Drawing.Size(60, 21)
        Me.lblPreviousSales.TabIndex = 0
        Me.lblPreviousSales.Text = "Label1"
        '
        'lblComparison
        '
        Me.lblComparison.AutoSize = True
        Me.lblComparison.Location = New System.Drawing.Point(140, 132)
        Me.lblComparison.Name = "lblComparison"
        Me.lblComparison.Size = New System.Drawing.Size(60, 21)
        Me.lblComparison.TabIndex = 0
        Me.lblComparison.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Previous :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Comparison :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.dgvTopSales)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(620, 723)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(586, 306)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Top Selling Products"
        '
        'dgvTopSales
        '
        Me.dgvTopSales.AllowUserToAddRows = False
        Me.dgvTopSales.AllowUserToDeleteRows = False
        Me.dgvTopSales.AllowUserToOrderColumns = True
        Me.dgvTopSales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTopSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTopSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTopSales.ColumnHeadersHeight = 50
        Me.dgvTopSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTopSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRank, Me.colProduct, Me.colQty, Me.colAmount})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTopSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTopSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTopSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSales.Location = New System.Drawing.Point(3, 25)
        Me.dgvTopSales.Name = "dgvTopSales"
        Me.dgvTopSales.ReadOnly = True
        Me.dgvTopSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTopSales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTopSales.RowHeadersVisible = False
        Me.dgvTopSales.RowTemplate.Height = 35
        Me.dgvTopSales.Size = New System.Drawing.Size(580, 278)
        Me.dgvTopSales.TabIndex = 8
        Me.dgvTopSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSales.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTopSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvTopSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTopSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTopSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTopSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTopSales.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvTopSales.ThemeStyle.ReadOnly = True
        Me.dgvTopSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTopSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTopSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.RowsStyle.Height = 35
        Me.dgvTopSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colRank
        '
        Me.colRank.HeaderText = "#"
        Me.colRank.Name = "colRank"
        Me.colRank.ReadOnly = True
        '
        'colProduct
        '
        Me.colProduct.HeaderText = "Product"
        Me.colProduct.Name = "colProduct"
        Me.colProduct.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty Sold"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Total Sales"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1216, 1041)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.chartSales)
        Me.Controls.Add(Me.cboValue)
        Me.Controls.Add(Me.cboPeriod)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDashboard"
        Me.Text = "FrmDashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvTopSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTodaySales As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalItems As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalRevenue As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalVAT As Label
    Friend WithEvents cboPeriod As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboValue As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents chartSales As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents lblComparison As Label
    Friend WithEvents lblPreviousSales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgvTopSales As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colRank As DataGridViewTextBoxColumn
    Friend WithEvents colProduct As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
End Class
