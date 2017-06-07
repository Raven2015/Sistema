Imports DevExpress.XtraRichEdit.API.Native

Public Class dlgBuscadorInforme
    Private dt As New DataTable
    Private Sub dlgBuscadorInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fBusqInforme
            dt = func.seleccionar_informe(0, 0, 0, 0)

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
            Else
                dgvListado.DataSource = Nothing
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'buscar()
    End Sub

    Private Sub mostrar_seleccionado()
        Dim login As Integer
        Dim nombre, apellido, ci As String

        login = tbLogin.Text
        nombre = tbNombre.Text
        apellido = tbApellido.Text
        ci = tbCI.Text
        Try
            Dim func As New fBusqInforme
            dt = func.seleccionar_informe(nombre, apellido, login, ci)

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
            Else
                dgvListado.DataSource = Nothing
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'dv.RowFilter = cbCampo.Text & " like '" & tbBuscar.Text & "%'"
            If dv.Count <> 0 Then
                lknInexistente.Visible = False
                dgvListado.DataSource = dv
            Else
                lknInexistente.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        tbInforme.Text = dgvListado.SelectedCells.Item(4).Value
        lblApellido.Text = dgvListado.SelectedCells.Item(1).Value
        lblNombre.Text = dgvListado.SelectedCells.Item(0).Value
        lblCI.Text = dgvListado.SelectedCells.Item(2).Value
        lblFecha.Text = dgvListado.SelectedCells.Item(3).Value
        lblAtencion.Text = dgvListado.SelectedCells.Item(5).Value
        lblAutor.Text = dgvListado.SelectedCells.Item(6).Value
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrar_seleccionado()
    End Sub

    Private Sub dgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentDoubleClick

        'dvxpReporteMedico.rhedctContenidoReporte.Text = dgvListado.SelectedCells.Item(4).Value
        dvxpReporteMedico.rhedctContenidoReporte.Document.AppendText(dgvListado.SelectedCells.Item(4).Value)
        Me.Close()
    End Sub
End Class