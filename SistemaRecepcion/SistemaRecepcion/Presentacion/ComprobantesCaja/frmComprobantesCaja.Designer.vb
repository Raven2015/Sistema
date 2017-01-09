<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComprobantesCaja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.MostraratencionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreliminar = New SistemaRecepcion.dsPreliminar()
        Me.MostrarreportefinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_reporte_finalTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter()
        Me.Mostrar_atencionesTableAdapter = New SistemaRecepcion.dsPreliminarTableAdapters.mostrar_atencionesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTotalIngresado = New System.Windows.Forms.TextBox()
        Me.tbTotalDescuentos = New System.Windows.Forms.TextBox()
        Me.tbTotalCaja = New System.Windows.Forms.TextBox()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostraratencionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarreportefinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA DE ATENCION"
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(133, 12)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaAtencion.TabIndex = 1
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = False
        Me.dgvListadoAtenciones.AllowUserToDeleteRows = False
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(12, 38)
        Me.dgvListadoAtenciones.MultiSelect = False
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(760, 245)
        Me.dgvListadoAtenciones.TabIndex = 2
        '
        'MostraratencionesBindingSource
        '
        Me.MostraratencionesBindingSource.DataMember = "mostrar_atenciones"
        Me.MostraratencionesBindingSource.DataSource = Me.DsPreliminar
        '
        'DsPreliminar
        '
        Me.DsPreliminar.DataSetName = "dsPreliminar"
        Me.DsPreliminar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrarreportefinalBindingSource
        '
        Me.MostrarreportefinalBindingSource.DataMember = "mostrar_reporte_final"
        Me.MostrarreportefinalBindingSource.DataSource = Me.DsPreliminar
        '
        'Mostrar_reporte_finalTableAdapter
        '
        Me.Mostrar_reporte_finalTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_atencionesTableAdapter
        '
        Me.Mostrar_atencionesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TURNO"
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Items.AddRange(New Object() {"MAÑANA", "TARDE"})
        Me.cbxTurno.Location = New System.Drawing.Point(403, 11)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(123, 21)
        Me.cbxTurno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MONTO TOTAL FACTURADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MONTO TOTAL DESCUENTOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "MONTO TOTAL EN CAJA"
        '
        'tbTotalIngresado
        '
        Me.tbTotalIngresado.Location = New System.Drawing.Point(197, 296)
        Me.tbTotalIngresado.Name = "tbTotalIngresado"
        Me.tbTotalIngresado.ReadOnly = True
        Me.tbTotalIngresado.Size = New System.Drawing.Size(134, 20)
        Me.tbTotalIngresado.TabIndex = 8
        Me.tbTotalIngresado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotalDescuentos
        '
        Me.tbTotalDescuentos.Location = New System.Drawing.Point(197, 322)
        Me.tbTotalDescuentos.Name = "tbTotalDescuentos"
        Me.tbTotalDescuentos.ReadOnly = True
        Me.tbTotalDescuentos.Size = New System.Drawing.Size(134, 20)
        Me.tbTotalDescuentos.TabIndex = 9
        Me.tbTotalDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotalCaja
        '
        Me.tbTotalCaja.Location = New System.Drawing.Point(197, 348)
        Me.tbTotalCaja.Name = "tbTotalCaja"
        Me.tbTotalCaja.ReadOnly = True
        Me.tbTotalCaja.Size = New System.Drawing.Size(134, 20)
        Me.tbTotalCaja.TabIndex = 10
        Me.tbTotalCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmComprobantesCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 376)
        Me.Controls.Add(Me.tbTotalCaja)
        Me.Controls.Add(Me.tbTotalDescuentos)
        Me.Controls.Add(Me.tbTotalIngresado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvListadoAtenciones)
        Me.Controls.Add(Me.dtpFechaAtencion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmComprobantesCaja"
        Me.Text = "COMPROBANTES DE CAJA"
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostraratencionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarreportefinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents DsPreliminar As dsPreliminar
    Friend WithEvents MostrarreportefinalBindingSource As BindingSource
    Friend WithEvents Mostrar_reporte_finalTableAdapter As dsPreliminarTableAdapters.mostrar_reporte_finalTableAdapter
    Friend WithEvents MostraratencionesBindingSource As BindingSource
    Friend WithEvents Mostrar_atencionesTableAdapter As dsPreliminarTableAdapters.mostrar_atencionesTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTurno As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTotalIngresado As TextBox
    Friend WithEvents tbTotalDescuentos As TextBox
    Friend WithEvents tbTotalCaja As TextBox
End Class
