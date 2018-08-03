<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteComprasCliente
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
        Me.mostrar_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_ventaTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.mostrar_ventaTableAdapter()
        CType(Me.mostrar_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_ventaBindingSource
        '
        Me.mostrar_ventaBindingSource.DataMember = "mostrar_venta"
        Me.mostrar_ventaBindingSource.DataSource = Me.DespensaDataSet
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_ventaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 312)
        Me.ReportViewer1.TabIndex = 0
        '
        'mostrar_ventaTableAdapter
        '
        Me.mostrar_ventaTableAdapter.ClearBeforeFill = True
        '
        'ReporteComprasCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 312)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteComprasCliente"
        Me.Text = "REPORTE COMPRAS DEL CLIENTE"
        CType(Me.mostrar_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_ventaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
    Friend WithEvents mostrar_ventaTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.mostrar_ventaTableAdapter
End Class
