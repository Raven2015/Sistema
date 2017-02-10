<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstudiosPorEntidad
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
        Me.estudios_por_entidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.estudios_por_entidadTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.estudios_por_entidadTableAdapter()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.cbxEntidad = New System.Windows.Forms.ComboBox()
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        CType(Me.estudios_por_entidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'estudios_por_entidadBindingSource
        '
        Me.estudios_por_entidadBindingSource.DataMember = "estudios_por_entidad"
        Me.estudios_por_entidadBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.estudios_por_entidadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.rptEstudioPorEntidad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(925, 622)
        Me.ReportViewer1.TabIndex = 0
        '
        'estudios_por_entidadTableAdapter
        '
        Me.estudios_por_entidadTableAdapter.ClearBeforeFill = True
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(821, 74)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(75, 23)
        Me.btnRecargar.TabIndex = 2
        Me.btnRecargar.Text = "RECARGAR"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'cbxEntidad
        '
        Me.cbxEntidad.DataSource = Me.ListaEntidadBindingSource
        Me.cbxEntidad.DisplayMember = "nombre_entidad"
        Me.cbxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntidad.FormattingEnabled = True
        Me.cbxEntidad.Location = New System.Drawing.Point(792, 47)
        Me.cbxEntidad.Name = "cbxEntidad"
        Me.cbxEntidad.Size = New System.Drawing.Size(121, 21)
        Me.cbxEntidad.TabIndex = 3
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
        'frmEstudiosPorEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 622)
        Me.Controls.Add(Me.cbxEntidad)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEstudiosPorEntidad"
        Me.Text = "LISTA DE ESTUDIOS"
        CType(Me.estudios_por_entidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents estudios_por_entidadBindingSource As BindingSource
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents estudios_por_entidadTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.estudios_por_entidadTableAdapter
    Friend WithEvents btnRecargar As Button
    Friend WithEvents cbxEntidad As ComboBox
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
End Class
