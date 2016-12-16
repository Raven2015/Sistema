Imports System.ComponentModel

Public Class dlgNuevaCategoria


    '-------------- Metodo principal del formulario --------------
    Private Sub dlgNuevaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        generar_categoria()
    End Sub

    '-------------- Botones de Interfaz --------------
    '-Cancelar
    '-Guardar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And tbNombres.Text <> "" And tbCodigoCategoria.Text <> "" Then
            Try
                Dim dts As New vCategoria
                Dim func As New fCategoria

                dts.gid_categoria = tbIDCategoria.Text
                dts.gnombre_categoria = tbNombres.Text
                dts.gcodigo_categoria = tbCodigoCategoria.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Categoria registrada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("La Categoria no pudo ser registrada. Intente de nuevo por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos faltantes. Llene todos los campos marcados por favor", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub generar_categoria()
        Try
            Dim dts As New vCategoria
            Dim func As New fCategoria
            tbIDCategoria.Text = Format(func.generar_categoria, "000")
            Debug.Write("Categoria Generada OK :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '-------------- Metodos de Validacion --------------
    '-Nombre de Estudio
    '-ID Categoria
    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) Handles tbNombres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un Nombre para la Categoria por favor. Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbIDCategoria_Validating(sender As Object, e As CancelEventArgs) Handles tbCodigoCategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un ID para la Categoria por favor. Este dato es obligatorio")
        End If
    End Sub

    '-------------- Metodos Internos --------------
    '-Limpiar
    Public Sub limpiar()
        tbCodigoCategoria.Text = ""
        tbNombres.Text = ""
    End Sub



End Class