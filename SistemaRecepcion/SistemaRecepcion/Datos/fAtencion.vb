Imports System.Data.SqlClient
Public Class fAtencion
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD
    Dim bd As New SqlConnection(My.Settings.Conexion)

    Public Function mostrar() As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_atencion") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd

            If cmd.ExecuteNonQuery Then 'Verifica que la consulta se realize exitosamente
                Dim dt As New DataTable 'Crea una variable que almacena el resultado obtenido de la consulta
                Dim da As New SqlDataAdapter(cmd) 'Crea una variable que permite usar el resultado dentro de la aplicacion
                da.Fill(dt) 'Llena la variable con los datos de la variable resultado (dt)
                Return dt 'Devuelve el resultado de la consulta a la BD
            Else
                Return Nothing 'En caso de que el resultado sea nulo se devuelve NADA
            End If
        Catch ex As Exception
            'En caso de errror se muestra un mensaje con la informacion del error ocurrido
            MsgBox(ex.Message)
            'Se devuelve falso pues no se realizo la conexion
            Return Nothing
        Finally 'Finaliza el proceso
            desconectado() 'Cierra la conexion a la BD
        End Try
    End Function

    Public Function insertarOpcional(ByVal dts As vAtencion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@medico_remitente", dts.gdoctor_remitente)
            cmd.Parameters.AddWithValue("@fecha_atencion", dts.gfecha)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@precio_parcial", dts.gprecio_parcial)
            cmd.Parameters.AddWithValue("@id_medico", dts.gid_medico)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Sub insertar(ByVal dts As vAtencion)
        bd.Open()
        cmd = New SqlCommand("insertar_atencion", bd)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_atencion", dts.gid_atencion)
            .AddWithValue("@medico_remitente", dts.gdoctor_remitente)
            .AddWithValue("@fecha_atencion", dts.gfecha)
            .AddWithValue("@id_cliente", dts.gid_cliente)
            .AddWithValue("@precio_parcial", dts.gprecio_parcial)
            .AddWithValue("@id_medico", dts.gid_medico)
        End With
        cmd.ExecuteNonQuery()
        bd.Close()
    End Sub

    Public Function editarTODO(ByVal dts As vAtencion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@medico_remitente", dts.gdoctor_remitente)
            cmd.Parameters.AddWithValue("@fecha_atencion", dts.gfecha)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@precio_parcial", dts.gprecio_parcial)
            cmd.Parameters.AddWithValue("@id_medico", dts.gid_medico)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vAtencion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@precio_parcial", dts.gprecio_parcial)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vAtencion)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_atencion", SqlDbType.NVarChar, 50).Value = dts.gid_atencion
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Metodo Nuevo que permite crear una instancia en blanco de Atencion. Solo con el ID_ATENCION
    Public Function generar_atencion() As Integer
        Try
            bd.Open()
            cmd = New SqlCommand("generar_atencion", bd)
            Dim param As New SqlParameter("@id_atencion", SqlDbType.Int)
            param.Direction = ParameterDirection.Output
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(param)
                .ExecuteNonQuery()
                bd.Close()
                Return .Parameters("@id_atencion").Value
            End With
        Catch ex As Exception
            MsgBox("No se pudo crear la Atencion: RAZON>> " + ex.Message)
            Return 0
        End Try
    End Function

End Class
