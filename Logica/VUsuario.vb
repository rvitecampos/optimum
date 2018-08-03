Public Class VUsuario
    Dim idusuario As Integer
    Dim nombre, apellidos, dni, direccion, telefono, login, password, acceso, Categoria As String
    Dim imagen() As Byte
    Public Property gCategoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value
        End Set
    End Property

    Public Property gidUsuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property
    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)

            acceso = value
        End Set
    End Property
    Public Property gImagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String, ByVal login As String, ByVal password As String, ByVal acceso As String, ByVal categoria As String)
        gidUsuario = idusuario
        gnombre = nombre
        gapellidos = apellidos
        gacceso = acceso
        gdni = dni
        gdireccion = direccion
        glogin = login
        gpassword = password
        gCategoria = Categoria
    End Sub
End Class
