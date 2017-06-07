Public Class frmInicioRecepcion
    Private Sub btnLista_Click(sender As Object, e As EventArgs)
        frmListaPrecios.ShowDialog()
        frmListaPrecios.TopMost = True
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

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.WindowState = FormWindowState.Minimized
        frmMenuReportes.ShowDialog()
    End Sub

    Private Sub btnArqueos_Click(sender As Object, e As EventArgs) Handles btnArqueos.Click
        Me.WindowState = FormWindowState.Minimized
        frmArqueos.ShowDialog()
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnComprobante.Click
        Me.WindowState = FormWindowState.Minimized
        frmComprobantesCaja.ShowDialog()
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        Me.WindowState = FormWindowState.Minimized
        frmCotizacion.ShowDialog()
        frmCotizacion.TopMost = True
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Me.WindowState = FormWindowState.Minimized
        frmModificaciones.ShowDialog()
    End Sub
End Class