Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, apellido, direccion, telefono, celular As String

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value

        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gcelular
        Get
            Return celular
        End Get
        Set(ByVal value)
            celular = value
        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal celular As String)
        gidcliente = idcliente
        gnombre = nombre
        gapellido = apellido
        gdireccion = direccion
        gtelefono = telefono
        gcelular = celular

    End Sub



End Class
