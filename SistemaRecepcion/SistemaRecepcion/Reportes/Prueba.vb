Public Class Prueba
    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsInicial.mostrar_detalles' table. You can move, or remove it, as needed.
        Me.mostrar_detallesTableAdapter.Fill(Me.dsInicial.mostrar_detalles, id_atencion:=tbIDAtencion.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub recargar()
        Me.mostrar_detallesTableAdapter.Fill(Me.dsInicial.mostrar_detalles, id_atencion:=tbIDAtencion.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        recargar()
    End Sub
End Class