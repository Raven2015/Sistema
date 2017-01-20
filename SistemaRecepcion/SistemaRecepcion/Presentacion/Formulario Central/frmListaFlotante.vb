Public Class frmListaFlotante
    Private dt As New DataTable
    Private Sub frmListaFlotante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar_registrados(tbCI.Text)

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                'tbCI.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False

            Else
                dgvListado.DataSource = Nothing
                'tbCI.Enabled = False
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

            dv.RowFilter = "ci " & " like '" & tbCI.Text & "%'"

            If dv.Count <> 0 Then
                lknInexistente.Visible = False
                dgvListado.DataSource = dv
                ocultar_columnas()
                ancho_columnas()
            Else
                lknInexistente.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgvListado.Columns(0).Visible = True
        dgvListado.Columns(1).Visible = True
        dgvListado.Columns(2).Visible = True
        dgvListado.Columns(3).Visible = False
        dgvListado.Columns(4).Visible = False
        dgvListado.Columns(5).Visible = False
        dgvListado.Columns(6).Visible = False
        dgvListado.Columns(7).Visible = False
        dgvListado.Columns(8).Visible = False
        dgvListado.Columns(9).Visible = False
        dgvListado.Columns(10).Visible = False
        dgvListado.Columns(11).Visible = False
        dgvListado.Columns(12).Visible = False
    End Sub

    Private Sub ancho_columnas()
        dgvListado.Columns(0).Width = 170
        dgvListado.Columns(1).Width = 170
        dgvListado.Columns(2).Width = 100
    End Sub

    Private Sub enviar_datos()
        frmCentral.tbNombres.Text = dgvListado.SelectedCells.Item(0).Value
        frmCentral.tbApellidos.Text = dgvListado.SelectedCells.Item(1).Value
        frmCentral.tbci.Text = dgvListado.SelectedCells.Item(2).Value
        frmCentral.dtpFechaNacimiento.Text = dgvListado.SelectedCells.Item(3).Value
        frmCentral.tbCodigoAsegurado.Text = dgvListado.SelectedCells.Item(8).Value
        frmCentral.tbEdad.Text = dgvListado.SelectedCells.Item(12).Value
        frmCentral.cbSexo.Text = dgvListado.SelectedCells.Item(7).Value
        frmCentral.tbTelefono.Text = dgvListado.SelectedCells.Item(5).Value
        frmCentral.tbCelular.Text = dgvListado.SelectedCells.Item(6).Value
        frmCentral.cbxInstitucion.Text = dgvListado.SelectedCells.Item(9).Value
        frmCentral.tbRazonSocial.Text = dgvListado.SelectedCells.Item(10).Value
        frmCentral.tbNIT.Text = dgvListado.SelectedCells.Item(11).Value
    End Sub

    Private Sub tbCI_TextChanged(sender As Object, e As EventArgs) Handles tbCI.TextChanged
        mostrar()
    End Sub

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        enviar_datos()
        Me.Close()
    End Sub
End Class