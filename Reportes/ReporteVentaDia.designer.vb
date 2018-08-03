<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentaDia
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
        Me.Reporte_VentaDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet1 = New SISVENTAS.DespensaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reporte_VentaDiaTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Reporte_VentaDiaTableAdapter()
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        CType(Me.Reporte_VentaDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reporte_VentaDiaBindingSource
        '
        Me.Reporte_VentaDiaBindingSource.DataMember = "Reporte_VentaDia"
        Me.Reporte_VentaDiaBindingSource.DataSource = Me.DespensaDataSet1
        '
        'DespensaDataSet1
        '
        Me.DespensaDataSet1.DataSetName = "DespensaDataSet1"
        Me.DespensaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Reporte_VentaDiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(806, 500)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reporte_VentaDiaTableAdapter
        '
        Me.Reporte_VentaDiaTableAdapter.ClearBeforeFill = True
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteVentaDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 408)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteVentaDia"
        Me.Text = "REPORTE VENTA DEL DIA"
        CType(Me.Reporte_VentaDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reporte_VentaDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet1 As SISVENTAS.DespensaDataSet
    Friend WithEvents Reporte_VentaDiaTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Reporte_VentaDiaTableAdapter
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
End Class
