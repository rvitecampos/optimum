Public Class Productos
    Private dt As New DataTable

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        bloquear()
        mostrar()

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fProductos
            dt = func.mostrar
            datalistadoProducto.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistadoProducto.DataSource = dt
                Txtbuscar.Enabled = True
                datalistadoProducto.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistadoProducto.DataSource = Nothing
                Txtbuscar.Enabled = False
                datalistadoProducto.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        BtnNuevo.Enabled = True
        BtnEditar.Enabled = False

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistadoProducto.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoProducto.DataSource = Nothing
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
        btnBuscarProveedor.Enabled = True
        TxtCodProducto.Enabled = True
        txtCantidad.Enabled = False
        txtLimite.Enabled = True
        TxtNombreProducto.Enabled = True
        TxtPrecioUnitario.Enabled = True
        txtSPrecioUnitario.Enabled = True
        BtnEditar.Enabled = False
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = True
        PictureBox1.Enabled = True
    End Sub
    Public Sub bloquear()
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        btnBuscarProveedor.Enabled = False
        TxtCodProducto.Enabled = False
        TxtNombreProducto.Enabled = False
        TxtCodProveedor.Enabled = False
        TxtProveedor.Enabled = False
        txtCantidad.Enabled = False
        TxtPrecioUnitario.Enabled = False
        txtSPrecioUnitario.Enabled = False
        txtLimite.Enabled = False
        PictureBox1.Enabled = False
    End Sub
    Public Sub limpiar()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        TxtCodProducto.Text = "0"
        TxtNombreProducto.Text = ""
        TxtCodProveedor.Text = "0"
        TxtProveedor.Text = ""
        txtCantidad.Text = "0"
        txtCantidad.Enabled = False
        TxtPrecioUnitario.Text = "0"
        txtSPrecioUnitario.Text = "0"
        txtLimite.Text = "0"
        cbeliminar.Checked = False

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.NOIMAGEN
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

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
    Public Sub txtCantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtCantidad.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub txtLimite_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLimite.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtLimite.Text & CChar(eventArgs.KeyChar))
    End Sub
    '  Public Sub TxtPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioUnitario.KeyPress
    '      eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtPrecioUnitario.Text & CChar(eventArgs.KeyChar))
    '  End Sub
    '  Public Sub txttxtSPrecioUnitario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSPrecioUnitario.KeyPress
    '      eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtSPrecioUnitario.Text & CChar(eventArgs.KeyChar))
    '  End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        mostrar()
        desbloquear()
        BtnNuevo.Enabled = False
        TxtCodProducto.Focus()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try


            If Me.ValidateChildren = True And TxtNombreProducto.Text <> " " And TxtCodProducto.Text <> " " And TxtPrecioUnitario.Text <> " " And TxtCodProveedor.Text > 0 Then

                Dim dts As New vProducto
                Dim func As New fProductos

                'INSERTAR PRODUCTO
                dts.gcod_Producto = TxtCodProducto.Text
                dts.gNombre_Producto = TxtNombreProducto.Text
                dts.gcood_Proveedor = TxtCodProveedor.Text
                dts.gcantidad = txtCantidad.Text
                'dts.gPrecio_compra = "0"

                dts.gPrecio_Unitario = TxtPrecioUnitario.Text
                dts.gSPrecio_unitario = txtSPrecioUnitario.Text
                dts.gLimite = txtLimite.Text

                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.NOIMAGEN
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If

                dts.gimagen = ms.GetBuffer

                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    bloquear()
                    BtnGuardar.Enabled = False
                    BtnNuevo.Enabled = True
                Else
                    MessageBox.Show("Producto no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()


                End If


            Else
                MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProducto.CellClick
        desbloquear()

        TxtCodProducto.Text = datalistadoProducto.SelectedCells.Item(1).Value
        TxtNombreProducto.Text = datalistadoProducto.SelectedCells.Item(2).Value
        txtCantidad.Text = datalistadoProducto.SelectedCells.Item(3).Value

        TxtPrecioUnitario.Text = datalistadoProducto.SelectedCells.Item(4).Value
        txtSPrecioUnitario.Text = datalistadoProducto.SelectedCells.Item(5).Value
        TxtCodProveedor.Text = datalistadoProducto.SelectedCells.Item(6).Value
        txtLimite.Text = datalistadoProducto.SelectedCells.Item(8).Value
        TxtProveedor.Text = datalistadoProducto.SelectedCells.Item(9).Value
        txtCantidad.Enabled = False



        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistadoProducto.SelectedCells.Item(7).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
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
                        dts.gcantidad = txtCantidad.Text
                        dts.gPrecio_Unitario = TxtPrecioUnitario.Text
                        dts.gSPrecio_unitario = txtSPrecioUnitario.Text
                        dts.gLimite = txtLimite.Text

                        Dim ms As New IO.MemoryStream()

                        If Not imagen.Image Is Nothing Then
                            imagen.Image.Save(ms, imagen.Image.RawFormat)
                        Else
                            imagen.Image = My.Resources.NOIMAGEN
                            imagen.Image.Save(ms, imagen.Image.RawFormat)
                        End If

                        dts.gimagen = ms.GetBuffer
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
        BtnGuardar.Enabled = False

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoProducto.Columns.Item("eliminar").Visible = True
            BtnEliminar.Enabled = True
        Else
            datalistadoProducto.Columns.Item("eliminar").Visible = False
            BtnEliminar.Enabled = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProducto.CellContentClick
        If e.ColumnIndex = Me.datalistadoProducto.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoProducto.Rows(e.RowIndex).Cells("Eliminar")
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
                    For Each row As DataGridViewRow In datalistadoProducto.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        Dim stock0 As Integer = Convert.ToInt32(row.Cells("Stock").Value)
                        Dim Prod As String = row.Cells("Nombre_Producto").Value
                        Dim CodProd As String = row.Cells("Cod_Producto").Value
                        If marcado Then
                            If stock0 > 0 Then
                                MessageBox.Show(Prod, "Solo puede eliminar con Stock = 0", MessageBoxButtons.OK)

                            Else
                                'Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_producto").Value)
                                Dim vdb As New vProducto
                                Dim func As New fProductos
                                vdb.gcod_Producto = CodProd

                                If func.eliminar(vdb) Then
                                    MessageBox.Show(Prod, "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    bloquear()
                                    limpiar()

                                End If

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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage



        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.NOIMAGEN
        imagen.SizeMode = PictureBoxSizeMode.StretchImage




    End Sub

    Private Sub btnBuscarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        FrmProveedor.txtflag.Text = "1"
        FrmProveedor.ShowDialog()

    End Sub



    Private Sub datalistadoProducto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProducto.CellDoubleClick
        If txtflag.Text = "1" Then
            '   Detalle_Venta.txtPrecio.Items.Clear()

            Detalle_Venta.txtcod_Servicio.Text = datalistadoProducto.SelectedCells.Item(1).Value
            Detalle_Venta.txtNombreServicio.Text = datalistadoProducto.SelectedCells.Item(2).Value
            '  Detalle_Venta.txtStock.Text = datalistadoProducto.SelectedCells.Item(3).Value
            '    Detalle_Venta.txtPrecio.Text = datalistadoProducto.SelectedCells.Item(4).Value
            '    Detalle_Venta.txtPrecio.Items.Add(datalistadoProducto.SelectedCells.Item(4).Value)
            '   Detalle_Venta.txtPrecio.Items.Add(datalistadoProducto.SelectedCells.Item(5).Value)



            Detalle_Compra.txtcod_Producto.Text = datalistadoProducto.SelectedCells.Item(1).Value
            Detalle_Compra.txtNombreProducto.Text = datalistadoProducto.SelectedCells.Item(2).Value
            Detalle_Compra.txtStock.Text = datalistadoProducto.SelectedCells.Item(3).Value
            Detalle_Compra.TxtPrecio1.Text = datalistadoProducto.SelectedCells.Item(4).Value
            Detalle_Compra.TxtPrecio2.Text = datalistadoProducto.SelectedCells.Item(5).Value


            Me.Close()


        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()

    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrecioUnitario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioUnitario.KeyPress
        NumerosyDecimal(TxtPrecioUnitario, e)
    End Sub
    Private Sub txtSPrecioUnitario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSPrecioUnitario.KeyPress
        NumerosyDecimal(txtSPrecioUnitario, e)
    End Sub


End Class