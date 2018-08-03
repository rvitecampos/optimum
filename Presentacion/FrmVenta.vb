Public Class FrmVenta
    Private dt As DataTable

    Private Sub FrmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()

    End Sub
    Public Sub mostrar()

        Dim func As New fventa


        dt = func.mostrar
        datalistadoVenta.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoVenta.DataSource = dt
            Txtbuscar.Enabled = True
            datalistadoVenta.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoVenta.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoVenta.ColumnHeadersVisible = False
            inexistente.Visible = True
        End If






    End Sub

    Private Sub buscar()
        Try
            If Txtbuscar.Text <> "" Then


                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))


                dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    datalistadoVenta.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoVenta.DataSource = Nothing
                End If
            Else
                mostrar()

            End If

        Catch ex As Exception

            If Txtbuscar.Text <> "" Then


                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))


                dv.RowFilter = cbocampos.Text & " = " & Txtbuscar.Text & ""
                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    datalistadoVenta.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoVenta.DataSource = Nothing
                End If
            Else
                mostrar()

            End If
        End Try
    End Sub



    Private Sub txtcod_cliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)


        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese Cliente por favor")

        End If
    End Sub

    Public Sub limpiar()


        txtCod_cliente.Text = "0"
        TxtNombre.Text = ""





    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


   
    
    Private Sub BtnBuscarCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscarCliente.Click
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
    End Sub

    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If Me.ValidateChildren = True And txtCod_cliente.Text <> "" And TxtNombre.Text <> "" Then


            Dim dts As New vVenta
            Dim func As New fventa
            dts.gcod_Cliente = txtCod_cliente.Text
            'dts.gFecha_venta = DateString
            dts.gtotal_a_pagar = "0"



            If func.insertar(dts) Then
                MessageBox.Show("Venta registrada correctamente, INGRESE PRODUCTOS", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("NO SE PUDO REGISTRAR LA VENTA", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            End If


            Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value



            Detalle_Venta.ShowDialog()


        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
       

    End Sub


   
    Private Sub FrmVenta_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()

    End Sub

  
    Private Sub datalistadoVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoVenta.CellDoubleClick
       

        'Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        '    Detalle_Venta.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteComprasCliente.ShowDialog()
    End Sub
End Class