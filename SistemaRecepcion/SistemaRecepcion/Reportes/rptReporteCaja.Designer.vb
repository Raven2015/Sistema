<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptReporteCaja
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsPreliminar = New SistemaRecepcion.dsPreliminar()
        Me.mostrar_reporte_finalBindingSource = New System.Windows.Forms.BindingSource()
        Me.mostrar_reporte_finalTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter()
        CType(Me.dsPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_reporte_finalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.ComprobanteCaja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(592, 516)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(505, 53)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(75, 23)
        Me.btnRecargar.TabIndex = 6
        Me.btnRecargar.Text = "Recargar"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Location = New System.Drawing.Point(489, 27)
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(100, 20)
        Me.tbIDAtencion.TabIndex = 5
        Me.tbIDAtencion.Text = "0"
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_reporte_finalBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.ComprobanteCaja.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(592, 516)
        Me.ReportViewer2.TabIndex = 7
        '
        'dsPreliminar
        '
        Me.dsPreliminar.DataSetName = "dsPreliminar"
        Me.dsPreliminar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_reporte_finalBindingSource
        '
        Me.mostrar_reporte_finalBindingSource.DataMember = "mostrar_reporte_final"
        Me.mostrar_reporte_finalBindingSource.DataSource = Me.dsPreliminar
        '
        'mostrar_reporte_finalTableAdapter
        '
        Me.mostrar_reporte_finalTableAdapter.ClearBeforeFill = True
        '
        'ReporteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 516)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.tbIDAtencion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "ReporteCaja"
        Me.Text = "ReporteCaja"
        CType(Me.dsPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_reporte_finalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnRecargar As Button
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_reporte_finalBindingSource As BindingSource
    Friend WithEvents dsPreliminar As dsPreliminar
    Friend WithEvents mostrar_reporte_finalTableAdapter As dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter
End Class
