Public Class frmModificaciones

    Private dt As New DataTable
    Private Sub brbtnDatosAtencion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnDatosAtencion.ItemClick
        flpnDatosAtencion.ShowPopup()
    End Sub

    Private Sub brbtnEditarCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnEditarCliente.ItemClick
        flpnDatosCliente.ShowPopup()
    End Sub
    Private Sub brbtnPreciosEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnPreciosEstudios.ItemClick
        flpnPreciosEstudios.ShowPopup()
    End Sub

    Private Sub mostrar_atenciones_por_numero(ByVal id_atencion As Integer)
        Try
            Dim func As New fAtencion
            dt = func.mostrar_por_numero(id_atencion)

            If dt.Rows.Count <> 0 Then
                dgvResultados.Visible = True
                dgvResultados.DataSource = dt
                dgvResultados.ColumnHeadersVisible = True
                lbInexistente.Visible = False
            Else
                dgvResultados.Visible = False
                dgvResultados.DataSource = Nothing
                dgvResultados.ColumnHeadersVisible = False
                lbInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbIdAtencion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIDAtencion.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbIdAtencion_TextChanged(sender As Object, e As EventArgs) Handles tbIDAtencion.TextChanged
        control()
        mostrar_atenciones_por_numero(Integer.Parse(tbIDAtencion.Text))
    End Sub

    Private Sub control()
        If tbIDAtencion.Text = "" Then
            tbIDAtencion.Text = 0
        End If
    End Sub

    Private Sub limpiar()
        dtpFechaAtencion.Text = Date.Now
        tbPrecio.Text = "0"
        'cbxMDestinatario.SelectedItem = 0
        tbMedicoRemitente.Text = ""
    End Sub
    Private Sub llenar()
        'limpiar()
        'Debug.Write("Valor de Celda 4>> " & dgvResultados.SelectedCells.Item(4).Value)
        'Debug.Write("Valor de Celda 3>> " & dgvResultados.SelectedCells.Item(3).Value)
        'Debug.Write("Valor de Celda 5>> " & dgvResultados.SelectedCells.Item(5).Value)
        'Debug.Write("Valor de Celda 6>> " & dgvResultados.SelectedCells.Item(6).Value)
        dtpFechaAtencion.Text = dgvResultados.SelectedCells.Item(4).Value
        tbMedicoRemitente.Text = dgvResultados.SelectedCells.Item(3).Value
        tbPrecio.Text = dgvResultados.SelectedCells.Item(5).Value
        cbxMDestinatario.SelectedIndex = dgvResultados.SelectedCells.Item(6).Value
    End Sub

    Private Sub dgvResultados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResultados.CellMouseDoubleClick
        dgvResultados.Visible = False
        limpiar()
        llenar()
    End Sub

    Private Sub frmModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)

        'TODO: This line of code loads data into the 'DataSetOperacionesAuxiliares.mostrar_medico' table. You can move, or remove it, as needed.
        Me.Mostrar_medicoTableAdapter.Fill(Me.DataSetOperacionesAuxiliares.mostrar_medico)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If tbIDAtencion.Text <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Desea editar los datos de la atención?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim dts As New vAtencion
                    Dim func As New fAtencion

                    dts.gid_atencion = tbIDAtencion.Text
                    dts.gfecha = dtpFechaAtencion.Text
                    dts.gdoctor_remitente = tbMedicoRemitente.Text
                    dts.gid_medico = cbxMDestinatario.SelectedIndex
                    dts.gprecio_parcial = tbPrecio.Text

                    If func.editar_TODO(dts) Then
                        'MessageBox.Show("Atencion editada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Debug.Write("Atencion actualizada :)")
                        MsgBox("DATOS ACTUALIZADOS CORRECTAMENTE")
                    Else
                        MessageBox.Show("la Atencion no pudo ser editada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Por favor seleecione una atención primero.", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tbIDAtencion.Text <> 0 Then

            Dim result As DialogResult
            result = MessageBox.Show("Desea ELIMINAR los datos de la atención?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim dts As New vAtencion
                    Dim func As New fAtencion

                    dts.gid_atencion = tbIDAtencion.Text

                    If func.eliminar(dts) Then
                        'MessageBox.Show("Atencion editada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Debug.Write("Atencion Eliminada :)")
                        MsgBox("ATENCIÓN ELIMINADA CORRECTAMENTE")
                    Else
                        MessageBox.Show("La Atencion no pudo ser eliminada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Por favor seleecione una atención primero.", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    '---------------------------------------------------------------'---------------------------------------------------------------
    '---------------------------------------------------------------'---------------------------------------------------------------
    '-----------------------------------------------------PANEL EDITAR CLIENTE------------------------------------------------------

    Private Sub mostrar_cliente_por_atencion(ByVal id_atencion As Integer)
        Try
            Dim func As New fcliente
            dt = func.mostrar_clientes_por_id_atencion(id_atencion)

            If dt.Rows.Count <> 0 Then
                dgvResultadoclientes.Visible = True
                dgvResultadoclientes.DataSource = dt
                dgvResultadoclientes.ColumnHeadersVisible = True
                lbDatosInexistentesCliente.Visible = False
            Else
                dgvResultadoclientes.Visible = False
                dgvResultadoclientes.DataSource = Nothing
                dgvResultadoclientes.ColumnHeadersVisible = False
                lbDatosInexistentesCliente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub control_clientes()
        If tbIDAtencionCliente.Text = "" Then
            tbIDAtencionCliente.Text = 0
        End If
    End Sub

    Private Sub limpiar_clientes()
        tbApellidosCliente.Text = ""
        tbNombresCliente.Text = ""
        tbCICliente.Text = ""
        dtpNacimientoCliente.Text = Date.Now
        cbxSexoCliente.SelectedIndex = 0
        tbCelularCliente.Text = ""
        tbCodigoCliente.Text = ""
        tbIDClienteEditar.Text = "0"
        tbEdadCliente.Text = modOperacionesAuxiliares.TuEdad(dtpNacimientoCliente.Text, Date.Now)
        tbRazonSocialCliente.Text = ""
        tbNitCliente.Text = ""

    End Sub
    Private Sub llenar_clientes()
        'limpiar()
        'Debug.Write("Valor de Celda 4>> " & dgvResultados.SelectedCells.Item(4).Value)
        'Debug.Write("Valor de Celda 3>> " & dgvResultados.SelectedCells.Item(3).Value)
        'Debug.Write("Valor de Celda 5>> " & dgvResultados.SelectedCells.Item(5).Value)
        'Debug.Write("Valor de Celda 6>> " & dgvResultados.SelectedCells.Item(6).Value)
        tbApellidosCliente.Text = dgvResultadoclientes.SelectedCells.Item(0).Value
        tbNombresCliente.Text = dgvResultadoclientes.SelectedCells.Item(1).Value
        tbCICliente.Text = dgvResultadoclientes.SelectedCells.Item(2).Value
        dtpNacimientoCliente.Text = dgvResultadoclientes.SelectedCells.Item(3).Value
        cbxSexoCliente.Text = dgvResultadoclientes.SelectedCells.Item(4).Value
        tbCelularCliente.Text = dgvResultadoclientes.SelectedCells.Item(5).Value
        tbCodigoCliente.Text = dgvResultadoclientes.SelectedCells.Item(6).Value
        tbRazonSocialCliente.Text = dgvResultadoclientes.SelectedCells.Item(7).Value
        tbNitCliente.Text = dgvResultadoclientes.SelectedCells.Item(8).Value
        tbIDClienteEditar.Text = dgvResultadoclientes.SelectedCells.Item(10).Value
        tbEdadCliente.Text = dgvResultadoclientes.SelectedCells.Item(11).Value
    End Sub

    Private Sub dgvResultadoclientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResultadoclientes.CellMouseDoubleClick
        dgvResultadoclientes.Visible = False
        limpiar_clientes()
        llenar_clientes()
    End Sub

    Private Sub tbIDAtencionCliente_TextChanged(sender As Object, e As EventArgs) Handles tbIDAtencionCliente.TextChanged
        control_clientes()
        mostrar_cliente_por_atencion(tbIDAtencionCliente.Text)
    End Sub

    Private Sub tbIDAtencionCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIDAtencionCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        tbIDAtencionCliente.Text = 0
        limpiar_clientes()
        flpnDatosCliente.HidePopup()
    End Sub

    Private Sub btnModificarClietne_Click(sender As Object, e As EventArgs) Handles btnModificarClietne.Click

        If tbIDAtencionCliente.Text <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Desea editar los datos del Cliente?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim dts As New vCliente
                    Dim func As New fcliente

                    dts.gid_cliente = tbIDClienteEditar.Text
                    dts.gnombres = tbNombresCliente.Text
                    dts.gapellidos = tbApellidosCliente.Text
                    dts.gci = tbCICliente.Text
                    dts.gfecha_nacimiento = dtpNacimientoCliente.Text
                    dts.gcelular = tbCelularCliente.Text
                    dts.gsexo = cbxSexoCliente.Text
                    dts.gcodigo_asegurado = tbCodigoCliente.Text
                    dts.grazon_social = tbRazonSocialCliente.Text
                    dts.gnit = tbNitCliente.Text
                    dts.gedad = tbEdadCliente.Text

                    If func.editar(dts) Then
                        'MessageBox.Show("Atencion editada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Debug.Write("Cliente Modificado:)")
                        MsgBox("DATOS ACTUALIZADOS CORRECTAMENTE")
                    Else
                        MessageBox.Show("Los datos no pudieron ser editados. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Por favor seleecione una atención primero.", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dtpNacimientoCliente_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimientoCliente.ValueChanged
        tbEdadCliente.Text = modOperacionesAuxiliares.TuEdad(dtpNacimientoCliente.Text, Date.Now)
    End Sub
End Class