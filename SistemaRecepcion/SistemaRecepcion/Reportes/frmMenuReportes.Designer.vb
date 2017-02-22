<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuReportes
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
        Me.btnListaAtencionesPorMedicos = New System.Windows.Forms.Button()
        Me.btnListaAtencionesPorInstitucion = New System.Windows.Forms.Button()
        Me.btnListaestudiosPorInstitución = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnListaAtencionesPorMedicos
        '
        Me.btnListaAtencionesPorMedicos.BackColor = System.Drawing.Color.DarkOrange
        Me.btnListaAtencionesPorMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaAtencionesPorMedicos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaAtencionesPorMedicos.ForeColor = System.Drawing.Color.White
        Me.btnListaAtencionesPorMedicos.Location = New System.Drawing.Point(62, 71)
        Me.btnListaAtencionesPorMedicos.Name = "btnListaAtencionesPorMedicos"
        Me.btnListaAtencionesPorMedicos.Size = New System.Drawing.Size(144, 56)
        Me.btnListaAtencionesPorMedicos.TabIndex = 0
        Me.btnListaAtencionesPorMedicos.Text = "ATENCIONES POR MÉDICOS"
        Me.btnListaAtencionesPorMedicos.UseVisualStyleBackColor = False
        '
        'btnListaAtencionesPorInstitucion
        '
        Me.btnListaAtencionesPorInstitucion.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnListaAtencionesPorInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaAtencionesPorInstitucion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaAtencionesPorInstitucion.ForeColor = System.Drawing.Color.White
        Me.btnListaAtencionesPorInstitucion.Location = New System.Drawing.Point(62, 143)
        Me.btnListaAtencionesPorInstitucion.Name = "btnListaAtencionesPorInstitucion"
        Me.btnListaAtencionesPorInstitucion.Size = New System.Drawing.Size(144, 56)
        Me.btnListaAtencionesPorInstitucion.TabIndex = 1
        Me.btnListaAtencionesPorInstitucion.Text = "ATENCIONES POR INSTITUCIÓN"
        Me.btnListaAtencionesPorInstitucion.UseVisualStyleBackColor = False
        '
        'btnListaestudiosPorInstitución
        '
        Me.btnListaestudiosPorInstitución.BackColor = System.Drawing.Color.SteelBlue
        Me.btnListaestudiosPorInstitución.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaestudiosPorInstitución.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaestudiosPorInstitución.ForeColor = System.Drawing.Color.White
        Me.btnListaestudiosPorInstitución.Location = New System.Drawing.Point(62, 215)
        Me.btnListaestudiosPorInstitución.Name = "btnListaestudiosPorInstitución"
        Me.btnListaestudiosPorInstitución.Size = New System.Drawing.Size(144, 56)
        Me.btnListaestudiosPorInstitución.TabIndex = 2
        Me.btnListaestudiosPorInstitución.Text = "LISTA DE ESTUDIOS"
        Me.btnListaestudiosPorInstitución.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "REPORTES PARA IMPRIMIR"
        '
        'frmMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(272, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnListaestudiosPorInstitución)
        Me.Controls.Add(Me.btnListaAtencionesPorInstitucion)
        Me.Controls.Add(Me.btnListaAtencionesPorMedicos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenuReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListaAtencionesPorMedicos As Button
    Friend WithEvents btnListaAtencionesPorInstitucion As Button
    Friend WithEvents btnListaestudiosPorInstitución As Button
    Friend WithEvents Label1 As Label
End Class
