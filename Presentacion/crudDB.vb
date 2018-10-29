Public Class crudDB
    Dim obj As New crud

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Mediante el objeto que creamos accedemos al procedimiento "conexion"
        obj.conexion()
    End Sub
End Class