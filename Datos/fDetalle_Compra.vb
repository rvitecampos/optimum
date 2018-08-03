Imports System.Data.SqlClient

Public Class fDetalle_Compra
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As VDetalle_Compra) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detallecompra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_compra", dts.gcood_compra)


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

    Public Function insertar_detalleCompra(ByVal dts As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detallecompra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cood_compra", dts.gcood_compra)
            cmd.Parameters.AddWithValue("@cood_producto", dts.gcood_producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gprecio_compra)



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
    Public Function restar_fondo(ByVal dtsRestarFondo As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("restar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@total_a_pagarCompra", dtsRestarFondo.gtotal_a_pagar)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Function actualizar_total(ByVal dtsActualizar As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_total")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cod_compra", dtsActualizar.gcood_compra)
            cmd.Parameters.AddWithValue("@total_a_pagar", dtsActualizar.gtotal_a_pagar)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Function aumentar(ByVal dtsAumentar As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cod_producto", dtsAumentar.gcood_Producto)
            cmd.Parameters.AddWithValue("@cantidad", dtsAumentar.gcantidad)




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

    Public Function eliminar(ByVal dt As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Eliminar_DetalleCompra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cood_producto", dt.gcood_Producto)



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
    Public Function disminuir(ByVal dtdisminuir As VDetalle_Compra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cod_producto", dtdisminuir.gcood_Producto)

            cmd.Parameters.AddWithValue("@cantidad", dtdisminuir.gcantidad)


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
