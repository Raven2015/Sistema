Public Class dlgSeleccionarEstudio

    Private dt As New DataTable
    Private Sub dlgSeleccionarEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar() 'Asegura que cualquier dato que quedo en los text box sea eliminado para que no exista confusion
        mostrar()
    End Sub

    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Private Sub mostrar()
        Try
            Dim func As New fEstudio
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
        dgvListado.Columns(2).Visible = False
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
        tbDescuento.Text = "0"
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
        Try
            tbIDEstudio.Text = dgvListado.SelectedCells.Item(1).Value
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
            tbCategoria.Text = dgvListado.SelectedCells.Item(4).Value
            tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(6).Value
            tbNombres.Text = dgvListado.SelectedCells.Item(5).Value
            tbPrecio.Text = dgvListado.SelectedCells.Item(7).Value
            tbDescuento.Text = dgvListado.SelectedCells.Item(8).Value
            tbIDCategoria.Text = dgvListado.SelectedCells.Item(2).Value
        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrar()
        limpiar()
    End Sub


    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If e.ColumnIndex = Me.dgvListado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        Dim indicador As Integer
        indicador = tbIndicador.Text
        Try
            Select Case indicador
                Case 0
                    tbIDEstudio.Text = dgvListado.SelectedCells.Item(1).Value
                    tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
                    tbCategoria.Text = dgvListado.SelectedCells.Item(4).Value
                    tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(6).Value
                    tbNombres.Text = dgvListado.SelectedCells.Item(5).Value
                    tbPrecio.Text = dgvListado.SelectedCells.Item(7).Value
                    tbDescuento.Text = dgvListado.SelectedCells.Item(8).Value
                    tbIDCategoria.Text = dgvListado.SelectedCells.Item(2).Value
                Case 1
                    MsgBox("Aun no se ha definido un caso para este valor")
            End Select

        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try
    End Sub
End Class