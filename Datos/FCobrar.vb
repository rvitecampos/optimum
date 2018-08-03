Imports System.Data.SqlClient
Public Class FCobrar
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As VCobrar) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pagos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cood_cliente", dts.gCood_cliente)


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
