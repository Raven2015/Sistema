Public Class vReporteMedico
    Dim nombres As String
    Dim apellidos As String
    Dim ci As String
    Dim edad As Integer
    Dim celular As String
    Dim fecha_nacimiento As date
    Dim sexo As String
    Dim codigo_asegurado As String
    Dim nit As String
    Dim medico_remitente As String
    Dim medico_destinatario As String
    Dim entidad As String

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

    Public Property gedad
        Get
            Return edad
        End Get
        Set(value)
            edad = value
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

    Public Property gfecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
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

    Public Property gcodigo_asegurado
        Get
            Return codigo_asegurado
        End Get
        Set(value)
            codigo_asegurado = value
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

    Public Property gmedico_remitente
        Get
            Return medico_remitente
        End Get
        Set(value)
            medico_remitente = value
        End Set
    End Property

    Public Property gmedico_destinatario
        Get
            Return medico_destinatario
        End Get
        Set(value)
            medico_destinatario = value
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

    Public Sub New(ByVal nombres As String,
                   ByVal apellidos As String,
                   ByVal ci As String,
                   ByVal edad As Integer,
                   ByVal celular As String,
                   ByVal fecha_nacimiento As Date,
                   ByVal sexo As String,
                   ByVal codigo_asegurado As String,
                   ByVal nit As String,
                   ByVal medico_remitente As String,
                   ByVal medico_destinatario As String,
                   ByVal entidad As String)

        gnombres = nombres
        gapellidos = apellidos
        gci = ci
        gedad = edad
        gcelular = celular
        gfecha_nacimiento = fecha_nacimiento
        gsexo = sexo
        gcodigo_asegurado = codigo_asegurado
        gnit = nit
        gmedico_destinatario = medico_destinatario
        gmedico_remitente = medico_remitente
        gentidad = entidad
    End Sub
End Class
