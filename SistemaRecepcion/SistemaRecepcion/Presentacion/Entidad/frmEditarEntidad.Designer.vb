<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarEntidad
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
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(95, 34)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(181, 20)
        Me.tbCategoria.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(95, 6)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(181, 20)
        Me.tbCodigoCategoria.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cód. Categoria"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(95, 59)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(181, 20)
        Me.tbCodigoEstudio.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Cód. Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Estudio"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(95, 85)
        Me.tbNombres.Multiline = True
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(181, 46)
        Me.tbNombres.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecio.Location = New System.Drawing.Point(327, 51)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(119, 22)
        Me.tbPrecio.TabIndex = 38
        Me.tbPrecio.Text = "0"
        Me.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Enabled = False
        Me.tbIDEstudio.Location = New System.Drawing.Point(293, 3)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.ReadOnly = True
        Me.tbIDEstudio.Size = New System.Drawing.Size(37, 20)
        Me.tbIDEstudio.TabIndex = 40
        Me.tbIDEstudio.Visible = False
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Enabled = False
        Me.tbIDPrecio.Location = New System.Drawing.Point(333, 3)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.ReadOnly = True
        Me.tbIDPrecio.Size = New System.Drawing.Size(37, 20)
        Me.tbIDPrecio.TabIndex = 43
        Me.tbIDPrecio.Visible = False
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Enabled = False
        Me.tbIDEntidad.Location = New System.Drawing.Point(376, 2)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.ReadOnly = True
        Me.tbIDEntidad.Size = New System.Drawing.Size(37, 20)
        Me.tbIDEntidad.TabIndex = 45
        Me.tbIDEntidad.Visible = False
        '
        'tbEntidad
        '
        Me.tbEntidad.Enabled = False
        Me.tbEntidad.Location = New System.Drawing.Point(419, 2)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.ReadOnly = True
        Me.tbEntidad.Size = New System.Drawing.Size(49, 20)
        Me.tbEntidad.TabIndex = 46
        Me.tbEntidad.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(293, 93)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 47
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(393, 93)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 48
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEditarEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 143)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.tbEntidad)
        Me.Controls.Add(Me.tbIDEntidad)
        Me.Controls.Add(Me.tbIDPrecio)
        Me.Controls.Add(Me.tbIDEstudio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbCodigoEstudio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNombres)
        Me.Controls.Add(Me.tbCategoria)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbCodigoCategoria)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditarEntidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR ENTIDAD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents tbIDEntidad As TextBox
    Friend WithEvents tbEntidad As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
