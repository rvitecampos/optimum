Public Class FrmFondo
    Dim dts As New DataTable
    Public Sub mostrar()
        Try
            Dim func As New fFondo

            dts = func.mostrar


            If dts.Rows.Count <> 0 Then
                DatalistadoFondo.DataSource = dts

                DatalistadoFondo.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                DatalistadoFondo.DataSource = Nothing

                DatalistadoFondo.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Public Sub limpiar()
        TxtFondo.Text = ""

    End Sub
    Private Sub TxtEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.ValidateChildren = True And TxtFondo.Text <> "" Then

            Dim dts As New VFondo
            Dim func As New fFondo

            dts.gFondo = TxtFondo.Text



            If func.actualizar(dts) Then
                MessageBox.Show("Fondo modificado correctamente", "Actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()


            Else
                MessageBox.Show("Fondo no modificado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            End If


        Else
            MessageBox.Show("Falta ingresar el Fondo", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FrmFondo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
        limpiar()
        ocultar()
    End Sub
    Public Sub ocultar()
        Try


            DatalistadoFondo.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DatalistadoFondo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatalistadoFondo.CellClick
        TxtFondo.Text = DatalistadoFondo.SelectedCells.Item(0).Value

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Try
            Dim dtsSumarFondo As New VFondo
            Dim func As New fFondo
            Dim dineroAgregado As New Double



            dineroAgregado = InputBox("Ingrese Dinero")
            dtsSumarFondo.gtotal_a_agregar = dineroAgregado







            If func.sumar_fondo(dtsSumarFondo) Then

            End If
            mostrar()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Dim dtsRestarFondo As New VFondo
            Dim func As New fFondo
            Dim dineroQuitar As New Double

            dineroQuitar = InputBox("Saque Dinero", "Cuanto?")
            dtsRestarFondo.gTotal_a_quitar = dineroQuitar


            If func.quitar_fondo(dtsRestarFondo) Then

            End If
            mostrar()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub
End Class