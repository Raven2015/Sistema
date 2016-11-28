Public Class frmCategoria
    Private dt As New DataTable

    '------------------ Botones del Menú ------------------
    '------------Nuevo
    '------------Editar
    '------------Eliminar
    '------------Reportes


    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        dlgNuevaCategoria.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        dlgEditarCategoria.tbNombres.Text = tbNombres.Text
        dlgEditarCategoria.tbCodigoCategoria.Text = tbCodigoCategoria.Text
        dlgEditarCategoria.tbIDCategoria.Text = tbIDCategoria.Text
        dlgEditarCategoria.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar los datos seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_categoria").Value)
                        Dim vdb As New vCategoria
                        Dim func As New fCategoria
                        vdb.gid_categoria = onekey

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

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        frmReporteCategorias.ShowDialog()
    End Sub

    '------------------ Método que carga el formulario principal ------------------
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Private Sub mostrar()
        Try
            Dim func As New fCategoria
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
        tbCodigoCategoria.Text = ""
        tbNombres.Text = ""
        tbIDCategoria.Text = ""
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
        tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
        tbNombres.Text = dgvListado.SelectedCells.Item(2).Value
        tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrar()
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


End Class