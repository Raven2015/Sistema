Public Class frmArqueos
    Private dt As New DataTable
    Private Sub frmArqueos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsListaEntidades.listaEntidad' table. You can move, or remove it, as needed.
        Me.ListaEntidadTableAdapter.Fill(Me.DsListaEntidades.listaEntidad)
        limpiar()
        mostrar_ingresos()
    End Sub

    Public Sub mostrar_ingresos()
        Dim fecha_atencion As Date
        Dim entidad As String
        fecha_atencion = dtpFechaAtencion.Text
        Debug.Write("Fecha enviada: " & dtpFechaAtencion.Text)
        entidad = cbxEntidad.Text
        Debug.Write("Entidad Enviada: " & cbxEntidad.Text)
        Try
            Dim func As New fArqueoIngreso
            dt = func.mostrar_ingresos_fecha(fecha_atencion, entidad)

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                dgvListado.ColumnHeadersVisible = True
                AnchoColumnas()
                lknInexistente.Visible = False
            Else
                dgvListado.DataSource = Nothing
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox("La tabla aun esta vacia: " & ex.Message)
        End Try
        'calcularValores()
    End Sub

    Public Sub AnchoColumnas()
        dgvListado.Columns(0).Width = 270
        dgvListado.Columns(1).Width = 110
        dgvListado.Columns(2).Width = 100
        dgvListado.Columns(3).Width = 100
    End Sub

    Public Sub limpiar()
        cbxEntidad.SelectedIndex = 0
        dtpFechaAtencion.Text = Date.Now
        cbxTurno.SelectedIndex = 0
    End Sub

    Private Sub cbxEntidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEntidad.SelectedIndexChanged
        mostrar_ingresos()
        calcularValores()
    End Sub

    Private Sub dtpFechaAtencion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaAtencion.ValueChanged
        mostrar_ingresos()
        calcularValores()
    End Sub

    Private Sub cbxTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTurno.SelectedIndexChanged
        mostrar_ingresos()
        calcularValores()
    End Sub

    Public Sub calcularValores()
        Dim ingresos As Double
        ingresos = precio_parcial()
        tbIngresos.Text = ingresos
    End Sub
    Protected Function obtener_valoresBETA(ByVal fila As DataGridViewRow) As String()
        Dim ncolumnas As Integer = dgvListado.ColumnCount
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(3) As String
        'Rellenar el contenido con el valor de las celdas de la fila

        Contenido(0) = fila.Cells(0).Value  'Columna Categoria
        Contenido(1) = fila.Cells(1).Value  'Columna Entidad
        Contenido(2) = fila.Cells(2).Value  'Columna Fecha
        Contenido(3) = fila.Cells(3).Value  'Columna Precio

        Return Contenido
    End Function

    Private Function precio_parcial() As Double

        Dim Total As Double
        'Dim precio As String = "0"
        If dgvListado.RowCount <> 0 Then
            'Sumar una Columna
            Dim Col As Integer = 3
            For Each row As DataGridViewRow In Me.dgvListado.Rows
                'Total += Val(row.Cells(Col).Value)
                Total += Convert.ToDouble(row.Cells(Col).Value)
                Debug.Write("Ela valor actual de TOTAL es>>> " & Convert.ToDouble(row.Cells(Col).Value))
            Next
        End If
        Return Total
    End Function

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ReporteArqueo.tbEntidad.Text = cbxEntidad.Text
        ReporteArqueo.tbFecha.Text = dtpFechaAtencion.Text
        ReporteArqueo.ShowDialog()
    End Sub
End Class