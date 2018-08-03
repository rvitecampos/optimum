Public Class Detalle_Venta
    Private dt As DataTable


    Private Sub mostrar()

        Dim func As New fDetalle_Venta
        Dim dts As New VDetalle_venta

        dts.gcod_venta = TxtCod_venta.Text
   
        dt = func.mostrar(dts)
        datalistadoDetalleVenta.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoDetalleVenta.DataSource = dt
            Txtbuscar.Enabled = True
            datalistadoDetalleVenta.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoDetalleVenta.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoDetalleVenta.ColumnHeadersVisible = False
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
                datalistadoDetalleVenta.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoDetalleVenta.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        ' datalistadoDetalleVenta.Columns(1).Visible = False

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


    Public Sub Txt_Efectivo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Efectivo.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Txt_Efectivo.Text & CChar(eventArgs.KeyChar))
    End Sub

    Public Sub Txtcantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtcantidad.Text & CChar(eventArgs.KeyChar))
       
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

        BtnVender.Visible = True

        txtcod_Producto.Text = "0"
        txtNombreProducto.Text = ""
        txtcantidad.Text = "0"
        txtStock.Text = "0"
        Txt_Efectivo.Text = "0"
        txt_total_a_pagar.Text = "0"


    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        Try

       
        If cbSinPagar.Checked = True Then
            Dim dtsActualizar As New VDetalle_venta

            Dim func As New fDetalle_Venta

            dtsActualizar.gcod_venta = TxtCod_venta.Text

            dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text
            dtsActualizar.gEstado = "1"
            dtsActualizar.gPagando = 0
            If func.editar_Pagos(dtsActualizar) Then

            End If
            If func.actualizar_total(dtsActualizar) Then

            End If


            If inexistente.Visible <> True Then
                MsgBox("Vendido")
                If MsgBox("¿Desea crear otra venta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Venta") = vbYes Then

                    FrmVenta.mostrar()
                    FrmVenta.Show()
                        cbSinPagar.Checked = False
                        Txt_Efectivo.Enabled = True
                    Me.Close()
                Else
                    FrmVenta.Close()
                        cbSinPagar.Checked = False
                        Txt_Efectivo.Enabled = True
                    Me.Close()
                End If
            Else
                MsgBox("Agregue Articulos a la Venta", MsgBoxStyle.Information, "Ningun Articulo")
            End If
        Else
            Dim dtsActualizar As New VDetalle_venta
            'Dim dtsSumarFondo As New VDetalle_venta
            Dim func As New fDetalle_Venta

            dtsActualizar.gcod_venta = TxtCod_venta.Text

            dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text
            'dtsSumarFondo.gtotal_a_pagar = txtTotal_a_pagar.Text

            If func.actualizar_total(dtsActualizar) Then

            End If

            'If func.sumar_fondo(dtsSumarFondo) Then

            'End If




            Dim Vuelto, total, efectivo As Double
            total = txtTotal_a_pagar.Text
            efectivo = Txt_Efectivo.Text



            If inexistente.Visible <> True Then


                If Txt_Efectivo.Text <> "0" And Txt_Efectivo.Text <> "" And efectivo >= total Then


                    Vuelto = efectivo - total
                    MsgBox(Vuelto & " Gs.", MsgBoxStyle.Information, "VUELTO")
                    If MsgBox("¿Desea crear otra venta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Venta") = vbYes Then

                        FrmVenta.mostrar()
                        FrmVenta.Show()
                        Me.Close()
                    Else
                        FrmVenta.Close()
                        Me.Close()

                    End If

                Else
                    MessageBox.Show("No ha ingresado el Efectivo del Cliente o el ingreso es menor al total a pagar", "Ingrese efectivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MsgBox("Agregue Articulos a la Venta", MsgBoxStyle.Information, "Ningun Articulo")
            End If
        End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BtnEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea quitar estos articulos", "Quitar articulos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadoDetalleVenta.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim cantidadSalvada As Double = row.Cells("cantidad").Value
                        Dim total As Double = row.Cells("total").Value
                        Dim total_a_pagar As Double
                        total_a_pagar = txtTotal_a_pagar.Text



                        Dim onekey As String = Convert.ToString(row.Cells("Cod_producto").Value)
                        Dim dt As New VDetalle_venta
                        Dim dtsAumentar As New VDetalle_venta

                        Dim func As New fDetalle_Venta



                        dt.gcood_Producto = onekey
                        dt.gcod_venta = TxtCod_venta.Text
                        dtsAumentar.gcood_Producto = onekey
                        dtsAumentar.gcantidad = cantidadSalvada

                        If func.eliminar(dt) Then
                            txtTotal_a_pagar.Text = total_a_pagar - total
                            If func.aumentar(dtsAumentar) Then


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

        mostrar()
        limpiar()
        txtTotal_a_pagar.Text = "0"
        Txt_Efectivo.Visible = True
    End Sub


    Private Sub BtnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Try

        
        Dim cantidad, stock, precio, total As Double
        cantidad = txtcantidad.Text
        stock = txtStock.Text
        precio = txtPrecio.Text
        total = txtTotal_a_pagar.Text

            If txtPrecio.Text = txtPrecio.Items(0) Or txtPrecio.Text = txtPrecio.Items(1) Then


                If txtStock.Text <> "0" And cantidad <= stock Then


                    If Me.ValidateChildren = True And TxtCod_venta.Text <> "" And txtcod_Producto.Text <> "" And txtcantidad.Text <> "0" Then

                        Dim dts As New VDetalle_venta
                        Dim func As New fDetalle_Venta
                        Dim Dtdisminuir As New VDetalle_venta
                        Dim dtsG As New VDetalle_Ganancia
                        Dim funcG As New FDetalle_Ganancia

                        dts.gtotal = txtcantidad.Text * txtPrecio.Text
                        'Insertar Detalle_Venta
                        dts.gcod_venta = TxtCod_venta.Text
                        dts.gcood_Producto = txtcod_Producto.Text
                        dts.gcantidad = txtcantidad.Text
                        dts.gPrecio_Unitario = txtPrecio.Text
                        dts.gActivar = 0
                        
                        'Calculo del total


                        Dtdisminuir.gcood_Producto = txtcod_Producto.Text
                        Dtdisminuir.gcantidad = txtcantidad.Text


                        'Aumentar ganancia
                        dtsG.gCod_Producto = txtcod_Producto.Text
                        dtsG.gCantidad = txtcantidad.Text
                        dtsG.gPrecio1 = txtPrecio.Text
                       

                        

                        If func.insertar_detalleVenta(dts) Then
                            txtTotal_a_pagar.Text = precio * cantidad + total
                            If func.disminuir(Dtdisminuir) Then

                            End If

                            MessageBox.Show("Producto ingresado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                        Else
                            MessageBox.Show("Producto no ingresado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()

                        End If

                        
                        If funcG.aumentar_ganancia(dtsG) Then

                        End If
                    Else
                        MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    Else
                        MessageBox.Show("La cantidad que intenta vender supera stock", "No puede vender", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If
            Else
                MessageBox.Show("El Precio que esta intentando introducir no pertenece al producto", "No puede vender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

   
    
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        limpiar()

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoDetalleVenta.Columns.Item("eliminar").Visible = True
        Else
            datalistadoDetalleVenta.Columns.Item("eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistadoDetalleVenta_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoDetalleVenta.CellContentClick
        If e.ColumnIndex = Me.datalistadoDetalleVenta.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoDetalleVenta.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If txtTotal_a_pagar.Text <> "0" Then
            MsgBox("Aún no vendio esos articulos debe quitarlos de la venta o venderlos")
        Else
            Dim dtsActualizar As New VDetalle_venta

            Dim func As New fDetalle_Venta

            dtsActualizar.gcod_venta = TxtCod_venta.Text

            dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text


            If func.actualizar_total(dtsActualizar) Then

            End If
            FrmVenta.mostrar()
            cbSinPagar.Checked = False
            Txt_Efectivo.Visible = True
            Me.Close()



        End If

    End Sub



    
    Private Sub cbSinPagar_Click(sender As Object, e As EventArgs) Handles cbSinPagar.Click
        If cbSinPagar.Checked = True Then


            Txt_Efectivo.Enabled = False
        Else
            Txt_Efectivo.Enabled = True
        End If
    End Sub

    

    Private Sub datalistadoDetalleVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalleVenta.CellDoubleClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("C:\Windows\System32\calc.exe", AppWinStyle.NormalFocus)
    End Sub
End Class