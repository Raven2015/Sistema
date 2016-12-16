<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEntidad = New System.Windows.Forms.Button()
        Me.btnCentral = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEstudio = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.lbpacientes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEntidad
        '
        Me.btnEntidad.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.house
        Me.btnEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEntidad.FlatAppearance.BorderSize = 0
        Me.btnEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntidad.Location = New System.Drawing.Point(7, 525)
        Me.btnEntidad.Name = "btnEntidad"
        Me.btnEntidad.Size = New System.Drawing.Size(70, 70)
        Me.btnEntidad.TabIndex = 8
        Me.btnEntidad.UseVisualStyleBackColor = True
        '
        'btnCentral
        '
        Me.btnCentral.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.btnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCentral.FlatAppearance.BorderSize = 0
        Me.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentral.Location = New System.Drawing.Point(7, 428)
        Me.btnCentral.Name = "btnCentral"
        Me.btnCentral.Size = New System.Drawing.Size(70, 70)
        Me.btnCentral.TabIndex = 5
        Me.btnCentral.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.search
        Me.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLista.FlatAppearance.BorderSize = 0
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Location = New System.Drawing.Point(7, 319)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(70, 70)
        Me.btnLista.TabIndex = 4
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.folder_7
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(7, 217)
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
        Me.btnEstudio.Location = New System.Drawing.Point(7, 113)
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
        'lbpacientes
        '
        Me.lbpacientes.AutoSize = True
        Me.lbpacientes.Location = New System.Drawing.Point(10, 84)
        Me.lbpacientes.Name = "lbpacientes"
        Me.lbpacientes.Size = New System.Drawing.Size(67, 13)
        Me.lbpacientes.TabIndex = 9
        Me.lbpacientes.Text = "PACIENTES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ESTUDIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CATEGORIAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "LISTA DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " PRECIOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ATENCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 598)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ENTIDADES"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(85, 617)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbpacientes)
        Me.Controls.Add(Me.btnEntidad)
        Me.Controls.Add(Me.btnCentral)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEstudio)
        Me.Controls.Add(Me.btnPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "INICIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnEstudio As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLista As Button
    Friend WithEvents btnCentral As Button
    Friend WithEvents btnEntidad As Button
    Friend WithEvents lbpacientes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
