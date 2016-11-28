Public Class dlgEditarCategoria
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la CATEGORIA?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And tbNombres.Text <> "" And tbCodigoCategoria.Text <> "" Then
                Try
                    Dim dts As New vCategoria
                    Dim func As New fCategoria

                    dts.gid_categoria = tbIDCategoria.Text
                    dts.gnombre_categoria = tbNombres.Text
                    dts.gcodigo_categoria = tbCodigoCategoria.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Datos modificados correctamente", "Editando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("La Categoria no pudo ser modificada. Intente de nuevo por favor", "Editando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dlgEditarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class