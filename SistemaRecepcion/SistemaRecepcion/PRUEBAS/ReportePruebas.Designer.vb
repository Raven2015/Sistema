<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePruebas
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsInicial = New SistemaRecepcion.dsInicial()
        Me.mostrar_detallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_detallesTableAdapter = New SistemaRecepcion.dsInicialTableAdapters.mostrar_detallesTableAdapter()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dsInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_detallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_detallesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.rptPrueba.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(722, 487)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsInicial
        '
        Me.dsInicial.DataSetName = "dsInicial"
        Me.dsInicial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_detallesBindingSource
        '
        Me.mostrar_detallesBindingSource.DataMember = "mostrar_detalles"
        Me.mostrar_detallesBindingSource.DataSource = Me.dsInicial
        '
        'mostrar_detallesTableAdapter
        '
        Me.mostrar_detallesTableAdapter.ClearBeforeFill = True
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(557, 37)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(133, 20)
        Me.tbID.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ID"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportePruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePruebas"
        Me.Text = "ReportePruebas"
        CType(Me.dsInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_detallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_detallesBindingSource As BindingSource
    Friend WithEvents dsInicial As dsInicial
    Friend WithEvents mostrar_detallesTableAdapter As dsInicialTableAdapters.mostrar_detallesTableAdapter
    Friend WithEvents tbID As TextBox
    Friend WithEvents Button1 As Button
End Class
