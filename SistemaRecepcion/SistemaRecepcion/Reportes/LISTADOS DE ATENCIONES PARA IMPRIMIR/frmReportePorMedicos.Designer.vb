<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePorMedicos
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
        Me.lista_atenciones_por_medicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lista_atenciones_por_medicoTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.lista_atenciones_por_medicoTableAdapter()
        Me.tbMedRem = New System.Windows.Forms.TextBox()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbxMedico = New System.Windows.Forms.ComboBox()
        Me.MostrarmedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_medicoTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        CType(Me.lista_atenciones_por_medicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lista_atenciones_por_medicoBindingSource
        '
        Me.lista_atenciones_por_medicoBindingSource.DataMember = "lista_atenciones_por_medico"
        Me.lista_atenciones_por_medicoBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtSetListaAtencionMedico"
        ReportDataSource1.Value = Me.lista_atenciones_por_medicoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.rptListaAtencionePorMedico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1069, 516)
        Me.ReportViewer1.TabIndex = 0
        '
        'lista_atenciones_por_medicoTableAdapter
        '
        Me.lista_atenciones_por_medicoTableAdapter.ClearBeforeFill = True
        '
        'tbMedRem
        '
        Me.tbMedRem.Location = New System.Drawing.Point(945, 14)
        Me.tbMedRem.Name = "tbMedRem"
        Me.tbMedRem.Size = New System.Drawing.Size(100, 23)
        Me.tbMedRem.TabIndex = 2
        Me.tbMedRem.Text = "ninguno"
        Me.tbMedRem.Visible = False
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(619, 12)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(100, 23)
        Me.btnRecargar.TabIndex = 5
        Me.btnRecargar.Text = "BUSCAR"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(321, 12)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaInicio.TabIndex = 6
        '
        'cbxMedico
        '
        Me.cbxMedico.DataSource = Me.MostrarmedicoBindingSource
        Me.cbxMedico.DisplayMember = "apellidos"
        Me.cbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMedico.FormattingEnabled = True
        Me.cbxMedico.Location = New System.Drawing.Point(151, 12)
        Me.cbxMedico.Name = "cbxMedico"
        Me.cbxMedico.Size = New System.Drawing.Size(100, 23)
        Me.cbxMedico.TabIndex = 8
        '
        'MostrarmedicoBindingSource
        '
        Me.MostrarmedicoBindingSource.DataMember = "mostrar_medico"
        Me.MostrarmedicoBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'Mostrar_medicoTableAdapter
        '
        Me.Mostrar_medicoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxMedico)
        Me.GroupBox1.Controls.Add(Me.tbMedRem)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.btnRecargar)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1069, 42)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "HASTA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DESDE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MEDICO DESTINATARIO"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(498, 12)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaFin.TabIndex = 7
        '
        'frmReportePorMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 516)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReportePorMedicos"
        Me.Text = "frmReportePorMedicos"
        CType(Me.lista_atenciones_por_medicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarmedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lista_atenciones_por_medicoBindingSource As BindingSource
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents lista_atenciones_por_medicoTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.lista_atenciones_por_medicoTableAdapter
    Friend WithEvents tbMedRem As TextBox
    Friend WithEvents btnRecargar As Button
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents cbxMedico As ComboBox
    Friend WithEvents MostrarmedicoBindingSource As BindingSource
    Friend WithEvents Mostrar_medicoTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.mostrar_medicoTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
End Class
