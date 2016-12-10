<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAtencion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbListadoPaciente = New System.Windows.Forms.GroupBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.btnOcultarLista = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVerLista = New System.Windows.Forms.Button()
        Me.AtencionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSeleccionarPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEstudiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.gbListadoPaciente.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPaciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtencionToolStripMenuItem, Me.mnSeleccionarPaciente, Me.ReportesToolStripMenuItem, Me.AñadirEstudiosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'chbxEliminar
        '
        Me.chbxEliminar.AutoSize = True
        Me.chbxEliminar.Location = New System.Drawing.Point(6, 64)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 22
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        Me.chbxEliminar.Visible = False
        '
        'cbCampo
        '
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"ci", "nombres", "apellidos"})
        Me.cbCampo.Location = New System.Drawing.Point(49, 34)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(129, 21)
        Me.cbCampo.TabIndex = 21
        Me.cbCampo.Text = "ci"
        Me.cbCampo.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(3, 37)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 20
        Me.lblBuscar.Text = "Buscar:"
        Me.lblBuscar.Visible = False
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(184, 35)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(143, 20)
        Me.tbBuscar.TabIndex = 22
        Me.tbBuscar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 18
        '
        'gbListadoPaciente
        '
        Me.gbListadoPaciente.Controls.Add(Me.btnVerLista)
        Me.gbListadoPaciente.Controls.Add(Me.lknInexistente)
        Me.gbListadoPaciente.Controls.Add(Me.dgvListado)
        Me.gbListadoPaciente.Location = New System.Drawing.Point(2, 87)
        Me.gbListadoPaciente.Name = "gbListadoPaciente"
        Me.gbListadoPaciente.Size = New System.Drawing.Size(325, 319)
        Me.gbListadoPaciente.TabIndex = 17
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
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(308, 294)
        Me.dgvListado.TabIndex = 0
        Me.dgvListado.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
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
        Me.gbPaciente.Location = New System.Drawing.Point(333, 34)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(326, 279)
        Me.gbPaciente.TabIndex = 16
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
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(258, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(69, 19)
        Me.btnActualizar.TabIndex = 24
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(127, 19)
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(186, 20)
        Me.tbMedicoRemitente.TabIndex = 10
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Fecha de Atención"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaAtencion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbMedicoRemitente)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 77)
        Me.GroupBox1.TabIndex = 25
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
        'btnOcultarLista
        '
        Me.btnOcultarLista.Location = New System.Drawing.Point(183, 61)
        Me.btnOcultarLista.Name = "btnOcultarLista"
        Me.btnOcultarLista.Size = New System.Drawing.Size(69, 19)
        Me.btnOcultarLista.TabIndex = 27
        Me.btnOcultarLista.Text = "Ocultar"
        Me.btnOcultarLista.UseVisualStyleBackColor = True
        Me.btnOcultarLista.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.add_21
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(624, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnVerLista
        '
        Me.btnVerLista.BackColor = System.Drawing.SystemColors.Control
        Me.btnVerLista.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.view_2
        Me.btnVerLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerLista.FlatAppearance.BorderSize = 0
        Me.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerLista.Location = New System.Drawing.Point(117, 118)
        Me.btnVerLista.Name = "btnVerLista"
        Me.btnVerLista.Size = New System.Drawing.Size(102, 84)
        Me.btnVerLista.TabIndex = 27
        Me.btnVerLista.UseVisualStyleBackColor = False
        '
        'AtencionToolStripMenuItem
        '
        Me.AtencionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem2, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.AtencionToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.calendar
        Me.AtencionToolStripMenuItem.Name = "AtencionToolStripMenuItem"
        Me.AtencionToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.AtencionToolStripMenuItem.Text = "Atención"
        '
        'NuevoToolStripMenuItem2
        '
        Me.NuevoToolStripMenuItem2.Image = Global.SistemaRecepcion.My.Resources.Resources.bookmark_1
        Me.NuevoToolStripMenuItem2.Name = "NuevoToolStripMenuItem2"
        Me.NuevoToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.NuevoToolStripMenuItem2.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.edit
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.garbage
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'mnSeleccionarPaciente
        '
        Me.mnSeleccionarPaciente.Image = Global.SistemaRecepcion.My.Resources.Resources.user
        Me.mnSeleccionarPaciente.Name = "mnSeleccionarPaciente"
        Me.mnSeleccionarPaciente.Size = New System.Drawing.Size(143, 20)
        Me.mnSeleccionarPaciente.Text = "Seleccionar Paciente"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.print
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'AñadirEstudiosToolStripMenuItem
        '
        Me.AñadirEstudiosToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.add_11
        Me.AñadirEstudiosToolStripMenuItem.Name = "AñadirEstudiosToolStripMenuItem"
        Me.AñadirEstudiosToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.AñadirEstudiosToolStripMenuItem.Text = "Añadir Estudios"
        '
        'frmAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 413)
        Me.Controls.Add(Me.btnOcultarLista)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbListadoPaciente)
        Me.Controls.Add(Me.gbPaciente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Atención"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbListadoPaciente.ResumeLayout(False)
        Me.gbListadoPaciente.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnSeleccionarPaciente As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnActualizar As Button
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbListadoPaciente As GroupBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents gbPaciente As GroupBox
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbFechaNacimiento As TextBox
    Friend WithEvents tbSexo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents tbIDAtencion As TextBox
    Friend WithEvents AtencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents AñadirEstudiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents btnVerLista As Button
    Friend WithEvents btnOcultarLista As Button
End Class
