Public Class frmPruebas

    Private dt As New DataTable

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim login As String
        Dim id As String
        Try
            login = tbLogin.Text
            id = tbIdAtencion.Text
            Dim dts As New vInformeMedico
            Dim funcD As New fInformeMedico

            tbResultado.Text = Format(funcD.verificacion_informe(login, id))
            If tbResultado.Text = 400 Then
                Debug.Write("Verificación OK :)")
            Else
                Debug.Write("Verificación INCORRECTA :/")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnObtener_Click(sender As Object, e As EventArgs) Handles btnObtener.Click

    End Sub

    Private Sub impresion(ByVal id_atencion, ByVal id_usuario)

    End Sub

    Private Sub btnMostrarImpresion_Click(sender As Object, e As EventArgs) Handles btnMostrarImpresion.Click
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fImpresion
            dt = func.mostrar_impresion(tbIDAt.Text, tbIDUser.Text)
            'dgvListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                'tbBuscar.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
            Else
                dgvListado.DataSource = Nothing
                'tbBuscar.Enabled = False
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '----INSERTAR IMPRESION PERMITE CREAR UN NUEVO ID DE IMPRESION ASIGNADO A LA ATENCION
    Public Sub insertar_impresion()
        Try
            Dim func As New fImpresion
            Dim resultado As Boolean
            resultado = func.insertar_impresion(tbIDAt.Text, tbIDUser.Text)
            'dgvListado.Columns.Item("Eliminar").Visible = False
            If resultado = True Then
                Debug.Print("Registro Insertado Correctamente")
            Else
                Debug.Print("No se pudo insertar el Registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImpresion_Click(sender As Object, e As EventArgs) Handles btnImpresion.Click
        insertar_impresion()
    End Sub

    Public Sub editar_impresion()
        Try
            Dim func As New fImpresion
            Dim resultado As Boolean
            resultado = func.editar_impresion(tbIDAt.Text, tbIDUser.Text)
            'dgvListado.Columns.Item("Eliminar").Visible = False
            If resultado = True Then
                Debug.Print("Registro Editado Correctamente")
            Else
                Debug.Print("No se pudo editar el Registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'Modifica el contador de impresion
        editar_impresion()
    End Sub
End Class