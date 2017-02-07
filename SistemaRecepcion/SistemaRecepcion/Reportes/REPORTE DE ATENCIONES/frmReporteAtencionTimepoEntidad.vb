Public Class frmReporteAtencionTimepoEntidad
    Private Sub frmReporteAtencionTimepoEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.mostrar_atenciones_lapso_tiempo_entidad' table. You can move, or remove it, as needed.
        Me.mostrar_atenciones_lapso_tiempo_entidadTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_atenciones_lapso_tiempo_entidad, fecha_inicio:= tbFechaInicio.Text, fecha_fin:=tbFechaFin.Text, entidad:=tbEntidad.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class