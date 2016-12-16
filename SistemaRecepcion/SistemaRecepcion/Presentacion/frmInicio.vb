Public Class frmInicio
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnEstudio_Click(sender As Object, e As EventArgs) Handles btnEstudio.Click
        frmEstudio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCategoria.ShowDialog()
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmListaPrecios.ShowDialog()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        frmCentral.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'dlgNuevaAtencion.ShowDialog()
        Prueba.ShowDialog()
    End Sub

    Private Sub btnEntidad_Click(sender As Object, e As EventArgs) Handles btnEntidad.Click
        frmEntidad.ShowDialog()
    End Sub
End Class