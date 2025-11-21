<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foutbound
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
        Dim Qty_outLabel As System.Windows.Forms.Label
        Dim Date_outLabel As System.Windows.Forms.Label
        Dim ProductcodeLabel1 As System.Windows.Forms.Label
        Dim ProductnameLabel As System.Windows.Forms.Label
        Dim StocksLabel As System.Windows.Forms.Label
        Dim GroupLabel As System.Windows.Forms.Label
        Dim StocksIDLabel As System.Windows.Forms.Label
        Dim CustomersIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladptoutprintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Qty_outTextBox = New System.Windows.Forms.TextBox()
        Me.TbloutboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.Date_outDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProductnameTextBox = New System.Windows.Forms.TextBox()
        Me.TblstocksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTextBox = New System.Windows.Forms.TextBox()
        Me.GroupTextBox = New System.Windows.Forms.TextBox()
        Me.StocksIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        Me.TbladptoutprintTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbladptoutprintTableAdapter()
        Me.TbloutboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.TbladptoutprintBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladptoutprintDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcustomersTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Qty_outLabel = New System.Windows.Forms.Label()
        Date_outLabel = New System.Windows.Forms.Label()
        ProductcodeLabel1 = New System.Windows.Forms.Label()
        ProductnameLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        GroupLabel = New System.Windows.Forms.Label()
        StocksIDLabel = New System.Windows.Forms.Label()
        CustomersIDLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladptoutprintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladptoutprintBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladptoutprintDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qty_outLabel
        '
        Qty_outLabel.AutoSize = True
        Qty_outLabel.BackColor = System.Drawing.Color.Transparent
        Qty_outLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Qty_outLabel.Location = New System.Drawing.Point(345, 67)
        Qty_outLabel.Name = "Qty_outLabel"
        Qty_outLabel.Size = New System.Drawing.Size(69, 23)
        Qty_outLabel.TabIndex = 62
        Qty_outLabel.Text = "qty out:"
        '
        'Date_outLabel
        '
        Date_outLabel.AutoSize = True
        Date_outLabel.BackColor = System.Drawing.Color.Transparent
        Date_outLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_outLabel.Location = New System.Drawing.Point(345, 132)
        Date_outLabel.Name = "Date_outLabel"
        Date_outLabel.Size = New System.Drawing.Size(79, 23)
        Date_outLabel.TabIndex = 64
        Date_outLabel.Text = "date out:"
        '
        'ProductcodeLabel1
        '
        ProductcodeLabel1.AutoSize = True
        ProductcodeLabel1.BackColor = System.Drawing.Color.Transparent
        ProductcodeLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductcodeLabel1.Location = New System.Drawing.Point(73, 132)
        ProductcodeLabel1.Name = "ProductcodeLabel1"
        ProductcodeLabel1.Size = New System.Drawing.Size(111, 23)
        ProductcodeLabel1.TabIndex = 69
        ProductcodeLabel1.Text = "productcode:"
        '
        'ProductnameLabel
        '
        ProductnameLabel.AutoSize = True
        ProductnameLabel.BackColor = System.Drawing.Color.Transparent
        ProductnameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductnameLabel.Location = New System.Drawing.Point(73, 202)
        ProductnameLabel.Name = "ProductnameLabel"
        ProductnameLabel.Size = New System.Drawing.Size(117, 23)
        ProductnameLabel.TabIndex = 71
        ProductnameLabel.Text = "productname:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.BackColor = System.Drawing.Color.Transparent
        StocksLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StocksLabel.Location = New System.Drawing.Point(67, 260)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(60, 23)
        StocksLabel.TabIndex = 73
        StocksLabel.Text = "stocks:"
        '
        'GroupLabel
        '
        GroupLabel.AutoSize = True
        GroupLabel.BackColor = System.Drawing.Color.Transparent
        GroupLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupLabel.Location = New System.Drawing.Point(73, 327)
        GroupLabel.Name = "GroupLabel"
        GroupLabel.Size = New System.Drawing.Size(60, 23)
        GroupLabel.TabIndex = 75
        GroupLabel.Text = "group:"
        '
        'StocksIDLabel
        '
        StocksIDLabel.AutoSize = True
        StocksIDLabel.BackColor = System.Drawing.Color.Transparent
        StocksIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StocksIDLabel.Location = New System.Drawing.Point(67, 407)
        StocksIDLabel.Name = "StocksIDLabel"
        StocksIDLabel.Size = New System.Drawing.Size(82, 23)
        StocksIDLabel.TabIndex = 77
        StocksIDLabel.Text = "stocks ID:"
        '
        'CustomersIDLabel
        '
        CustomersIDLabel.AutoSize = True
        CustomersIDLabel.BackColor = System.Drawing.Color.Transparent
        CustomersIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomersIDLabel.Location = New System.Drawing.Point(67, 61)
        CustomersIDLabel.Name = "CustomersIDLabel"
        CustomersIDLabel.Size = New System.Drawing.Size(117, 23)
        CustomersIDLabel.TabIndex = 78
        CustomersIDLabel.Text = "Customers ID:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1141, 620)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 52)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(122, 534)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 52)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Outbound"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(122, 619)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 52)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(848, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 54)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Print Overview"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.MediumBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1141, 534)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 52)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1289, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 23)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1179, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total Stocks:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 31)
        Me.TextBox1.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(841, 534)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 52)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(688, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(273, 47)
        Me.Panel4.TabIndex = 62
        Me.Panel4.Visible = False
        '
        'Qty_outTextBox
        '
        Me.Qty_outTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "qty_out", True))
        Me.Qty_outTextBox.Location = New System.Drawing.Point(349, 87)
        Me.Qty_outTextBox.Name = "Qty_outTextBox"
        Me.Qty_outTextBox.Size = New System.Drawing.Size(154, 22)
        Me.Qty_outTextBox.TabIndex = 63
        '
        'TbloutboundingBindingSource
        '
        Me.TbloutboundingBindingSource.DataMember = "tbloutbounding"
        Me.TbloutboundingBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Date_outDateTimePicker
        '
        Me.Date_outDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbloutboundingBindingSource, "date_out", True))
        Me.Date_outDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_outDateTimePicker.Location = New System.Drawing.Point(349, 158)
        Me.Date_outDateTimePicker.Name = "Date_outDateTimePicker"
        Me.Date_outDateTimePicker.Size = New System.Drawing.Size(154, 22)
        Me.Date_outDateTimePicker.TabIndex = 65
        '
        'ProductnameTextBox
        '
        Me.ProductnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource1, "productname", True))
        Me.ProductnameTextBox.Location = New System.Drawing.Point(71, 228)
        Me.ProductnameTextBox.Name = "ProductnameTextBox"
        Me.ProductnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductnameTextBox.TabIndex = 72
        '
        'TblstocksBindingSource1
        '
        Me.TblstocksBindingSource1.DataMember = "tblstocks"
        Me.TblstocksBindingSource1.DataSource = Me.TarubnewDataSet
        '
        'StocksTextBox
        '
        Me.StocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource1, "stocks", True))
        Me.StocksTextBox.Location = New System.Drawing.Point(71, 286)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksTextBox.TabIndex = 74
        '
        'GroupTextBox
        '
        Me.GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource1, "group", True))
        Me.GroupTextBox.Location = New System.Drawing.Point(77, 353)
        Me.GroupTextBox.Name = "GroupTextBox"
        Me.GroupTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GroupTextBox.TabIndex = 76
        '
        'StocksIDTextBox
        '
        Me.StocksIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource1, "stocksID", True))
        Me.StocksIDTextBox.Location = New System.Drawing.Point(77, 433)
        Me.StocksIDTextBox.Name = "StocksIDTextBox"
        Me.StocksIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksIDTextBox.TabIndex = 78
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 22)
        Me.TextBox2.TabIndex = 0
        '
        'TblstocksTableAdapter
        '
        Me.TblstocksTableAdapter.ClearBeforeFill = True
        '
        'TbladptoutprintTableAdapter
        '
        Me.TbladptoutprintTableAdapter.ClearBeforeFill = True
        '
        'TbloutboundingTableAdapter
        '
        Me.TbloutboundingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Me.TbloutboundingTableAdapter
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Me.TblstocksTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbladptoutprintBindingSource1
        '
        Me.TbladptoutprintBindingSource1.DataMember = "tbladptoutprint"
        Me.TbladptoutprintBindingSource1.DataSource = Me.TarubnewDataSet
        '
        'TbladptoutprintDataGridView
        '
        Me.TbladptoutprintDataGridView.AllowUserToAddRows = False
        Me.TbladptoutprintDataGridView.AllowUserToDeleteRows = False
        Me.TbladptoutprintDataGridView.AutoGenerateColumns = False
        Me.TbladptoutprintDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TbladptoutprintDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TbladptoutprintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbladptoutprintDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TbladptoutprintDataGridView.DataSource = Me.TbladptoutprintBindingSource1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TbladptoutprintDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.TbladptoutprintDataGridView.GridColor = System.Drawing.Color.Black
        Me.TbladptoutprintDataGridView.Location = New System.Drawing.Point(688, 260)
        Me.TbladptoutprintDataGridView.Name = "TbladptoutprintDataGridView"
        Me.TbladptoutprintDataGridView.ReadOnly = True
        Me.TbladptoutprintDataGridView.RowTemplate.Height = 24
        Me.TbladptoutprintDataGridView.Size = New System.Drawing.Size(646, 220)
        Me.TbladptoutprintDataGridView.TabIndex = 78
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CustomersID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CustomersID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "stocksID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "stocksID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "productname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "productname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stocks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "stocks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "qty_out"
        Me.DataGridViewTextBoxColumn5.HeaderText = "qty_out"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date_out"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date_out"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "group"
        Me.DataGridViewTextBoxColumn8.HeaderText = "group"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "totalstocks"
        Me.DataGridViewTextBoxColumn9.HeaderText = "totalstocks"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'TblcustomersBindingSource
        '
        Me.TblcustomersBindingSource.DataMember = "tblcustomers"
        Me.TblcustomersBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TblcustomersTableAdapter
        '
        Me.TblcustomersTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(71, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox1.TabIndex = 79
        '
        'Foutbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BGS
        Me.ClientSize = New System.Drawing.Size(1388, 707)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CustomersIDLabel)
        Me.Controls.Add(Me.TbladptoutprintDataGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(ProductcodeLabel1)
        Me.Controls.Add(ProductnameLabel)
        Me.Controls.Add(Me.ProductnameTextBox)
        Me.Controls.Add(StocksLabel)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(GroupLabel)
        Me.Controls.Add(Me.GroupTextBox)
        Me.Controls.Add(StocksIDLabel)
        Me.Controls.Add(Me.StocksIDTextBox)
        Me.Controls.Add(Qty_outLabel)
        Me.Controls.Add(Me.Qty_outTextBox)
        Me.Controls.Add(Date_outLabel)
        Me.Controls.Add(Me.Date_outDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Foutbound"
        Me.Text = "Form7"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladptoutprintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladptoutprintBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladptoutprintDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
    Friend WithEvents TblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladptoutprintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladptoutprintTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbladptoutprintTableAdapter
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TbloutboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbloutboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Qty_outTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_outDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TblstocksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StocksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StocksIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TbladptoutprintBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TbladptoutprintDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblcustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcustomersTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
