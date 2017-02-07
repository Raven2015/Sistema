Public Class vReporteAtencion
    Dim fecha_atencion As Date
    Dim medicoRemitente As String
    Dim precio As Double
    Dim medicoDestinatario As String
    Dim nombres As String
    Dim apellidos As String
    Dim ci As String
    Dim codigo_asegurado As String
    Dim edad As Integer
    Dim nit As String
    Dim entidad As String
    Dim id_atencion As Integer
    Dim categoria As String
    Dim estudio As String

    Public Property gfecha_atencion
        Get
            Return fecha_atencion
        End Get
        Set(value)
            fecha_atencion = value
        End Set
    End Property

    Public Property gmedicoRemitente
        Get
            Return medicoRemitente
        End Get
        Set(value)
            medicoRemitente = value
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

    Public Property gmedicodestinatario
        Get
            Return medicoDestinatario
        End Get
        Set(value)
            medicoDestinatario = value
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

    Public Property gcodigo_asegurado
        Get
            Return codigo_asegurado
        End Get
        Set(value)
            codigo_asegurado = value
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

    Public Property gnit
        Get
            Return nit
        End Get
        Set(value)
            nit = value
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

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
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

    Public Property gestudio
        Get
            Return estudio
        End Get
        Set(value)
            estudio = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal fecha_atencion As Date,
                  ByVal medicoRemitente As String,
                  ByVal precio As String,
                  ByVal medicodestinatario As String,
                  ByVal nombres As String,
                  ByVal apellidos As String,
                  ByVal ci As String,
                  ByVal codigo_asegurado As String,
                  ByVal edad As Integer,
                  ByVal nit As String,
                  ByVal entidad As String,
                  ByVal id_atencion As String)
        gfecha_atencion = fecha_atencion
        gmedicoRemitente = medicoRemitente
        gmedicodestinatario = medicodestinatario
        gprecio = precio
        gnombres = nombres
        gapellidos = apellidos
        gci = ci
        gcodigo_asegurado = codigo_asegurado
        gedad = edad
        gnit = nit
        gentidad = entidad
        gid_atencion = id_atencion
    End Sub

    Public Sub New(
              ByVal fecha_atencion As Date,
              ByVal medicoRemitente As String,
              ByVal precio As String,
              ByVal medicodestinatario As String,
              ByVal nombres As String,
              ByVal apellidos As String,
              ByVal ci As String,
              ByVal codigo_asegurado As String,
              ByVal edad As Integer,
              ByVal nit As String,
              ByVal entidad As String,
              ByVal id_atencion As String,
              ByVal categoria As String,
              ByVal estudio As String)
        gfecha_atencion = fecha_atencion
        gmedicoRemitente = medicoRemitente
        gmedicodestinatario = medicodestinatario
        gprecio = precio
        gnombres = nombres
        gapellidos = apellidos
        gci = ci
        gcodigo_asegurado = codigo_asegurado
        gedad = edad
        gnit = nit
        gentidad = entidad
        gid_atencion = id_atencion
        gcategoria = categoria
        gestudio = estudio
    End Sub
End Class
