<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCategorias
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbBioDataSet = New SistemaRecepcion.dbBioDataSet()
        Me.mostrar_categoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_categoriaTableAdapter = New SistemaRecepcion.dbBioDataSetTableAdapters.mostrar_categoriaTableAdapter()
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_categoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.mostrar_categoriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.RCategorias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(734, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbBioDataSet
        '
        Me.dbBioDataSet.DataSetName = "dbBioDataSet"
        Me.dbBioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_categoriaBindingSource
        '
        Me.mostrar_categoriaBindingSource.DataMember = "mostrar_categoria"
        Me.mostrar_categoriaBindingSource.DataSource = Me.dbBioDataSet
        '
        'mostrar_categoriaTableAdapter
        '
        Me.mostrar_categoriaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteCategorias"
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_categoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_categoriaBindingSource As BindingSource
    Friend WithEvents dbBioDataSet As dbBioDataSet
    Friend WithEvents mostrar_categoriaTableAdapter As dbBioDataSetTableAdapters.mostrar_categoriaTableAdapter
End Class
