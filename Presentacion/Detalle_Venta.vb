Public Class Detalle_Venta
    Private dt As DataTable


    Private Sub mostrar()

        Dim func As New fDetalle_Venta
        Dim dts As New VDetalle_venta

        dts.gCood_venta = TxtCod_venta.Text
        dts.gCood_Cliente = txtCodCliente.Text
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


    '  Public Sub Txt_Efectivo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '      eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Txt_Efectivo.Text & CChar(eventArgs.KeyChar))
    '  End Sub

    ' Public Sub Txtcantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
    '     eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtcantidad.Text & CChar(eventArgs.KeyChar))

    '    End Sub



    Private Sub TxtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcod_Servicio.Validating, txtcantidad.Validating
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

        txtcod_Servicio.Text = "0"
        txtNombreServicio.Text = ""
        txtcantidad.Text = "0"
        txtIGV.Text = "0"
        txtPVenta.Text = "0"
        txtPUnitario.Text = "0"
        txtPTotal.Text = "0"
        '    Txt_Efectivo.Text = "0"
        '    txt_total_a_pagar.Text = "0"


    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click



        '   Try


        '     If cbSinPagar.Checked = True Then
        Dim dtsTotalActual As New vVenta
        Dim funcTotalActual As New fventa

        dtsTotalActual.gcod_Venta = TxtCod_venta.Text
        dtsTotalActual.gcood_Cliente = txtCodCliente.Text

        ' dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text
        ' dtsActualizar.gEstado = "1"
        ' dtsActualizar.gPagando = 0
        'If func.editar_Pagos(dtsActualizar) Then

        'End If
        dt = funcTotalActual.totalActual(dtsTotalActual)

        If (dt.Rows.Count) <> 0 Then
            FrmVenta.txtTotal.Text = Trim(dt.Rows(0)("Total"))
            FrmVenta.txtLetras.Text = Trim(dt.Rows(0)("Letras"))
        End If

        Dim func As New fventa
        dt = func.mostrar
        FrmVenta.datalistadoVenta.DataSource = dt


        ' If inexistente.Visible <> True Then
        ' MsgBox("Vendido")
        ' If MsgBox("¿Desea crear otra venta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Venta") = vbYes Then

        'FrmVenta.mostrar()

        FrmVenta.Show()
        '  cbSinPagar.Checked = False
        '  Txt_Efectivo.Enabled = True
        Me.Close()
        '  Else
        ' FrmVenta.Close()
        ' cbSinPagar.Checked = False
        ' Txt_Efectivo.Enabled = True
        ' Me.Close()
        ' End If
        ' Else
        ' MsgBox("Agregue Articulos a la Venta", MsgBoxStyle.Information, "Ningun Articulo")
        ' End If
        ' Else
        ' Dim dtsActualizar As New VDetalle_venta
        'Dim dtsSumarFondo As New VDetalle_venta
        ' Dim func As New fDetalle_Venta

        '                dtsActualizar.gcod_venta = TxtCod_venta.Text

        'dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text
        'dtsSumarFondo.gtotal_a_pagar = txtTotal_a_pagar.Text

        ' If func.actualizar_total(dtsActualizar) Then

        '            End If

        'If func.sumar_fondo(dtsSumarFondo) Then

        'End If




        ' Dim Vuelto, total, efectivo As Double
        'total = txtTotal_a_pagar.Text
        ' efectivo = Txt_Efectivo.Text



        'If inexistente.Visible <> True Then


        ' If Txt_Efectivo.Text <> "0" And Txt_Efectivo.Text <> "" And efectivo >= total Then


        'Vuelto = efectivo - total
        'MsgBox(Vuelto & " Gs.", MsgBoxStyle.Information, "VUELTO")
        'If MsgBox("¿Desea crear otra venta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Venta") = vbYes Then

        ' FrmVenta.mostrar()
        ' FrmVenta.Show()
        ' Me.Close()
        ' Else
        ' FrmVenta.Close()
        ' Me.Close()

        'End If

        'Else
        ' MessageBox.Show("No ha ingresado el Efectivo del Cliente o el ingreso es menor al total a pagar", "Ingrese efectivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If

        '            Else
        '           MsgBox("Agregue Articulos a la Venta", MsgBoxStyle.Information, "Ningun Articulo")
        '          End If
        '         End If
        '    Catch ex As Exception
        '       MsgBox(ex.Message)
        '  End Try
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
                        '     Dim total_a_pagar As Double
                        '        total_a_pagar = txtTotal_a_pagar.Text



                        Dim onekey As String = Convert.ToString(row.Cells("Cod_producto").Value)
                        Dim dt As New VDetalle_venta
                        Dim dtsAumentar As New VDetalle_venta

                        Dim func As New fDetalle_Venta



                        '   dt.gcood_Producto = onekey
                        '   dt.gcod_venta = TxtCod_venta.Text
                        '   dtsAumentar.gcood_Producto = onekey
                        '   dtsAumentar.gcantidad = cantidadSalvada

                        If func.eliminar(dt) Then
                            '       txtTotal_a_pagar.Text = total_a_pagar - total
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
        Servicios.txtflag.Text = "1"
        Servicios.ShowDialog()
    End Sub

    Private Sub Detalle_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrar()
        limpiar()
        '    txtTotal_a_pagar.Text = "0"
        '     Txt_Efectivo.Visible = True
    End Sub


    Private Sub BtnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Try


            If txtcantidad.Text > 0 Then


                If Me.ValidateChildren = True And txtcod_Servicio.Text <> "" And txtcantidad.Text <> "0" And txtPVenta.Text <> "0" Then

                    Dim dts As New VDetalle_venta
                    Dim func As New fDetalle_Venta

                    dts.gCood_venta = TxtCod_venta.Text
                    dts.gCood_Cliente = txtCodCliente.Text
                    dts.gCood_Servicio = txtcod_Servicio.Text
                    dts.gUni_Medida = "NIU"
                    dts.gCantidad = txtcantidad.Text
                    dts.gNombre_Servicio = txtNombreServicio.Text
                    dts.gVenta_unitario = txtPUnitario.Text
                    dts.gVenta = txtPVenta.Text
                    dts.gIGV = txtIGV.Text
                    dts.gTotal = txtPTotal.Text
                    dts.gNombre_tributo = "IGV"
                    dts.gCodigo_tributo = "VAT"



                    If func.insertar_detalleVenta(dts) Then
                        '         txtTotal_a_pagar.Text = precio * cantidad + total
                        ' If func.disminuir(Dtdisminuir) Then

                        '                    End If

                        MessageBox.Show("Producto ingresado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Producto no ingresado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()

                    End If


                Else
                    MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No ingreso Cantidad", "No puede vender", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            '   Else
            '   MessageBox.Show("El Precio que esta intentando introducir no pertenece al producto", "No puede vender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '   End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        '     If txtTotal_a_pagar.Text <> "0" Then
        'MsgBox("Aún no vendio esos articulos debe quitarlos de la venta o venderlos")
        '     Else
        '   Dim dtsActualizar As New VDetalle_venta

        '   Dim func As New fDetalle_Venta

        '   dtsActualizar.gcod_venta = TxtCod_venta.Text

        ' dtsActualizar.gtotal_a_pagar = txtTotal_a_pagar.Text


        '    If func.actualizar_total(dtsActualizar) Then

        '   End If
        '  FrmVenta.mostrar()
        '   cbSinPagar.Checked = False
        '   Txt_Efectivo.Visible = True
        '   Me.Close()



        '   End If

    End Sub




    Private Sub cbSinPagar_Click(sender As Object, e As EventArgs)
        '   If cbSinPagar.Checked = True Then


        'Txt_Efectivo.Enabled = False
        '    Else
        '    Txt_Efectivo.Enabled = True
        '    End If
    End Sub



    Private Sub datalistadoDetalleVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalleVenta.CellDoubleClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("C:\Windows\System32\calc.exe", AppWinStyle.NormalFocus)
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

    Private Sub txtcantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        NumerosyDecimal(txtcantidad, e)
     End Sub

    Private Sub txtcantidad_LostFocus(sender As Object, e As EventArgs) Handles txtcantidad.LostFocus
        If txtcantidad.Text <> "" And txtcantidad.Text <> "." Then
            If txtPVenta.Text <> "" And txtPVenta.Text <> "." Then
                txtPTotal.Text = txtcantidad.Text * txtPVenta.Text
                txtPUnitario.Text = txtPVenta.Text / 1.18
                txtIGV.Text = txtPTotal.Text - (txtPTotal.Text / 1.18)
            End If
        End If

        Dim val As Decimal = 0
        If Decimal.TryParse(txtPTotal.Text, val) Then
            txtPTotal.Text = val.ToString("N2")
        Else
            txtPTotal.Text = ""
        End If

        Dim val2 As Decimal = 0
        If Decimal.TryParse(txtPUnitario.Text, val2) Then
            txtPUnitario.Text = val2.ToString("N2")
        Else
            txtPUnitario.Text = ""
        End If

        Dim val3 As Decimal = 0
        If Decimal.TryParse(txtIGV.Text, val3) Then
            txtIGV.Text = val3.ToString("N2")
        Else
            txtIGV.Text = ""
        End If

    End Sub

    Private Sub txtPVenta_LostFocus(sender As Object, e As EventArgs) Handles txtPVenta.LostFocus
        If txtPVenta.Text <> "" And txtPVenta.Text <> "." Then
            If txtcantidad.Text <> "" And txtcantidad.Text <> "." Then
                txtPTotal.Text = txtcantidad.Text * txtPVenta.Text
                txtPUnitario.Text = txtPVenta.Text / 1.18
                txtIGV.Text = txtPTotal.Text - (txtPTotal.Text / 1.18)
            End If
        End If

        Dim val As Decimal = 0
        If Decimal.TryParse(txtPTotal.Text, val) Then
            txtPTotal.Text = val.ToString("N2")
        Else
            txtPTotal.Text = ""
        End If

        Dim val2 As Decimal = 0
        If Decimal.TryParse(txtPUnitario.Text, val2) Then
            txtPUnitario.Text = val2.ToString("N2")
        Else
            txtPUnitario.Text = ""
        End If

        Dim val3 As Decimal = 0
        If Decimal.TryParse(txtIGV.Text, val3) Then
            txtIGV.Text = val3.ToString("N2")
        Else
            txtIGV.Text = ""
        End If
    End Sub
End Class