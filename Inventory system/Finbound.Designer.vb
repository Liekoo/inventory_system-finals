<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finbound
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
        Dim ProductcodeLabel As System.Windows.Forms.Label
        Dim ProductnameLabel As System.Windows.Forms.Label
        Dim StocksLabel As System.Windows.Forms.Label
        Dim GroupLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Qty_inLabel As System.Windows.Forms.Label
        Dim InboundIDLabel As System.Windows.Forms.Label
        Dim StocksIDLabel As System.Windows.Forms.Label
        Dim CustomersIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finbound))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.TbinboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter()
        Me.ProductnameTextBox = New System.Windows.Forms.TextBox()
        Me.StocksTextBox = New System.Windows.Forms.TextBox()
        Me.GroupTextBox = New System.Windows.Forms.TextBox()
        Me.TbinboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Qty_inTextBox = New System.Windows.Forms.TextBox()
        Me.InboundIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.StocksIDTextBox = New System.Windows.Forms.TextBox()
        Me.TbladptinprintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladptinprintTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbladptinprintTableAdapter()
        Me.TbladptinprintDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbloutboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbloutboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblcustomersTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter()
        Me.TblcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ProductcodeLabel = New System.Windows.Forms.Label()
        ProductnameLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        GroupLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Qty_inLabel = New System.Windows.Forms.Label()
        InboundIDLabel = New System.Windows.Forms.Label()
        StocksIDLabel = New System.Windows.Forms.Label()
        CustomersIDLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladptinprintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladptinprintDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductcodeLabel
        '
        ProductcodeLabel.AutoSize = True
        ProductcodeLabel.Location = New System.Drawing.Point(33, 161)
        ProductcodeLabel.Name = "ProductcodeLabel"
        ProductcodeLabel.Size = New System.Drawing.Size(91, 17)
        ProductcodeLabel.TabIndex = 72
        ProductcodeLabel.Text = "productcode:"
        '
        'ProductnameLabel
        '
        ProductnameLabel.AutoSize = True
        ProductnameLabel.Location = New System.Drawing.Point(33, 189)
        ProductnameLabel.Name = "ProductnameLabel"
        ProductnameLabel.Size = New System.Drawing.Size(95, 17)
        ProductnameLabel.TabIndex = 74
        ProductnameLabel.Text = "productname:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.Location = New System.Drawing.Point(33, 217)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(52, 17)
        StocksLabel.TabIndex = 76
        StocksLabel.Text = "stocks:"
        '
        'GroupLabel
        '
        GroupLabel.AutoSize = True
        GroupLabel.Location = New System.Drawing.Point(33, 245)
        GroupLabel.Name = "GroupLabel"
        GroupLabel.Size = New System.Drawing.Size(49, 17)
        GroupLabel.TabIndex = 78
        GroupLabel.Text = "group:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(33, 319)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(43, 17)
        PriceLabel.TabIndex = 81
        PriceLabel.Text = "price:"
        '
        'Qty_inLabel
        '
        Qty_inLabel.AutoSize = True
        Qty_inLabel.Location = New System.Drawing.Point(33, 347)
        Qty_inLabel.Name = "Qty_inLabel"
        Qty_inLabel.Size = New System.Drawing.Size(46, 17)
        Qty_inLabel.TabIndex = 83
        Qty_inLabel.Text = "qty in:"
        '
        'InboundIDLabel
        '
        InboundIDLabel.AutoSize = True
        InboundIDLabel.Location = New System.Drawing.Point(33, 290)
        InboundIDLabel.Name = "InboundIDLabel"
        InboundIDLabel.Size = New System.Drawing.Size(80, 17)
        InboundIDLabel.TabIndex = 87
        InboundIDLabel.Text = "inbound ID:"
        '
        'StocksIDLabel
        '
        StocksIDLabel.AutoSize = True
        StocksIDLabel.Location = New System.Drawing.Point(33, 99)
        StocksIDLabel.Name = "StocksIDLabel"
        StocksIDLabel.Size = New System.Drawing.Size(69, 17)
        StocksIDLabel.TabIndex = 91
        StocksIDLabel.Text = "stocks ID:"
        '
        'CustomersIDLabel
        '
        CustomersIDLabel.AutoSize = True
        CustomersIDLabel.Location = New System.Drawing.Point(28, 129)
        CustomersIDLabel.Name = "CustomersIDLabel"
        CustomersIDLabel.Size = New System.Drawing.Size(96, 17)
        CustomersIDLabel.TabIndex = 95
        CustomersIDLabel.Text = "Customers ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "No of Stocks:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(49, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 52)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Inbound"
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
        Me.Button5.Location = New System.Drawing.Point(49, 608)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 52)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(786, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 54)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Print Overview"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(917, 454)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 52)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Print All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(273, 608)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 52)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(535, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(273, 47)
        Me.Panel4.TabIndex = 63
        Me.Panel4.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1065, 454)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 52)
        Me.Button6.TabIndex = 71
        Me.Button6.Text = "refresh data"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblstocksBindingSource
        '
        Me.TblstocksBindingSource.DataMember = "tblstocks"
        Me.TblstocksBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TblstocksTableAdapter
        '
        Me.TblstocksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Me.TbinboundingTableAdapter
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Me.TblstocksTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbinboundingTableAdapter
        '
        Me.TbinboundingTableAdapter.ClearBeforeFill = True
        '
        'ProductnameTextBox
        '
        Me.ProductnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "productname", True))
        Me.ProductnameTextBox.Location = New System.Drawing.Point(131, 184)
        Me.ProductnameTextBox.Name = "ProductnameTextBox"
        Me.ProductnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductnameTextBox.TabIndex = 75
        '
        'StocksTextBox
        '
        Me.StocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "stocks", True))
        Me.StocksTextBox.Location = New System.Drawing.Point(131, 212)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksTextBox.TabIndex = 77
        '
        'GroupTextBox
        '
        Me.GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "group", True))
        Me.GroupTextBox.Location = New System.Drawing.Point(131, 240)
        Me.GroupTextBox.Name = "GroupTextBox"
        Me.GroupTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GroupTextBox.TabIndex = 79
        '
        'TbinboundingBindingSource
        '
        Me.TbinboundingBindingSource.DataMember = "tbinbounding"
        Me.TbinboundingBindingSource.DataSource = Me.TarubnewDataSet
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(130, 316)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 82
        '
        'Qty_inTextBox
        '
        Me.Qty_inTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "qty_in", True))
        Me.Qty_inTextBox.Location = New System.Drawing.Point(130, 344)
        Me.Qty_inTextBox.Name = "Qty_inTextBox"
        Me.Qty_inTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Qty_inTextBox.TabIndex = 84
        '
        'InboundIDTextBox
        '
        Me.InboundIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "inboundID", True))
        Me.InboundIDTextBox.Location = New System.Drawing.Point(131, 290)
        Me.InboundIDTextBox.Name = "InboundIDTextBox"
        Me.InboundIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.InboundIDTextBox.TabIndex = 88
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 22)
        Me.TextBox2.TabIndex = 91
        '
        'StocksIDTextBox
        '
        Me.StocksIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "stocksID", True))
        Me.StocksIDTextBox.Location = New System.Drawing.Point(131, 99)
        Me.StocksIDTextBox.Name = "StocksIDTextBox"
        Me.StocksIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksIDTextBox.TabIndex = 92
        '
        'TbladptinprintBindingSource
        '
        Me.TbladptinprintBindingSource.DataMember = "tbladptinprint"
        Me.TbladptinprintBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TbladptinprintTableAdapter
        '
        Me.TbladptinprintTableAdapter.ClearBeforeFill = True
        '
        'TbladptinprintDataGridView
        '
        Me.TbladptinprintDataGridView.AllowUserToDeleteRows = False
        Me.TbladptinprintDataGridView.AutoGenerateColumns = False
        Me.TbladptinprintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbladptinprintDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TbladptinprintDataGridView.DataSource = Me.TbladptinprintBindingSource
        Me.TbladptinprintDataGridView.Location = New System.Drawing.Point(535, 189)
        Me.TbladptinprintDataGridView.Name = "TbladptinprintDataGridView"
        Me.TbladptinprintDataGridView.ReadOnly = True
        Me.TbladptinprintDataGridView.RowTemplate.Height = 24
        Me.TbladptinprintDataGridView.Size = New System.Drawing.Size(796, 220)
        Me.TbladptinprintDataGridView.TabIndex = 93
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CustomersID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CustomersID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "stocksID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "stocksID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "productname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stocks"
        Me.DataGridViewTextBoxColumn3.HeaderText = "stocks"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "qty_in"
        Me.DataGridViewTextBoxColumn4.HeaderText = "qty_in"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "group"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date_in"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date_in"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "price"
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
        'TbloutboundingBindingSource
        '
        Me.TbloutboundingBindingSource.DataMember = "tbloutbounding"
        Me.TbloutboundingBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TbloutboundingTableAdapter
        '
        Me.TbloutboundingTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "CustomersID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(163, 127)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox1.TabIndex = 95
        Me.ComboBox1.ValueMember = "CustomersID"
        '
        'TblcustomersTableAdapter
        '
        Me.TblcustomersTableAdapter.ClearBeforeFill = True
        '
        'TblcustomersBindingSource
        '
        Me.TblcustomersBindingSource.DataMember = "tblcustomers"
        Me.TblcustomersBindingSource.DataSource = Me.TarubnewDataSet
        '
        'Finbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1388, 707)
        Me.Controls.Add(CustomersIDLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TbladptinprintDataGridView)
        Me.Controls.Add(StocksIDLabel)
        Me.Controls.Add(Me.StocksIDTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Qty_inLabel)
        Me.Controls.Add(Me.Qty_inTextBox)
        Me.Controls.Add(InboundIDLabel)
        Me.Controls.Add(Me.InboundIDTextBox)
        Me.Controls.Add(ProductcodeLabel)
        Me.Controls.Add(ProductnameLabel)
        Me.Controls.Add(Me.ProductnameTextBox)
        Me.Controls.Add(StocksLabel)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(GroupLabel)
        Me.Controls.Add(Me.GroupTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Finbound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladptinprintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladptinprintDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbinboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter
    Friend WithEvents ProductnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StocksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbinboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty_inTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InboundIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents StocksIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbladptinprintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladptinprintTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbladptinprintTableAdapter
    Friend WithEvents TbladptinprintDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbloutboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbloutboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TblcustomersTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter
    Friend WithEvents TblcustomersBindingSource As System.Windows.Forms.BindingSource
End Class
