Imports System.ComponentModel

Public Class dlgNuevoEstudio
    Private Sub dlgNuevoEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    '-------------- Botones de Interfaz --------------
    '-Cancelar
    '-Guardar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And tbIDCategoria.Text <> "" And tbNombres.Text <> "" And tbCodigoEstudio.Text <> "" And tbPrecio.Text <> "" Then
            Try
                Dim dts As New vEstudio
                Dim func As New fEstudio

                dts.gid_categoria = tbIDCategoria.Text
                dts.gcodigo_estudio = tbCodigoEstudio.Text
                dts.gnombre_estudio = tbNombres.Text
                dts.gprecio = tbPrecio.Text
                dts.gdescuento = tbDescuento.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Estudio registrado correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("El estudio no pudo ser registrado. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    '-------------- Metodos de Validacion --------------
    '-Nombres
    '-Apellidos
    '-Direccion
    '-Celular
    '-Sexo
    '-Fecha de Nacimiento
    '-CI

    Private Sub tbCodigoCategoria_Validating(sender As Object, e As CancelEventArgs) Handles tbCodigoCategoria.Validating
        'Permite validar que el campo nombres no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione una categoría por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbCategoria_Validating(sender As Object, e As CancelEventArgs) Handles tbCategoria.Validating
        'Permite validar que el campo apellidos no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione una categoría por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbIDCategoria_Validating(sender As Object, e As CancelEventArgs) Handles tbIDCategoria.Validating
        'Permite validar que el campo direccion no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione una categoría por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbCodigoEstudio_Validating(sender As Object, e As CancelEventArgs) Handles tbCodigoEstudio.Validating
        'Permite validar que el campo celular no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un código de estudio por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) Handles tbNombres.Validating
        'Permite validar que el campo celular no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre de estudio por favor, Este dato es obligatorio")
        End If
    End Sub
    Private Sub tbPrecio_Validating(sender As Object, e As CancelEventArgs) Handles tbPrecio.Validating
        'Permite validar que se seleccione por lo menos uno de los valores del checkBox Sexo para evitar datos nulos.
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un valor valido en precio por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbDescuento_Validating(sender As Object, e As CancelEventArgs) Handles tbDescuento.Validating
        'Permite validar que el campo CI no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el numero de carnet del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    '-------------- Metodos Internos --------------
    '-Limpiar
    Public Sub limpiar()
        'Limpia los valores de las cajas de texto.
        tbIDCategoria.Text = ""
        tbCodigoCategoria.Text = ""
        tbCategoria.Text = ""
        tbCodigoEstudio.Text = ""
        tbNombres.Text = ""
        tbPrecio.Text = "0"
        tbDescuento.Text = "0"
    End Sub

    Private Sub btnSeleccionarCategoria_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCategoria.Click
        dlgSeleccionarCategoria.tbIndicador.Text = "0"
        dlgSeleccionarCategoria.ShowDialog()
    End Sub
End Class