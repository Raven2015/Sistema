Public Class frmEditarEntidad
    Private Sub frmEditarEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub editar()
        If Me.ValidateChildren = True And tbNombres.Text <> "" And tbCodigoCategoria.Text <> "" Then
            Try
                Dim dts As New vPrecio
                Dim func As New fprecio

                dts.gid_precio = tbIDPrecio.Text
                dts.gprecio = tbPrecio.Text

                If func.editar(dts) Then
                    MessageBox.Show("Datos modificados correctamente", "Editando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("El precio no pudo ser modificado. Intente de nuevo por favor", "Editando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub limpiar()
        tbIDEntidad.Text = ""
        tbIDEstudio.Text = ""
        tbIDPrecio.Text = ""
        tbCategoria.Text = ""
        tbCodigoCategoria.Text = ""
        tbCodigoEstudio.Text = ""
        tbNombres.Text = ""
        tbEntidad.Text = ""
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        editar()
    End Sub
End Class