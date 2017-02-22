Imports System.Data.SqlClient
Public Class fArqueoIngreso
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion
    Dim bd As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD

    Public Function mostrar_ingresos_fecha(ByVal fecha_atencion As Date, ByVal entidad As String, ByVal turno As String) As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("ingresos_diarios_por_categoria2") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd
            cmd.Parameters.AddWithValue("@fecha_atencion", fecha_atencion)
            cmd.Parameters.AddWithValue("@entidad", entidad)
            cmd.Parameters.AddWithValue("@turno", turno)

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
End Class
