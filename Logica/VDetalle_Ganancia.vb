Public Class VDetalle_Ganancia
    Dim cod_Producto As String
    Dim Cantidad, Precio_Compra, Precio1, Precio2, ganancia_total As Decimal

    Public Property gCod_Producto
        Get
            Return cod_Producto
        End Get
        Set(ByVal value)
            cod_Producto = value

        End Set
    End Property

    Public Property gCantidad
        Get
                Return Cantidad
        End Get
        Set(ByVal value)
            Try
                Cantidad = value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Set
    End Property
    Public Property gPrecio_Compra
        Get
            Return Precio_Compra
        End Get
        Set(ByVal value)
            Precio_Compra = value
        End Set
    End Property

    Public Property gPrecio1
        Get
            Return Precio1
        End Get
        Set(ByVal value)
            Precio1 = value
        End Set
    End Property
    Public Property gPrecio2
        Get
            Return Precio2
        End Get
        Set(ByVal value)
            Precio2 = value
        End Set
    End Property
    Public Property gGanancia_total
        Get
            Return ganancia_total
        End Get
        Set(ByVal value)
            ganancia_total = value
        End Set
    End Property



    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal cod_Producto As Integer, ByVal Precio_Compra As Decimal, ByVal Cantidad As Decimal, ByVal Precio1 As Decimal, ByVal Precio2 As Decimal, ByVal ganancia_total As Decimal)
        gCod_Producto = cod_Producto
        gPrecio_Compra = Precio_Compra
        gCantidad = Cantidad
        gPrecio1 = Precio1
        gPrecio2 = Precio2
        gGanancia_total = ganancia_total

    End Sub

End Class
