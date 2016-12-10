<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleAtencion
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
        Me.gbPaciente = New System.Windows.Forms.GroupBox()
        Me.tbIDAtencion = New System.Windows.Forms.TextBox()
        Me.tbFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.tbSexo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.tbIDCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.gbPaciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPaciente
        '
        Me.gbPaciente.Controls.Add(Me.tbIDAtencion)
        Me.gbPaciente.Controls.Add(Me.tbFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.tbSexo)
        Me.gbPaciente.Controls.Add(Me.Label15)
        Me.gbPaciente.Controls.Add(Me.tbEdad)
        Me.gbPaciente.Controls.Add(Me.Label10)
        Me.gbPaciente.Controls.Add(Me.tbCelular)
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.Label7)
        Me.gbPaciente.Controls.Add(Me.Label4)
        Me.gbPaciente.Controls.Add(Me.Label9)
        Me.gbPaciente.Controls.Add(Me.tbDireccion)
        Me.gbPaciente.Controls.Add(Me.Label6)
        Me.gbPaciente.Controls.Add(Me.Label8)
        Me.gbPaciente.Controls.Add(Me.tbTelefono)
        Me.gbPaciente.Controls.Add(Me.Label5)
        Me.gbPaciente.Controls.Add(Me.tbCI)
        Me.gbPaciente.Controls.Add(Me.Label3)
        Me.gbPaciente.Controls.Add(Me.tbNombres)
        Me.gbPaciente.Controls.Add(Me.tbIDCliente)
        Me.gbPaciente.Location = New System.Drawing.Point(12, 12)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(326, 279)
        Me.gbPaciente.TabIndex = 17
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos del Paciente"
        '
        'tbIDAtencion
        '
        Me.tbIDAtencion.Location = New System.Drawing.Point(239, 259)
        Me.tbIDAtencion.Name = "tbIDAtencion"
        Me.tbIDAtencion.Size = New System.Drawing.Size(87, 20)
        Me.tbIDAtencion.TabIndex = 39
        '
        'tbFechaNacimiento
        '
        Me.tbFechaNacimiento.Location = New System.Drawing.Point(127, 229)
        Me.tbFechaNacimiento.Name = "tbFechaNacimiento"
        Me.tbFechaNacimiento.ReadOnly = True
        Me.tbFechaNacimiento.Size = New System.Drawing.Size(186, 20)
        Me.tbFechaNacimiento.TabIndex = 9
        '
        'tbSexo
        '
        Me.tbSexo.Location = New System.Drawing.Point(80, 151)
        Me.tbSexo.Name = "tbSexo"
        Me.tbSexo.ReadOnly = True
        Me.tbSexo.Size = New System.Drawing.Size(233, 20)
        Me.tbSexo.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 181)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Edad"
        '
        'tbEdad
        '
        Me.tbEdad.Location = New System.Drawing.Point(80, 178)
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.ReadOnly = True
        Me.tbEdad.Size = New System.Drawing.Size(233, 20)
        Me.tbEdad.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Celular"
        '
        'tbCelular
        '
        Me.tbCelular.Location = New System.Drawing.Point(80, 204)
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.ReadOnly = True
        Me.tbCelular.Size = New System.Drawing.Size(233, 20)
        Me.tbCelular.TabIndex = 8
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(80, 47)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(233, 20)
        Me.tbApellidos.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Apellidos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Telefono"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(80, 125)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.ReadOnly = True
        Me.tbDireccion.Size = New System.Drawing.Size(233, 20)
        Me.tbDireccion.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Dirección"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(80, 99)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.ReadOnly = True
        Me.tbTelefono.Size = New System.Drawing.Size(233, 20)
        Me.tbTelefono.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "CI"
        '
        'tbCI
        '
        Me.tbCI.Location = New System.Drawing.Point(80, 73)
        Me.tbCI.Name = "tbCI"
        Me.tbCI.ReadOnly = True
        Me.tbCI.Size = New System.Drawing.Size(233, 20)
        Me.tbCI.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nombres"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(80, 21)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(233, 20)
        Me.tbNombres.TabIndex = 1
        '
        'tbIDCliente
        '
        Me.tbIDCliente.Location = New System.Drawing.Point(0, 259)
        Me.tbIDCliente.Name = "tbIDCliente"
        Me.tbIDCliente.Size = New System.Drawing.Size(87, 20)
        Me.tbIDCliente.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaAtencion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbMedicoRemitente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 77)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Atención"
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(127, 43)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(186, 20)
        Me.dtpFechaAtencion.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Fecha de Atención"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Doctor Remitente"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(127, 19)
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(186, 20)
        Me.tbMedicoRemitente.TabIndex = 10
        '
        'frmDetalleAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPaciente)
        Me.Name = "frmDetalleAtencion"
        Me.Text = "frmDetalleAtencion"
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbPaciente As GroupBox
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents tbFechaNacimiento As TextBox
    Friend WithEvents tbSexo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbMedicoRemitente As TextBox
End Class
