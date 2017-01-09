Public Class InicioPruebas
    Private Sub btnReporteCaja_Click(sender As Object, e As EventArgs) Handles btnReporteCaja.Click
        ReporteCajaFinal.ShowDialog()
    End Sub

    Private Sub btnReporteAtencion_Click(sender As Object, e As EventArgs) Handles btnReporteAtencion.Click
        ReporteFinal.ShowDialog()
    End Sub
End Class