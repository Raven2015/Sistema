<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIContenedor
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mdiInicio = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInformeMedico = New System.Windows.Forms.Button()
        Me.btnComprobante = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnArqueos = New System.Windows.Forms.Button()
        Me.btnCotizacion = New System.Windows.Forms.Button()
        Me.btnAtención = New System.Windows.Forms.Button()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMover = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.INICIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARQUEOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COTIZACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADEPRECIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPROBANTESDECAJAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMEMEDICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tmHora = New System.Windows.Forms.Timer(Me.components)
        Me.mdiInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mdiInicio
        '
        Me.mdiInicio.BackColor = System.Drawing.Color.Transparent
        Me.mdiInicio.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.bg4
        Me.mdiInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mdiInicio.Controls.Add(Me.Label4)
        Me.mdiInicio.Controls.Add(Me.Label3)
        Me.mdiInicio.Controls.Add(Me.btnInformeMedico)
        Me.mdiInicio.Controls.Add(Me.btnComprobante)
        Me.mdiInicio.Controls.Add(Me.btnReportes)
        Me.mdiInicio.Controls.Add(Me.btnArqueos)
        Me.mdiInicio.Controls.Add(Me.btnCotizacion)
        Me.mdiInicio.Controls.Add(Me.btnAtención)
        Me.mdiInicio.Controls.Add(Me.lbHora)
        Me.mdiInicio.Controls.Add(Me.Label2)
        Me.mdiInicio.Controls.Add(Me.PictureBox1)
        Me.mdiInicio.Controls.Add(Me.Label1)
        Me.mdiInicio.Controls.Add(Me.btnMover)
        Me.mdiInicio.Controls.Add(Me.btnCerrar)
        Me.mdiInicio.Controls.Add(Me.btnMinimizar)
        Me.mdiInicio.Controls.Add(Me.MenuStrip)
        Me.mdiInicio.Controls.Add(Me.PictureBox2)
        Me.mdiInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mdiInicio.Location = New System.Drawing.Point(0, 0)
        Me.mdiInicio.Name = "mdiInicio"
        Me.mdiInicio.Size = New System.Drawing.Size(1100, 665)
        Me.mdiInicio.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Informe Médico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "MÉDICOS"
        '
        'btnInformeMedico
        '
        Me.btnInformeMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnInformeMedico.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.list
        Me.btnInformeMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInformeMedico.FlatAppearance.BorderSize = 0
        Me.btnInformeMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeMedico.ForeColor = System.Drawing.Color.White
        Me.btnInformeMedico.Location = New System.Drawing.Point(181, 441)
        Me.btnInformeMedico.Name = "btnInformeMedico"
        Me.btnInformeMedico.Size = New System.Drawing.Size(82, 73)
        Me.btnInformeMedico.TabIndex = 20
        Me.btnInformeMedico.UseVisualStyleBackColor = False
        '
        'btnComprobante
        '
        Me.btnComprobante.BackColor = System.Drawing.Color.BlueViolet
        Me.btnComprobante.FlatAppearance.BorderSize = 0
        Me.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobante.ForeColor = System.Drawing.Color.White
        Me.btnComprobante.Location = New System.Drawing.Point(736, 298)
        Me.btnComprobante.Name = "btnComprobante"
        Me.btnComprobante.Size = New System.Drawing.Size(123, 73)
        Me.btnComprobante.TabIndex = 19
        Me.btnComprobante.Text = "COMPROBANTE DE CAJA"
        Me.btnComprobante.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Location = New System.Drawing.Point(598, 298)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(123, 73)
        Me.btnReportes.TabIndex = 18
        Me.btnReportes.Text = "REPORTES"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnArqueos
        '
        Me.btnArqueos.BackColor = System.Drawing.Color.Red
        Me.btnArqueos.FlatAppearance.BorderSize = 0
        Me.btnArqueos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArqueos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArqueos.ForeColor = System.Drawing.Color.White
        Me.btnArqueos.Location = New System.Drawing.Point(459, 298)
        Me.btnArqueos.Name = "btnArqueos"
        Me.btnArqueos.Size = New System.Drawing.Size(123, 73)
        Me.btnArqueos.TabIndex = 17
        Me.btnArqueos.Text = "ARQUEOS"
        Me.btnArqueos.UseVisualStyleBackColor = False
        '
        'btnCotizacion
        '
        Me.btnCotizacion.BackColor = System.Drawing.Color.Green
        Me.btnCotizacion.FlatAppearance.BorderSize = 0
        Me.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotizacion.ForeColor = System.Drawing.Color.White
        Me.btnCotizacion.Location = New System.Drawing.Point(320, 298)
        Me.btnCotizacion.Name = "btnCotizacion"
        Me.btnCotizacion.Size = New System.Drawing.Size(123, 73)
        Me.btnCotizacion.TabIndex = 16
        Me.btnCotizacion.Text = "COTIZACIÓN"
        Me.btnCotizacion.UseVisualStyleBackColor = False
        '
        'btnAtención
        '
        Me.btnAtención.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAtención.FlatAppearance.BorderSize = 0
        Me.btnAtención.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtención.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtención.ForeColor = System.Drawing.Color.White
        Me.btnAtención.Location = New System.Drawing.Point(181, 298)
        Me.btnAtención.Name = "btnAtención"
        Me.btnAtención.Size = New System.Drawing.Size(123, 73)
        Me.btnAtención.TabIndex = 15
        Me.btnAtención.Text = "ATENCIÓN"
        Me.btnAtención.UseVisualStyleBackColor = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbHora.Location = New System.Drawing.Point(220, 624)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(42, 18)
        Me.lbHora.TabIndex = 14
        Me.lbHora.Text = "hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(34, 624)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HORA DEL SISTEMA:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.logobiom
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(833, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 84)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(743, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SISTEMA DE REGISTRO Y CONTROL DE PACIENTES"
        '
        'btnMover
        '
        Me.btnMover.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.mover_1_
        Me.btnMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMover.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnMover.FlatAppearance.BorderSize = 0
        Me.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMover.Location = New System.Drawing.Point(12, 12)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(60, 60)
        Me.btnMover.TabIndex = 8
        Me.btnMover.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.cancelar
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1040, 605)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(48, 48)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.eliminar
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(985, 605)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(48, 48)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIOToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(65, 115)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(84, 72)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'INICIOToolStripMenuItem
        '
        Me.INICIOToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.INICIOToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.INICIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTESToolStripMenuItem, Me.ARQUEOSToolStripMenuItem, Me.COTIZACIONToolStripMenuItem, Me.ENTIDADESToolStripMenuItem, Me.ATENCIONToolStripMenuItem, Me.CATEGORIASToolStripMenuItem, Me.ESTUDIOSToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.LISTADEPRECIOSToolStripMenuItem, Me.COMPROBANTESDECAJAToolStripMenuItem, Me.INFORMEMEDICOToolStripMenuItem, Me.MODIFICACIONESToolStripMenuItem})
        Me.INICIOToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.list_3_
        Me.INICIOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.INICIOToolStripMenuItem.Name = "INICIOToolStripMenuItem"
        Me.INICIOToolStripMenuItem.Size = New System.Drawing.Size(76, 68)
        Me.INICIOToolStripMenuItem.Text = "INICIO"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.excelColor
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'ARQUEOSToolStripMenuItem
        '
        Me.ARQUEOSToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.calendar
        Me.ARQUEOSToolStripMenuItem.Name = "ARQUEOSToolStripMenuItem"
        Me.ARQUEOSToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ARQUEOSToolStripMenuItem.Text = "ARQUEOS"
        '
        'COTIZACIONToolStripMenuItem
        '
        Me.COTIZACIONToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.info
        Me.COTIZACIONToolStripMenuItem.Name = "COTIZACIONToolStripMenuItem"
        Me.COTIZACIONToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.COTIZACIONToolStripMenuItem.Text = "COTIZACION"
        '
        'ENTIDADESToolStripMenuItem
        '
        Me.ENTIDADESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.house
        Me.ENTIDADESToolStripMenuItem.Name = "ENTIDADESToolStripMenuItem"
        Me.ENTIDADESToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ENTIDADESToolStripMenuItem.Text = "ENTIDADES"
        '
        'ATENCIONToolStripMenuItem
        '
        Me.ATENCIONToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.ATENCIONToolStripMenuItem.Name = "ATENCIONToolStripMenuItem"
        Me.ATENCIONToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ATENCIONToolStripMenuItem.Text = "ATENCION"
        '
        'CATEGORIASToolStripMenuItem
        '
        Me.CATEGORIASToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.folder_7
        Me.CATEGORIASToolStripMenuItem.Name = "CATEGORIASToolStripMenuItem"
        Me.CATEGORIASToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CATEGORIASToolStripMenuItem.Text = "CATEGORIAS"
        '
        'ESTUDIOSToolStripMenuItem
        '
        Me.ESTUDIOSToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.bookmark_1
        Me.ESTUDIOSToolStripMenuItem.Name = "ESTUDIOSToolStripMenuItem"
        Me.ESTUDIOSToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ESTUDIOSToolStripMenuItem.Text = "ESTUDIOS"
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.users
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PACIENTESToolStripMenuItem.Text = "PACIENTES"
        '
        'LISTADEPRECIOSToolStripMenuItem
        '
        Me.LISTADEPRECIOSToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.search
        Me.LISTADEPRECIOSToolStripMenuItem.Name = "LISTADEPRECIOSToolStripMenuItem"
        Me.LISTADEPRECIOSToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LISTADEPRECIOSToolStripMenuItem.Text = "LISTA DE PRECIOS"
        '
        'COMPROBANTESDECAJAToolStripMenuItem
        '
        Me.COMPROBANTESDECAJAToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.list
        Me.COMPROBANTESDECAJAToolStripMenuItem.Name = "COMPROBANTESDECAJAToolStripMenuItem"
        Me.COMPROBANTESDECAJAToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.COMPROBANTESDECAJAToolStripMenuItem.Text = "COMPROBANTES DE CAJA"
        '
        'INFORMEMEDICOToolStripMenuItem
        '
        Me.INFORMEMEDICOToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.info
        Me.INFORMEMEDICOToolStripMenuItem.Name = "INFORMEMEDICOToolStripMenuItem"
        Me.INFORMEMEDICOToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.INFORMEMEDICOToolStripMenuItem.Text = "INFORME MEDICO"
        '
        'MODIFICACIONESToolStripMenuItem
        '
        Me.MODIFICACIONESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.edit
        Me.MODIFICACIONESToolStripMenuItem.Name = "MODIFICACIONESToolStripMenuItem"
        Me.MODIFICACIONESToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.MODIFICACIONESToolStripMenuItem.Text = "MODIFICACIONES"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.CINTA
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(916, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 197)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'tmHora
        '
        '
        'MDIContenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 665)
        Me.Controls.Add(Me.mdiInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIContenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mdiInicio.ResumeLayout(False)
        Me.mdiInicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents INICIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARQUEOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COTIZACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATENCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTUDIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mdiInicio As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMover As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbHora As Label
    Friend WithEvents tmHora As Timer
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnArqueos As Button
    Friend WithEvents btnCotizacion As Button
    Friend WithEvents btnAtención As Button
    Friend WithEvents btnComprobante As Button
    Friend WithEvents LISTADEPRECIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPROBANTESDECAJAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INFORMEMEDICOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICACIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnInformeMedico As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
