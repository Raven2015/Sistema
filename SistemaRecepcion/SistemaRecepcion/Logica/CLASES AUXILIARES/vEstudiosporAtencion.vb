Public Class vEstudiosporAtencion
    Dim id_atencion As Integer
    Dim entidad As String
    Dim precio As Double
    Dim estudio As String
    Dim categoria As String

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
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

    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property

    Public Property gestudio
        Get
            Return estudio
        End Get
        Set(value)
            estudio = value
        End Set
    End Property

    Public Property gcategoria
        Get
            Return categoria
        End Get
        Set(value)
            categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_atencion As Integer,
                   ByVal categoria As String,
                   ByVal estudio As String,
                   ByVal precio As Double,
                   ByVal entidad As String)
        gid_atencion = id_atencion
        gcategoria = categoria
        gestudio = estudio
        gprecio = precio
        gentidad = entidad
    End Sub
End Class
