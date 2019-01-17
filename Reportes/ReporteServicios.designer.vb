<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteServicios
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
        Me.Servicio_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Servicio_ItemsTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Servicio_ItemsTableAdapter()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.Servicio_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Servicio_ItemsBindingSource
        '
        Me.Servicio_ItemsBindingSource.DataMember = "Servicio_Items"
        Me.Servicio_ItemsBindingSource.DataSource = Me.DespensaDataSet
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Servicio_ItemsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 89)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(642, 339)
        Me.ReportViewer1.TabIndex = 0
        '
        'Servicio_ItemsTableAdapter
        '
        Me.Servicio_ItemsTableAdapter.ClearBeforeFill = True
        '
        'cmbServicio
        '
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(80, 31)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(155, 21)
        Me.cmbServicio.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(301, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(106, 26)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ReporteServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 451)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteServicios"
        Me.Text = "ReporteServicios"
        CType(Me.Servicio_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Servicio_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
    Friend WithEvents Servicio_ItemsTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Servicio_ItemsTableAdapter
    Friend WithEvents cmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
