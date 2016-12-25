<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioRecepcion
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCentral = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(342, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "SISTEMA DE RECEPCION Y REGISTRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "SALIR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "ATENCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "LISTA DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " PRECIOS"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.logout
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(298, 69)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(70, 70)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCentral
        '
        Me.btnCentral.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.notepad
        Me.btnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCentral.FlatAppearance.BorderSize = 0
        Me.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentral.Location = New System.Drawing.Point(171, 69)
        Me.btnCentral.Name = "btnCentral"
        Me.btnCentral.Size = New System.Drawing.Size(70, 70)
        Me.btnCentral.TabIndex = 24
        Me.btnCentral.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.search
        Me.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLista.FlatAppearance.BorderSize = 0
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Location = New System.Drawing.Point(46, 69)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(70, 70)
        Me.btnLista.TabIndex = 23
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(280, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 128)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 52)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'InicioRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 180)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCentral)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioRecepcion"
        Me.Text = "InicioRecepcion"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCentral As Button
    Friend WithEvents btnLista As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
