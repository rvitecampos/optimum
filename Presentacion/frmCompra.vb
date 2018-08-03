Public Class frmCompra
    Dim dt As DataTable

    Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()

    End Sub
    Public Sub mostrar()

        Dim func As New fCompra


        dt = func.mostrar
        datalistadoCompra.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoCompra.DataSource = dt
            Txtbuscar.Enabled = True
            datalistadoCompra.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoCompra.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoCompra.ColumnHeadersVisible = False
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
                    datalistadoCompra.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoCompra.DataSource = Nothing
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
                    datalistadoCompra.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoCompra.DataSource = Nothing
                End If
            Else
                mostrar()

            End If
        End Try
    End Sub



    Private Sub txtcod_proveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)


        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese Proveedor por favor")

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

   

    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If Me.ValidateChildren = True And txtCod_Proveedor.Text <> "" And TxtProveedor.Text <> "" Then


            Dim dts As New vCompra
            Dim func As New fCompra
            dts.gcood_proveedor = txtCod_Proveedor.Text
            dts.gFecha_compra = dtpFecha.Text
            dts.gtotal_a_pagar = "0"



            If func.insertar(dts) Then
                MessageBox.Show("Compra registrada correctamente, INGRESE PRODUCTOS", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("NO SE PUDO REGISTRAR LA VENTA", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            End If


        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Detalle_Compra.TxtCod_compra.Text = datalistadoCompra.SelectedCells.Item(1).Value

        Detalle_Compra.Show()



    End Sub



    Private Sub FrmVenta_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()
    End Sub

    Private Sub btnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedor.Click
        FrmProveedor.txtflag.Text = "1"
        FrmProveedor.ShowDialog()
    End Sub
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub
End Class