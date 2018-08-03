Imports System.Data.SqlClient
Public Class fFondo
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function sumar_fondo(ByVal dtsSumarFondo As VFondo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("sumar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@total_a_pagarVenta", dtsSumarFondo.gtotal_a_agregar)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function quitar_fondo(ByVal dtsquitarFondo As VFondo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("restar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@total_a_pagarCompra", dtsquitarFondo.gTotal_a_quitar)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function actualizar(ByVal dts As VFondo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_Fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Fondo", dts.gFondo)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function
End Class
