<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.tbIDCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbListadoPaciente = New System.Windows.Forms.GroupBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNIT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbCodigoAsegurado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.tbInstitucion = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbPaciente.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbListadoPaciente.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPaciente
        '
        Me.gbPaciente.Controls.Add(Me.cbSexo)
        Me.gbPaciente.Controls.Add(Me.tbIDCliente)
        Me.gbPaciente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.Label15)
        Me.gbPaciente.Controls.Add(Me.tbEdad)
        Me.gbPaciente.Controls.Add(Me.Label10)
        Me.gbPaciente.Controls.Add(Me.tbCelular)
        Me.gbPaciente.Controls.Add(Me.Label9)
        Me.gbPaciente.Controls.Add(Me.tbTelefono)
        Me.gbPaciente.Controls.Add(Me.Label8)
        Me.gbPaciente.Controls.Add(Me.tbDireccion)
        Me.gbPaciente.Controls.Add(Me.Label7)
        Me.gbPaciente.Controls.Add(Me.Label5)
        Me.gbPaciente.Controls.Add(Me.tbCI)
        Me.gbPaciente.Controls.Add(Me.Label6)
        Me.gbPaciente.Controls.Add(Me.Label4)
        Me.gbPaciente.Controls.Add(Me.Label3)
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.tbNombres)
        Me.gbPaciente.Location = New System.Drawing.Point(383, 37)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(389, 270)
        Me.gbPaciente.TabIndex = 0
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos del Paciente"
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(7, 144)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(170, 21)
        Me.cbSexo.TabIndex = 22
        '
        'tbIDCliente
        '
        Me.tbIDCliente.Location = New System.Drawing.Point(302, -4)
        Me.tbIDCliente.Name = "tbIDCliente"
        Me.tbIDCliente.Size = New System.Drawing.Size(87, 20)
        Me.tbIDCliente.TabIndex = 21
        Me.tbIDCliente.Visible = False
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(214, 94)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(169, 20)
        Me.dtpFechaNacimiento.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(75, 221)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Edad"
        '
        'tbEdad
        '
        Me.tbEdad.Location = New System.Drawing.Point(7, 242)
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.Size = New System.Drawing.Size(170, 20)
        Me.tbEdad.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(281, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Celular"
        '
        'tbCelular
        '
        Me.tbCelular.Location = New System.Drawing.Point(213, 193)
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(170, 20)
        Me.tbCelular.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Telefono"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(7, 193)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(170, 20)
        Me.tbTelefono.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Dirección"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(213, 144)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(170, 20)
        Me.tbDireccion.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CI"
        '
        'tbCI
        '
        Me.tbCI.Location = New System.Drawing.Point(7, 95)
        Me.tbCI.Name = "tbCI"
        Me.tbCI.Size = New System.Drawing.Size(170, 20)
        Me.tbCI.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres"
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(213, 46)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(170, 20)
        Me.tbApellidos.TabIndex = 1
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(6, 46)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(170, 20)
        Me.tbNombres.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.bookmark_1
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.edit
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.garbage
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'gbListadoPaciente
        '
        Me.gbListadoPaciente.Controls.Add(Me.lknInexistente)
        Me.gbListadoPaciente.Controls.Add(Me.dgvListado)
        Me.gbListadoPaciente.Location = New System.Drawing.Point(12, 90)
        Me.gbListadoPaciente.Name = "gbListadoPaciente"
        Me.gbListadoPaciente.Size = New System.Drawing.Size(355, 359)
        Me.gbListadoPaciente.TabIndex = 1
        Me.gbListadoPaciente.TabStop = False
        Me.gbListadoPaciente.Text = "Listado de Pacientes"
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(125, 168)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(94, 13)
        Me.lknInexistente.TabIndex = 1
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "Datos Inexistentes"
        '
        'dgvListado
        '
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvListado.Location = New System.Drawing.Point(6, 19)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(343, 334)
        Me.dgvListado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(207, 37)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(160, 20)
        Me.tbBuscar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar:"
        '
        'cbCampo
        '
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"ci", "nombres", "apellidos"})
        Me.cbCampo.Location = New System.Drawing.Point(59, 37)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(142, 21)
        Me.cbCampo.TabIndex = 5
        Me.cbCampo.Text = "ci"
        '
        'chbxEliminar
        '
        Me.chbxEliminar.AutoSize = True
        Me.chbxEliminar.Location = New System.Drawing.Point(16, 67)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 6
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbNIT)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tbCodigoAsegurado)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbRazonSocial)
        Me.GroupBox1.Controls.Add(Me.tbInstitucion)
        Me.GroupBox1.Location = New System.Drawing.Point(383, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 136)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para la factura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(77, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "NIT"
        '
        'tbNIT
        '
        Me.tbNIT.Location = New System.Drawing.Point(7, 103)
        Me.tbNIT.Name = "tbNIT"
        Me.tbNIT.Size = New System.Drawing.Size(170, 20)
        Me.tbNIT.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(250, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Código de Asegurado"
        '
        'tbCodigoAsegurado
        '
        Me.tbCodigoAsegurado.Location = New System.Drawing.Point(214, 103)
        Me.tbCodigoAsegurado.Name = "tbCodigoAsegurado"
        Me.tbCodigoAsegurado.Size = New System.Drawing.Size(170, 20)
        Me.tbCodigoAsegurado.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Razon Social"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Institucion Aseguradora"
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Location = New System.Drawing.Point(213, 50)
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(170, 20)
        Me.tbRazonSocial.TabIndex = 1
        '
        'tbInstitucion
        '
        Me.tbInstitucion.Location = New System.Drawing.Point(6, 50)
        Me.tbInstitucion.Name = "tbInstitucion"
        Me.tbInstitucion.Size = New System.Drawing.Size(170, 20)
        Me.tbInstitucion.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(297, 64)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(69, 19)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbListadoPaciente)
        Me.Controls.Add(Me.gbPaciente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCliente"
        Me.Text = "Pacientes"
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbListadoPaciente.ResumeLayout(False)
        Me.gbListadoPaciente.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbPaciente As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbListadoPaciente As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNIT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbCodigoAsegurado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents tbInstitucion As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
