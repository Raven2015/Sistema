Public Class vEgreso
    Dim id_egreso As Integer
    Dim fecha_egreso As Date

    Public Property gid_egreso
        Get
            Return id_egreso
        End Get
        Set(value)
            id_egreso = value
        End Set
    End Property

    Public Property gfecha_egreso
        Get
            Return fecha_egreso
        End Get
        Set(value)
            fecha_egreso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_egreso As Integer, ByVal fecha_egreso As Date)
        gid_egreso = id_egreso
        gfecha_egreso = fecha_egreso
    End Sub
End Class
