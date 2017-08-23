<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOG
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
        Me.tbLOG = New System.Windows.Forms.TextBox()
        Me.lbLOG = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbLOG
        '
        Me.tbLOG.Location = New System.Drawing.Point(12, 25)
        Me.tbLOG.Multiline = True
        Me.tbLOG.Name = "tbLOG"
        Me.tbLOG.Size = New System.Drawing.Size(171, 197)
        Me.tbLOG.TabIndex = 0
        '
        'lbLOG
        '
        Me.lbLOG.AutoSize = True
        Me.lbLOG.Location = New System.Drawing.Point(83, 9)
        Me.lbLOG.Name = "lbLOG"
        Me.lbLOG.Size = New System.Drawing.Size(29, 13)
        Me.lbLOG.TabIndex = 1
        Me.lbLOG.Text = "LOG"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(61, 228)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "ENVIAR"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 261)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lbLOG)
        Me.Controls.Add(Me.tbLOG)
        Me.Name = "LOG"
        Me.Text = "LOG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbLOG As TextBox
    Friend WithEvents lbLOG As Label
    Friend WithEvents btnEnviar As Button
End Class
