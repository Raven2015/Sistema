Public Class vArqueoIngreso
    Dim categoria As String
    Dim entidad As String
    Dim fecha As Date
    Dim precio_final As Double

    Public Property gcategoria
        Get
            Return categoria
        End Get
        Set(value)
            categoria = value
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
    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
    Public Property gprecio_final
        Get
            Return precio_final
        End Get
        Set(value)
            precio_final = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal categoria As String,
                  ByVal entidad As String,
                  ByVal fecha As Date,
                  ByVal precio_final As Double
                  )
        gcategoria = categoria
        gentidad = entidad
        gfecha = fecha
        gprecio_final = precio_final
    End Sub
End Class
