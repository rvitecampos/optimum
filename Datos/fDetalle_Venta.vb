Imports System.Data.SqlClient
Public Class fDetalle_Venta

    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As VDetalle_venta) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalleVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            '
            cmd.Parameters.AddWithValue("@Cood_Venta", dts.gCood_venta)
            cmd.Parameters.AddWithValue("@Cood_Cliente", dts.gCood_Cliente)


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
    Public Function actualizar_total(ByVal dtsActualizar As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_totalventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@cod_venta", dtsActualizar.gCood_venta)
            ' cmd.Parameters.AddWithValue("@total_a_pagar", dtsActualizar.gtotal_a_pagar)


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
    Public Function sumar_fondo(ByVal dtsSumarFondo As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("sumar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            '  cmd.Parameters.AddWithValue("@total_a_pagarVenta", dtsSumarFondo.gtotal_a_pagar)


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
   
    Public Function insertar_detalleVenta(ByVal dts As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalleVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cood_venta", dts.gCood_venta)
            cmd.Parameters.AddWithValue("@Cood_Cliente", dts.gCood_Cliente)
            cmd.Parameters.AddWithValue("@Cood_Servicio", dts.gCood_Servicio)
            cmd.Parameters.AddWithValue("@Uni_Medida", dts.gUni_Medida)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@Nombre_Servicio", dts.gNombre_Servicio)
            cmd.Parameters.AddWithValue("@Venta_unitario", dts.gVenta_unitario)
            cmd.Parameters.AddWithValue("@Venta", dts.gVenta)
            cmd.Parameters.AddWithValue("@IGV", dts.gIGV)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Nombre_tributo", dts.gNombre_tributo)
            cmd.Parameters.AddWithValue("@Codigo_tributo", dts.gCodigo_tributo)
            cmd.Parameters.AddWithValue("@Detalle1", dts.gDetalle1)
            cmd.Parameters.AddWithValue("@Detalle2", dts.gDetalle2)
            cmd.Parameters.AddWithValue("@Detalle3", dts.gDetalle3)


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
    Public Function editar_Pagos(ByVal dts As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_Pagos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            '  cmd.Parameters.AddWithValue("@cood_venta", dts.gcod_venta)
            '    cmd.Parameters.AddWithValue("@Estado", dts.gEstado)


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
    Public Function aumentar(ByVal dtsAumentar As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            '    cmd.Parameters.AddWithValue("@cod_producto", dtsAumentar.gcood_Producto)
            '    cmd.Parameters.AddWithValue("@cantidad", dtsAumentar.gcantidad)


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

    Public Function eliminar(ByVal dts As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalleVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cood_venta", dts.gCood_venta)
            cmd.Parameters.AddWithValue("@Cood_Cliente", dts.gCood_Cliente)
            cmd.Parameters.AddWithValue("@Cood_Servicio", dts.gCood_Servicio)
            cmd.Parameters.AddWithValue("@Venta", dts.gVenta)
            cmd.Parameters.AddWithValue("@IGV", dts.gIGV)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)

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
    Public Function disminuir(ByVal dtdisminuir As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            '     cmd.Parameters.AddWithValue("@cod_producto", dtdisminuir.gcood_Producto)

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
    Public Function Actualizar_Pagando(ByVal dts As VDetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Actualizar_Pagando")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cood_cliente", dts.gCood_Cliente)
            '      cmd.Parameters.AddWithValue("@Pagando", dts.gPagando)



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
    Public Function mostrar_vuelto(ByVal dts As VDetalle_venta) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_vuelto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cood_cliente", dts.gCood_Cliente)


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

End Class
