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
        Me.btnAtencion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEstudio = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.btnCentral = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAtencion
        '
        Me.btnAtencion.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.calendar_1
        Me.btnAtencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtencion.FlatAppearance.BorderSize = 0
        Me.btnAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtencion.Location = New System.Drawing.Point(7, 287)
        Me.btnAtencion.Name = "btnAtencion"
        Me.btnAtencion.Size = New System.Drawing.Size(70, 70)
        Me.btnAtencion.TabIndex = 3
        Me.btnAtencion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.folder_7
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(7, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEstudio
        '
        Me.btnEstudio.BackColor = System.Drawing.Color.Transparent
        Me.btnEstudio.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.bookmark_11
        Me.btnEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudio.FlatAppearance.BorderSize = 0
        Me.btnEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudio.ForeColor = System.Drawing.Color.Silver
        Me.btnEstudio.Location = New System.Drawing.Point(7, 103)
        Me.btnEstudio.Name = "btnEstudio"
        Me.btnEstudio.Size = New System.Drawing.Size(70, 70)
        Me.btnEstudio.TabIndex = 1
        Me.btnEstudio.UseVisualStyleBackColor = False
        '
        'btnPaciente
        '
        Me.btnPaciente.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.users
        Me.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.ForeColor = System.Drawing.Color.Silver
        Me.btnPaciente.Location = New System.Drawing.Point(7, 11)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(70, 70)
        Me.btnPaciente.TabIndex = 0
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.search
        Me.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLista.FlatAppearance.BorderSize = 0
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Location = New System.Drawing.Point(7, 377)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(70, 70)
        Me.btnLista.TabIndex = 4
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'btnCentral
        '
        Me.btnCentral.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.btnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCentral.FlatAppearance.BorderSize = 0
        Me.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentral.Location = New System.Drawing.Point(7, 479)
        Me.btnCentral.Name = "btnCentral"
        Me.btnCentral.Size = New System.Drawing.Size(70, 70)
        Me.btnCentral.TabIndex = 5
        Me.btnCentral.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(85, 561)
        Me.Controls.Add(Me.btnCentral)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.btnAtencion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEstudio)
        Me.Controls.Add(Me.btnPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "INICIO"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnEstudio As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAtencion As Button
    Friend WithEvents btnLista As Button
    Friend WithEvents btnCentral As Button
End Class
