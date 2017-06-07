Imports System.Data.SqlClient
Public Class fImpresion
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion
    Dim bd As New SqlConnection(My.Settings.Conexion)

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD

    Public Function mostrar_impresion(ByVal id_atencion As Integer, ByVal id_usuario As Integer) As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_impresiones") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd

            cmd.Parameters.AddWithValue("@id_atencion", id_atencion)
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)

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

    Public Function insertar_impresion(ByVal id_atencion As Integer, ByVal id_usuario As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_impresion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", id_atencion)
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)


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
End Class
