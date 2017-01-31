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
        frmInicio.ShowDialog()
    End Sub
End Class