Public Class vStockMovimiento
    Dim Id_Stock, Ctdad, Cood_Proveedor, Cood_Servicio As Integer
    Dim Cood_Producto, Nombre_Producto, Tipo, Documento, Fecha As String
    Public Property gId_Stock
        Get
            Return Id_Stock
        End Get
        Set(ByVal value)
            Id_Stock = value
        End Set
    End Property
    Public Property gCood_Producto
        Get
            Return Cood_Producto
        End Get
        Set(ByVal value)
            Cood_Producto = value
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
    Public Property gCtdad
        Get
            Return Ctdad
        End Get
        Set(ByVal value)
            Ctdad = value
        End Set
    End Property
    Public Property gTipo
        Get
            Return Tipo
        End Get
        Set(ByVal value)
            Tipo = value
        End Set
    End Property
    Public Property gDocumento
        Get
            Return Documento
        End Get
        Set(ByVal value)
            Documento = value
        End Set
    End Property
    Public Property gFecha
        Get
            Return Fecha
        End Get
        Set(ByVal value)
            Fecha = value
        End Set
    End Property
    Public Property gCood_Proveedor
        Get
            Return Cood_Proveedor
        End Get
        Set(ByVal value)
            Cood_Proveedor = value
        End Set
    End Property

    Public Property gCood_Servicio
        Get
            Return Cood_Servicio
        End Get
        Set(ByVal value)
            Cood_Servicio = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal cood_Proveedor As Integer, ByVal proveedor As String, ByVal telefono As String, ByVal direccion As String, ByVal correo As String)
        gId_Stock = Id_Stock
        gCood_Producto = Cood_Producto
        gNombre_Producto = Nombre_Producto
        gCtdad = Ctdad
        gTipo = Tipo
        gDocumento = Documento
        gFecha = Fecha
        gCood_Proveedor = cood_Proveedor
        gCood_Servicio = Cood_Servicio

    End Sub
End Class
