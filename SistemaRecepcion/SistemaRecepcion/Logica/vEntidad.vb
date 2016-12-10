Public Class vEntidad
    Dim id_entidad, id_estudio, id_precio As Integer
    Dim entidad As String

    Public Property gid_entidad
        Get
            Return id_entidad
        End Get
        Set(value)
            id_entidad = value
        End Set
    End Property

    Public Property gid_estudio
        Get
            Return id_estudio
        End Get
        Set(value)
            id_estudio = value
        End Set
    End Property

    Public Property gid_precio
        Get
            Return id_precio
        End Get
        Set(value)
            id_precio = value
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

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_entidad As Integer, ByVal id_estudio As Integer, ByVal id_precio As Integer, ByVal entidad As String)
        gid_entidad = id_entidad
        gid_estudio = id_estudio
        gid_precio = id_precio
        gentidad = entidad
    End Sub
End Class
