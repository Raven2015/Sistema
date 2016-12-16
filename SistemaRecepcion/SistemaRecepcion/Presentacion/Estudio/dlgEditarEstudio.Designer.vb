<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditarEstudio
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
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.grbDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarCategoria = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.tbIDCategoria = New System.Windows.Forms.TextBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbEstudio.SuspendLayout()
        Me.grbDatosCategoria.SuspendLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.tbCodigoEstudio)
        Me.gbEstudio.Controls.Add(Me.Label5)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(6, 90)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(395, 95)
        Me.gbEstudio.TabIndex = 34
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Datos de Estudio"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(112, 22)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(268, 20)
        Me.tbCodigoEstudio.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Código Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Estudio"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(112, 48)
        Me.tbNombres.Multiline = True
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(268, 41)
        Me.tbNombres.TabIndex = 0
        '
        'grbDatosCategoria
        '
        Me.grbDatosCategoria.Controls.Add(Me.tbCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.btnSeleccionarCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label9)
        Me.grbDatosCategoria.Controls.Add(Me.tbCodigoCategoria)
        Me.grbDatosCategoria.Controls.Add(Me.Label4)
        Me.grbDatosCategoria.Location = New System.Drawing.Point(6, 8)
        Me.grbDatosCategoria.Name = "grbDatosCategoria"
        Me.grbDatosCategoria.Size = New System.Drawing.Size(395, 76)
        Me.grbDatosCategoria.TabIndex = 33
        Me.grbDatosCategoria.TabStop = False
        Me.grbDatosCategoria.Text = "Datos de Categoría"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(145, 49)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(234, 20)
        Me.tbCategoria.TabIndex = 29
        '
        'btnSeleccionarCategoria
        '
        Me.btnSeleccionarCategoria.Location = New System.Drawing.Point(111, 49)
        Me.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria"
        Me.btnSeleccionarCategoria.Size = New System.Drawing.Size(28, 20)
        Me.btnSeleccionarCategoria.TabIndex = 28
        Me.btnSeleccionarCategoria.Text = "..."
        Me.btnSeleccionarCategoria.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(145, 21)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(234, 20)
        Me.tbCodigoCategoria.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Código Categoria"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(246, 191)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(73, 191)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = False
        Me.tbIDEstudio.Location = New System.Drawing.Point(336, 3)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.Size = New System.Drawing.Size(65, 20)
        Me.tbIDEstudio.TabIndex = 23
        '
        'tbIDCategoria
        '
        Me.tbIDCategoria.Location = New System.Drawing.Point(342, 191)
        Me.tbIDCategoria.Name = "tbIDCategoria"
        Me.tbIDCategoria.ReadOnly = True
        Me.tbIDCategoria.Size = New System.Drawing.Size(59, 20)
        Me.tbIDCategoria.TabIndex = 35
        Me.tbIDCategoria.Visible = False
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'dlgEditarEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 223)
        Me.Controls.Add(Me.tbIDCategoria)
        Me.Controls.Add(Me.tbIDEstudio)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.grbDatosCategoria)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgEditarEstudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Estudio"
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.grbDatosCategoria.ResumeLayout(False)
        Me.grbDatosCategoria.PerformLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents grbDatosCategoria As GroupBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents btnSeleccionarCategoria As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents tbIDCategoria As TextBox
    Friend WithEvents errorIcono As ErrorProvider
End Class
