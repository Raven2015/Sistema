<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        'InicioPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 237)
        Me.Controls.Add(Me.btnReporteAtencion)
        Me.Controls.Add(Me.btnReporteCaja)
        Me.Name = "InicioPruebas"
        Me.Text = "Iniciodvp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReporteCaja As Button
    Friend WithEvents btnReporteAtencion As Button
End Class
