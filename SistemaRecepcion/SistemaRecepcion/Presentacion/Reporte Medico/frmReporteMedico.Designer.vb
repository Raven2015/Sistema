<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteMedico
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
        Me.components = New System.ComponentModel.Container()
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SCor = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFont = New System.Windows.Forms.ComboBox()
        Me.SaveFile1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbIdAtencion = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbMedicoDestinatario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.tbSexo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbCI = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbcodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbedad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pic_texto = New System.Windows.Forms.PictureBox()
        Me.pic_cor = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnNegrita = New System.Windows.Forms.Button()
        Me.btnItalic = New System.Windows.Forms.Button()
        Me.btnSubrayado = New System.Windows.Forms.Button()
        Me.btnJustificado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCentro = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.rtbAreaTexto = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbDatosInexistentes = New System.Windows.Forms.Label()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.pnContenedor = New System.Windows.Forms.Panel()
        CType(Me.txtSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_texto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFile1
        '
        Me.OpenFile1.Filter = "(*.rtf)|*.rtf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(205, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamaño"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(208, 30)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(46, 20)
        Me.txtSize.TabIndex = 2
        Me.txtSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(70, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fuente"
        '
        'txtFont
        '
        Me.txtFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFont.FormattingEnabled = True
        Me.txtFont.Location = New System.Drawing.Point(71, 30)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.Size = New System.Drawing.Size(131, 21)
        Me.txtFont.TabIndex = 2
        '
        'SaveFile1
        '
        Me.SaveFile1.Filter = "(*.rtf)|*.rtf"
        Me.SaveFile1.RestoreDirectory = True
        Me.SaveFile1.Title = "Salvar Arquivo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 149)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tbIdAtencion)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(659, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "# ATENCIÓN"
        '
        'tbIdAtencion
        '
        Me.tbIdAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbIdAtencion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbIdAtencion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdAtencion.Location = New System.Drawing.Point(95, 14)
        Me.tbIdAtencion.Name = "tbIdAtencion"
        Me.tbIdAtencion.Size = New System.Drawing.Size(127, 22)
        Me.tbIdAtencion.TabIndex = 33
        Me.tbIdAtencion.Text = "0"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.search
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(228, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbMedicoDestinatario)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.tbMedicoRemitente)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbNombres)
        Me.GroupBox2.Controls.Add(Me.tbSexo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbApellidos)
        Me.GroupBox2.Controls.Add(Me.tbCI)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbcodigo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbedad)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 71)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'tbMedicoDestinatario
        '
        Me.tbMedicoDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMedicoDestinatario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbMedicoDestinatario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedicoDestinatario.Location = New System.Drawing.Point(722, 41)
        Me.tbMedicoDestinatario.Name = "tbMedicoDestinatario"
        Me.tbMedicoDestinatario.ReadOnly = True
        Me.tbMedicoDestinatario.Size = New System.Drawing.Size(177, 22)
        Me.tbMedicoDestinatario.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(615, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "M. DESTINATARIO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(615, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "M. REMITENTE"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMedicoRemitente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbMedicoRemitente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(722, 14)
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.ReadOnly = True
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(177, 22)
        Me.tbMedicoRemitente.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "NOMBRES"
        '
        'tbNombres
        '
        Me.tbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombres.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbNombres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombres.Location = New System.Drawing.Point(78, 14)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(135, 22)
        Me.tbNombres.TabIndex = 34
        '
        'tbSexo
        '
        Me.tbSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSexo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSexo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSexo.Location = New System.Drawing.Point(475, 41)
        Me.tbSexo.Name = "tbSexo"
        Me.tbSexo.ReadOnly = True
        Me.tbSexo.Size = New System.Drawing.Size(135, 22)
        Me.tbSexo.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(215, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "APELLIDOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(422, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "SEXO"
        '
        'tbApellidos
        '
        Me.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbApellidos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbApellidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(285, 14)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(135, 22)
        Me.tbApellidos.TabIndex = 36
        '
        'tbCI
        '
        Me.tbCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCI.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbCI.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCI.Location = New System.Drawing.Point(285, 41)
        Me.tbCI.Name = "tbCI"
        Me.tbCI.ReadOnly = True
        Me.tbCI.Size = New System.Drawing.Size(135, 22)
        Me.tbCI.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(422, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "CÓDIGO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(215, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "CI"
        '
        'tbcodigo
        '
        Me.tbcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcodigo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbcodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcodigo.Location = New System.Drawing.Point(475, 14)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.ReadOnly = True
        Me.tbcodigo.Size = New System.Drawing.Size(135, 22)
        Me.tbcodigo.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "EDAD"
        '
        'tbedad
        '
        Me.tbedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbedad.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbedad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbedad.Location = New System.Drawing.Point(78, 41)
        Me.tbedad.Name = "tbedad"
        Me.tbedad.ReadOnly = True
        Me.tbedad.Size = New System.Drawing.Size(135, 22)
        Me.tbedad.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFont)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSize)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pic_texto)
        Me.GroupBox1.Controls.Add(Me.pic_cor)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.btnNegrita)
        Me.GroupBox1.Controls.Add(Me.btnItalic)
        Me.GroupBox1.Controls.Add(Me.btnSubrayado)
        Me.GroupBox1.Controls.Add(Me.btnJustificado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnLista)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCentro)
        Me.GroupBox1.Controls.Add(Me.btnDerecha)
        Me.GroupBox1.Controls.Add(Me.btnIzquierda)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 65)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Archivo"
        '
        'pic_texto
        '
        Me.pic_texto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pic_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_texto.Location = New System.Drawing.Point(291, 29)
        Me.pic_texto.Name = "pic_texto"
        Me.pic_texto.Size = New System.Drawing.Size(19, 21)
        Me.pic_texto.TabIndex = 2
        Me.pic_texto.TabStop = False
        '
        'pic_cor
        '
        Me.pic_cor.BackColor = System.Drawing.Color.White
        Me.pic_cor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_cor.Location = New System.Drawing.Point(338, 30)
        Me.pic_cor.Name = "pic_cor"
        Me.pic_cor.Size = New System.Drawing.Size(19, 21)
        Me.pic_cor.TabIndex = 4
        Me.pic_cor.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.SistemaRecepcion.My.Resources.Resources.edit
        Me.PictureBox3.Location = New System.Drawing.Point(320, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.SistemaRecepcion.My.Resources.Resources.edit
        Me.PictureBox4.Location = New System.Drawing.Point(273, 29)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.SistemaRecepcion.My.Resources.Resources.save
        Me.PictureBox6.Location = New System.Drawing.Point(31, 29)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.SistemaRecepcion.My.Resources.Resources.folder_14
        Me.PictureBox7.Location = New System.Drawing.Point(6, 29)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'btnNegrita
        '
        Me.btnNegrita.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.bold_text_option
        Me.btnNegrita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNegrita.FlatAppearance.BorderSize = 0
        Me.btnNegrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNegrita.Location = New System.Drawing.Point(491, 29)
        Me.btnNegrita.Name = "btnNegrita"
        Me.btnNegrita.Size = New System.Drawing.Size(21, 21)
        Me.btnNegrita.TabIndex = 16
        Me.btnNegrita.UseVisualStyleBackColor = True
        '
        'btnItalic
        '
        Me.btnItalic.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.italicize_text
        Me.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnItalic.FlatAppearance.BorderSize = 0
        Me.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItalic.Location = New System.Drawing.Point(518, 29)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(21, 21)
        Me.btnItalic.TabIndex = 17
        Me.btnItalic.UseVisualStyleBackColor = True
        '
        'btnSubrayado
        '
        Me.btnSubrayado.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.underline_text_option
        Me.btnSubrayado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubrayado.FlatAppearance.BorderSize = 0
        Me.btnSubrayado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubrayado.Location = New System.Drawing.Point(545, 29)
        Me.btnSubrayado.Name = "btnSubrayado"
        Me.btnSubrayado.Size = New System.Drawing.Size(21, 21)
        Me.btnSubrayado.TabIndex = 18
        Me.btnSubrayado.UseVisualStyleBackColor = True
        '
        'btnJustificado
        '
        Me.btnJustificado.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.align_justify
        Me.btnJustificado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJustificado.FlatAppearance.BorderSize = 0
        Me.btnJustificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJustificado.Location = New System.Drawing.Point(454, 30)
        Me.btnJustificado.Name = "btnJustificado"
        Me.btnJustificado.Size = New System.Drawing.Size(21, 21)
        Me.btnJustificado.TabIndex = 21
        Me.btnJustificado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(270, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(318, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Relleno"
        '
        'btnLista
        '
        Me.btnLista.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.underline_text_option
        Me.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLista.FlatAppearance.BorderSize = 0
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Location = New System.Drawing.Point(581, 29)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(21, 21)
        Me.btnLista.TabIndex = 29
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(400, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Alineado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(506, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Formato"
        '
        'btnCentro
        '
        Me.btnCentro.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.center_text_alignment
        Me.btnCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCentro.FlatAppearance.BorderSize = 0
        Me.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentro.Location = New System.Drawing.Point(400, 30)
        Me.btnCentro.Name = "btnCentro"
        Me.btnCentro.Size = New System.Drawing.Size(21, 21)
        Me.btnCentro.TabIndex = 25
        Me.btnCentro.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.align_to_right
        Me.btnDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDerecha.FlatAppearance.BorderSize = 0
        Me.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDerecha.Location = New System.Drawing.Point(427, 30)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(21, 21)
        Me.btnDerecha.TabIndex = 27
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.align_to_left
        Me.btnIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIzquierda.FlatAppearance.BorderSize = 0
        Me.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIzquierda.Location = New System.Drawing.Point(373, 30)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(21, 21)
        Me.btnIzquierda.TabIndex = 26
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'rtbAreaTexto
        '
        Me.rtbAreaTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbAreaTexto.Location = New System.Drawing.Point(0, 149)
        Me.rtbAreaTexto.Name = "rtbAreaTexto"
        Me.rtbAreaTexto.Size = New System.Drawing.Size(931, 454)
        Me.rtbAreaTexto.TabIndex = 3
        Me.rtbAreaTexto.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbDatosInexistentes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 603)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 42)
        Me.Panel2.TabIndex = 5
        '
        'lbDatosInexistentes
        '
        Me.lbDatosInexistentes.AutoSize = True
        Me.lbDatosInexistentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbDatosInexistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDatosInexistentes.ForeColor = System.Drawing.Color.White
        Me.lbDatosInexistentes.Location = New System.Drawing.Point(311, 15)
        Me.lbDatosInexistentes.Name = "lbDatosInexistentes"
        Me.lbDatosInexistentes.Size = New System.Drawing.Size(275, 18)
        Me.lbDatosInexistentes.TabIndex = 7
        Me.lbDatosInexistentes.Text = "NO EXISTEN DATOS PARA MOSTRAR"
        Me.lbDatosInexistentes.Visible = False
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.White
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(0, 0)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(504, 71)
        Me.dgvResultados.TabIndex = 6
        '
        'pnContenedor
        '
        Me.pnContenedor.Controls.Add(Me.dgvResultados)
        Me.pnContenedor.Location = New System.Drawing.Point(205, 155)
        Me.pnContenedor.Name = "pnContenedor"
        Me.pnContenedor.Size = New System.Drawing.Size(504, 71)
        Me.pnContenedor.TabIndex = 8
        Me.pnContenedor.Visible = False
        '
        'frmReporteMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 645)
        Me.Controls.Add(Me.pnContenedor)
        Me.Controls.Add(Me.rtbAreaTexto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReporteMedico"
        Me.Text = "REPORTE MÉDICO"
        CType(Me.txtSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_texto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFile1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnJustificado As Button
    Friend WithEvents btnSubrayado As Button
    Friend WithEvents btnItalic As Button
    Friend WithEvents btnNegrita As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SCor As ColorDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pic_cor As PictureBox
    Friend WithEvents pic_texto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSize As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFont As ComboBox
    Friend WithEvents SaveFile1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents rtbAreaTexto As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnCentro As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLista As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbIdAtencion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbMedicoDestinatario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents tbSexo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbCI As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbcodigo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbedad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents lbDatosInexistentes As Label
    Friend WithEvents pnContenedor As Panel
End Class
