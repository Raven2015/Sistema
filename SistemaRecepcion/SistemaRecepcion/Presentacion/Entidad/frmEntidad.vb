Public Class frmEntidad

    Private dt As New DataTable

    Private Sub frmEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        limpiar_estudios()
        mostrar()
        generar_precio()
        generar_entidad()
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

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                tbBuscar.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
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
        dgvListaEstPrec.Columns(1).Width = 200
        dgvListaEstPrec.Columns(1).Width = 70
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
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(1).Visible = False
    End Sub
    Private Sub ocultar_filas()
        Dim nfilas As Integer
        nfilas = dgvListado.Rows.Count
    End Sub

    Private Sub limpiar_estudios()
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
            'tbIDCategoria.Text = dgvListado.SelectedCells.Item(1).Value
            tbIDEstudio.Text = dgvListado.SelectedCells.Item(1).Value
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(2).Value
            tbCategoria.Text = dgvListado.SelectedCells.Item(3).Value
            tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(4).Value
            tbNombres.Text = dgvListado.SelectedCells.Item(5).Value

        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try
    End Sub



    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        Dim valores As New DataGridViewRow

        'Dimensionar el array al tamaño de columnas del DGV

        'Rellenar el contenido con el valor de las celdas de la fila

        For Each seleccion As DataGridViewRow In dgvListado.SelectedRows
            Me.dgvListaEstPrec.Rows.Add(obtener_valores(seleccion))
        Next
        insertar_precio()
        tbPrecio.Text = "0"
    End Sub



    Private Function obtener_valores(ByVal fila As DataGridViewRow) As String()
        Dim ncolumnas As Integer = dgvListado.ColumnCount
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(4) As String
        'Rellenar el contenido con el valor de las celdas de la fila

        Contenido(0) = fila.Cells(1).Value  'Columna id-estudio
        Contenido(1) = fila.Cells(4).Value  'Columna codigo_estudio
        Contenido(2) = fila.Cells(5).Value  'Columna Estudio
        Contenido(3) = tbPrecio.Text
        Contenido(4) = tbIDPrecio.Text

        Return Contenido
    End Function

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrar()
        limpiar_estudios()
    End Sub


    '----------DOBLE CLICK PARA ELIMINAR UN ESTUDIO AÑADIDO
    Private Sub dgvListaEstPrec_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaEstPrec.CellMouseDoubleClick
        For Each seleccion As DataGridViewRow In dgvListaEstPrec.SelectedRows
            eliminar_precio()
            Me.dgvListaEstPrec.Rows.RemoveAt(dgvListaEstPrec.CurrentRow.Index)
        Next
    End Sub


    '$$$$$$$$$$$$$$$$$$$$$$$    FUNCIONES PARA GENERAR ESPACIOS EN BLANCO DE CADA CLASE NECESARIA    $$$$$$$$$$$$$$$$$$$$$$$

    '---------ENTIDAD
    '---------PRECIO

    Public Sub generar_entidad()
        Try
            Dim dts As New vEntidad
            Dim func As New fEntidad
            tbIDEntidad.Text = Format(func.generar_entidad, "")
            Debug.Write("Entidad Generada OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub generar_precio()
        Try
            Dim dts As New vPrecio
            Dim func As New fprecio
            tbIDPrecio.Text = Format(func.generar_precio, "")
            Debug.Write("Precio Generado OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-----------BOTON PARA GUARDAR TODOS LOS ESTUDIOS ASIGNADOS A UNA ENTIDAD
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim resultado As New DialogResult
        resultado = MsgBox("Son todos los datos correctos? ")
        If (resultado = DialogResult.OK) Then
            registrarEntidad()
            Debug.Write("Todo OK")
        End If
        grbxDatosEstudio.Refresh()
    End Sub


    '----------------REGISTRAR ENTIDAD
    Public Sub registrarEntidad()
        Dim id_entidad As Integer = tbIDEntidad.Text
        Dim id As String = "0"
        For Each seleccion As DataGridViewRow In dgvListaEstPrec.Rows
            Try
                id = seleccion.Cells(0).Value 'Obtiene el valor actual del ID de Estudio
                Debug.Write("Valor de IDEstudio = " & id)
                insertar_entidad(seleccion, id_entidad)
                id_entidad = id_entidad + 1
                'Me.dgvListaEstPrec.Rows.RemoveAt(dgvListaEstPrec.CurrentRow.Index)
            Catch ex As Exception
                MsgBox("Datos registrados")
            End Try
        Next
    End Sub


    '----------------INSERTAR ENTIDAD
    Public Sub insertar_entidad(ByVal fila As DataGridViewRow, ByVal id_entidad As Integer)
        Try
            Dim dts As New vEntidad
            Dim func As New fEntidad

            'idDetalleActual = tbIDDetalle.Text
            dts.gid_entidad = id_entidad
            dts.gentidad = tbEntidad.Text
            dts.gid_estudio = fila.Cells.Item(0).Value
            dts.gid_precio = fila.Cells.Item(4).Value

            func.insertar(dts)
            'MessageBox.Show("Estudio añadido correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.Write("Entidad creada correctamente :)")
        Catch ex As Exception
            Debug.Write("Se alcanzo el limite")
        End Try
        'generar_precio()
    End Sub

    '---------------- INSERTAR PRECIO
    Public Sub insertar_precio()
        Try
            Dim dts As New vPrecio
            Dim func As New fprecio

            'idDetalleActual = tbIDDetalle.Text
            dts.gid_precio = tbIDPrecio.Text
            dts.gprecio = tbPrecio.Text


            func.insertar(dts)
            'MessageBox.Show("Estudio añadido correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.Write("Precio adherido correctamente :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        generar_precio()
    End Sub

    '-------------------ELIMINAR PRECIO
    Public Sub eliminar_precio()
        Try
            Dim dts As New vPrecio
            Dim func As New fprecio

            'idDetalleActual = tbIDDetalle.Text
            dts.gid_precio = dgvListaEstPrec.SelectedCells.Item(4).Value

            func.eliminar(dts)
            'MessageBox.Show("Estudio añadido correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.Write("Precio eliminado correctamente :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'generar_precio()
    End Sub

    '-----------Metodo para limpiar el datagridview de listados
    Public Sub limpiardgvListEstPrecios()
        Try
            If dgvListaEstPrec.RowCount >= 1 Then
                For i As Integer = 1 To dgvListaEstPrec.RowCount
                    dgvListaEstPrec.Rows.Remove(dgvListaEstPrec.CurrentRow)
                    Debug.Write("Fila Eliminada>>> " & i)
                Next
            End If
        Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
            MsgBox("Esta fila no se puede eliminar", MsgBoxStyle.Critical, "Operación inválida : : : . . ." & ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        Debug.Write("Limpiando Lista de Estudios :)")
        limpiardgvListEstPrecios()
        Debug.Write("Limpieza OK:)")
        tbEntidad.Text = ""
    End Sub
End Class