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


    Private Sub limpiar_atencion()
        tbIDAtencion.Text = "" 'Borrar el textBox del ID Atencion para que no existan errores
        tbMedicoRemitente.Text = ""
        dtpFechaAtencion.Text = Date.Now
    End Sub

    Public Sub insertarAtencion()
        Try
            Dim dts As New vAtencion
            Dim func As New fAtencion

            dts.gid_atencion = Convert.ToInt16(tbIDAtencion.Text)
            dts.gdoctor_remitente = tbMedicoRemitente.Text
            dts.gfecha = dtpFechaAtencion.Text
            dts.gprecio_parcial = tbPrecio.Text
            dts.gid_cliente = tbIDCliente.Text


            'If func.insertar(dts) Then
            '    MessageBox.Show("Atencion registrada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.Close()
            'Else
            '    MessageBox.Show("la Atencion no pudo ser registrada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

            func.insertar(dts)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub generar_atencion()
        Try
            Dim dts As New vAtencion
            Dim funcA As New fAtencion
            tbIDAtencion.Text = Format(funcA.generar_atencion, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AñadirEstudiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEstudiosToolStripMenuItem.Click
        Try
            insertarAtencion()
        Catch ex As Exception
            MsgBox("No se puede crear la atencion: ", ex.Message)
        End Try
    End Sub
End Class