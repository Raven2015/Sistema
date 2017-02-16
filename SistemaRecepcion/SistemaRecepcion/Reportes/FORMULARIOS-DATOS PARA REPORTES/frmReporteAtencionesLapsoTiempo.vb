Public Class frmReporteAtencionesLapsoTiempo
    Dim dt As New DataTable
    Private Sub frmReporteAtencionesLapsoTiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)
        limpiar()
        llenar()
    End Sub

    Private Sub llenar()
        Try
            Dim funcLista As New fReporteAtencion
            Dim fecha_inicio As Date
            Dim fecha_fin As Date
            Dim entidad As String

            fecha_inicio = dtpFechaInicio.Text
            fecha_fin = dtpFechaFin.Text
            entidad = cbxEntidad.Text

            dt = funcLista.mostrar_por_entidad(fecha_inicio, fecha_fin, entidad)

            If dt.Rows.Count <> 0 Then
                dgvListadoAtenciones.DataSource = dt
                lknInexistente.Visible = False

            Else
                dgvListadoAtenciones.DataSource = Nothing
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        cbxEntidad.SelectedIndex = 0 'Selecciona automaticamente el elemento PARTICULAR de la lista
    End Sub

    Private Sub cbxEntidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEntidad.SelectedIndexChanged
        llenar()
    End Sub

    Private Sub btnImprimirReporte_Click(sender As Object, e As EventArgs) Handles btnImprimirReporte.Click
        frmReporteAtencionTimepoEntidad.tbFechaInicio.Text = dtpFechaInicio.Text
        Debug.Write("El valor de fecha inicio: " & dtpFechaInicio.Text)
        frmReporteAtencionTimepoEntidad.tbFechaFin.Text = dtpFechaFin.Text
        Debug.Write("El valor de fecha fin: " & dtpFechaFin.Text)
        frmReporteAtencionTimepoEntidad.tbEntidad.Text = cbxEntidad.Text
        Debug.Write("El valor de Entidad: " & cbxEntidad.Text)
        'frmReporteAtencionTimepoEntidad.ShowDialog()
    End Sub
End Class