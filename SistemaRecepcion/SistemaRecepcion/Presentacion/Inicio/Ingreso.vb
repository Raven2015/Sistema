Public Class Ingreso
    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        validacion()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tmHora_Tick(sender As Object, e As EventArgs) Handles tmHora.Tick
        lbHora.Text = TimeOfDay
        tmHora.Start()
    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        lbHora.Text = TimeOfDay
        tmHora.Start()
    End Sub

    Private Sub limpiar()
        tbLogin.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub tbPassword_Enter(sender As Object, e As EventArgs) Handles tbPassword.Enter
        validacion()
    End Sub


    Public Sub validacion()
        Try
            Dim dts As New vUsuario
            Dim func As New fUsuario
            Dim tipo As String = ""

            If tbLogin.Text <> "" And tbPassword.Text <> "" Then
                Dim dt As New DataTable

                dts.glogin = tbLogin.Text
                dts.gpassword = tbPassword.Text

                dt = func.inicio_sesion(dts)
                If dt.Rows.Count <> 0 Then
                    tipo = dt.Rows(0)("tipo")
                    limpiar()
                    If tipo = "recepcionista" Then
                        InicioRecepcion.ShowDialog()
                    ElseIf tipo = "administrador" Then
                        'frmInicio.ShowDialog()
                        MDIContenedor.ShowDialog()
                    End If
                Else
                    Static intento As Integer
                    intento = intento + 1
                    MsgBox("DATOS INCORRECTOS. Intente de nuevo por favor." & vbNewLine & "LE QUEDAN: " & (3 - intento) & " INTENTOS PARA INGRESAR AL SISTEMA")
                    limpiar()
                    If intento = 3 Then
                        MsgBox("El sistema se cerrará", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la BD")
        End Try
    End Sub
End Class