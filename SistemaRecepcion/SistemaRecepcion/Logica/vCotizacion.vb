Public Class vCotizacion
    Dim estudio, precio, entidad As String

    Public Property gestudio
        Get
            Return estudio
        End Get
        Set(value)
            estudio = value
        End Set
    End Property

    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property

    Public Property gentidad
        Get
            Return entidad
        End Get
        Set(value)
            entidad = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal estudio As String, ByVal precio As String, ByVal entidad As String)
        gestudio = estudio
        gprecio = precio
        gentidad = entidad
    End Sub
End Class
