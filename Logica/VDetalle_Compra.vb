Public Class VDetalle_Compra
    Dim cood_compra As Integer
    Dim cood_producto As String
    Dim cantidad, precio_compra, total_a_pagar As Double


    Public Property gcood_producto
        Get
            Return cood_producto
        End Get
        Set(ByVal value)
            cood_producto = value
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


    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property

    Public Property gprecio_compra
        Get
            Return precio_compra
        End Get
        Set(ByVal value)
            precio_compra = value
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

    Public Sub New(ByVal cood_producto As String, ByVal cod_compra As Integer, ByVal cantidad As Double, ByVal precio_compra As Double)
        gcood_producto = cood_producto
        gcood_compra = cood_compra
        gcantidad = cantidad
        gprecio_compra = precio_compra


    End Sub
End Class
