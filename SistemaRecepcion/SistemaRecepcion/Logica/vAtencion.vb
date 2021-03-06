﻿Public Class vAtencion
    Dim id_atencion, id_cliente, id_medico As Integer
    Dim fecha As Date
    Dim precio_parcial As Double
    Dim doctor_remitente, tipo_documento, num_documento, descripcion As String

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

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnumero_documento
        Get
            Return num_documento
        End Get
        Set(value)
            num_documento = value
        End Set
    End Property

    Public Property gdoctor_remitente
        Get
            Return doctor_remitente
        End Get
        Set(value)
            doctor_remitente = value
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

    Public Property gprecio_parcial
        Get
            Return precio_parcial
        End Get
        Set(value)
            precio_parcial = value
        End Set
    End Property

    Public Property gid_medico
        Get
            Return id_medico
        End Get
        Set(value)
            id_medico = value
        End Set
    End Property

    '------------------ CONSTRUCTORES DE LA CLASE
    Public Sub New()

    End Sub

    'Public Sub New(
    '              ByVal id_atencion As Integer,
    '              ByVal id_cliente As Integer,
    '              ByVal fecha As Date,
    '              ByVal doctor_remitente As String,
    '              ByVal tipo_documento As String,
    '              ByVal numero_documento As String,
    '              ByVal descripcion As String)
    '    gid_atencion = id_atencion
    '    gid_cliente = id_cliente
    '    gfecha = fecha
    '    gdoctor_remitente = doctor_remitente
    '    gtipo_documento = tipo_documento
    '    gnumero_documento = numero_documento
    '    gdescripcion = descripcion
    'End Sub

    Public Sub New(
                  ByVal id_atencion As Integer,
                  ByVal id_cliente As Integer,
                  ByVal fecha As Date,
                  ByVal doctor_remitente As String,
                  ByVal precio_parcial As String,
                  ByVal id_medico As Integer
                  )
        gid_atencion = id_atencion
        gid_cliente = id_cliente
        gfecha = fecha
        gdoctor_remitente = doctor_remitente
        gprecio_parcial = precio_parcial
        gid_medico = id_medico
    End Sub


End Class
