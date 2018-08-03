<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentasACobrar
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
        Me.Mostrar_PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespensaDataSet = New SISVENTAS.DespensaDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCod_cliente = New System.Windows.Forms.TextBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCobrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtMontoACobrar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Mostrar_PagosTableAdapter = New SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PagosTableAdapter()
        Me.TableAdapterManager = New SISVENTAS.DespensaDataSetTableAdapters.TableAdapterManager()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        CType(Me.Mostrar_PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mostrar_PagosBindingSource
        '
        Me.Mostrar_PagosBindingSource.DataMember = "Mostrar_Pagos"
        Me.Mostrar_PagosBindingSource.DataSource = Me.DespensaDataSet
        '
        'DespensaDataSet
        '
        Me.DespensaDataSet.DataSetName = "DespensaDataSet"
        Me.DespensaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCod_cliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 61)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'txtCod_cliente
        '
        Me.txtCod_cliente.Enabled = False
        Me.txtCod_cliente.Location = New System.Drawing.Point(40, 24)
        Me.txtCod_cliente.Name = "txtCod_cliente"
        Me.txtCod_cliente.Size = New System.Drawing.Size(37, 20)
        Me.txtCod_cliente.TabIndex = 75
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(296, 23)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(40, 20)
        Me.BtnBuscarCliente.TabIndex = 78
        Me.BtnBuscarCliente.Text = "..."
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Id:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(148, 24)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(133, 20)
        Me.TxtNombre.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Cliente:"
        '
        'BtnCobrar
        '
        Me.BtnCobrar.Location = New System.Drawing.Point(302, 294)
        Me.BtnCobrar.Name = "BtnCobrar"
        Me.BtnCobrar.Size = New System.Drawing.Size(122, 35)
        Me.BtnCobrar.TabIndex = 77
        Me.BtnCobrar.Text = "&Cobrar"
        Me.BtnCobrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMontoACobrar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 186)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cobrar Cuenta"
        '
        'TxtMontoACobrar
        '
        Me.TxtMontoACobrar.Location = New System.Drawing.Point(120, 131)
        Me.TxtMontoACobrar.Name = "TxtMontoACobrar"
        Me.TxtMontoACobrar.Size = New System.Drawing.Size(133, 20)
        Me.TxtMontoACobrar.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Monto a Cobrar:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Mostrar_PagosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISVENTAS.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(430, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 338)
        Me.ReportViewer1.TabIndex = 81
        '
        'Mostrar_PagosTableAdapter
        '
        Me.Mostrar_PagosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Detalle_CompraTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_GananciaTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_ventaTableAdapter = Nothing
        Me.TableAdapterManager.FondoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISVENTAS.DespensaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(184, 12)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.Size = New System.Drawing.Size(240, 48)
        Me.datalistado.TabIndex = 82
        '
        'FrmCuentasACobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1154, 378)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCobrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmCuentasACobrar"
        Me.Text = "Cuentas a Cobrar"
        CType(Me.Mostrar_PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespensaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnCobrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMontoACobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespensaDataSet As SISVENTAS.DespensaDataSet
    Friend WithEvents Mostrar_PagosTableAdapter As SISVENTAS.DespensaDataSetTableAdapters.Mostrar_PagosTableAdapter
    Friend WithEvents TableAdapterManager As SISVENTAS.DespensaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
End Class
