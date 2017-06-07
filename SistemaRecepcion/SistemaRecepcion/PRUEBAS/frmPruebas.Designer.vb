<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPruebas
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
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.tbIdAtencion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnObtener = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLoginObt = New System.Windows.Forms.TextBox()
        Me.tbIDAt = New System.Windows.Forms.TextBox()
        Me.tbIDUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImpresion = New System.Windows.Forms.Button()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.btnMostrarImpresion = New System.Windows.Forms.Button()
        Me.lknInexistente = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(20, 16)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(126, 20)
        Me.tbLogin.TabIndex = 0
        '
        'tbIdAtencion
        '
        Me.tbIdAtencion.Location = New System.Drawing.Point(20, 41)
        Me.tbIdAtencion.Name = "tbIdAtencion"
        Me.tbIdAtencion.Size = New System.Drawing.Size(126, 20)
        Me.tbIdAtencion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID ATENCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RESULTADO"
        '
        'tbResultado
        '
        Me.tbResultado.Location = New System.Drawing.Point(20, 67)
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.Size = New System.Drawing.Size(126, 20)
        Me.tbResultado.TabIndex = 4
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(251, 65)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "ENVIAR"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnObtener
        '
        Me.btnObtener.Location = New System.Drawing.Point(251, 94)
        Me.btnObtener.Name = "btnObtener"
        Me.btnObtener.Size = New System.Drawing.Size(75, 23)
        Me.btnObtener.TabIndex = 7
        Me.btnObtener.Text = "INFORME"
        Me.btnObtener.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LOGIN"
        '
        'tbLoginObt
        '
        Me.tbLoginObt.Location = New System.Drawing.Point(20, 93)
        Me.tbLoginObt.Name = "tbLoginObt"
        Me.tbLoginObt.Size = New System.Drawing.Size(126, 20)
        Me.tbLoginObt.TabIndex = 8
        '
        'tbIDAt
        '
        Me.tbIDAt.Location = New System.Drawing.Point(20, 139)
        Me.tbIDAt.Name = "tbIDAt"
        Me.tbIDAt.Size = New System.Drawing.Size(126, 20)
        Me.tbIDAt.TabIndex = 10
        '
        'tbIDUser
        '
        Me.tbIDUser.Location = New System.Drawing.Point(20, 165)
        Me.tbIDUser.Name = "tbIDUser"
        Me.tbIDUser.Size = New System.Drawing.Size(126, 20)
        Me.tbIDUser.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID ATENCION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID USUARIO"
        '
        'btnImpresion
        '
        Me.btnImpresion.Location = New System.Drawing.Point(80, 191)
        Me.btnImpresion.Name = "btnImpresion"
        Me.btnImpresion.Size = New System.Drawing.Size(82, 22)
        Me.btnImpresion.TabIndex = 14
        Me.btnImpresion.Text = "IMPRESION"
        Me.btnImpresion.UseVisualStyleBackColor = True
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.BackgroundColor = System.Drawing.Color.White
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvListado.Location = New System.Drawing.Point(332, 0)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(371, 244)
        Me.dgvListado.TabIndex = 15
        '
        'btnMostrarImpresion
        '
        Me.btnMostrarImpresion.Location = New System.Drawing.Point(80, 219)
        Me.btnMostrarImpresion.Name = "btnMostrarImpresion"
        Me.btnMostrarImpresion.Size = New System.Drawing.Size(82, 22)
        Me.btnMostrarImpresion.TabIndex = 16
        Me.btnMostrarImpresion.Text = "MOSTRAR"
        Me.btnMostrarImpresion.UseVisualStyleBackColor = True
        '
        'lknInexistente
        '
        Me.lknInexistente.AutoSize = True
        Me.lknInexistente.Location = New System.Drawing.Point(486, 104)
        Me.lknInexistente.Name = "lknInexistente"
        Me.lknInexistente.Size = New System.Drawing.Size(94, 13)
        Me.lknInexistente.TabIndex = 17
        Me.lknInexistente.TabStop = True
        Me.lknInexistente.Text = "Datos Inexistentes"
        '
        'frmPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 244)
        Me.Controls.Add(Me.lknInexistente)
        Me.Controls.Add(Me.btnMostrarImpresion)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.btnImpresion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbIDUser)
        Me.Controls.Add(Me.tbIDAt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbLoginObt)
        Me.Controls.Add(Me.btnObtener)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbIdAtencion)
        Me.Controls.Add(Me.tbLogin)
        Me.Name = "frmPruebas"
        Me.Text = "PRUEBAS"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbLogin As TextBox
    Friend WithEvents tbIdAtencion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnObtener As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbLoginObt As TextBox
    Friend WithEvents tbIDAt As TextBox
    Friend WithEvents tbIDUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImpresion As Button
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents btnMostrarImpresion As Button
    Friend WithEvents lknInexistente As LinkLabel
End Class
