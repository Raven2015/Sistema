Imports System.Windows.Forms

Public Class dlgBuscaInforme
    Dim dt As New DataTable
    Private Sub dlgBuscaInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub llenar()
        Try
            Dim funcLista As New fInformeMedico
            Dim nombre_cliente As String
            Dim apellido_cliente As String
            Dim ci As String = ""
            Dim id_atencion As String = ""

            Dim objeto = New vInformeMedicoB

            'If tbCodigoAtencion.Text = "" Then
            '    tbCodigoAtencion.Text = "%"
            'End If

            objeto.gid_atencion = tbCodigoAtencion.Text
            objeto.gnombre_cliente = tbNombres.Text
            objeto.gapellido_cliente = tbApellidos.Text
            objeto.gci_cliente = tbCI.Text

            dt = funcLista.buscar_informe(objeto)

            If dt.Rows.Count <> 0 Then
                dgvListaInforme.DataSource = dt
                lknInexistente.Visible = False

            Else
                dgvListaInforme.DataSource = Nothing
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub mostrar()
    '    Dim objeto = New vInformeMedicoB
    '    Try
    '        Dim funcDetalle As New fInformeMedico
    '        objeto.gid_atencion = 0
    '        objeto.gnombre_cliente = tbNombres.Text
    '        objeto.gapellido_cliente = tbApellidos.Text
    '        objeto.gci_cliente = tbCI.Text
    '        dt = funcDetalle.buscar_informe(objeto)

    '        If dt.Rows.Count <> 0 Then
    '            dgvListaInforme.DataSource = dt
    '            dgvListaInforme.ColumnHeadersVisible = True
    '            lknInexistente.Visible = False
    '            'chbxEliminar.CheckState = CheckState.Unchecked
    '        Else
    '            dgvListaInforme.DataSource = Nothing
    '            dgvListaInforme.ColumnHeadersVisible = False
    '            lknInexistente.Visible = True
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    'buscar()
    'End Sub

    'Private Sub buscar()
    '    Try
    '        Dim ds As New DataSet
    '        ds.Tables.Add(dt.Copy)
    '        Dim dv As New DataView(ds.Tables(0))

    '        dv.RowFilter = "dbo.atencion.id_atencion" & " like '" & tbCodigoAtencion.Text & "%' and " & "dbo.cliente.apellidos" & " like '%" & tbApellidos.Text & "%' and " & "dbo.cliente.nombres" & " like '%" & tbNombres.Text & "%' and " & "dbo.cliente.ci" & " like '%" & tbCI.Text & "%'"

    '        If dv.Count <> 0 Then
    '            lknInexistente.Visible = False
    '            dgvListaInforme.DataSource = dv
    '            'ocultar_columnas()
    '            'AnchoColumnas()
    '        Else
    '            lknInexistente.Visible = True
    '            dgvListaInforme.DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub tbCodigoAtencion_TextChanged(sender As Object, e As EventArgs) Handles tbCodigoAtencion.TextChanged
        llenar()
    End Sub

    Private Sub tbNombres_TextChanged(sender As Object, e As EventArgs) Handles tbNombres.TextChanged
        llenar()
    End Sub

    Private Sub tbApellidos_TextChanged(sender As Object, e As EventArgs) Handles tbApellidos.TextChanged
        llenar()
    End Sub

    Private Sub tbCI_TextChanged(sender As Object, e As EventArgs) Handles tbCI.TextChanged
        llenar()
    End Sub

    Private Sub dgvListaInforme_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaInforme.CellContentClick

    End Sub
End Class
