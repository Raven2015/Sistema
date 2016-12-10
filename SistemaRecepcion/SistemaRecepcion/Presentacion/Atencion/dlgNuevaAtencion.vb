Public Class dlgNuevaAtencion
    Private Sub dlgNuevaAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Try
            Dim dts As New vAtencion
            Dim func As New fAtencion
            tbIDAtencion.Text = Format(func.generar_atencion, "0000")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-------------- Metodos Internos --------------
    '-Limpiar
    Public Sub limpiar()
        'Limpia lo svalores de las cajas de texto.
        tbMedicoRemitente.Text = ""
        dtpFechaAtencion.Text = DateTime.Today
    End Sub

End Class