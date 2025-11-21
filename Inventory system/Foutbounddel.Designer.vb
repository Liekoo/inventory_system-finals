<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foutbounddel
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
        Dim OutboundIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TbloutboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbloutboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.Qty_outTextBox = New System.Windows.Forms.TextBox()
        Me.Date_outDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OutboundIDTextBox = New System.Windows.Forms.TextBox()
        Me.TbloutboundingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Qty_outLabel = New System.Windows.Forms.Label()
        Date_outLabel = New System.Windows.Forms.Label()
        OutboundIDLabel = New System.Windows.Forms.Label()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloutboundingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qty_outLabel
        '
        Qty_outLabel.AutoSize = True
        Qty_outLabel.Location = New System.Drawing.Point(41, 123)
        Qty_outLabel.Name = "Qty_outLabel"
        Qty_outLabel.Size = New System.Drawing.Size(55, 17)
        Qty_outLabel.TabIndex = 1
        Qty_outLabel.Text = "qty out:"
        '
        'Date_outLabel
        '
        Date_outLabel.AutoSize = True
        Date_outLabel.Location = New System.Drawing.Point(41, 152)
        Date_outLabel.Name = "Date_outLabel"
        Date_outLabel.Size = New System.Drawing.Size(64, 17)
        Date_outLabel.TabIndex = 3
        Date_outLabel.Text = "date out:"
        '
        'OutboundIDLabel
        '
        OutboundIDLabel.AutoSize = True
        OutboundIDLabel.Location = New System.Drawing.Point(41, 96)
        OutboundIDLabel.Name = "OutboundIDLabel"
        OutboundIDLabel.Size = New System.Drawing.Size(89, 17)
        OutboundIDLabel.TabIndex = 5
        OutboundIDLabel.Text = "outbound ID:"
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
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Me.TbloutboundingTableAdapter
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Qty_outTextBox
        '
        Me.Qty_outTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "qty_out", True))
        Me.Qty_outTextBox.Location = New System.Drawing.Point(143, 120)
        Me.Qty_outTextBox.Name = "Qty_outTextBox"
        Me.Qty_outTextBox.Size = New System.Drawing.Size(153, 22)
        Me.Qty_outTextBox.TabIndex = 2
        '
        'Date_outDateTimePicker
        '
        Me.Date_outDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbloutboundingBindingSource, "date_out", True))
        Me.Date_outDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_outDateTimePicker.Location = New System.Drawing.Point(143, 148)
        Me.Date_outDateTimePicker.Name = "Date_outDateTimePicker"
        Me.Date_outDateTimePicker.Size = New System.Drawing.Size(153, 22)
        Me.Date_outDateTimePicker.TabIndex = 4
        Me.Date_outDateTimePicker.Value = New Date(2025, 12, 6, 0, 0, 0, 0)
        '
        'OutboundIDTextBox
        '
        Me.OutboundIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbloutboundingBindingSource, "outboundID", True))
        Me.OutboundIDTextBox.Location = New System.Drawing.Point(143, 93)
        Me.OutboundIDTextBox.Name = "OutboundIDTextBox"
        Me.OutboundIDTextBox.Size = New System.Drawing.Size(153, 22)
        Me.OutboundIDTextBox.TabIndex = 6
        '
        'TbloutboundingDataGridView
        '
        Me.TbloutboundingDataGridView.AutoGenerateColumns = False
        Me.TbloutboundingDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TbloutboundingDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TbloutboundingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbloutboundingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbloutboundingDataGridView.DataSource = Me.TbloutboundingBindingSource
        Me.TbloutboundingDataGridView.Location = New System.Drawing.Point(403, 93)
        Me.TbloutboundingDataGridView.Name = "TbloutboundingDataGridView"
        Me.TbloutboundingDataGridView.RowTemplate.Height = 24
        Me.TbloutboundingDataGridView.Size = New System.Drawing.Size(404, 220)
        Me.TbloutboundingDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "outboundID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "outboundID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "qty_out"
        Me.DataGridViewTextBoxColumn1.HeaderText = "qty_out"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date_out"
        Me.DataGridViewTextBoxColumn2.HeaderText = "date_out"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CustomersID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CustomersID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(343, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 59)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Del"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 59)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 59)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Foutbounddel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BGS
        Me.ClientSize = New System.Drawing.Size(853, 418)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbloutboundingDataGridView)
        Me.Controls.Add(Qty_outLabel)
        Me.Controls.Add(Me.Qty_outTextBox)
        Me.Controls.Add(Date_outLabel)
        Me.Controls.Add(Me.Date_outDateTimePicker)
        Me.Controls.Add(OutboundIDLabel)
        Me.Controls.Add(Me.OutboundIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Foutbounddel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foutbounddel"
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloutboundingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TbloutboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbloutboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbloutboundingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Qty_outTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_outDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OutboundIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbloutboundingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
