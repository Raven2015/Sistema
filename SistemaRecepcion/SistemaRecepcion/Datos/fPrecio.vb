Imports System.Data.SqlClient
Public Class fprecio
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD
    Dim bd As New SqlConnection(My.Settings.Conexion)

    Public Sub insertar(ByVal dts As vPrecio)
        bd.Open()
        cmd = New SqlCommand("insertar_precio", bd)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_precio", dts.gid_precio)
            .AddWithValue("@precio", dts.gprecio)
        End With
        cmd.ExecuteNonQuery()
        bd.Close()
    End Sub

    Public Function editar(ByVal dts As vPrecio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_precio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_precio", dts.gid_precio)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)

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


    Public Function eliminar(ByVal dts As vPrecio)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_precio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_precio", SqlDbType.NVarChar, 50).Value = dts.gid_precio
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


    Public Function generar_precio() As Integer
        Try
            bd.Open()
            cmd = New SqlCommand("generar_precio", bd)
            Dim param As New SqlParameter("@id_precio", SqlDbType.Int)
            param.Direction = ParameterDirection.Output
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(param)
                .ExecuteNonQuery()
                bd.Close()
                Return .Parameters("@id_precio").Value
            End With
        Catch ex As Exception
            MsgBox("No se pudo generar el precio: RAZON>> " + ex.Message)
            Return 0
        End Try
    End Function
End Class
