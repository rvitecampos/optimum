Public Class Servicios
    Private dt As New DataTable

    Private Sub Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fServicios
            dt = func.mostrar
            datalistadoStock.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistadoStock.DataSource = dt
                Txtbuscar.Enabled = True
                datalistadoStock.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistadoStock.DataSource = Nothing
                Txtbuscar.Enabled = False
                datalistadoStock.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        BtnNuevo.Enabled = True
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
                datalistadoStock.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoStock.DataSource = Nothing
            End If

        Catch ex As Exception



        End Try
    End Sub

    Private Sub ocultar_columnas()
        'datalistadoProducto.Columns(1).Visible = False

    End Sub


    Private Sub TxtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNombreServicio.Validating
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
        'txtCtdad.Enabled = True
        '   txtDoc.Enabled = True
        'btnBuscarProveedor.Enabled = True
        'TxtCodProducto.Enabled = True
        'txtCantidad.Enabled = False
        'txtLimite.Enabled = True
        TxtNombreServicio.Enabled = True
        txtItems.Enabled = False
        txtVenta.Enabled = True
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
        BtnEditar.Enabled = False
        btnMovimientos.Enabled = False
        TxtCodServicio.Enabled = False
        TxtNombreServicio.Enabled = False
        txtItems.Enabled = False
        'TxtCodProveedor.Enabled = False
        'TxtProveedor.Enabled = False
        'txtCantidad.Enabled = False
        TxtCosto.Enabled = False
        txtVenta.Enabled = False
        txtItems.Enabled = False
    End Sub
    Public Sub limpiar()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnNuevo.Enabled = False
        btnMovimientos.Enabled = False
        TxtCodServicio.Text = "0"
        TxtNombreServicio.Text = ""
        TxtNombreServicio.Enabled = False
        txtVenta.Enabled = False
        'TxtCodProveedor.Text = "0"
        'TxtProveedor.Text = ""
        'txtCantidad.Text = "0"
        'txtCantidad.Enabled = False
        TxtCosto.Text = "0"
        txtVenta.Text = "0"
        txtItems.Text = "0"
        'txtCtdad.Text = "0"
        'txtCtdad.Enabled = False
        'txtDoc.Text = ""
        'txtDoc.Enabled = False
        cbeliminar.Checked = False

        'imagen.Image = Nothing
        'imagen.BackgroundImage = My.Resources.NOIMAGEN
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
    '  Public Sub txtCantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '      eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtCantidad.Text & CChar(eventArgs.KeyChar))
    '  End Sub
    Public Sub txtLimite_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItems.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtItems.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub TxtPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCosto.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtCosto.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub txttxtSPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVenta.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtVenta.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        mostrar()
        desbloquear()
        BtnNuevo.Enabled = False
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = True
        TxtNombreServicio.Focus()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try


            If Me.ValidateChildren = True And TxtNombreServicio.Text <> "" And TxtCodServicio.Text <> "" And txtVenta.Text <> "" Then
                ' And TxtCodProveedor.Text > 0 Then

                Dim dts As New vServicios
                Dim func As New fServicios

                'INSERTAR PRODUCTO
                dts.gcod_Servicio = TxtCodServicio.Text
                dts.gnombre_Servicio = TxtNombreServicio.Text
                dts.gventa = txtVenta.Text
                '       dts.gCtdad = txtCtdad.Text
                '       dts.gDocumento = txtDoc.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Servicio registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    bloquear()
                    ' BtnGuardar.Enabled = False
                    BtnNuevo.Enabled = True
                Else
                    MessageBox.Show("Servicio no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()


                End If


            Else
                MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub datalistadoStock_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStock.CellClick
        'desbloquear()

        TxtCodServicio.Text = datalistadoStock.SelectedCells.Item(1).Value
        TxtNombreServicio.Text = datalistadoStock.SelectedCells.Item(2).Value
        '     txtCantidad.Text = datalistadoStock.SelectedCells.Item(3).Value

        TxtCosto.Text = datalistadoStock.SelectedCells.Item(3).Value
        txtVenta.Text = datalistadoStock.SelectedCells.Item(4).Value
        txtItems.Text = datalistadoStock.SelectedCells.Item(5).Value
        '        TxtCodProveedor.Text = datalistadoStock.SelectedCells.Item(6).Value
        '        txtLimite.Text = datalistadoStock.SelectedCells.Item(8).Value
        '        TxtProveedor.Text = datalistadoStock.SelectedCells.Item(9).Value
        TxtNombreServicio.Enabled = True
        txtVenta.Enabled = True



        '     imagen.BackgroundImage = Nothing
        ' Dim b() As Byte = datalistadoStock.SelectedCells.Item(7).Value
        ' Dim ms As New IO.MemoryStream(b)

        '    imagen.Image = Image.FromStream(ms)
        '    imagen.SizeMode = PictureBoxSizeMode.StretchImage

        BtnNuevo.Enabled = True
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False
        btnMovimientos.Enabled = True

        '  BtnEditar.Enabled = True
        '  BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del Servicio?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then


                If Me.ValidateChildren = True And TxtNombreServicio.Text <> "" And TxtCodServicio.Text <> "" Then
                    Try
                        Dim dts As New vServicios
                        Dim func As New fServicios
                        dts.gcod_Servicio = TxtCodServicio.Text
                        dts.gnombre_Servicio = TxtNombreServicio.Text
                        '       dts.gcood_Proveedor = TxtCodProveedor.Text
                        '      dts.gcantidad = txtCantidad.Text
                        dts.gcosto = TxtCosto.Text
                        dts.gventa = txtVenta.Text
                        dts.gitems = txtItems.Text

                        'Dim ms As New IO.MemoryStream()

                        '     If Not imagen.Image Is Nothing Then
                        ' imagen.Image.Save(ms, imagen.Image.RawFormat)
                        ' Else
                        ' imagen.Image = My.Resources.NOIMAGEN
                        ' imagen.Image.Save(ms, imagen.Image.RawFormat)
                        ' End If

                        'dts.gimagen = ms.GetBuffer
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
            datalistadoStock.Columns.Item("eliminar").Visible = True
            BtnEliminar.Enabled = True
        Else
            datalistadoStock.Columns.Item("eliminar").Visible = False
            BtnEliminar.Enabled = False
        End If
    End Sub

    Private Sub datalistadoStock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStock.CellContentClick
        If e.ColumnIndex = Me.datalistadoStock.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoStock.Rows(e.RowIndex).Cells("Eliminar")
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
                    For Each row As DataGridViewRow In datalistadoStock.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            'Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_producto").Value)
                            Dim vdb As New vServicios
                            Dim func As New fServicios
                            vdb.gcod_Servicio = TxtCodServicio.Text

                            If func.eliminar(vdb) Then
                                MessageBox.Show("Servicio eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dlg.ShowDialog() = DialogResult.OK Then
            '       imagen.BackgroundImage = Nothing
            '       imagen.Image = New Bitmap(dlg.FileName)
            '       imagen.SizeMode = PictureBoxSizeMode.StretchImage



        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '       imagen.Image = Nothing
        '       imagen.BackgroundImage = My.Resources.NOIMAGEN
        '       imagen.SizeMode = PictureBoxSizeMode.StretchImage




    End Sub

    Private Sub btnMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovimientos.Click
        itemsServicios.txtflag.Text = "1"
        itemsServicios.lblTxtServicio.Text = TxtNombreServicio.Text
        ' StockServicio.TxtCodProducto = TxtCodServicio
        itemsServicios.ShowDialog()

    End Sub



    Private Sub datalistadoStockMovimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStock.CellDoubleClick
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
        bloquear()
        buscar()

    End Sub

    '  Public Sub TxtCtdad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '      eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtCtdad.Text & CChar(eventArgs.KeyChar))
    '  End Sub


 
End Class