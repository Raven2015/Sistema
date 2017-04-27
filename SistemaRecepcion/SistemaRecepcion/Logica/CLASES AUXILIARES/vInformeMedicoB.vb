Public Class vInformeMedicoB

    Dim id_atencion As String
    Dim nombre_cliente As String
    Dim apellido_cliente As String
    Dim ci_cliente As String

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property gnombre_cliente
        Get
            Return nombre_cliente
        End Get
        Set(value)
            nombre_cliente = value
        End Set
    End Property

    Public Property gapellido_cliente
        Get
            Return apellido_cliente
        End Get
        Set(value)
            apellido_cliente = value
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


    Public Sub New()

    End Sub

    Public Sub New(ByVal id_atencion As String,
                   ByVal nombre_cliente As String,
                   ByVal apellido_cliente As String,
                   ByVal ci_cliente As String)
        gid_atencion = id_atencion
        gnombre_cliente = nombre_cliente
        gapellido_cliente = apellido_cliente
        gci_cliente = ci_cliente
    End Sub

End Class
