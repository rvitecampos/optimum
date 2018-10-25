Imports System.IO
Imports System.Globalization

Public Class FrmVenta
    Private dt As DataTable
    Public U, D, C, M, DM, CM As String
    Public CMl, DMl, Ml, Cl, Dl, Ul As String
    Public letra As String
    Private Property dtlle As String

    Private Property tri As String

    Private Property ley As String

    Private Property aca As String

    Private Property nombre2 As String

    Private Sub FrmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()
        'cargarCat51()


    End Sub
    Public Sub mostrar()
        limpiar()
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
        Dim nombreGral As String
        nombre = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA\"
        nombreGral = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA\"
        nombre2 = ""
        nombre2 = campo7 + "-01-" + campo19 + "-" + campo20
        nombre = nombre + campo7 + "-01-" + campo19 + "-" + campo20 + ".cab"
        dtlle = nombreGral + campo7 + "-01-" + campo19 + "-" + campo20 + ".det"
        tri = nombreGral + campo7 + "-01-" + campo19 + "-" + campo20 + ".tri"
        ley = nombreGral + campo7 + "-01-" + campo19 + "-" + campo20 + ".ley"
        aca = nombreGral + campo7 + "-01-" + campo19 + "-" + campo20 + ".aca"

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
                campo18 & "|"
        ' If linea.Substring(0, 1) = "|" Then

        '            Else
        archivo.WriteLine(linea)
        MsgBox("txt creado")
        '           End If
        archivo.Close()


        grabaArchivo(nombre2)


        ' MessageBox.Show(msg, "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub grabaArchivo(gArchivo As String)
        Dim dtsGrabaArchivo As New vVenta
        Dim funcGrabaArchivo As New fventa

        dtsGrabaArchivo.gcod_Venta = TxtCod_venta.Text
        dtsGrabaArchivo.gcood_Cliente = txtCod_cliente.Text
        dtsGrabaArchivo.garchivo = gArchivo


        If funcGrabaArchivo.grabaArchivo(dtsGrabaArchivo) Then

        Else

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
        btnRegistrar.Enabled = False
        btnAñadir.Enabled = False
        BtnCerrar.Enabled = False
        BtnNuevo.Enabled = True
        TxtCod_venta.Text = ""
        txtCod_cliente.Text = ""
        txtRuc.Text = ""
        TxtNombre.Text = ""
        txtSerie.Text = ""
        txtRefer.Text = 0
        txtTC.Text = 0
        txtSerie.Text = "F001"
        dtpFecha.Value = Date.Today
        dtpVence.Value = Date.Today
        cmbBoxOper.Text = "Venta Interna"
        cmbBoxMoneda.Text = "S/."
        txtTC.Enabled = False
        txtTotal.Text = ""
        txtLetras.Text = ""
        lblEstado.Text = ""

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
        txtRefer.Enabled = False

    End Sub



    Public Sub desbloquear()
        dtpFecha.Enabled = True
        BtnBuscarCliente.Enabled = True
        cmbBoxOper.Enabled = True
        cmbBoxMoneda.Enabled = True
        btnRegistrar.Enabled = True
        '' 'btnAñadir.Enabled = True
        'txtTC.Enabled = True
        dtpVence.Enabled = True
        'txtRefer.Enabled = True

    End Sub

    Private Sub BtnBuscarCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscarCliente.Click
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
    End Sub

    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        If datalistadoVenta.SelectedCells.Item(15).Value = 0 Then
            If txtTotal.Text > 0 Then
                Dim codVta As String
                Dim codCli As String



                codVta = datalistadoVenta.SelectedCells.Item(1).Value
                codCli = datalistadoVenta.SelectedCells.Item(3).Value
                crearCabeceraFac(codVta)

                crearDetalleFac(codVta, codCli)
                crearTri(codVta, codCli)
                crearLey(codVta, codCli, Trim(txtLetras.Text))
                'crearAca(codVta, codCli)
                Dim dtsCerrar As New vVenta
                Dim funcCerrar As New fventa


                dtsCerrar.gcod_Venta = TxtCod_venta.Text
                dtsCerrar.gcood_Cliente = txtCod_cliente.Text
                dtsCerrar.gletras = txtLetras.Text
                dtsCerrar.greferencial = txtRefer.Text



                If funcCerrar.cierraFac(dtsCerrar) Then
                    MessageBox.Show("Factura cerrada ", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    mostrar()
                    bloquear()
                Else
                    MessageBox.Show("NO SE pudo cerrar la Factura", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    mostrar()
                    bloquear()
                End If

            Else
                MessageBox.Show("Añadir Detalle", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Factura Cerrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub



    Private Sub FrmVenta_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        bloquear()
        mostrar()
        'cargarCat51()


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        buscar()

    End Sub

    Private Sub datalistadoVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoVenta.CellClick
        bloquear()
        btnAñadir.Enabled = True
        BtnCerrar.Enabled = True
        TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        Dim fechaVta As String = datalistadoVenta.SelectedCells.Item(2).Value
        Dim fecha As String = ""
        fecha = Mid(fechaVta, 9, 2) + "/" + Mid(fechaVta, 6, 2) + "/" + Mid(fechaVta, 1, 4)
        dtpFecha.Value = Convert.ToDateTime(fecha)
        txtCod_cliente.Text = datalistadoVenta.SelectedCells.Item(3).Value
        txtRuc.Text = datalistadoVenta.SelectedCells.Item(4).Value
        TxtNombre.Text = datalistadoVenta.SelectedCells.Item(5).Value
        txtSerie.Text = datalistadoVenta.SelectedCells.Item(6).Value
        txtRefer.Text = datalistadoVenta.SelectedCells.Item(7).Value
        cmbBoxOper.Text = "Venta Interna"
        Dim moneda As String = datalistadoVenta.SelectedCells.Item(9).Value
        If moneda = "PEN" Then
            cmbBoxMoneda.Text = "S/."
        Else
            If moneda = "USD" Then
                cmbBoxMoneda.Text = "$"
            Else
                cmbBoxMoneda.Text = "€"
            End If
        End If

        txtTC.Text = datalistadoVenta.SelectedCells.Item(10).Value
        txtTC.Enabled = False

        Dim fechaVce As String = datalistadoVenta.SelectedCells.Item(11).Value
        Dim fecha2 As String = ""
        fecha2 = Mid(fechaVce, 9, 2) + "/" + Mid(fechaVce, 6, 2) + "/" + Mid(fechaVce, 1, 4)
        dtpVence.Value = Convert.ToDateTime(fecha2)
        txtTotal.Text = datalistadoVenta.SelectedCells.Item(14).Value
        letras(txtTotal.Text, moneda)
        Dim estado As String = datalistadoVenta.SelectedCells.Item(15).Value
        If estado = "0" Then
            lblEstado.Text = "Open"
            lblEstado.ForeColor = Color.Red
        Else
            lblEstado.Text = "Close"
            lblEstado.ForeColor = Color.Black
        End If



    End Sub


    Private Sub datalistadoVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoVenta.CellDoubleClick



        'Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        '    Detalle_Venta.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ReporteComprasCliente.ShowDialog()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.ValidateChildren = True And txtCod_cliente.Text <> "" And TxtNombre.Text <> "" Then

            If cmbBoxMoneda.Text <> "S/." Then
                If txtTC.Text = "" Then
                    MessageBox.Show("Falta ingresar Tipo Cambio", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTC.Focus()
                    Return
                End If
            End If


            Dim dts As New vVenta
            Dim func As New fventa
            Dim fvta As String
            fvta = dtpFecha.Value.ToString("yyyy/MM/dd")
            Dim fvto As String
            fvto = dtpVence.Value.ToString("yyyy/MM/dd")
            dts.gcood_Cliente = txtCod_cliente.Text

            Dim serieF As New fventa
            dt = serieF.mostrar_serieF
            Dim fac As String = Trim(dt.Rows(0)("Serie"))
            Dim fac2 As String = Trim(dt.Rows(0)("Serie"))
            If fac.Length <= 3 Then
                If fac.Length = 2 Then
                    fac = "0" + fac
                Else
                    If fac.Length = 1 Then
                        fac = "00" + fac
                    End If
                End If
            Else
                fac = "xxx"
                fac2 = "xxx"
            End If
            dts.gserie = "F001"
            '+ fac

            dts.greferencial = fac
            'txtRefer.Text


            dts.gtipooper = "0101"
            dts.gfecha_venta = Mid(fvta, 1, 4) + "-" + Mid(fvta, 6, 2) + "-" + Mid(fvta, 9, 2)

            dts.ghora_emision = TimeOfDay
            dts.gfecha_vencimiento = Mid(fvto, 1, 4) + "-" + Mid(fvto, 6, 2) + "-" + Mid(fvto, 9, 2)
            '  dts.gtotal_a_pagar = "0"
            dts.gnro_doc = txtRuc.Text
            dts.gcliente = TxtNombre.Text
            If cmbBoxMoneda.Text = "S/." Then
                dts.gtip_moneda = "PEN"
                dts.gTC = 0.0
            Else
                If cmbBoxMoneda.Text = "$" Then
                    dts.gtip_moneda = "USD"
                Else
                    dts.gtip_moneda = "EUR"
                End If
                dts.gTC = txtTC.Text
            End If

            dts.gigv = 0
            dts.gventa = 0
            dts.gtotal = 0
            dts.gletras = txtLetras.Text

            If func.insertar(dts, fac2) Then
                MessageBox.Show("Venta registrada correctamente, INGRESE PRODUCTOS", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                mostrar()
                bloquear()
            Else
                MessageBox.Show("NO SE PUDO REGISTRAR LA VENTA", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                mostrar()
                bloquear()
            End If


            Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value






        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If datalistadoVenta.SelectedCells.Item(15).Value = 0 Then
            Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
            Detalle_Venta.txtSerie.Text = datalistadoVenta.SelectedCells.Item(6).Value
            Detalle_Venta.txtCliente.Text = datalistadoVenta.SelectedCells.Item(5).Value
            Detalle_Venta.txtCodCliente.Text = datalistadoVenta.SelectedCells.Item(3).Value
            Detalle_Venta.txtcantidad.Text = ""
            Detalle_Venta.txtPVenta.Text = ""
            Detalle_Venta.txtPTotal.Text = ""
            Detalle_Venta.txtIGV.Text = ""
            Detalle_Venta.txtPUnitario.Text = ""

            Detalle_Venta.ShowDialog()
        Else
            MessageBox.Show("Factura Cerrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        Return
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

    Private Sub cargarCat51()
        Dim func As New fventa
        dt = func.mostrarCat51

        'Dim strCmbTipo1 As String
        'Dim strCmbTipo2 As String
        'strCmbTipo1 = Trim(dt.Rows(0)("Codigo"))
        'strCmbTipo2 = Trim(dt.Rows(0)("Descripcion"))

        cmbBoxOper.DataSource = dt
        cmbBoxOper.DisplayMember = "Descripcion"
        cmbBoxOper.ValueMember = "Codigo"

    End Sub

    Private Sub cmbBoxMoneda_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBoxMoneda.SelectedValueChanged
        If cmbBoxMoneda.Text = "S/." Then
            txtTC.Text = ""
            txtTC.Enabled = False
        Else
            txtTC.Text = ""
            txtTC.Enabled = True

        End If
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

    Private Sub txtTC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTC.KeyPress
        NumerosyDecimal(txtTC, e)
    End Sub
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    Public Sub txtRefer__KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        'eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtRefer.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub crearDetalleFac(codVenta As String, codCli As String)
        Dim func As New fventa
        dt = func.crearDetalleFac(codVenta, codCli)
        Dim archivo As StreamWriter
        Dim linea As String = Nothing
        archivo = New StreamWriter(dtlle)
        Dim con As Integer = dt.Rows.Count - 1
        For i = 0 To con
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
            Dim campo21 As String
            Dim campo22 As String
            Dim campo23 As String
            Dim campo24 As String
            Dim campo25 As String
            Dim campo26 As String
            Dim campo27 As String
            Dim campo28 As String
            Dim campo29 As String
            Dim campo30 As String



            campo1 = Trim(dt.Rows(i)("campo1"))
            campo2 = Trim(dt.Rows(i)("campo2"))
            campo3 = Trim(dt.Rows(i)("campo3"))
            campo4 = Trim(dt.Rows(i)("campo4"))
            campo5 = Trim(dt.Rows(i)("campo5"))
            campo6 = Trim(dt.Rows(i)("campo6"))
            campo7 = Trim(dt.Rows(i)("campo7"))
            campo8 = Trim(dt.Rows(i)("campo8"))
            campo9 = Trim(dt.Rows(i)("campo9"))
            campo10 = Trim(dt.Rows(i)("campo10"))
            campo11 = Trim(dt.Rows(i)("campo11"))
            campo12 = Trim(dt.Rows(i)("campo12"))
            campo13 = Trim(dt.Rows(i)("campo13"))
            campo14 = Trim(dt.Rows(i)("campo14"))
            campo15 = Trim(dt.Rows(i)("campo15"))
            campo16 = Trim(dt.Rows(i)("campo16"))
            campo17 = Trim(dt.Rows(i)("campo17"))
            campo18 = Trim(dt.Rows(i)("campo18"))
            campo19 = Trim(dt.Rows(i)("campo19"))
            campo20 = Trim(dt.Rows(i)("campo20"))
            campo21 = Trim(dt.Rows(i)("campo21"))
            campo22 = Trim(dt.Rows(i)("campo22"))
            campo23 = Trim(dt.Rows(i)("campo23"))
            campo24 = Trim(dt.Rows(i)("campo24"))
            campo25 = Trim(dt.Rows(i)("campo25"))
            campo26 = Trim(dt.Rows(i)("campo26"))
            campo27 = Trim(dt.Rows(i)("campo27"))
            campo28 = Trim(dt.Rows(i)("campo28"))
            campo29 = Trim(dt.Rows(i)("campo29"))
            campo30 = Trim(dt.Rows(i)("campo30"))




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
                    campo18 & "|" & _
                    campo19 & "|" & _
                    campo20 & "|" & _
                    campo21 & "|" & _
                    campo22 & "|" & _
                    campo23 & "|" & _
                    campo24 & "|" & _
                    campo25 & "|" & _
                    campo26 & "|" & _
                    campo27 & "|" & _
                    campo28 & "|" & _
                    campo29 & "|" & _
                    campo30 & "|"







            ' If linea.Substring(0, 1) = "|" Then

            '            Else
            archivo.WriteLine(linea)
        Next
        MsgBox("txt creado")
        '           End If
        archivo.Close()
    End Sub

    Private Sub crearTri(codVenta As String, codCli As String)
        Dim func As New fventa
        dt = func.crearTri(codVenta, codCli)
        Dim archivo As StreamWriter
        Dim linea As String = Nothing
        archivo = New StreamWriter(tri)
        Dim con As Integer = dt.Rows.Count - 1
        For i = 0 To con
            Dim campo1 As String
            Dim campo2 As String
            Dim campo3 As String
            Dim campo4 As String
            Dim campo5 As String



            campo1 = Trim(dt.Rows(i)("campo1"))
            campo2 = Trim(dt.Rows(i)("campo2"))
            campo3 = Trim(dt.Rows(i)("campo3"))
            campo4 = Trim(dt.Rows(i)("campo4"))
            campo5 = Trim(dt.Rows(i)("campo5"))



            linea = campo1 & "|" & _
                    campo2 & "|" & _
                    campo3 & "|" & _
                    campo4 & "|" & _
                    campo5 & "|"


            ' If linea.Substring(0, 1) = "|" Then

            '            Else
            archivo.WriteLine(linea)
        Next
        MsgBox("txt creado")
        '           End If
        archivo.Close()
    End Sub



    Private Sub crearLey(codVenta As String, codCli As String, letras As String)
        Dim func As New fventa
        dt = func.crearLeyAca(codVenta, codCli)
        Dim archivo As StreamWriter
        Dim linea As String = Nothing
        archivo = New StreamWriter(ley)
        ' Dim con As Integer = dt.Rows.Count - 1
        '  For i = 0 To con
        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String



        campo1 = Trim(dt.Rows(0)("campo1"))
        campo2 = Trim(letras)
        campo3 = Trim(dt.Rows(0)("campo3"))
        campo4 = Trim(dt.Rows(0)("campo4"))
        campo5 = Trim(dt.Rows(0)("campo5"))
        campo6 = Trim(dt.Rows(0)("campo6"))



        linea = campo1 & "|" & _
                campo2 & "|"


        ' If linea.Substring(0, 1) = "|" Then

        '            Else
        archivo.WriteLine(linea)
        '   Next
        MsgBox("txt creado")
        '           End If
        archivo.Close()
    End Sub

    Private Sub crearAca(codVenta As String, codCli As String)
        Dim func As New fventa
        dt = func.crearLeyAca(codVenta, codCli)
        Dim archivo As StreamWriter
        Dim linea As String = Nothing
        archivo = New StreamWriter(aca)
        'Dim con As Integer = dt.Rows.Count - 1
        'For i = 0 To con
        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String


        campo1 = Trim(dt.Rows(0)("campo1"))
        campo2 = Trim(dt.Rows(0)("campo2"))
        campo3 = Trim(dt.Rows(0)("campo3"))
        campo4 = Trim(dt.Rows(0)("campo4"))
        campo5 = Trim(dt.Rows(0)("campo5"))
        campo6 = Trim(dt.Rows(0)("campo6"))



        linea = campo6 & "|" & _
                campo6 & "|" & _
                campo6 & "|" & _
                campo6 & "|" & _
                campo6 & "|" & _
                campo3 & "|" & _
                campo4 & "|" & _
                campo5 & "|" & _
                campo6 & "|" & _
                campo6 & "|" & _
                campo6 & "|"


        ' If linea.Substring(0, 1) = "|" Then

        '            Else
        archivo.WriteLine(linea)
        ' Next
        MsgBox("txt creado")
        '           End If
        archivo.Close()
    End Sub




    Public Sub letras(ByVal numero As String, ByVal moneda As String)
        Dim final As String
        If moneda = "PEN" Then
            final = "SOLES"
        Else
            If moneda = "USD" Then
                final = "DOLARES AMERICANOS"
            Else
                final = "EUROS"
            End If
        End If
        Dim ctdadEntera As String = Int(numero)
        Dim vColeccion() As String = numero.Split(".")
        Dim ctdadDecimal As String = vColeccion(vColeccion.Length - 1)
        Dim arr(ctdadEntera.Length - 1) As String
        Dim inicia As Integer = 0
        Ul = ""
        Dl = ""
        Cl = ""
        Ml = ""
        DMl = ""
        CMl = ""

        For i = 0 To ctdadEntera.Length - 1
            arr(inicia) = ctdadEntera(inicia)
            inicia = inicia + 1
        Next
        If ctdadEntera.Length = 1 Then
            U = arr(0)
            unidades()
            Ml = ""
            Cl = ""
            Dl = ""
        ElseIf ctdadEntera.Length = 2 Then
            D = arr(0)
            U = arr(1)
            Decenas()
            Ml = ""
            Cl = ""
        ElseIf ctdadEntera.Length = 3 Then
            C = arr(0)
            D = arr(1)
            U = arr(2)
            centenas()
            Decenas()
            Ml = ""
            DMl = ""
            CMl = ""
        ElseIf ctdadEntera.Length = 4 Then
            M = arr(0)
            C = arr(1)
            D = arr(2)
            U = arr(3)
            unMil()
            centenas()
            Decenas()
            DMl = ""
            CMl = ""
        ElseIf ctdadEntera.Length = 5 Then
            DM = arr(0)
            M = arr(1)
            C = arr(2)
            D = arr(3)
            U = arr(4)
            DecMil()
            centenas()
            Decenas()
            CMl = ""
        ElseIf ctdadEntera.Length = 6 Then
            CM = arr(0)
            DM = arr(1)
            M = arr(2)
            C = arr(3)
            D = arr(4)
            U = arr(5)
            cenMil()
            DecMil()
            centenas()
            Decenas()
        End If


        letra = CMl + " " + DMl + Ml + " " + Cl + " " + Dl + Ul + " y " + ctdadDecimal + "/100 " + final
        txtLetras.Text = letra

    End Sub

    Private Sub centenas()
        If C > 0 Then
            If C = 1 Then
                Cl = "Ciento"
            ElseIf C = 2 Then
                Cl = "Doscientos"
            ElseIf C = 3 Then
                Cl = "Trescientos"
            ElseIf C = 4 Then
                Cl = "Cuatrocientos"
            ElseIf C = 5 Then
                Cl = "Quinientos"
            ElseIf C = 6 Then
                Cl = "Seiscientos"
            ElseIf C = 7 Then
                Cl = "Setecientos"
            ElseIf C = 8 Then
                Cl = "Ochocientos"
            ElseIf C = 9 Then
                Cl = "Novecientos"
            End If

        Else
            Cl = ""
        End If
    End Sub

    Private Sub Decenas()
        If D = 0 Then
            Dl = ""
            unidades()
        Else
            If D = 1 And U = 0 Then
                Dl = "Diez"
                Ul = ""
            ElseIf D = 1 And U = 1 Then
                Dl = "Once"
            ElseIf D = 1 And U = 2 Then
                Dl = "Doce"
            ElseIf D = 1 And U = 3 Then
                Dl = "Trece"
            ElseIf D = 1 And U = 4 Then
                Dl = "Catorce"
            ElseIf D = 1 And U = 5 Then
                Dl = "Quince"
            ElseIf D = 1 And U > 5 Then
                Dl = "Diez y "
                unidades()
            ElseIf D > 1 And U > 0 Then
                If D = 2 Then
                    Dl = "Veinti"
                ElseIf D = 3 Then
                    Dl = "Treinta y "
                ElseIf D = 4 Then
                    Dl = "Cuarenta y "
                ElseIf D = 5 Then
                    Dl = "Cincuenta y "
                ElseIf D = 6 Then
                    Dl = "Sesenta y "
                ElseIf D = 7 Then
                    Dl = "Setenta y "
                ElseIf D = 8 Then
                    Dl = "Ochenta y "
                ElseIf D = 9 Then
                    Dl = "Noventa y "
                End If
                unidades()
            Else
                If D = 2 Then
                    Dl = "Veinte"
                ElseIf D = 3 Then
                    Dl = "Treinta"
                ElseIf D = 4 Then
                    Dl = "Cuarenta"
                ElseIf D = 5 Then
                    Dl = "Cincuenta"
                ElseIf D = 6 Then
                    Dl = "Sesenta"
                ElseIf D = 7 Then
                    Dl = "Setenta"
                ElseIf D = 8 Then
                    Dl = "Ochenta"
                ElseIf D = 9 Then
                    Dl = "Noventa"
                End If
                Ul = ""

            End If
            End If
    End Sub

    Private Sub unidades()
        If U > 0 Then
            If U = 1 Then
                Ul = "uno"
            ElseIf U = 2 Then
                Ul = "dos"
            ElseIf U = 3 Then
                Ul = "tres"
            ElseIf U = 4 Then
                Ul = "cuatro"
            ElseIf U = 5 Then
                Ul = "cinco"
            ElseIf U = 6 Then
                Ul = "seis"
            ElseIf U = 7 Then
                Ul = "siete"
            ElseIf U = 8 Then
                Ul = "ocho"
            ElseIf U = 9 Then
                Ul = "nueve"
            End If
        End If
    End Sub

    Private Sub cenMil()
        If CM > 0 Then
            If CM = 1 Then
                CMl = "Ciento"
            ElseIf CM = 2 Then
                CMl = "Doscientos"
            ElseIf CM = 3 Then
                CMl = "Trescientos"
            ElseIf CM = 4 Then
                CMl = "Cuatrocientos"
            ElseIf CM = 5 Then
                CMl = "Quinientos"
            ElseIf CM = 6 Then
                CMl = "Seiscientos"
            ElseIf CM = 7 Then
                CMl = "Setecientos"
            ElseIf CM = 8 Then
                CMl = "Ochocientos"
            ElseIf CM = 9 Then
                CMl = "Novecientos"
            End If
        Else
            CMl = ""
        End If
    End Sub


    Private Sub DecMil()
        If DM = 0 Then
            DMl = ""
            unMil()
        Else
            If DM = 1 And M = 0 Then
                DMl = "Diez Mil"
                Ml = ""
            ElseIf DM = 1 And M = 1 Then
                DMl = "Once Mil"
            ElseIf DM = 1 And M = 2 Then
                DMl = "Doce Mil"
            ElseIf DM = 1 And M = 3 Then
                DMl = "Trece Mil"
            ElseIf DM = 1 And M = 4 Then
                DMl = "Catorce Mil"
            ElseIf DM = 1 And M = 5 Then
                DMl = "Quince Mil"
            ElseIf DM = 1 And M > 5 Then
                DMl = "Diez y "
                unMil()
            ElseIf DM > 1 And M > 0 Then
                If DM = 2 Then
                    DMl = "Veinti"
                ElseIf DM = 3 Then
                    DMl = "Treinta y "
                ElseIf DM = 4 Then
                    DMl = "Cuarenta y "
                ElseIf DM = 5 Then
                    DMl = "Cincuenta y "
                ElseIf DM = 6 Then
                    DMl = "Sesenta y "
                ElseIf DM = 7 Then
                    DMl = "Setenta y "
                ElseIf DM = 8 Then
                    DMl = "Ochenta y "
                ElseIf DM = 9 Then
                    DMl = "Noventa y "
                End If
                unMil()
            Else
                If DM = 2 Then
                    DMl = "Veinte Mil"
                ElseIf DM = 3 Then
                    DMl = "Treinta Mil"
                ElseIf DM = 4 Then
                    DMl = "Cuarenta Mil"
                ElseIf DM = 5 Then
                    DMl = "Cincuenta Mil"
                ElseIf DM = 6 Then
                    DMl = "Sesenta Mil"
                ElseIf DM = 7 Then
                    DMl = "Setenta Mil"
                ElseIf DM = 8 Then
                    DMl = "Ochenta Mil"
                ElseIf DM = 9 Then
                    DMl = "Noventa Mil"
                End If
                Ml = ""

            End If
        End If
    End Sub

    Private Sub unMil()
        If M > 0 Then
            If M = 1 Then
                Ml = "Mil"
            ElseIf M = 2 Then
                Ml = "Dos Mil"
            ElseIf M = 3 Then
                Ml = "Tres Mil"
            ElseIf M = 4 Then
                Ml = "Cuatro Mil"
            ElseIf M = 5 Then
                Ml = "Cinco Mil"
            ElseIf M = 6 Then
                Ml = "Seis Mil"
            ElseIf M = 7 Then
                Ml = "Siete Mil"
            ElseIf M = 8 Then
                Ml = "Ocho Mil"
            ElseIf M = 9 Then
                Ml = "Nueve Mil"
            End If
        End If
    End Sub



End Class