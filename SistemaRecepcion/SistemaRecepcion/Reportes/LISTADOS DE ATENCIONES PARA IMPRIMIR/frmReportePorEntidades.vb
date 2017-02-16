Public Class frmReportePorEntidades
    Private Sub frmReportePorEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.mostrar_atenciones_lapso_tiempo_entidad' table. You can move, or remove it, as needed.
        Try
            Me.mostrar_atenciones_lapso_tiempo_entidadTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_atenciones_lapso_tiempo_entidad, fecha_inicio:=dtpFechaInicio.Text, fecha_fin:=dtpFechaFin.Text, entidad:=cbxEntidad.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Debug.Write("Error" & ex.Message)
        End Try

    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Try
            Me.mostrar_atenciones_lapso_tiempo_entidadTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_atenciones_lapso_tiempo_entidad, fecha_inicio:=dtpFechaInicio.Text, fecha_fin:=dtpFechaFin.Text, entidad:=cbxEntidad.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Debug.Write("Error" & ex.Message)
        End Try
    End Sub
End Class