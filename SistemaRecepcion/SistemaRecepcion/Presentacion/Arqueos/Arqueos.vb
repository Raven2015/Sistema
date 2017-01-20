Public Class Arqueos
    Private Sub Arqueos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsPreliminar.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsPreliminar.listaEntidad)

    End Sub
End Class