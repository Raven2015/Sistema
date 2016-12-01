Public Class dlgSeleccionarCategoria

    Private dt As New DataTable

    '------------------ Método que carga el formulario principal ------------------
    Private Sub dlgSeleccionarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
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
        'tbIndicador.Text = ""
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
        Try
            tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
            tbNombres.Text = dgvListado.SelectedCells.Item(2).Value
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
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

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        If tbIndicador.Text = 0 Then
            dlgNuevoEstudio.tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
            dlgNuevoEstudio.tbCategoria.Text = dgvListado.SelectedCells.Item(2).Value
            dlgNuevoEstudio.tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
        Else
            dlgEditarEstudio.tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
            dlgEditarEstudio.tbCategoria.Text = dgvListado.SelectedCells.Item(2).Value
            dlgEditarEstudio.tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
        End If
        Me.Close()
    End Sub


End Class
