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
        Dim IDLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Qty_inLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbinboundingDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Qty_inTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TbinboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbinboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Qty_inLabel = New System.Windows.Forms.Label()
        CType(Me.TbinboundingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(243, 109)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 39
        IDLabel.Text = "ID:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(243, 137)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(43, 17)
        PriceLabel.TabIndex = 41
        PriceLabel.Text = "price:"
        '
        'Qty_inLabel
        '
        Qty_inLabel.AutoSize = True
        Qty_inLabel.Location = New System.Drawing.Point(243, 165)
        Qty_inLabel.Name = "Qty_inLabel"
        Qty_inLabel.Size = New System.Drawing.Size(46, 17)
        Qty_inLabel.TabIndex = 43
        Qty_inLabel.Text = "qty in:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1103, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1003, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "No of Items:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(524, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 43)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 38)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Inbounding Stocks"
        '
        'TbinboundingDataGridView
        '
        Me.TbinboundingDataGridView.AutoGenerateColumns = False
        Me.TbinboundingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbinboundingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TbinboundingDataGridView.DataSource = Me.TbinboundingBindingSource
        Me.TbinboundingDataGridView.Location = New System.Drawing.Point(525, 104)
        Me.TbinboundingDataGridView.Name = "TbinboundingDataGridView"
        Me.TbinboundingDataGridView.RowTemplate.Height = 24
        Me.TbinboundingDataGridView.Size = New System.Drawing.Size(365, 220)
        Me.TbinboundingDataGridView.TabIndex = 39
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(295, 106)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(193, 22)
        Me.IDTextBox.TabIndex = 40
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(295, 134)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(193, 22)
        Me.PriceTextBox.TabIndex = 42
        '
        'Qty_inTextBox
        '
        Me.Qty_inTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinboundingBindingSource, "qty_in", True))
        Me.Qty_inTextBox.Location = New System.Drawing.Point(295, 162)
        Me.Qty_inTextBox.Name = "Qty_inTextBox"
        Me.Qty_inTextBox.Size = New System.Drawing.Size(193, 22)
        Me.Qty_inTextBox.TabIndex = 44
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(246, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 44)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(647, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 44)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Del"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TbinboundingBindingSource
        '
        Me.TbinboundingBindingSource.DataMember = "tbinbounding"
        Me.TbinboundingBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn2.HeaderText = "price"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "qty_in"
        Me.DataGridViewTextBoxColumn3.HeaderText = "qty_in"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TbinboundingTableAdapter
        '
        Me.TbinboundingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Me.TbinboundingTableAdapter
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 32)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "<"
        '
        'Finbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Qty_inLabel)
        Me.Controls.Add(Me.Qty_inTextBox)
        Me.Controls.Add(Me.TbinboundingDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Finbound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.TbinboundingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TbinboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbinboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbinboundingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty_inTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
