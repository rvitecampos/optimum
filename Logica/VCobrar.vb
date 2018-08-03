Public Class VCobrar
    Dim cood_Cliente As Integer

    Public Property gCood_cliente
        Get
            Return cood_Cliente
        End Get
        Set(value)
            cood_Cliente = value
        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal cood_cliente As Integer)
        gCood_cliente = cood_cliente
    End Sub
End Class
