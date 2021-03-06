﻿Imports System.Data.SqlClient


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

    Public Function mostrar_ListaFac() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ListaFac")
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


    Public Function mostrar_serieF() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_serieFac")
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

    Public Function mostrarCat51() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarCat51")
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

    Public Function crearDetalleFac(ByVal codVenta As String, ByVal codCli As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("crearDetalleFac")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_Venta", codVenta)
            cmd.Parameters.AddWithValue("@Cod_Cliente", codCli)

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



    Public Function crearTri(ByVal codVenta As String, ByVal codCli As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("crearTri")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_Venta", codVenta)
            cmd.Parameters.AddWithValue("@Cod_Cliente", codCli)

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


    Public Function crearLeyAca(ByVal codVenta As String, ByVal codCli As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("crearLeyAca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_Venta", codVenta)
            cmd.Parameters.AddWithValue("@Cod_Cliente", codCli)

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




    Public Function insertar(ByVal dts As vVenta, ByVal serief As Integer) As Boolean
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
            cmd.Parameters.AddWithValue("@Letras", dts.gletras)
            cmd.Parameters.AddWithValue("@serieF", serief)




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



    Public Function editar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_venta", dts.gcod_Venta)
            cmd.Parameters.AddWithValue("@Cood_cliente", dts.gcood_Cliente)
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
            cmd.Parameters.AddWithValue("@Letras", dts.gletras)





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

    Public Function cierraFac(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("cierraFactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_venta", dts.gcod_Venta)
            cmd.Parameters.AddWithValue("@Cood_cliente", dts.gcood_Cliente)
            cmd.Parameters.AddWithValue("@Letras", dts.gletras)
            cmd.Parameters.AddWithValue("@Referencial", dts.greferencial)

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


    Public Function abrirFac(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("abrirFactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_venta", dts.gcod_Venta)
            '           cmd.Parameters.AddWithValue("@Letras", dts.gletras)
            '           cmd.Parameters.AddWithValue("@Referencial", dts.greferencial)

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
    Public Function totalActual(ByVal dts As vVenta) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_TotalActual")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_venta", dts.gcod_Venta)
            cmd.Parameters.AddWithValue("@Cood_cliente", dts.gcood_Cliente)


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
    Public Function grabaArchivo(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("grabaArchivo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_venta", dts.gcod_Venta)
            cmd.Parameters.AddWithValue("@Cood_cliente", dts.gcood_Cliente)
            cmd.Parameters.AddWithValue("@Archivo", dts.garchivo)
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
