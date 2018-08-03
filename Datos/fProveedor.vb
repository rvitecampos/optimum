﻿Imports System.Data.SqlClient

Public Class fProveedor
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedor")
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

    Public Function editar(ByVal dts As vProveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_proveedor", dts.gcood_Proveedor)
            cmd.Parameters.AddWithValue("@nombre_Proveedor", dts.gProveedor)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gTelefono)
            
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

    Public Function insertar(ByVal dts As vProveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre_Proveedor", dts.gProveedor)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gTelefono)

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

    Public Function eliminar(ByVal dts As vProveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@cod_proveedor", SqlDbType.NVarChar, 50).Value = dts.gcood_Proveedor

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
