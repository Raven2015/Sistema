Public Class vPrecio
    Dim id_precio As Integer
    Dim precio As Double

    Public Property gid_precio
        Get
            Return id_precio
        End Get
        Set(value)
            id_precio = value
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

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal id_precio As Integer,
                  ByVal precio As Double)
        gid_precio = id_precio
        gprecio = precio
    End Sub

End Class
