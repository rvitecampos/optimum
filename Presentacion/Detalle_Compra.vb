Public Class Detalle_Compra
    Private dt As DataTable
    Private Sub Detalle_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        bloquear()
        mostrar()

        

    End Sub
    Private Sub bloquear()
        BtnComprar.Enabled = False
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
    Public Sub Txtcantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtcantidad.Text & CChar(eventArgs.KeyChar))
    End Sub

    Public Sub Txt_Efectivo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Efectivo.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Txt_Efectivo.Text & CChar(eventArgs.KeyChar))
    End Sub


    Public Sub TxtPrecioCompra_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtPrecioCompra.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mostrar()

        Dim func As New fDetalle_Compra
        Dim dts As New VDetalle_Compra

        dts.gcood_compra = TxtCod_compra.Text

        dt = func.mostrar(dts)
        datalistadoDetalleCompra.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoDetalleCompra.DataSource = dt
            Txtbuscar.Enabled = True
            datalistadoDetalleCompra.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoDetalleCompra.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoDetalleCompra.ColumnHeadersVisible = False
            inexistente.Visible = True
        End If







    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistadoDetalleCompra.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoDetalleCompra.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistadoDetalleCompra.Columns(1).Visible = False

    End Sub


    Private Sub TxtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcod_Producto.Validating, txtcantidad.Validating, txtStock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese nombre del proveedor por favor")

        End If
    End Sub

    Private Sub txtcod_producto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)


        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese telefono del proveedor por favor")

        End If
    End Sub

    Public Sub limpiar()



        txtcod_Producto.Text = "0"
        txtNombreProducto.Text = ""
        txtcantidad.Text = "0"
        txtStock.Text = "0"
        Txt_Efectivo.Text = "0"
        txtPrecioCompra.Text = "0"

    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComprar.Click
        Try
            'If Val(txtTotal_a_pagar.Text) <= Val(txtFondo.Text) Then
                Dim dtsActualizar As New VDetalle_Compra
                Dim func As New fDetalle_Compra
            'Dim dtsRestarFondo As New VDetalle_Compra

                dtsActualizar.gcood_compra = TxtCod_compra.Text
                dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text
            'dtsRestarFondo.gtotal_a_pagar = txtTotal_a_pagar.Text

            'If func.restar_fondo(dtsRestarFondo) Then

            'End If

                If func.actualizar_total(dtsActualizar) Then

                End If

                Dim Vuelto, total, efectivo As Double
                total = txtTotal_a_pagar.Text
                efectivo = Txt_Efectivo.Text



                If total > 0 Then




                    If Txt_Efectivo.Text <> "0" And Txt_Efectivo.Text <> "" And efectivo >= total Then


                        Vuelto = efectivo - total
                        MsgBox(Vuelto & " Gs.", MsgBoxStyle.Information, "VUELTO")
                        If MsgBox("¿Desea crear otra compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Comprar") = vbYes Then
                            'Aqui actualiza el total a pagar de la venta
                            frmCompra.mostrar()
                            frmCompra.Show()
                            Me.Close()
                        Else
                            frmCompra.Close()
                            Me.Close()

                        End If

                    Else
                        MessageBox.Show("No ha ingresado su Efectivo o el ingreso es menor al total a pagar", "Ingrese efectivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    MsgBox("Agregue Articulos a la Compra", MsgBoxStyle.Information, "Ningun Articulo")

                End If
            'Else
            '    MessageBox.Show("El fondo que posee no es Suficiente", "Poco Dinero", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub BtnEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea quitar estos articulos", "Quitar articulos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadoDetalleCompra.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim cantidadSalvada As Double = row.Cells("cantidad").Value
                        Dim precio_compra As Double = row.Cells("precio_compra").Value
                        Dim total_a_pagar As Double
                        total_a_pagar = txtTotal_a_pagar.Text


                        'Transformar a String el cod del producto
                        Dim onekey As String = Convert.ToString(row.Cells("Cod_producto").Value)
                        Dim dt As New VDetalle_Compra
                        Dim dtdisminuir As New VDetalle_Compra
                        Dim func As New fDetalle_Compra
                        Dim dtsg As New VDetalle_Ganancia
                        Dim funci As New FDetalle_Ganancia
                        dt.gcood_producto = onekey
                        dtdisminuir.gcood_producto = onekey
                        dtdisminuir.gcantidad = cantidadSalvada
                        dtsg.gCod_Producto = onekey

                        If funci.eliminar_detalleganancia(dtsg) Then

                        End If
                        If func.eliminar(dt) Then
                            txtTotal_a_pagar.Text = total_a_pagar - precio_compra

                            If func.disminuir(dtdisminuir) Then


                            End If
                            MessageBox.Show("Articulo eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Call limpiar()
    End Sub




    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarProducto.Click
        Productos.txtflag.Text = "1"
        Productos.ShowDialog()
    End Sub

    Private Sub Detalle_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()

    End Sub
    Public Sub desbloquear()
        BtnComprar.Enabled = True

    End Sub

    Private Sub BtnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click



        If Me.ValidateChildren = True And TxtCod_compra.Text <> "" And txtcod_Producto.Text <> "" And txtcantidad.Text <> "0" Then

            Dim dts As New VDetalle_Compra
            Dim dtsg As New VDetalle_Ganancia
            Dim func As New fDetalle_Compra
            Dim funcG As New FDetalle_Ganancia

            Dim dtsAumentar As New VDetalle_Compra

            dts.gcood_compra = TxtCod_compra.Text
            dts.gcood_producto = txtcod_Producto.Text
            dts.gprecio_compra = txtPrecioCompra.Text
            dts.gcantidad = txtcantidad.Text


            'Detalle Ganancia
            dtsg.gCod_Producto = txtcod_Producto.Text
            dtsg.gCantidad = txtcantidad.Text
            dtsg.gPrecio_Compra = txtPrecioCompra.Text
            dtsg.gPrecio1 = TxtPrecio1.Text
            dtsg.gPrecio2 = TxtPrecio2.Text
            dtsg.gGanancia_total = "0"

            'Aumentar Stock
            dtsAumentar.gcood_Producto = txtcod_Producto.Text
            dtsAumentar.gcantidad = txtcantidad.Text


            If funcG.insertar_detalleganancia(dtsg) Then

            End If

            If func.insertar_detalleCompra(dts) Then
                txtTotal_a_pagar.Text = Val(txtPrecioCompra.Text) + Val(txtTotal_a_pagar.Text)
                If func.aumentar(dtsAumentar) Then


                End If
                MessageBox.Show("Producto ingresado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                desbloquear()
                limpiar()
            Else
                MessageBox.Show("Producto no ingresado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            End If


        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        limpiar()

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoDetalleCompra.Columns.Item("eliminar").Visible = True
        Else
            datalistadoDetalleCompra.Columns.Item("eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistadoDetalleCompra_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoDetalleCompra.CellContentClick
        If e.ColumnIndex = Me.datalistadoDetalleCompra.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoDetalleCompra.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If txtTotal_a_pagar.Text <> "0" Then
            MsgBox("Aún no comprado esos articulos debe quitarlos de la compra o comprarlos")
        Else
            Dim dtsActualizar As New VDetalle_Compra

            Dim func As New fDetalle_Compra

            dtsActualizar.gcood_compra = TxtCod_compra.Text

            dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text


            If func.actualizar_total(dtsActualizar) Then

            End If
            frmCompra.mostrar()

            Me.Close()



        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmFondo.ShowDialog()

    End Sub

    
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("C:\Windows\System32\calc.exe", AppWinStyle.NormalFocus)
    End Sub
End Class