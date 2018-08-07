Public Class FrmProveedor
    Private dt As New DataTable

    Private Sub FrmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        mostrar()
        bloquear()

    End Sub
    Private Shared Function EmailValido(strEmail As String) As Boolean
        ' Retorna verdadero si strEmail es un formato de E-mail valido.
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Public Sub bloquear()
        TxtProveedor.Enabled = False
        TxtDireccion.Enabled = False
        TxtTelefono.Enabled = False
        TxtCorreo.Enabled = False
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = False

    End Sub
    'FUNCION PARA PERMITIR SOLO NUMEROS DECIMALES
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
    '-----------------------------------------------------------
    Public Sub TxtTelefono_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtTelefono.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub mostrar()
        Try

        Dim func As New fProveedor

        dt = func.mostrar
        datalistadoProveedor.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoProveedor.DataSource = dt
            Txtbuscar.Enabled = True
            datalistadoProveedor.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoProveedor.DataSource = Nothing
                Txtbuscar.Enabled = False
            datalistadoProveedor.ColumnHeadersVisible = False
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
            If Txtbuscar.Text <> "" Then


                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))


                dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    datalistadoProveedor.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoProveedor.DataSource = Nothing
                End If
            Else
                mostrar()
                bloquear()

            End If

        Catch ex As Exception

            If Txtbuscar.Text <> "" Then


                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))


                dv.RowFilter = cbocampos.Text & " = " & Txtbuscar.Text & ""
                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    datalistadoProveedor.DataSource = dv

                Else
                    inexistente.Visible = True
                    datalistadoProveedor.DataSource = Nothing
                End If
            Else
                mostrar()

            End If
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistadoProveedores.Columns(1).Visible = False

    End Sub


  

   

    Public Sub limpiar()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        TxtCodProveedor.Text = "0"
        TxtProveedor.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtCorreo.Text = ""
        cbeliminar.Checked = False

    End Sub
    Public Sub desbloquear()
        TxtProveedor.Enabled = True
        TxtDireccion.Enabled = True
        TxtTelefono.Enabled = True
        TxtCorreo.Enabled = True
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        mostrar()
        desbloquear()
        BtnNuevo.Enabled = False
        TxtProveedor.Focus()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TxtProveedor.Text <> "" And TxtTelefono.Text <> "" Then

            Dim dts As New vProveedor
            Dim func As New fProveedor
            dts.gcood_Proveedor = TxtCodProveedor.Text
            dts.gProveedor = TxtProveedor.Text
            dts.gdireccion = TxtDireccion.Text
            dts.gTelefono = TxtTelefono.Text
            dts.gcorreo = TxtCorreo.Text



            If func.insertar(dts) Then
                MessageBox.Show("Proveedor registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
                BtnGuardar.Enabled = False
                BtnNuevo.Enabled = True

                bloquear()

            Else
                MessageBox.Show("Proveedor no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            End If


        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProveedor.CellClick
        desbloquear()
        TxtCodProveedor.Text = Trim(datalistadoProveedor.SelectedCells.Item(1).Value)
        TxtProveedor.Text = Trim(datalistadoProveedor.SelectedCells.Item(2).Value)
        TxtDireccion.Text = Trim(datalistadoProveedor.SelectedCells.Item(3).Value)
        TxtTelefono.Text = Trim(datalistadoProveedor.SelectedCells.Item(4).Value)
        TxtCorreo.Text = Trim(datalistadoProveedor.SelectedCells.Item(5).Value)


        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then

                If Me.ValidateChildren = True And TxtProveedor.Text <> "" And TxtTelefono.Text <> "" Then
                    Try
                        Dim dts As New vProveedor
                        Dim func As New fProveedor
                        dts.gcood_Proveedor = TxtCodProveedor.Text
                        dts.gProveedor = TxtProveedor.Text
                        dts.gTelefono = TxtTelefono.Text
                        dts.gdireccion = TxtDireccion.Text
                        dts.gcorreo = TxtCorreo.Text


                        If func.editar(dts) Then
                            MessageBox.Show("Producto editado correctamente", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '      mostrar()
                            '      limpiar()
                            '      bloquear()
                        Else
                            MessageBox.Show("Producto no fue modificado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '     mostrar()
                            '     limpiar()
                            '     bloquear()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                Else
                    MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else

            End If
            mostrar()
            limpiar()
            bloquear()

        End If
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnNuevo.Enabled = True

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistadoProveedor.Columns.Item("eliminar").Visible = True
            btneliminar2.Enabled = True
        Else
            datalistadoProveedor.Columns.Item("eliminar").Visible = False
            btneliminar2.Enabled = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProveedor.CellContentClick
        If e.ColumnIndex = Me.datalistadoProveedor.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoProveedor.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub BtnEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar estos Proveedores", "Eliminar Proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Try
                    For Each row As DataGridViewRow In datalistadoProveedor.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_Proveedor").Value)
                            Dim vdb As New vProveedor
                            Dim func As New fProveedor
                            vdb.gcood_Proveedor = onekey

                            If func.eliminar(vdb) Then
                                MessageBox.Show("Proveedor eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

   


    
    
    Private Sub datalistadoProveedor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProveedor.CellDoubleClick
        If txtflag.Text = "1" Then
            Productos.TxtCodProveedor.Text = datalistadoProveedor.SelectedCells.Item(1).Value
            Productos.TxtProveedor.Text = datalistadoProveedor.SelectedCells.Item(2).Value


            frmCompra.txtCod_Proveedor.Text = datalistadoProveedor.SelectedCells.Item(1).Value
            frmCompra.TxtProveedor.Text = datalistadoProveedor.SelectedCells.Item(2).Value

            Me.Close()


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub

    Private Sub TxtCorreo_LostFocus(sender As Object, e As EventArgs) Handles TxtCorreo.LostFocus
        If (EmailValido(TxtCorreo.Text) = False) Then
            MsgBox("Correo no válido")
        End If
    End Sub

End Class