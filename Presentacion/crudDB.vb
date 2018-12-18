Public Class crudDB
    Dim obj As New crud

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Mediante el objeto que creamos accedemos al procedimiento "conexion"
        'obj.conexion()


    End Sub

    Private Sub mostrar()
        Dim dt As DataTable
        dtgDB.DataSource = Nothing
        Dim func As New crud
        dt = func.mostrar
        ' datalistadoFactura.Columns.Item("Eliminar").Visible = False



        If dt.Rows.Count <> 0 Then
            dtgDB.DataSource = dt

        Else
            dtgDB.DataSource = Nothing
        End If

    End Sub

    Private Sub dtgDB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDB.CellClick
        txtARCH.Text = Trim(dtgDB.SelectedCells.Item(0).Value)
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim func As New crud
        Dim ARCH As String = txtARCH.Text

        If func.eliminar(ARCH) Then
            MessageBox.Show("Servicio eliminado", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        btnEliminar.Enabled = False
        Call mostrar()
    End Sub

    Private Sub crudDB_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub
End Class