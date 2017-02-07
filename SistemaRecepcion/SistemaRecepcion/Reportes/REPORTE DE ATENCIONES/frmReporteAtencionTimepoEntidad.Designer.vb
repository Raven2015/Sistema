<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteAtencionTimepoEntidad
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.tbFechaInicio = New System.Windows.Forms.TextBox()
        Me.tbFechaFin = New System.Windows.Forms.TextBox()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_atenciones_lapso_tiempo_entidadTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.mostrar_atenciones_lapso_tiempo_entidadTableAdapter()
        CType(Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_atenciones_lapso_tiempo_entidadBindingSource
        '
        Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource.DataMember = "mostrar_atenciones_lapso_tiempo_entidad"
        Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbFechaInicio
        '
        Me.tbFechaInicio.Location = New System.Drawing.Point(658, 50)
        Me.tbFechaInicio.Name = "tbFechaInicio"
        Me.tbFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.tbFechaInicio.TabIndex = 1
        Me.tbFechaInicio.Text = "01-01-2017"
        '
        'tbFechaFin
        '
        Me.tbFechaFin.Location = New System.Drawing.Point(658, 76)
        Me.tbFechaFin.Name = "tbFechaFin"
        Me.tbFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.tbFechaFin.TabIndex = 2
        Me.tbFechaFin.Text = "01-02-2017"
        '
        'tbEntidad
        '
        Me.tbEntidad.Location = New System.Drawing.Point(658, 102)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.Size = New System.Drawing.Size(100, 20)
        Me.tbEntidad.TabIndex = 3
        Me.tbEntidad.Text = "PARTICULAR"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.rptReporteAtencionesTiempoEntidad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 711)
        Me.ReportViewer1.TabIndex = 4
        '
        'mostrar_atenciones_lapso_tiempo_entidadTableAdapter
        '
        Me.mostrar_atenciones_lapso_tiempo_entidadTableAdapter.ClearBeforeFill = True
        '
        'frmReporteAtencionTimepoEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 711)
        Me.Controls.Add(Me.tbEntidad)
        Me.Controls.Add(Me.tbFechaFin)
        Me.Controls.Add(Me.tbFechaInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteAtencionTimepoEntidad"
        Me.Text = "REPORTE DE ATENCIONES"
        CType(Me.mostrar_atenciones_lapso_tiempo_entidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbFechaInicio As TextBox
    Friend WithEvents tbFechaFin As TextBox
    Friend WithEvents tbEntidad As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_atenciones_lapso_tiempo_entidadBindingSource As BindingSource
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents mostrar_atenciones_lapso_tiempo_entidadTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.mostrar_atenciones_lapso_tiempo_entidadTableAdapter
End Class
