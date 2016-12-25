Public Class vMedico
    'Se declara cada campo de la clase Medico
    Dim id_medico As Integer
    Dim nombres As String
    Dim apellidos As String
    Dim direccion As String
    Dim telefono As String
    Dim celular As String
    Dim ci As String
    Dim cargo As String
    Dim sexo As String


    'Se crean los metodos Set y Get

    Public Property gid_medico
        Get
            Return id_medico
        End Get
        Set(value)
            id_medico = value
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

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
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

    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(value)
            sexo = value
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

    Public Property gcargo
        Get
            Return cargo
        End Get
        Set(value)
            cargo = value
        End Set
    End Property

    'Creacion de los constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_medico As Integer,
                   ByVal nombres As String,
                   ByVal apellidos As String,
                   ByVal direccion As String,
                   ByVal telefono As String,
                   ByVal celular As String,
                   ByVal sexo As String,
                   ByVal ci As String,
                   ByVal cargo As String)
        gid_medico = id_medico
        gnombres = nombres
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gcelular = celular
        gsexo = sexo
        gci = ci
        gcargo = cargo
    End Sub
End Class
