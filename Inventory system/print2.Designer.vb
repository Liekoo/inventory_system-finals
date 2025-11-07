<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print2
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.tbladptoutprintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbladptoutprintTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbladptoutprintTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblstocksTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter()
        CType(Me.tarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbladptoutprintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tarubnewDataSet
        '
        Me.tarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.tarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbladptoutprintBindingSource
        '
        Me.tbladptoutprintBindingSource.DataMember = "tbladptoutprint"
        Me.tbladptoutprintBindingSource.DataSource = Me.tarubnewDataSet
        '
        'tbladptoutprintTableAdapter
        '
        Me.tbladptoutprintTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.tblstocksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1043, 614)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblstocksBindingSource
        '
        Me.tblstocksBindingSource.DataMember = "tblstocks"
        Me.tblstocksBindingSource.DataSource = Me.tarubnewDataSet
        '
        'tblstocksTableAdapter
        '
        Me.tblstocksTableAdapter.ClearBeforeFill = True
        '
        'print2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 614)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "print2"
        Me.Text = "print2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbladptoutprintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbladptoutprintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents tbladptoutprintTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbladptoutprintTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblstocksTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tblstocksTableAdapter
End Class
