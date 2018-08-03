Imports System.Data.SqlClient
Public Class Cliente
    Private dt As New DataTable


    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
        limpiar()
        bloquear()


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
    Public Sub TxtCelular__KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCelular.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtCelular.Text & CChar(eventArgs.KeyChar))
    End Sub
    Public Sub TxtTelefono__KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtTelefono.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fCliente
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                Txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                Txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        BtnNuevo.Enabled = True
        BtnEditar.Enabled = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False

    End Sub




   

    Public Sub limpiar()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        TxtNombre.Text = ""
        txtApellidos.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtCelular.Text = ""
        TxtCliente.Text = ""
    End Sub
    Public Sub bloquear()
        TxtNombre.Enabled = False
        txtApellidos.Enabled = False
        TxtCelular.Enabled = False

        TxtDireccion.Enabled = False
        TxtTelefono.Enabled = False


    End Sub
    Public Sub desbloquear()
        TxtNombre.Enabled = True
        txtApellidos.Enabled = True
        TxtCelular.Enabled = True

        TxtDireccion.Enabled = True
        TxtTelefono.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        desbloquear()
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And txtApellidos.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New fCliente
                dts.gnombre = TxtNombre.Text
                dts.gapellido = txtApellidos.Text
                dts.gdireccion = TxtDireccion.Text
                dts.gtelefono = TxtTelefono.Text
                dts.gcelular = TxtCelular.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    bloquear()
                    BtnGuardar.Enabled = False
                    BtnEditar.Enabled = False
                    BtnNuevo.Enabled = True
                Else
                    MessageBox.Show("Cliente no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    bloquear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        Else
            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      

    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        desbloquear()
        TxtCliente.Text = datalistado.SelectedCells.Item(1).Value
        TxtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellidos.Text = datalistado.SelectedCells.Item(3).Value
        TxtDireccion.Text = datalistado.SelectedCells.Item(4).Value
        TxtTelefono.Text = datalistado.SelectedCells.Item(5).Value
        TxtCelular.Text = datalistado.SelectedCells.Item(6).Value
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then


                If Me.ValidateChildren = True And TxtNombre.Text <> "" And txtApellidos.Text <> "" And TxtCliente.Text <> "" Then
                    Try
                        Dim dts As New vcliente
                        Dim func As New fCliente

                        dts.gidcliente = TxtCliente.Text
                        dts.gnombre = TxtNombre.Text
                        dts.gapellido = txtApellidos.Text
                        dts.gdireccion = TxtDireccion.Text
                        dts.gtelefono = TxtTelefono.Text
                        dts.gcelular = TxtCelular.Text

                        If func.editar(dts) Then
                            MessageBox.Show("Cliente editado correctamente", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            bloquear()
                        Else
                            MessageBox.Show("Cliente no modificado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            bloquear()
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
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnNuevo.Enabled = True

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("eliminar").Visible = True
        Else
            datalistado.Columns.Item("eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar estos clientes", "Eliminar clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then
                Try
                    For Each row As DataGridViewRow In datalistado.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_cliente").Value)
                            Dim vdb As New vcliente
                            Dim func As New fCliente
                            vdb.gidcliente = onekey

                            If func.eliminar(vdb) Then
                                MessageBox.Show("Cliente eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            FrmVenta.txtCod_cliente.Text = datalistado.SelectedCells.Item(1).Value
            FrmVenta.TxtNombre.Text = datalistado.SelectedCells.Item(2).Value
            FrmCuentasACobrar.txtCod_cliente.Text = datalistado.SelectedCells.Item(1).Value
            FrmCuentasACobrar.TxtNombre.Text = datalistado.SelectedCells.Item(2).Value
            FrmCuentas.txtCod_cliente.Text = datalistado.SelectedCells.Item(1).Value
            FrmCuentas.TxtNombre.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        buscar()
    End Sub


End Class