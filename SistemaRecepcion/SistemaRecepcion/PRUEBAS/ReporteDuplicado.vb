Public Class frmReporteDuplicado
    Private Sub frmReporteDuplicado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbReportes.reporte_modificado' table. You can move, or remove it, as needed.
        Me.reporte_modificadoTableAdapter.Fill(Me.dbReportes.reporte_modificado, id_atencion:=tbID.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub recargar()
        Me.reporte_modificadoTableAdapter.Fill(Me.dbReportes.reporte_modificado, id_atencion:=tbID.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        recargar()
    End Sub
End Class