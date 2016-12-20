Module CadenaConexion
    Public Function crear_cadena(ByVal param As String) As String
        Dim cadena As String = ""
        cadena = "Data Source=" & param & ";Initial Catalog=dbBIOMEDICA;Integrated Security=True"
        Return cadena
    End Function
End Module
