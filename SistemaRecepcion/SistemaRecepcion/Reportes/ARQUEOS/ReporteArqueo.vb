Public Class ReporteArqueo

    Private Sub ReporteArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria' table. You can move, or remove it, as needed.
        'tbFecha.Text = Date.Now
        Try
            Me.ingresos_diarios_por_categoriaTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria, entidad:=tbEntidad.Text, fecha_atencion:=tbFecha.Text, turno:=tbTurno.Text)

            Me.rpvwArqueos.RefreshReport()
        Catch ex As Exception
            Debug.Write("OCURRIO UN ERROR: " + ex.Message)
        End Try
    End Sub

    Public Sub recargar()
        'Me.mostrar_detallesTableAdapter.Fill(Me.dsInicial.mostrar_detalles, id_atencion:=tbIDAtencion.Text)
        Try
            Me.ingresos_diarios_por_categoriaTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.ingresos_diarios_por_categoria, entidad:=tbEntidad.Text, fecha_atencion:=tbFecha.Text, turno:=tbTurno.Text)
            Me.rpvwArqueos.RefreshReport()
        Catch ex As Exception
            Debug.Write("OCURRIO UN ERROR: " + ex.Message)
        End Try
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        recargar()
    End Sub

End Class