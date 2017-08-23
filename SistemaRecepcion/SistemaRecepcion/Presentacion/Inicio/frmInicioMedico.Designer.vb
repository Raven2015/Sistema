<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioMedico
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
        Me.lbpacientes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCentral = New System.Windows.Forms.Button()
        Me.btnEstudio = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbIDUsuario = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbpacientes
        '
        Me.lbpacientes.AutoSize = True
        Me.lbpacientes.Location = New System.Drawing.Point(26, 145)
        Me.lbpacientes.Name = "lbpacientes"
        Me.lbpacientes.Size = New System.Drawing.Size(67, 13)
        Me.lbpacientes.TabIndex = 9
        Me.lbpacientes.Text = "PACIENTES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "INFORME " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MÉDICO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "SALIR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "DOCTORES"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.logout
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(302, 72)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(70, 70)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCentral
        '
        Me.btnCentral.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.btnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCentral.FlatAppearance.BorderSize = 0
        Me.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentral.Location = New System.Drawing.Point(200, 73)
        Me.btnCentral.Name = "btnCentral"
        Me.btnCentral.Size = New System.Drawing.Size(70, 70)
        Me.btnCentral.TabIndex = 5
        Me.btnCentral.UseVisualStyleBackColor = True
        '
        'btnEstudio
        '
        Me.btnEstudio.BackColor = System.Drawing.Color.Transparent
        Me.btnEstudio.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.bookmark_11
        Me.btnEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudio.FlatAppearance.BorderSize = 0
        Me.btnEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudio.ForeColor = System.Drawing.Color.Silver
        Me.btnEstudio.Location = New System.Drawing.Point(111, 73)
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
        Me.btnPaciente.Location = New System.Drawing.Point(23, 72)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(70, 70)
        Me.btnPaciente.TabIndex = 0
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(287, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 128)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Teal
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 52)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ESTUDIOS"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.BackColor = System.Drawing.Color.Teal
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(317, 20)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(28, 17)
        Me.lblApellido.TabIndex = 58
        Me.lblApellido.Text = "----"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Teal
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(260, 20)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(28, 17)
        Me.lblUsuario.TabIndex = 57
        Me.lblUsuario.Text = "----"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(196, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Usuario:"
        '
        'lbIDUsuario
        '
        Me.lbIDUsuario.AutoSize = True
        Me.lbIDUsuario.BackColor = System.Drawing.Color.Teal
        Me.lbIDUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDUsuario.ForeColor = System.Drawing.Color.White
        Me.lbIDUsuario.Location = New System.Drawing.Point(226, 3)
        Me.lbIDUsuario.Name = "lbIDUsuario"
        Me.lbIDUsuario.Size = New System.Drawing.Size(28, 17)
        Me.lbIDUsuario.TabIndex = 61
        Me.lbIDUsuario.Text = "----"
        Me.lbIDUsuario.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(197, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "ID:"
        Me.Label9.Visible = False
        '
        'frmInicioMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 180)
        Me.Controls.Add(Me.lbIDUsuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbpacientes)
        Me.Controls.Add(Me.btnCentral)
        Me.Controls.Add(Me.btnEstudio)
        Me.Controls.Add(Me.btnPaciente)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "INICIO"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnEstudio As Button
    Friend WithEvents btnCentral As Button
    Friend WithEvents lbpacientes As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbIDUsuario As Label
    Friend WithEvents Label9 As Label
End Class
