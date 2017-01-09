Public Class InicioRecepcion
    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmListaPrecios.ShowDialog()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        frmCentral.ShowDialog()
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Ingreso.Visible() = True
        Me.Close()
    End Sub

    Private Sub InicioRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ingreso.Hide()
    End Sub

End Class