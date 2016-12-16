<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobante
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
        Me.comprobante_atencionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbBIOMEDICADataSet = New SistemaRecepcion.dbBIOMEDICADataSet()
        Me.comprobante_atencionTableAdapter = New SistemaRecepcion.dbBIOMEDICADataSetTableAdapters.comprobante_atencionTableAdapter()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.dsInicial = New SistemaRecepcion.dsInicial()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.comprobante_atencionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbBIOMEDICADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comprobante_atencionBindingSource
        '
        Me.comprobante_atencionBindingSource.DataMember = "comprobante_atencion"
        Me.comprobante_atencionBindingSource.DataSource = Me.dbBIOMEDICADataSet
        '
        'dbBIOMEDICADataSet
        '
        Me.dbBIOMEDICADataSet.DataSetName = "dbBIOMEDICADataSet"
        Me.dbBIOMEDICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comprobante_atencionTableAdapter
        '
        Me.comprobante_atencionTableAdapter.ClearBeforeFill = True
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Location = New System.Drawing.Point(572, 82)
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(100, 20)
        Me.tbIDAtencion.TabIndex = 1
        '
        'dsInicial
        '
        Me.dsInicial.DataSetName = "dsInicial"
        Me.dsInicial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.comprobante_atencionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 561)
        Me.ReportViewer1.TabIndex = 2
        '
        'frmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.tbIDAtencion)
        Me.Name = "frmComprobante"
        Me.Text = "frmComprobante"
        CType(Me.comprobante_atencionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbBIOMEDICADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comprobante_atencionBindingSource As BindingSource
    Friend WithEvents comprobante_atencionTableAdapter As dbBIOMEDICADataSetTableAdapters.comprobante_atencionTableAdapter
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents dbBIOMEDICADataSet As dbBIOMEDICADataSet
    Friend WithEvents dsInicial As dsInicial
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
