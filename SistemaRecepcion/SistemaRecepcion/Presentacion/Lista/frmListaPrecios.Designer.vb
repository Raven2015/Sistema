<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPrecios
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbListadoEstudios = New System.Windows.Forms.GroupBox()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.grbDatosCategoria.SuspendLayout()
        Me.gbEstudio.SuspendLayout()
        Me.gbListadoEstudios.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 32
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
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.print
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
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
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "ENTIDAD"
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(112, 106)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.ReadOnly = True
        Me.tbCliente.Size = New System.Drawing.Size(268, 20)
        Me.tbCliente.TabIndex = 18
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
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label9)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label4)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(13, 27)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(388, 88)
        Me.grbDatosCategoria.TabIndex = 40
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
        Me.tbIDEstudio.Location = New System.Drawing.Point(-8, 293)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEstudio.TabIndex = 38
        Me.tbIDEstudio.Visible = False
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Enabled = False
        Me.tbIDPrecio.Location = New System.Drawing.Point(696, 293)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDPrecio.TabIndex = 42
        Me.tbIDPrecio.Visible = False
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
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(326, 143)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 41
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.Label5)
        Me.gbEstudio.Controls.Add(Me.Label15)
        Me.gbEstudio.Controls.Add(Me.tbCliente)
        Me.gbEstudio.Controls.Add(Me.Label10)
        Me.gbEstudio.Controls.Add(Me.tbPrecio)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(407, 27)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(389, 135)
        Me.gbEstudio.TabIndex = 39
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Estudio"
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
        Me.chbxEliminar.Location = New System.Drawing.Point(22, 149)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 37
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"entidad", "codigo_categoria", "codigo_estudio", "nombre_categoria", "estudio"})
        Me.cbCampo.Location = New System.Drawing.Point(65, 119)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(170, 21)
        Me.cbCampo.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(241, 119)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(160, 20)
        Me.tbBuscar.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 33
        '
        'gbListadoEstudios
        '
        Me.gbListadoEstudios.Controls.Add(Me.tbIDEstudio)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDEntidad)
        Me.gbListadoEstudios.Controls.Add(Me.lknInexistente)
        Me.gbListadoEstudios.Controls.Add(Me.tbIDPrecio)
        Me.gbListadoEstudios.Controls.Add(Me.dgvListado)
        Me.gbListadoEstudios.Location = New System.Drawing.Point(8, 172)
        Me.gbListadoEstudios.Name = "gbListadoEstudios"
        Me.gbListadoEstudios.Size = New System.Drawing.Size(788, 313)
        Me.gbListadoEstudios.TabIndex = 31
        Me.gbListadoEstudios.TabStop = False
        Me.gbListadoEstudios.Text = "Listado de Estudios"
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Enabled = False
        Me.tbIDEntidad.Location = New System.Drawing.Point(344, 293)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEntidad.TabIndex = 43
        Me.tbIDEntidad.Visible = False
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(350, 145)
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
        Me.dgvListado.Size = New System.Drawing.Size(773, 288)
        Me.dgvListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'frmListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 489)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grbDatosCategoria)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbListadoEstudios)
        Me.Name = "frmListaPrecios"
        Me.Text = "frmListaPrecios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbDatosCategoria.ResumeLayout(False)
        Me.grbDatosCategoria.PerformLayout()
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.gbListadoEstudios.ResumeLayout(False)
        Me.gbListadoEstudios.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbListadoEstudios As GroupBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents tbIDEntidad As TextBox
End Class
