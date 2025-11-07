<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print3
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tarubnewDataSet = New WindowsApplication1.tarubnewDataSet()
        Me.tbladptinprintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbladptinprintTableAdapter = New WindowsApplication1.tarubnewDataSetTableAdapters.tbladptinprintTableAdapter()
        CType(Me.tarubnewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbladptinprintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbladptinprintBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(866, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'tarubnewDataSet
        '
        Me.tarubnewDataSet.DataSetName = "tarubnewDataSet"
        Me.tarubnewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbladptinprintBindingSource
        '
        Me.tbladptinprintBindingSource.DataMember = "tbladptinprint"
        Me.tbladptinprintBindingSource.DataSource = Me.tarubnewDataSet
        '
        'tbladptinprintTableAdapter
        '
        Me.tbladptinprintTableAdapter.ClearBeforeFill = True
        '
        'print3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 492)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "print3"
        Me.Text = "print3"
        CType(Me.tarubnewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbladptinprintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbladptinprintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tarubnewDataSet As WindowsApplication1.tarubnewDataSet
    Friend WithEvents tbladptinprintTableAdapter As WindowsApplication1.tarubnewDataSetTableAdapters.tbladptinprintTableAdapter
End Class
