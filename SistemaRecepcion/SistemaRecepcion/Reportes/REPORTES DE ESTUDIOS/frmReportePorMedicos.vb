Public Class frmReportePorMedicos
    Private Sub frmReportePorMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.mostrar_medico' table. You can move, or remove it, as needed.
        Me.Mostrar_medicoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_medico)
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.estudios_por_entidad' table. You can move, or remove it, as needed.
        Try
            Me.lista_atenciones_por_medicoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.lista_atenciones_por_medico, medico_destinatario:=cbxMedico.Text, medico_remitente:=tbMedRem.Text, fecha_inicio:=dtpFechaInicio.Text, fecha_fin:=dtpFechaFin.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Debug.Write("Error" & ex.Message)
        End Try

    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Try
            Me.lista_atenciones_por_medicoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.lista_atenciones_por_medico, medico_destinatario:=cbxMedico.Text, medico_remitente:=tbMedRem.Text, fecha_inicio:=dtpFechaInicio.Text, fecha_fin:=dtpFechaFin.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Debug.Write("Error" & ex.Message)
        End Try
    End Sub
End Class