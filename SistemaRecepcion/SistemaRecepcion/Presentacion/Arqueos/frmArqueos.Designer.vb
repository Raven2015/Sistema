<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grbxIngresos = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grbxEgresos = New System.Windows.Forms.GroupBox()
        Me.cbxEntidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.ListaentidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_entidadesTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.lista_entidadesTableAdapter()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.grbxIngresos.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbxTurno)
        Me.Panel1.Controls.Add(Me.dtpFechaAtencion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbxEntidad)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 64)
        Me.Panel1.TabIndex = 0
        '
        'grbxIngresos
        '
        Me.grbxIngresos.Controls.Add(Me.lknInexistente)
        Me.grbxIngresos.Controls.Add(Me.dgvListado)
        Me.grbxIngresos.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbxIngresos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxIngresos.Location = New System.Drawing.Point(0, 64)
        Me.grbxIngresos.Name = "grbxIngresos"
        Me.grbxIngresos.Size = New System.Drawing.Size(589, 429)
        Me.grbxIngresos.TabIndex = 1
        Me.grbxIngresos.TabStop = False
        Me.grbxIngresos.Text = "INGRESOS FACTURADOS DEL DÍA"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 493)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1070, 97)
        Me.Panel2.TabIndex = 2
        '
        'grbxEgresos
        '
        Me.grbxEgresos.Dock = System.Windows.Forms.DockStyle.Right
        Me.grbxEgresos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxEgresos.Location = New System.Drawing.Point(595, 64)
        Me.grbxEgresos.Name = "grbxEgresos"
        Me.grbxEgresos.Size = New System.Drawing.Size(475, 429)
        Me.grbxEgresos.TabIndex = 3
        Me.grbxEgresos.TabStop = False
        Me.grbxEgresos.Text = "DEDUCCIONES AUTORIZADAS"
        '
        'cbxEntidad
        '
        Me.cbxEntidad.DataSource = Me.ListaEntidadBindingSource
        Me.cbxEntidad.DisplayMember = "nombre_entidad"
        Me.cbxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntidad.FormattingEnabled = True
        Me.cbxEntidad.Location = New System.Drawing.Point(187, 12)
        Me.cbxEntidad.Name = "cbxEntidad"
        Me.cbxEntidad.Size = New System.Drawing.Size(166, 21)
        Me.cbxEntidad.TabIndex = 0
        Me.cbxEntidad.ValueMember = "id_entidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE DE ENTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(381, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA DE ATENCIÓN"
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(539, 12)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaAtencion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(683, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TURNO"
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Items.AddRange(New Object() {"MAÑANA", "TARDE"})
        Me.cbxTurno.Location = New System.Drawing.Point(747, 12)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(166, 21)
        Me.cbxTurno.TabIndex = 4
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListado.Location = New System.Drawing.Point(3, 23)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(583, 403)
        Me.dgvListado.TabIndex = 0
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lknInexistente.Location = New System.Drawing.Point(183, 203)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(185, 19)
        Me.lknInexistente.TabIndex = 3
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "No hay datos par mostrar"
        '
        'DsListaEntidades
        '
        Me.DsListaEntidades.DataSetName = "dsListaEntidades"
        Me.DsListaEntidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ListaEntidadBindingSource
        '
        Me.ListaEntidadBindingSource.DataMember = "listaEntidad"
        Me.ListaEntidadBindingSource.DataSource = Me.DsListaEntidades
        '
        'ListaEntidadTableAdapter
        '
        Me.ListaEntidadTableAdapter.ClearBeforeFill = True
        '
        'frmArqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 590)
        Me.Controls.Add(Me.grbxIngresos)
        Me.Controls.Add(Me.grbxEgresos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmArqueos"
        Me.Text = "ARQUEO DIARIO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grbxIngresos.ResumeLayout(False)
        Me.grbxIngresos.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grbxIngresos As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grbxEgresos As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxTurno As ComboBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxEntidad As ComboBox
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents ListaentidadesBindingSource As BindingSource
    Friend WithEvents Lista_entidadesTableAdapter As dsListaEntidadesTableAdapters.lista_entidadesTableAdapter
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
End Class
