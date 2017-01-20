Public Class frmCotizacion
    Private dt As New DataTable
    Private Sub Cotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)
        limpiar()
        mostrar()
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fEntidad
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                cbxInstitucion.Enabled = True
                tbEstudio.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
            Else
                dgvListado.DataSource = Nothing
                cbxInstitucion.Enabled = False
                tbEstudio.Enabled = False
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox("La tabla aun esta vacia: " & ex.Message)
        End Try
        buscar()
    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "entidad" & " like '" & cbxInstitucion.Text & "%' and " & "estudio" & " like '%" & tbEstudio.Text & "%'"
            'dv.RowFilter = cbCampo.Text & " like '" & tbBuscar.Text & "%'"

            If dv.Count <> 0 Then
                lknInexistente.Visible = False
                dgvListado.DataSource = dv
                ocultar_columnas()
                AnchoColumnas()
            Else
                lknInexistente.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            'MsgBox("La tabla aun esta vacia: " & ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(1).Visible = False
        dgvListado.Columns(2).Visible = False
        dgvListado.Columns(6).Visible = False
        dgvListado.Columns(7).Visible = True
        dgvListado.Columns(8).Visible = False
    End Sub

    Public Sub AnchoColumnas()
        dgvListado.Columns(3).Width = 350
        dgvListado.Columns(4).Width = 50
        dgvListado.Columns(5).Width = 100
        dgvListado.Columns(7).Width = 190
    End Sub

    Public Sub limpiar()
        tbEstudio.Text = ""
        cbxInstitucion.SelectedIndex = 0
        tbPrecio.Text = ""
    End Sub

    Private Sub tbEstudio_TextChanged(sender As Object, e As EventArgs) Handles tbEstudio.TextChanged
        buscar()
    End Sub

    Private Sub cbxInstitucion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxInstitucion.SelectedIndexChanged
        buscar()
    End Sub



    Private Sub dgvListadoAtenciones_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoAtenciones.CellMouseDoubleClick
        For Each seleccion As DataGridViewRow In dgvListadoAtenciones.SelectedRows
            Me.dgvListadoAtenciones.Rows.RemoveAt(dgvListadoAtenciones.CurrentRow.Index)
            tbPrecio.Text = precio_parcial()
        Next
    End Sub

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        Dim valores As New DataGridViewRow

        'Dimensionar el array al tamaño de columnas del DGV

        'Rellenar el contenido con el valor de las celdas de la fila

        For Each seleccion As DataGridViewRow In dgvListado.SelectedRows
            Me.dgvListadoAtenciones.Rows.Add(obtener_valoresBETA(seleccion))
            Debug.Write("Detalle de estudio Añadido correctamente  :)")
        Next
        tbPrecio.Text = precio_parcial()
    End Sub


    Protected Function obtener_valoresBETA(ByVal fila As DataGridViewRow) As String()
        Dim ncolumnas As Integer = dgvListado.ColumnCount
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(2) As String
        'Rellenar el contenido con el valor de las celdas de la fila

        Contenido(0) = fila.Cells(3).Value  'Columna estudio
        Contenido(1) = fila.Cells(4).Value  'Columna precio
        Contenido(2) = fila.Cells(5).Value  'Columna entidad

        Return Contenido
    End Function

    Private Function precio_parcial() As Double

        Dim Total As Double
        'Dim precio As String = "0"
        If dgvListadoAtenciones.RowCount <> 0 Then
            'Sumar una Columna
            Dim Col As Integer = 1
            For Each row As DataGridViewRow In Me.dgvListadoAtenciones.Rows
                'Total += Val(row.Cells(Col).Value)
                Total += Convert.ToDouble(row.Cells(Col).Value)
                Debug.Write("Ela valor actual de TOTAL es>>> " & Convert.ToDouble(row.Cells(Col).Value))
            Next
        End If
        Return Total
    End Function
End Class