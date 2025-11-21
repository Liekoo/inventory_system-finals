<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fstocks
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
        Dim StocksIDLabel As System.Windows.Forms.Label
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.TblstocksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductnameTextBox = New System.Windows.Forms.TextBox()
        Me.StocksTextBox = New System.Windows.Forms.TextBox()
        Me.GroupTextBox = New System.Windows.Forms.TextBox()
        Me.StocksIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        ProductcodeLabel = New System.Windows.Forms.Label()
        ProductnameLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        GroupLabel = New System.Windows.Forms.Label()
        StocksIDLabel = New System.Windows.Forms.Label()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductcodeLabel
        '
        ProductcodeLabel.AutoSize = True
        ProductcodeLabel.Location = New System.Drawing.Point(77, 168)
        ProductcodeLabel.Name = "ProductcodeLabel"
        ProductcodeLabel.Size = New System.Drawing.Size(91, 17)
        ProductcodeLabel.TabIndex = 1
        ProductcodeLabel.Text = "productcode:"
        '
        'ProductnameLabel
        '
        ProductnameLabel.AutoSize = True
        ProductnameLabel.Location = New System.Drawing.Point(77, 196)
        ProductnameLabel.Name = "ProductnameLabel"
        ProductnameLabel.Size = New System.Drawing.Size(95, 17)
        ProductnameLabel.TabIndex = 3
        ProductnameLabel.Text = "productname:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.Location = New System.Drawing.Point(77, 224)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(52, 17)
        StocksLabel.TabIndex = 5
        StocksLabel.Text = "stocks:"
        '
        'GroupLabel
        '
        GroupLabel.AutoSize = True
        GroupLabel.Location = New System.Drawing.Point(77, 252)
        GroupLabel.Name = "GroupLabel"
        GroupLabel.Size = New System.Drawing.Size(49, 17)
        GroupLabel.TabIndex = 7
        GroupLabel.Text = "group:"
        '
        'StocksIDLabel
        '
        StocksIDLabel.AutoSize = True
        StocksIDLabel.Location = New System.Drawing.Point(77, 140)
        StocksIDLabel.Name = "StocksIDLabel"
        StocksIDLabel.Size = New System.Drawing.Size(69, 17)
        StocksIDLabel.TabIndex = 9
        StocksIDLabel.Text = "stocks ID:"
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
        Me.TableAdapterManager.tbinboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Me.TblstocksTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblstocksDataGridView
        '
        Me.TblstocksDataGridView.AutoGenerateColumns = False
        Me.TblstocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblstocksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblstocksDataGridView.DataSource = Me.TblstocksBindingSource
        Me.TblstocksDataGridView.Location = New System.Drawing.Point(713, 140)
        Me.TblstocksDataGridView.Name = "TblstocksDataGridView"
        Me.TblstocksDataGridView.RowTemplate.Height = 24
        Me.TblstocksDataGridView.Size = New System.Drawing.Size(580, 220)
        Me.TblstocksDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "stocksID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "stocksID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "productname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stocks"
        Me.DataGridViewTextBoxColumn3.HeaderText = "stocks"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "group"
        Me.DataGridViewTextBoxColumn4.HeaderText = "group"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ProductcodeTextBox
        '
        Me.ProductcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "productcode", True))
        Me.ProductcodeTextBox.Location = New System.Drawing.Point(178, 165)
        Me.ProductcodeTextBox.Name = "ProductcodeTextBox"
        Me.ProductcodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductcodeTextBox.TabIndex = 2
        '
        'ProductnameTextBox
        '
        Me.ProductnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "productname", True))
        Me.ProductnameTextBox.Location = New System.Drawing.Point(178, 193)
        Me.ProductnameTextBox.Name = "ProductnameTextBox"
        Me.ProductnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductnameTextBox.TabIndex = 4
        '
        'StocksTextBox
        '
        Me.StocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "stocks", True))
        Me.StocksTextBox.Location = New System.Drawing.Point(178, 221)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksTextBox.TabIndex = 6
        '
        'GroupTextBox
        '
        Me.GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "group", True))
        Me.GroupTextBox.Location = New System.Drawing.Point(178, 249)
        Me.GroupTextBox.Name = "GroupTextBox"
        Me.GroupTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GroupTextBox.TabIndex = 8
        '
        'StocksIDTextBox
        '
        Me.StocksIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstocksBindingSource, "stocksID", True))
        Me.StocksIDTextBox.Location = New System.Drawing.Point(178, 137)
        Me.StocksIDTextBox.Name = "StocksIDTextBox"
        Me.StocksIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StocksIDTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 79)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 79)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 478)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 79)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Del"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(70, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(582, 478)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 79)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Print One"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(765, 478)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 79)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Print All"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(713, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 22)
        Me.TextBox1.TabIndex = 17
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(948, 478)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 79)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Refresh Datagrid"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Fstocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1356, 689)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ProductcodeLabel)
        Me.Controls.Add(Me.ProductcodeTextBox)
        Me.Controls.Add(ProductnameLabel)
        Me.Controls.Add(Me.ProductnameTextBox)
        Me.Controls.Add(StocksLabel)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(GroupLabel)
        Me.Controls.Add(Me.GroupTextBox)
        Me.Controls.Add(StocksIDLabel)
        Me.Controls.Add(Me.StocksIDTextBox)
        Me.Controls.Add(Me.TblstocksDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fstocks"
        Me.Text = "Fstocks"
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblstocksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StocksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StocksIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
