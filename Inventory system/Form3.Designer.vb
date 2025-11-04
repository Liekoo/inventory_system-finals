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
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tblstocks1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tblstocks1TableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocks1TableAdapter()
        Me.Tblstocks1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcustomersTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblusersTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblusersTableAdapter()
        Me.TbinboundingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbinboundingTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tblstocks1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tblstocks1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.tblcustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Me.TblstocksTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 38)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Zero Stocks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 38)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 38)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total Stocks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 38)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total users"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(793, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 38)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total Inbound"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 38)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(334, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 38)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(600, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 38)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "0"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(807, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 38)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tblstocks1BindingSource
        '
        Me.Tblstocks1BindingSource.DataMember = "tblstocks1"
        Me.Tblstocks1BindingSource.DataSource = Me.TarubnewDataSet
        '
        'Tblstocks1TableAdapter
        '
        Me.Tblstocks1TableAdapter.ClearBeforeFill = True
        '
        'Tblstocks1DataGridView
        '
        Me.Tblstocks1DataGridView.AutoGenerateColumns = False
        Me.Tblstocks1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tblstocks1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tblstocks1DataGridView.DataSource = Me.Tblstocks1BindingSource
        Me.Tblstocks1DataGridView.Location = New System.Drawing.Point(19, 313)
        Me.Tblstocks1DataGridView.Name = "Tblstocks1DataGridView"
        Me.Tblstocks1DataGridView.RowTemplate.Height = 24
        Me.Tblstocks1DataGridView.Size = New System.Drawing.Size(544, 220)
        Me.Tblstocks1DataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productcode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "productcode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "productname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "productname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stocks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "stocks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tblusers"
        Me.TblusersBindingSource.DataSource = Me.TarubnewDataSet
        '
        'TblusersTableAdapter
        '
        Me.TblusersTableAdapter.ClearBeforeFill = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 48)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tblstocks1DataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tblstocks1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tblstocks1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinboundingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tblstocks1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tblstocks1TableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocks1TableAdapter
    Friend WithEvents Tblstocks1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblcustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcustomersTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter
    Friend WithEvents TblusersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblusersTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblusersTableAdapter
    Friend WithEvents TbinboundingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbinboundingTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbinboundingTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
