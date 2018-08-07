<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDelDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeMesesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCuentasACobrar = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnFondo = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.UtileriasToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1589, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CapturaToolStripMenuItem
        '
        Me.CapturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.VentaToolStripMenuItem})
        Me.CapturaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapturaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CapturaToolStripMenuItem.Name = "CapturaToolStripMenuItem"
        Me.CapturaToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CapturaToolStripMenuItem.Text = "&Movimientos"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ClienteToolStripMenuItem.Text = "&Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProductoToolStripMenuItem.Text = "&Productos"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProveedorToolStripMenuItem.Text = "&Proveedores"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.VentaToolStripMenuItem.Text = "&Ventas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDelDiaToolStripMenuItem, Me.ExistenciaToolStripMenuItem, Me.VentaDeMesesToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.CuentasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentaDelDiaToolStripMenuItem
        '
        Me.VentaDelDiaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaDelDiaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.VentaDelDiaToolStripMenuItem.Name = "VentaDelDiaToolStripMenuItem"
        Me.VentaDelDiaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.VentaDelDiaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VentaDelDiaToolStripMenuItem.Text = "&Venta del dia"
        '
        'ExistenciaToolStripMenuItem
        '
        Me.ExistenciaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ExistenciaToolStripMenuItem.Name = "ExistenciaToolStripMenuItem"
        Me.ExistenciaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExistenciaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExistenciaToolStripMenuItem.Text = "&Existencia"
        '
        'VentaDeMesesToolStripMenuItem
        '
        Me.VentaDeMesesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaDeMesesToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.VentaDeMesesToolStripMenuItem.Name = "VentaDeMesesToolStripMenuItem"
        Me.VentaDeMesesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VentaDeMesesToolStripMenuItem.Text = "Venta de Meses"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresosToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreciosToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuentasToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiaDeSeguridadToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CopiaDeSeguridadToolStripMenuItem
        '
        Me.CopiaDeSeguridadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopiaDeSeguridadToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CopiaDeSeguridadToolStripMenuItem.Name = "CopiaDeSeguridadToolStripMenuItem"
        Me.CopiaDeSeguridadToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CopiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'UtileriasToolStripMenuItem
        '
        Me.UtileriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.UtileriasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtileriasToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.UtileriasToolStripMenuItem.Name = "UtileriasToolStripMenuItem"
        Me.UtileriasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.UtileriasToolStripMenuItem.Text = "&Utilerias"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'BtnCuentasACobrar
        '
        Me.BtnCuentasACobrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCuentasACobrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCuentasACobrar.FlatAppearance.BorderSize = 0
        Me.BtnCuentasACobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCuentasACobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnCuentasACobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCuentasACobrar.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.BtnCuentasACobrar.ForeColor = System.Drawing.Color.White
        Me.BtnCuentasACobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCuentasACobrar.Location = New System.Drawing.Point(932, 399)
        Me.BtnCuentasACobrar.Name = "BtnCuentasACobrar"
        Me.BtnCuentasACobrar.Size = New System.Drawing.Size(304, 104)
        Me.BtnCuentasACobrar.TabIndex = 3
        Me.BtnCuentasACobrar.Text = "CUENTAS A COBRAR"
        Me.BtnCuentasACobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCuentasACobrar.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(1218, 475)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(19, 18)
        Me.datalistado.TabIndex = 13
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(1321, 467)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(116, 20)
        Me.txtLogin.TabIndex = 52
        Me.txtLogin.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(1321, 493)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(116, 20)
        Me.txtPassword.TabIndex = 52
        Me.txtPassword.Visible = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblUsuario.Location = New System.Drawing.Point(10, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(96, 20)
        Me.LblUsuario.TabIndex = 54
        Me.LblUsuario.Text = "CJUNQUEZ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Nombres:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(167, 48)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(61, 20)
        Me.LblNombre.TabIndex = 54
        Me.LblNombre.Text = "Junnior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Apellidos:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblApellido.Location = New System.Drawing.Point(167, 101)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(56, 20)
        Me.LblApellido.TabIndex = 54
        Me.LblApellido.Text = "Castro"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCategoria)
        Me.GroupBox1.Controls.Add(Me.LblApellido)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblNombre)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(1122, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 169)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoria.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblCategoria.Location = New System.Drawing.Point(167, 136)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(20, 20)
        Me.LblCategoria.TabIndex = 56
        Me.LblCategoria.Text = "A"
        '
        'imagen
        '
        Me.imagen.Image = Global.SISVENTAS.My.Resources.Resources.AVATAR1
        Me.imagen.Location = New System.Drawing.Point(27, 28)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(133, 128)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen.TabIndex = 51
        Me.imagen.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHora.Location = New System.Drawing.Point(1484, 19)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(96, 25)
        Me.lblHora.TabIndex = 57
        Me.lblHora.Text = "18:50:12"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnFondo
        '
        Me.btnFondo.BackColor = System.Drawing.Color.Transparent
        Me.btnFondo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFondo.FlatAppearance.BorderSize = 0
        Me.btnFondo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFondo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFondo.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFondo.ForeColor = System.Drawing.Color.White
        Me.btnFondo.Image = Global.SISVENTAS.My.Resources.Resources.CLIENTE
        Me.btnFondo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFondo.Location = New System.Drawing.Point(14, 528)
        Me.btnFondo.Name = "btnFondo"
        Me.btnFondo.Size = New System.Drawing.Size(304, 104)
        Me.btnFondo.TabIndex = 3
        Me.btnFondo.Text = "FONDO"
        Me.btnFondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFondo.UseVisualStyleBackColor = False
        Me.btnFondo.Visible = False
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.BtnProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnProveedor.Image = Global.SISVENTAS.My.Resources.Resources.PROVEEDORES11
        Me.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProveedor.Location = New System.Drawing.Point(932, 275)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(304, 104)
        Me.BtnProveedor.TabIndex = 3
        Me.BtnProveedor.Text = "PROVEEDORES"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.Transparent
        Me.btnComprar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Image = Global.SISVENTAS.My.Resources.Resources.COMPRA
        Me.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComprar.Location = New System.Drawing.Point(618, 399)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(287, 104)
        Me.btnComprar.TabIndex = 3
        Me.btnComprar.Text = "COMPRAS"
        Me.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.White
        Me.BtnVentas.Image = Global.SISVENTAS.My.Resources.Resources.VENTA
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentas.Location = New System.Drawing.Point(324, 399)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(265, 104)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "VENTAS"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnProducto
        '
        Me.BtnProducto.BackColor = System.Drawing.Color.Transparent
        Me.BtnProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnProducto.FlatAppearance.BorderSize = 0
        Me.BtnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducto.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.BtnProducto.ForeColor = System.Drawing.Color.White
        Me.BtnProducto.Image = Global.SISVENTAS.My.Resources.Resources.PRODUCTOS
        Me.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProducto.Location = New System.Drawing.Point(618, 275)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(287, 104)
        Me.BtnProducto.TabIndex = 3
        Me.BtnProducto.Text = "PRODUCTOS"
        Me.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducto.UseVisualStyleBackColor = False
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.Transparent
        Me.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCliente.Image = Global.SISVENTAS.My.Resources.Resources.CLIENTES
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.Location = New System.Drawing.Point(324, 275)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(265, 104)
        Me.BtnCliente.TabIndex = 3
        Me.BtnCliente.Text = "CLIENTES"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SISVENTAS.My.Resources.Resources.OPTIMUM2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1589, 704)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1589, 704)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnFondo)
        Me.Controls.Add(Me.BtnCuentasACobrar)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.BtnProducto)
        Me.Controls.Add(Me.BtnCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SisOptimum"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CapturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaDelDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtileriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnProducto As System.Windows.Forms.Button
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnVentas As System.Windows.Forms.Button
    Friend WithEvents btnComprar As System.Windows.Forms.Button
    Friend WithEvents btnFondo As System.Windows.Forms.Button
    Friend WithEvents VentaDeMesesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCuentasACobrar As System.Windows.Forms.Button
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiaDeSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
