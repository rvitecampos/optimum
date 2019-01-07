Imports System.Data.SqlClient
Public Class fRutaSFS
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_rutaSFS")
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

    Public Function editar(ByVal dts As vRutaSFS) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_rutaSFS")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@rutaSFS", dts.grutasfs)

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

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cliente", dts.gcliente)
            cmd.Parameters.AddWithValue("@ruc", dts.gruc)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)

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

    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@cod_cliente", SqlDbType.NVarChar, 50).Value = dts.gidcliente
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
