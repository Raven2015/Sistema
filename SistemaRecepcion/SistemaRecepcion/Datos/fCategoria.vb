﻿Imports System.Data.SqlClient
Public Class fCategoria

    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion
    Dim bd As New SqlConnection(My.Settings.Conexion)

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD

    Public Function mostrar() As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_categoria") 'Llama al procedimiento almacenado en la BD.
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


    Public Function mostrar_categoria_param(ByVal id As String) As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_categoria_param") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd
            cmd.Parameters.AddWithValue("@id_categoria", id)

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


    Public Function insertar(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_categoria", dts.gid_categoria)
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)
            cmd.Parameters.AddWithValue("@codigo_categoria", dts.gcodigo_categoria)

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

    Public Function editar(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_categoria", dts.gid_categoria)
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)
            cmd.Parameters.AddWithValue("@codigo_categoria", dts.gcodigo_categoria)

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

    Public Function eliminar(ByVal dts As vCategoria)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_categoria", SqlDbType.NVarChar, 50).Value = dts.gid_categoria
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

    Public Function generar_categoria() As Integer
        Try
            bd.Open()
            cmd = New SqlCommand("generar_categoria", bd)
            Dim param As New SqlParameter("@id_categoria", SqlDbType.Int)
            param.Direction = ParameterDirection.Output
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(param)
                .ExecuteNonQuery()
                bd.Close()
                Return .Parameters("@id_categoria").Value
            End With
        Catch ex As Exception
            MsgBox("No se pudo crear la categoria: RAZON>> " + ex.Message)
            Return 0
        End Try
    End Function

End Class
