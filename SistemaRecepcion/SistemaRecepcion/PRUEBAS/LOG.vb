Public Class LOG
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        modLOG.LOG(tbLOG.Text)
    End Sub
End Class