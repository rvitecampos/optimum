
Public Class frmPrincipal
    Dim dt As New DataTable

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        Cliente.ShowDialog()
        'Muestra el Formulario
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir de SisOptimum", MsgBoxStyle.Question + vbYesNo, "¿Salir?") = vbYes Then
            End
        Else

        End If

        'Salir del sistema

    End Sub

    Private Sub BtnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProducto.Click
        Productos.ShowDialog()
    End Sub


    'Sub ocultar()
    '    PictureBox1.Visible = False
    '    BtnCliente.Visible = False
    '    BtnProducto.Visible = False
    '    BtnVentas.Visible = False
    '    BtnProveedor.Visible = False
    '    btnComprar.Visible = False
    '    btnFondo.Visible = False
    'End Sub

    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        Cliente.ShowDialog()
    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        FrmVenta.ShowDialog()

    End Sub


    Private Sub btnComprar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComprar.Click
        frmCompra.ShowDialog()
    End Sub

    Private Sub btnFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFondo.Click
        FrmFondo.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        Productos.ShowDialog()

    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        FrmVenta.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("Cualquier problema de SisOptimum, Consultas al 920523590", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaToolStripMenuItem.Click
        ReporteInventario.Show()

    End Sub

    'Private Sub BtnCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnCliente.MouseMove
    '    Dim x As String
    '    x = "<invoke name=""FlashFunction"" returntype=""xml"">"
    '    x = x & "<arguments>"
    '    x = x & "<object>"
    '    x = x & "<property id='arg1'><string>value1</string></property>"
    '    x = x & "<property id='arg2'><string>value2</string></property>"
    '    x = x & "</object>"
    '    x = x & "</arguments>"
    '    x = x & "</invoke>"

    '    Dim r As String
    '    r = AxShockwaveFlash1.CallFunction(x)
    '    ' r is result passed back from Flash (XML in stirng format)
    '    MsgBox(r, vbInformation, "FlashFunction called, result from Flash")

    'End Sub

    Private Sub VentaDelDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDelDiaToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            ReporteVentaDia.ShowDialog()
        End If
    End Sub

    Private Sub VentaDeMesesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDeMesesToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            FrmReporteMeses.Show()
        End If
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then

            Reporte_Ingresos.ShowDialog()
        End If

    End Sub
    Sub mostrar()

        Dim func As New fUsuario

        Dim dts As New VUsuario

        dts.glogin = txtLogin.Text
        dts.gpassword = txtPassword.Text
        dt = func.mostrar_activo(dts)
        datalistado.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistado.DataSource = dt

            datalistado.ColumnHeadersVisible = True

        Else
            datalistado.DataSource = Nothing

            datalistado.ColumnHeadersVisible = False

        End If
    End Sub


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Text = TimeOfDay
        mostrar()
        LblUsuario.Text = datalistado.SelectedCells.Item(1).Value
        LblNombre.Text = datalistado.SelectedCells.Item(2).Value
        LblApellido.Text = datalistado.SelectedCells.Item(3).Value
        LblCategoria.Text = datalistado.SelectedCells.Item(5).Value
        If LblCategoria.Text = "A" Then
            LblCategoria.Text = "Administrador"
        Else
            LblCategoria.Text = "Operador"
        End If


        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(4).Value

        If b.Length <> 0 Then
            Dim ms As New IO.MemoryStream(b)
            imagen.Image = Image.FromStream(ms)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            imagen.Image = Nothing
            imagen.BackgroundImage = My.Resources.NOIMAGEN
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            ReportePrecios.ShowDialog()
        End If
    End Sub

    Private Sub BtnCuentasACobrar_Click(sender As Object, e As EventArgs) Handles BtnCuentasACobrar.Click
        FrmCuentas.ShowDialog()
    End Sub

    Private Sub CopiaDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDeSeguridadToolStripMenuItem.Click
        frmBackup.ShowDialog()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            ReportePersonasConCuentas.ShowDialog()
        End If
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("C:\Windows\System32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            FrmUsuarios.ShowDialog()
        End If
    End Sub

    Private Sub ServiciosStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        'FrmBloqueo.ShowDialog()
        ' If FrmBloqueo.txtPermiso.Text = "1" Then
        Servicios.ShowDialog()
        ' End If
    End Sub

    Private Sub Stock_MovToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Stock_MovToolStripMenuItem2.Click
        FrmBloqueo.ShowDialog()
        If FrmBloqueo.txtPermiso.Text = "1" Then
            Stock.ShowDialog()
        End If
    End Sub

End Class
