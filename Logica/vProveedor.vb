Public Class vProveedor
    Dim cood_proveedor As Integer
    Dim proveedor, telefono, direccion, correo As String


    Public Property gcood_Proveedor
        Get
            Return cood_proveedor
        End Get
        Set(ByVal value)
            cood_proveedor = value
        End Set
    End Property
    Public Property gProveedor
        Get
            Return Proveedor
        End Get
        Set(ByVal value)
            proveedor = value
        End Set
    End Property
    Public Property gTelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
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
    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(ByVal value)
            correo = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal cood_Proveedor As Integer, ByVal proveedor As String, ByVal telefono As String, ByVal direccion As String, ByVal correo As String)
        gcood_Proveedor = cood_Proveedor
        gProveedor = proveedor
        gTelefono = telefono
        gdireccion = direccion
        gcorreo = correo

    End Sub
End Class
