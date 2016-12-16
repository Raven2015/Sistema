<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCentral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbFechaEstudioVP = New System.Windows.Forms.TextBox()
        Me.tbFechaNacimientoVP = New System.Windows.Forms.TextBox()
        Me.grbxVIstaPrevia = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.id_entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.tbIDCliente = New System.Windows.Forms.TextBox()
        Me.tbIDDetalle = New System.Windows.Forms.TextBox()
        Me.tbPrecioParcial = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbSexoVP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbMedicoRemitenteVP = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbCiVP = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbCelularVP = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbTelefonoVP = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbEdadVP = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbDireccionVP = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbApellidoVP = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbNombresVP = New System.Windows.Forms.TextBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnListaEstudios = New System.Windows.Forms.Panel()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.lbCodigoCategoria = New System.Windows.Forms.Label()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.lbCodigoEstudio = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.lbNombreEstudio = New System.Windows.Forms.Label()
        Me.tbNombreEstudio = New System.Windows.Forms.TextBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.gbListadoEstudios = New System.Windows.Forms.GroupBox()
        Me.tbIDLista = New System.Windows.Forms.TextBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.grbxSeleccionEstudio = New System.Windows.Forms.GroupBox()
        Me.btnInsertarEstudios = New System.Windows.Forms.Button()
        Me.tbIDEstudio2 = New System.Windows.Forms.TextBox()
        Me.lbEstudio = New System.Windows.Forms.Label()
        Me.grbxDatosAtencion = New System.Windows.Forms.GroupBox()
        Me.btnDatosAtencion = New System.Windows.Forms.Button()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.lbMedicoRemit = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.lbFechaEstudio = New System.Windows.Forms.Label()
        Me.grbxDatosFactura = New System.Windows.Forms.GroupBox()
        Me.tbNIT = New System.Windows.Forms.TextBox()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.tbInstitucion = New System.Windows.Forms.TextBox()
        Me.tbCodigoAsegurado = New System.Windows.Forms.TextBox()
        Me.lbNit = New System.Windows.Forms.Label()
        Me.lbRazonSocial = New System.Windows.Forms.Label()
        Me.lbInstitucion = New System.Windows.Forms.Label()
        Me.lbCodigoAsegurado = New System.Windows.Forms.Label()
        Me.grbxDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.lbci = New System.Windows.Forms.Label()
        Me.tbci = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.lbCelular = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblbApellidoCliente = New System.Windows.Forms.Label()
        Me.lbNombreCliente = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grbxVIstaPrevia.SuspendLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnListaEstudios.SuspendLayout()
        Me.grbDatosCategoria.SuspendLayout()
        Me.gbEstudio.SuspendLayout()
        Me.gbListadoEstudios.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxSeleccionEstudio.SuspendLayout()
        Me.grbxDatosAtencion.SuspendLayout()
        Me.grbxDatosFactura.SuspendLayout()
        Me.grbxDatosPersonales.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFechaEstudioVP
        '
        Me.tbFechaEstudioVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaEstudioVP.Location = New System.Drawing.Point(141, 213)
        Me.tbFechaEstudioVP.MaxLength = 8
        Me.tbFechaEstudioVP.Name = "tbFechaEstudioVP"
        Me.tbFechaEstudioVP.ReadOnly = True
        Me.tbFechaEstudioVP.Size = New System.Drawing.Size(131, 23)
        Me.tbFechaEstudioVP.TabIndex = 49
        '
        'tbFechaNacimientoVP
        '
        Me.tbFechaNacimientoVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaNacimientoVP.Location = New System.Drawing.Point(127, 128)
        Me.tbFechaNacimientoVP.MaxLength = 8
        Me.tbFechaNacimientoVP.Name = "tbFechaNacimientoVP"
        Me.tbFechaNacimientoVP.ReadOnly = True
        Me.tbFechaNacimientoVP.Size = New System.Drawing.Size(131, 23)
        Me.tbFechaNacimientoVP.TabIndex = 48
        '
        'grbxVIstaPrevia
        '
        Me.grbxVIstaPrevia.Controls.Add(Me.btnImprimir)
        Me.grbxVIstaPrevia.Controls.Add(Me.dgvListadoAtenciones)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label39)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label38)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label37)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label33)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbIDEntidad)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbIDAtencion)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbIDCliente)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbIDDetalle)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbPrecioParcial)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label36)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label31)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbFechaEstudioVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbFechaNacimientoVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbSexoVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label13)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label26)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbMedicoRemitenteVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label27)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbCiVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label25)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label24)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label23)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbCelularVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label22)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbTelefonoVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label21)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbEdadVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label20)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbDireccionVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label19)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbApellidoVP)
        Me.grbxVIstaPrevia.Controls.Add(Me.Label18)
        Me.grbxVIstaPrevia.Controls.Add(Me.tbNombresVP)
        Me.grbxVIstaPrevia.Dock = System.Windows.Forms.DockStyle.Right
        Me.grbxVIstaPrevia.Location = New System.Drawing.Point(705, 0)
        Me.grbxVIstaPrevia.Name = "grbxVIstaPrevia"
        Me.grbxVIstaPrevia.Size = New System.Drawing.Size(399, 661)
        Me.grbxVIstaPrevia.TabIndex = 3
        Me.grbxVIstaPrevia.TabStop = False
        Me.grbxVIstaPrevia.Text = "*"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.print
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(327, 544)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(60, 60)
        Me.btnImprimir.TabIndex = 60
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoAtenciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoAtenciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_entidad, Me.id_estudio, Me.id_pecio, Me.entidad, Me.codigo_categoria, Me.nombre_categoria, Me.codigo_estudio, Me.estudio, Me.precio})
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(9, 241)
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(384, 296)
        Me.dgvListadoAtenciones.TabIndex = 59
        '
        'id_entidad
        '
        Me.id_entidad.HeaderText = "id_entidad"
        Me.id_entidad.Name = "id_entidad"
        Me.id_entidad.ReadOnly = True
        Me.id_entidad.Visible = False
        '
        'id_estudio
        '
        Me.id_estudio.HeaderText = "id_estudio"
        Me.id_estudio.Name = "id_estudio"
        Me.id_estudio.ReadOnly = True
        Me.id_estudio.Visible = False
        '
        'id_pecio
        '
        Me.id_pecio.HeaderText = "id_pecio"
        Me.id_pecio.Name = "id_pecio"
        Me.id_pecio.ReadOnly = True
        Me.id_pecio.Visible = False
        '
        'entidad
        '
        Me.entidad.HeaderText = "ENTIDAD"
        Me.entidad.Name = "entidad"
        Me.entidad.ReadOnly = True
        '
        'codigo_categoria
        '
        Me.codigo_categoria.HeaderText = "CODIGO CATEGORIA"
        Me.codigo_categoria.Name = "codigo_categoria"
        Me.codigo_categoria.ReadOnly = True
        '
        'nombre_categoria
        '
        Me.nombre_categoria.HeaderText = "NOMBRE CATEGORIA"
        Me.nombre_categoria.Name = "nombre_categoria"
        Me.nombre_categoria.ReadOnly = True
        '
        'codigo_estudio
        '
        Me.codigo_estudio.HeaderText = "CODIGO ESTUDIO"
        Me.codigo_estudio.Name = "codigo_estudio"
        Me.codigo_estudio.ReadOnly = True
        '
        'estudio
        '
        Me.estudio.HeaderText = "ESTUDIO"
        Me.estudio.Name = "estudio"
        Me.estudio.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(206, 622)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 13)
        Me.Label39.TabIndex = 58
        Me.Label39.Text = "id_entidad"
        Me.Label39.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(68, 622)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(62, 13)
        Me.Label38.TabIndex = 57
        Me.Label38.Text = "id_atencion"
        Me.Label38.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(138, 622)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 13)
        Me.Label37.TabIndex = 56
        Me.Label37.Text = "id_cliente"
        Me.Label37.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 622)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 13)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "id_detalle"
        Me.Label33.Visible = False
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbIDEntidad.Location = New System.Drawing.Point(204, 638)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.Size = New System.Drawing.Size(62, 23)
        Me.tbIDEntidad.TabIndex = 55
        Me.tbIDEntidad.Visible = False
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDAtencion.Location = New System.Drawing.Point(68, 638)
        Me.tbIDAtencion.MaxLength = 50
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(62, 23)
        Me.tbIDAtencion.TabIndex = 54
        Me.tbIDAtencion.Visible = False
        '
        'tbIDCliente
        '
        Me.tbIDCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbIDCliente.Location = New System.Drawing.Point(136, 638)
        Me.tbIDCliente.Name = "tbIDCliente"
        Me.tbIDCliente.Size = New System.Drawing.Size(62, 23)
        Me.tbIDCliente.TabIndex = 21
        Me.tbIDCliente.Visible = False
        '
        'tbIDDetalle
        '
        Me.tbIDDetalle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDDetalle.Location = New System.Drawing.Point(0, 638)
        Me.tbIDDetalle.MaxLength = 50
        Me.tbIDDetalle.Name = "tbIDDetalle"
        Me.tbIDDetalle.Size = New System.Drawing.Size(62, 23)
        Me.tbIDDetalle.TabIndex = 53
        Me.tbIDDetalle.Visible = False
        '
        'tbPrecioParcial
        '
        Me.tbPrecioParcial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecioParcial.Location = New System.Drawing.Point(87, 544)
        Me.tbPrecioParcial.MaxLength = 8
        Me.tbPrecioParcial.Name = "tbPrecioParcial"
        Me.tbPrecioParcial.ReadOnly = True
        Me.tbPrecioParcial.Size = New System.Drawing.Size(131, 23)
        Me.tbPrecioParcial.TabIndex = 52
        Me.tbPrecioParcial.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(6, 547)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(75, 15)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Total a Pagar"
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(170, 12)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 19)
        Me.Label31.TabIndex = 50
        Me.Label31.Text = "VISTA PREVIA"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSexoVP
        '
        Me.tbSexoVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSexoVP.Location = New System.Drawing.Point(264, 70)
        Me.tbSexoVP.MaxLength = 8
        Me.tbSexoVP.Name = "tbSexoVP"
        Me.tbSexoVP.ReadOnly = True
        Me.tbSexoVP.Size = New System.Drawing.Size(131, 23)
        Me.tbSexoVP.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "CI"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(8, 187)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 15)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Medico Remitente"
        '
        'tbMedicoRemitenteVP
        '
        Me.tbMedicoRemitenteVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedicoRemitenteVP.Location = New System.Drawing.Point(141, 184)
        Me.tbMedicoRemitenteVP.MaxLength = 50
        Me.tbMedicoRemitenteVP.Name = "tbMedicoRemitenteVP"
        Me.tbMedicoRemitenteVP.ReadOnly = True
        Me.tbMedicoRemitenteVP.Size = New System.Drawing.Size(254, 23)
        Me.tbMedicoRemitenteVP.TabIndex = 43
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(8, 219)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 15)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Fecha Estudio"
        '
        'tbCiVP
        '
        Me.tbCiVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCiVP.Location = New System.Drawing.Point(70, 70)
        Me.tbCiVP.Name = "tbCiVP"
        Me.tbCiVP.ReadOnly = True
        Me.tbCiVP.Size = New System.Drawing.Size(131, 23)
        Me.tbCiVP.TabIndex = 38
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(6, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 15)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Nombres"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(201, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 15)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Apellidos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(6, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 15)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Fecha de Nacimiento"
        '
        'tbCelularVP
        '
        Me.tbCelularVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCelularVP.Location = New System.Drawing.Point(264, 99)
        Me.tbCelularVP.MaxLength = 8
        Me.tbCelularVP.Name = "tbCelularVP"
        Me.tbCelularVP.ReadOnly = True
        Me.tbCelularVP.Size = New System.Drawing.Size(131, 23)
        Me.tbCelularVP.TabIndex = 35
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(8, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 15)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Dirección"
        '
        'tbTelefonoVP
        '
        Me.tbTelefonoVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefonoVP.Location = New System.Drawing.Point(70, 99)
        Me.tbTelefonoVP.MaxLength = 9
        Me.tbTelefonoVP.Name = "tbTelefonoVP"
        Me.tbTelefonoVP.ReadOnly = True
        Me.tbTelefonoVP.Size = New System.Drawing.Size(131, 23)
        Me.tbTelefonoVP.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(264, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 15)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Edad"
        '
        'tbEdadVP
        '
        Me.tbEdadVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdadVP.Location = New System.Drawing.Point(312, 128)
        Me.tbEdadVP.MaxLength = 2
        Me.tbEdadVP.Name = "tbEdadVP"
        Me.tbEdadVP.ReadOnly = True
        Me.tbEdadVP.Size = New System.Drawing.Size(83, 23)
        Me.tbEdadVP.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(8, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 15)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Teléfono"
        '
        'tbDireccionVP
        '
        Me.tbDireccionVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccionVP.Location = New System.Drawing.Point(71, 157)
        Me.tbDireccionVP.Name = "tbDireccionVP"
        Me.tbDireccionVP.ReadOnly = True
        Me.tbDireccionVP.Size = New System.Drawing.Size(324, 23)
        Me.tbDireccionVP.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(201, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 15)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Sexo"
        '
        'tbApellidoVP
        '
        Me.tbApellidoVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidoVP.Location = New System.Drawing.Point(264, 41)
        Me.tbApellidoVP.MaxLength = 50
        Me.tbApellidoVP.Name = "tbApellidoVP"
        Me.tbApellidoVP.ReadOnly = True
        Me.tbApellidoVP.Size = New System.Drawing.Size(131, 23)
        Me.tbApellidoVP.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(201, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Celular"
        '
        'tbNombresVP
        '
        Me.tbNombresVP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombresVP.Location = New System.Drawing.Point(70, 41)
        Me.tbNombresVP.MaxLength = 50
        Me.tbNombresVP.Name = "tbNombresVP"
        Me.tbNombresVP.ReadOnly = True
        Me.tbNombresVP.Size = New System.Drawing.Size(131, 23)
        Me.tbNombresVP.TabIndex = 30
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnListaEstudios)
        Me.Panel1.Controls.Add(Me.grbxSeleccionEstudio)
        Me.Panel1.Controls.Add(Me.grbxDatosAtencion)
        Me.Panel1.Controls.Add(Me.grbxDatosFactura)
        Me.Panel1.Controls.Add(Me.grbxDatosPersonales)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 661)
        Me.Panel1.TabIndex = 4
        '
        'pnListaEstudios
        '
        Me.pnListaEstudios.BackColor = System.Drawing.Color.LightGray
        Me.pnListaEstudios.Controls.Add(Me.grbDatosCategoria)
        Me.pnListaEstudios.Controls.Add(Me.gbEstudio)
        Me.pnListaEstudios.Controls.Add(Me.cbCampo)
        Me.pnListaEstudios.Controls.Add(Me.Label35)
        Me.pnListaEstudios.Controls.Add(Me.tbBuscar)
        Me.pnListaEstudios.Controls.Add(Me.gbListadoEstudios)
        Me.pnListaEstudios.Location = New System.Drawing.Point(8, 314)
        Me.pnListaEstudios.Name = "pnListaEstudios"
        Me.pnListaEstudios.Size = New System.Drawing.Size(681, 344)
        Me.pnListaEstudios.TabIndex = 34
        Me.pnListaEstudios.Visible = False
        '
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.lbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.lbCodigoCategoria)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(5, 5)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(345, 88)
        Me.grbDatosCategoria.TabIndex = 54
        Me.grbDatosCategoria.TabStop = False
        Me.grbDatosCategoria.Text = "Datos de Categoría"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(111, 57)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(224, 20)
        Me.tbCategoria.TabIndex = 29
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.Location = New System.Drawing.Point(17, 58)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lbCategoria.TabIndex = 27
        Me.lbCategoria.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(111, 29)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(224, 20)
        Me.tbCodigoCategoria.TabIndex = 26
        '
        'lbCodigoCategoria
        '
        Me.lbCodigoCategoria.AutoSize = True
        Me.lbCodigoCategoria.Location = New System.Drawing.Point(17, 32)
        Me.lbCodigoCategoria.Name = "lbCodigoCategoria"
        Me.lbCodigoCategoria.Size = New System.Drawing.Size(88, 13)
        Me.lbCodigoCategoria.TabIndex = 25
        Me.lbCodigoCategoria.Text = "Código Categoria"
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.lbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.lbCliente)
        Me.gbEstudio.Controls.Add(Me.tbCliente)
        Me.gbEstudio.Controls.Add(Me.lbPrecio)
        Me.gbEstudio.Controls.Add(Me.tbPrecio)
        Me.gbEstudio.Controls.Add(Me.lbNombreEstudio)
        Me.gbEstudio.Controls.Add(Me.tbNombreEstudio)
        Me.gbEstudio.Location = New System.Drawing.Point(356, 5)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(320, 135)
        Me.gbEstudio.TabIndex = 53
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Estudio"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(112, 27)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(199, 20)
        Me.tbCodigoEstudio.TabIndex = 22
        '
        'lbCodigoEstudio
        '
        Me.lbCodigoEstudio.AutoSize = True
        Me.lbCodigoEstudio.Location = New System.Drawing.Point(18, 30)
        Me.lbCodigoEstudio.Name = "lbCodigoEstudio"
        Me.lbCodigoEstudio.Size = New System.Drawing.Size(78, 13)
        Me.lbCodigoEstudio.TabIndex = 21
        Me.lbCodigoEstudio.Text = "Código Estudio"
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Location = New System.Drawing.Point(18, 109)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(39, 13)
        Me.lbCliente.TabIndex = 19
        Me.lbCliente.Text = "Cliente"
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(112, 106)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.ReadOnly = True
        Me.tbCliente.Size = New System.Drawing.Size(199, 20)
        Me.tbCliente.TabIndex = 18
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(18, 83)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lbPrecio.TabIndex = 17
        Me.lbPrecio.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(112, 80)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.ReadOnly = True
        Me.tbPrecio.Size = New System.Drawing.Size(199, 20)
        Me.tbPrecio.TabIndex = 16
        Me.tbPrecio.Text = "0"
        '
        'lbNombreEstudio
        '
        Me.lbNombreEstudio.AutoSize = True
        Me.lbNombreEstudio.Location = New System.Drawing.Point(18, 56)
        Me.lbNombreEstudio.Name = "lbNombreEstudio"
        Me.lbNombreEstudio.Size = New System.Drawing.Size(82, 13)
        Me.lbNombreEstudio.TabIndex = 2
        Me.lbNombreEstudio.Text = "Nombre Estudio"
        '
        'tbNombreEstudio
        '
        Me.tbNombreEstudio.Location = New System.Drawing.Point(112, 53)
        Me.tbNombreEstudio.Name = "tbNombreEstudio"
        Me.tbNombreEstudio.ReadOnly = True
        Me.tbNombreEstudio.Size = New System.Drawing.Size(199, 20)
        Me.tbNombreEstudio.TabIndex = 0
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"entidad", "codigo_categoria", "codigo_estudio", "nombre_categoria", "estudio"})
        Me.cbCampo.Location = New System.Drawing.Point(57, 97)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(123, 21)
        Me.cbCampo.TabIndex = 52
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(11, 100)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(186, 97)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(154, 20)
        Me.tbBuscar.TabIndex = 50
        '
        'gbListadoEstudios
        '
        Me.gbListadoEstudios.Controls.Add(Me.tbIDLista)
        Me.gbListadoEstudios.Controls.Add(Me.lknInexistente)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDPrecio)
        Me.gbListadoEstudios.Controls.Add(Me.dgvListado)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDEstudio)
        Me.gbListadoEstudios.Location = New System.Drawing.Point(7, 137)
        Me.gbListadoEstudios.Name = "gbListadoEstudios"
        Me.gbListadoEstudios.Size = New System.Drawing.Size(669, 203)
        Me.gbListadoEstudios.TabIndex = 49
        Me.gbListadoEstudios.TabStop = False
        Me.gbListadoEstudios.Text = "Listado de Estudios"
        '
        'tbIDLista
        '
        Me.tbIDLista.Enabled = False
        Me.tbIDLista.Location = New System.Drawing.Point(344, 293)
        Me.tbIDLista.Name = "tbIDLista"
        Me.tbIDLista.Size = New System.Drawing.Size(100, 20)
        Me.tbIDLista.TabIndex = 43
        Me.tbIDLista.Visible = False
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(291, 107)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(94, 13)
        Me.lknInexistente.TabIndex = 1
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "Datos Inexistentes"
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Enabled = False
        Me.tbIDPrecio.Location = New System.Drawing.Point(696, 293)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDPrecio.TabIndex = 42
        Me.tbIDPrecio.Visible = False
        '
        'dgvListado
        '
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(3, 19)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(663, 178)
        Me.dgvListado.TabIndex = 0
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = False
        Me.tbIDEstudio.Location = New System.Drawing.Point(-8, 293)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEstudio.TabIndex = 38
        Me.tbIDEstudio.Visible = False
        '
        'grbxSeleccionEstudio
        '
        Me.grbxSeleccionEstudio.Controls.Add(Me.btnInsertarEstudios)
        Me.grbxSeleccionEstudio.Controls.Add(Me.tbIDEstudio2)
        Me.grbxSeleccionEstudio.Controls.Add(Me.lbEstudio)
        Me.grbxSeleccionEstudio.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxSeleccionEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grbxSeleccionEstudio.Location = New System.Drawing.Point(8, 257)
        Me.grbxSeleccionEstudio.Name = "grbxSeleccionEstudio"
        Me.grbxSeleccionEstudio.Size = New System.Drawing.Size(681, 51)
        Me.grbxSeleccionEstudio.TabIndex = 33
        Me.grbxSeleccionEstudio.TabStop = False
        Me.grbxSeleccionEstudio.Text = "SELECCIONAR ESTUDIOS"
        '
        'btnInsertarEstudios
        '
        Me.btnInsertarEstudios.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarEstudios.Location = New System.Drawing.Point(586, 10)
        Me.btnInsertarEstudios.Name = "btnInsertarEstudios"
        Me.btnInsertarEstudios.Size = New System.Drawing.Size(80, 38)
        Me.btnInsertarEstudios.TabIndex = 0
        Me.btnInsertarEstudios.Text = "Insertar Estudios"
        Me.btnInsertarEstudios.UseVisualStyleBackColor = True
        '
        'tbIDEstudio2
        '
        Me.tbIDEstudio2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIDEstudio2.Location = New System.Drawing.Point(74, 20)
        Me.tbIDEstudio2.MaxLength = 50
        Me.tbIDEstudio2.Name = "tbIDEstudio2"
        Me.tbIDEstudio2.Size = New System.Drawing.Size(64, 23)
        Me.tbIDEstudio2.TabIndex = 53
        '
        'lbEstudio
        '
        Me.lbEstudio.AutoSize = True
        Me.lbEstudio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbEstudio.Location = New System.Drawing.Point(6, 24)
        Me.lbEstudio.Name = "lbEstudio"
        Me.lbEstudio.Size = New System.Drawing.Size(47, 15)
        Me.lbEstudio.TabIndex = 52
        Me.lbEstudio.Text = "Estudio"
        '
        'grbxDatosAtencion
        '
        Me.grbxDatosAtencion.Controls.Add(Me.btnDatosAtencion)
        Me.grbxDatosAtencion.Controls.Add(Me.dtpFechaAtencion)
        Me.grbxDatosAtencion.Controls.Add(Me.lbMedicoRemit)
        Me.grbxDatosAtencion.Controls.Add(Me.tbMedicoRemitente)
        Me.grbxDatosAtencion.Controls.Add(Me.lbFechaEstudio)
        Me.grbxDatosAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxDatosAtencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grbxDatosAtencion.Location = New System.Drawing.Point(369, 163)
        Me.grbxDatosAtencion.Name = "grbxDatosAtencion"
        Me.grbxDatosAtencion.Size = New System.Drawing.Size(320, 83)
        Me.grbxDatosAtencion.TabIndex = 32
        Me.grbxDatosAtencion.TabStop = False
        Me.grbxDatosAtencion.Text = "DATOS DE ATENCION"
        '
        'btnDatosAtencion
        '
        Me.btnDatosAtencion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatosAtencion.Location = New System.Drawing.Point(0, 0)
        Me.btnDatosAtencion.Name = "btnDatosAtencion"
        Me.btnDatosAtencion.Size = New System.Drawing.Size(320, 83)
        Me.btnDatosAtencion.TabIndex = 0
        Me.btnDatosAtencion.Text = "DATOS DE ATENCIÓN"
        Me.btnDatosAtencion.UseVisualStyleBackColor = True
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(128, 51)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(177, 23)
        Me.dtpFechaAtencion.TabIndex = 41
        '
        'lbMedicoRemit
        '
        Me.lbMedicoRemit.AutoSize = True
        Me.lbMedicoRemit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMedicoRemit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbMedicoRemit.Location = New System.Drawing.Point(6, 25)
        Me.lbMedicoRemit.Name = "lbMedicoRemit"
        Me.lbMedicoRemit.Size = New System.Drawing.Size(109, 15)
        Me.lbMedicoRemit.TabIndex = 38
        Me.lbMedicoRemit.Text = "Medico Remitente"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(128, 22)
        Me.tbMedicoRemitente.MaxLength = 50
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(177, 23)
        Me.tbMedicoRemitente.TabIndex = 37
        '
        'lbFechaEstudio
        '
        Me.lbFechaEstudio.AutoSize = True
        Me.lbFechaEstudio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbFechaEstudio.Location = New System.Drawing.Point(7, 57)
        Me.lbFechaEstudio.Name = "lbFechaEstudio"
        Me.lbFechaEstudio.Size = New System.Drawing.Size(81, 15)
        Me.lbFechaEstudio.TabIndex = 36
        Me.lbFechaEstudio.Text = "Fecha Estudio"
        '
        'grbxDatosFactura
        '
        Me.grbxDatosFactura.Controls.Add(Me.tbNIT)
        Me.grbxDatosFactura.Controls.Add(Me.tbRazonSocial)
        Me.grbxDatosFactura.Controls.Add(Me.tbInstitucion)
        Me.grbxDatosFactura.Controls.Add(Me.tbCodigoAsegurado)
        Me.grbxDatosFactura.Controls.Add(Me.lbNit)
        Me.grbxDatosFactura.Controls.Add(Me.lbRazonSocial)
        Me.grbxDatosFactura.Controls.Add(Me.lbInstitucion)
        Me.grbxDatosFactura.Controls.Add(Me.lbCodigoAsegurado)
        Me.grbxDatosFactura.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxDatosFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grbxDatosFactura.Location = New System.Drawing.Point(369, 12)
        Me.grbxDatosFactura.Name = "grbxDatosFactura"
        Me.grbxDatosFactura.Size = New System.Drawing.Size(320, 145)
        Me.grbxDatosFactura.TabIndex = 31
        Me.grbxDatosFactura.TabStop = False
        Me.grbxDatosFactura.Text = "DATOS PARA FACTURA"
        '
        'tbNIT
        '
        Me.tbNIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbNIT.Location = New System.Drawing.Point(128, 111)
        Me.tbNIT.MaxLength = 20
        Me.tbNIT.Name = "tbNIT"
        Me.tbNIT.Size = New System.Drawing.Size(177, 23)
        Me.tbNIT.TabIndex = 3
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbRazonSocial.Location = New System.Drawing.Point(128, 82)
        Me.tbRazonSocial.MaxLength = 100
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(177, 23)
        Me.tbRazonSocial.TabIndex = 2
        '
        'tbInstitucion
        '
        Me.tbInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbInstitucion.Location = New System.Drawing.Point(128, 53)
        Me.tbInstitucion.MaxLength = 50
        Me.tbInstitucion.Name = "tbInstitucion"
        Me.tbInstitucion.Size = New System.Drawing.Size(177, 23)
        Me.tbInstitucion.TabIndex = 1
        '
        'tbCodigoAsegurado
        '
        Me.tbCodigoAsegurado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbCodigoAsegurado.Location = New System.Drawing.Point(128, 24)
        Me.tbCodigoAsegurado.MaxLength = 50
        Me.tbCodigoAsegurado.Name = "tbCodigoAsegurado"
        Me.tbCodigoAsegurado.Size = New System.Drawing.Size(177, 23)
        Me.tbCodigoAsegurado.TabIndex = 0
        '
        'lbNit
        '
        Me.lbNit.AutoSize = True
        Me.lbNit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbNit.Location = New System.Drawing.Point(6, 114)
        Me.lbNit.Name = "lbNit"
        Me.lbNit.Size = New System.Drawing.Size(25, 15)
        Me.lbNit.TabIndex = 3
        Me.lbNit.Text = "NIT"
        '
        'lbRazonSocial
        '
        Me.lbRazonSocial.AutoSize = True
        Me.lbRazonSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbRazonSocial.Location = New System.Drawing.Point(7, 85)
        Me.lbRazonSocial.Name = "lbRazonSocial"
        Me.lbRazonSocial.Size = New System.Drawing.Size(72, 15)
        Me.lbRazonSocial.TabIndex = 2
        Me.lbRazonSocial.Text = "Razón Social"
        '
        'lbInstitucion
        '
        Me.lbInstitucion.AutoSize = True
        Me.lbInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbInstitucion.Location = New System.Drawing.Point(7, 56)
        Me.lbInstitucion.Name = "lbInstitucion"
        Me.lbInstitucion.Size = New System.Drawing.Size(64, 15)
        Me.lbInstitucion.TabIndex = 1
        Me.lbInstitucion.Text = "Institución"
        '
        'lbCodigoAsegurado
        '
        Me.lbCodigoAsegurado.AutoSize = True
        Me.lbCodigoAsegurado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigoAsegurado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbCodigoAsegurado.Location = New System.Drawing.Point(6, 27)
        Me.lbCodigoAsegurado.Name = "lbCodigoAsegurado"
        Me.lbCodigoAsegurado.Size = New System.Drawing.Size(122, 15)
        Me.lbCodigoAsegurado.TabIndex = 0
        Me.lbCodigoAsegurado.Text = "Codigo de Asegurado"
        '
        'grbxDatosPersonales
        '
        Me.grbxDatosPersonales.Controls.Add(Me.lbci)
        Me.grbxDatosPersonales.Controls.Add(Me.tbci)
        Me.grbxDatosPersonales.Controls.Add(Me.dtpFechaNacimiento)
        Me.grbxDatosPersonales.Controls.Add(Me.cbSexo)
        Me.grbxDatosPersonales.Controls.Add(Me.tbCelular)
        Me.grbxDatosPersonales.Controls.Add(Me.tbTelefono)
        Me.grbxDatosPersonales.Controls.Add(Me.tbEdad)
        Me.grbxDatosPersonales.Controls.Add(Me.tbDireccion)
        Me.grbxDatosPersonales.Controls.Add(Me.tbApellidos)
        Me.grbxDatosPersonales.Controls.Add(Me.tbNombres)
        Me.grbxDatosPersonales.Controls.Add(Me.lbCelular)
        Me.grbxDatosPersonales.Controls.Add(Me.lbSexo)
        Me.grbxDatosPersonales.Controls.Add(Me.lbTelefono)
        Me.grbxDatosPersonales.Controls.Add(Me.lbEdad)
        Me.grbxDatosPersonales.Controls.Add(Me.lbDireccion)
        Me.grbxDatosPersonales.Controls.Add(Me.lbFechaNacimiento)
        Me.grbxDatosPersonales.Controls.Add(Me.lblbApellidoCliente)
        Me.grbxDatosPersonales.Controls.Add(Me.lbNombreCliente)
        Me.grbxDatosPersonales.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxDatosPersonales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grbxDatosPersonales.Location = New System.Drawing.Point(8, 12)
        Me.grbxDatosPersonales.Name = "grbxDatosPersonales"
        Me.grbxDatosPersonales.Size = New System.Drawing.Size(355, 234)
        Me.grbxDatosPersonales.TabIndex = 30
        Me.grbxDatosPersonales.TabStop = False
        Me.grbxDatosPersonales.Text = "DATOS PERSONALES"
        '
        'lbci
        '
        Me.lbci.AutoSize = True
        Me.lbci.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbci.Location = New System.Drawing.Point(13, 146)
        Me.lbci.Name = "lbci"
        Me.lbci.Size = New System.Drawing.Size(17, 15)
        Me.lbci.TabIndex = 19
        Me.lbci.Text = "CI"
        '
        'tbci
        '
        Me.tbci.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbci.Location = New System.Drawing.Point(123, 143)
        Me.tbci.Name = "tbci"
        Me.tbci.Size = New System.Drawing.Size(216, 23)
        Me.tbci.TabIndex = 4
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(139, 85)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaNacimiento.TabIndex = 2
        '
        'cbSexo
        '
        Me.cbSexo.AutoCompleteCustomSource.AddRange(New String() {"Femenino", "Masculino"})
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(248, 170)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(91, 23)
        Me.cbSexo.TabIndex = 5
        '
        'tbCelular
        '
        Me.tbCelular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCelular.Location = New System.Drawing.Point(248, 201)
        Me.tbCelular.MaxLength = 8
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(91, 23)
        Me.tbCelular.TabIndex = 7
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(88, 201)
        Me.tbTelefono.MaxLength = 9
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(91, 23)
        Me.tbTelefono.TabIndex = 6
        '
        'tbEdad
        '
        Me.tbEdad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdad.Location = New System.Drawing.Point(88, 172)
        Me.tbEdad.MaxLength = 2
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.ReadOnly = True
        Me.tbEdad.Size = New System.Drawing.Size(91, 23)
        Me.tbEdad.TabIndex = 20
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(123, 114)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(216, 23)
        Me.tbDireccion.TabIndex = 3
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(123, 56)
        Me.tbApellidos.MaxLength = 50
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(216, 23)
        Me.tbApellidos.TabIndex = 1
        '
        'tbNombres
        '
        Me.tbNombres.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombres.Location = New System.Drawing.Point(123, 27)
        Me.tbNombres.MaxLength = 50
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(216, 23)
        Me.tbNombres.TabIndex = 0
        '
        'lbCelular
        '
        Me.lbCelular.AutoSize = True
        Me.lbCelular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbCelular.Location = New System.Drawing.Point(197, 204)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.Size = New System.Drawing.Size(45, 15)
        Me.lbCelular.TabIndex = 7
        Me.lbCelular.Text = "Celular"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbSexo.Location = New System.Drawing.Point(197, 175)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(33, 15)
        Me.lbSexo.TabIndex = 6
        Me.lbSexo.Text = "Sexo"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbTelefono.Location = New System.Drawing.Point(12, 204)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(54, 15)
        Me.lbTelefono.TabIndex = 5
        Me.lbTelefono.Text = "Teléfono"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbEdad.Location = New System.Drawing.Point(12, 175)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(33, 15)
        Me.lbEdad.TabIndex = 4
        Me.lbEdad.Text = "Edad"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbDireccion.Location = New System.Drawing.Point(12, 117)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(57, 15)
        Me.lbDireccion.TabIndex = 3
        Me.lbDireccion.Text = "Dirección"
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(12, 91)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(121, 15)
        Me.lbFechaNacimiento.TabIndex = 2
        Me.lbFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'lblbApellidoCliente
        '
        Me.lblbApellidoCliente.AutoSize = True
        Me.lblbApellidoCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblbApellidoCliente.Location = New System.Drawing.Point(12, 59)
        Me.lblbApellidoCliente.Name = "lblbApellidoCliente"
        Me.lblbApellidoCliente.Size = New System.Drawing.Size(57, 15)
        Me.lblbApellidoCliente.TabIndex = 1
        Me.lblbApellidoCliente.Text = "Apellidos"
        '
        'lbNombreCliente
        '
        Me.lbNombreCliente.AutoSize = True
        Me.lbNombreCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbNombreCliente.Location = New System.Drawing.Point(12, 30)
        Me.lbNombreCliente.Name = "lbNombreCliente"
        Me.lbNombreCliente.Size = New System.Drawing.Size(58, 15)
        Me.lbNombreCliente.TabIndex = 0
        Me.lbNombreCliente.Text = "Nombres"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'frmCentral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grbxVIstaPrevia)
        Me.Name = "frmCentral"
        Me.Text = "ATENCIÓN DE PACIENTES"
        Me.grbxVIstaPrevia.ResumeLayout(False)
        Me.grbxVIstaPrevia.PerformLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnListaEstudios.ResumeLayout(False)
        Me.pnListaEstudios.PerformLayout()
        Me.grbDatosCategoria.ResumeLayout(False)
        Me.grbDatosCategoria.PerformLayout()
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.gbListadoEstudios.ResumeLayout(False)
        Me.gbListadoEstudios.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxSeleccionEstudio.ResumeLayout(False)
        Me.grbxSeleccionEstudio.PerformLayout()
        Me.grbxDatosAtencion.ResumeLayout(False)
        Me.grbxDatosAtencion.PerformLayout()
        Me.grbxDatosFactura.ResumeLayout(False)
        Me.grbxDatosFactura.PerformLayout()
        Me.grbxDatosPersonales.ResumeLayout(False)
        Me.grbxDatosPersonales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbFechaEstudioVP As TextBox
    Friend WithEvents tbFechaNacimientoVP As TextBox
    Friend WithEvents grbxVIstaPrevia As GroupBox
    Friend WithEvents tbSexoVP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tbMedicoRemitenteVP As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbCiVP As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tbCelularVP As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbTelefonoVP As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbEdadVP As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbDireccionVP As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbApellidoVP As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbNombresVP As TextBox
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnListaEstudios As Panel
    Friend WithEvents grbxSeleccionEstudio As GroupBox
    Friend WithEvents btnInsertarEstudios As Button
    Friend WithEvents tbIDEstudio2 As TextBox
    Friend WithEvents lbEstudio As Label
    Friend WithEvents grbxDatosAtencion As GroupBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents lbMedicoRemit As Label
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents lbFechaEstudio As Label
    Friend WithEvents grbxDatosFactura As GroupBox
    Friend WithEvents tbNIT As TextBox
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents tbInstitucion As TextBox
    Friend WithEvents tbCodigoAsegurado As TextBox
    Friend WithEvents lbNit As Label
    Friend WithEvents lbRazonSocial As Label
    Friend WithEvents lbInstitucion As Label
    Friend WithEvents lbCodigoAsegurado As Label
    Friend WithEvents grbxDatosPersonales As GroupBox
    Friend WithEvents lbci As Label
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents tbci As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents lbCelular As Label
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbDireccion As Label
    Friend WithEvents lbFechaNacimiento As Label
    Friend WithEvents lblbApellidoCliente As Label
    Friend WithEvents lbNombreCliente As Label
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents lbCategoria As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents lbCodigoCategoria As Label
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents lbCodigoEstudio As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents lbPrecio As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents lbNombreEstudio As Label
    Friend WithEvents tbNombreEstudio As TextBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents gbListadoEstudios As GroupBox
    Friend WithEvents tbIDLista As TextBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents tbPrecioParcial As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents tbIDEntidad As TextBox
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents tbIDDetalle As TextBox
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents id_entidad As DataGridViewTextBoxColumn
    Friend WithEvents id_estudio As DataGridViewTextBoxColumn
    Friend WithEvents id_pecio As DataGridViewTextBoxColumn
    Friend WithEvents entidad As DataGridViewTextBoxColumn
    Friend WithEvents codigo_categoria As DataGridViewTextBoxColumn
    Friend WithEvents nombre_categoria As DataGridViewTextBoxColumn
    Friend WithEvents codigo_estudio As DataGridViewTextBoxColumn
    Friend WithEvents estudio As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnDatosAtencion As Button
End Class
