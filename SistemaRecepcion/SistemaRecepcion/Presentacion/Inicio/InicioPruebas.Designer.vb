﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioPruebas
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
        Me.btnReporteCaja = New System.Windows.Forms.Button()
        Me.btnReporteAtencion = New System.Windows.Forms.Button()
        Me.btnArqueos = New System.Windows.Forms.Button()
        Me.btnReporteArqueo = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnReporteAtencionesTiempoEntidad = New System.Windows.Forms.Button()
        Me.btnReporteTiempoEntidad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReporteCaja
        '
        Me.btnReporteCaja.Location = New System.Drawing.Point(12, 12)
        Me.btnReporteCaja.Name = "btnReporteCaja"
        Me.btnReporteCaja.Size = New System.Drawing.Size(110, 23)
        Me.btnReporteCaja.TabIndex = 0
        Me.btnReporteCaja.Text = "Reporte Caja"
        Me.btnReporteCaja.UseVisualStyleBackColor = True
        '
        'btnReporteAtencion
        '
        Me.btnReporteAtencion.Location = New System.Drawing.Point(12, 41)
        Me.btnReporteAtencion.Name = "btnReporteAtencion"
        Me.btnReporteAtencion.Size = New System.Drawing.Size(110, 23)
        Me.btnReporteAtencion.TabIndex = 1
        Me.btnReporteAtencion.Text = "Reporte atencion"
        Me.btnReporteAtencion.UseVisualStyleBackColor = True
        '
        'btnArqueos
        '
        Me.btnArqueos.Location = New System.Drawing.Point(12, 70)
        Me.btnArqueos.Name = "btnArqueos"
        Me.btnArqueos.Size = New System.Drawing.Size(110, 23)
        Me.btnArqueos.TabIndex = 2
        Me.btnArqueos.Text = "Arqueos"
        Me.btnArqueos.UseVisualStyleBackColor = True
        '
        'btnReporteArqueo
        '
        Me.btnReporteArqueo.Location = New System.Drawing.Point(12, 99)
        Me.btnReporteArqueo.Name = "btnReporteArqueo"
        Me.btnReporteArqueo.Size = New System.Drawing.Size(110, 23)
        Me.btnReporteArqueo.TabIndex = 3
        Me.btnReporteArqueo.Text = "REPORTE"
        Me.btnReporteArqueo.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 128)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(110, 23)
        Me.btnInicio.TabIndex = 4
        Me.btnInicio.Text = "INICIO NORMAL"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnReporteAtencionesTiempoEntidad
        '
        Me.btnReporteAtencionesTiempoEntidad.Location = New System.Drawing.Point(12, 157)
        Me.btnReporteAtencionesTiempoEntidad.Name = "btnReporteAtencionesTiempoEntidad"
        Me.btnReporteAtencionesTiempoEntidad.Size = New System.Drawing.Size(110, 40)
        Me.btnReporteAtencionesTiempoEntidad.TabIndex = 5
        Me.btnReporteAtencionesTiempoEntidad.Text = "RPT. DE ATENC./ENT."
        Me.btnReporteAtencionesTiempoEntidad.UseVisualStyleBackColor = True
        '
        'btnReporteTiempoEntidad
        '
        Me.btnReporteTiempoEntidad.Location = New System.Drawing.Point(128, 12)
        Me.btnReporteTiempoEntidad.Name = "btnReporteTiempoEntidad"
        Me.btnReporteTiempoEntidad.Size = New System.Drawing.Size(110, 23)
        Me.btnReporteTiempoEntidad.TabIndex = 6
        Me.btnReporteTiempoEntidad.Text = "REPORTE"
        Me.btnReporteTiempoEntidad.UseVisualStyleBackColor = True
        '
        'InicioPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 237)
        Me.Controls.Add(Me.btnReporteTiempoEntidad)
        Me.Controls.Add(Me.btnReporteAtencionesTiempoEntidad)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnReporteArqueo)
        Me.Controls.Add(Me.btnArqueos)
        Me.Controls.Add(Me.btnReporteAtencion)
        Me.Controls.Add(Me.btnReporteCaja)
        Me.Name = "InicioPruebas"
        Me.Text = "Iniciodvp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReporteCaja As Button
    Friend WithEvents btnReporteAtencion As Button
    Friend WithEvents btnArqueos As Button
    Friend WithEvents btnReporteArqueo As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnReporteAtencionesTiempoEntidad As Button
    Friend WithEvents btnReporteTiempoEntidad As Button
End Class
