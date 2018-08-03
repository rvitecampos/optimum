Public Class VCaja
    'Dim fecha As String
    Dim inicial As Double
    'Public Property gfecha
    '    Get
    '        Return fecha
    '    End Get
    '    Set(value)
    '        fecha = value
    '    End Set
    'End Property
    Public Property ginicial
        Get
            Return inicial
        End Get
        Set(value)
            inicial = value
        End Set
    End Property
  
    Public Sub New()

    End Sub
    Public Sub New(ByVal inicial As Double)
        'gfecha = fecha
        ginicial = inicial

    End Sub
End Class
