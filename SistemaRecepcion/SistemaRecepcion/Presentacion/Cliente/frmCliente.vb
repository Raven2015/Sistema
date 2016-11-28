Public Class frmCliente

    Private dt As New DataTable

    '------------------ Botones del Menú ------------------
    '------------Nuevo
    '------------Editar
    '------------Eliminar
    '------------Reportes

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        dlgNuevoCliente.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
        dlgEditarCliente.tbIDCliente.Text = tbIDCliente.Text
        dlgEditarCliente.tbNombres.Text = tbNombres.Text
        dlgEditarCliente.tbApellidos.Text = tbApellidos.Text
        dlgEditarCliente.dtpFechaNacimiento.Text = dtpFechaNacimiento.Value
        dlgEditarCliente.tbDireccion.Text = tbDireccion.Text
        dlgEditarCliente.tbCodigoAsegurado.Text = tbCodigoAsegurado.Text
        dlgEditarCliente.tbInstitucion.Text = tbInstitucion.Text
        dlgEditarCliente.tbRazonSocial.Text = tbRazonSocial.Text
        dlgEditarCliente.tbNIT.Text = tbNIT.Text
        dlgEditarCliente.tbTelefono.Text = tbTelefono.Text
        dlgEditarCliente.tbCelular.Text = tbCelular.Text
        dlgEditarCliente.cbSexo.Text = cbSexo.Text
        dlgEditarCliente.tbCI.Text = tbCI.Text
        dlgEditarCliente.tbEdad.Text = DateTime.Now.Date.Year - Convert.ToDateTime(dgvListado.SelectedCells.Item(5).Value).Year

        dlgEditarCliente.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar los datos seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_cliente").Value)
                        Dim vdb As New vCliente
                        Dim func As New fcliente
                        vdb.gid_cliente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("No se pudo eliminar los datos seleccionados", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Eliminación cancelada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        'Call limpiar()
    End Sub



    '------------------ Método que carga el formulario principal ------------------
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar
            dgvListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                tbBuscar.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
                chbxEliminar.CheckState = CheckState.Unchecked
            Else
                dgvListado.DataSource = Nothing
                tbBuscar.Enabled = False
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbCampo.Text & " like '" & tbBuscar.Text & "%'"

            If dv.Count <> 0 Then
                lknInexistente.Visible = False
                dgvListado.DataSource = dv
                ocultar_columnas()
            Else
                lknInexistente.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgvListado.Columns(1).Visible = False
    End Sub

    Private Sub limpiar()
        tbIDCliente.Text = ""
        tbApellidos.Text = ""
        tbCelular.Text = ""
        tbCI.Text = ""
        tbCodigoAsegurado.Text = ""
        tbDireccion.Text = ""
        tbEdad.Text = ""
        tbInstitucion.Text = ""
        tbNIT.Text = ""
        tbNombres.Text = ""
        tbRazonSocial.Text = ""
        cbSexo.Text = ""
        tbTelefono.Text = ""
        dtpFechaNacimiento.Text = DateTime.Today
    End Sub

    '------------------ Funciones del Data Grid View ------------------
    '------------Caja de Texto buscar
    '------------Click en contenido del listado
    '------------Botón Actualizar
    '------------CheckBox Eliminar
    '------------Click en chkbox eliminar para seleccionar elementos


    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        'En caso de errror verificar el tipo de seleccion en el Data Grid Vuiew del modo Gráfico
        'Seleccionar: FullRowSelect
        'En Read Only: True

        tbIDCliente.Text = dgvListado.SelectedCells.Item(1).Value
        tbNombres.Text = dgvListado.SelectedCells.Item(2).Value
        tbApellidos.Text = dgvListado.SelectedCells.Item(3).Value
        tbDireccion.Text = dgvListado.SelectedCells.Item(6).Value
        tbCelular.Text = dgvListado.SelectedCells.Item(8).Value
        tbTelefono.Text = dgvListado.SelectedCells.Item(7).Value
        cbSexo.Text = dgvListado.SelectedCells.Item(9).Value
        dtpFechaNacimiento.Text = dgvListado.SelectedCells.Item(5).Value
        tbCodigoAsegurado.Text = dgvListado.SelectedCells.Item(10).Value
        tbInstitucion.Text = dgvListado.SelectedCells.Item(11).Value
        tbRazonSocial.Text = dgvListado.SelectedCells.Item(12).Value
        tbNIT.Text = dgvListado.SelectedCells.Item(13).Value
        tbCI.Text = dgvListado.SelectedCells.Item(4).Value
        tbEdad.Text = DateTime.Now.Date.Year - Convert.ToDateTime(dgvListado.SelectedCells.Item(5).Value).Year
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrar()
        limpiar()
    End Sub

    Private Sub chbxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEliminar.CheckedChanged
        If chbxEliminar.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Eliminar").Visible = True
        Else
            dgvListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If e.ColumnIndex = Me.dgvListado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        frmReportePacientes.ShowDialog()
    End Sub
End Class