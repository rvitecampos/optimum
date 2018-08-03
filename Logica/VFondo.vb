Public Class VFondo
    Dim Total_a_quitar, total_a_agregar, fondo As Double

    Public Property gTotal_a_quitar
        Get
            Return Total_a_quitar
        End Get
        Set(ByVal value)
            Total_a_quitar = value
        End Set
    End Property

    Public Property gtotal_a_agregar
        Get
            Return total_a_agregar
        End Get
        Set(ByVal value)
            total_a_agregar = value

        End Set
    End Property
    Public Property gFondo
        Get
            Return fondo
        End Get
        Set(ByVal value)
            fondo = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal total_a_agregar As Double, ByVal total_a_quitar As Double, ByVal fondo As Double)
        gtotal_a_agregar = total_a_agregar
        gTotal_a_quitar = total_a_quitar
        gFondo = fondo
    End Sub

End Class
