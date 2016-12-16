Imports System.Data.SqlClient
Public Class fEntidad
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD
    Dim bd As New SqlConnection(My.Settings.Conexion)


    Public Function mostrar() As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_precios") 'Llama al procedimiento almacenado en la BD.
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


    Public Sub insertar(ByVal dts As vEntidad)
        bd.Open()
        cmd = New SqlCommand("insertar_entidad", bd)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_entidad", dts.gid_entidad)
            .AddWithValue("@entidad", dts.gentidad)
            .AddWithValue("@id_precio", dts.gid_precio)
            .AddWithValue("@id_estudio", dts.gid_estudio)
        End With
        cmd.ExecuteNonQuery()
        bd.Close()
    End Sub


    Public Function editar(ByVal dts As vEntidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_entidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_entidad", dts.gid_entidad)
            cmd.Parameters.AddWithValue("@entidad", dts.gentidad)
            cmd.Parameters.AddWithValue("@id_precio", dts.gid_precio)
            cmd.Parameters.AddWithValue("@id_estudio", dts.gid_estudio)

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



    '--------------ENTIDAD------------
    Public Function generar_entidad() As Integer
        Try
            bd.Open()
            cmd = New SqlCommand("generar_entidad", bd)
            Dim param As New SqlParameter("@id_entidad", SqlDbType.Int)
            param.Direction = ParameterDirection.Output
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(param)
                .ExecuteNonQuery()
                bd.Close()
                Return .Parameters("@id_entidad").Value
            End With
        Catch ex As Exception
            MsgBox("No se pudo generar la Entidad: RAZON>> " + ex.Message)
            Return 0
        End Try
    End Function

    Public Function eliminar(ByVal dts As vEntidad)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_entidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_entidad", SqlDbType.NVarChar, 50).Value = dts.gid_entidad
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



End Class
