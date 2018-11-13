Public Class VDetalle_venta
    Dim cood_venta, cood_cliente, cood_servicio As Integer
    Dim uni_medida, nombre_servicio, nombre_tributo, codigo_tributo, detalle1, detalle2, detalle3 As String
    Dim cantidad, venta, igv, venta_unitario, total As Double
    Public Property gCood_venta
        Get
            Return cood_venta
        End Get
        Set(value)
            cood_venta = value
        End Set
    End Property
    Public Property gCood_Cliente
        Get
            Return cood_cliente
        End Get
        Set(value)
            cood_cliente = value
        End Set
    End Property


    Public Property gCood_Servicio
        Get
            Return cood_servicio
        End Get
        Set(value)
            cood_servicio = value
        End Set
    End Property
    Public Property gUni_Medida
        Get
            Return uni_medida
        End Get
        Set(value)
            uni_medida = value
        End Set
    End Property
    Public Property gCantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property gNombre_Servicio
        Get
            Return nombre_servicio
        End Get
        Set(ByVal value)
            nombre_servicio = value
        End Set
    End Property
    Public Property gVenta
        Get
            Return venta
        End Get
        Set(ByVal value)
            venta = value
        End Set
    End Property
    Public Property gIGV
        Get
            Return igv
        End Get
        Set(ByVal value)
            igv = value
        End Set
    End Property


    Public Property gVenta_unitario
        Get
            Return venta_unitario
        End Get
        Set(ByVal value)
            venta_unitario = value
        End Set
    End Property
    Public Property gNombre_tributo
        Get
            Return nombre_tributo
        End Get
        Set(ByVal value)
            nombre_tributo = value
        End Set
    End Property
    Public Property gCodigo_tributo
        Get
            Return codigo_tributo
        End Get
        Set(ByVal value)
            codigo_tributo = value
        End Set
    End Property
    Public Property gTotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property gDetalle1
        Get
            Return detalle1
        End Get
        Set(ByVal value)
            detalle1 = value
        End Set
    End Property
    Public Property gDetalle2
        Get
            Return detalle2
        End Get
        Set(ByVal value)
            detalle2 = value
        End Set
    End Property
    Public Property gDetalle3
        Get
            Return detalle3
        End Get
        Set(ByVal value)
            detalle3 = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_cliente As Integer, ByVal cod_producto As String, ByVal cod_venta As Integer, ByVal cantidad As Double, ByVal total_a_pagar As Double, ByVal precio_unitario As Double)

    End Sub
End Class
