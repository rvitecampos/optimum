Imports System.Data.SqlClient

Public Class fServicios
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_servicios")
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

    Public Function editar(ByVal dts As vServicios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_servicios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_Servicio", dts.gcod_Servicio)
            cmd.Parameters.AddWithValue("@nombre_Servicio", dts.gnombre_Servicio)
            cmd.Parameters.AddWithValue("@costo", dts.gcosto)
            cmd.Parameters.AddWithValue("@venta", dts.gventa)
            cmd.Parameters.AddWithValue("@items", dts.gitems)
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

    Public Function insertar(ByVal dts As vServicios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_servicios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre_Servicio", dts.gnombre_Servicio)
            cmd.Parameters.AddWithValue("@costo", dts.gcosto)
            cmd.Parameters.AddWithValue("@venta", dts.gventa)
            cmd.Parameters.AddWithValue("@items", dts.gitems)

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

    Public Function eliminar(ByVal dts As vServicios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_servicios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_Servicio", dts.gcod_Servicio)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
End Class
