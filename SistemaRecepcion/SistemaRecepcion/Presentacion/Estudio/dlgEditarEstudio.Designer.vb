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
        Me.gbEstudio = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbDescuento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbIDCategoria = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbEstudio.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEstudio
        '
        Me.gbEstudio.Controls.Add(Me.Label15)
        Me.gbEstudio.Controls.Add(Me.tbDescuento)
        Me.gbEstudio.Controls.Add(Me.Label10)
        Me.gbEstudio.Controls.Add(Me.tbPrecio)
        Me.gbEstudio.Controls.Add(Me.Label9)
        Me.gbEstudio.Controls.Add(Me.tbCategoria)
        Me.gbEstudio.Controls.Add(Me.Label4)
        Me.gbEstudio.Controls.Add(Me.Label3)
        Me.gbEstudio.Controls.Add(Me.tbIDCategoria)
        Me.gbEstudio.Controls.Add(Me.tbNombres)
        Me.gbEstudio.Location = New System.Drawing.Point(9, 12)
        Me.gbEstudio.Name = "gbEstudio"
        Me.gbEstudio.Size = New System.Drawing.Size(389, 166)
        Me.gbEstudio.TabIndex = 25
        Me.gbEstudio.TabStop = False
        Me.gbEstudio.Text = "Nuevos Datos de Estudio"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Descuento"
        '
        'tbDescuento
        '
        Me.tbDescuento.Location = New System.Drawing.Point(100, 132)
        Me.tbDescuento.Name = "tbDescuento"
        Me.tbDescuento.Size = New System.Drawing.Size(280, 20)
        Me.tbDescuento.TabIndex = 18
        Me.tbDescuento.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(100, 106)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(280, 20)
        Me.tbPrecio.TabIndex = 16
        Me.tbPrecio.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Categoria"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(100, 80)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.Size = New System.Drawing.Size(280, 20)
        Me.tbCategoria.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'tbIDCategoria
        '
        Me.tbIDCategoria.Location = New System.Drawing.Point(100, 54)
        Me.tbIDCategoria.Name = "tbIDCategoria"
        Me.tbIDCategoria.Size = New System.Drawing.Size(280, 20)
        Me.tbIDCategoria.TabIndex = 1
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(100, 28)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(280, 20)
        Me.tbNombres.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(248, 184)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(75, 184)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dlgEditarEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 214)
        Me.Controls.Add(Me.gbEstudio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "dlgEditarEstudio"
        Me.Text = "Editar Estudio"
        Me.gbEstudio.ResumeLayout(False)
        Me.gbEstudio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEstudio As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbDescuento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbIDCategoria As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
