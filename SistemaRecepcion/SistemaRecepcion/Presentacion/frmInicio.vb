Public Class frmInicio
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnEstudio_Click(sender As Object, e As EventArgs) Handles btnEstudio.Click
        frmEstudio.ShowDialog()
    End Sub
End Class