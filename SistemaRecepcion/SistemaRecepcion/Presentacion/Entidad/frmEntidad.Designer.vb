<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntidad
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.dgvListaEstPrec = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grbxDatosEstudio = New System.Windows.Forms.GroupBox()
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbListadoEstudios = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.id_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListaEstPrec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxDatosEstudio.SuspendLayout()
        Me.gbListadoEstudios.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 18
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.tbIDEntidad)
        Me.GroupBox1.Controls.Add(Me.tbEntidad)
        Me.GroupBox1.Controls.Add(Me.dgvListaEstPrec)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 426)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "-"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(301, 77)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 24)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Location = New System.Drawing.Point(6, 81)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.ReadOnly = True
        Me.tbIDEntidad.Size = New System.Drawing.Size(34, 20)
        Me.tbIDEntidad.TabIndex = 48
        '
        'tbEntidad
        '
        Me.tbEntidad.Location = New System.Drawing.Point(95, 20)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.Size = New System.Drawing.Size(124, 20)
        Me.tbEntidad.TabIndex = 48
        '
        'dgvListaEstPrec
        '
        Me.dgvListaEstPrec.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaEstPrec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaEstPrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaEstPrec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_estudio, Me.codigo_estudio, Me.estudio, Me.precio, Me.id_precio})
        Me.dgvListaEstPrec.Location = New System.Drawing.Point(6, 107)
        Me.dgvListaEstPrec.Name = "dgvListaEstPrec"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaEstPrec.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaEstPrec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaEstPrec.Size = New System.Drawing.Size(365, 313)
        Me.dgvListaEstPrec.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "ENTIDAD"
        '
        'grbxDatosEstudio
        '
        Me.grbxDatosEstudio.Controls.Add(Me.tbIDPrecio)
        Me.grbxDatosEstudio.Controls.Add(Me.tbIDEstudio)
        Me.grbxDatosEstudio.Controls.Add(Me.tbPrecio)
        Me.grbxDatosEstudio.Controls.Add(Me.Label1)
        Me.grbxDatosEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.grbxDatosEstudio.Controls.Add(Me.Label5)
        Me.grbxDatosEstudio.Controls.Add(Me.Label3)
        Me.grbxDatosEstudio.Controls.Add(Me.tbNombres)
        Me.grbxDatosEstudio.Controls.Add(Me.tbCategoria)
        Me.grbxDatosEstudio.Controls.Add(Me.Label9)
        Me.grbxDatosEstudio.Controls.Add(Me.tbCodigoCategoria)
        Me.grbxDatosEstudio.Controls.Add(Me.Label4)
        Me.grbxDatosEstudio.Controls.Add(Me.gbListadoEstudios)
        Me.grbxDatosEstudio.Dock = System.Windows.Forms.DockStyle.Right
        Me.grbxDatosEstudio.Location = New System.Drawing.Point(383, 24)
        Me.grbxDatosEstudio.Name = "grbxDatosEstudio"
        Me.grbxDatosEstudio.Size = New System.Drawing.Size(501, 426)
        Me.grbxDatosEstudio.TabIndex = 20
        Me.grbxDatosEstudio.TabStop = False
        Me.grbxDatosEstudio.Text = "-"
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Location = New System.Drawing.Point(421, 107)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.ReadOnly = True
        Me.tbIDPrecio.Size = New System.Drawing.Size(34, 20)
        Me.tbIDPrecio.TabIndex = 48
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Location = New System.Drawing.Point(461, 107)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.ReadOnly = True
        Me.tbIDEstudio.Size = New System.Drawing.Size(34, 20)
        Me.tbIDEstudio.TabIndex = 47
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(92, 86)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(124, 20)
        Me.tbPrecio.TabIndex = 46
        Me.tbPrecio.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "PRECIO"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(92, 54)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(124, 20)
        Me.tbCodigoEstudio.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cód. Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Estudio"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(283, 54)
        Me.tbNombres.Multiline = True
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(206, 52)
        Me.tbNombres.TabIndex = 41
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(283, 23)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(206, 20)
        Me.tbCategoria.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(92, 23)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(124, 20)
        Me.tbCodigoCategoria.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Cod. Categoria"
        '
        'gbListadoEstudios
        '
        Me.gbListadoEstudios.Controls.Add(Me.btnAdicionar)
        Me.gbListadoEstudios.Controls.Add(Me.btnActualizar)
        Me.gbListadoEstudios.Controls.Add(Me.cbCampo)
        Me.gbListadoEstudios.Controls.Add(Me.Label2)
        Me.gbListadoEstudios.Controls.Add(Me.tbBuscar)
        Me.gbListadoEstudios.Controls.Add(Me.lknInexistente)
        Me.gbListadoEstudios.Controls.Add(Me.dgvListado)
        Me.gbListadoEstudios.Location = New System.Drawing.Point(6, 126)
        Me.gbListadoEstudios.Name = "gbListadoEstudios"
        Me.gbListadoEstudios.Size = New System.Drawing.Size(489, 300)
        Me.gbListadoEstudios.TabIndex = 30
        Me.gbListadoEstudios.TabStop = False
        Me.gbListadoEstudios.Text = "Listado de Estudios"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(415, 21)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(62, 49)
        Me.btnAdicionar.TabIndex = 41
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(250, 21)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(62, 49)
        Me.btnActualizar.TabIndex = 40
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"codigo_categoria", "nombre_categoria", "estudio", "codigo_estudio"})
        Me.cbCampo.Location = New System.Drawing.Point(71, 23)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(173, 21)
        Me.cbCampo.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(71, 50)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(174, 20)
        Me.tbBuscar.TabIndex = 37
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(218, 178)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(94, 13)
        Me.lknInexistente.TabIndex = 1
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "Datos Inexistentes"
        '
        'dgvListado
        '
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(6, 82)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(477, 210)
        Me.dgvListado.TabIndex = 0
        '
        'id_estudio
        '
        Me.id_estudio.HeaderText = "id_estudio"
        Me.id_estudio.Name = "id_estudio"
        Me.id_estudio.ReadOnly = True
        Me.id_estudio.Visible = False
        '
        'codigo_estudio
        '
        Me.codigo_estudio.HeaderText = "Código Estudio"
        Me.codigo_estudio.Name = "codigo_estudio"
        Me.codigo_estudio.ReadOnly = True
        Me.codigo_estudio.Width = 70
        '
        'estudio
        '
        Me.estudio.HeaderText = "Estudio"
        Me.estudio.Name = "estudio"
        Me.estudio.ReadOnly = True
        Me.estudio.Width = 170
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.Width = 70
        '
        'id_precio
        '
        Me.id_precio.HeaderText = "id_precio"
        Me.id_precio.Name = "id_precio"
        '
        'frmEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 450)
        Me.Controls.Add(Me.grbxDatosEstudio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmEntidad"
        Me.Text = "Entidad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListaEstPrec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxDatosEstudio.ResumeLayout(False)
        Me.grbxDatosEstudio.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListaEstPrec As DataGridView
    Friend WithEvents grbxDatosEstudio As GroupBox
    Friend WithEvents gbListadoEstudios As GroupBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents tbIDEntidad As TextBox
    Friend WithEvents tbEntidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents id_estudio As DataGridViewTextBoxColumn
    Friend WithEvents codigo_estudio As DataGridViewTextBoxColumn
    Friend WithEvents estudio As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents id_precio As DataGridViewTextBoxColumn
End Class
