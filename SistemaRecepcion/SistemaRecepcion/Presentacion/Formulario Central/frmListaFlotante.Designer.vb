<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaFlotante
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.DataSetOperacionesAuxiliares = New SistemaRecepcion.DataSetOperacionesAuxiliares()
        Me.MostrarclientesregistradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_clientes_registradosTableAdapter = New SistemaRecepcion.DataSetOperacionesAuxiliaresTableAdapters.mostrar_clientes_registradosTableAdapter()
        Me.tbCI = New System.Windows.Forms.TextBox()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarclientesregistradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CARNET DE IDENTIDAD DEL PACIENTE: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lknInexistente)
        Me.Panel1.Controls.Add(Me.dgvListado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 317)
        Me.Panel1.TabIndex = 2
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListado.Location = New System.Drawing.Point(0, 0)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(484, 317)
        Me.dgvListado.TabIndex = 0
        '
        'DataSetOperacionesAuxiliares
        '
        Me.DataSetOperacionesAuxiliares.DataSetName = "DataSetOperacionesAuxiliares"
        Me.DataSetOperacionesAuxiliares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrarclientesregistradosBindingSource
        '
        Me.MostrarclientesregistradosBindingSource.DataMember = "mostrar_clientes_registrados"
        Me.MostrarclientesregistradosBindingSource.DataSource = Me.DataSetOperacionesAuxiliares
        '
        'Mostrar_clientes_registradosTableAdapter
        '
        Me.Mostrar_clientes_registradosTableAdapter.ClearBeforeFill = True
        '
        'tbCI
        '
        Me.tbCI.Location = New System.Drawing.Point(235, 10)
        Me.tbCI.Name = "tbCI"
        Me.tbCI.Size = New System.Drawing.Size(181, 20)
        Me.tbCI.TabIndex = 3
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lknInexistente.Location = New System.Drawing.Point(121, 146)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(263, 23)
        Me.lknInexistente.TabIndex = 1
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "NO HAY DATOS PARA MOSTRAR"
        '
        'frmListaFlotante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 352)
        Me.Controls.Add(Me.tbCI)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListaFlotante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES REGISTRADOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOperacionesAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarclientesregistradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents DataSetOperacionesAuxiliares As DataSetOperacionesAuxiliares
    Friend WithEvents MostrarclientesregistradosBindingSource As BindingSource
    Friend WithEvents Mostrar_clientes_registradosTableAdapter As DataSetOperacionesAuxiliaresTableAdapters.mostrar_clientes_registradosTableAdapter
    Friend WithEvents tbCI As TextBox
    Friend WithEvents lknInexistente As LinkLabel
End Class
