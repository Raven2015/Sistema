﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCajaFinal
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
        Me.mostrar_reporte_finalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPreliminar = New SistemaRecepcion.dsPreliminar()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_reporte_finalTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        CType(Me.mostrar_reporte_finalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_reporte_finalBindingSource
        '
        Me.mostrar_reporte_finalBindingSource.DataMember = "mostrar_reporte_final"
        Me.mostrar_reporte_finalBindingSource.DataSource = Me.dsPreliminar
        '
        'dsPreliminar
        '
        Me.dsPreliminar.DataSetName = "dsPreliminar"
        Me.dsPreliminar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_reporte_finalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecepcion.ComprobanteCaja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(679, 511)
        Me.ReportViewer1.TabIndex = 0
        '
        'mostrar_reporte_finalTableAdapter
        '
        Me.mostrar_reporte_finalTableAdapter.ClearBeforeFill = True
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(592, 60)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(75, 23)
        Me.btnRecargar.TabIndex = 8
        Me.btnRecargar.Text = "Recargar"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Location = New System.Drawing.Point(576, 34)
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(100, 20)
        Me.tbIDAtencion.TabIndex = 7
        Me.tbIDAtencion.Text = "0"
        '
        'ReporteCajaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 511)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.tbIDAtencion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteCajaFinal"
        Me.Text = "REPORTE DE CAJA"
        CType(Me.mostrar_reporte_finalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_reporte_finalBindingSource As BindingSource
    Friend WithEvents dsPreliminar As dsPreliminar
    Friend WithEvents mostrar_reporte_finalTableAdapter As dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter
    Friend WithEvents btnRecargar As Button
    Friend WithEvents tbIDAtencion As TextBox
End Class
