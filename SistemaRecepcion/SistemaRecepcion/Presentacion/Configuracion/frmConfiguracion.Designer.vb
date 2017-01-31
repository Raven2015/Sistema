<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombreSucursal = New System.Windows.Forms.TextBox()
        Me.btnGuardarConfiguracion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DE LA SUCURSAL"
        '
        'tbNombreSucursal
        '
        Me.tbNombreSucursal.Location = New System.Drawing.Point(206, 19)
        Me.tbNombreSucursal.Multiline = True
        Me.tbNombreSucursal.Name = "tbNombreSucursal"
        Me.tbNombreSucursal.Size = New System.Drawing.Size(283, 46)
        Me.tbNombreSucursal.TabIndex = 2
        '
        'btnGuardarConfiguracion
        '
        Me.btnGuardarConfiguracion.Location = New System.Drawing.Point(414, 71)
        Me.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion"
        Me.btnGuardarConfiguracion.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarConfiguracion.TabIndex = 3
        Me.btnGuardarConfiguracion.Text = "GUARDAR"
        Me.btnGuardarConfiguracion.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 105)
        Me.Controls.Add(Me.btnGuardarConfiguracion)
        Me.Controls.Add(Me.tbNombreSucursal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConfiguracion"
        Me.Text = "CONFIGURACIÓN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbNombreSucursal As TextBox
    Friend WithEvents btnGuardarConfiguracion As Button
End Class
