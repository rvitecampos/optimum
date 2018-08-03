Public Class VBloqueo
    Dim password As String
    Public Property gPassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal password As String)
        gPassword = password
    End Sub
End Class
