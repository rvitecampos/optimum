Public Class FrmUsuarios
    Private dt As New DataTable
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub bloquear()
        TxtNombre.Enabled = False
        txtApellidos.Enabled = False
        TxtDireccion.Enabled = False
        TxtTelefono.Enabled = False
        TxtDNI.Enabled = False
        txtLogin.Enabled = False
        txtPassword.Enabled = False
        cbCategoria.Enabled = False
    End Sub
    Public Sub desbloquear()
        TxtNombre.Enabled = True
        txtApellidos.Enabled = True
        TxtDireccion.Enabled = True
        TxtTelefono.Enabled = True
        TxtDNI.Enabled = True
        txtLogin.Enabled = True
        txtPassword.Enabled = True
        cbCategoria.Enabled = True
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fUsuario
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                Txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
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
    Sub ocultar_columnas()
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False
    End Sub
    Sub limpiar()
        TxtNombre.Text = ""
        txtApellidos.Text = ""
        Txtbuscar.Text = ""
        TxtDireccion.Text = ""
        TxtDNI.Text = ""
        txtLogin.Text = ""
        TxtNombre.Text = ""
        txtPassword.Text = ""
        TxtTelefono.Text = ""

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then

                Dim dts As New VUsuario
                Dim func As New fUsuario
                dts.gnombre = TxtNombre.Text
                dts.gapellidos = txtApellidos.Text
                dts.gdireccion = TxtDireccion.Text
                dts.gdni = TxtDNI.Text
                dts.gtelefono = TxtTelefono.Text
                dts.glogin = txtLogin.Text
                dts.gpassword = txtPassword.Text
                dts.gCategoria = cbCategoria.Text
                If cbCategoria.Text = "Administrador" Then
                    dts.gacceso = "1"
                Else
                    dts.gacceso = "0"
                End If
                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.AVATAR1
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If

                dts.gImagen = ms.GetBuffer

                If func.insertar(dts) Then
                    MessageBox.Show("Usuario registrado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                    BtnGuardar.Enabled = False
                    BtnEditar.Enabled = False
                    BtnNuevo.Enabled = True
                Else
                    MessageBox.Show("Usuario no registrado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    BtnGuardar.Enabled = False
                    BtnEditar.Enabled = False
                    BtnNuevo.Enabled = True
                End If
            
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.Zoom

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.AVATAR1
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloquear()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtPassword.Enabled = False
        TxtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellidos.Text = datalistado.SelectedCells.Item(3).Value
        TxtDNI.Text = datalistado.SelectedCells.Item(4).Value
        TxtDireccion.Text = datalistado.SelectedCells.Item(5).Value
        TxtTelefono.Text = datalistado.SelectedCells.Item(6).Value
        txtLogin.Text = datalistado.SelectedCells.Item(7).Value
        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(11).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        

    End Sub

    Private Sub txtCambiarContraseña_Click(sender As Object, e As EventArgs) Handles txtCambiarContraseña.Click
        FrmCambiarContraseña.ShowDialog()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiar()
        desbloquear()
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = True

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then



                Dim dts As New VUsuario
                Dim func As New fUsuario
                dts.gnombre = TxtNombre.Text
                dts.gapellidos = txtApellidos.Text
                dts.gdireccion = TxtDireccion.Text
                dts.gdni = TxtDNI.Text
                dts.gtelefono = TxtTelefono.Text
                dts.glogin = txtLogin.Text
                dts.gCategoria = cbCategoria.Text
                If cbCategoria.Text = "Administrador" Then
                    dts.gacceso = "1"
                Else
                    dts.gacceso = "0"
                End If
                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.AVATAR1
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If

                dts.gImagen = ms.GetBuffer

                If func.editar_usuario(dts) Then
                    MessageBox.Show("Usuario editado correctamente", "Editado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                    BtnGuardar.Enabled = False
                    BtnEditar.Enabled = False
                    BtnNuevo.Enabled = True
                Else
                    MessageBox.Show("Usuario no editado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    BtnGuardar.Enabled = False
                    BtnEditar.Enabled = False
                    BtnNuevo.Enabled = True
                End If
            
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub
End Class