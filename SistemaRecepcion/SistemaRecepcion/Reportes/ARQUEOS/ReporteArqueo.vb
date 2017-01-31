Public Class ReporteArqueo

    Private Sub ReporteArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria' table. You can move, or remove it, as needed.
        'tbFecha.Text = Date.Now
        Me.ingresos_diarios_por_categoriaTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria, entidad:=tbEntidad.Text, fecha_atencion:=tbFecha.Text)

        Me.rpvwArqueos.RefreshReport()
    End Sub

    Public Sub recargar()
        'Me.mostrar_detallesTableAdapter.Fill(Me.dsInicial.mostrar_detalles, id_atencion:=tbIDAtencion.Text)
        Me.ingresos_diarios_por_categoriaTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria, entidad:=tbEntidad.Text, fecha_atencion:=tbFecha.Text)
        Me.rpvwArqueos.RefreshReport()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        recargar()
    End Sub

End Class