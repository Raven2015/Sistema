<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAtencionesLapsoTiempo
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
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxEntidad = New System.Windows.Forms.ComboBox()
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimirReporte = New System.Windows.Forms.Button()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(784, 506)
        Me.dgvListadoAtenciones.TabIndex = 11
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(139, 13)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaInicio.TabIndex = 10
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
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(438, 13)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFin.TabIndex = 17
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnImprimirReporte)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 552)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 55)
        Me.Panel1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(567, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ENTIDAD"
        '
        'cbxEntidad
        '
        Me.cbxEntidad.DataSource = Me.ListaEntidadBindingSource
        Me.cbxEntidad.DisplayMember = "nombre_entidad"
        Me.cbxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntidad.FormattingEnabled = True
        Me.cbxEntidad.Location = New System.Drawing.Point(641, 13)
        Me.cbxEntidad.Name = "cbxEntidad"
        Me.cbxEntidad.Size = New System.Drawing.Size(121, 21)
        Me.cbxEntidad.TabIndex = 20
        '
        'DsListaEntidades
        '
        Me.DsListaEntidades.DataSetName = "dsListaEntidades"
        Me.DsListaEntidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbxEntidad)
        Me.Panel2.Controls.Add(Me.dgvListadoAtenciones)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpFechaInicio)
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 546)
        Me.Panel2.TabIndex = 19
        '
        'btnImprimirReporte
        '
        Me.btnImprimirReporte.BackColor = System.Drawing.Color.White
        Me.btnImprimirReporte.FlatAppearance.BorderSize = 0
        Me.btnImprimirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirReporte.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirReporte.Location = New System.Drawing.Point(690, 7)
        Me.btnImprimirReporte.Name = "btnImprimirReporte"
        Me.btnImprimirReporte.Size = New System.Drawing.Size(82, 40)
        Me.btnImprimirReporte.TabIndex = 0
        Me.btnImprimirReporte.Text = "Imprimir Reporte"
        Me.btnImprimirReporte.UseVisualStyleBackColor = False
        '
        'frmReporteAtencionesLapsoTiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 607)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmReporteAtencionesLapsoTiempo"
        Me.Text = "REPORTE DE ATENCIONES"
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxEntidad As ComboBox
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
    Friend WithEvents btnImprimirReporte As Button
    Friend WithEvents Panel2 As Panel
End Class
