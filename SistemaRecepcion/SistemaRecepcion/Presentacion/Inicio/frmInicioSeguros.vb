Public Class frmInicioSeguros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        frmSeguros.tbIdUsuario.Text = lbIDUsuario.Text
        frmSeguros.ShowDialog()
    End Sub
End Class