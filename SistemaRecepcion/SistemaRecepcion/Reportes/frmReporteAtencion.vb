Public Class frmReporteAtencion
    Private Sub frmReporteAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbBIOMEDICADataSet.reporte_atencion' table. You can move, or remove it, as needed.
        Me.reporte_atencionTableAdapter.Fill(Me.dbBIOMEDICADataSet.reporte_atencion)
        'TODO: This line of code loads data into the 'dbBIOMEDICADataSet.comprobante_atencion' table. You can move, or remove it, as needed.
        'Me.comprobante_atencionTableAdapter.Fill(Me.dbBIOMEDICADataSet.comprobante_atencion, tbIDAtencion.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class