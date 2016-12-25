Imports System.Data.SqlClient
Public Class fUsuario
    Inherits conexion

    Dim cmd As New SqlCommand


    Public Function validar_usuario(dts As vUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Problema de Autenticación en la BD>> " & ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function inicio_sesion(ByVal dts As vUsuario) As DataTable
        conectado()
        cmd = New SqlCommand("validar_usuario")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn
        cmd.Parameters.AddWithValue("@login", dts.glogin)
        cmd.Parameters.AddWithValue("@password", dts.gpassword)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
