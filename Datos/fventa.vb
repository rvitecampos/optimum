Imports System.Data.SqlClient


Public Class fventa

    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ventasimple")
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


    Public Function crearCabeceraFac(ByVal codVenta As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("crearCabeceraFac")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_Venta", codVenta)

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

    Public Function insertar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cood_cliente", dts.gcood_Cliente)
            cmd.Parameters.AddWithValue("@Serie", dts.gserie)
            cmd.Parameters.AddWithValue("@Referencial", dts.greferencial)
            cmd.Parameters.AddWithValue("@TC", dts.gTC)
            cmd.Parameters.AddWithValue("@Tipo_oper", dts.gtipooper)
            cmd.Parameters.AddWithValue("@Fecha_Venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@Hora_Emision", dts.ghora_emision)
            cmd.Parameters.AddWithValue("@Fecha_Vence", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@Nro_doc", dts.gnro_doc)
            cmd.Parameters.AddWithValue("@Cliente", dts.gcliente)
            cmd.Parameters.AddWithValue("@Tip_Moneda", dts.gtip_moneda)
            cmd.Parameters.AddWithValue("@IGV", dts.gigv)
            cmd.Parameters.AddWithValue("@Venta", dts.gventa)
            cmd.Parameters.AddWithValue("@Total", dts.gtotal)




            'cmd.Parameters.AddWithValue("@fecha_venta", dts.gFecha_venta)
            'cmd.Parameters.AddWithValue("@Total_a_pagar", dts.gtotal_a_pagar)

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
