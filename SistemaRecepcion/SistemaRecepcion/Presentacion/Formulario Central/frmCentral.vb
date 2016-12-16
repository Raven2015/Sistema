Imports System.ComponentModel

Public Class frmCentral
    Dim precio_reporte As Integer = 0
    Dim idAtencionActual As Integer = 0
    Dim idClienteActual As Integer = 0
    Dim indicadorAtencion As Integer = 0
    Dim idDetalleActual As Integer = 0

    Private Sub frmCentral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        generar_cliente()
        generar_atencion()
        generar_detalle()

        mostrar()
    End Sub




    '$$$$$$$$$$$$$$$$$$$$$$$    FUNCIONES PARA GENERAR ESPACIOS EN BLANCO DE CADA CLASE NECESARIA    $$$$$$$$$$$$$$$$$$$$$$$

    '---------CLIENTE
    '---------ATENCION
    '---------DETALLE

    Public Sub generar_cliente()
        Try
            Dim dts As New vCliente
            Dim func As New fcliente
            tbIDCliente.Text = Format(func.generar_cliente, "")
            Debug.Write("Cliente Generado OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub generar_atencion()
        Try
            Dim dts As New vAtencion
            Dim funcA As New fAtencion
            tbIDAtencion.Text = Format(funcA.generar_atencion, "")
            Debug.Write("Atencion Generada OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub generar_detalle()
        Try
            Dim dts As New vDetalleAtencion
            Dim funcD As New fDetalle
            tbIDDetalle.Text = Format(funcD.generar_detalle, "")
            Debug.Write("Detalle Generado OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'ESTE FORMULARIO CONTENDRA LA INFORMACION DE TRES CLASES
    'CLIENTE
    'ATENCION
    'DETALLE DE ATENCION
    'Por lo cual sera bastante extenso, la primera parte contendra todo lo referente al cliente


    '$$$$$$$$$$$$$$$$$$$$$$$    CLIENTE    $$$$$$$$$$$$$$$$$$$$$$$

    '-------------- Metodos Internos --------------
    '-Insertar Cliente
    '-Limpiar

    Public Sub insertarCliente()
        If Me.ValidateChildren = True And tbNombres.Text <> "" And tbApellidos.Text <> "" And tbCelular.Text <> "" And tbci.Text <> "" And tbDireccion.Text <> "" And cbSexo.Text <> "" Then
            Try
                Dim dts As New vCliente
                Dim func As New fcliente

                'dts.gid_cliente = Integer.Parse(tbIDCliente.Text)
                dts.gid_cliente = idClienteActual
                dts.gnombres = tbNombres.Text
                dts.gapellidos = tbApellidos.Text
                dts.gfecha_nacimiento = dtpFechaNacimiento.Value
                dts.gdireccion = tbDireccion.Text
                dts.gcodigo_asegurado = tbCodigoAsegurado.Text
                dts.ginstitucion = tbInstitucion.Text
                dts.grazon_social = tbRazonSocial.Text
                dts.gnit = tbNIT.Text
                dts.gtelefono = tbTelefono.Text
                dts.gcelular = tbCelular.Text
                dts.gsexo = cbSexo.Text
                dts.gci = tbci.Text

                If func.insertar(dts) Then
                    'MessageBox.Show("Paciente registrado correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Debug.Write("Registro de paciente OK :)")

                Else
                    MessageBox.Show("El paciente no pudo ser registrado. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Public Sub limpiar()
        'Limpia lo svalores de las cajas de texto.
        tbNombres.Text = ""
        tbApellidos.Text = ""
        tbEdad.Text = ""
        tbDireccion.Text = ""
        tbTelefono.Text = ""
        tbCelular.Text = ""
        tbCodigoAsegurado.Text = ""
        tbRazonSocial.Text = ""
        tbInstitucion.Text = ""
        tbci.Text = ""
        tbNIT.Text = ""
        cbSexo.Text = ""
        dtpFechaNacimiento.Text = DateTime.Today
        Debug.Write("Limpieza OK :)")
    End Sub

    Public Function fecha_nacimiento(ByVal fecha As Date) As Integer
        Dim fecha_nac As Integer
        'Calcula la edad restando la fecha actual menos el valor pasado como parametro.
        fecha_nac = DateTime.Now.Date.Year - fecha.Year
        Return fecha_nac
    End Function

    '-------------- Metodos de Validacion --------------
    '-Nombres
    '-Apellidos
    '-Direccion
    '-Celular
    '-Sexo
    '-Fecha de Nacimiento
    '-CI

    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) Handles tbNombres.Validating
        'Permite validar que el campo nombres no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    Private Sub tbApellidos_Validating(sender As Object, e As CancelEventArgs) Handles tbApellidos.Validating
        'Permite validar que el campo apellidos no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el apellido del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    Private Sub tbDireccion_Validating(sender As Object, e As CancelEventArgs) Handles tbDireccion.Validating
        'Permite validar que el campo direccion no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese la dirección del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbCelular_Validating(sender As Object, e As CancelEventArgs) Handles tbCelular.Validating
        'Permite validar que el campo celular no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un numero Celular de referencia por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub cbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cbSexo.Validating
        'Permite validar que se seleccione por lo menos uno de los valores del checkBox Sexo para evitar datos nulos.
        If cbSexo.Text <> "" Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione el sexo del paciente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub dtpFechaNacimiento_Validating(sender As Object, e As CancelEventArgs) Handles dtpFechaNacimiento.Validating
        'Metodo que permite validar que la fecha seleccionada en el selector de fechas sea distinta a la actual.
        'Se crea una variable que almacenara el valor de la edad
        Dim nacimiento As Integer = 0
        'Se verifica que la fecha seleccionada sea diferente a la actual
        If dtpFechaNacimiento.Value.Date <> DateTime.Now.Date Then
            Me.errorIcono.SetError(sender, "")
            'En caso de que sea diferente se asigna la diferencia entre la fecha actual y la fecha seleccionada a la variable nacimiento
            nacimiento = fecha_nacimiento(dtpFechaNacimiento.Value)
            'Se coloca el valor de nacimiento en el campo EDAD
            tbEdad.Text = nacimiento
        Else
            'En caso de que sea igual se muestra el icono de error
            Me.errorIcono.SetError(sender, "Debe seleccionar una fecha distinta a la actual por favor")
            'Se rellena el campo EDAD con el valor 0
            tbEdad.Text = 0
        End If
    End Sub



    Private Sub tbci_Validating(sender As Object, e As CancelEventArgs) Handles tbci.Validating
        'Permite validar que el campo CI no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el numero de carnet del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    '$$$$$$$$$$$$$$$$$$$$$$$    LISTA DE ESTUDIOS    $$$$$$$$$$$$$$$$$$$$$$$

    '------------------ Funciones Básicas ------------------
    '------------mostrar()
    '------------buscar()
    '------------ocultar_columnas()
    '------------

    Dim dt As New DataTable

    Private Sub mostrar()
        Try
            Dim funcDetalle As New fEntidad
            dt = funcDetalle.mostrar

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                tbBuscar.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lknInexistente.Visible = False
                'chbxEliminar.CheckState = CheckState.Unchecked
            Else
                dgvListado.DataSource = Nothing
                tbBuscar.Enabled = False
                dgvListado.ColumnHeadersVisible = False
                lknInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cbCampo.SelectedIndex = "0"
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
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(1).Visible = False
        dgvListado.Columns(2).Visible = False
    End Sub

    Private Sub limpiarEstudios()
        tbCodigoCategoria.Text = ""
        tbCategoria.Text = ""
        tbCodigoEstudio.Text = ""
        tbNombreEstudio.Text = ""
        tbPrecio.Text = "0"
        tbCliente.Text = ""
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
        limpiarEstudios()
        Try
            tbIDEntidad.Text = dgvListado.SelectedCells.Item(0).Value
            'tbIDEstudio.Text = dgvListado.SelectedCells.Item(1).Value
            tbIDPrecio.Text = dgvListado.SelectedCells.Item(2).Value
            tbCliente.Text = dgvListado.SelectedCells.Item(3).Value
            tbCodigoCategoria.Text = dgvListado.SelectedCells.Item(4).Value
            tbCategoria.Text = dgvListado.SelectedCells.Item(5).Value
            tbCodigoEstudio.Text = dgvListado.SelectedCells.Item(6).Value
            tbNombreEstudio.Text = dgvListado.SelectedCells.Item(7).Value
            tbPrecio.Text = dgvListado.SelectedCells.Item(8).Value
        Catch ex As Exception
            MsgBox("Seleccione una fila con contenido por favor.")
        End Try

    End Sub

    Private Sub dgvListado_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        Dim valores As New DataGridViewRow

        'Dimensionar el array al tamaño de columnas del DGV

        'Rellenar el contenido con el valor de las celdas de la fila

        For Each seleccion As DataGridViewRow In dgvListado.SelectedRows
            Me.dgvListadoAtenciones.Rows.Add(obtener_valores(seleccion))
        Next

        tbPrecioParcial.Text = precio_parcial()

        insertar_detalle()
        editar_Atencion()
    End Sub


    Private Function obtener_valores(ByVal fila As DataGridViewRow) As String()
        Dim ncolumnas As Integer = dgvListado.ColumnCount
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(ncolumnas - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila

        For Ndx As Integer = 0 To Contenido.Length - 1
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        Return Contenido
    End Function


    '$$$$$$$$$$$$$$$$$$$$$$$    ATENCION    $$$$$$$$$$$$$$$$$$$$$$$

    Private Sub limpiar_atencion()
        tbIDAtencion.Text = "" 'Borrar el textBox del ID Atencion para que no existan errores
        tbMedicoRemitente.Text = ""
        dtpFechaAtencion.Text = Date.Now
    End Sub

    Public Sub insertarAtencion()
        Try
            Dim dts As New vAtencion
            Dim func As New fAtencion

            dts.gid_atencion = Integer.Parse(tbIDAtencion.Text)
            dts.gid_cliente = idClienteActual
            dts.gdoctor_remitente = tbMedicoRemitente.Text
            dts.gfecha = dtpFechaAtencion.Text
            dts.gprecio_parcial = tbPrecioParcial.Text


            'If func.insertar(dts) Then
            '    MessageBox.Show("Atencion registrada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.Close()
            'Else
            '    MessageBox.Show("la Atencion no pudo ser registrada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

            func.insertar(dts)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub editar_Atencion()
        Try
            Dim dts As New vAtencion
            Dim func As New fAtencion

            dts.gid_atencion = idAtencionActual
            dts.gprecio_parcial = tbPrecioParcial.Text

            If func.editar(dts) Then
                'MessageBox.Show("Atencion editada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Debug.Write("Atencion actualizada :)")
            Else
                MessageBox.Show("la Atencion no pudo ser editada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '$$$$$$$$$$$$$$$$$$$$$$$    DETALLE DE ATENCION    $$$$$$$$$$$$$$$$$$$$$$$

    Private Function precio_parcial() As Integer

        Dim Total As Single
        'Dim precio As String = "0"
        If dgvListadoAtenciones.RowCount <> 0 Then
            'Sumar una Columna
            Dim Col As Integer = 8
            For Each row As DataGridViewRow In Me.dgvListadoAtenciones.Rows
                Total += Val(row.Cells(Col).Value)
            Next
        End If
        Return Total
    End Function


    Private Sub ocultar_columnas_atencion()
        dgvListadoAtenciones.Columns(0).Visible = False
        dgvListadoAtenciones.Columns(1).Visible = False
        dgvListadoAtenciones.Columns(2).Visible = False

    End Sub

    Public Sub insertar_detalle()
        Try
            Dim dts As New vDetalleAtencion
            Dim func As New fDetalle

            'idDetalleActual = tbIDDetalle.Text
            dts.gid_detalle = tbIDDetalle.Text

            dts.gid_atencion = tbIDAtencion.Text
            dts.gid_entidad = tbIDEntidad.Text


            If func.insertar(dts) Then
                'MessageBox.Show("Estudio añadido correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Debug.Write("Estudio adherido correctamente :)")
            Else
                MessageBox.Show("El estudio no pudo ser añadido. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        generar_detalle()
    End Sub




    '$$$$$$$$$$$$$$$$$$$$$$$    BOTON INSERTAR ESTUDIOS    $$$$$$$$$$$$$$$$$$$$$$$
    Private Sub btnInsertarEstudios_Click(sender As Object, e As EventArgs) Handles btnInsertarEstudios.Click
        'insertarCliente()
        Try
            insertarAtencion() 'Cuando se presiona el boton INSERTAR ESTUDIOS, se envian los datos del estudio y el precio que se encuentra en el tb precio = 0
            idAtencionActual = Integer.Parse(tbIDAtencion.Text)
            Debug.Write("Valor de IDAtencion >> " & idAtencionActual)
        Catch ex As Exception
            MsgBox("Ups. Algo anda mal :/")
        End Try
        pnListaEstudios.Visible = True
        'insertar_detalle()
        'limpiar()
        'limpiarEstudios()
        'limpiar_atencion()
    End Sub

    '$$$$$$$$$$$$$$$$$$$$$$$    CAMBIOS AUTOMATICOS EN LA INTERFAZ    $$$$$$$$$$$$$$$$$$$$$$$
    Private Sub tbNombres_TextChanged(sender As Object, e As EventArgs) Handles tbNombres.TextChanged
        tbNombresVP.Text = tbNombres.Text
    End Sub

    Private Sub tbApellidos_TextChanged(sender As Object, e As EventArgs) Handles tbApellidos.TextChanged
        tbApellidoVP.Text = tbApellidos.Text
    End Sub

    Private Sub tbDireccion_TextChanged(sender As Object, e As EventArgs) Handles tbDireccion.TextChanged
        tbDireccionVP.Text = tbDireccion.Text
    End Sub

    Private Sub tbci_TextChanged(sender As Object, e As EventArgs) Handles tbci.TextChanged
        tbCiVP.Text = tbci.Text
    End Sub

    Private Sub cbSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSexo.SelectedIndexChanged
        tbSexoVP.Text = cbSexo.Text
    End Sub

    Private Sub tbTelefono_TextChanged(sender As Object, e As EventArgs) Handles tbTelefono.TextChanged
        tbTelefonoVP.Text = tbTelefono.Text
    End Sub

    Private Sub tbCelular_TextChanged(sender As Object, e As EventArgs) Handles tbCelular.TextChanged
        tbCelularVP.Text = tbCelular.Text
    End Sub

    Private Sub tbMedicoRemitente_TextChanged(sender As Object, e As EventArgs) Handles tbMedicoRemitente.TextChanged
        tbMedicoRemitenteVP.Text = tbMedicoRemitente.Text
    End Sub

    Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged
        tbFechaNacimientoVP.Text = dtpFechaNacimiento.Text
    End Sub

    Private Sub dtpFechaAtencion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaAtencion.ValueChanged
        tbFechaEstudioVP.Text = dtpFechaAtencion.Text
    End Sub


    '-------------------Boton IMPRIMIR-----------------------
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'editar_Atencion() 'Cuando el usuario presione el boton imprimir se guardan los datos de la atencion.
        Debug.Write("Valor de IDAtencion>> " & idAtencionActual)
        Prueba.tbIDAtencion.Text = idAtencionActual
        'POSTERIORMENTE SE LLAMA A LA CLASE frmREPORTE PARA IMPRIMIR EL REPORTE DE ATENCION
        Prueba.ShowDialog()
    End Sub

    'Cuando el tbMedico Remitente entra en foco, se envian automaticamente los datos del cliente.
    'Si falta algun dato obligatorio, se lanza un mensaje de alerta para que rellene todos los campos.


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDatosAtencion_Click(sender As Object, e As EventArgs) Handles btnDatosAtencion.Click
        If Me.ValidateChildren = True And tbNombres.Text <> "" And tbApellidos.Text <> "" And tbCelular.Text <> "" And tbci.Text <> "" And tbDireccion.Text <> "" And cbSexo.Text <> "" Then
            Try
                idClienteActual = Integer.Parse(tbIDCliente.Text)
                insertarCliente()
            Catch ex As Exception
                MsgBox("Por favor llene los campos marcados como obligatorios.")
            End Try
        End If
        generar_cliente()
        btnDatosAtencion.Visible = False
    End Sub

End Class

