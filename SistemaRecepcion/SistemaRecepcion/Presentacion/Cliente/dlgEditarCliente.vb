Imports System.ComponentModel

Public Class dlgEditarCliente

    Dim fecha_nac As Integer

    '-------------- Metodo principal del formulario --------------
    Private Sub dlgEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '-------------- Botones de Interfaz --------------
    '-Cancelar
    '-Guardar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del paciente?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And tbNombres.Text <> "" And tbApellidos.Text <> "" And tbCelular.Text <> "" And tbCI.Text <> "" And tbDireccion.Text <> "" And cbSexo.Text <> "" Then
                Try
                    Dim dts As New vCliente
                    Dim func As New fcliente

                    dts.gid_cliente = tbIDCliente.Text
                    dts.gnombres = tbNombres.Text
                    dts.gapellidos = tbApellidos.Text
                    dts.gfecha_nacimiento = dtpFechaNacimiento.Value
                    dts.gdireccion = tbDireccion.Text
                    dts.gcodigo_asegurado = tbCodigoAsegurado.Text
                    dts.ginstitucion = tbInstitucion.Text
                    dts.grazon_social = tbRazonSocial.Text
                    dts.gnit = tbNIT.Text
                    dts.gtelefono = tbTelefono.Text
                    dts.gcelular = tbCelular.Text
                    dts.gsexo = cbSexo.Text
                    dts.gci = tbCI.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Datos modificados correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Los datos no pudieron ser modificados. Intente de nuevo por favor", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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

    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) Handles tbNombres.Validating
        'Permite validar que el campo nombres no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbApellidos_Validating(sender As Object, e As CancelEventArgs) Handles tbApellidos.Validating
        'Permite validar que el campo apellidos no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el apellido del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    Private Sub tbDireccion_Validating(sender As Object, e As CancelEventArgs) Handles tbDireccion.Validating
        'Permite validar que el campo direccion no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese la dirección del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbCelular_Validating(sender As Object, e As CancelEventArgs) Handles tbCelular.Validating
        'Permite validar que el campo celular no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un numero Celular de referencia por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub cbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cbSexo.Validating
        'Permite validar que se seleccione por lo menos uno de los valores del checkBox Sexo para evitar datos nulos.
        If cbSexo.Text <> "" Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione el sexo del paciente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub dtpFechaNacimiento_Validating(sender As Object, e As CancelEventArgs) Handles dtpFechaNacimiento.Validating
        'Metodo que permite validar que la fecha seleccionada en el selector de fechas sea distinta a la actual.
        'Se crea una variable que almacenara el valor de la edad
        Dim nacimiento As Integer
        'Se verifica que la fecha seleccionada sea diferente a la actual
        If dtpFechaNacimiento.Value.Date <> DateTime.Now.Date Then
            Me.errorIcono.SetError(sender, "")
            'En caso de que sea diferente se asigna la diferencia entre la fecha actual y la fecha seleccionada a la variable nacimiento
            nacimiento = fecha_nacimiento(dtpFechaNacimiento.Value)
            'Se coloca el valor de nacimiento en el campo EDAD
            tbEdad.Text = nacimiento
        Else
            'En caso de que sea igual se muestra el icono de error
            Me.errorIcono.SetError(sender, "Debe seleccionar una fecha distinta a la actual por favor")
            'Se rellena el campo EDAD con el valor 0
            tbEdad.Text = 0
        End If
    End Sub

    Private Sub tbci_Validating(sender As Object, e As CancelEventArgs) Handles tbCI.Validating
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
        'Limpia lo svalores de las cajas de texto.
        tbNombres.Text = ""
        tbApellidos.Text = ""
        tbEdad.Text = ""
        tbDireccion.Text = ""
        tbTelefono.Text = ""
        tbCelular.Text = ""
        tbCodigoAsegurado.Text = ""
        tbRazonSocial.Text = ""
        tbInstitucion.Text = ""
        tbCI.Text = ""
        tbNIT.Text = ""
        cbSexo.Text = ""
        dtpFechaNacimiento.Text = DateTime.Today
    End Sub

    Public Function fecha_nacimiento(ByVal fecha As Date) As Integer
        'Calcula la edad restando la fecha actual menos el valor pasado como parametro.
        fecha_nac = DateTime.Now.Date.Year - fecha.Year
        Return fecha_nac
    End Function

End Class