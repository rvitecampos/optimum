Imports System.Data.SqlClient

Public Class fProductos
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_productos")
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

    Public Function editar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_producto", dts.gcod_Producto)
            cmd.Parameters.AddWithValue("@nombre_Producto", dts.gNombre_Producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            'cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFecha_vencimiento)
            cmd.Parameters.AddWithValue("@Precio_unitario", dts.gPrecio_Unitario)
            cmd.Parameters.AddWithValue("@SPrecio_unitario", dts.gSPrecio_unitario)
            cmd.Parameters.AddWithValue("@cood_Proveedor", dts.gcood_Proveedor)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@limite", dts.gLimite)
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

    Public Function insertar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_Producto", dts.gcod_Producto)
            cmd.Parameters.AddWithValue("@nombre_Producto", dts.gNombre_Producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            'cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFecha_vencimiento)
            cmd.Parameters.AddWithValue("@Precio_unitario", dts.gPrecio_Unitario)
            cmd.Parameters.AddWithValue("@SPrecio_unitario", dts.gSPrecio_unitario)
            cmd.Parameters.AddWithValue("@cood_Proveedor", dts.gcood_Proveedor)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@limite", dts.gLimite)

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

    Public Function eliminar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_producto", dts.gcod_Producto)
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
