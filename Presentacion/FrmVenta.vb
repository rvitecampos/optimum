Imports System.IO

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
            cbeliminar.Visible = True
            BtnEliminar.Visible = True
        Else
            datalistadoVenta.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoVenta.ColumnHeadersVisible = False
            inexistente.Visible = True
            cbeliminar.Visible = False
            BtnEliminar.Visible = False
        End If

    End Sub

    Public Sub crearCabeceraFac(ByVal codVenta As String)
        Dim func As New fventa
        dt = func.crearCabeceraFac(codVenta)
        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String
        Dim campo7 As String
        Dim campo8 As String
        Dim campo9 As String
        Dim campo10 As String
        Dim campo11 As String
        Dim campo12 As String
        Dim campo13 As String
        Dim campo14 As String
        Dim campo15 As String
        Dim campo16 As String
        Dim campo17 As String
        Dim campo18 As String
        Dim campo19 As String
        Dim campo20 As String


        campo1 = Trim(dt.Rows(0)("campo1"))
        campo2 = Trim(dt.Rows(0)("campo2"))
        campo3 = Trim(dt.Rows(0)("campo3"))
        campo4 = Trim(dt.Rows(0)("campo4"))
        campo5 = Trim(dt.Rows(0)("campo5"))
        campo6 = Trim(dt.Rows(0)("campo6"))
        campo7 = Trim(dt.Rows(0)("campo7"))
        campo8 = Trim(dt.Rows(0)("campo8"))
        campo9 = Trim(dt.Rows(0)("campo9"))
        campo10 = Trim(dt.Rows(0)("campo10"))
        campo11 = Trim(dt.Rows(0)("campo11"))
        campo12 = Trim(dt.Rows(0)("campo12"))
        campo13 = Trim(dt.Rows(0)("campo13"))
        campo14 = Trim(dt.Rows(0)("campo14"))
        campo15 = Trim(dt.Rows(0)("campo15"))
        campo16 = Trim(dt.Rows(0)("campo16"))
        campo17 = Trim(dt.Rows(0)("campo17"))
        campo18 = Trim(dt.Rows(0)("campo18"))
        campo19 = Trim(dt.Rows(0)("campo19"))
        campo20 = Trim(dt.Rows(0)("campo20"))



        Dim archivo As StreamWriter
        Dim nombre As String
        nombre = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA\"
        nombre = nombre + campo7 + "-01-" + campo19 + "-" + campo20 + ".cab"
        Dim linea As String = Nothing
        'archivo = New StreamWriter("D:\idea\FACTURADOR\Facturas\prueba.txt")
        archivo = New StreamWriter(nombre)
        'Dim escoge As Integer

        linea = campo1 & "|" & _
                campo2 & "|" & _
                campo3 & "|" & _
                campo4 & "|" & _
                campo5 & "|" & _
                campo6 & "|" & _
                campo7 & "|" & _
                campo8 & "|" & _
                campo9 & "|" & _
                campo10 & "|" & _
                campo11 & "|" & _
                campo12 & "|" & _
                campo13 & "|" & _
                campo14 & "|" & _
                campo15 & "|" & _
                campo16 & "|" & _
                campo17 & "|" & _
                campo18
        ' If linea.Substring(0, 1) = "|" Then

        '            Else
        archivo.WriteLine(linea)
        MsgBox("txt creado")
        '           End If
        archivo.Close()




        ' MessageBox.Show(msg, "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        btnRegistrar.Enabled = True
        btnAñadir.Enabled = False
        BtnCerrar.Enabled = False
        BtnNuevo.Enabled = True
        TxtCod_venta.Text = ""
        txtCod_cliente.Text = ""
        txtRuc.Text = ""
        TxtNombre.Text = ""
        txtTC.Text = ""

    End Sub

    Public Sub bloquear()
        btnRegistrar.Enabled = False
        btnAñadir.Enabled = False
        BtnCerrar.Enabled = False
        BtnNuevo.Enabled = True
        TxtCod_venta.Enabled = False
        dtpFecha.Enabled = False
        txtCod_cliente.Enabled = False
        txtRuc.Enabled = False
        TxtNombre.Enabled = False
        BtnBuscarCliente.Enabled = False
        cmbBoxOper.Enabled = False
        cmbBoxMoneda.Enabled = False
        txtTC.Enabled = False
        dtpVence.Enabled = False

    End Sub



    Public Sub desbloquear()
        dtpFecha.Enabled = True
        BtnBuscarCliente.Enabled = True
        cmbBoxOper.Enabled = True
        cmbBoxMoneda.Enabled = True
        txtTC.Enabled = True
        dtpVence.Enabled = True

    End Sub







    Private Sub BtnBuscarCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscarCliente.Click
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
    End Sub

    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Dim codVta As String
        codVta = datalistadoVenta.SelectedCells.Item(1).Value
        crearCabeceraFac(codVta)
    End Sub



    Private Sub FrmVenta_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        bloquear()
        mostrar()
 
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        buscar()

    End Sub

    Private Sub datalistadoVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoVenta.CellClick
        bloquear()
        btnAñadir.Enabled = True
        BtnCerrar.Enabled = True
        TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        TxtNombre.Text = datalistadoVenta.SelectedCells.Item(2).Value
        Dim fechaVta As String = datalistadoVenta.SelectedCells.Item(3).Value
        Dim fecha As String = ""
        fecha = Mid(fechaVta, 9, 2) + "/" + Mid(fechaVta, 6, 2) + "/" + Mid(fechaVta, 1, 4)
        'DateTime data = DateTime.ParseExact("04/18/2013","dd/MM/yyyy",CultureInfo.InvariantCulture);

        dtpFecha.Value = Convert.ToDateTime(fecha)



        txtCod_cliente.Text = datalistadoVenta.SelectedCells.Item(6).Value
        txtRuc.Text = datalistadoVenta.SelectedCells.Item(7).Value
        ' TxtNombreProducto.Text = datalistadoStock.SelectedCells.Item(2).Value
        ' txtCantidad.Text = datalistadoStock.SelectedCells.Item(3).Value

        '        TxtPrecioUnitario.Text = datalistadoStock.SelectedCells.Item(4).Value
        '        txtSPrecioUnitario.Text = datalistadoStock.SelectedCells.Item(5).Value
        '        TxtCodProveedor.Text = datalistadoStock.SelectedCells.Item(6).Value
        '        txtLimite.Text = datalistadoStock.SelectedCells.Item(8).Value
        '        TxtProveedor.Text = datalistadoStock.SelectedCells.Item(9).Value
    End Sub


    Private Sub datalistadoVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoVenta.CellDoubleClick

 

        'Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        '    Detalle_Venta.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteComprasCliente.ShowDialog()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.ValidateChildren = True And txtCod_cliente.Text <> "" And TxtNombre.Text <> "" Then


            Dim dts As New vVenta
            Dim func As New fventa
            Dim fvta As String
            fvta = dtpFecha.Value.ToString("yyyy/MM/dd")
            Dim fvto As String
            fvto = dtpVence.Value.ToString("yyyy/MM/dd")
            dts.gcood_Cliente = txtCod_cliente.Text
            dts.gserie = "F001"
            dts.greferencial = 1
            dts.gTC = 0.0

            dts.gtipooper = "0101"
            dts.gfecha_venta = Mid(fvta, 1, 4) + "-" + Mid(fvta, 6, 2) + "-" + Mid(fvta, 9, 2)

            dts.ghora_emision = "18:39:00"
            dts.gfecha_vencimiento = Mid(fvto, 1, 4) + "-" + Mid(fvto, 6, 2) + "-" + Mid(fvto, 9, 2)
            '  dts.gtotal_a_pagar = "0"
            dts.gnro_doc = txtRuc.Text
            dts.gcliente = TxtNombre.Text
            dts.gtip_moneda = "PEN"
            dts.gigv = 0
            dts.gventa = 0
            dts.gtotal = 0


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






        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Detalle_Venta.ShowDialog()
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoVenta.Columns.Item("eliminar").Visible = True
            BtnEliminar.Enabled = True
        Else
            datalistadoVenta.Columns.Item("eliminar").Visible = False
            BtnEliminar.Enabled = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar estos productos", "Eliminar productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Try
                    For Each row As DataGridViewRow In datalistadoVenta.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then

                            Dim vdb As New vProducto
                            Dim func As New fProductos
                            '  vdb.gcod_Producto = TxtCodProducto.Text

                            If func.eliminar(vdb) Then
                                MessageBox.Show("Producto eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' bloquear()
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


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiar()
        desbloquear()

    End Sub
End Class