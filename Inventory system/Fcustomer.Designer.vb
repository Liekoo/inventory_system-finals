<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fcustomer
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
        Dim CustomersnameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim GstLabel As System.Windows.Forms.Label
        Dim Phone_noLabel As System.Windows.Forms.Label
        Dim CustomersIDLabel As System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.TblcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcustomersTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager()
        Me.CustomersnameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.GstTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_noTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblcustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CustomersnameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        GstLabel = New System.Windows.Forms.Label()
        Phone_noLabel = New System.Windows.Forms.Label()
        CustomersIDLabel = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(112, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 52)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(338, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 52)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(112, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 52)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(421, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 45)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Manage Customers"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Location = New System.Drawing.Point(722, 153)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(273, 47)
        Me.Panel5.TabIndex = 58
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(6, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 31)
        Me.TextBox1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(724, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Search:"
        '
        'TarubnewDataSet
        '
        Me.TarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.TarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblcustomers1TableAdapter = Nothing
        Me.TableAdapterManager.tblcustomersTableAdapter = Me.TblcustomersTableAdapter
        Me.TableAdapterManager.tbloutboundingTableAdapter = Nothing
        Me.TableAdapterManager.tblstocks1TableAdapter = Nothing
        Me.TableAdapterManager.tblstocksTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersnameLabel
        '
        CustomersnameLabel.AutoSize = True
        CustomersnameLabel.Location = New System.Drawing.Point(129, 245)
        CustomersnameLabel.Name = "CustomersnameLabel"
        CustomersnameLabel.Size = New System.Drawing.Size(112, 17)
        CustomersnameLabel.TabIndex = 59
        CustomersnameLabel.Text = "customersname:"
        '
        'CustomersnameTextBox
        '
        Me.CustomersnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcustomersBindingSource, "customersname", True))
        Me.CustomersnameTextBox.Location = New System.Drawing.Point(247, 242)
        Me.CustomersnameTextBox.Name = "CustomersnameTextBox"
        Me.CustomersnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomersnameTextBox.TabIndex = 60
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(129, 273)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(63, 17)
        AddressLabel.TabIndex = 61
        AddressLabel.Text = "address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcustomersBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(247, 270)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 62
        '
        'GstLabel
        '
        GstLabel.AutoSize = True
        GstLabel.Location = New System.Drawing.Point(129, 301)
        GstLabel.Name = "GstLabel"
        GstLabel.Size = New System.Drawing.Size(31, 17)
        GstLabel.TabIndex = 63
        GstLabel.Text = "gst:"
        '
        'GstTextBox
        '
        Me.GstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcustomersBindingSource, "gst", True))
        Me.GstTextBox.Location = New System.Drawing.Point(247, 298)
        Me.GstTextBox.Name = "GstTextBox"
        Me.GstTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GstTextBox.TabIndex = 64
        '
        'Phone_noLabel
        '
        Phone_noLabel.AutoSize = True
        Phone_noLabel.Location = New System.Drawing.Point(129, 329)
        Phone_noLabel.Name = "Phone_noLabel"
        Phone_noLabel.Size = New System.Drawing.Size(72, 17)
        Phone_noLabel.TabIndex = 65
        Phone_noLabel.Text = "phone no:"
        '
        'Phone_noTextBox
        '
        Me.Phone_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcustomersBindingSource, "phone_no", True))
        Me.Phone_noTextBox.Location = New System.Drawing.Point(247, 326)
        Me.Phone_noTextBox.Name = "Phone_noTextBox"
        Me.Phone_noTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Phone_noTextBox.TabIndex = 66
        '
        'CustomersIDLabel
        '
        CustomersIDLabel.AutoSize = True
        CustomersIDLabel.Location = New System.Drawing.Point(129, 357)
        CustomersIDLabel.Name = "CustomersIDLabel"
        CustomersIDLabel.Size = New System.Drawing.Size(96, 17)
        CustomersIDLabel.TabIndex = 67
        CustomersIDLabel.Text = "Customers ID:"
        '
        'CustomersIDTextBox
        '
        Me.CustomersIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcustomersBindingSource, "CustomersID", True))
        Me.CustomersIDTextBox.Location = New System.Drawing.Point(247, 354)
        Me.CustomersIDTextBox.Name = "CustomersIDTextBox"
        Me.CustomersIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomersIDTextBox.TabIndex = 68
        '
        'TblcustomersDataGridView
        '
        Me.TblcustomersDataGridView.AutoGenerateColumns = False
        Me.TblcustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblcustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblcustomersDataGridView.DataSource = Me.TblcustomersBindingSource
        Me.TblcustomersDataGridView.Location = New System.Drawing.Point(641, 266)
        Me.TblcustomersDataGridView.Name = "TblcustomersDataGridView"
        Me.TblcustomersDataGridView.RowTemplate.Height = 24
        Me.TblcustomersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblcustomersDataGridView.TabIndex = 68
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customersname"
        Me.DataGridViewTextBoxColumn1.HeaderText = "customersname"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn2.HeaderText = "address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "gst"
        Me.DataGridViewTextBoxColumn3.HeaderText = "gst"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "phone_no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CustomersID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CustomersID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Fcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BGS
        Me.ClientSize = New System.Drawing.Size(1330, 600)
        Me.Controls.Add(Me.TblcustomersDataGridView)
        Me.Controls.Add(CustomersnameLabel)
        Me.Controls.Add(Me.CustomersnameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(GstLabel)
        Me.Controls.Add(Me.GstTextBox)
        Me.Controls.Add(Phone_noLabel)
        Me.Controls.Add(Me.Phone_noTextBox)
        Me.Controls.Add(CustomersIDLabel)
        Me.Controls.Add(Me.CustomersIDTextBox)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fcustomer"
        Me.Text = "Form6"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.TarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents TblcustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcustomersTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblcustomersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tarubnewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomersIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblcustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
