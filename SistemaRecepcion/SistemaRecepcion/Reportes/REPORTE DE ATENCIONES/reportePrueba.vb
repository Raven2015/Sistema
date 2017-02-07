Public Class reportePrueba
    Private Sub reportePrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.reporte_etenciones_tiempo' table. You can move, or remove it, as needed.
        Me.reporte_etenciones_tiempoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.reporte_etenciones_tiempo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class