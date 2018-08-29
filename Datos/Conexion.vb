Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection

    Public idusuario As Integer
    Protected Function conectado()
        Try
            Dim dts As New VUsuario
            'Static conexxion As String
            'Static activar As Integer
            'Static login As String
            'Static password As String
            'Aca hice que una vez nomas se guardara el login de manera estatica, o sea que no se borre
            'If activar = 0 Then
            '    login = frmLogin.txtLogin.Text
            '    password = frmLogin.txtPassword.Text
            '    activar = 1
            'End If


            'Dim fecha As String
            'Usuario
            'conexxion = "Data Source=LOCALHOST\BD;Initial Catalog=Despensa;User ID=" & login & ";Password=" & password & ""

            cnn = New SqlConnection("Data Source=MCDEV22\SQLEXPRESS;Initial Catalog=Despensa;Integrated Security=True")
            cnn.Open()
            'server=JUNNIOR-PC\BD;database=Despensa; Integrated Security = True;User ID=Probar;Password=12345 

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
