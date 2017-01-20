<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arqueos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IngresosdiariosporcategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreliminar = New SistemaRecepcion.dsPreliminar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ListaEntidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ingresos_diarios_por_categoriaTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.ingresos_diarios_por_categoriaTableAdapter()
        Me.ListaEntidadTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.listaEntidadTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresosdiariosporcategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 330)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(543, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 330)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEDUCCIONES AUTORIZADAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 330)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESOS FACTURADOS DEL DÍA"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(531, 304)
        Me.DataGridView1.TabIndex = 0
        '
        'IngresosdiariosporcategoriaBindingSource
        '
        Me.IngresosdiariosporcategoriaBindingSource.DataMember = "ingresos_diarios_por_categoria"
        Me.IngresosdiariosporcategoriaBindingSource.DataSource = Me.DsPreliminar
        '
        'DsPreliminar
        '
        Me.DsPreliminar.DataSetName = "dsPreliminar"
        Me.DsPreliminar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 427)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1053, 72)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1053, 85)
        Me.Panel3.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ListaEntidadBindingSource
        Me.ComboBox2.DisplayMember = "nombre_entidad"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(833, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'ListaEntidadBindingSource
        '
        Me.ListaEntidadBindingSource.DataMember = "listaEntidad"
        Me.ListaEntidadBindingSource.DataSource = Me.DsPreliminar
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(650, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SELECCIONE UNA ENTIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ARQUEO DIARIO"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MAÑANA", "TARDE"})
        Me.ComboBox1.Location = New System.Drawing.Point(506, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SELECCIONE UN TURNO: "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(181, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SELECCIONE UNA FECHA: "
        '
        'Ingresos_diarios_por_categoriaTableAdapter
        '
        Me.Ingresos_diarios_por_categoriaTableAdapter.ClearBeforeFill = True
        '
        'ListaEntidadTableAdapter
        '
        Me.ListaEntidadTableAdapter.ClearBeforeFill = True
        '
        'Arqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 499)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Arqueos"
        Me.Text = "Arqueos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresosdiariosporcategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ListaEntidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents IngresosdiariosporcategoriaBindingSource As BindingSource
    Friend WithEvents DsPreliminar As dsPreliminar
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Ingresos_diarios_por_categoriaTableAdapter As dsPreliminarTableAdapters.ingresos_diarios_por_categoriaTableAdapter
    Friend WithEvents ListaEntidadBindingSource As BindingSource
    Friend WithEvents ListaEntidadTableAdapter As dsPreliminarTableAdapters.listaEntidadTableAdapter
End Class
