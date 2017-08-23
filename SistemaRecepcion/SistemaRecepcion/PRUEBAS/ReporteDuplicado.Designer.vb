<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDuplicado
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reporte_modificadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbReportes = New SistemaRecepcion.dbReportes()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reporte_modificadoTableAdapter = New SistemaRecepcion.dbReportesTableAdapters.reporte_modificadoTableAdapter()
        CType(Me.reporte_modificadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reporte_modificadoBindingSource
        '
        Me.reporte_modificadoBindingSource.DataMember = "reporte_modificado"
        Me.reporte_modificadoBindingSource.DataSource = Me.dbReportes
        '
        'dbReportes
        '
        Me.dbReportes.DataSetName = "dbReportes"
        Me.dbReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(579, 54)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(69, 23)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = True
        Me.btnGenerar.Visible = False
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(541, 28)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(133, 20)
        Me.tbID.TabIndex = 5
        Me.tbID.Text = "0"
        Me.tbID.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "ReporteDuplicado"
        ReportDataSource2.Value = Me.reporte_modificadoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.ReporteDuplicado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 531)
        Me.ReportViewer1.TabIndex = 7
        '
        'reporte_modificadoTableAdapter
        '
        Me.reporte_modificadoTableAdapter.ClearBeforeFill = True
        '
        'frmReporteDuplicado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 531)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteDuplicado"
        Me.Text = "REPORTE DUPLICADO"
        CType(Me.reporte_modificadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents tbID As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_modificadoBindingSource As BindingSource
    Friend WithEvents dbReportes As dbReportes
    Friend WithEvents reporte_modificadoTableAdapter As dbReportesTableAdapters.reporte_modificadoTableAdapter
End Class
