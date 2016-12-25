<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstudio
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
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbListadoPaciente = New System.Windows.Forms.GroupBox()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.tbIDCategoria = New System.Windows.Forms.TextBox()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListadoPaciente.SuspendLayout()
        Me.gbEstudio.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grbDatosCategoria.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvListado.Size = New System.Drawing.Size(408, 182)
        Me.dgvListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'chbxEliminar
        '
        Me.chbxEliminar.AutoSize = True
        Me.chbxEliminar.Location = New System.Drawing.Point(11, 69)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 22
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"COD_CATEGORIA", "CATEGORIA", "ESTUDIO", "COD_ESTUDIO"})
        Me.cbCampo.Location = New System.Drawing.Point(54, 39)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(142, 21)
        Me.cbCampo.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(202, 39)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(219, 20)
        Me.tbBuscar.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 18
        '
        'gbListadoPaciente
        '
        Me.gbListadoPaciente.Controls.Add(Me.lknInexistente)
        Me.gbListadoPaciente.Controls.Add(Me.dgvListado)
        Me.gbListadoPaciente.Location = New System.Drawing.Point(7, 92)
        Me.gbListadoPaciente.Name = "gbListadoPaciente"
        Me.gbListadoPaciente.Size = New System.Drawing.Size(420, 207)
        Me.gbListadoPaciente.TabIndex = 16
        Me.gbListadoPaciente.TabStop = False
        Me.gbListadoPaciente.Text = "Listado de Estudios"
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.Label5)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(433, 138)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(324, 135)
        Me.gbEstudio.TabIndex = 26
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Estudio"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(112, 27)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(206, 20)
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
        Me.tbNombres.Multiline = True
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(206, 76)
        Me.tbNombres.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(763, 24)
        Me.MenuStrip1.TabIndex = 17
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
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = False
        Me.tbIDEstudio.Location = New System.Drawing.Point(657, 279)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(100, 20)
        Me.tbIDEstudio.TabIndex = 23
        Me.tbIDEstudio.Visible = False
        '
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label9)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label4)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(434, 39)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(323, 88)
        Me.grbDatosCategoria.TabIndex = 28
        Me.grbDatosCategoria.TabStop = False
        Me.grbDatosCategoria.Text = "Datos de Categoría"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(111, 57)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(206, 20)
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
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(206, 20)
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
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(346, 63)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 29
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'tbIDCategoria
        '
        Me.tbIDCategoria.Enabled = False
        Me.tbIDCategoria.Location = New System.Drawing.Point(433, 279)
        Me.tbIDCategoria.Name = "tbIDCategoria"
        Me.tbIDCategoria.Size = New System.Drawing.Size(100, 20)
        Me.tbIDCategoria.TabIndex = 30
        Me.tbIDCategoria.Visible = False
        '
        'frmEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 305)
        Me.Controls.Add(Me.tbIDCategoria)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.grbDatosCategoria)
        Me.Controls.Add(Me.tbIDEstudio)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbListadoPaciente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEstudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudio"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListadoPaciente.ResumeLayout(False)
        Me.gbListadoPaciente.PerformLayout()
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbDatosCategoria.ResumeLayout(False)
        Me.grbDatosCategoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbListadoPaciente As GroupBox
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents tbIDCategoria As TextBox
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
