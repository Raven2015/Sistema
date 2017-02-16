Public Class frmEstudiosPorEntidad
    Private Sub frmEstudiosPorEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.estudios_por_entidad' table. You can move, or remove it, as needed.
        Me.estudios_por_entidadTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.estudios_por_entidad, entidad:=cbxEntidad.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Me.estudios_por_entidadTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.estudios_por_entidad, entidad:=cbxEntidad.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class