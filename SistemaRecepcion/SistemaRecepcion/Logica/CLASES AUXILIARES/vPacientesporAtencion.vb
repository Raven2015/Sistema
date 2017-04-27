Public Class vPacientesporAtencion
    Dim id_atencion As Integer
    Dim id_cliente As Integer
    Dim nombres, apellidos, ci, sexo, celular, codigo, razon_social, nit As String
    Dim fecha_nacimento As Date

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property gid_cliente
        Get
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(value)
            nombres = value
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

    Public Property gci
        Get
            Return ci
        End Get
        Set(value)
            ci = value
        End Set
    End Property

    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(value)
            sexo = value
        End Set
    End Property

    Public Property gcelular
        Get
            Return celular
        End Get
        Set(value)
            celular = value
        End Set
    End Property
    Public Property gcodigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property

    Public Property grazon_social
        Get
            Return razon_social
        End Get
        Set(value)
            razon_social = value
        End Set
    End Property

    Public Property gnit
        Get
            Return nit
        End Get
        Set(value)
            nit = value
        End Set
    End Property
    Public Property gfecha_nacimiento
        Get
            Return fecha_nacimento
        End Get
        Set(value)
            fecha_nacimento = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_atencion As Integer,
                    ByVal id_cliente As Integer,
                    ByVal nombres As String,
                    ByVal apellidos As String,
                    ByVal ci As String,
                    ByVal sexo As String,
                    ByVal celular As String,
                    ByVal codigo As String,
                    ByVal razon_social As String,
                    ByVal nit As String,
                    ByVal fecha_nacimento As Date)
        gid_atencion = id_atencion
        gid_cliente = id_cliente
        gnombres = nombres
        gapellidos = apellidos
        gci = ci
        gsexo = sexo
        gcelular = celular
        gcodigo = codigo
        grazon_social = razon_social
        gnit = nit
        gfecha_nacimiento = fecha_nacimento
    End Sub
End Class
