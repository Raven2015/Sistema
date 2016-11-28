<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEstudio = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.folder_14
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(7, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEstudio
        '
        Me.btnEstudio.BackColor = System.Drawing.Color.Transparent
        Me.btnEstudio.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.list
        Me.btnEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudio.ForeColor = System.Drawing.Color.Silver
        Me.btnEstudio.Location = New System.Drawing.Point(7, 87)
        Me.btnEstudio.Name = "btnEstudio"
        Me.btnEstudio.Size = New System.Drawing.Size(70, 70)
        Me.btnEstudio.TabIndex = 1
        Me.btnEstudio.UseVisualStyleBackColor = False
        '
        'btnPaciente
        '
        Me.btnPaciente.BackgroundImage = Global.SistemaRecepcion.My.Resources.Resources.users_1
        Me.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.ForeColor = System.Drawing.Color.Silver
        Me.btnPaciente.Location = New System.Drawing.Point(7, 11)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(70, 70)
        Me.btnPaciente.TabIndex = 0
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(85, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEstudio)
        Me.Controls.Add(Me.btnPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "INICIO"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnEstudio As Button
    Friend WithEvents Button1 As Button
End Class
