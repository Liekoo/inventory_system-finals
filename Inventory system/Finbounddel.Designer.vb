<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finbounddel
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
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Qty_inLabel As System.Windows.Forms.Label
        Dim Date_inLabel As System.Windows.Forms.Label
        Dim InboundIDLabel As System.Windows.Forms.Label
        Dim ProductcodeLabel As System.Windows.Forms.Label
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TbinboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbinboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.TbinboundingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Qty_inTextBox = New System.Windows.Forms.TextBox()
        Me.Date_inDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InboundIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        PriceLabel = New System.Windows.Forms.Label()
        Qty_inLabel = New System.Windows.Forms.Label()
        Date_inLabel = New System.Windows.Forms.Label()
        InboundIDLabel = New System.Windows.Forms.Label()
        ProductcodeLabel = New System.Windows.Forms.Label()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinboundingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(42, 144)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(43, 17)
        PriceLabel.TabIndex = 1
        PriceLabel.Text = "price:"
        '
        'Qty_inLabel
        '
        Qty_inLabel.AutoSize = True
        Qty_inLabel.Location = New System.Drawing.Point(42, 172)
        Qty_inLabel.Name = "Qty_inLabel"
        Qty_inLabel.Size = New System.Drawing.Size(46, 17)
        Qty_inLabel.TabIndex = 3
        Qty_inLabel.Text = "qty in:"
        '
        'Date_inLabel
        '
        Date_inLabel.AutoSize = True
        Date_inLabel.Location = New System.Drawing.Point(42, 201)
        Date_inLabel.Name = "Date_inLabel"
        Date_inLabel.Size = New System.Drawing.Size(55, 17)
        Date_inLabel.TabIndex = 5
        Date_inLabel.Text = "date in:"
        '
        'InboundIDLabel
        '
        InboundIDLabel.AutoSize = True
        InboundIDLabel.Location = New System.Drawing.Point(42, 105)
        InboundIDLabel.Name = "InboundIDLabel"
        InboundIDLabel.Size = New System.Drawing.Size(80, 17)
        InboundIDLabel.TabIndex = 7
        InboundIDLabel.Text = "inbound ID:"
        '
        'ProductcodeLabel
        '
        ProductcodeLabel.AutoSize = True
        ProductcodeLabel.Location = New System.Drawing.Point(42, 239)
        ProductcodeLabel.Name = "ProductcodeLabel"
        ProductcodeLabel.Size = New System.Drawing.Size(91, 17)
        ProductcodeLabel.TabIndex = 9
        ProductcodeLabel.Text = "productcode:"
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbinboundingBindingSource
        '
        Me.TbinboundingBindingSource.DataMember = "tbinbounding"
        Me.TbinboundingBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TbinboundingTableAdapter
        '
        Me.TbinboundingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Me.TbinboundingTableAdapter
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbinboundingDataGridView
        '
        Me.TbinboundingDataGridView.AutoGenerateColumns = False
        Me.TbinboundingDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        Me.TbinboundingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbinboundingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.TbinboundingDataGridView.DataSource = Me.TbinboundingBindingSource
        Me.TbinboundingDataGridView.Location = New System.Drawing.Point(555, 90)
        Me.TbinboundingDataGridView.Name = "TbinboundingDataGridView"
        Me.TbinboundingDataGridView.RowTemplate.Height = 24
        Me.TbinboundingDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TbinboundingDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "inboundID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "inboundID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn1.HeaderText = "price"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "qty_in"
        Me.DataGridViewTextBoxColumn2.HeaderText = "qty_in"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date_in"
        Me.DataGridViewTextBoxColumn3.HeaderText = "date_in"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(139, 141)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 2
        '
        'Qty_inTextBox
        '
        Me.Qty_inTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "qty_in", True))
        Me.Qty_inTextBox.Location = New System.Drawing.Point(139, 169)
        Me.Qty_inTextBox.Name = "Qty_inTextBox"
        Me.Qty_inTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Qty_inTextBox.TabIndex = 4
        '
        'Date_inDateTimePicker
        '
        Me.Date_inDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbinboundingBindingSource, "date_in", True))
        Me.Date_inDateTimePicker.Location = New System.Drawing.Point(139, 197)
        Me.Date_inDateTimePicker.Name = "Date_inDateTimePicker"
        Me.Date_inDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Date_inDateTimePicker.TabIndex = 6
        '
        'InboundIDTextBox
        '
        Me.InboundIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "inboundID", True))
        Me.InboundIDTextBox.Location = New System.Drawing.Point(139, 102)
        Me.InboundIDTextBox.Name = "InboundIDTextBox"
        Me.InboundIDTextBox.Size = New System.Drawing.Size(54, 22)
        Me.InboundIDTextBox.TabIndex = 8
        '
        'ProductcodeTextBox
        '
        Me.ProductcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "productcode", True))
        Me.ProductcodeTextBox.Location = New System.Drawing.Point(139, 236)
        Me.ProductcodeTextBox.Name = "ProductcodeTextBox"
        Me.ProductcodeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ProductcodeTextBox.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(365, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 59)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Del"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 59)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 59)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Finbounddel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BGS
        Me.ClientSize = New System.Drawing.Size(871, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Qty_inLabel)
        Me.Controls.Add(Me.Qty_inTextBox)
        Me.Controls.Add(Date_inLabel)
        Me.Controls.Add(Me.Date_inDateTimePicker)
        Me.Controls.Add(InboundIDLabel)
        Me.Controls.Add(Me.InboundIDTextBox)
        Me.Controls.Add(ProductcodeLabel)
        Me.Controls.Add(Me.ProductcodeTextBox)
        Me.Controls.Add(Me.TbinboundingDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Finbounddel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finbounddel"
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinboundingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TbinboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbinboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbinboundingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty_inTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_inDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents InboundIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
