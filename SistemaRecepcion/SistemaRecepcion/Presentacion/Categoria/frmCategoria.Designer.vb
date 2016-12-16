<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoria
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.chbxEliminar = New System.Windows.Forms.CheckBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbListadoPaciente = New System.Windows.Forms.GroupBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbIDCategoria = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gbListadoPaciente.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEstudio.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(83, 28)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(297, 20)
        Me.tbNombres.TabIndex = 0
        '
        'chbxEliminar
        '
        Me.chbxEliminar.AutoSize = True
        Me.chbxEliminar.Location = New System.Drawing.Point(11, 65)
        Me.chbxEliminar.Name = "chbxEliminar"
        Me.chbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chbxEliminar.TabIndex = 33
        Me.chbxEliminar.Text = "Eliminar"
        Me.chbxEliminar.UseVisualStyleBackColor = True
        '
        'cbCampo
        '
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"nombre_categoria", "codigo_categoria"})
        Me.cbCampo.Location = New System.Drawing.Point(54, 35)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(142, 21)
        Me.cbCampo.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Buscar:"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(202, 35)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(160, 20)
        Me.tbBuscar.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 29
        '
        'gbListadoPaciente
        '
        Me.gbListadoPaciente.Controls.Add(Me.lknInexistente)
        Me.gbListadoPaciente.Controls.Add(Me.dgvListado)
        Me.gbListadoPaciente.Location = New System.Drawing.Point(7, 88)
        Me.gbListadoPaciente.Name = "gbListadoPaciente"
        Me.gbListadoPaciente.Size = New System.Drawing.Size(355, 219)
        Me.gbListadoPaciente.TabIndex = 27
        Me.gbListadoPaciente.TabStop = False
        Me.gbListadoPaciente.Text = "Listado de Pacientes"
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(130, 98)
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
        Me.dgvListado.Size = New System.Drawing.Size(343, 194)
        Me.dgvListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.Label4)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbCodigoCategoria)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(368, 35)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(389, 87)
        Me.gbEstudio.TabIndex = 34
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(83, 54)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(297, 20)
        Me.tbCodigoCategoria.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 28
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
        'tbIDCategoria
        '
        Me.tbIDCategoria.Location = New System.Drawing.Point(368, 128)
        Me.tbIDCategoria.Name = "tbIDCategoria"
        Me.tbIDCategoria.Size = New System.Drawing.Size(99, 20)
        Me.tbIDCategoria.TabIndex = 4
        Me.tbIDCategoria.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(287, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 35
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 311)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.tbIDCategoria)
        Me.Controls.Add(Me.chbxEliminar)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbListadoPaciente)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias de Estudios"
        Me.gbListadoPaciente.ResumeLayout(False)
        Me.gbListadoPaciente.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbListadoPaciente As GroupBox
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents tbIDCategoria As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
