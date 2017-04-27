Public Class frmInicioRecepcion
    Private Sub btnLista_Click(sender As Object, e As EventArgs)
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

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.WindowState = FormWindowState.Minimized
        frmMenuReportes.ShowDialog()
    End Sub

    Private Sub btnArqueos_Click(sender As Object, e As EventArgs) Handles btnArqueos.Click
        Me.WindowState = FormWindowState.Minimized
        frmArqueos.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
        frmComprobantesCaja.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
        frmCotizacion.ShowDialog()
    End Sub
End Class