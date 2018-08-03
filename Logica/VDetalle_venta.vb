Public Class VDetalle_venta
    Dim cood_venta, cood_cliente As Integer
    Dim cood_producto, Estado As String
    Dim cantidad, total_a_pagar, total, precio_unitario, Pagando As Double
    Dim activar As String
    Public Property gCood_Cliente
        Get
            Return cood_cliente
        End Get
        Set(value)
            cood_cliente = value
        End Set
    End Property
    Public Property gEstado
        Get
            Return Estado
        End Get
        Set(value)
            Estado = value
        End Set
    End Property
    Public Property gPagando
        Get
            Return Pagando
        End Get
        Set(value)
            Pagando = value
        End Set
    End Property
    Public Property gtotal
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set
    End Property
    Public Property gcood_Producto
        Get
            Return cood_producto
        End Get
        Set(ByVal value)
            cood_producto = value
        End Set
    End Property
    Public Property gcod_venta
        Get
            Return cood_venta
        End Get
        Set(ByVal value)
            cood_venta = value
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
    Public Property gtotal_a_pagar
        Get
            Return total_a_pagar
        End Get
        Set(ByVal value)
            total_a_pagar = value
        End Set
    End Property
    Public Property gPrecio_Unitario
        Get
            Return precio_unitario
        End Get
        Set(ByVal value)
            precio_unitario = value
        End Set
    End Property
    Public Property gActivar
        Get
            Return activar
        End Get
        Set(value)
            activar = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_cliente As Integer, ByVal cod_producto As String, ByVal cod_venta As Integer, ByVal cantidad As Double, ByVal total_a_pagar As Double, ByVal precio_unitario As Double)
        gcood_Producto = cod_producto
        gcod_venta = cod_venta
        gcantidad = cantidad
        gtotal_a_pagar = total_a_pagar
        gPrecio_Unitario = precio_unitario

    End Sub
End Class
