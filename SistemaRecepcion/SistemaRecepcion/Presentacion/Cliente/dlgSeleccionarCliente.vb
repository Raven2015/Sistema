﻿Public Class dlgSeleccionarCliente
    Private dt As New DataTable

    Private Sub dlgSeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'tbCodigoAsegurado.Text = ""
        tbDireccion.Text = ""
        tbEdad.Text = ""
        'tbInstitucion.Text = ""
        'tbNIT.Text = ""
        tbNombres.Text = ""
        'tbRazonSocial.Text = ""
        tbSexo.Text = ""
        tbTelefono.Text = ""
        tbFechaNacimiento.Text = DateTime.Today
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
        tbSexo.Text = dgvListado.SelectedCells.Item(9).Value
        tbFechaNacimiento.Text = dgvListado.SelectedCells.Item(5).Value
        'tbCodigoAsegurado.Text = dgvListado.SelectedCells.Item(10).Value
        'tbInstitucion.Text = dgvListado.SelectedCells.Item(11).Value
        'tbRazonSocial.Text = dgvListado.SelectedCells.Item(12).Value
        'tbNIT.Text = dgvListado.SelectedCells.Item(13).Value
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

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        frmAtencion.tbIDCliente.Text = tbIDCliente.Text
        frmAtencion.tbNombres.Text = tbNombres.Text
        frmAtencion.tbApellidos.Text = tbApellidos.Text
        frmAtencion.tbDireccion.Text = tbDireccion.Text
        frmAtencion.tbCelular.Text = tbCelular.Text
        frmAtencion.tbTelefono.Text = tbTelefono.Text
        frmAtencion.tbSexo.Text = tbSexo.Text
        frmAtencion.tbFechaNacimiento.Text = tbFechaNacimiento.Text
        frmAtencion.tbCI.Text = tbCI.Text
        frmAtencion.tbEdad.Text = tbEdad.Text
        Me.Close()
    End Sub
End Class