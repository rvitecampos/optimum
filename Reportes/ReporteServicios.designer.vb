<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteServicios
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
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Reporte_MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reporte_MesesTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter()
        Me.Mostrar_PersonasCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_PersonasCuentasTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PersonasCuentasTableAdapter()
        Me.ServiciosTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.ServiciosTableAdapter()
        Me.mostrar_serviciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_serviciosTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.mostrar_serviciosTableAdapter()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mostrar_PersonasCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_serviciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.DespensaDataSet
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_serviciosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 431)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmbServicio
        '
        Me.cmbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(149, 24)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(153, 21)
        Me.cmbServicio.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(343, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 26)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Reporte_MesesBindingSource
        '
        Me.Reporte_MesesBindingSource.DataMember = "Reporte_Meses"
        Me.Reporte_MesesBindingSource.DataSource = Me.DespensaDataSet
        '
        'Reporte_MesesTableAdapter
        '
        Me.Reporte_MesesTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_PersonasCuentasBindingSource
        '
        Me.Mostrar_PersonasCuentasBindingSource.DataMember = "Mostrar_PersonasCuentas"
        Me.Mostrar_PersonasCuentasBindingSource.DataSource = Me.DespensaDataSet
        '
        'Mostrar_PersonasCuentasTableAdapter
        '
        Me.Mostrar_PersonasCuentasTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'mostrar_serviciosBindingSource
        '
        Me.mostrar_serviciosBindingSource.DataMember = "mostrar_servicios"
        Me.mostrar_serviciosBindingSource.DataSource = Me.DespensaDataSet
        '
        'mostrar_serviciosTableAdapter
        '
        Me.mostrar_serviciosTableAdapter.ClearBeforeFill = True
        '
        'ReporteServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 517)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteServicios"
        Me.Text = "SERVICIOS"
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporte_MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mostrar_PersonasCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_serviciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Reporte_MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
    Friend WithEvents Reporte_MesesTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Reporte_MesesTableAdapter
    Friend WithEvents Mostrar_PersonasCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_PersonasCuentasTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PersonasCuentasTableAdapter
    Friend WithEvents ServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiciosTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents mostrar_serviciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mostrar_serviciosTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.mostrar_serviciosTableAdapter
End Class
