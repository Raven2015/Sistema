Public Class frmInicioMedico
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Me.WindowState = FormWindowState.Minimized
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnEstudio_Click(sender As Object, e As EventArgs) Handles btnEstudio.Click
        Me.WindowState = FormWindowState.Minimized
        frmEstudio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmCategoria.ShowDialog()
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs)
        frmListaPrecios.ShowDialog()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click
        Me.WindowState = FormWindowState.Minimized
        dvxpReporteMedico.ShowDialog()
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ingreso.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Ingreso.Visible() = True
        Me.Close()
    End Sub
End Class