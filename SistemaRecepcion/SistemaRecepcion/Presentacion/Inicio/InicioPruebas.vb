Public Class InicioPruebas
    Private Sub btnReporteCaja_Click(sender As Object, e As EventArgs) Handles btnReporteCaja.Click
        ReporteCajaFinal.ShowDialog()
    End Sub

    Private Sub btnReporteAtencion_Click(sender As Object, e As EventArgs) Handles btnReporteAtencion.Click
        ReporteFinal.ShowDialog()
    End Sub

    Private Sub btnArqueos_Click(sender As Object, e As EventArgs) Handles btnArqueos.Click
        frmArqueos.ShowDialog()
    End Sub

    Private Sub btnReporteArqueo_Click(sender As Object, e As EventArgs) Handles btnReporteArqueo.Click
        ReporteArqueo.ShowDialog()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        frmInicioAdministrador.ShowDialog()
    End Sub

    Private Sub btnReporteAtencionesTiempoEntidad_Click(sender As Object, e As EventArgs) Handles btnReporteAtencionesTiempoEntidad.Click
        frmReporteAtencionesLapsoTiempo.ShowDialog()
    End Sub

    Private Sub btnReporteTiempoEntidad_Click(sender As Object, e As EventArgs) Handles btnReporteTiempoEntidad.Click
        frmReportePorEntidades.ShowDialog()
    End Sub

    Private Sub btnEstudiosPorEntidad_Click(sender As Object, e As EventArgs) Handles btnEstudiosPorEntidad.Click
        frmEstudiosPorEntidad.ShowDialog()
    End Sub

    Private Sub btnEstudiosByMedico_Click(sender As Object, e As EventArgs) Handles btnEstudiosByMedico.Click
        frmReportePorMedicos.ShowDialog()
    End Sub

    Private Sub btnFrmListaAtencionesporMedico_Click(sender As Object, e As EventArgs) Handles btnFrmListaAtencionesporMedico.Click
        frmReportedeAtencionesporMedicos.ShowDialog()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        MDIContenedor.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmReporteAtencionesLapsoTiempo.ShowDialog()
    End Sub

    Private Sub btnInicioPrueba_Click(sender As Object, e As EventArgs) Handles btnInicioPrueba.Click
        MDIContenedor.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmReporteMedico.ShowDialog()
    End Sub

    Private Sub btnModificaciones_Click(sender As Object, e As EventArgs) Handles btnModificaciones.Click
        frmModificaciones.ShowDialog()
    End Sub

    Private Sub btnReporteMedico_Click(sender As Object, e As EventArgs) Handles btnReporteMedico.Click
        dvxpReporteMedico.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dlgBuscaInforme.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmPruebas.ShowDialog()
    End Sub

    Private Sub btnRptModificado_Click(sender As Object, e As EventArgs) Handles btnRptModificado.Click
        frmReporteModificado.ShowDialog()
    End Sub

    Private Sub btnReporteDuplicado_Click(sender As Object, e As EventArgs) Handles btnReporteDuplicado.Click
        frmReporteDuplicado.ShowDialog()
    End Sub

    Private Sub btnReporteOri_Click(sender As Object, e As EventArgs) Handles btnReporteOri.Click
        ReporteFinal.ShowDialog()
    End Sub

    Private Sub btnLOG_Click(sender As Object, e As EventArgs) Handles btnLOG.Click
        LOG.ShowDialog()
    End Sub

    Private Sub btnSeguro_Click(sender As Object, e As EventArgs) Handles btnSeguro.Click
        frmSeguros.ShowDialog()
    End Sub
End Class