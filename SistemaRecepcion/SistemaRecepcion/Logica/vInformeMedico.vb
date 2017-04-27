Public Class vInformeMedico
    Dim id_informe As Integer
    Dim id_atencion As Integer
    Dim informe As String
    Dim fecha_informe As Date
    Dim id_usuario As Integer

    Public Property gid_informe
        Get
            Return id_informe
        End Get
        Set(value)
            id_informe = value
        End Set
    End Property
    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property ginforme
        Get
            Return informe
        End Get
        Set(value)
            informe = value
        End Set
    End Property

    Public Property gfecha_informe
        Get
            Return fecha_informe
        End Get
        Set(value)
            fecha_informe = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_informe As Integer,
                   ByVal id_atencion As Integer,
                   ByVal informe As String,
                   ByVal fecha_informe As Date,
                   ByVal id_usuario As Integer)
        gid_informe = id_informe
        gid_atencion = id_atencion
        ginforme = informe
        gfecha_informe = fecha_informe
        gid_usuario = id_usuario
    End Sub
End Class
