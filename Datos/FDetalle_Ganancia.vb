Imports System.Data.SqlClient
Public Class FDetalle_Ganancia
    Inherits Conexion
    Dim cmd As New SqlCommand


    Public Function insertar_detalleganancia(ByVal dtsg As VDetalle_Ganancia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalleganancias")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_producto", dtsg.gCod_Producto)
            cmd.Parameters.AddWithValue("@cantidad", dtsg.gCantidad)
            cmd.Parameters.AddWithValue("@precio_compra", dtsg.gPrecio_Compra)
            cmd.Parameters.AddWithValue("@precio1_Venta", dtsg.gPrecio1)
            cmd.Parameters.AddWithValue("@precio2_Venta", dtsg.gPrecio2)
            cmd.Parameters.AddWithValue("@ganancia_total", dtsg.gGanancia_total)


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
    Public Function aumentar_ganancia(ByVal dtsg As VDetalle_Ganancia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_ganancia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_producto", dtsg.gCod_Producto)
            cmd.Parameters.AddWithValue("@cantidad", dtsg.gCantidad)
            cmd.Parameters.AddWithValue("@precio", dtsg.gPrecio1)




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
   
    Public Function eliminar_detalleganancia(ByVal dtsg As VDetalle_Ganancia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_DetalleGanancia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_producto", dtsg.gCod_Producto)
            




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
