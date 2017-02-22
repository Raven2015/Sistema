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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxEntidad = New System.Windows.Forms.ComboBox()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.grbxIngresos = New System.Windows.Forms.GroupBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEgresos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbIngresos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListaentidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_entidadesTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.lista_entidadesTableAdapter()
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IMRIMIRARQUEOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TODOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxIngresos.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(547, 13)
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
        Me.cbxTurno.Location = New System.Drawing.Point(622, 12)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(142, 21)
        Me.cbxTurno.TabIndex = 4
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(420, 12)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaAtencion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(262, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA DE ATENCIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTIDAD"
        '
        'cbxEntidad
        '
        Me.cbxEntidad.DataSource = Me.ListaEntidadBindingSource
        Me.cbxEntidad.DisplayMember = "nombre_entidad"
        Me.cbxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntidad.FormattingEnabled = True
        Me.cbxEntidad.Location = New System.Drawing.Point(88, 12)
        Me.cbxEntidad.Name = "cbxEntidad"
        Me.cbxEntidad.Size = New System.Drawing.Size(166, 21)
        Me.cbxEntidad.TabIndex = 0
        Me.cbxEntidad.ValueMember = "id_entidad"
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
        'grbxIngresos
        '
        Me.grbxIngresos.Controls.Add(Me.lknInexistente)
        Me.grbxIngresos.Controls.Add(Me.dgvListado)
        Me.grbxIngresos.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbxIngresos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxIngresos.Location = New System.Drawing.Point(0, 67)
        Me.grbxIngresos.Name = "grbxIngresos"
        Me.grbxIngresos.Size = New System.Drawing.Size(773, 473)
        Me.grbxIngresos.TabIndex = 1
        Me.grbxIngresos.TabStop = False
        Me.grbxIngresos.Text = "INGRESOS DEL DÍA"
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lknInexistente.Location = New System.Drawing.Point(311, 215)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(185, 19)
        Me.lknInexistente.TabIndex = 3
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "No hay datos par mostrar"
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
        Me.dgvListado.Size = New System.Drawing.Size(767, 447)
        Me.dgvListado.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbSaldo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tbEgresos)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tbIngresos)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 540)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 50)
        Me.Panel2.TabIndex = 2
        '
        'tbSaldo
        '
        Me.tbSaldo.Location = New System.Drawing.Point(679, 12)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.ReadOnly = True
        Me.tbSaldo.Size = New System.Drawing.Size(82, 20)
        Me.tbSaldo.TabIndex = 6
        Me.tbSaldo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(618, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SALDO"
        Me.Label6.Visible = False
        '
        'tbEgresos
        '
        Me.tbEgresos.Location = New System.Drawing.Point(466, 12)
        Me.tbEgresos.Name = "tbEgresos"
        Me.tbEgresos.ReadOnly = True
        Me.tbEgresos.Size = New System.Drawing.Size(139, 20)
        Me.tbEgresos.TabIndex = 4
        Me.tbEgresos.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TOTAL DE EGRESOS"
        Me.Label5.Visible = False
        '
        'tbIngresos
        '
        Me.tbIngresos.Location = New System.Drawing.Point(175, 12)
        Me.tbIngresos.Name = "tbIngresos"
        Me.tbIngresos.ReadOnly = True
        Me.tbIngresos.Size = New System.Drawing.Size(139, 20)
        Me.tbIngresos.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TOTAL DE NGRESOS"
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMRIMIRARQUEOToolStripMenuItem, Me.TODOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(776, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IMRIMIRARQUEOToolStripMenuItem
        '
        Me.IMRIMIRARQUEOToolStripMenuItem.Name = "IMRIMIRARQUEOToolStripMenuItem"
        Me.IMRIMIRARQUEOToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.IMRIMIRARQUEOToolStripMenuItem.Text = "IMPRIMIR ARQUEO"
        '
        'TODOSToolStripMenuItem
        '
        Me.TODOSToolStripMenuItem.Name = "TODOSToolStripMenuItem"
        Me.TODOSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.TODOSToolStripMenuItem.Text = "TODOS"
        '
        'frmArqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 590)
        Me.Controls.Add(Me.grbxIngresos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmArqueos"
        Me.Text = "ARQUEO DIARIO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxIngresos.ResumeLayout(False)
        Me.grbxIngresos.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ListaentidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grbxIngresos As GroupBox
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents tbSaldo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEgresos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbIngresos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IMRIMIRARQUEOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TODOSToolStripMenuItem As ToolStripMenuItem
End Class
