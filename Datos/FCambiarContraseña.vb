Imports System.Data.SqlClient
Public Class FCambiarContraseña
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Cambiar_contraseña(ByVal dt As VCambiarContraseña)
        Try


            conectado()
            cmd = New SqlCommand("Cambiar_Contraseña")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@login", dt.gLogin)
            cmd.Parameters.AddWithValue("@password", dt.gPassword)
            cmd.Parameters.AddWithValue("@nuevopassword", dt.gConfirmacion)




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
