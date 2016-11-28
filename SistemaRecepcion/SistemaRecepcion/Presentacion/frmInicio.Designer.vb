<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnEstudio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPaciente
        '
        Me.btnPaciente.Location = New System.Drawing.Point(12, 11)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(75, 23)
        Me.btnPaciente.TabIndex = 0
        Me.btnPaciente.Text = "Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnEstudio
        '
        Me.btnEstudio.Location = New System.Drawing.Point(105, 11)
        Me.btnEstudio.Name = "btnEstudio"
        Me.btnEstudio.Size = New System.Drawing.Size(75, 23)
        Me.btnEstudio.TabIndex = 1
        Me.btnEstudio.Text = "Estudio"
        Me.btnEstudio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Categoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(800, 46)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEstudio)
        Me.Controls.Add(Me.btnPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmInicio"
        Me.Text = "frmInicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnEstudio As Button
    Friend WithEvents Button1 As Button
End Class
