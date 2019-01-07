Public Class vRutaSFS
    Dim rutaSFS As String
    Public Property grutasfs
        Get
            Return rutaSFS
        End Get
        Set(ByVal value)
            rutaSFS = value

        End Set
    End Property
    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal rutasfs As String)
        grutasfs = rutasfs
    End Sub
End Class
