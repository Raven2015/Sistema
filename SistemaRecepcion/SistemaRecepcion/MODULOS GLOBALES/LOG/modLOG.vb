Imports System.IO
Module modLOG
    Public Sub registrar(ByVal texto As String)
        Dim obj As Object
        Dim archivo As Object
        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile("C:\LOG.txt")
        archivo.WriteLine("Registro de atención: " + texto + "Fecha: " + Date.Now)
        archivo.Close()
    End Sub

    Public Sub LOG(ByVal texto As String)
        Dim directorio = "C:\LOG.txt"
        Try
            My.Computer.FileSystem.WriteAllText(directorio, vbCrLf & "ID usuario: " & texto & "- Fecha: " & Date.Now, True)
        Catch ex As Exception
            Debug.Write("No se pudo registrar el archivo" + ex.Message)
        End Try
    End Sub
End Module
