Public Class frmComprobantesCaja
    Dim dt As New DataTable
    Private Sub ComprobantesCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        llenar()
        montos()
    End Sub

    Private Sub llenar()
        Try
            Dim funcDetalle As New fComprobante
            Dim dts As New vComprobante

            dts.gfecha_atencion = dtpFechaAtencion.Text

            dt = funcDetalle.mostrar(dts)

            If dt.Rows.Count <> 0 Then
                dgvListadoAtenciones.DataSource = dt
                'lknInexistente.Visible = False

            Else
                dgvListadoAtenciones.DataSource = Nothing
                'lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaAtencion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaAtencion.ValueChanged
        llenar()
        montos()
    End Sub


    Private Sub dgvListadoAtenciones_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoAtenciones.CellMouseDoubleClick
        Dim id_atencion As Integer
        id_atencion = dgvListadoAtenciones.SelectedCells.Item(6).Value
        ReporteCajaFinal.tbIDAtencion.Text = id_atencion
        ReporteCajaFinal.ShowDialog()
    End Sub

    Public Sub limpiar()
        cbxTurno.SelectedIndex = 0
        tbTotalIngresado.Text = "0"
        tbTotalDescuentos.Text = "0"
        tbTotalCaja.Text = "0"
    End Sub

    Public Function calcular() As Integer
        Dim TotalFacturado As Single
        'Dim precio As String = "0"
        If dgvListadoAtenciones.RowCount <> 0 Then
            'Sumar una Columna
            Dim Col As Integer = 5
            For Each row As DataGridViewRow In Me.dgvListadoAtenciones.Rows
                TotalFacturado += Val(row.Cells(Col).Value)
            Next
        End If
        Return TotalFacturado
    End Function

    Public Sub montos()
        Dim TotalFacturado As Double
        Dim TotalDescuentos As Double
        Dim TotalCaja As Double = 0

        TotalFacturado = Convert.ToDouble(calcular())
        TotalDescuentos = 0
        TotalCaja = TotalFacturado - TotalDescuentos
        tbTotalIngresado.Text = TotalFacturado
        tbTotalDescuentos.Text = TotalDescuentos
        tbTotalCaja.Text = TotalCaja
    End Sub
End Class