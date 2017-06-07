Public Class vImpresion
    Dim id_atencion As Integer
    Dim id_usuario As Integer
    Dim contador As Integer

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property gid_usuario
        Get
            Return id_usuario
        End Get
        Set(value)
            id_usuario = value
        End Set
    End Property

    Public Property gcontador
        Get
            Return contador
        End Get
        Set(value)
            contador = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal id_atencion As Integer,
                  ByVal id_usuario As Integer,
                  ByVal contador As Integer
                  )
        gid_atencion = id_atencion
        gid_usuario = id_usuario
        gcontador = contador
    End Sub
End Class
