﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsServicios
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
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.inexistente = New System.Windows.Forms.Label()
        Me.Txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampos = New System.Windows.Forms.ComboBox()
        Me.datalistadoStockServicio = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtCodProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCtdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMovimientos = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.txtSPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.TxtCodProveedor = New System.Windows.Forms.TextBox()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTxtServicio = New System.Windows.Forms.Label()
        Me.lblCodServicio = New System.Windows.Forms.Label()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistadoStockServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(265, 283)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 30
        Me.inexistente.Text = "Datos inexistentes"
        '
        'Txtbuscar
        '
        Me.Txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbuscar.Location = New System.Drawing.Point(199, 26)
        Me.Txtbuscar.Name = "Txtbuscar"
        Me.Txtbuscar.Size = New System.Drawing.Size(361, 29)
        Me.Txtbuscar.TabIndex = 13
        '
        'cbocampos
        '
        Me.cbocampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocampos.FormattingEnabled = True
        Me.cbocampos.Items.AddRange(New Object() {"Nombre_Producto", "Cod_Producto", "Cood_Proveedor"})
        Me.cbocampos.Location = New System.Drawing.Point(29, 26)
        Me.cbocampos.Name = "cbocampos"
        Me.cbocampos.Size = New System.Drawing.Size(164, 32)
        Me.cbocampos.TabIndex = 1
        Me.cbocampos.Text = "Cod_Producto"
        '
        'datalistadoStockServicio
        '
        Me.datalistadoStockServicio.AllowUserToAddRows = False
        Me.datalistadoStockServicio.AllowUserToDeleteRows = False
        Me.datalistadoStockServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoStockServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistadoStockServicio.Location = New System.Drawing.Point(29, 102)
        Me.datalistadoStockServicio.Name = "datalistadoStockServicio"
        Me.datalistadoStockServicio.ReadOnly = True
        Me.datalistadoStockServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoStockServicio.Size = New System.Drawing.Size(531, 343)
        Me.datalistadoStockServicio.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(29, 71)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 14
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        Me.cbeliminar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.Txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampos)
        Me.GroupBox2.Controls.Add(Me.datalistadoStockServicio)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(659, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 464)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Productos"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(475, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(108, 61)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 35)
        Me.BtnEliminar.TabIndex = 15
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.Enabled = False
        Me.TxtCodProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProducto.Location = New System.Drawing.Point(118, 26)
        Me.TxtCodProducto.MaxLength = 13
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(486, 29)
        Me.TxtCodProducto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Codigo Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Precio Unitario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCtdad)
        Me.GroupBox1.Controls.Add(Me.TxtCodProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.txtLimite)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 192)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de Movimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(346, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Ctdad:"
        '
        'txtCtdad
        '
        Me.txtCtdad.Enabled = False
        Me.txtCtdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtdad.Location = New System.Drawing.Point(391, 105)
        Me.txtCtdad.MaxLength = 18
        Me.txtCtdad.Name = "txtCtdad"
        Me.txtCtdad.Size = New System.Drawing.Size(141, 29)
        Me.txtCtdad.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Limite:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Stock:"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(118, 67)
        Me.TxtNombreProducto.MaxLength = 20
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(486, 29)
        Me.TxtNombreProducto.TabIndex = 2
        '
        'txtLimite
        '
        Me.txtLimite.Enabled = False
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.Location = New System.Drawing.Point(118, 148)
        Me.txtLimite.MaxLength = 18
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(141, 29)
        Me.txtLimite.TabIndex = 4
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(118, 105)
        Me.txtStock.MaxLength = 18
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(141, 29)
        Me.txtStock.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Segundo Precio:"
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Location = New System.Drawing.Point(326, 564)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Size = New System.Drawing.Size(75, 31)
        Me.btnMovimientos.TabIndex = 7
        Me.btnMovimientos.Text = "Movimientos"
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Proveedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Cod Proveedor:"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Enabled = False
        Me.TxtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(272, 19)
        Me.TxtProveedor.MaxLength = 30
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(332, 29)
        Me.TxtProveedor.TabIndex = 6
        '
        'txtSPrecioUnitario
        '
        Me.txtSPrecioUnitario.Enabled = False
        Me.txtSPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPrecioUnitario.Location = New System.Drawing.Point(390, 17)
        Me.txtSPrecioUnitario.MaxLength = 18
        Me.txtSPrecioUnitario.Name = "txtSPrecioUnitario"
        Me.txtSPrecioUnitario.Size = New System.Drawing.Size(185, 29)
        Me.txtSPrecioUnitario.TabIndex = 9
        '
        'TxtCodProveedor
        '
        Me.TxtCodProveedor.Enabled = False
        Me.TxtCodProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProveedor.Location = New System.Drawing.Point(118, 19)
        Me.TxtCodProveedor.MaxLength = 10
        Me.TxtCodProveedor.Name = "TxtCodProveedor"
        Me.TxtCodProveedor.Size = New System.Drawing.Size(74, 29)
        Me.TxtCodProveedor.TabIndex = 5
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.Enabled = False
        Me.TxtPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(116, 18)
        Me.TxtPrecioUnitario.MaxLength = 18
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(171, 29)
        Me.TxtPrecioUnitario.TabIndex = 8
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.FlatAppearance.BorderSize = 3
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(40, 557)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(85, 46)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "&Añadir"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(377, 138)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(40, 20)
        Me.txtflag.TabIndex = 51
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtCodProveedor)
        Me.GroupBox4.Controls.Add(Me.TxtProveedor)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 413)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(625, 60)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedor"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxtPrecioUnitario)
        Me.GroupBox5.Controls.Add(Me.txtSPrecioUnitario)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(28, 480)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(626, 61)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Precios"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "(Venta)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "(Costo)"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SISVENTAS.My.Resources.Resources.Items_Servicios
        Me.PictureBox3.Location = New System.Drawing.Point(189, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(916, 120)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 113
        Me.PictureBox3.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.FlatAppearance.BorderSize = 3
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(164, 557)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 45)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(36, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "SERVICIO"
        '
        'lblTxtServicio
        '
        Me.lblTxtServicio.AutoSize = True
        Me.lblTxtServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtServicio.Location = New System.Drawing.Point(233, 169)
        Me.lblTxtServicio.Name = "lblTxtServicio"
        Me.lblTxtServicio.Size = New System.Drawing.Size(82, 22)
        Me.lblTxtServicio.TabIndex = 114
        Me.lblTxtServicio.Text = "Label13"
        '
        'lblCodServicio
        '
        Me.lblCodServicio.AutoSize = True
        Me.lblCodServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodServicio.Location = New System.Drawing.Point(138, 169)
        Me.lblCodServicio.Name = "lblCodServicio"
        Me.lblCodServicio.Size = New System.Drawing.Size(82, 22)
        Me.lblCodServicio.TabIndex = 115
        Me.lblCodServicio.Text = "Label13"
        '
        'itemsServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1253, 633)
        Me.Controls.Add(Me.lblCodServicio)
        Me.Controls.Add(Me.lblTxtServicio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.btnMovimientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "itemsServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistadoStockServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents inexistente As System.Windows.Forms.Label
    Friend WithEvents Txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampos As System.Windows.Forms.ComboBox
    Friend WithEvents datalistadoStockServicio As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCodProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnMovimientos As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodProveedor As System.Windows.Forms.TextBox
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCtdad As System.Windows.Forms.TextBox
    Friend WithEvents lblTxtServicio As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCodServicio As System.Windows.Forms.Label
End Class
