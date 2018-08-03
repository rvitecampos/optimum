Public Class vCompra
    Dim cood_proveedor, cood_compra As Integer
    Dim total_a_pagar As Double
    Dim fecha_compra As Date


    Public Property gcood_proveedor
        Get
            Return cood_proveedor
        End Get
        Set(ByVal value)
            cood_proveedor = value
        End Set
    End Property

    Public Property gcood_compra
        Get
            Return cood_compra
        End Get
        Set(ByVal value)
            cood_compra = value
        End Set
    End Property
    Public Property gFecha_compra
        Get
            Return fecha_compra
        End Get
        Set(ByVal value)
            fecha_compra = value
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






    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_cliente As Integer, ByVal cod_producto As Integer, ByVal cod_venta As Integer)
        gcood_compra = cood_compra
        gcood_proveedor = cood_proveedor
        gFecha_compra = fecha_compra
        gtotal_a_pagar = total_a_pagar




    End Sub
End Class
