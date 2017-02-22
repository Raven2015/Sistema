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
        Me.INICIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARQUEOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COTIZACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'INICIOToolStripMenuItem
        '
        Me.INICIOToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.INICIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTESToolStripMenuItem, Me.ARQUEOSToolStripMenuItem, Me.COTIZACIONToolStripMenuItem, Me.ENTIDADESToolStripMenuItem, Me.ATENCIONToolStripMenuItem, Me.CATEGORIASToolStripMenuItem, Me.ESTUDIOSToolStripMenuItem, Me.PACIENTESToolStripMenuItem})
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
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'ARQUEOSToolStripMenuItem
        '
        Me.ARQUEOSToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.calendar
        Me.ARQUEOSToolStripMenuItem.Name = "ARQUEOSToolStripMenuItem"
        Me.ARQUEOSToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ARQUEOSToolStripMenuItem.Text = "ARQUEOS"
        '
        'COTIZACIONToolStripMenuItem
        '
        Me.COTIZACIONToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.info
        Me.COTIZACIONToolStripMenuItem.Name = "COTIZACIONToolStripMenuItem"
        Me.COTIZACIONToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.COTIZACIONToolStripMenuItem.Text = "COTIZACION"
        '
        'ENTIDADESToolStripMenuItem
        '
        Me.ENTIDADESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.house
        Me.ENTIDADESToolStripMenuItem.Name = "ENTIDADESToolStripMenuItem"
        Me.ENTIDADESToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ENTIDADESToolStripMenuItem.Text = "ENTIDADES"
        '
        'ATENCIONToolStripMenuItem
        '
        Me.ATENCIONToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.ATENCIONToolStripMenuItem.Name = "ATENCIONToolStripMenuItem"
        Me.ATENCIONToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ATENCIONToolStripMenuItem.Text = "ATENCION"
        '
        'CATEGORIASToolStripMenuItem
        '
        Me.CATEGORIASToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.folder_7
        Me.CATEGORIASToolStripMenuItem.Name = "CATEGORIASToolStripMenuItem"
        Me.CATEGORIASToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CATEGORIASToolStripMenuItem.Text = "CATEGORIAS"
        '
        'ESTUDIOSToolStripMenuItem
        '
        Me.ESTUDIOSToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.bookmark_1
        Me.ESTUDIOSToolStripMenuItem.Name = "ESTUDIOSToolStripMenuItem"
        Me.ESTUDIOSToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ESTUDIOSToolStripMenuItem.Text = "ESTUDIOS"
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.Image = Global.SistemaRecepcion.My.Resources.Resources.users
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PACIENTESToolStripMenuItem.Text = "PACIENTES"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIOToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 593)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1100, 72)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MDIContenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 665)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIContenedor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
