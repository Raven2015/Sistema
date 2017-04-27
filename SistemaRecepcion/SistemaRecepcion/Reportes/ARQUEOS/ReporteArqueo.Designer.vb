<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArqueo
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ingresos_diarios_por_categoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.rpvwArqueos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ingresos_diarios_por_categoriaTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.ingresos_diarios_por_categoriaTableAdapter()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTurno = New System.Windows.Forms.TextBox()
        CType(Me.ingresos_diarios_por_categoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingresos_diarios_por_categoriaBindingSource
        '
        Me.ingresos_diarios_por_categoriaBindingSource.DataMember = "ingresos_diarios_por_categoria"
        Me.ingresos_diarios_por_categoriaBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvwArqueos
        '
        Me.rpvwArqueos.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsArqueos"
        ReportDataSource1.Value = Me.ingresos_diarios_por_categoriaBindingSource
        Me.rpvwArqueos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvwArqueos.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.rptArqueo.rdlc"
        Me.rpvwArqueos.Location = New System.Drawing.Point(0, 0)
        Me.rpvwArqueos.Name = "rpvwArqueos"
        Me.rpvwArqueos.Size = New System.Drawing.Size(650, 660)
        Me.rpvwArqueos.TabIndex = 0
        Me.rpvwArqueos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ingresos_diarios_por_categoriaTableAdapter
        '
        Me.ingresos_diarios_por_categoriaTableAdapter.ClearBeforeFill = True
        '
        'tbEntidad
        '
        Me.tbEntidad.Location = New System.Drawing.Point(522, 119)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.Size = New System.Drawing.Size(100, 20)
        Me.tbEntidad.TabIndex = 1
        Me.tbEntidad.Text = "PARTICULAR"
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(522, 145)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(100, 20)
        Me.tbFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(448, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ENTIDAD: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(448, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FECHA: "
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(537, 171)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(75, 23)
        Me.btnRecargar.TabIndex = 5
        Me.btnRecargar.Text = "RECARGAR"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(448, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TURNO: "
        '
        'tbTurno
        '
        Me.tbTurno.Location = New System.Drawing.Point(522, 93)
        Me.tbTurno.Name = "tbTurno"
        Me.tbTurno.Size = New System.Drawing.Size(100, 20)
        Me.tbTurno.TabIndex = 6
        Me.tbTurno.Text = "%"
        '
        'ReporteArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 660)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTurno)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbEntidad)
        Me.Controls.Add(Me.rpvwArqueos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReporteArqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARQUEO DE CAJA"
        CType(Me.ingresos_diarios_por_categoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rpvwArqueos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ingresos_diarios_por_categoriaBindingSource As BindingSource
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents ingresos_diarios_por_categoriaTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.ingresos_diarios_por_categoriaTableAdapter
    Friend WithEvents tbEntidad As TextBox
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRecargar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTurno As TextBox
End Class
