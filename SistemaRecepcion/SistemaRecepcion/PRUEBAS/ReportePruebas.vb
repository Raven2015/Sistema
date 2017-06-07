Public Class ReportePruebas
    Private Sub ReportePruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsInicial.mostrar_detalles' table. You can move, or remove it, as needed.
        'Me.mostrar_detallesTableAdapter.Fill(Me.dsInicial.mostrar_detalles, fecha_inicio:=tbFechaInicio.Text, fecha_fin:=tbFechaFin.Text, entidad:=tbEntidad.Text)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class