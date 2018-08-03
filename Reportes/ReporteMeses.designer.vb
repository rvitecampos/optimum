<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMeses
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Reporte_MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet2 = New SISVENTAS.DespensaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reporte_MesesTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter()
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reporte_MesesBindingSource
        '
        Me.Reporte_MesesBindingSource.DataMember = "Reporte_Meses"
        Me.Reporte_MesesBindingSource.DataSource = Me.DespensaDataSet2
        '
        'DespensaDataSet2
        '
        Me.DespensaDataSet2.DataSetName = "DespensaDataSet2"
        Me.DespensaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Reporte_MesesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(813, 486)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reporte_MesesTableAdapter
        '
        Me.Reporte_MesesTableAdapter.ClearBeforeFill = True
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteMeses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 486)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteMeses"
        Me.Text = "REPORTE MESES"
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reporte_MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet2 As SISVENTAS.DespensaDataSet
    Friend WithEvents Reporte_MesesTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
End Class
