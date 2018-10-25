Public Class vVenta
    Dim cood_cliente, cod_venta, referencial As Integer
    Dim TC, igv, venta, total As Double
    Dim serie, tipo_oper, fecha_venta, hora_emision, fecha_vencimiento, cod_doc, nro_doc, cliente, tip_moneda, letras, estado, archivo As String

    Public Property gcood_Cliente
        Get
            Return cood_cliente
        End Get
        Set(ByVal value)
            cood_cliente = value
        End Set
    End Property
    
    Public Property gcod_Venta
        Get
            Return cod_venta
        End Get
        Set(ByVal value)
            cod_venta = value
        End Set
    End Property

    Public Property greferencial
        Get
            Return referencial
        End Get
        Set(ByVal value)
            referencial = value
        End Set
    End Property

    Public Property gTC
        Get
            Return TC
        End Get
        Set(ByVal value)
            TC = value
        End Set
    End Property
    Public Property gtipooper
        Get
            Return tipo_oper
        End Get
        Set(ByVal value)
            tipo_oper = value
        End Set
    End Property



    Public Property gigv
        Get
            Return igv
        End Get
        Set(ByVal value)
            igv = value
        End Set
    End Property

    Public Property gventa
        Get
            Return venta
        End Get
        Set(ByVal value)
            venta = value
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

    Public Property gserie
        Get
            Return serie
        End Get
        Set(ByVal value)
            serie = value
        End Set
    End Property

    Public Property gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(ByVal value)
            fecha_venta = value
        End Set
    End Property

    Public Property ghora_emision
        Get
            Return hora_emision
        End Get
        Set(ByVal value)
            hora_emision = value
        End Set
    End Property

    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(ByVal value)
            fecha_vencimiento = value
        End Set

    End Property

    Public Property gcod_doc
        Get
            Return cod_doc
        End Get
        Set(ByVal value)
            cod_doc = value
        End Set

    End Property

    Public Property gnro_doc
        Get
            Return nro_doc
        End Get
        Set(ByVal value)
            nro_doc = value
        End Set

    End Property

    Public Property gcliente
        Get
            Return cliente
        End Get
        Set(ByVal value)
            cliente = value
        End Set

    End Property



    Public Property gtip_moneda
        Get
            Return tip_moneda
        End Get
        Set(ByVal value)
            tip_moneda = value
        End Set

    End Property

    Public Property gletras
        Get
            Return letras
        End Get
        Set(ByVal value)
            letras = value
        End Set

    End Property

    Public Property gestado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set

    End Property


    Public Property garchivo
        Get
            Return archivo
        End Get
        Set(ByVal value)
            archivo = value
        End Set

    End Property



    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_Venta As Integer, ByVal fecha_venta As Date, ByVal cod_Cliente As Integer)
        gcod_Venta = cod_Venta
        gfecha_venta = fecha_venta


    End Sub
End Class


