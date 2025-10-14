<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim ItemnameLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Serial_noLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim Stock_inLabel As System.Windows.Forms.Label
        Dim Stock_outLabel As System.Windows.Forms.Label
        Dim Item_descriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Total_priceLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.TblitemsTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.tblitemsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ItemnameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Serial_noTextBox = New System.Windows.Forms.TextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_inDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Stock_outDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Item_descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Total_priceTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        ItemnameLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Serial_noLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        Stock_inLabel = New System.Windows.Forms.Label()
        Stock_outLabel = New System.Windows.Forms.Label()
        Item_descriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Total_priceLabel = New System.Windows.Forms.Label()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(126, 114)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 14
        IdLabel.Text = "id:"
        '
        'ItemnameLabel
        '
        ItemnameLabel.AutoSize = True
        ItemnameLabel.Location = New System.Drawing.Point(126, 142)
        ItemnameLabel.Name = "ItemnameLabel"
        ItemnameLabel.Size = New System.Drawing.Size(73, 17)
        ItemnameLabel.TabIndex = 16
        ItemnameLabel.Text = "itemname:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(126, 170)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(67, 17)
        CategoryLabel.TabIndex = 18
        CategoryLabel.Text = "category:"
        '
        'Serial_noLabel
        '
        Serial_noLabel.AutoSize = True
        Serial_noLabel.Location = New System.Drawing.Point(126, 198)
        Serial_noLabel.Name = "Serial_noLabel"
        Serial_noLabel.Size = New System.Drawing.Size(66, 17)
        Serial_noLabel.TabIndex = 20
        Serial_noLabel.Text = "serial no:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(126, 226)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(31, 17)
        QtyLabel.TabIndex = 22
        QtyLabel.Text = "qty:"
        '
        'Stock_inLabel
        '
        Stock_inLabel.AutoSize = True
        Stock_inLabel.Location = New System.Drawing.Point(126, 255)
        Stock_inLabel.Name = "Stock_inLabel"
        Stock_inLabel.Size = New System.Drawing.Size(60, 17)
        Stock_inLabel.TabIndex = 24
        Stock_inLabel.Text = "stock in:"
        '
        'Stock_outLabel
        '
        Stock_outLabel.AutoSize = True
        Stock_outLabel.Location = New System.Drawing.Point(126, 283)
        Stock_outLabel.Name = "Stock_outLabel"
        Stock_outLabel.Size = New System.Drawing.Size(69, 17)
        Stock_outLabel.TabIndex = 26
        Stock_outLabel.Text = "stock out:"
        '
        'Item_descriptionLabel
        '
        Item_descriptionLabel.AutoSize = True
        Item_descriptionLabel.Location = New System.Drawing.Point(126, 310)
        Item_descriptionLabel.Name = "Item_descriptionLabel"
        Item_descriptionLabel.Size = New System.Drawing.Size(111, 17)
        Item_descriptionLabel.TabIndex = 28
        Item_descriptionLabel.Text = "item description:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(126, 338)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(43, 17)
        PriceLabel.TabIndex = 30
        PriceLabel.Text = "price:"
        '
        'Total_priceLabel
        '
        Total_priceLabel.AutoSize = True
        Total_priceLabel.Location = New System.Drawing.Point(126, 366)
        Total_priceLabel.Name = "Total_priceLabel"
        Total_priceLabel.Size = New System.Drawing.Size(74, 17)
        Total_priceLabel.TabIndex = 32
        Total_priceLabel.Text = "total price:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 38)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stock In"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tblitems"
        Me.TblitemsBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblitemsTableAdapter
        '
        Me.TblitemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblitemsTableAdapter = Me.TblitemsTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(243, 111)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdTextBox.TabIndex = 15
        '
        'ItemnameTextBox
        '
        Me.ItemnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "itemname", True))
        Me.ItemnameTextBox.Location = New System.Drawing.Point(243, 139)
        Me.ItemnameTextBox.Name = "ItemnameTextBox"
        Me.ItemnameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ItemnameTextBox.TabIndex = 17
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(243, 167)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CategoryTextBox.TabIndex = 19
        '
        'Serial_noTextBox
        '
        Me.Serial_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "serial_no", True))
        Me.Serial_noTextBox.Location = New System.Drawing.Point(243, 195)
        Me.Serial_noTextBox.Name = "Serial_noTextBox"
        Me.Serial_noTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Serial_noTextBox.TabIndex = 21
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(243, 223)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(200, 22)
        Me.QtyTextBox.TabIndex = 23
        '
        'Stock_inDateTimePicker
        '
        Me.Stock_inDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblitemsBindingSource, "stock_in", True))
        Me.Stock_inDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Stock_inDateTimePicker.Location = New System.Drawing.Point(243, 251)
        Me.Stock_inDateTimePicker.Name = "Stock_inDateTimePicker"
        Me.Stock_inDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Stock_inDateTimePicker.TabIndex = 25
        '
        'Stock_outDateTimePicker
        '
        Me.Stock_outDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblitemsBindingSource, "stock_out", True))
        Me.Stock_outDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Stock_outDateTimePicker.Location = New System.Drawing.Point(243, 279)
        Me.Stock_outDateTimePicker.Name = "Stock_outDateTimePicker"
        Me.Stock_outDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Stock_outDateTimePicker.TabIndex = 27
        '
        'Item_descriptionTextBox
        '
        Me.Item_descriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "item_description", True))
        Me.Item_descriptionTextBox.Location = New System.Drawing.Point(243, 307)
        Me.Item_descriptionTextBox.Name = "Item_descriptionTextBox"
        Me.Item_descriptionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Item_descriptionTextBox.TabIndex = 29
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(243, 335)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 31
        '
        'Total_priceTextBox
        '
        Me.Total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "total_price", True))
        Me.Total_priceTextBox.Location = New System.Drawing.Point(243, 363)
        Me.Total_priceTextBox.Name = "Total_priceTextBox"
        Me.Total_priceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Total_priceTextBox.TabIndex = 33
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 509)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ItemnameLabel)
        Me.Controls.Add(Me.ItemnameTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Serial_noLabel)
        Me.Controls.Add(Me.Serial_noTextBox)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Me.QtyTextBox)
        Me.Controls.Add(Stock_inLabel)
        Me.Controls.Add(Me.Stock_inDateTimePicker)
        Me.Controls.Add(Stock_outLabel)
        Me.Controls.Add(Me.Stock_outDateTimePicker)
        Me.Controls.Add(Item_descriptionLabel)
        Me.Controls.Add(Me.Item_descriptionTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Total_priceLabel)
        Me.Controls.Add(Me.Total_priceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents TblitemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblitemsTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.tblitemsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Serial_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_inDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Stock_outDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Item_descriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_priceTextBox As System.Windows.Forms.TextBox
End Class
