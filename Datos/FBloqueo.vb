Imports System.Data.SqlClient
Public Class FBloqueo
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function validar_usuario(ByVal dts As VBloqueo)
        Try


            conectado()
            cmd = New SqlCommand("Validar_administrador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
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
