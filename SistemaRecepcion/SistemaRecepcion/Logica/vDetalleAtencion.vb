Public Class vDetalleAtencion
    Dim id_detalle, id_atencion, id_entidad As Integer
    'Dim precio_parcial As Double   '----MODIFICADO - CAMPO MOVIDO A LA CLASE ATENCION----

    Public Property gid_detalle
        Get
            Return id_detalle
        End Get
        Set(value)
            id_detalle = value
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

    Public Property gid_entidad
        Get
            Return id_entidad
        End Get
        Set(value)
            id_entidad = value
        End Set
    End Property

    'Public Property gprecio_parcial
    '    Get
    '        Return precio_parcial
    '    End Get
    '    Set(value)
    '        precio_parcial = value
    '    End Set
    'End Property

    'Public Property gprecio_total
    '    Get
    '        Return precio_total
    '    End Get
    '    Set(value)
    '        precio_total = value
    '    End Set
    'End Property
    '-----COLUMNA ELIMINADA-----


    '-------------- CONSTRUCTORES
    Public Sub New()

    End Sub


    Public Sub New(ByVal id_detalle As Integer,
                   ByVal id_atencion As Integer,
                   ByVal id_entidad As Integer)
        gid_detalle = id_detalle
        gid_atencion = id_atencion
        gid_entidad = id_entidad
        'gprecio_parcial = precio_parcial
        'gprecio_total = precio_total -----COLUMNA ELIMINADA-----
    End Sub
End Class
