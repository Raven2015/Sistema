<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportePrueba
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.reporte_etenciones_tiempoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporte_etenciones_tiempoTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.reporte_etenciones_tiempoTableAdapter()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporte_etenciones_tiempoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.reporte_etenciones_tiempoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(822, 646)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_etenciones_tiempoBindingSource
        '
        Me.reporte_etenciones_tiempoBindingSource.DataMember = "reporte_etenciones_tiempo"
        Me.reporte_etenciones_tiempoBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'reporte_etenciones_tiempoTableAdapter
        '
        Me.reporte_etenciones_tiempoTableAdapter.ClearBeforeFill = True
        '
        'reportePrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 646)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportePrueba"
        Me.Text = "reportePrueba"
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporte_etenciones_tiempoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_etenciones_tiempoBindingSource As BindingSource
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents reporte_etenciones_tiempoTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.reporte_etenciones_tiempoTableAdapter
End Class
