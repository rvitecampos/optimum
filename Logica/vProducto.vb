Public Class vProducto
    Dim cood_proveedor As Integer
    Dim Nombre_Producto, cod_Producto As String
    Dim cantidad, Precio_unitario, SPrecio_Unitario, Precio_compra, Limite As Double
    Dim imagen() As Byte

    Public Property gcod_Producto
        Get
            Return cod_Producto
        End Get
        Set(ByVal value)
            cod_Producto = value
        End Set
    End Property
    Public Property gcood_Proveedor
        Get
            Return cood_proveedor
        End Get
        Set(ByVal value)
            cood_proveedor = value
        End Set
    End Property
    Public Property gNombre_Producto
        Get
            Return Nombre_Producto
        End Get
        Set(ByVal value)
            Nombre_Producto = value
        End Set
    End Property
    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property
    Public Property gPrecio_Unitario
        Get
            Return Precio_unitario
        End Get
        Set(ByVal value)
            Precio_unitario = value
        End Set
    End Property
    Public Property gSPrecio_unitario
        Get
            Return SPrecio_Unitario
        End Get
        Set(ByVal value)
            SPrecio_Unitario = value
        End Set
    End Property
    'Public Property gFecha_vencimiento
    '    Get
    '        Return fecha_vencimiento
    '    End Get
    '    Set(ByVal value)
    '        fecha_vencimiento = value
    '    End Set
    'End Property
    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property

        public property gPrecio_compra
        Get
            Return Precio_compra
        End Get
        Set(ByVal value)
            Precio_compra = value
        End Set
    End Property
    Public Property gLimite
        Get
            Return Limite
        End Get
        Set(value)
            Limite = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_Producto As String, ByVal Limite As Double, ByVal cood_Proveedor As Integer, ByVal Nombre_Producto As String, ByVal cantidad As Double, ByVal precio_unitario As Double, ByVal sprecio_unitario As Double, ByVal fecha_vencimiento As Date, ByVal imagen() As Byte)
        gcod_Producto = cod_Producto
        gcood_Proveedor = cood_Proveedor
        gNombre_Producto = Nombre_Producto
        gcantidad = cantidad
        gPrecio_Unitario = precio_unitario
        gSPrecio_unitario = sprecio_unitario
        'gFecha_vencimiento = fecha_vencimiento
        gimagen = imagen
        gLimite = Limite
    End Sub

End Class
