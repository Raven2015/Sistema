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
        Me.tbIDPrecio = New System.Windows.Forms.TextBox()
        Me.tbIDEstudio = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbIDEntidad = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbIDPrecio
        '
        Me.tbIDPrecio.Location = New System.Drawing.Point(409, 95)
        Me.tbIDPrecio.Name = "tbIDPrecio"
        Me.tbIDPrecio.ReadOnly = True
        Me.tbIDPrecio.Size = New System.Drawing.Size(34, 20)
        Me.tbIDPrecio.TabIndex = 60
        '
        'tbIDEstudio
        '
        Me.tbIDEstudio.Location = New System.Drawing.Point(449, 95)
        Me.tbIDEstudio.Name = "tbIDEstudio"
        Me.tbIDEstudio.ReadOnly = True
        Me.tbIDEstudio.Size = New System.Drawing.Size(34, 20)
        Me.tbIDEstudio.TabIndex = 59
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(86, 69)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(124, 20)
        Me.tbPrecio.TabIndex = 58
        Me.tbPrecio.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "PRECIO"
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(86, 37)
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.ReadOnly = True
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(124, 20)
        Me.tbCodigoEstudio.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Cód. Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Estudio"
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(277, 37)
        Me.tbNombres.Multiline = True
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.ReadOnly = True
        Me.tbNombres.Size = New System.Drawing.Size(206, 52)
        Me.tbNombres.TabIndex = 53
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(277, 6)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.ReadOnly = True
        Me.tbCategoria.Size = New System.Drawing.Size(206, 20)
        Me.tbCategoria.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(86, 6)
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.ReadOnly = True
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(124, 20)
        Me.tbCodigoCategoria.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Cod. Categoria"
        '
        'tbIDEntidad
        '
        Me.tbIDEntidad.Location = New System.Drawing.Point(369, 95)
        Me.tbIDEntidad.Name = "tbIDEntidad"
        Me.tbIDEntidad.ReadOnly = True
        Me.tbIDEntidad.Size = New System.Drawing.Size(34, 20)
        Me.tbIDEntidad.TabIndex = 61
        Me.tbIDEntidad.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(148, 106)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 62
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(266, 106)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 63
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbEntidad
        '
        Me.tbEntidad.Location = New System.Drawing.Point(6, 106)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.ReadOnly = True
        Me.tbEntidad.Size = New System.Drawing.Size(34, 20)
        Me.tbEntidad.TabIndex = 64
        Me.tbEntidad.Visible = False
        '
        'frmEditarEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 138)
        Me.Controls.Add(Me.tbEntidad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.tbIDEntidad)
        Me.Controls.Add(Me.tbIDPrecio)
        Me.Controls.Add(Me.tbIDEstudio)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.Label1)
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
        Me.Text = "Editar Entidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbIDPrecio As TextBox
    Friend WithEvents tbIDEstudio As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbIDEntidad As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tbEntidad As TextBox
End Class
