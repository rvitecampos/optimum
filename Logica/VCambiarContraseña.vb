Public Class VCambiarContraseña
    Dim login, password, Confirmacion As String
    Public Property gLogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property
    Public Property gPassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property
    Public Property gConfirmacion
        Get
            Return Confirmacion
        End Get
        Set(value)
            Confirmacion = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal login As String, ByVal password As String, ByVal confirmacion As String)
        gLogin = login
        gPassword = password
        gConfirmacion = confirmacion
    End Sub

End Class
