Public Class vVenta
    Dim cod_cliente, cod_venta As Integer
    Dim total_a_pagar As Double
    'Dim fecha_venta As String


    Public Property gcod_Cliente
        Get
            Return cod_cliente
        End Get
        Set(ByVal value)
            cod_cliente = value
        End Set
    End Property
    
    Public Property gcod_venta
        Get
            Return cod_venta
        End Get
        Set(ByVal value)
            cod_venta = value
        End Set
    End Property
    'Public Property gFecha_venta
    '    Get
    '        Return fecha_venta
    '    End Get
    '    Set(ByVal value)
    '        fecha_venta = value
    '    End Set
    'End Property

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

    Public Sub New(ByVal cod_cliente As Integer, ByVal fecha_venta As Date, ByVal cod_venta As Integer)

        gcod_Cliente = cod_cliente
        'gFecha_venta = fecha_venta
        gtotal_a_pagar = total_a_pagar

    End Sub
End Class


