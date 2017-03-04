Public Class frmReportedeAtencionesporMedicos
    Dim dt As New DataTable
    Private Sub frmReportedeAtencionesporMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.mostrar_medico' table. You can move, or remove it, as needed.
        Me.Mostrar_medicoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_medico)

        limpiar()
        llenar()
    End Sub

    Private Sub llenar()
        Try
            Dim funcLista As New fReporteAtencion
            Dim fecha_inicio As Date
            Dim fecha_fin As Date
            Dim medico_destinatario As String
            Dim medico_remitente As String

            fecha_inicio = dtpFechaInicio.Text
            fecha_fin = dtpFechaFin.Text
            medico_destinatario = cbxMedico.Text

            dt = funcLista.mostrar_por_medico_destinatario(fecha_inicio, fecha_fin, medico_destinatario, "ninguno")

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

    Private Sub llenarTODO()
        Try
            Dim funcLista As New fReporteAtencion
            Dim fecha_inicio As Date
            Dim fecha_fin As Date
            Dim medico_destinatario As String
            Dim medico_remitente As String

            fecha_inicio = dtpFechaInicio.Text
            fecha_fin = dtpFechaFin.Text
            medico_destinatario = "%"

            dt = funcLista.mostrar_por_medico_destinatario(fecha_inicio, fecha_fin, medico_destinatario, "ninguno")

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
        cbxMedico.SelectedIndex = 0 'Selecciona automaticamente el elemento PARTICULAR de la lista
    End Sub

    Private Sub cbxMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMedico.SelectedIndexChanged
        llenar()
    End Sub

    Private Sub IMPRIMIRREPORTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPRIMIRREPORTEToolStripMenuItem.Click
        Try
            frmReportePorMedicos.dtpFechaInicio.Text = dtpFechaInicio.Text
            Debug.Write("El valor de fecha inicio: " & dtpFechaInicio.Text)
            frmReportePorMedicos.dtpFechaFin.Text = dtpFechaFin.Text
            Debug.Write("El valor de fecha fin: " & dtpFechaFin.Text)
            'frmReportePorMedicos.cbxMedico.SelectedIndex = cbxMedico.SelectedIndex
            Debug.Write("El valor de Medico_destinatario: " & cbxMedico.Text)
            frmReportePorMedicos.ShowDialog()
        Catch ex As Exception
            Debug.Write("OCURRIO UN ERROR: " + ex.Message)
        End Try
    End Sub

    Private Sub EXPORTARAEXCELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPORTARAEXCELToolStripMenuItem.Click
        Dim objexcel As New ExportarExcel
        Try
            objexcel.exportarInforme(dt)
        Catch ex As Exception
            Debug.Write("OCURRIO UN ERROR: " + ex.Message)
        End Try
    End Sub

    Private Sub TODOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSToolStripMenuItem.Click

    End Sub

    Private Sub VERTODOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERTODOToolStripMenuItem.Click
        llenarTODO()
    End Sub
End Class