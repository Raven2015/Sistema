Public Class frmAtencion

    Private dt As New DataTable

    '------------------ Método que carga el formulario principal ------------------
    Private Sub frmAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    '------------------ Botones del Menú ------------------
    '------------Atencion
    '----------------Nuevo
    '----------------Editar
    '----------------Eliminar
    '------------Seleccionar Paciente
    '------------Reportes
    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem2.Click
        dlgNuevaAtencion.ShowDialog()
    End Sub

    Private Sub mnSeleccionarPaciente_Click(sender As Object, e As EventArgs) Handles mnSeleccionarPaciente.Click
        limpiar()
        dlgSeleccionarCliente.ShowDialog()
    End Sub



    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Private Sub mostrar()
        Try
            Dim func As New fAtencion
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
        tbIDAtencion.Text = "" 'Borrar el textBox del ID Atencion para que no existan errores
        tbIDCliente.Text = ""
        tbNombres.Text = ""
        tbApellidos.Text = ""
        tbCI.Text = ""
        tbTelefono.Text = ""
        tbDireccion.Text = ""
        tbSexo.Text = ""
        tbEdad.Text = ""
        tbCelular.Text = ""
        tbFechaNacimiento.Text = ""
        tbMedicoRemitente.Text = ""
        dtpFechaAtencion.Text = Date.Now
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
            tbIDCliente.Text = dgvListado.SelectedCells.Item(2).Value
            tbIDAtencion.Text = dgvListado.SelectedCells.Item(1).Value
            tbNombres.Text = dgvListado.SelectedCells.Item(3).Value
            tbApellidos.Text = dgvListado.SelectedCells.Item(4).Value
            tbCI.Text = dgvListado.SelectedCells.Item(5).Value
            tbTelefono.Text = dgvListado.SelectedCells.Item(8).Value
            tbDireccion.Text = dgvListado.SelectedCells.Item(7).Value
            tbEdad.Text = Date.Now.Date.Year - Convert.ToDateTime(dgvListado.SelectedCells.Item(6).Value).Year
            tbSexo.Text = dgvListado.SelectedCells.Item(10).Value
            tbFechaNacimiento.Text = dgvListado.SelectedCells.Item(6).Value
            tbCelular.Text = dgvListado.SelectedCells.Item(9).Value
            tbMedicoRemitente.Text = dgvListado.SelectedCells.Item(15).Value
            dtpFechaAtencion.Text = dgvListado.SelectedCells.Item(18).Value

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

    Private Sub AñadirEstudiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEstudiosToolStripMenuItem.Click
        dlgSeleccionarEstudio.ShowDialog()
    End Sub

    Private Sub btnVerLista_Click(sender As Object, e As EventArgs) Handles btnVerLista.Click
        'dgvListado.Visible = True
        btnVerLista.Visible = False
        lblBuscar.Visible = True
        cbCampo.Visible = True
        tbBuscar.Visible = True
        chbxEliminar.Visible = True
        btnActualizar.Visible = True
        dgvListado.Visible = True
        btnOcultarLista.Visible = True
    End Sub

    Private Sub btnOcultarLista_Click(sender As Object, e As EventArgs) Handles btnOcultarLista.Click
        btnVerLista.Visible = True
        lblBuscar.Visible = False
        cbCampo.Visible = False
        tbBuscar.Visible = False
        chbxEliminar.Visible = False
        btnActualizar.Visible = False
        dgvListado.Visible = False
        btnOcultarLista.Visible = False
    End Sub
End Class