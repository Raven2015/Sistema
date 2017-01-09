<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbEstudio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.cbxInstitucion = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxInstitucion)
        Me.Panel1.Controls.Add(Me.tbEstudio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 47)
        Me.Panel1.TabIndex = 0
        '
        'tbEstudio
        '
        Me.tbEstudio.Location = New System.Drawing.Point(411, 14)
        Me.tbEstudio.Name = "tbEstudio"
        Me.tbEstudio.Size = New System.Drawing.Size(152, 20)
        Me.tbEstudio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ESTUDIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTIDAD"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbPrecio)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 394)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 51)
        Me.Panel2.TabIndex = 1
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(547, 15)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(152, 20)
        Me.tbPrecio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MONTO A PAGAR"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(728, 347)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvListadoAtenciones)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 154)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(728, 193)
        Me.Panel5.TabIndex = 1
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = False
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoAtenciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoAtenciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.estudio, Me.precio})
        Me.dgvListadoAtenciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(0, 0)
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(728, 193)
        Me.dgvListadoAtenciones.TabIndex = 60
        '
        'estudio
        '
        Me.estudio.HeaderText = "ESTUDIO"
        Me.estudio.Name = "estudio"
        Me.estudio.ReadOnly = True
        Me.estudio.Width = 580
        '
        'precio
        '
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lknInexistente)
        Me.Panel4.Controls.Add(Me.dgvListado)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(728, 148)
        Me.Panel4.TabIndex = 0
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(293, 67)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(125, 13)
        Me.lknInexistente.TabIndex = 2
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "No hay datos par mostrar"
        '
        'dgvListado
        '
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListado.Location = New System.Drawing.Point(0, 0)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(728, 148)
        Me.dgvListado.TabIndex = 3
        '
        'cbxInstitucion
        '
        Me.cbxInstitucion.DisplayMember = "nombre_entidad"
        Me.cbxInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInstitucion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbxInstitucion.FormattingEnabled = True
        Me.cbxInstitucion.Items.AddRange(New Object() {"PARTICULAR", "COTEL", "RED SALUD", "POLICIA"})
        Me.cbxInstitucion.Location = New System.Drawing.Point(99, 11)
        Me.cbxInstitucion.Name = "cbxInstitucion"
        Me.cbxInstitucion.Size = New System.Drawing.Size(177, 23)
        Me.cbxInstitucion.TabIndex = 5
        '
        'frmCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 445)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCotizacion"
        Me.Text = "Cotizacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbEstudio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents estudio As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents lknInexistente As LinkLabel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents cbxInstitucion As ComboBox
End Class
