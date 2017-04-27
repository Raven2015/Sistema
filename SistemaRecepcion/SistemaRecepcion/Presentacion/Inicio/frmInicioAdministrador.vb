Public Class frmInicioAdministrador
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Me.WindowState = FormWindowState.Minimized
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnEstudio_Click(sender As Object, e As EventArgs) Handles btnEstudio.Click
        Me.WindowState = FormWindowState.Minimized
        frmEstudio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        Me.WindowState = FormWindowState.Minimized
        frmCategoria.ShowDialog()
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        Me.WindowState = FormWindowState.Minimized
        frmListaPrecios.ShowDialog()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        Me.WindowState = FormWindowState.Minimized
        frmCentral.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'dlgNuevaAtencion.ShowDialog()
        Prueba.ShowDialog()
    End Sub

    Private Sub btnEntidad_Click(sender As Object, e As EventArgs) Handles btnEntidad.Click
        Me.WindowState = FormWindowState.Minimized
        frmEntidad.ShowDialog()
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ingreso.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Ingreso.Visible() = True
        Me.Close()
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnComprobante.Click
        Me.WindowState = FormWindowState.Minimized
        frmComprobantesCaja.ShowDialog()
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        Me.WindowState = FormWindowState.Minimized
        frmCotizacion.ShowDialog()
    End Sub

    Private Sub btnArqueos_Click(sender As Object, e As EventArgs) Handles btnArqueos.Click
        Me.WindowState = FormWindowState.Minimized
        frmArqueos.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.WindowState = FormWindowState.Minimized
        frmMenuReportes.ShowDialog()
    End Sub

End Class