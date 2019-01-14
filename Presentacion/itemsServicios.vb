Public Class itemsServicios
    Private dt As New DataTable

    Private Sub itemsServicios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Servicios.limpiar()
        Servicios.mostrar()
    End Sub


 

    Private Sub itemsServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fProductos
            dt = func.mostrar
            datalistadoStockServicio.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistadoStockServicio.DataSource = dt
                Txtbuscar.Enabled = True
                datalistadoStockServicio.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistadoStockServicio.DataSource = Nothing
                Txtbuscar.Enabled = False
                datalistadoStockServicio.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = False
        '  BtnEditar.Enabled = False

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistadoStockServicio.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoStockServicio.DataSource = Nothing
            End If

        Catch ex As Exception



        End Try
    End Sub

    Private Sub ocultar_columnas()
        'datalistadoProducto.Columns(1).Visible = False

    End Sub


    Private Sub TxtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNombreProducto.Validating
        ' If DirectCast(sender, TextBox).Text.Length > 0 Then
        ' Me.Erroricono.SetError(sender, "")
        ' Else
        ' Me.Erroricono.SetError(sender, "Ingrese nombre del cliente por favor")
        '
        '        End If
    End Sub

    Private Sub txtApellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese apellido del cliente por favor")

        End If
    End Sub

    Public Sub desbloquear()
        txtCtdad.Enabled = True
        ' txtDoc.Enabled = True
        'btnBuscarProveedor.Enabled = True
        'TxtCodProducto.Enabled = True
        'txtCantidad.Enabled = False
        'txtLimite.Enabled = True
        'TxtNombreProducto.Enabled = True
        'TxtPrecioUnitario.Enabled = True
        'txtSPrecioUnitario.Enabled = True
        'BtnEditar.Enabled = False
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
    End Sub
    Public Sub bloquear()
        'BtnEditar.Enabled = False
        'BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        btnMovimientos.Enabled = False
        TxtCodProducto.Enabled = False
        TxtNombreProducto.Enabled = False
        TxtCodProveedor.Enabled = False
        TxtProveedor.Enabled = False
        txtStock.Enabled = False
        TxtPrecioUnitario.Enabled = False
        txtSPrecioUnitario.Enabled = False
        txtLimite.Enabled = False
    End Sub
    Public Sub limpiar()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = False
        btnMovimientos.Enabled = False
        TxtCodProducto.Text = "0"
        TxtNombreProducto.Text = ""
        TxtCodProveedor.Text = "0"
        TxtProveedor.Text = ""
        txtStock.Text = "0"
        txtStock.Enabled = False
        TxtPrecioUnitario.Text = "0"
        txtSPrecioUnitario.Text = "0"
        txtLimite.Text = "0"
        txtCtdad.Text = "0"
        txtCtdad.Enabled = False
        '  txtDoc.Text = ""
        '  txtDoc.Enabled = False
        cbeliminar.Checked = False

        ' imagen.Image = Nothing
        ' imagen.BackgroundImage = My.Resources.NOIMAGEN
        'imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    'FUNCION PARA PERMITIR SOLO NUMEROS DECIMALES
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890,", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    '-----------------------------------------------------------
    Public Sub txtStock_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtStock.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub txtLimite_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLimite.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtLimite.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub TxtPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioUnitario.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtPrecioUnitario.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub txttxtSPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSPrecioUnitario.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtSPrecioUnitario.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        'limpiar()
        'mostrar()
        desbloquear()
        'BtnNuevo.Enabled = False
        txtCtdad.Focus()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            If txtStock.Text >= txtCtdad.Text Then


                If Me.ValidateChildren = True And TxtNombreProducto.Text <> "" And TxtCodProducto.Text <> "" And TxtPrecioUnitario.Text <> "" And TxtCodProveedor.Text > 0 Then

                    Dim dts As New vStockMovimiento
                    Dim func As New fStockMovimiento

                    'INSERTAR PRODUCTO
                    dts.gCood_Producto = TxtCodProducto.Text
                    dts.gCosto = TxtPrecioUnitario.Text
                    dts.gNombre_Producto = TxtNombreProducto.Text
                    dts.gCood_Proveedor = TxtCodProveedor.Text
                    dts.gCtdad = txtCtdad.Text
                    dts.gDocumento = ""
                    dts.gCood_Servicio = lblCodServicio.Text


                    If func.insertar(dts) Then
                        MessageBox.Show("Producto registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloquear()
                        ' BtnGuardar.Enabled = False
                        BtnNuevo.Enabled = True
                    Else
                        MessageBox.Show("Producto no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()


                    End If


                Else
                    MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Cantidad Mayor a Stock", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub datalistadoStock_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStockServicio.CellClick
        'desbloquear()

        TxtCodProducto.Text = datalistadoStockServicio.SelectedCells.Item(1).Value
        TxtNombreProducto.Text = datalistadoStockServicio.SelectedCells.Item(2).Value
        txtStock.Text = datalistadoStockServicio.SelectedCells.Item(3).Value

        TxtPrecioUnitario.Text = datalistadoStockServicio.SelectedCells.Item(4).Value
        txtSPrecioUnitario.Text = datalistadoStockServicio.SelectedCells.Item(5).Value
        TxtCodProveedor.Text = datalistadoStockServicio.SelectedCells.Item(6).Value
        txtLimite.Text = datalistadoStockServicio.SelectedCells.Item(8).Value
        TxtProveedor.Text = datalistadoStockServicio.SelectedCells.Item(9).Value
        ' txtCantidad.Enabled = False



        ' imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistadoStockServicio.SelectedCells.Item(7).Value
        Dim ms As New IO.MemoryStream(b)

        'imagen.Image = Image.FromStream(ms)
        '        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        BtnNuevo.Enabled = True
        btnMovimientos.Enabled = True

        '  BtnEditar.Enabled = True
        '  BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then


                If Me.ValidateChildren = True And TxtNombreProducto.Text <> "" And TxtCodProducto.Text <> "" Then
                    Try
                        Dim dts As New vProducto
                        Dim func As New fProductos
                        dts.gcod_Producto = TxtCodProducto.Text
                        dts.gNombre_Producto = TxtNombreProducto.Text
                        dts.gcood_Proveedor = TxtCodProveedor.Text
                        dts.gcantidad = txtStock.Text
                        dts.gPrecio_Unitario = TxtPrecioUnitario.Text
                        dts.gSPrecio_unitario = txtSPrecioUnitario.Text
                        dts.gLimite = txtLimite.Text

                        '        Dim ms As New IO.MemoryStream()

                        'If Not imagen.Image Is Nothing Then
                        'imagen.Image.Save(MS, imagen.Image.RawFormat)
                        'Else
                        'imagen.Image = My.Resources.NOIMAGEN
                        'imagen.Image.Save(MS, imagen.Image.RawFormat)
                        'End If

                        '        dts.gimagen = MS.GetBuffer
                        If func.editar(dts) Then
                            MessageBox.Show("Producto editado correctamente", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                        Else
                            MessageBox.Show("Producto no fue modificado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()

                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                Else
                    MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
        bloquear()
        ' BtnGuardar.Enabled = False

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoStockServicio.Columns.Item("eliminar").Visible = True
            BtnEliminar.Enabled = True
        Else
            datalistadoStockServicio.Columns.Item("eliminar").Visible = False
            BtnEliminar.Enabled = False
        End If
    End Sub

    Private Sub datalistadoStock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStockServicio.CellContentClick
        If e.ColumnIndex = Me.datalistadoStockServicio.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoStockServicio.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar estos productos", "Eliminar productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Try
                    For Each row As DataGridViewRow In datalistadoStockServicio.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            'Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_producto").Value)
                            Dim vdb As New vProducto
                            Dim func As New fProductos
                            vdb.gcod_Producto = TxtCodProducto.Text

                            If func.eliminar(vdb) Then
                                MessageBox.Show("Producto eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                bloquear()
                                limpiar()

                            End If
                        End If
                    Next
                    Call mostrar()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MessageBox.Show("Cancelando eliminacion", "Eliminacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call mostrar()

            End If
        End If
        Call limpiar()

    End Sub

    ' Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    '    If dlg.ShowDialog() = DialogResult.OK Then
    '  imagen.BackgroundImage = Nothing
    '  imagen.Image = New Bitmap(dlg.FileName)
    '  imagen.SizeMode = PictureBoxSizeMode.StretchImage



    '   End If
    '    End Sub

    '  Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    '  imagen.Image = Nothing
    '  imagen.BackgroundImage = My.Resources.NOIMAGEN
    '  imagen.SizeMode = PictureBoxSizeMode.StretchImage




    ' End Sub

    Private Sub btnMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovimientos.Click
        StockMovimiento.txtflag.Text = "1"
        StockMovimiento.txtCodProducto = TxtCodProducto
        StockMovimiento.ShowDialog()

    End Sub



    Private Sub datalistadoStockMovimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStockServicio.CellDoubleClick
        ' If txtflag.Text = "1" Then
        ' Detalle_Venta.txtPrecio.Items.Clear()
        '
        '        Detalle_Venta.txtcod_Producto.Text = datalistado.SelectedCells.Item(1).Value
        '        Detalle_Venta.txtNombreProducto.Text = datalistado.SelectedCells.Item(2).Value
        '        Detalle_Venta.txtStock.Text = datalistado.SelectedCells.Item(3).Value
        '        Detalle_Venta.txtPrecio.Text = datalistado.SelectedCells.Item(4).Value
        '        Detalle_Venta.txtPrecio.Items.Add(datalistado.SelectedCells.Item(4).Value)
        '        Detalle_Venta.txtPrecio.Items.Add(datalistado.SelectedCells.Item(5).Value)



        '        Detalle_Compra.txtcod_Producto.Text = datalistado.SelectedCells.Item(1).Value
        '        Detalle_Compra.txtNombreProducto.Text = datalistado.SelectedCells.Item(2).Value
        '        Detalle_Compra.txtStock.Text = datalistado.SelectedCells.Item(3).Value
        '        Detalle_Compra.TxtPrecio1.Text = datalistado.SelectedCells.Item(4).Value
        '        Detalle_Compra.TxtPrecio2.Text = datalistado.SelectedCells.Item(5).Value


        '        Me.Close()


        'End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
        buscar()

    End Sub

    Public Sub TxtCtdad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCtdad.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtCtdad.Text & CChar(eventArgs.KeyChar))
    End Sub
End Class