Public Class frmConfiguracion
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardarConfiguracion_Click(sender As Object, e As EventArgs) Handles btnGuardarConfiguracion.Click
        My.Settings.NombreSucursal = tbNombreSucursal.Text
    End Sub
End Class