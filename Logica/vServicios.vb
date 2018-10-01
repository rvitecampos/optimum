Public Class vServicios

    Dim Cod_Servicio As Integer
    Dim Nombre_Servicio As String
    Dim Costo, Venta, Items As Double


    Public Property gcod_Servicio
        Get
            Return Cod_Servicio
        End Get
        Set(ByVal value)
            Cod_Servicio = value
        End Set
    End Property
    Public Property gnombre_Servicio
        Get
            Return Nombre_Servicio
        End Get
        Set(ByVal value)
            Nombre_Servicio = value
        End Set
    End Property
    Public Property gcosto
        Get
            Return Costo
        End Get
        Set(ByVal value)
            Costo = value
        End Set
    End Property
    Public Property gventa
        Get
            Return Venta
        End Get
        Set(ByVal value)
            Venta = value
        End Set
    End Property
    Public Property gitems
        Get
            Return Items
        End Get
        Set(ByVal value)
            Items = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_Servicio As Integer, ByVal Nombre_Servicio As String, ByVal costo As Double, ByVal venta As Double, ByVal items As Double)
        gcod_Servicio = cod_Servicio
        gnombre_Servicio = Nombre_Servicio
        gcosto = costo
        gventa = venta
        gitems = items
    End Sub

End Class
