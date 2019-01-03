Imports System.IO
Imports System.Globalization

Public Class FrmListFactura
    Private dt As DataTable
    Public U, D, C, M, DM, CM As String
    Public CMl, DMl, Ml, Cl, Dl, Ul As String
    Public letra As String
    Private Property dtlle As String

    Private Property tri As String

    Private Property ley As String

    Private Property aca As String



    Public Sub mostrar()
        'limpiar()
        datalistadoFactura.DataSource = Nothing
        Dim func As New fventa


        dt = func.mostrar_ListaFac
        ' datalistadoFactura.Columns.Item("Eliminar").Visible = False



        If dt.Rows.Count <> 0 Then
            datalistadoFactura.DataSource = dt
            addSFS(datalistadoFactura)
            Txtbuscar.Enabled = True
            datalistadoFactura.ColumnHeadersVisible = True
            inexistente.Visible = False
            '     cbeliminar.Visible = True
            '     BtnEliminar.Visible = True
        Else
            datalistadoFactura.DataSource = Nothing
            Txtbuscar.Enabled = False
            datalistadoFactura.ColumnHeadersVisible = False
            inexistente.Visible = True
            '   cbeliminar.Visible = False
            '   BtnEliminar.Visible = False
        End If
        Txtbuscar.Focus()


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
        Dim nombre2 As String
        nombre = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA\"
        nombre2 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA\"
        nombre = nombre + campo7 + "-01-" + campo19 + "-" + campo20 + ".cab"
        dtlle = nombre2 + campo7 + "-01-" + campo19 + "-" + campo20 + ".det"
        tri = nombre2 + campo7 + "-01-" + campo19 + "-" + campo20 + ".tri"
        ley = nombre2 + campo7 + "-01-" + campo19 + "-" + campo20 + ".ley"
        aca = nombre2 + campo7 + "-01-" + campo19 + "-" + campo20 + ".aca"

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
                    datalistadoFactura.DataSource = dv
                    addSFS(datalistadoFactura)
 
                Else
                    inexistente.Visible = True
                    datalistadoFactura.DataSource = Nothing
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
                    datalistadoFactura.DataSource = dv
                    addSFS(datalistadoFactura)

                Else
                    inexistente.Visible = True
                    datalistadoFactura.DataSource = Nothing
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
        ' cbocampos.Text = "Cliente"
        ' Txtbuscar.Text = ""
        lblXml.Text = ""
        lblPdf.Text = ""
        lblCDR.Text = ""
        lblFactura.Text = ""
        btnPdf.Visible = False
        btnEnviar.Visible = False
        btnEstado.Visible = False


    End Sub

    Public Sub bloquear()

 
    End Sub



    Public Sub desbloquear()
 

 
    End Sub

    Private Sub BtnBuscarCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
    End Sub

    Private Sub btnbuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        limpiar()
        buscar()

    End Sub

    Private Sub datalistadoVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoFactura.CellClick
        limpiar()
        lblFactura.Text = "Factura : " + Trim(datalistadoFactura.SelectedCells.Item(6).Value) + "-" + Trim(datalistadoFactura.SelectedCells.Item(7).Value)
        btnEstado.Visible = True
        Xml()
        Pdf()
        Cdr()



    End Sub


    Private Sub datalistadoVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoFactura.CellDoubleClick



        'Detalle_Venta.TxtCod_venta.Text = datalistadoVenta.SelectedCells.Item(1).Value
        '    Detalle_Venta.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ReporteComprasCliente.ShowDialog()
    End Sub



    Private Sub btnAñadir_Click(sender As Object, e As EventArgs)
        If datalistadoFactura.SelectedCells.Item(15).Value = 0 Then
            Detalle_Venta.TxtCod_venta.Text = datalistadoFactura.SelectedCells.Item(1).Value
            Detalle_Venta.txtSerie.Text = datalistadoFactura.SelectedCells.Item(6).Value
            Detalle_Venta.txtCliente.Text = datalistadoFactura.SelectedCells.Item(5).Value
            Detalle_Venta.txtCodCliente.Text = datalistadoFactura.SelectedCells.Item(3).Value
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

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs)
        '   If cbeliminar.CheckState = CheckState.Checked Then
        ' datalistadoFactura.Columns.Item("eliminar").Visible = True
        ' BtnEliminar.Enabled = True
        ' Else
        ' datalistadoFactura.Columns.Item("eliminar").Visible = False
        ' BtnEliminar.Enabled = False
        ' End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs)
        Return
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar estos productos", "Eliminar productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Try
                    For Each row As DataGridViewRow In datalistadoFactura.Rows
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


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs)
        limpiar()
        desbloquear()

    End Sub

    Private Sub cargarCat51()
        Dim func As New fventa
        dt = func.mostrarCat51


        '        cmbBoxOper.DataSource = dt
        '        cmbBoxOper.DisplayMember = "Descripcion"
        '        cmbBoxOper.ValueMember = "Codigo"

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
    Public Sub txtRefer__KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub Xml()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\ENVIO"
            archivoFinal = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".zip"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                lblXml.ForeColor = Color.Green
                lblXml.Text = "XML generado"

            Next
        Catch ex As Exception

            'MsgBox("No se realizó la operación por: " & ex.Message)
        End Try
    End Sub
    Public Function dtFacXml(ByVal iRows As Integer) As Boolean
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\ENVIO"
            archivoFinal = Trim(datalistadoFactura.Rows(iRows).Cells(15).Value) + ".zip"
            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                Return True
            Next
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Pdf()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\REPO"
            archivoFinal = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".pdf"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                lblPdf.ForeColor = Color.Green
                lblPdf.Text = "PDF generado"
                btnPdf.Visible = True

            Next
        Catch ex As Exception


        End Try
    End Sub
    Function dtFacPdf(ByVal irows As Integer) As Boolean
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\REPO"
            archivoFinal = Trim(datalistadoFactura.Rows(irows).Cells(15).Value) + ".pdf"
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                Return True
            Next
        Catch ex As Exception
            Return False

        End Try
    End Function
    Private Sub Cdr()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\RPTA"
            archivoFinal = "R" + Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".zip"
            ' ruta = ruta + archivoFinal

            'Dim Total = My.Computer.FileSystem.GetFiles("C:\Tutoriales", FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
            'LblTotal.Text = "Total Archivos de Texto: " + CStr(Total.Count)

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                lblCDR.ForeColor = Color.Green
                lblCDR.Text = "Enviado y Aceptado SUNAT"
                btnEnviar.Visible = True
                btnEstado.Visible = False
                'ListBox1.Items.Add(archivos)
            Next
        Catch ex As Exception
            btnEstado.Visible = True
            'MsgBox("No se realizó la operación por: " & ex.Message)
        End Try

    End Sub
    Public Function dtFacCdr(ByVal irows As Integer) As Boolean

        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\RPTA"
            archivoFinal = "R" + Trim(datalistadoFactura.Rows(irows).Cells(15).Value) + ".zip"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                Return True

            Next
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        Dim ruta As String
        Dim archivoFinal As String
        ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\REPO\"
        archivoFinal = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".pdf"
        With New Process
            '.StartInfo.Verb = "print"
            .StartInfo.CreateNoWindow = False
            .StartInfo.FileName = ruta + archivoFinal
            .Start()
            '.WaitForExit(10000)
            '.CloseMainWindow()
            .Close()
        End With
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click


        credencialesCorreo.txtflag.Text = "1"
        credencialesCorreo.ShowDialog()
        
        If credencialesCorreo.txtflag.Text = "1" Then
            Dim Emisor As String = txtEmisor.Text

            Dim Password As String = txtPassword.Text

            Dim Mensaje As String = "SFS Sunat Emision Factura Electronica"

            Dim Asunto As String = "Factura " + Mid(Trim(datalistadoFactura.SelectedCells.Item(15).Value), 17, Trim(datalistadoFactura.SelectedCells.Item(15).Value).Length - 1)

            Dim Receptor As String = Trim(datalistadoFactura.SelectedCells.Item(16).Value)
            Dim ruta1 As String
            Dim archivoFinal1 As String
            ruta1 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\REPO\"
            archivoFinal1 = ruta1 + Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".pdf"
            Dim RutaArchivo1 As String = archivoFinal1
            Dim ruta2 As String
            Dim archivoFinal2 As String
            ruta2 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\RPTA\"
            archivoFinal2 = ruta2 + "R" + Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".zip"
            Dim RutaArchivo2 As String = archivoFinal2
            enviarCorreo(Emisor, Password, Mensaje, Asunto, Receptor, RutaArchivo1, RutaArchivo2)

        Else
            MessageBox.Show("No ingresó Credenciales", "Correo no enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub configSTMP()


        ' Usando el cliente como nuevo Imap ()
        ''client.ConnectSSL("imap-mail.outlook.com")
        ''client.UseBestLogin("pat@hotmail.com", "contraseña")

        ' Terminar de usar

        'Usando el cliente como nuevo Pop3 ()
        ''client.ConnectSSL("pop-mail.outlook.com")
        ''client.UseBestLogin("pat@hotmail.com", "contraseña")

        'Terminar de usar

        'Usando el cliente como nuevo smtp ()
        ''client.Connect("smtp-mail.outlook.com")
        ''Cliente.StartTLS()
        ''client.UseBestLogin("pat@hotmail.com", "contraseña")

        'Terminar de usar
    End Sub

    Private Sub addSFS(dataGridView As DataGridView)
        For i As Integer = 0 To dataGridView.Rows.Count - 1

            If dtFacXml(i) Then
                dataGridView.Rows(i).Cells(0).Value = "Generado"
            Else
                dataGridView.Rows(i).Cells(0).Value = ""
            End If

            If dtFacPdf(i) Then
                dataGridView.Rows(i).Cells(1).Value = "Generado"
            Else
                dataGridView.Rows(i).Cells(1).Value = ""
            End If

            If dtFacCdr(i) Then
                dataGridView.Rows(i).Cells(2).Value = "Aceptado"
            Else
                dataGridView.Rows(i).Cells(2).Value = ""
            End If




        Next i
    End Sub



    Private Sub FrmListFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiar()
        bloquear()
        mostrar()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        limpiar()
        cbocampos.Text = "Cliente"
        Txtbuscar.Text = ""
        bloquear()
        mostrar()
    End Sub

    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Cambiar de Estado?", "Modificando Estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Dim dtsAbrir As New vVenta
                Dim funcAbrir As New fventa


                dtsAbrir.gcod_Venta = Trim(datalistadoFactura.SelectedCells.Item(10).Value)


                If funcAbrir.abrirFac(dtsAbrir) Then
                    borrarDB()
                    borrarSFS()

                    MessageBox.Show("Cambio de Estado", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    bloquear()
                    mostrar()
                Else
                    MessageBox.Show("Estado no fue modificado", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    bloquear()
                    mostrar()
                End If

            End If
        End If
        bloquear()
        ' BtnGuardar.Enabled = False
    End Sub

    Private Sub borrarDB()
        Dim func As New crud
        Dim ARCH As String = Trim(datalistadoFactura.SelectedCells.Item(15).Value)

        If func.eliminar(ARCH) Then
        Else
            MessageBox.Show("Error", "No se Elimino DB SFS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


    Private Sub borrarSFS()
        borrarXML()
        borrarPDF()
        borrarDOCS()
    End Sub

    Function borrarXML()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\ENVIO"
            archivoFinal = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".zip"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivoFinal)

            Next

            Dim ruta2 As String
            Dim archivoFinal2 As String
            ruta2 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\FIRMA"
            archivoFinal2 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".xml"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta2, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal2)
                My.Computer.FileSystem.DeleteFile(ruta2 + "\" + archivoFinal2)

            Next

            Dim ruta3 As String
            Dim archivoFinal3 As String
            ruta3 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\ORIDAT"
            archivoFinal3 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".xml"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta3, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal3)
                My.Computer.FileSystem.DeleteFile(ruta3 + "\" + archivoFinal3)

            Next

            Dim ruta4 As String
            Dim archivoFinal4 As String
            ruta4 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\PARSE"
            archivoFinal4 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".xml"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta4, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal4)
                My.Computer.FileSystem.DeleteFile(ruta4 + "\" + archivoFinal4)

            Next

            Dim ruta5 As String
            Dim archivoFinal5 As String
            ruta5 = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\TEMP"
            archivoFinal5 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".xml"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta5, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal5)
                My.Computer.FileSystem.DeleteFile(ruta5 + "\" + archivoFinal5)

            Next





        Catch ex As Exception

            'MsgBox("No se realizó la operación por: " & ex.Message)
        End Try
    End Function

    Function borrarPDF()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivoFinal As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\REPO"
            archivoFinal = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".pdf"

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivoFinal)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivoFinal)

            Next
        Catch ex As Exception


        End Try
    End Function

    Function borrarDOCS()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim ruta As String
            Dim archivo1 As String
            Dim archivo2 As String
            Dim archivo3 As String
            Dim archivo4 As String
            Dim archivo5 As String
            ruta = "D:\FACTURADOR\SFS_v1.2\sunat_archivos\sfs\DATA"
            archivo1 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".cab"
            archivo2 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".det"
            archivo3 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".ley"
            archivo4 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".tri"
            archivo5 = Trim(datalistadoFactura.SelectedCells.Item(15).Value) + ".aca"
            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, archivo1)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivo1)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivo2)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivo3)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivo4)
                My.Computer.FileSystem.DeleteFile(ruta + "\" + archivo5)

            Next
        Catch ex As Exception


        End Try

    End Function


End Class