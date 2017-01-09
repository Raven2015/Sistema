Public Class vDetalleEgreso
    Dim id_detalle_egreso As Integer
    Dim id_egreso As Integer
    Dim monto As Double
    Dim descripcion As String
    Dim destinatario As String
    Dim responsable As String

    Public Property gid_detalle_egreso
        Get
            Return id_detalle_egreso
        End Get
        Set(value)
            id_detalle_egreso = value
        End Set
    End Property

    Public Property gid_egreso
        Get
            Return id_egreso
        End Get
        Set(value)
            id_egreso = value
        End Set
    End Property

    Public Property gmonto
        Get
            Return monto
        End Get
        Set(value)
            monto = value
        End Set
    End Property

    Public Property gdestinatario
        Get
            Return destinatario
        End Get
        Set(value)
            destinatario = value
        End Set
    End Property

    Public Property gresponsable
        Get
            Return responsable
        End Get
        Set(value)
            responsable = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal id_detalle_egreso As Integer,
                  ByVal id_egreso As Integer,
                  ByVal monto As Integer,
                  ByVal destinatario As String,
                  ByVal responsable As String,
                  ByVal descripcion As String)
        gid_detalle_egreso = id_detalle_egreso
        gid_egreso = id_egreso
        gmonto = monto
        gdestinatario = destinatario
        gresponsable = responsable
        gdescripcion = descripcion
    End Sub
End Class
