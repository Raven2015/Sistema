Imports System.Data.SqlClient
Public Class fInformeMedico
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion

    Dim BD As New SqlConnection(My.Settings.Conexion)
    'Dim BD As New SqlConnection(CadenaConexion.crear_cadena("192.168.1.105"))

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD



    Public Function buscar_informe(ByVal dts As vInformeMedicoB) As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("bucar_informe") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd
            cmd.Parameters.AddWithValue("@id_atencion ", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@nombre_cliente ", dts.gnombre_cliente)
            cmd.Parameters.AddWithValue("@apellido_cliente ", dts.gapellido_cliente)
            cmd.Parameters.AddWithValue("@ci_cliente ", dts.gci_cliente)

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

    Public Function mostrar() As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_medico") 'Llama al procedimiento almacenado en la BD.
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
    Public Function insertar(ByVal dts As vMedico) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_medico")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_medico", dts.gid_medico)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)

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

    Public Function editar(ByVal dts As vMedico) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_medico", dts.gid_medico)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)

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

    Public Function eliminar(ByVal dts As vMedico)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_medico")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_medico", SqlDbType.NVarChar, 50).Value = dts.gid_medico
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


    Public Function insertar_informe_medico(ByVal dts As vInformeMedico) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_informe_actualizado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@informe", dts.ginforme)
            cmd.Parameters.AddWithValue("@fecha_informe", dts.gfecha_informe)
            cmd.Parameters.AddWithValue("@id_usuario", dts.gid_usuario)

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

    Public Function verificacion_informe(
                                        ByVal login As String,
                                        ByVal id_atencion As String) As Integer

        Try
            BD.Open()
            cmd = New SqlCommand("verifInforme", BD)

            cmd.Parameters.AddWithValue("@login", login)
            cmd.Parameters.AddWithValue("@idAtencion", id_atencion)
            Dim respuesta As New SqlParameter("@respuesta", SqlDbType.Int)
            respuesta.Direction = ParameterDirection.Output

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(respuesta)
                .ExecuteNonQuery()
                BD.Close()
                Return .Parameters("@respuesta").Value

            End With
        Catch ex As Exception
            MsgBox("Error an la BD: RAZON>> " + ex.Message)
            Return 0
        End Try
    End Function
End Class
