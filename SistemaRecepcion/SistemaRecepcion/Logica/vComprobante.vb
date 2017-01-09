Public Class vComprobante
    Dim fecha_atencion As Date
    Dim institucion, ci, apellido_cliente, nombre_cliente
    Dim precio As Double
    Dim id_atencion As Integer

    Public Property gfecha_atencion
        Get
            Return fecha_atencion
        End Get
        Set(value)
            fecha_atencion = value
        End Set
    End Property

    Public Property ginstitucion
        Get
            Return institucion
        End Get
        Set(value)
            institucion = value
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

    Public Property gapellido_cliente
        Get
            Return apellido_cliente
        End Get
        Set(value)
            apellido_cliente = value
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

    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
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

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal fecha_atencion As Date,
                  ByVal institucion As String,
                  ByVal ci As String,
                  ByVal apellido_cliente As String,
                  ByVal nombre_cliente As String,
                  ByVal precio As Double,
                  ByVal id_atencion As Integer)
        gfecha_atencion = fecha_atencion
        ginstitucion = institucion
        gci = ci
        gapellido_cliente = apellido_cliente
        gnombre_cliente = nombre_cliente
        gprecio = precio
        gid_atencion = id_atencion
    End Sub
End Class
