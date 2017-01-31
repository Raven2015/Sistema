Public Class frmReporteAtencionesLapsoTiempo
    Private Sub frmReporteAtencionesLapsoTiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)

    End Sub
End Class