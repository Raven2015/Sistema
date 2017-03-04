<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportedeAtencionesporMedicos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.cbxMedico = New System.Windows.Forms.ComboBox()
        Me.MostrarmedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.Mostrar_medicoTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IMPRIMIRREPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXPORTARAEXCELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TODOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERTODOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lknInexistente)
        Me.Panel2.Controls.Add(Me.cbxMedico)
        Me.Panel2.Controls.Add(Me.dgvListadoAtenciones)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpFechaInicio)
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 513)
        Me.Panel2.TabIndex = 21
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lknInexistente.Location = New System.Drawing.Point(329, 267)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(226, 19)
        Me.lknInexistente.TabIndex = 21
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "NO HAY DATOS PARA MOSTRAR"
        '
        'cbxMedico
        '
        Me.cbxMedico.DataSource = Me.MostrarmedicoBindingSource
        Me.cbxMedico.DisplayMember = "apellidos"
        Me.cbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMedico.FormattingEnabled = True
        Me.cbxMedico.Location = New System.Drawing.Point(740, 13)
        Me.cbxMedico.Name = "cbxMedico"
        Me.cbxMedico.Size = New System.Drawing.Size(121, 21)
        Me.cbxMedico.TabIndex = 20
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
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = False
        Me.dgvListadoAtenciones.AllowUserToDeleteRows = False
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(0, 40)
        Me.dgvListadoAtenciones.MultiSelect = False
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(869, 473)
        Me.dgvListadoAtenciones.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "FECHA DE FINALIZACIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(567, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "MEDICO DESTINATARIO"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(139, 13)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaInicio.TabIndex = 10
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(438, 13)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFin.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FECHA DE INICIO"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 552)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 55)
        Me.Panel1.TabIndex = 20
        '
        'ListaEntidadTableAdapter
        '
        Me.ListaEntidadTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_medicoTableAdapter
        '
        Me.Mostrar_medicoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMPRIMIRREPORTEToolStripMenuItem, Me.EXPORTARAEXCELToolStripMenuItem, Me.VERTODOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IMPRIMIRREPORTEToolStripMenuItem
        '
        Me.IMPRIMIRREPORTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TODOSToolStripMenuItem})
        Me.IMPRIMIRREPORTEToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.bookmark_11
        Me.IMPRIMIRREPORTEToolStripMenuItem.Name = "IMPRIMIRREPORTEToolStripMenuItem"
        Me.IMPRIMIRREPORTEToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.IMPRIMIRREPORTEToolStripMenuItem.Text = "IMPRIMIR REPORTE"
        '
        'EXPORTARAEXCELToolStripMenuItem
        '
        Me.EXPORTARAEXCELToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.excelColor
        Me.EXPORTARAEXCELToolStripMenuItem.Name = "EXPORTARAEXCELToolStripMenuItem"
        Me.EXPORTARAEXCELToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.EXPORTARAEXCELToolStripMenuItem.Text = "EXPORTAR A EXCEL"
        '
        'TODOSToolStripMenuItem
        '
        Me.TODOSToolStripMenuItem.Name = "TODOSToolStripMenuItem"
        Me.TODOSToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TODOSToolStripMenuItem.Text = "IMPRIMIR TODOS"
        '
        'VERTODOToolStripMenuItem
        '
        Me.VERTODOToolStripMenuItem.Name = "VERTODOToolStripMenuItem"
        Me.VERTODOToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.VERTODOToolStripMenuItem.Text = "VER TODO"
        '
        'frmReportedeAtencionesporMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 607)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReportedeAtencionesporMedicos"
        Me.Text = "REPORTE DE ATENCIONES POR MEDICO"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents cbxMedico As ComboBox
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents MostrarmedicoBindingSource As BindingSource
    Friend WithEvents Mostrar_medicoTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IMPRIMIRREPORTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXPORTARAEXCELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TODOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VERTODOToolStripMenuItem As ToolStripMenuItem
End Class
