﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditarCliente
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
        Me.components = New System.ComponentModel.Container()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNIT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbCodigoAsegurado = New System.Windows.Forms.TextBox()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCI = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.gbPaciente = New System.Windows.Forms.GroupBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.tbIDCliente = New System.Windows.Forms.TextBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.cbxInstitucion = New System.Windows.Forms.ComboBox()
        Me.DsListaEntidades = New SistemaRecepcion.dsListaEntidades()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsListaEntidadesTableAdapters.listaEntidadTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.gbPaciente.SuspendLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(316, 27)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(170, 20)
        Me.tbApellidos.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "NIT"
        '
        'tbNIT
        '
        Me.tbNIT.Location = New System.Drawing.Point(140, 49)
        Me.tbNIT.Name = "tbNIT"
        Me.tbNIT.Size = New System.Drawing.Size(207, 20)
        Me.tbNIT.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Código de Asegurado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Institucion Aseguradora"
        '
        'tbCodigoAsegurado
        '
        Me.tbCodigoAsegurado.Location = New System.Drawing.Point(140, 101)
        Me.tbCodigoAsegurado.Name = "tbCodigoAsegurado"
        Me.tbCodigoAsegurado.Size = New System.Drawing.Size(207, 20)
        Me.tbCodigoAsegurado.TabIndex = 6
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Location = New System.Drawing.Point(140, 75)
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(207, 20)
        Me.tbRazonSocial.TabIndex = 1
        '
        'tbCelular
        '
        Me.tbCelular.Location = New System.Drawing.Point(316, 105)
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(170, 20)
        Me.tbCelular.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Telefono"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Razon Social"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(144, 131)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(169, 20)
        Me.dtpFechaNacimiento.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(264, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Edad"
        '
        'tbEdad
        '
        Me.tbEdad.Enabled = False
        Me.tbEdad.Location = New System.Drawing.Point(316, 79)
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.Size = New System.Drawing.Size(170, 20)
        Me.tbEdad.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Celular"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(317, 325)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxInstitucion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbNIT)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbCodigoAsegurado)
        Me.GroupBox1.Controls.Add(Me.tbRazonSocial)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 130)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para la factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(130, 325)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(73, 79)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(170, 20)
        Me.tbTelefono.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CI"
        '
        'tbCI
        '
        Me.tbCI.Location = New System.Drawing.Point(73, 53)
        Me.tbCI.Name = "tbCI"
        Me.tbCI.Size = New System.Drawing.Size(170, 20)
        Me.tbCI.TabIndex = 8
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(73, 27)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(170, 20)
        Me.tbNombres.TabIndex = 0
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
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.tbDireccion)
        Me.gbPaciente.Controls.Add(Me.Label6)
        Me.gbPaciente.Controls.Add(Me.Label8)
        Me.gbPaciente.Controls.Add(Me.tbTelefono)
        Me.gbPaciente.Controls.Add(Me.Label7)
        Me.gbPaciente.Controls.Add(Me.Label4)
        Me.gbPaciente.Controls.Add(Me.Label5)
        Me.gbPaciente.Controls.Add(Me.tbCI)
        Me.gbPaciente.Controls.Add(Me.Label3)
        Me.gbPaciente.Controls.Add(Me.tbNombres)
        Me.gbPaciente.Location = New System.Drawing.Point(11, 13)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(503, 165)
        Me.gbPaciente.TabIndex = 18
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos del Paciente"
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(316, 52)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(170, 21)
        Me.cbSexo.TabIndex = 23
        '
        'tbIDCliente
        '
        Me.tbIDCliente.Location = New System.Drawing.Point(426, -1)
        Me.tbIDCliente.Name = "tbIDCliente"
        Me.tbIDCliente.Size = New System.Drawing.Size(77, 20)
        Me.tbIDCliente.TabIndex = 21
        Me.tbIDCliente.Visible = False
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Dirección"
        Me.Label8.Visible = False
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(73, 105)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(170, 20)
        Me.tbDireccion.TabIndex = 12
        Me.tbDireccion.Visible = False
        '
        'cbxInstitucion
        '
        Me.cbxInstitucion.DataSource = Me.ListaEntidadBindingSource
        Me.cbxInstitucion.DisplayMember = "nombre_entidad"
        Me.cbxInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInstitucion.FormattingEnabled = True
        Me.cbxInstitucion.Location = New System.Drawing.Point(140, 22)
        Me.cbxInstitucion.Name = "cbxInstitucion"
        Me.cbxInstitucion.Size = New System.Drawing.Size(207, 21)
        Me.cbxInstitucion.TabIndex = 10
        '
        'DsListaEntidades
        '
        Me.DsListaEntidades.DataSetName = "dsListaEntidades"
        Me.DsListaEntidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaEntidadBindingSource
        '
        Me.ListaEntidadBindingSource.DataMember = "listaEntidad"
        Me.ListaEntidadBindingSource.DataSource = Me.DsListaEntidades
        '
        'ListaEntidadTableAdapter
        '
        Me.ListaEntidadTableAdapter.ClearBeforeFill = True
        '
        'dlgEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 361)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgEditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNIT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbCodigoAsegurado As TextBox
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCI As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents gbPaciente As GroupBox
    Friend WithEvents tbIDCliente As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxInstitucion As ComboBox
    Friend WithEvents DsListaEntidades As dsListaEntidades
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsListaEntidadesTableAdapters.listaEntidadTableAdapter
End Class
