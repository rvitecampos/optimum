Public Class vcliente
    Dim idcliente As Integer
    Dim cliente, ruc, nombre, apellido, dni, direccion, telefono, celular, correo As String
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value

        End Set
    End Property

    Public Property gcliente
        Get
            Return cliente
        End Get
        Set(ByVal value)
            cliente = value

        End Set
    End Property

    Public Property gruc
        Get
            Return ruc
        End Get
        Set(ByVal value)
            ruc = value

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
    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value

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
    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(ByVal value)
            correo = value

        End Set
    End Property


    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal idcliente As Integer, ByVal cliente As String, ByVal ruc As String, ByVal nombre As String, ByVal apellido As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String, ByVal celular As String, ByVal correo As String)
        gidcliente = idcliente
        gcliente = cliente
        gruc = ruc
        gnombre = nombre
        gapellido = apellido
        gdni = dni
        gdireccion = direccion
        gtelefono = telefono
        gcelular = celular
        gcorreo = correo

    End Sub



End Class
