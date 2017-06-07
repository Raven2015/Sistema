Public Class vBusqInforme
    Dim cliente As String
    Dim apellidos As String
    Dim ci_cliente As String
    Dim fecha As Date
    Dim informe As String
    Dim id As Integer
    Dim usuario As String

    Public Property gcliente
        Get
            Return cliente
        End Get
        Set(value)
            cliente = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property

    Public Property gci_cliente
        Get
            Return ci_cliente
        End Get
        Set(value)
            ci_cliente = value
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

    Public Property ginforme
        Get
            Return informe
        End Get
        Set(value)
            informe = value
        End Set
    End Property

    Public Property gid
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property gusuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal cliente As String,
                  ByVal apellidos As String,
                  ByVal ci_cliente As String,
                  ByVal fecha As Date,
                  ByVal informe As String,
                  ByVal id As Integer,
                  ByVal usuario As String
                  )
        gcliente = cliente
        gapellidos = apellidos
        gci_cliente = ci_cliente
        gfecha = fecha
        ginforme = informe
        gid = id
        gusuario = usuario
    End Sub

End Class
