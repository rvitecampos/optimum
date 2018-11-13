<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Venta
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
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.Txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampos = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.Label()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.datalistadoDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnbuscarProducto = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.txtcod_Servicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCod_venta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.txt_total_a_pagar = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetalle3 = New System.Windows.Forms.TextBox()
        Me.txtDetalle2 = New System.Windows.Forms.TextBox()
        Me.txtDetalle1 = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPUnitario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPVenta = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistadoDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(22, 71)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 38
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'Txtbuscar
        '
        Me.Txtbuscar.Location = New System.Drawing.Point(163, 26)
        Me.Txtbuscar.Name = "Txtbuscar"
        Me.Txtbuscar.Size = New System.Drawing.Size(390, 20)
        Me.Txtbuscar.TabIndex = 29
        '
        'cbocampos
        '
        Me.cbocampos.FormattingEnabled = True
        Me.cbocampos.Items.AddRange(New Object() {"Cood_Servicio"})
        Me.cbocampos.Location = New System.Drawing.Point(22, 26)
        Me.cbocampos.Name = "cbocampos"
        Me.cbocampos.Size = New System.Drawing.Size(121, 21)
        Me.cbocampos.TabIndex = 1
        Me.cbocampos.Text = "Cood_Servicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.BtnVender)
        Me.GroupBox2.Controls.Add(Me.Txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampos)
        Me.GroupBox2.Controls.Add(Me.datalistadoDetalleVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(654, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 468)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Detalle"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(457, 60)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 35)
        Me.btnBuscar.TabIndex = 114
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(90, 60)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 35)
        Me.BtnEliminar.TabIndex = 113
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 34)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "CALCULADORA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(249, 238)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 30
        Me.inexistente.Text = "Datos inexistentes"
        '
        'BtnVender
        '
        Me.BtnVender.Location = New System.Drawing.Point(257, 418)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(85, 35)
        Me.BtnVender.TabIndex = 5
        Me.BtnVender.Text = "&Salir"
        Me.BtnVender.UseVisualStyleBackColor = True
        '
        'datalistadoDetalleVenta
        '
        Me.datalistadoDetalleVenta.AllowUserToAddRows = False
        Me.datalistadoDetalleVenta.AllowUserToDeleteRows = False
        Me.datalistadoDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistadoDetalleVenta.Location = New System.Drawing.Point(22, 102)
        Me.datalistadoDetalleVenta.Name = "datalistadoDetalleVenta"
        Me.datalistadoDetalleVenta.ReadOnly = True
        Me.datalistadoDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoDetalleVenta.Size = New System.Drawing.Size(531, 299)
        Me.datalistadoDetalleVenta.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'btnbuscarProducto
        '
        Me.btnbuscarProducto.Location = New System.Drawing.Point(518, 26)
        Me.btnbuscarProducto.Name = "btnbuscarProducto"
        Me.btnbuscarProducto.Size = New System.Drawing.Size(40, 20)
        Me.btnbuscarProducto.TabIndex = 7
        Me.btnbuscarProducto.Text = "..."
        Me.btnbuscarProducto.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(13, 361)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(584, 35)
        Me.BtnAgregar.TabIndex = 16
        Me.BtnAgregar.Text = "&Agregar Articulo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Enabled = False
        Me.txtNombreServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreServicio.Location = New System.Drawing.Point(209, 19)
        Me.txtNombreServicio.MaxLength = 49
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(289, 29)
        Me.txtNombreServicio.TabIndex = 6
        '
        'txtcod_Servicio
        '
        Me.txtcod_Servicio.Enabled = False
        Me.txtcod_Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod_Servicio.Location = New System.Drawing.Point(77, 19)
        Me.txtcod_Servicio.Name = "txtcod_Servicio"
        Me.txtcod_Servicio.Size = New System.Drawing.Size(99, 29)
        Me.txtcod_Servicio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Servicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Codigo Venta:"
        '
        'TxtCod_venta
        '
        Me.TxtCod_venta.Enabled = False
        Me.TxtCod_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod_venta.Location = New System.Drawing.Point(90, 17)
        Me.TxtCod_venta.Name = "TxtCod_venta"
        Me.TxtCod_venta.Size = New System.Drawing.Size(63, 29)
        Me.TxtCod_venta.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Precio Venta"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(71, 93)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(40, 20)
        Me.txtflag.TabIndex = 85
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'txt_total_a_pagar
        '
        Me.txt_total_a_pagar.Enabled = False
        Me.txt_total_a_pagar.Location = New System.Drawing.Point(157, 226)
        Me.txt_total_a_pagar.Name = "txt_total_a_pagar"
        Me.txt_total_a_pagar.Size = New System.Drawing.Size(133, 20)
        Me.txt_total_a_pagar.TabIndex = 87
        Me.txt_total_a_pagar.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(151, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 69
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(81, 55)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(74, 29)
        Me.txtcantidad.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDetalle3)
        Me.GroupBox1.Controls.Add(Me.txtDetalle2)
        Me.GroupBox1.Controls.Add(Me.txtDetalle1)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtCod_venta)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 468)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Venta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Detalle3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Detalle2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Detalle1"
        '
        'txtDetalle3
        '
        Me.txtDetalle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle3.Location = New System.Drawing.Point(223, 197)
        Me.txtDetalle3.MaxLength = 49
        Me.txtDetalle3.Name = "txtDetalle3"
        Me.txtDetalle3.Size = New System.Drawing.Size(289, 29)
        Me.txtDetalle3.TabIndex = 10
        '
        'txtDetalle2
        '
        Me.txtDetalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle2.Location = New System.Drawing.Point(222, 162)
        Me.txtDetalle2.MaxLength = 49
        Me.txtDetalle2.Name = "txtDetalle2"
        Me.txtDetalle2.Size = New System.Drawing.Size(289, 29)
        Me.txtDetalle2.TabIndex = 9
        '
        'txtDetalle1
        '
        Me.txtDetalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle1.Location = New System.Drawing.Point(222, 127)
        Me.txtDetalle1.MaxLength = 49
        Me.txtDetalle1.Name = "txtDetalle1"
        Me.txtDetalle1.Size = New System.Drawing.Size(289, 29)
        Me.txtDetalle1.TabIndex = 8
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(312, 17)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(63, 29)
        Me.txtCodCliente.TabIndex = 3
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(381, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(216, 29)
        Me.txtCliente.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Cliente"
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(198, 17)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(63, 29)
        Me.txtSerie.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Serie:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPUnitario)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtIGV)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtPTotal)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtPVenta)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 241)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(584, 103)
        Me.GroupBox5.TabIndex = 89
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cantidad y Precio"
        '
        'txtPUnitario
        '
        Me.txtPUnitario.Enabled = False
        Me.txtPUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPUnitario.Location = New System.Drawing.Point(80, 16)
        Me.txtPUnitario.Name = "txtPUnitario"
        Me.txtPUnitario.Size = New System.Drawing.Size(105, 29)
        Me.txtPUnitario.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Precio Unitario"
        '
        'txtIGV
        '
        Me.txtIGV.Enabled = False
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.Location = New System.Drawing.Point(258, 16)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(74, 29)
        Me.txtIGV.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(207, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "IGV:"
        '
        'txtPTotal
        '
        Me.txtPTotal.Enabled = False
        Me.txtPTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPTotal.Location = New System.Drawing.Point(454, 54)
        Me.txtPTotal.Name = "txtPTotal"
        Me.txtPTotal.Size = New System.Drawing.Size(104, 29)
        Me.txtPTotal.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(371, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Precio Total"
        '
        'txtPVenta
        '
        Me.txtPVenta.Enabled = False
        Me.txtPVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVenta.Location = New System.Drawing.Point(258, 53)
        Me.txtPVenta.Name = "txtPVenta"
        Me.txtPVenta.Size = New System.Drawing.Size(105, 29)
        Me.txtPVenta.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtcod_Servicio)
        Me.GroupBox4.Controls.Add(Me.btnbuscarProducto)
        Me.GroupBox4.Controls.Add(Me.txtNombreServicio)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(584, 68)
        Me.GroupBox4.TabIndex = 89
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Servicio"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISVENTAS.My.Resources.Resources.DETALLECOMPRA
        Me.PictureBox1.Location = New System.Drawing.Point(152, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(987, 126)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'Detalle_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Detalle_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE VENTA"
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistadoDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents inexistente As System.Windows.Forms.Label
    Friend WithEvents Txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampos As System.Windows.Forms.ComboBox
    Friend WithEvents datalistadoDetalleVenta As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnbuscarProducto As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtNombreServicio As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_Servicio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCod_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnVender As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_a_pagar As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle1 As System.Windows.Forms.TextBox
End Class
