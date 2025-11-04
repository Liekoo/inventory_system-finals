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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Qty_outLabel As System.Windows.Forms.Label
        Dim TotalstocksLabel As System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataTable1TableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.DataTable1TableAdapter()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TbloutboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbloutboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.TbloutboundingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Qty_outTextBox = New System.Windows.Forms.TextBox()
        Me.TotalstocksTextBox = New System.Windows.Forms.TextBox()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Qty_outLabel = New System.Windows.Forms.Label()
        TotalstocksLabel = New System.Windows.Forms.Label()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(26, 214)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 49
        IDLabel.Text = "ID:"
        '
        'Qty_outLabel
        '
        Qty_outLabel.AutoSize = True
        Qty_outLabel.Location = New System.Drawing.Point(26, 242)
        Qty_outLabel.Name = "Qty_outLabel"
        Qty_outLabel.Size = New System.Drawing.Size(55, 17)
        Qty_outLabel.TabIndex = 51
        Qty_outLabel.Text = "qty out:"
        '
        'TotalstocksLabel
        '
        TotalstocksLabel.AutoSize = True
        TotalstocksLabel.Location = New System.Drawing.Point(26, 270)
        TotalstocksLabel.Name = "TotalstocksLabel"
        TotalstocksLabel.Size = New System.Drawing.Size(79, 17)
        TotalstocksLabel.TabIndex = 53
        TotalstocksLabel.Text = "totalstocks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(312, 38)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Outbounding Stocks"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(448, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 43)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 44)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(18, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 44)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(296, 449)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 44)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Del"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(771, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 38)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Updated Stocks"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1011, 450)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 43)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 32)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "<"
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Me.TbloutboundingTableAdapter
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbloutboundingDataGridView
        '
        Me.TbloutboundingDataGridView.AutoGenerateColumns = False
        Me.TbloutboundingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbloutboundingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TbloutboundingDataGridView.DataSource = Me.TbloutboundingBindingSource
        Me.TbloutboundingDataGridView.Location = New System.Drawing.Point(217, 204)
        Me.TbloutboundingDataGridView.Name = "TbloutboundingDataGridView"
        Me.TbloutboundingDataGridView.RowTemplate.Height = 24
        Me.TbloutboundingDataGridView.Size = New System.Drawing.Size(357, 220)
        Me.TbloutboundingDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "qty_out"
        Me.DataGridViewTextBoxColumn2.HeaderText = "qty_out"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "totalstocks"
        Me.DataGridViewTextBoxColumn3.HeaderText = "totalstocks"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(111, 211)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 50
        '
        'Qty_outTextBox
        '
        Me.Qty_outTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "qty_out", True))
        Me.Qty_outTextBox.Location = New System.Drawing.Point(111, 239)
        Me.Qty_outTextBox.Name = "Qty_outTextBox"
        Me.Qty_outTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Qty_outTextBox.TabIndex = 52
        '
        'TotalstocksTextBox
        '
        Me.TotalstocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "totalstocks", True))
        Me.TotalstocksTextBox.Location = New System.Drawing.Point(111, 267)
        Me.TotalstocksTextBox.Name = "TotalstocksTextBox"
        Me.TotalstocksTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalstocksTextBox.TabIndex = 54
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.TarubnewDataSet
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource1
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(675, 204)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.RowTemplate.Height = 24
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(453, 220)
        Me.DataTable1DataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "productname"
        Me.DataGridViewTextBoxColumn6.HeaderText = "productname"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "qty_in"
        Me.DataGridViewTextBoxColumn7.HeaderText = "qty_in"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "qty_out"
        Me.DataGridViewTextBoxColumn8.HeaderText = "qty_out"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "stocks"
        Me.DataGridViewTextBoxColumn9.HeaderText = "stocks"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "totalstocks"
        Me.DataGridViewTextBoxColumn10.HeaderText = "totalstocks"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(784, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(671, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total Stocks:"
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
        'Foutbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 513)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Qty_outLabel)
        Me.Controls.Add(Me.Qty_outTextBox)
        Me.Controls.Add(TotalstocksLabel)
        Me.Controls.Add(Me.TotalstocksTextBox)
        Me.Controls.Add(Me.TbloutboundingDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Foutbound"
        Me.Text = "Form7"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataTable1TableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TbloutboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbloutboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbloutboundingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty_outTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalstocksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
End Class
