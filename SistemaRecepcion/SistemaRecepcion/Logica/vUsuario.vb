Public Class vUsuario
    Dim id_usuario As Integer
    Dim nombre, apellido, ci, direccion, telefono, celular, login, password, tipo, acceso As String

    Public Property gid_usuario()
        Get
            Return id_usuario
        End Get
        Set(value)
            id_usuario = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
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

    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property gtipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)
            acceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_usuario As Integer,
                   ByVal nombre As String,
                   ByVal apellido As String,
                   ByVal ci As String,
                   ByVal direccion As String,
                   ByVal telefono As String,
                   ByVal celular As String,
                   ByVal login As String,
                   ByVal password As String,
                   ByVal tipo As String,
                   ByVal acceso As String)

        gid_usuario = id_usuario
        gnombre = nombre
        gapellido = apellido
        gci = ci
        gdireccion = direccion
        gtelefono = telefono
        gcelular = celular
        glogin = login
        gpassword = password
        gacceso = acceso
        gtipo = tipo
    End Sub
End Class
