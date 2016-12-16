Imports System.Data.SqlClient
Public Class frmEstudio

    Private dt As New DataTable

    '------------------ Botones del Menú ------------------
    '------------Nuevo
    '------------Editar
    '------------Eliminar
    '------------Reportes

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        dlgNuevoEstudio.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
        dlgEditarEstudio.tbCodigoCategoria.Text = tbCodigoCategoria.Text
        dlgEditarEstudio.tbCategoria.Text = tbCategoria.Text
        dlgEditarEstudio.tbCodigoEstudio.Text = tbCodigoEstudio.Text
        dlgEditarEstudio.tbNombres.Text = tbNombres.Text
        dlgEditarEstudio.tbIDEstudio.Text = tbIDEstudio.Text
        dlgEditarEstudio.tbIDCategoria.Text = tbIDCategoria.Text

        dlgEditarEstudio.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar los datos seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_estudio").Value)
                        Dim vdb As New vEstudio
                        Dim func As New fEstudio
                        vdb.gid_estudio = onekey

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
        'frmReporteEstudios.ShowDialog()
    End Sub



    '------------------ Método que carga el formulario principal ------------------
    Private Sub frmEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cbCampo.SelectedIndex = 2 'SELECCIONA EL ITEM 3 DEL COMBO BOX
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
            tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
            tbIDEstudio.Text = dgvListado.SelectedCells.Item(2).Value
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(3).Value
            tbCategoria.Text = dgvListado.SelectedCells.Item(4).Value
            tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(5).Value
            tbNombres.Text = dgvListado.SelectedCells.Item(6).Value

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

End Class