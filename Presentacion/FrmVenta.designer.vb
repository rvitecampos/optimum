﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
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
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCod_cliente = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.Label()
        Me.datalistadoVenta = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampos = New System.Windows.Forms.ComboBox()
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Venta = New System.Windows.Forms.GroupBox()
        Me.txtLetras = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRefer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpVence = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBoxMoneda = New System.Windows.Forms.ComboBox()
        Me.cmbBoxOper = New System.Windows.Forms.ComboBox()
        Me.TxtCod_venta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        CType(Me.datalistadoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Venta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Enabled = False
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(530, 58)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(40, 30)
        Me.BtnBuscarCliente.TabIndex = 51
        Me.BtnBuscarCliente.Text = "..."
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCerrar.Enabled = False
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCerrar.FlatAppearance.BorderSize = 3
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(492, 588)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(122, 37)
        Me.BtnCerrar.TabIndex = 50
        Me.BtnCerrar.Text = "&Cerrar Factura"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(217, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(307, 29)
        Me.TxtNombre.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Fecha Emisión:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cliente:"
        '
        'txtCod_cliente
        '
        Me.txtCod_cliente.Enabled = False
        Me.txtCod_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod_cliente.Location = New System.Drawing.Point(41, 19)
        Me.txtCod_cliente.Name = "txtCod_cliente"
        Me.txtCod_cliente.Size = New System.Drawing.Size(83, 29)
        Me.txtCod_cliente.TabIndex = 45
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(427, 26)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(133, 29)
        Me.dtpFecha.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Id:"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(241, 265)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 30
        Me.inexistente.Text = "Datos inexistentes"
        '
        'datalistadoVenta
        '
        Me.datalistadoVenta.AllowUserToAddRows = False
        Me.datalistadoVenta.AllowUserToDeleteRows = False
        Me.datalistadoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistadoVenta.Location = New System.Drawing.Point(16, 122)
        Me.datalistadoVenta.Name = "datalistadoVenta"
        Me.datalistadoVenta.ReadOnly = True
        Me.datalistadoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoVenta.Size = New System.Drawing.Size(531, 283)
        Me.datalistadoVenta.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGrabar)
        Me.GroupBox2.Controls.Add(Me.BtnEditar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.Txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampos)
        Me.GroupBox2.Controls.Add(Me.datalistadoVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(634, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 439)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Ventas"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.DarkGray
        Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGrabar.FlatAppearance.BorderSize = 3
        Me.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(185, 83)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(91, 33)
        Me.btnGrabar.TabIndex = 94
        Me.btnGrabar.Text = "G&rabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        Me.btnGrabar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnEditar.Enabled = False
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(17, 81)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(85, 35)
        Me.BtnEditar.TabIndex = 95
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(426, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(121, 37)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Txtbuscar
        '
        Me.Txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbuscar.Location = New System.Drawing.Point(185, 46)
        Me.Txtbuscar.Name = "Txtbuscar"
        Me.Txtbuscar.Size = New System.Drawing.Size(362, 29)
        Me.Txtbuscar.TabIndex = 29
        '
        'cbocampos
        '
        Me.cbocampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocampos.FormattingEnabled = True
        Me.cbocampos.Items.AddRange(New Object() {"Cod_Venta", "Cliente"})
        Me.cbocampos.Location = New System.Drawing.Point(16, 46)
        Me.cbocampos.Name = "cbocampos"
        Me.cbocampos.Size = New System.Drawing.Size(152, 32)
        Me.cbocampos.TabIndex = 1
        Me.cbocampos.Text = "Cod_Venta"
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'Venta
        '
        Me.Venta.Controls.Add(Me.txtLetras)
        Me.Venta.Controls.Add(Me.lblEstado)
        Me.Venta.Controls.Add(Me.Label13)
        Me.Venta.Controls.Add(Me.txtTotal)
        Me.Venta.Controls.Add(Me.Label12)
        Me.Venta.Controls.Add(Me.txtSerie)
        Me.Venta.Controls.Add(Me.Label11)
        Me.Venta.Controls.Add(Me.txtRefer)
        Me.Venta.Controls.Add(Me.Label10)
        Me.Venta.Controls.Add(Me.txtTC)
        Me.Venta.Controls.Add(Me.Label9)
        Me.Venta.Controls.Add(Me.Label8)
        Me.Venta.Controls.Add(Me.Label7)
        Me.Venta.Controls.Add(Me.dtpVence)
        Me.Venta.Controls.Add(Me.Label6)
        Me.Venta.Controls.Add(Me.cmbBoxMoneda)
        Me.Venta.Controls.Add(Me.cmbBoxOper)
        Me.Venta.Controls.Add(Me.TxtCod_venta)
        Me.Venta.Controls.Add(Me.dtpFecha)
        Me.Venta.Controls.Add(Me.Label3)
        Me.Venta.Controls.Add(Me.Label5)
        Me.Venta.Controls.Add(Me.GroupBox1)
        Me.Venta.Location = New System.Drawing.Point(21, 177)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(607, 405)
        Me.Venta.TabIndex = 59
        Me.Venta.TabStop = False
        Me.Venta.Text = "Registro de Venta"
        '
        'txtLetras
        '
        Me.txtLetras.Enabled = False
        Me.txtLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetras.Location = New System.Drawing.Point(75, 362)
        Me.txtLetras.Name = "txtLetras"
        Me.txtLetras.Size = New System.Drawing.Size(515, 29)
        Me.txtLetras.TabIndex = 54
        Me.txtLetras.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(424, 328)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(66, 20)
        Me.lblEstado.TabIndex = 86
        Me.lblEstado.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(343, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Estado"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(75, 327)
        Me.txtTotal.MaxLength = 9
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(128, 29)
        Me.txtTotal.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Total"
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(85, 191)
        Me.txtSerie.MaxLength = 9
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(128, 29)
        Me.txtSerie.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Serie"
        '
        'txtRefer
        '
        Me.txtRefer.Enabled = False
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.Location = New System.Drawing.Point(416, 191)
        Me.txtRefer.MaxLength = 9
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(128, 29)
        Me.txtRefer.TabIndex = 80
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(294, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Número de Referencia"
        '
        'txtTC
        '
        Me.txtTC.Enabled = False
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.Location = New System.Drawing.Point(457, 239)
        Me.txtTC.MaxLength = 9
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(83, 29)
        Me.txtTC.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(424, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "T.C."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Tipo Operación"
        '
        'dtpVence
        '
        Me.dtpVence.Enabled = False
        Me.dtpVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVence.Location = New System.Drawing.Point(268, 284)
        Me.dtpVence.Name = "dtpVence"
        Me.dtpVence.Size = New System.Drawing.Size(133, 29)
        Me.dtpVence.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Fecha Vencimiento:"
        '
        'cmbBoxMoneda
        '
        Me.cmbBoxMoneda.Enabled = False
        Me.cmbBoxMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxMoneda.FormattingEnabled = True
        Me.cmbBoxMoneda.Items.AddRange(New Object() {"S/.", "$", "€"})
        Me.cmbBoxMoneda.Location = New System.Drawing.Point(346, 238)
        Me.cmbBoxMoneda.Name = "cmbBoxMoneda"
        Me.cmbBoxMoneda.Size = New System.Drawing.Size(56, 32)
        Me.cmbBoxMoneda.TabIndex = 34
        Me.cmbBoxMoneda.Text = "S/."
        '
        'cmbBoxOper
        '
        Me.cmbBoxOper.DropDownWidth = 56
        Me.cmbBoxOper.Enabled = False
        Me.cmbBoxOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxOper.FormattingEnabled = True
        Me.cmbBoxOper.Items.AddRange(New Object() {"Venta Interna"})
        Me.cmbBoxOper.Location = New System.Drawing.Point(116, 238)
        Me.cmbBoxOper.Name = "cmbBoxOper"
        Me.cmbBoxOper.Size = New System.Drawing.Size(152, 32)
        Me.cmbBoxOper.TabIndex = 33
        Me.cmbBoxOper.Text = "Venta Interna"
        '
        'TxtCod_venta
        '
        Me.TxtCod_venta.Enabled = False
        Me.TxtCod_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod_venta.Location = New System.Drawing.Point(100, 27)
        Me.TxtCod_venta.Name = "TxtCod_venta"
        Me.TxtCod_venta.Size = New System.Drawing.Size(82, 29)
        Me.TxtCod_venta.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Codigo Venta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCod_cliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 108)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Ruc:"
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(41, 59)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(118, 29)
        Me.txtRuc.TabIndex = 53
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.FlatAppearance.BorderSize = 3
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Location = New System.Drawing.Point(196, 588)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(122, 37)
        Me.btnRegistrar.TabIndex = 76
        Me.btnRegistrar.Text = "R&egistrar Cabecera"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISVENTAS.My.Resources.Resources.REGISTRO_VENTA
        Me.PictureBox1.Location = New System.Drawing.Point(196, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(871, 126)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.FlatAppearance.BorderSize = 3
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(44, 588)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(124, 37)
        Me.BtnNuevo.TabIndex = 92
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.Enabled = False
        Me.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.FlatAppearance.BorderSize = 3
        Me.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Location = New System.Drawing.Point(340, 588)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(122, 37)
        Me.btnAñadir.TabIndex = 93
        Me.btnAñadir.Text = "&Añadir Detalle"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1246, 644)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Name = "FrmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA"
        CType(Me.datalistadoVenta,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.Erroricono,System.ComponentModel.ISupportInitialize).EndInit
        Me.Venta.ResumeLayout(false)
        Me.Venta.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BtnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inexistente As System.Windows.Forms.Label
    Friend WithEvents datalistadoVenta As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampos As System.Windows.Forms.ComboBox
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents Venta As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCod_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbBoxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBoxOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLetras As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
End Class
