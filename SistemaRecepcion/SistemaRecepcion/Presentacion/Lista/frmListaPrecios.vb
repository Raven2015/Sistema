Public Class frmListaPrecios

    Private dt As New DataTable
    Private Sub frmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Private Sub mostrar()
        Try
            Dim func As New fEntidad
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
        cbCampo.SelectedIndex = "0"
        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampo.Text & " like '%" & tbBuscar.Text & "%'"

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
        dgvListado.Columns(2).Visible = False
        dgvListado.Columns(3).Visible = False
    End Sub
    Private Sub ocultar_filas()
        Dim nfilas As Integer
        nfilas = dgvListado.Rows.Count

    End Sub

    Private Sub limpiar()
        tbCodigoCategoria.Text = ""
        tbCategoria.Text = ""
        tbCodigoEstudio.Text = ""
        tbNombres.Text = ""
        tbPrecio.Text = "0"
        tbCliente.Text = ""
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
        'En caso de errror verificar el tipo de seleccion en el Data Grid View del modo Gráfico
        'Seleccionar: FullRowSelect
        'En Read Only: True
        'Para corregir el problema de click en la última fila:
        limpiar()
        Try
            tbIDEntidad.Text = dgvListado.SelectedCells.Item(1).Value 'ID de Entidad
            tbIDEstudio.Text = dgvListado.SelectedCells.Item(2).Value 'ID de Estudio
            tbIDPrecio.Text = dgvListado.SelectedCells.Item(3).Value 'ID de Precio
            tbCliente.Text = dgvListado.SelectedCells.Item(6).Value 'Entidad
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(7).Value 'CODIGO de categoria
            tbCategoria.Text = dgvListado.SelectedCells.Item(8).Value 'Categoria
            tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(9).Value 'Cod. de Estudio
            tbNombres.Text = dgvListado.SelectedCells.Item(4).Value ' Estudio
            tbPrecio.Text = dgvListado.SelectedCells.Item(5).Value 'Precio
        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try


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

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        frmEditarEntidad.tbIDEntidad.Text = dgvListado.SelectedCells.Item(1).Value 'ID de Entidad
        frmEditarEntidad.tbIDEstudio.Text = dgvListado.SelectedCells.Item(2).Value 'ID de Estudio
        frmEditarEntidad.tbIDPrecio.Text = dgvListado.SelectedCells.Item(3).Value 'ID de Precio
        frmEditarEntidad.tbEntidad.Text = dgvListado.SelectedCells.Item(6).Value 'Entidad
        frmEditarEntidad.tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(7).Value 'CODIGO de categoria
        frmEditarEntidad.tbCategoria.Text = dgvListado.SelectedCells.Item(8).Value 'Categoria
        frmEditarEntidad.tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(9).Value 'Cod. de Estudio
        frmEditarEntidad.tbNombres.Text = dgvListado.SelectedCells.Item(4).Value ' Estudio
        frmEditarEntidad.tbPrecio.Text = dgvListado.SelectedCells.Item(5).Value 'Precio
        frmEditarEntidad.ShowDialog()
    End Sub
End Class