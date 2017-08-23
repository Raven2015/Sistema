<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grbxDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.lbci = New System.Windows.Forms.Label()
        Me.tbci = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.tbCodigoAsegurado = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.lbCodigoAsegurado = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.lbCelular = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblbApellidoCliente = New System.Windows.Forms.Label()
        Me.lbNombreCliente = New System.Windows.Forms.Label()
        Me.grbxDatosFactura = New System.Windows.Forms.GroupBox()
        Me.cbxInstitucion = New System.Windows.Forms.TextBox()
        Me.tbNIT = New System.Windows.Forms.TextBox()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.lbNit = New System.Windows.Forms.Label()
        Me.lbRazonSocial = New System.Windows.Forms.Label()
        Me.lbInstitucion = New System.Windows.Forms.Label()
        Me.btnDatosAtencion = New System.Windows.Forms.Button()
        Me.pnDatosPaciente = New System.Windows.Forms.Panel()
        Me.tbInstitucion = New System.Windows.Forms.TextBox()
        Me.pnDatosAtencion = New System.Windows.Forms.Panel()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.grbxDatosAtencion = New System.Windows.Forms.GroupBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.TextBox()
        Me.cbxMedicoDestinatario = New System.Windows.Forms.ComboBox()
        Me.MedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreliminarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreliminar = New SistemaRecepcion.dsPreliminar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMedicoRemit = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.lbFechaEstudio = New System.Windows.Forms.Label()
        Me.pnListaEstudios = New System.Windows.Forms.Panel()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.lbIDAtencion = New System.Windows.Forms.Label()
        Me.tbPrecioParcial = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.lbCodigoCategoria = New System.Windows.Forms.Label()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.lbCodigoEstudio = New System.Windows.Forms.Label()
        Me.lbNombreEstudio = New System.Windows.Forms.Label()
        Me.tbNombreEstudio = New System.Windows.Forms.TextBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.gbListadoEstudios = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbIdUsuario = New System.Windows.Forms.TextBox()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.tbIDCliente = New System.Windows.Forms.TextBox()
        Me.tbIDDetalle = New System.Windows.Forms.TextBox()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.id_entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_atencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbIDLista = New System.Windows.Forms.TextBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MedicoTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.medicoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.grbxDatosPersonales.SuspendLayout
        Me.grbxDatosFactura.SuspendLayout
        Me.pnDatosPaciente.SuspendLayout
        Me.pnDatosAtencion.SuspendLayout
        Me.grbxDatosAtencion.SuspendLayout
        CType(Me.MedicoBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsPreliminarBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsPreliminar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnListaEstudios.SuspendLayout
        Me.grbDatosCategoria.SuspendLayout
        Me.gbEstudio.SuspendLayout
        Me.gbListadoEstudios.SuspendLayout
        CType(Me.dgvListadoAtenciones,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvListado,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.errorIcono,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'grbxDatosPersonales
        '
        Me.grbxDatosPersonales.Controls.Add(Me.lbci)
        Me.grbxDatosPersonales.Controls.Add(Me.tbci)
        Me.grbxDatosPersonales.Controls.Add(Me.dtpFechaNacimiento)
        Me.grbxDatosPersonales.Controls.Add(Me.tbCodigoAsegurado)
        Me.grbxDatosPersonales.Controls.Add(Me.cbSexo)
        Me.grbxDatosPersonales.Controls.Add(Me.tbCelular)
        Me.grbxDatosPersonales.Controls.Add(Me.tbEdad)
        Me.grbxDatosPersonales.Controls.Add(Me.lbCodigoAsegurado)
        Me.grbxDatosPersonales.Controls.Add(Me.tbDireccion)
        Me.grbxDatosPersonales.Controls.Add(Me.tbApellidos)
        Me.grbxDatosPersonales.Controls.Add(Me.tbNombres)
        Me.grbxDatosPersonales.Controls.Add(Me.lbCelular)
        Me.grbxDatosPersonales.Controls.Add(Me.lbSexo)
        Me.grbxDatosPersonales.Controls.Add(Me.lbEdad)
        Me.grbxDatosPersonales.Controls.Add(Me.lbDireccion)
        Me.grbxDatosPersonales.Controls.Add(Me.lbFechaNacimiento)
        Me.grbxDatosPersonales.Controls.Add(Me.lblbApellidoCliente)
        Me.grbxDatosPersonales.Controls.Add(Me.lbNombreCliente)
        Me.grbxDatosPersonales.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grbxDatosPersonales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.grbxDatosPersonales.Location = New System.Drawing.Point(7, 3)
        Me.grbxDatosPersonales.Name = "grbxDatosPersonales"
        Me.grbxDatosPersonales.Size = New System.Drawing.Size(355, 234)
        Me.grbxDatosPersonales.TabIndex = 31
        Me.grbxDatosPersonales.TabStop = false
        Me.grbxDatosPersonales.Text = "DATOS PERSONALES"
        '
        'lbci
        '
        Me.lbci.AutoSize = true
        Me.lbci.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbci.Location = New System.Drawing.Point(13, 146)
        Me.lbci.Name = "lbci"
        Me.lbci.Size = New System.Drawing.Size(17, 15)
        Me.lbci.TabIndex = 19
        Me.lbci.Text = "CI"
        '
        'tbci
        '
        Me.tbci.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbci.Location = New System.Drawing.Point(123, 143)
        Me.tbci.Name = "tbci"
        Me.tbci.Size = New System.Drawing.Size(216, 23)
        Me.tbci.TabIndex = 4
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(139, 85)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaNacimiento.TabIndex = 2
        '
        'tbCodigoAsegurado
        '
        Me.tbCodigoAsegurado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbCodigoAsegurado.Location = New System.Drawing.Point(139, 114)
        Me.tbCodigoAsegurado.MaxLength = 50
        Me.tbCodigoAsegurado.Name = "tbCodigoAsegurado"
        Me.tbCodigoAsegurado.Size = New System.Drawing.Size(200, 23)
        Me.tbCodigoAsegurado.TabIndex = 0
        '
        'cbSexo
        '
        Me.cbSexo.AutoCompleteCustomSource.AddRange(New String() {"Femenino", "Masculino"})
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbSexo.FormattingEnabled = true
        Me.cbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(248, 172)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(91, 23)
        Me.cbSexo.TabIndex = 5
        '
        'tbCelular
        '
        Me.tbCelular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbCelular.Location = New System.Drawing.Point(123, 201)
        Me.tbCelular.MaxLength = 8
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(216, 23)
        Me.tbCelular.TabIndex = 7
        '
        'tbEdad
        '
        Me.tbEdad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbEdad.Location = New System.Drawing.Point(88, 172)
        Me.tbEdad.MaxLength = 2
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.ReadOnly = true
        Me.tbEdad.Size = New System.Drawing.Size(91, 23)
        Me.tbEdad.TabIndex = 20
        '
        'lbCodigoAsegurado
        '
        Me.lbCodigoAsegurado.AutoSize = true
        Me.lbCodigoAsegurado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCodigoAsegurado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbCodigoAsegurado.Location = New System.Drawing.Point(11, 119)
        Me.lbCodigoAsegurado.Name = "lbCodigoAsegurado"
        Me.lbCodigoAsegurado.Size = New System.Drawing.Size(124, 15)
        Me.lbCodigoAsegurado.TabIndex = 0
        Me.lbCodigoAsegurado.Text = "Número de Matrícula"
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(123, 114)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(216, 23)
        Me.tbDireccion.TabIndex = 3
        Me.tbDireccion.Visible = false
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(123, 56)
        Me.tbApellidos.MaxLength = 50
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(216, 23)
        Me.tbApellidos.TabIndex = 1
        '
        'tbNombres
        '
        Me.tbNombres.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbNombres.Location = New System.Drawing.Point(123, 27)
        Me.tbNombres.MaxLength = 50
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(216, 23)
        Me.tbNombres.TabIndex = 0
        '
        'lbCelular
        '
        Me.lbCelular.AutoSize = true
        Me.lbCelular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbCelular.Location = New System.Drawing.Point(11, 204)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.Size = New System.Drawing.Size(98, 15)
        Me.lbCelular.TabIndex = 7
        Me.lbCelular.Text = "Teléfono/Celular"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = true
        Me.lbSexo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbSexo.Location = New System.Drawing.Point(197, 176)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(33, 15)
        Me.lbSexo.TabIndex = 6
        Me.lbSexo.Text = "Sexo"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = true
        Me.lbEdad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbEdad.Location = New System.Drawing.Point(12, 176)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(33, 15)
        Me.lbEdad.TabIndex = 4
        Me.lbEdad.Text = "Edad"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = true
        Me.lbDireccion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbDireccion.Location = New System.Drawing.Point(12, 117)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(57, 15)
        Me.lbDireccion.TabIndex = 3
        Me.lbDireccion.Text = "Dirección"
        Me.lbDireccion.Visible = false
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = true
        Me.lbFechaNacimiento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(12, 91)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(121, 15)
        Me.lbFechaNacimiento.TabIndex = 2
        Me.lbFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'lblbApellidoCliente
        '
        Me.lblbApellidoCliente.AutoSize = true
        Me.lblbApellidoCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblbApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lblbApellidoCliente.Location = New System.Drawing.Point(12, 59)
        Me.lblbApellidoCliente.Name = "lblbApellidoCliente"
        Me.lblbApellidoCliente.Size = New System.Drawing.Size(57, 15)
        Me.lblbApellidoCliente.TabIndex = 1
        Me.lblbApellidoCliente.Text = "Apellidos"
        '
        'lbNombreCliente
        '
        Me.lbNombreCliente.AutoSize = true
        Me.lbNombreCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbNombreCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbNombreCliente.Location = New System.Drawing.Point(12, 30)
        Me.lbNombreCliente.Name = "lbNombreCliente"
        Me.lbNombreCliente.Size = New System.Drawing.Size(58, 15)
        Me.lbNombreCliente.TabIndex = 0
        Me.lbNombreCliente.Text = "Nombres"
        '
        'grbxDatosFactura
        '
        Me.grbxDatosFactura.Controls.Add(Me.cbxInstitucion)
        Me.grbxDatosFactura.Controls.Add(Me.tbNIT)
        Me.grbxDatosFactura.Controls.Add(Me.tbRazonSocial)
        Me.grbxDatosFactura.Controls.Add(Me.lbNit)
        Me.grbxDatosFactura.Controls.Add(Me.lbRazonSocial)
        Me.grbxDatosFactura.Controls.Add(Me.lbInstitucion)
        Me.grbxDatosFactura.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grbxDatosFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.grbxDatosFactura.Location = New System.Drawing.Point(7, 243)
        Me.grbxDatosFactura.Name = "grbxDatosFactura"
        Me.grbxDatosFactura.Size = New System.Drawing.Size(355, 108)
        Me.grbxDatosFactura.TabIndex = 32
        Me.grbxDatosFactura.TabStop = false
        Me.grbxDatosFactura.Text = "DATOS PARA FACTURA"
        '
        'cbxInstitucion
        '
        Me.cbxInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbxInstitucion.Location = New System.Drawing.Point(134, 83)
        Me.cbxInstitucion.MaxLength = 20
        Me.cbxInstitucion.Name = "cbxInstitucion"
        Me.cbxInstitucion.ReadOnly = true
        Me.cbxInstitucion.Size = New System.Drawing.Size(205, 23)
        Me.cbxInstitucion.TabIndex = 5
        Me.cbxInstitucion.Text = "PROMES"
        '
        'tbNIT
        '
        Me.tbNIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbNIT.Location = New System.Drawing.Point(134, 57)
        Me.tbNIT.MaxLength = 20
        Me.tbNIT.Name = "tbNIT"
        Me.tbNIT.Size = New System.Drawing.Size(205, 23)
        Me.tbNIT.TabIndex = 3
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbRazonSocial.Location = New System.Drawing.Point(134, 31)
        Me.tbRazonSocial.MaxLength = 100
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(205, 23)
        Me.tbRazonSocial.TabIndex = 2
        '
        'lbNit
        '
        Me.lbNit.AutoSize = true
        Me.lbNit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbNit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbNit.Location = New System.Drawing.Point(12, 60)
        Me.lbNit.Name = "lbNit"
        Me.lbNit.Size = New System.Drawing.Size(25, 15)
        Me.lbNit.TabIndex = 3
        Me.lbNit.Text = "NIT"
        '
        'lbRazonSocial
        '
        Me.lbRazonSocial.AutoSize = true
        Me.lbRazonSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbRazonSocial.Location = New System.Drawing.Point(13, 34)
        Me.lbRazonSocial.Name = "lbRazonSocial"
        Me.lbRazonSocial.Size = New System.Drawing.Size(72, 15)
        Me.lbRazonSocial.TabIndex = 2
        Me.lbRazonSocial.Text = "Razón Social"
        '
        'lbInstitucion
        '
        Me.lbInstitucion.AutoSize = true
        Me.lbInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbInstitucion.Location = New System.Drawing.Point(13, 86)
        Me.lbInstitucion.Name = "lbInstitucion"
        Me.lbInstitucion.Size = New System.Drawing.Size(64, 15)
        Me.lbInstitucion.TabIndex = 1
        Me.lbInstitucion.Text = "Institución"
        Me.lbInstitucion.Visible = false
        '
        'btnDatosAtencion
        '
        Me.btnDatosAtencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnDatosAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatosAtencion.ForeColor = System.Drawing.Color.White
        Me.btnDatosAtencion.Location = New System.Drawing.Point(7, 360)
        Me.btnDatosAtencion.Name = "btnDatosAtencion"
        Me.btnDatosAtencion.Size = New System.Drawing.Size(355, 30)
        Me.btnDatosAtencion.TabIndex = 33
        Me.btnDatosAtencion.Text = "SIGUIENTE"
        Me.btnDatosAtencion.UseVisualStyleBackColor = false
        '
        'pnDatosPaciente
        '
        Me.pnDatosPaciente.BackColor = System.Drawing.Color.White
        Me.pnDatosPaciente.Controls.Add(Me.tbInstitucion)
        Me.pnDatosPaciente.Controls.Add(Me.grbxDatosPersonales)
        Me.pnDatosPaciente.Controls.Add(Me.btnDatosAtencion)
        Me.pnDatosPaciente.Controls.Add(Me.grbxDatosFactura)
        Me.pnDatosPaciente.Location = New System.Drawing.Point(12, 32)
        Me.pnDatosPaciente.Name = "pnDatosPaciente"
        Me.pnDatosPaciente.Size = New System.Drawing.Size(370, 402)
        Me.pnDatosPaciente.TabIndex = 34
        '
        'tbInstitucion
        '
        Me.tbInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbInstitucion.Location = New System.Drawing.Point(0, -15)
        Me.tbInstitucion.MaxLength = 100
        Me.tbInstitucion.Name = "tbInstitucion"
        Me.tbInstitucion.ReadOnly = true
        Me.tbInstitucion.Size = New System.Drawing.Size(58, 23)
        Me.tbInstitucion.TabIndex = 36
        Me.tbInstitucion.Visible = false
        '
        'pnDatosAtencion
        '
        Me.pnDatosAtencion.BackColor = System.Drawing.Color.White
        Me.pnDatosAtencion.Controls.Add(Me.btnDetalle)
        Me.pnDatosAtencion.Controls.Add(Me.grbxDatosAtencion)
        Me.pnDatosAtencion.Location = New System.Drawing.Point(12, 32)
        Me.pnDatosAtencion.Name = "pnDatosAtencion"
        Me.pnDatosAtencion.Size = New System.Drawing.Size(406, 407)
        Me.pnDatosAtencion.TabIndex = 35
        Me.pnDatosAtencion.Visible = false
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.ForeColor = System.Drawing.Color.White
        Me.btnDetalle.Location = New System.Drawing.Point(6, 360)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(375, 30)
        Me.btnDetalle.TabIndex = 34
        Me.btnDetalle.Text = "SIGUIENTE"
        Me.btnDetalle.UseVisualStyleBackColor = false
        '
        'grbxDatosAtencion
        '
        Me.grbxDatosAtencion.Controls.Add(Me.dtpFechaAtencion)
        Me.grbxDatosAtencion.Controls.Add(Me.cbxMedicoDestinatario)
        Me.grbxDatosAtencion.Controls.Add(Me.Label1)
        Me.grbxDatosAtencion.Controls.Add(Me.lbMedicoRemit)
        Me.grbxDatosAtencion.Controls.Add(Me.tbMedicoRemitente)
        Me.grbxDatosAtencion.Controls.Add(Me.lbFechaEstudio)
        Me.grbxDatosAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grbxDatosAtencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.grbxDatosAtencion.Location = New System.Drawing.Point(11, 8)
        Me.grbxDatosAtencion.Name = "grbxDatosAtencion"
        Me.grbxDatosAtencion.Size = New System.Drawing.Size(378, 117)
        Me.grbxDatosAtencion.TabIndex = 33
        Me.grbxDatosAtencion.TabStop = false
        Me.grbxDatosAtencion.Text = "DATOS DE ATENCION"
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(148, 50)
        Me.dtpFechaAtencion.MaxLength = 50
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.ReadOnly = true
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(217, 23)
        Me.dtpFechaAtencion.TabIndex = 38
        '
        'cbxMedicoDestinatario
        '
        Me.cbxMedicoDestinatario.AutoCompleteCustomSource.AddRange(New String() {"Femenino", "Masculino"})
        Me.cbxMedicoDestinatario.DataSource = Me.MedicoBindingSource
        Me.cbxMedicoDestinatario.DisplayMember = "apellidos"
        Me.cbxMedicoDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMedicoDestinatario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbxMedicoDestinatario.FormattingEnabled = true
        Me.cbxMedicoDestinatario.Location = New System.Drawing.Point(148, 78)
        Me.cbxMedicoDestinatario.Name = "cbxMedicoDestinatario"
        Me.cbxMedicoDestinatario.Size = New System.Drawing.Size(217, 23)
        Me.cbxMedicoDestinatario.TabIndex = 21
        '
        'MedicoBindingSource
        '
        Me.MedicoBindingSource.DataMember = "medico"
        Me.MedicoBindingSource.DataSource = Me.DsPreliminarBindingSource
        '
        'DsPreliminarBindingSource
        '
        Me.DsPreliminarBindingSource.DataSource = Me.DsPreliminar
        Me.DsPreliminarBindingSource.Position = 0
        '
        'DsPreliminar
        '
        Me.DsPreliminar.DataSetName = "dsPreliminar"
        Me.DsPreliminar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Medico Destinatario"
        Me.Label1.Visible = false
        '
        'lbMedicoRemit
        '
        Me.lbMedicoRemit.AutoSize = true
        Me.lbMedicoRemit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbMedicoRemit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbMedicoRemit.Location = New System.Drawing.Point(6, 25)
        Me.lbMedicoRemit.Name = "lbMedicoRemit"
        Me.lbMedicoRemit.Size = New System.Drawing.Size(109, 15)
        Me.lbMedicoRemit.TabIndex = 38
        Me.lbMedicoRemit.Text = "Medico Remitente"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(148, 22)
        Me.tbMedicoRemitente.MaxLength = 50
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(217, 23)
        Me.tbMedicoRemitente.TabIndex = 37
        '
        'lbFechaEstudio
        '
        Me.lbFechaEstudio.AutoSize = true
        Me.lbFechaEstudio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbFechaEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbFechaEstudio.Location = New System.Drawing.Point(7, 57)
        Me.lbFechaEstudio.Name = "lbFechaEstudio"
        Me.lbFechaEstudio.Size = New System.Drawing.Size(81, 15)
        Me.lbFechaEstudio.TabIndex = 36
        Me.lbFechaEstudio.Text = "Fecha Estudio"
        '
        'pnListaEstudios
        '
        Me.pnListaEstudios.BackColor = System.Drawing.Color.White
        Me.pnListaEstudios.Controls.Add(Me.tbBuscar)
        Me.pnListaEstudios.Controls.Add(Me.lbIDAtencion)
        Me.pnListaEstudios.Controls.Add(Me.tbPrecioParcial)
        Me.pnListaEstudios.Controls.Add(Me.btnImprimir)
        Me.pnListaEstudios.Controls.Add(Me.grbDatosCategoria)
        Me.pnListaEstudios.Controls.Add(Me.gbEstudio)
        Me.pnListaEstudios.Controls.Add(Me.cbCampo)
        Me.pnListaEstudios.Controls.Add(Me.Label35)
        Me.pnListaEstudios.Controls.Add(Me.gbListadoEstudios)
        Me.pnListaEstudios.Location = New System.Drawing.Point(9, 26)
        Me.pnListaEstudios.Name = "pnListaEstudios"
        Me.pnListaEstudios.Size = New System.Drawing.Size(634, 413)
        Me.pnListaEstudios.TabIndex = 35
        Me.pnListaEstudios.Visible = false
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(87, 93)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(253, 20)
        Me.tbBuscar.TabIndex = 50
        '
        'lbIDAtencion
        '
        Me.lbIDAtencion.AutoSize = true
        Me.lbIDAtencion.Location = New System.Drawing.Point(18, 380)
        Me.lbIDAtencion.Name = "lbIDAtencion"
        Me.lbIDAtencion.Size = New System.Drawing.Size(39, 13)
        Me.lbIDAtencion.TabIndex = 57
        Me.lbIDAtencion.Text = "Label2"
        Me.lbIDAtencion.Visible = false
        '
        'tbPrecioParcial
        '
        Me.tbPrecioParcial.BackColor = System.Drawing.Color.White
        Me.tbPrecioParcial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbPrecioParcial.Location = New System.Drawing.Point(346, 92)
        Me.tbPrecioParcial.MaxLength = 8
        Me.tbPrecioParcial.Name = "tbPrecioParcial"
        Me.tbPrecioParcial.ReadOnly = true
        Me.tbPrecioParcial.Size = New System.Drawing.Size(131, 23)
        Me.tbPrecioParcial.TabIndex = 56
        Me.tbPrecioParcial.Text = "0"
        Me.tbPrecioParcial.Visible = false
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(114, 371)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(375, 30)
        Me.btnImprimir.TabIndex = 55
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = false
        '
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.lbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.lbCodigoCategoria)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(15, 11)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(285, 74)
        Me.grbDatosCategoria.TabIndex = 54
        Me.grbDatosCategoria.TabStop = false
        Me.grbDatosCategoria.Text = "Datos de Categoría"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(92, 46)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = true
        Me.tbCategoria.Size = New System.Drawing.Size(184, 20)
        Me.tbCategoria.TabIndex = 29
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = true
        Me.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbCategoria.Location = New System.Drawing.Point(3, 47)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lbCategoria.TabIndex = 27
        Me.lbCategoria.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(92, 18)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = true
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(184, 20)
        Me.tbCodigoCategoria.TabIndex = 26
        '
        'lbCodigoCategoria
        '
        Me.lbCodigoCategoria.AutoSize = true
        Me.lbCodigoCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbCodigoCategoria.Location = New System.Drawing.Point(3, 21)
        Me.lbCodigoCategoria.Name = "lbCodigoCategoria"
        Me.lbCodigoCategoria.Size = New System.Drawing.Size(88, 13)
        Me.lbCodigoCategoria.TabIndex = 25
        Me.lbCodigoCategoria.Text = "Código Categoria"
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.lbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.lbNombreEstudio)
        Me.gbEstudio.Controls.Add(Me.tbNombreEstudio)
        Me.gbEstudio.Controls.Add(Me.lbCliente)
        Me.gbEstudio.Controls.Add(Me.tbCliente)
        Me.gbEstudio.Controls.Add(Me.lbPrecio)
        Me.gbEstudio.Controls.Add(Me.tbPrecio)
        Me.gbEstudio.Location = New System.Drawing.Point(304, 11)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(320, 74)
        Me.gbEstudio.TabIndex = 53
        Me.gbEstudio.TabStop = false
        Me.gbEstudio.Text = "Datos de Estudio"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(104, 18)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = true
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(199, 20)
        Me.tbCodigoEstudio.TabIndex = 22
        '
        'lbCodigoEstudio
        '
        Me.lbCodigoEstudio.AutoSize = true
        Me.lbCodigoEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbCodigoEstudio.Location = New System.Drawing.Point(12, 21)
        Me.lbCodigoEstudio.Name = "lbCodigoEstudio"
        Me.lbCodigoEstudio.Size = New System.Drawing.Size(78, 13)
        Me.lbCodigoEstudio.TabIndex = 21
        Me.lbCodigoEstudio.Text = "Código Estudio"
        '
        'lbNombreEstudio
        '
        Me.lbNombreEstudio.AutoSize = true
        Me.lbNombreEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(114,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lbNombreEstudio.Location = New System.Drawing.Point(12, 47)
        Me.lbNombreEstudio.Name = "lbNombreEstudio"
        Me.lbNombreEstudio.Size = New System.Drawing.Size(82, 13)
        Me.lbNombreEstudio.TabIndex = 2
        Me.lbNombreEstudio.Text = "Nombre Estudio"
        '
        'tbNombreEstudio
        '
        Me.tbNombreEstudio.Location = New System.Drawing.Point(104, 44)
        Me.tbNombreEstudio.Name = "tbNombreEstudio"
        Me.tbNombreEstudio.ReadOnly = true
        Me.tbNombreEstudio.Size = New System.Drawing.Size(199, 20)
        Me.tbNombreEstudio.TabIndex = 0
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = true
        Me.lbCliente.Location = New System.Drawing.Point(18, 61)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(39, 13)
        Me.lbCliente.TabIndex = 19
        Me.lbCliente.Text = "Cliente"
        Me.lbCliente.Visible = false
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(112, 58)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.ReadOnly = true
        Me.tbCliente.Size = New System.Drawing.Size(199, 20)
        Me.tbCliente.TabIndex = 18
        Me.tbCliente.Visible = false
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = true
        Me.lbPrecio.Location = New System.Drawing.Point(18, 35)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lbPrecio.TabIndex = 17
        Me.lbPrecio.Text = "Precio"
        Me.lbPrecio.Visible = false
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(112, 32)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.ReadOnly = true
        Me.tbPrecio.Size = New System.Drawing.Size(199, 20)
        Me.tbPrecio.TabIndex = 16
        Me.tbPrecio.Text = "0"
        Me.tbPrecio.Visible = false
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = true
        Me.cbCampo.Items.AddRange(New Object() {"estudio", "codigo_categoria", "codigo_estudio", "nombre_categoria"})
        Me.cbCampo.Location = New System.Drawing.Point(57, 93)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(123, 21)
        Me.cbCampo.TabIndex = 52
        Me.cbCampo.Visible = false
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Location = New System.Drawing.Point(11, 96)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "Buscar:"
        '
        'gbListadoEstudios
        '
        Me.gbListadoEstudios.Controls.Add(Me.Label5)
        Me.gbListadoEstudios.Controls.Add(Me.Label39)
        Me.gbListadoEstudios.Controls.Add(Me.Label38)
        Me.gbListadoEstudios.Controls.Add(Me.Label37)
        Me.gbListadoEstudios.Controls.Add(Me.Label33)
        Me.gbListadoEstudios.Controls.Add(Me.tbIdUsuario)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDEntidad)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDAtencion)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDCliente)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDDetalle)
        Me.gbListadoEstudios.Controls.Add(Me.dgvListadoAtenciones)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDLista)
        Me.gbListadoEstudios.Controls.Add(Me.lknInexistente)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDPrecio)
        Me.gbListadoEstudios.Controls.Add(Me.dgvListado)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDEstudio)
        Me.gbListadoEstudios.Location = New System.Drawing.Point(8, 120)
        Me.gbListadoEstudios.Name = "gbListadoEstudios"
        Me.gbListadoEstudios.Size = New System.Drawing.Size(623, 253)
        Me.gbListadoEstudios.TabIndex = 49
        Me.gbListadoEstudios.TabStop = false
        Me.gbListadoEstudios.Text = "Listado de Estudios"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(547, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "id_usuario"
        Me.Label5.Visible = false
        '
        'Label39
        '
        Me.Label39.AutoSize = true
        Me.Label39.Location = New System.Drawing.Point(492, 194)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 13)
        Me.Label39.TabIndex = 73
        Me.Label39.Text = "id_entidad"
        Me.Label39.Visible = false
        '
        'Label38
        '
        Me.Label38.AutoSize = true
        Me.Label38.Location = New System.Drawing.Point(377, 194)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(62, 13)
        Me.Label38.TabIndex = 72
        Me.Label38.Text = "id_atencion"
        Me.Label38.Visible = false
        '
        'Label37
        '
        Me.Label37.AutoSize = true
        Me.Label37.Location = New System.Drawing.Point(439, 194)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 13)
        Me.Label37.TabIndex = 71
        Me.Label37.Text = "id_cliente"
        Me.Label37.Visible = false
        '
        'Label33
        '
        Me.Label33.AutoSize = true
        Me.Label33.Location = New System.Drawing.Point(327, 194)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 13)
        Me.Label33.TabIndex = 70
        Me.Label33.Text = "id_detalle"
        Me.Label33.Visible = false
        '
        'tbIdUsuario
        '
        Me.tbIdUsuario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbIdUsuario.Location = New System.Drawing.Point(548, 208)
        Me.tbIdUsuario.Name = "tbIdUsuario"
        Me.tbIdUsuario.ReadOnly = true
        Me.tbIdUsuario.Size = New System.Drawing.Size(53, 23)
        Me.tbIdUsuario.TabIndex = 69
        Me.tbIdUsuario.Visible = false
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbIDEntidad.Location = New System.Drawing.Point(492, 208)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.ReadOnly = true
        Me.tbIDEntidad.Size = New System.Drawing.Size(53, 23)
        Me.tbIDEntidad.TabIndex = 68
        Me.tbIDEntidad.Visible = false
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbIDAtencion.Location = New System.Drawing.Point(382, 208)
        Me.tbIDAtencion.MaxLength = 50
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.ReadOnly = true
        Me.tbIDAtencion.Size = New System.Drawing.Size(53, 23)
        Me.tbIDAtencion.TabIndex = 67
        Me.tbIDAtencion.Visible = false
        '
        'tbIDCliente
        '
        Me.tbIDCliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbIDCliente.Location = New System.Drawing.Point(437, 208)
        Me.tbIDCliente.Name = "tbIDCliente"
        Me.tbIDCliente.ReadOnly = true
        Me.tbIDCliente.Size = New System.Drawing.Size(53, 23)
        Me.tbIDCliente.TabIndex = 65
        Me.tbIDCliente.Visible = false
        '
        'tbIDDetalle
        '
        Me.tbIDDetalle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbIDDetalle.Location = New System.Drawing.Point(326, 208)
        Me.tbIDDetalle.MaxLength = 50
        Me.tbIDDetalle.Name = "tbIDDetalle"
        Me.tbIDDetalle.ReadOnly = true
        Me.tbIDDetalle.Size = New System.Drawing.Size(54, 23)
        Me.tbIDDetalle.TabIndex = 66
        Me.tbIDDetalle.Visible = false
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = false
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoAtenciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoAtenciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_entidad, Me.id_estudio, Me.id_pecio, Me.estudio, Me.precio, Me.entidad, Me.codigo_categoria, Me.id_detalle, Me.id_atencion})
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(294, 18)
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = true
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(332, 229)
        Me.dgvListadoAtenciones.TabIndex = 60
        '
        'id_entidad
        '
        Me.id_entidad.HeaderText = "id_entidad"
        Me.id_entidad.Name = "id_entidad"
        Me.id_entidad.ReadOnly = true
        Me.id_entidad.Visible = false
        '
        'id_estudio
        '
        Me.id_estudio.HeaderText = "id_estudio"
        Me.id_estudio.Name = "id_estudio"
        Me.id_estudio.ReadOnly = true
        Me.id_estudio.Visible = false
        '
        'id_pecio
        '
        Me.id_pecio.HeaderText = "id_pecio"
        Me.id_pecio.Name = "id_pecio"
        Me.id_pecio.ReadOnly = true
        Me.id_pecio.Visible = false
        '
        'estudio
        '
        Me.estudio.HeaderText = "ESTUDIO"
        Me.estudio.Name = "estudio"
        Me.estudio.ReadOnly = true
        Me.estudio.Width = 290
        '
        'precio
        '
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = true
        Me.precio.Width = 50
        '
        'entidad
        '
        Me.entidad.HeaderText = "ENTIDAD"
        Me.entidad.Name = "entidad"
        Me.entidad.ReadOnly = true
        '
        'codigo_categoria
        '
        Me.codigo_categoria.HeaderText = "CODIGO CATEGORIA"
        Me.codigo_categoria.Name = "codigo_categoria"
        Me.codigo_categoria.ReadOnly = true
        '
        'id_detalle
        '
        Me.id_detalle.HeaderText = "id_detalle"
        Me.id_detalle.Name = "id_detalle"
        Me.id_detalle.ReadOnly = true
        '
        'id_atencion
        '
        Me.id_atencion.HeaderText = "id_atencion"
        Me.id_atencion.Name = "id_atencion"
        Me.id_atencion.ReadOnly = true
        Me.id_atencion.Visible = false
        '
        'tbIDLista
        '
        Me.tbIDLista.Enabled = false
        Me.tbIDLista.Location = New System.Drawing.Point(344, 293)
        Me.tbIDLista.Name = "tbIDLista"
        Me.tbIDLista.Size = New System.Drawing.Size(100, 20)
        Me.tbIDLista.TabIndex = 43
        Me.tbIDLista.Visible = false
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = true
        Me.lknInexistente.Location = New System.Drawing.Point(103, 114)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(94, 13)
        Me.lknInexistente.TabIndex = 1
        Me.lknInexistente.TabStop = true
        Me.lknInexistente.Text = "Datos Inexistentes"
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Enabled = false
        Me.tbIDPrecio.Location = New System.Drawing.Point(696, 293)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDPrecio.TabIndex = 42
        Me.tbIDPrecio.Visible = false
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = false
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(3, 18)
        Me.dgvListado.MultiSelect = false
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = true
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(290, 229)
        Me.dgvListado.TabIndex = 0
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = false
        Me.tbIDEstudio.Location = New System.Drawing.Point(-8, 293)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEstudio.TabIndex = 38
        Me.tbIDEstudio.Visible = false
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'MedicoTableAdapter
        '
        Me.MedicoTableAdapter.ClearBeforeFill = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(190, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "REGISTRO DE PACIENTES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 30)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = false
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.Gray
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.ForeColor = System.Drawing.Color.Transparent
        Me.btCerrar.Location = New System.Drawing.Point(629, 0)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btCerrar.TabIndex = 75
        Me.btCerrar.Text = "X"
        Me.btCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCerrar.UseVisualStyleBackColor = false
        '
        'frmSeguros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(655, 440)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.pnListaEstudios)
        Me.Controls.Add(Me.pnDatosAtencion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnDatosPaciente)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeguros"
        Me.Text = "PROMES"
        Me.grbxDatosPersonales.ResumeLayout(false)
        Me.grbxDatosPersonales.PerformLayout
        Me.grbxDatosFactura.ResumeLayout(false)
        Me.grbxDatosFactura.PerformLayout
        Me.pnDatosPaciente.ResumeLayout(false)
        Me.pnDatosPaciente.PerformLayout
        Me.pnDatosAtencion.ResumeLayout(false)
        Me.grbxDatosAtencion.ResumeLayout(false)
        Me.grbxDatosAtencion.PerformLayout
        CType(Me.MedicoBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPreliminarBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPreliminar,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnListaEstudios.ResumeLayout(false)
        Me.pnListaEstudios.PerformLayout
        Me.grbDatosCategoria.ResumeLayout(false)
        Me.grbDatosCategoria.PerformLayout
        Me.gbEstudio.ResumeLayout(false)
        Me.gbEstudio.PerformLayout
        Me.gbListadoEstudios.ResumeLayout(false)
        Me.gbListadoEstudios.PerformLayout
        CType(Me.dgvListadoAtenciones,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvListado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.errorIcono,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents grbxDatosPersonales As GroupBox
    Friend WithEvents lbci As Label
    Friend WithEvents tbci As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents tbCodigoAsegurado As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents lbCodigoAsegurado As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents lbCelular As Label
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbDireccion As Label
    Friend WithEvents lbFechaNacimiento As Label
    Friend WithEvents lblbApellidoCliente As Label
    Friend WithEvents lbNombreCliente As Label
    Friend WithEvents grbxDatosFactura As GroupBox
    Friend WithEvents tbNIT As TextBox
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents lbNit As Label
    Friend WithEvents lbRazonSocial As Label
    Friend WithEvents lbInstitucion As Label
    Friend WithEvents btnDatosAtencion As Button
    Friend WithEvents pnDatosPaciente As Panel
    Friend WithEvents pnDatosAtencion As Panel
    Friend WithEvents btnDetalle As Button
    Friend WithEvents grbxDatosAtencion As GroupBox
    Friend WithEvents cbxMedicoDestinatario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbMedicoRemit As Label
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents lbFechaEstudio As Label
    Friend WithEvents pnListaEstudios As Panel
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents lbCategoria As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents lbCodigoCategoria As Label
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents lbCodigoEstudio As Label
    Friend WithEvents lbNombreEstudio As Label
    Friend WithEvents tbNombreEstudio As TextBox
    Friend WithEvents lbCliente As Label
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents lbPrecio As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents gbListadoEstudios As GroupBox
    Friend WithEvents tbIDLista As TextBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents id_entidad As DataGridViewTextBoxColumn
    Friend WithEvents id_estudio As DataGridViewTextBoxColumn
    Friend WithEvents id_pecio As DataGridViewTextBoxColumn
    Friend WithEvents estudio As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents entidad As DataGridViewTextBoxColumn
    Friend WithEvents codigo_categoria As DataGridViewTextBoxColumn
    Friend WithEvents id_detalle As DataGridViewTextBoxColumn
    Friend WithEvents id_atencion As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents tbIdUsuario As TextBox
    Friend WithEvents tbIDEntidad As TextBox
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents tbIDDetalle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents cbxInstitucion As TextBox
    Friend WithEvents DsPreliminarBindingSource As BindingSource
    Friend WithEvents DsPreliminar As dsPreliminar
    Friend WithEvents MedicoBindingSource As BindingSource
    Friend WithEvents MedicoTableAdapter As dsPreliminarTableAdapters.medicoTableAdapter
    Friend WithEvents tbInstitucion As TextBox
    Friend WithEvents tbPrecioParcial As TextBox
    Friend WithEvents lbIDAtencion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaAtencion As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btCerrar As Button
End Class
