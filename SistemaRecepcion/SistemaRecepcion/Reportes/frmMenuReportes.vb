Public Class frmMenuReportes
    Private Sub btnListaAtencionesPorMedicos_Click(sender As Object, e As EventArgs) Handles btnListaAtencionesPorMedicos.Click
        frmReportedeAtencionesporMedicos.ShowDialog()
    End Sub

    Private Sub btnListaAtencionesPorInstitucion_Click(sender As Object, e As EventArgs) Handles btnListaAtencionesPorInstitucion.Click
        frmReporteAtencionesLapsoTiempo.ShowDialog()
    End Sub

    Private Sub btnListaestudiosPorInstitución_Click(sender As Object, e As EventArgs) Handles btnListaestudiosPorInstitución.Click
        frmEstudiosPorEntidad.ShowDialog()
    End Sub
End Class