<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSeleccionarEstudio
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
        Me.tbIDCategoria = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbDescuento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.gbListadoPaciente = New System.Windows.Forms.GroupBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tbIndicador = New System.Windows.Forms.TextBox()
        Me.grbDatosCategoria.SuspendLayout()
        Me.gbEstudio.SuspendLayout()
        Me.gbListadoPaciente.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbIDCategoria
        '
        Me.tbIDCategoria.Enabled = False
        Me.tbIDCategoria.Location = New System.Drawing.Point(364, 246)
        Me.tbIDCategoria.Name = "tbIDCategoria"
        Me.tbIDCategoria.Size = New System.Drawing.Size(100, 20)
        Me.tbIDCategoria.TabIndex = 40
        Me.tbIDCategoria.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(282, 30)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 39
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label9)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label4)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(364, 6)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(388, 88)
        Me.grbDatosCategoria.TabIndex = 38
        Me.grbDatosCategoria.TabStop = False
        Me.grbDatosCategoria.Text = "Datos de Categoría"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(111, 57)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(268, 20)
        Me.tbCategoria.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(111, 29)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(268, 20)
        Me.tbCodigoCategoria.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Código Categoria"
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = False
        Me.tbIDEstudio.Location = New System.Drawing.Point(652, 246)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEstudio.TabIndex = 36
        Me.tbIDEstudio.Visible = False
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.Label5)
        Me.gbEstudio.Controls.Add(Me.Label15)
        Me.gbEstudio.Controls.Add(Me.tbDescuento)
        Me.gbEstudio.Controls.Add(Me.Label10)
        Me.gbEstudio.Controls.Add(Me.tbPrecio)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(363, 105)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(389, 135)
        Me.gbEstudio.TabIndex = 37
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Estudio"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(112, 27)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(268, 20)
        Me.tbCodigoEstudio.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Código Estudio"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Descuento"
        '
        'tbDescuento
        '
        Me.tbDescuento.Location = New System.Drawing.Point(112, 106)
        Me.tbDescuento.Name = "tbDescuento"
        Me.tbDescuento.ReadOnly = True
        Me.tbDescuento.Size = New System.Drawing.Size(268, 20)
        Me.tbDescuento.TabIndex = 18
        Me.tbDescuento.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(112, 80)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.ReadOnly = True
        Me.tbPrecio.Size = New System.Drawing.Size(268, 20)
        Me.tbPrecio.TabIndex = 16
        Me.tbPrecio.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Estudio"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(112, 53)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(268, 20)
        Me.tbNombres.TabIndex = 0
        '
        'chbxEliminar
        '
        Me.chbxEliminar.AutoSize = True
        Me.chbxEliminar.Location = New System.Drawing.Point(6, 36)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 35
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        Me.chbxEliminar.Visible = False
        '
        'cbCampo
        '
        Me.cbCampo.AutoCompleteCustomSource.AddRange(New String() {"codigo_categoria", "nombre_categoria", "nombre_estudio", "codigo_estudio"})
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"codigo_categoria", "nombre_categoria", "nombre_estudio", "codigo_estudio"})
        Me.cbCampo.Location = New System.Drawing.Point(49, 6)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(142, 21)
        Me.cbCampo.TabIndex = 34
        Me.cbCampo.Text = "nombre_estudio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(197, 6)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(160, 20)
        Me.tbBuscar.TabIndex = 32
        '
        'gbListadoPaciente
        '
        Me.gbListadoPaciente.Controls.Add(Me.lknInexistente)
        Me.gbListadoPaciente.Controls.Add(Me.dgvListado)
        Me.gbListadoPaciente.Location = New System.Drawing.Point(2, 59)
        Me.gbListadoPaciente.Name = "gbListadoPaciente"
        Me.gbListadoPaciente.Size = New System.Drawing.Size(355, 207)
        Me.gbListadoPaciente.TabIndex = 31
        Me.gbListadoPaciente.TabStop = False
        Me.gbListadoPaciente.Text = "Listado de Pacientes"
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(127, 105)
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
        Me.dgvListado.Size = New System.Drawing.Size(343, 182)
        Me.dgvListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'tbIndicador
        '
        Me.tbIndicador.Enabled = False
        Me.tbIndicador.Location = New System.Drawing.Point(514, 246)
        Me.tbIndicador.Name = "tbIndicador"
        Me.tbIndicador.Size = New System.Drawing.Size(100, 20)
        Me.tbIndicador.TabIndex = 41
        Me.tbIndicador.Text = "1"
        Me.tbIndicador.Visible = False
        '
        'dlgSeleccionarEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 271)
        Me.Controls.Add(Me.tbIndicador)
        Me.Controls.Add(Me.tbIDCategoria)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.grbDatosCategoria)
        Me.Controls.Add(Me.tbIDEstudio)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.gbListadoPaciente)
        Me.Name = "dlgSeleccionarEstudio"
        Me.Text = "dlgSeleccionarEstudio"
        Me.grbDatosCategoria.ResumeLayout(False)
        Me.grbDatosCategoria.PerformLayout()
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.gbListadoPaciente.ResumeLayout(False)
        Me.gbListadoPaciente.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbIDCategoria As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tbDescuento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents gbListadoPaciente As GroupBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents tbIndicador As TextBox
End Class
