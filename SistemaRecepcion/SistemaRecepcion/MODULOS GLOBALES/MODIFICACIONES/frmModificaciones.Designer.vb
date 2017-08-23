<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificaciones
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificaciones))
        Me.rbctrCintaOpciones = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.brbtnDatosAtencion = New DevExpress.XtraBars.BarButtonItem()
        Me.brbtnDatosEstudio = New DevExpress.XtraBars.BarButtonItem()
        Me.brbtnEntidades = New DevExpress.XtraBars.BarButtonItem()
        Me.brbtnPreciosEstudios = New DevExpress.XtraBars.BarButtonItem()
        Me.brbtnEditarCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.pnContenedor = New System.Windows.Forms.Panel()
        Me.flpnDatosCliente = New DevExpress.Utils.FlyoutPanel()
        Me.btnCerrarCliente = New System.Windows.Forms.Button()
        Me.tbIdUsuarioEditar = New System.Windows.Forms.TextBox()
        Me.tbIDClienteEditar = New System.Windows.Forms.TextBox()
        Me.dgvResultadoclientes = New System.Windows.Forms.DataGridView()
        Me.dtpNacimientoCliente = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbEdadCliente = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbRazonSocialCliente = New System.Windows.Forms.TextBox()
        Me.tbNombresCliente = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbNitCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbCelularCliente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbCodigoCliente = New System.Windows.Forms.TextBox()
        Me.lbDatosInexistentesCliente = New System.Windows.Forms.Label()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.btnModificarClietne = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbApellidosCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbCICliente = New System.Windows.Forms.TextBox()
        Me.tbIDAtencionCliente = New System.Windows.Forms.TextBox()
        Me.cbxSexoCliente = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.flpnPreciosEstudios = New DevExpress.Utils.FlyoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.flpnDatosAtencion = New DevExpress.Utils.FlyoutPanel()
        Me.btnCerrarAtenciones = New System.Windows.Forms.Button()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lbInexistente = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.cbxMDestinatario = New System.Windows.Forms.ComboBox()
        Me.MostrarmedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.Mostrar_medicoTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter()
        Me.ListaentidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_entidadesTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.lista_entidadesTableAdapter()
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.brbtnDatosCliente = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.rbctrCintaOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnContenedor.SuspendLayout()
        CType(Me.flpnDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpnDatosCliente.SuspendLayout()
        CType(Me.dgvResultadoclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flpnPreciosEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpnPreciosEstudios.SuspendLayout()
        CType(Me.flpnDatosAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpnDatosAtencion.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbctrCintaOpciones
        '
        Me.rbctrCintaOpciones.ExpandCollapseItem.Id = 0
        Me.rbctrCintaOpciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbctrCintaOpciones.ExpandCollapseItem, Me.brbtnDatosAtencion, Me.brbtnDatosEstudio, Me.brbtnEntidades, Me.brbtnPreciosEstudios, Me.brbtnEditarCliente})
        Me.rbctrCintaOpciones.Location = New System.Drawing.Point(0, 0)
        Me.rbctrCintaOpciones.MaxItemId = 8
        Me.rbctrCintaOpciones.Name = "rbctrCintaOpciones"
        Me.rbctrCintaOpciones.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rbctrCintaOpciones.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.rbctrCintaOpciones.Size = New System.Drawing.Size(803, 143)
        Me.rbctrCintaOpciones.StatusBar = Me.RibbonStatusBar1
        '
        'brbtnDatosAtencion
        '
        Me.brbtnDatosAtencion.Caption = "DATOS DE ATENCIÓN"
        Me.brbtnDatosAtencion.Glyph = CType(resources.GetObject("brbtnDatosAtencion.Glyph"), System.Drawing.Image)
        Me.brbtnDatosAtencion.Id = 1
        Me.brbtnDatosAtencion.LargeGlyph = CType(resources.GetObject("brbtnDatosAtencion.LargeGlyph"), System.Drawing.Image)
        Me.brbtnDatosAtencion.Name = "brbtnDatosAtencion"
        '
        'brbtnDatosEstudio
        '
        Me.brbtnDatosEstudio.Caption = "DATOS DE ESTUDIOS"
        Me.brbtnDatosEstudio.Glyph = CType(resources.GetObject("brbtnDatosEstudio.Glyph"), System.Drawing.Image)
        Me.brbtnDatosEstudio.Id = 3
        Me.brbtnDatosEstudio.LargeGlyph = CType(resources.GetObject("brbtnDatosEstudio.LargeGlyph"), System.Drawing.Image)
        Me.brbtnDatosEstudio.Name = "brbtnDatosEstudio"
        '
        'brbtnEntidades
        '
        Me.brbtnEntidades.Caption = "ENTIDADES"
        Me.brbtnEntidades.Glyph = CType(resources.GetObject("brbtnEntidades.Glyph"), System.Drawing.Image)
        Me.brbtnEntidades.Id = 4
        Me.brbtnEntidades.LargeGlyph = CType(resources.GetObject("brbtnEntidades.LargeGlyph"), System.Drawing.Image)
        Me.brbtnEntidades.Name = "brbtnEntidades"
        '
        'brbtnPreciosEstudios
        '
        Me.brbtnPreciosEstudios.Caption = "PRECIOS DE ESTUDIOS"
        Me.brbtnPreciosEstudios.Glyph = CType(resources.GetObject("brbtnPreciosEstudios.Glyph"), System.Drawing.Image)
        Me.brbtnPreciosEstudios.Id = 5
        Me.brbtnPreciosEstudios.LargeGlyph = CType(resources.GetObject("brbtnPreciosEstudios.LargeGlyph"), System.Drawing.Image)
        Me.brbtnPreciosEstudios.Name = "brbtnPreciosEstudios"
        '
        'brbtnEditarCliente
        '
        Me.brbtnEditarCliente.Caption = "DATOS DEL PACIENTE"
        Me.brbtnEditarCliente.Glyph = CType(resources.GetObject("brbtnEditarCliente.Glyph"), System.Drawing.Image)
        Me.brbtnEditarCliente.Id = 7
        Me.brbtnEditarCliente.LargeGlyph = CType(resources.GetObject("brbtnEditarCliente.LargeGlyph"), System.Drawing.Image)
        Me.brbtnEditarCliente.Name = "brbtnEditarCliente"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "MODIFICACIONES"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.brbtnDatosAtencion)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.brbtnEditarCliente)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "ATENCIÓN"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.brbtnDatosEstudio)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "ESTUDIOS"
        Me.RibbonPageGroup2.Visible = False
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.brbtnEntidades)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.brbtnPreciosEstudios)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "PRECIOS"
        Me.RibbonPageGroup3.Visible = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 388)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.rbctrCintaOpciones
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(803, 31)
        '
        'pnContenedor
        '
        Me.pnContenedor.Controls.Add(Me.flpnDatosCliente)
        Me.pnContenedor.Controls.Add(Me.flpnPreciosEstudios)
        Me.pnContenedor.Controls.Add(Me.flpnDatosAtencion)
        Me.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnContenedor.Location = New System.Drawing.Point(0, 143)
        Me.pnContenedor.Name = "pnContenedor"
        Me.pnContenedor.Size = New System.Drawing.Size(803, 276)
        Me.pnContenedor.TabIndex = 8
        '
        'flpnDatosCliente
        '
        Me.flpnDatosCliente.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnDatosCliente.Appearance.Options.UseBackColor = True
        Me.flpnDatosCliente.Controls.Add(Me.btnCerrarCliente)
        Me.flpnDatosCliente.Controls.Add(Me.tbIdUsuarioEditar)
        Me.flpnDatosCliente.Controls.Add(Me.tbIDClienteEditar)
        Me.flpnDatosCliente.Controls.Add(Me.dgvResultadoclientes)
        Me.flpnDatosCliente.Controls.Add(Me.dtpNacimientoCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label20)
        Me.flpnDatosCliente.Controls.Add(Me.tbEdadCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label19)
        Me.flpnDatosCliente.Controls.Add(Me.Label18)
        Me.flpnDatosCliente.Controls.Add(Me.tbRazonSocialCliente)
        Me.flpnDatosCliente.Controls.Add(Me.tbNombresCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label17)
        Me.flpnDatosCliente.Controls.Add(Me.tbNitCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label16)
        Me.flpnDatosCliente.Controls.Add(Me.tbCelularCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label15)
        Me.flpnDatosCliente.Controls.Add(Me.tbCodigoCliente)
        Me.flpnDatosCliente.Controls.Add(Me.lbDatosInexistentesCliente)
        Me.flpnDatosCliente.Controls.Add(Me.btnCancelarCliente)
        Me.flpnDatosCliente.Controls.Add(Me.btnModificarClietne)
        Me.flpnDatosCliente.Controls.Add(Me.Label10)
        Me.flpnDatosCliente.Controls.Add(Me.tbApellidosCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label11)
        Me.flpnDatosCliente.Controls.Add(Me.Label12)
        Me.flpnDatosCliente.Controls.Add(Me.Label13)
        Me.flpnDatosCliente.Controls.Add(Me.Label14)
        Me.flpnDatosCliente.Controls.Add(Me.tbCICliente)
        Me.flpnDatosCliente.Controls.Add(Me.tbIDAtencionCliente)
        Me.flpnDatosCliente.Controls.Add(Me.cbxSexoCliente)
        Me.flpnDatosCliente.Controls.Add(Me.Label9)
        Me.flpnDatosCliente.Location = New System.Drawing.Point(0, 27)
        Me.flpnDatosCliente.Name = "flpnDatosCliente"
        Me.flpnDatosCliente.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom
        Me.flpnDatosCliente.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnDatosCliente.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom
        Me.flpnDatosCliente.OwnerControl = Me.pnContenedor
        Me.flpnDatosCliente.Size = New System.Drawing.Size(800, 220)
        Me.flpnDatosCliente.TabIndex = 2
        '
        'btnCerrarCliente
        '
        Me.btnCerrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarCliente.ForeColor = System.Drawing.Color.White
        Me.btnCerrarCliente.Location = New System.Drawing.Point(3, 3)
        Me.btnCerrarCliente.Name = "btnCerrarCliente"
        Me.btnCerrarCliente.Size = New System.Drawing.Size(23, 23)
        Me.btnCerrarCliente.TabIndex = 50
        Me.btnCerrarCliente.Text = "X"
        Me.btnCerrarCliente.UseVisualStyleBackColor = True
        '
        'tbIdUsuarioEditar
        '
        Me.tbIdUsuarioEditar.Location = New System.Drawing.Point(612, 196)
        Me.tbIdUsuarioEditar.Name = "tbIdUsuarioEditar"
        Me.tbIdUsuarioEditar.ReadOnly = True
        Me.tbIdUsuarioEditar.Size = New System.Drawing.Size(85, 21)
        Me.tbIdUsuarioEditar.TabIndex = 49
        Me.tbIdUsuarioEditar.Visible = False
        '
        'tbIDClienteEditar
        '
        Me.tbIDClienteEditar.Location = New System.Drawing.Point(703, 196)
        Me.tbIDClienteEditar.Name = "tbIDClienteEditar"
        Me.tbIDClienteEditar.ReadOnly = True
        Me.tbIDClienteEditar.Size = New System.Drawing.Size(85, 21)
        Me.tbIDClienteEditar.TabIndex = 46
        Me.tbIDClienteEditar.Visible = False
        '
        'dgvResultadoclientes
        '
        Me.dgvResultadoclientes.AllowUserToAddRows = False
        Me.dgvResultadoclientes.AllowUserToDeleteRows = False
        Me.dgvResultadoclientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultadoclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultadoclientes.Location = New System.Drawing.Point(29, 146)
        Me.dgvResultadoclientes.MultiSelect = False
        Me.dgvResultadoclientes.Name = "dgvResultadoclientes"
        Me.dgvResultadoclientes.ReadOnly = True
        Me.dgvResultadoclientes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvResultadoclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultadoclientes.Size = New System.Drawing.Size(751, 72)
        Me.dgvResultadoclientes.TabIndex = 30
        Me.dgvResultadoclientes.Visible = False
        '
        'dtpNacimientoCliente
        '
        Me.dtpNacimientoCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimientoCliente.Location = New System.Drawing.Point(505, 59)
        Me.dtpNacimientoCliente.Name = "dtpNacimientoCliente"
        Me.dtpNacimientoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpNacimientoCliente.Size = New System.Drawing.Size(124, 21)
        Me.dtpNacimientoCliente.TabIndex = 48
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(708, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 15)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "EDAD"
        '
        'tbEdadCliente
        '
        Me.tbEdadCliente.Location = New System.Drawing.Point(684, 119)
        Me.tbEdadCliente.Name = "tbEdadCliente"
        Me.tbEdadCliente.ReadOnly = True
        Me.tbEdadCliente.Size = New System.Drawing.Size(85, 21)
        Me.tbEdadCliente.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(426, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 15)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "NACIMIENTO:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(439, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 15)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "R. SOCIAL:"
        '
        'tbRazonSocialCliente
        '
        Me.tbRazonSocialCliente.Location = New System.Drawing.Point(505, 119)
        Me.tbRazonSocialCliente.Name = "tbRazonSocialCliente"
        Me.tbRazonSocialCliente.Size = New System.Drawing.Size(124, 21)
        Me.tbRazonSocialCliente.TabIndex = 40
        '
        'tbNombresCliente
        '
        Me.tbNombresCliente.Location = New System.Drawing.Point(78, 59)
        Me.tbNombresCliente.Name = "tbNombresCliente"
        Me.tbNombresCliente.Size = New System.Drawing.Size(147, 21)
        Me.tbNombresCliente.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(473, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 15)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "NIT:"
        '
        'tbNitCliente
        '
        Me.tbNitCliente.Location = New System.Drawing.Point(505, 89)
        Me.tbNitCliente.Name = "tbNitCliente"
        Me.tbNitCliente.Size = New System.Drawing.Size(124, 21)
        Me.tbNitCliente.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(234, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "CELULAR:"
        '
        'tbCelularCliente
        '
        Me.tbCelularCliente.Location = New System.Drawing.Point(296, 119)
        Me.tbCelularCliente.Name = "tbCelularCliente"
        Me.tbCelularCliente.Size = New System.Drawing.Size(124, 21)
        Me.tbCelularCliente.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(237, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 15)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "CÓDIDO:"
        '
        'tbCodigoCliente
        '
        Me.tbCodigoCliente.Location = New System.Drawing.Point(296, 89)
        Me.tbCodigoCliente.Name = "tbCodigoCliente"
        Me.tbCodigoCliente.Size = New System.Drawing.Size(124, 21)
        Me.tbCodigoCliente.TabIndex = 33
        '
        'lbDatosInexistentesCliente
        '
        Me.lbDatosInexistentesCliente.AutoSize = True
        Me.lbDatosInexistentesCliente.ForeColor = System.Drawing.Color.White
        Me.lbDatosInexistentesCliente.Location = New System.Drawing.Point(663, 32)
        Me.lbDatosInexistentesCliente.Name = "lbDatosInexistentesCliente"
        Me.lbDatosInexistentesCliente.Size = New System.Drawing.Size(116, 26)
        Me.lbDatosInexistentesCliente.TabIndex = 31
        Me.lbDatosInexistentesCliente.Text = "NO HAY RESULTADOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA MOSTRAR"
        Me.lbDatosInexistentesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbDatosInexistentesCliente.Visible = False
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCliente.ForeColor = System.Drawing.Color.White
        Me.btnCancelarCliente.Location = New System.Drawing.Point(275, 187)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCliente.TabIndex = 27
        Me.btnCancelarCliente.Text = "CANCELAR"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarClietne
        '
        Me.btnModificarClietne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarClietne.ForeColor = System.Drawing.Color.White
        Me.btnModificarClietne.Location = New System.Drawing.Point(416, 187)
        Me.btnModificarClietne.Name = "btnModificarClietne"
        Me.btnModificarClietne.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarClietne.TabIndex = 26
        Me.btnModificarClietne.Text = "MODIFICAR"
        Me.btnModificarClietne.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "APELLIDOS:"
        '
        'tbApellidosCliente
        '
        Me.tbApellidosCliente.Location = New System.Drawing.Point(78, 89)
        Me.tbApellidosCliente.Name = "tbApellidosCliente"
        Me.tbApellidosCliente.Size = New System.Drawing.Size(147, 21)
        Me.tbApellidosCliente.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(252, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "SEXO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(51, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "CI:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(15, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "NOMBRES:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(556, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 15)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "# ATENCIÓN"
        '
        'tbCICliente
        '
        Me.tbCICliente.Location = New System.Drawing.Point(78, 119)
        Me.tbCICliente.Name = "tbCICliente"
        Me.tbCICliente.Size = New System.Drawing.Size(147, 21)
        Me.tbCICliente.TabIndex = 19
        '
        'tbIDAtencionCliente
        '
        Me.tbIDAtencionCliente.Location = New System.Drawing.Point(633, 9)
        Me.tbIDAtencionCliente.Name = "tbIDAtencionCliente"
        Me.tbIDAtencionCliente.Size = New System.Drawing.Size(147, 21)
        Me.tbIDAtencionCliente.TabIndex = 18
        Me.tbIDAtencionCliente.Text = "0"
        '
        'cbxSexoCliente
        '
        Me.cbxSexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSexoCliente.FormattingEnabled = True
        Me.cbxSexoCliente.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cbxSexoCliente.Location = New System.Drawing.Point(296, 59)
        Me.cbxSexoCliente.Name = "cbxSexoCliente"
        Me.cbxSexoCliente.Size = New System.Drawing.Size(124, 21)
        Me.cbxSexoCliente.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(288, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "EDICIÓN DE LOS DATOS DEL CLIENTE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpnPreciosEstudios
        '
        Me.flpnPreciosEstudios.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnPreciosEstudios.Appearance.Options.UseBackColor = True
        Me.flpnPreciosEstudios.Controls.Add(Me.Label7)
        Me.flpnPreciosEstudios.Controls.Add(Me.TextBox10)
        Me.flpnPreciosEstudios.Controls.Add(Me.TextBox12)
        Me.flpnPreciosEstudios.Controls.Add(Me.TextBox11)
        Me.flpnPreciosEstudios.Location = New System.Drawing.Point(58, 14)
        Me.flpnPreciosEstudios.Name = "flpnPreciosEstudios"
        Me.flpnPreciosEstudios.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom
        Me.flpnPreciosEstudios.Options.CloseOnOuterClick = True
        Me.flpnPreciosEstudios.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnPreciosEstudios.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom
        Me.flpnPreciosEstudios.OwnerControl = Me.pnContenedor
        Me.flpnPreciosEstudios.Size = New System.Drawing.Size(800, 173)
        Me.flpnPreciosEstudios.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(313, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "EDITAR PRECIOS DE ETUDIOS"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(16, 66)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(147, 21)
        Me.TextBox10.TabIndex = 11
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(16, 12)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(147, 21)
        Me.TextBox12.TabIndex = 9
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(16, 39)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(147, 21)
        Me.TextBox11.TabIndex = 10
        '
        'flpnDatosAtencion
        '
        Me.flpnDatosAtencion.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnDatosAtencion.Appearance.Options.UseBackColor = True
        Me.flpnDatosAtencion.Controls.Add(Me.btnCerrarAtenciones)
        Me.flpnDatosAtencion.Controls.Add(Me.dgvResultados)
        Me.flpnDatosAtencion.Controls.Add(Me.btnEliminar)
        Me.flpnDatosAtencion.Controls.Add(Me.lbInexistente)
        Me.flpnDatosAtencion.Controls.Add(Me.btnCancelar)
        Me.flpnDatosAtencion.Controls.Add(Me.btnModificar)
        Me.flpnDatosAtencion.Controls.Add(Me.Label6)
        Me.flpnDatosAtencion.Controls.Add(Me.tbPrecio)
        Me.flpnDatosAtencion.Controls.Add(Me.Label5)
        Me.flpnDatosAtencion.Controls.Add(Me.Label4)
        Me.flpnDatosAtencion.Controls.Add(Me.Label3)
        Me.flpnDatosAtencion.Controls.Add(Me.Label2)
        Me.flpnDatosAtencion.Controls.Add(Me.Label1)
        Me.flpnDatosAtencion.Controls.Add(Me.tbMedicoRemitente)
        Me.flpnDatosAtencion.Controls.Add(Me.tbIDAtencion)
        Me.flpnDatosAtencion.Controls.Add(Me.cbxMDestinatario)
        Me.flpnDatosAtencion.Controls.Add(Me.dtpFechaAtencion)
        Me.flpnDatosAtencion.Location = New System.Drawing.Point(82, 3)
        Me.flpnDatosAtencion.Name = "flpnDatosAtencion"
        Me.flpnDatosAtencion.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom
        Me.flpnDatosAtencion.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnDatosAtencion.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom
        Me.flpnDatosAtencion.OwnerControl = Me.pnContenedor
        Me.flpnDatosAtencion.Size = New System.Drawing.Size(797, 220)
        Me.flpnDatosAtencion.TabIndex = 0
        '
        'btnCerrarAtenciones
        '
        Me.btnCerrarAtenciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarAtenciones.ForeColor = System.Drawing.Color.White
        Me.btnCerrarAtenciones.Location = New System.Drawing.Point(3, 3)
        Me.btnCerrarAtenciones.Name = "btnCerrarAtenciones"
        Me.btnCerrarAtenciones.Size = New System.Drawing.Size(23, 23)
        Me.btnCerrarAtenciones.TabIndex = 51
        Me.btnCerrarAtenciones.Text = "X"
        Me.btnCerrarAtenciones.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(145, 147)
        Me.dgvResultados.MultiSelect = False
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(505, 72)
        Me.dgvResultados.TabIndex = 15
        Me.dgvResultados.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(519, 179)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lbInexistente
        '
        Me.lbInexistente.AutoSize = True
        Me.lbInexistente.ForeColor = System.Drawing.Color.White
        Me.lbInexistente.Location = New System.Drawing.Point(671, 49)
        Me.lbInexistente.Name = "lbInexistente"
        Me.lbInexistente.Size = New System.Drawing.Size(116, 26)
        Me.lbInexistente.TabIndex = 16
        Me.lbInexistente.Text = "NO HAY RESULTADOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA MOSTRAR"
        Me.lbInexistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbInexistente.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(237, 179)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(378, 179)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(145, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PRECIO"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(208, 112)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(147, 21)
        Me.tbPrecio.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(400, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "M. DESTINATARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(419, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "M. REMITENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FECHA DE ATENCIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(564, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "# ATENCIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(310, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EDICIÓN DE LOS DATOS DE  ATENCIONES"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(519, 77)
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(147, 21)
        Me.tbMedicoRemitente.TabIndex = 2
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Location = New System.Drawing.Point(641, 26)
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(147, 21)
        Me.tbIDAtencion.TabIndex = 0
        Me.tbIDAtencion.Text = "0"
        '
        'cbxMDestinatario
        '
        Me.cbxMDestinatario.DataSource = Me.MostrarmedicoBindingSource
        Me.cbxMDestinatario.DisplayMember = "apellidos"
        Me.cbxMDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMDestinatario.FormattingEnabled = True
        Me.cbxMDestinatario.Location = New System.Drawing.Point(519, 112)
        Me.cbxMDestinatario.Name = "cbxMDestinatario"
        Me.cbxMDestinatario.Size = New System.Drawing.Size(147, 21)
        Me.cbxMDestinatario.TabIndex = 13
        '
        'MostrarmedicoBindingSource
        '
        Me.MostrarmedicoBindingSource.DataMember = "mostrar_medico"
        Me.MostrarmedicoBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(208, 77)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(147, 21)
        Me.dtpFechaAtencion.TabIndex = 14
        '
        'ListaEntidadBindingSource
        '
        Me.ListaEntidadBindingSource.DataMember = "listaEntidad"
        Me.ListaEntidadBindingSource.DataSource = Me.DsListaEntidades
        '
        'DsListaEntidades
        '
        Me.DsListaEntidades.DataSetName = "dsListaEntidades"
        Me.DsListaEntidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mostrar_medicoTableAdapter
        '
        Me.Mostrar_medicoTableAdapter.ClearBeforeFill = True
        '
        'ListaentidadesBindingSource
        '
        Me.ListaentidadesBindingSource.DataMember = "lista_entidades"
        Me.ListaentidadesBindingSource.DataSource = Me.DsListaEntidades
        '
        'Lista_entidadesTableAdapter
        '
        Me.Lista_entidadesTableAdapter.ClearBeforeFill = True
        '
        'ListaEntidadTableAdapter
        '
        Me.ListaEntidadTableAdapter.ClearBeforeFill = True
        '
        'brbtnDatosCliente
        '
        Me.brbtnDatosCliente.Caption = "DATOS DE CLIENTE"
        Me.brbtnDatosCliente.Glyph = CType(resources.GetObject("brbtnDatosCliente.Glyph"), System.Drawing.Image)
        Me.brbtnDatosCliente.Id = 6
        Me.brbtnDatosCliente.Name = "brbtnDatosCliente"
        '
        'frmModificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 419)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.pnContenedor)
        Me.Controls.Add(Me.rbctrCintaOpciones)
        Me.Name = "frmModificaciones"
        Me.Ribbon = Me.rbctrCintaOpciones
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Modificaciones"
        CType(Me.rbctrCintaOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnContenedor.ResumeLayout(False)
        CType(Me.flpnDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpnDatosCliente.ResumeLayout(False)
        Me.flpnDatosCliente.PerformLayout()
        CType(Me.dgvResultadoclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flpnPreciosEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpnPreciosEstudios.ResumeLayout(False)
        Me.flpnPreciosEstudios.PerformLayout()
        CType(Me.flpnDatosAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpnDatosAtencion.ResumeLayout(False)
        Me.flpnDatosAtencion.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbctrCintaOpciones As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents brbtnDatosAtencion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents brbtnDatosEstudio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents brbtnEntidades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents brbtnPreciosEstudios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pnContenedor As Panel
    Friend WithEvents flpnDatosAtencion As DevExpress.Utils.FlyoutPanel
    Friend WithEvents flpnPreciosEstudios As DevExpress.Utils.FlyoutPanel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents flpnDatosCliente As DevExpress.Utils.FlyoutPanel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxMDestinatario As ComboBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents lbInexistente As Label
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents MostrarmedicoBindingSource As BindingSource
    Friend WithEvents Mostrar_medicoTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents ListaentidadesBindingSource As BindingSource
    Friend WithEvents Lista_entidadesTableAdapter As dsListaEntidadesTableAdapters.lista_entidadesTableAdapter
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
    Friend WithEvents Label20 As Label
    Friend WithEvents tbEdadCliente As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tbRazonSocialCliente As TextBox
    Friend WithEvents tbNombresCliente As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbNitCliente As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbCelularCliente As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbCodigoCliente As TextBox
    Friend WithEvents dgvResultadoclientes As DataGridView
    Friend WithEvents lbDatosInexistentesCliente As Label
    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents btnModificarClietne As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tbApellidosCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbCICliente As TextBox
    Friend WithEvents tbIDAtencionCliente As TextBox
    Friend WithEvents cbxSexoCliente As ComboBox
    Friend WithEvents tbIDClienteEditar As TextBox
    Friend WithEvents brbtnEditarCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents brbtnDatosCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtpNacimientoCliente As DateTimePicker
    Friend WithEvents tbIdUsuarioEditar As TextBox
    Friend WithEvents btnCerrarCliente As Button
    Friend WithEvents btnCerrarAtenciones As Button
End Class
