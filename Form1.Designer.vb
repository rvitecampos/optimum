<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Reporte_InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        Me.Reporte_MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Mostrar_ClienesConCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_ClienesConCuentasTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Mostrar_ClienesConCuentasTableAdapter()
        Me.Reporte_InventarioTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Reporte_InventarioTableAdapter()
        Me.Mostrar_ClienesConCuentasTableAdapter1 = New SISVENTAS.DespensaDataSetTableAdapters.Mostrar_ClienesConCuentasTableAdapter()
        Me.Reporte_MesesTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter()
        Me.MostrarclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_clienteTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.mostrar_clienteTableAdapter()
        Me.Mostrar_PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_PagosTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PagosTableAdapter()
        CType(Me.Reporte_InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mostrar_ClienesConCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mostrar_PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reporte_InventarioBindingSource
        '
        Me.Reporte_InventarioBindingSource.DataMember = "Reporte_Inventario"
        Me.Reporte_InventarioBindingSource.DataSource = Me.DespensaDataSet
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reporte_MesesBindingSource
        '
        Me.Reporte_MesesBindingSource.DataMember = "Reporte_Meses"
        Me.Reporte_MesesBindingSource.DataSource = Me.DespensaDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Reporte_InventarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report8.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1037, 605)
        Me.ReportViewer1.TabIndex = 0
        '
        'Mostrar_ClienesConCuentasBindingSource
        '
        Me.Mostrar_ClienesConCuentasBindingSource.DataMember = "Mostrar_ClienesConCuentas"
        Me.Mostrar_ClienesConCuentasBindingSource.DataSource = Me.DespensaDataSet
        '
        'Mostrar_ClienesConCuentasTableAdapter
        '
        Me.Mostrar_ClienesConCuentasTableAdapter.ClearBeforeFill = True
        '
        'Reporte_InventarioTableAdapter
        '
        Me.Reporte_InventarioTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_ClienesConCuentasTableAdapter1
        '
        Me.Mostrar_ClienesConCuentasTableAdapter1.ClearBeforeFill = True
        '
        'Reporte_MesesTableAdapter
        '
        Me.Reporte_MesesTableAdapter.ClearBeforeFill = True
        '
        'MostrarclienteBindingSource
        '
        Me.MostrarclienteBindingSource.DataMember = "mostrar_cliente"
        Me.MostrarclienteBindingSource.DataSource = Me.DespensaDataSet
        '
        'Mostrar_clienteTableAdapter
        '
        Me.Mostrar_clienteTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_PagosBindingSource
        '
        Me.Mostrar_PagosBindingSource.DataMember = "Mostrar_Pagos"
        Me.Mostrar_PagosBindingSource.DataSource = Me.DespensaDataSet
        '
        'Mostrar_PagosTableAdapter
        '
        Me.Mostrar_PagosTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 605)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Reporte_InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mostrar_ClienesConCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mostrar_PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_ClienesConCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
    Friend WithEvents Mostrar_ClienesConCuentasTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Mostrar_ClienesConCuentasTableAdapter
    Friend WithEvents Reporte_InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reporte_InventarioTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Reporte_InventarioTableAdapter
    Friend WithEvents Mostrar_ClienesConCuentasTableAdapter1 As SISVENTAS.DespensaDataSetTableAdapters.Mostrar_ClienesConCuentasTableAdapter
    Friend WithEvents Reporte_MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reporte_MesesTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter
    Friend WithEvents MostrarclienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_clienteTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.mostrar_clienteTableAdapter
    Friend WithEvents Mostrar_PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_PagosTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PagosTableAdapter

End Class
