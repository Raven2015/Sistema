Imports DevExpress.XtraRichEdit.API.Native

Public Class dvxpReporteMedico
    Private dt As New DataTable
    Private Sub beiNroAtencion_EditValueChanged(sender As Object, e As EventArgs)
        'rhedctContenidoReporte.Text = beiNroAtencion.
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnDatosPaciente.ItemClick
        flpnFlotante.ShowPopup()
    End Sub

    Private Sub mostrar(ByVal id_atencion As Integer)
        Try
            Dim func As New fReporteMedico
            dt = func.mostrar(id_atencion)

            If dt.Rows.Count <> 0 Then
                dgvResultados.Visible = True
                dgvResultados.DataSource = dt
                dgvResultados.ColumnHeadersVisible = True
                lbDatosInexistentes.Visible = False
            Else
                dgvResultados.Visible = False
                dgvResultados.DataSource = Nothing
                dgvResultados.ColumnHeadersVisible = False
                lbDatosInexistentes.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mostrar_estudios(ByVal id_atencion As Integer)
        Try
            Dim func As New fEstudiosporAtencion
            dt = func.mostrar_por_por_atencion(id_atencion)

            If dt.Rows.Count <> 0 Then
                dgvEstudiosARealizar.Visible = True
                dgvEstudiosARealizar.DataSource = dt
                dgvEstudiosARealizar.ColumnHeadersVisible = True
                lbEstudiosInexsistentes.Visible = False
            Else
                dgvEstudiosARealizar.Visible = False
                dgvEstudiosARealizar.DataSource = Nothing
                dgvEstudiosARealizar.ColumnHeadersVisible = False
                lbEstudiosInexsistentes.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        tbNombres.Text = ""
        tbApellidos.Text = ""
        tbCI.Text = ""
        tbSexo.Text = ""
        tbcodigo.Text = ""
        tbedad.Text = ""
        tbMedicoDestinatario.Text = ""
        tbMedicoRemitente.Text = ""
    End Sub

    Private Sub llenar_datos()
        limpiar()
        tbNombres.Text = dgvResultados.SelectedCells.Item(0).Value
        tbApellidos.Text = dgvResultados.SelectedCells.Item(1).Value
        tbCI.Text = dgvResultados.SelectedCells.Item(2).Value
        tbedad.Text = dgvResultados.SelectedCells.Item(3).Value
        tbcodigo.Text = dgvResultados.SelectedCells.Item(7).Value
        tbSexo.Text = dgvResultados.SelectedCells.Item(6).Value
        tbMedicoRemitente.Text = dgvResultados.SelectedCells.Item(10).Value
        tbMedicoDestinatario.Text = dgvResultados.SelectedCells.Item(12).Value
    End Sub

    Private Sub control()
        If tbIdAtencion.Text = "" Then
            tbIdAtencion.Text = 0
        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        limpiar()
        mostrar(tbIdAtencion.Text)
    End Sub

    Private Sub tbIdAtencion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIdAtencion.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbIdAtencion_TextChanged(sender As Object, e As EventArgs) Handles tbIdAtencion.TextChanged
        control()
        mostrar(Integer.Parse(tbIdAtencion.Text))
    End Sub

    Private Sub dgvResultados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResultados.CellMouseDoubleClick
        tbNombres.Text = dgvResultados.SelectedCells.Item(0).Value
        tbApellidos.Text = dgvResultados.SelectedCells.Item(1).Value
        tbCI.Text = dgvResultados.SelectedCells.Item(2).Value
        tbedad.Text = dgvResultados.SelectedCells.Item(3).Value
        tbcodigo.Text = dgvResultados.SelectedCells.Item(7).Value
        tbSexo.Text = dgvResultados.SelectedCells.Item(6).Value
        tbMedicoRemitente.Text = dgvResultados.SelectedCells.Item(10).Value
        tbMedicoDestinatario.Text = dgvResultados.SelectedCells.Item(12).Value
        tbInstitucion.Text = dgvResultados.SelectedCells.Item(13).Value
        mostrar_estudios(tbIdAtencion.Text)
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Dim estudio As String = generar_texto(dgvEstudiosARealizar)

        Dim fecha As String = ""
        Dim fechaDirecto As String = ""
        Dim salto As String = ""
        Dim Contenido As String = ""
        Dim nombre As String = ""
        Dim edad As String = ""
        Dim medico As String = ""

        lbIDAtencion.Text=tbIdAtencion.Text
        'fecha = "La Paz " & Date.Now.Day & " de " & Date.Now.Month & " de " & Date.Now.Year
        fechaDirecto = Date.Now.ToLongDateString()
        'fecha = modOperacionesAuxiliares.cambiar(fechaDirecto)

        salto = vbCrLf
        nombre = vbTab & vbTab & "PACIENTE: " & vbTab & vbTab & tbApellidos.Text & " " & tbNombres.Text
        edad = vbTab & vbTab & "EDAD: " & vbTab & vbTab & vbTab & tbedad.Text & " años"
        medico = vbTab & vbTab & "MEDICO: " & vbTab & vbTab & tbMedicoRemitente.Text

        rhedctContenidoReporte.Text = salto & salto & salto & "La Paz, " & fechaDirecto & salto & salto & nombre & salto & edad & salto & medico

        'rhedctContenidoReporte.Document.BeginUpdate()
        'rhedctContenidoReporte.Document.AppendText(vbCrLf & estudio)
        'rhedctContenidoReporte.Document.EndUpdate()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'ntIcon.BalloonTipText = "AVISO"

        'ntIcon.ShowBalloonTip(5)
    End Sub

    Private Sub brbtnGuardaInforme_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnGuardaInforme.ItemClick
        If tbIdAtencion.Text <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Desea guardar el contenido actual del informe?", "Guardando Informe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                If rhedctContenidoReporte.Text <> "" Then

                    Try
                        Dim dts As New vInformeMedico
                        Dim func As New fInformeMedico

                        dts.gid_atencion = lbIDAtencion.text
                        dts.ginforme = rhedctContenidoReporte.Text
                        dts.gfecha_informe = Date.Now
                        dts.gid_usuario = lbIDUsuario.Text
                        
                        If func.insertar_informe_medico(dts) Then
                            'MessageBox.Show("Atencion editada correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Debug.Write("Informe Guardado exitosamente :)")
                            MsgBox("INFORME GUARDADO")
                        Else
                            MessageBox.Show("Los datos no pudieron ser guardados. Intente de nuevo por favor", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("El contenido del informe no puede estar vacio.", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Por favor seleccione una atención primero.", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvEstudiosARealizar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEstudiosARealizar.CellMouseDoubleClick
        Dim estudio As String = generar_texto(dgvEstudiosARealizar)

        Dim fecha As String = ""
        Dim fechaDirecto As String = ""
        Dim salto As String = ""
        Dim Contenido As String = ""
        Dim nombre As String = ""
        Dim edad As String = ""
        Dim medico As String = ""

        lbIDAtencion.Text=tbIdAtencion.Text

        'fecha = "La Paz " & Date.Now.Day & " de " & Date.Now.Month & " de " & Date.Now.Year
        fechaDirecto = Date.Now.ToLongDateString()
        'fecha = modOperacionesAuxiliares.cambiar(fechaDirecto)

        salto = vbCrLf
        nombre = vbTab & vbTab & "PACIENTE: " & vbTab & vbTab & tbApellidos.Text & " " & tbNombres.Text
        edad = vbTab & vbTab & "EDAD: " & vbTab & vbTab & vbTab & tbedad.Text & " años"
        medico = vbTab & vbTab & "MEDICO: " & vbTab & vbTab & tbMedicoRemitente.Text

        rhedctContenidoReporte.Text = salto & salto & salto & "La Paz, " & fechaDirecto & salto & salto & nombre & salto & edad & salto & medico

        'rhedctContenidoReporte.Document.BeginUpdate()
        'rhedctContenidoReporte.Document.AppendText(vbCrLf & estudio)
        'rhedctContenidoReporte.Document.EndUpdate()

    End Sub

    Private Function generar_texto(ByVal tabla As DataGridView) As String
        Dim estudio As String = tabla.SelectedCells.Item(0).Value
        Dim resultado As String = ""
        Select Case (estudio)
            Case "ESTUDIOS ECOGRAFÍA"
                resultado = vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "ESTUDIOS DE ECOGRAFÍA" + vbCrLf + " "

            Case "BIOPSIA GUIADA POR ECOGRAFÍA"
                resultado = vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "BIOPSIA GUIADA POR ECOGRAFÍA" + vbCrLf + " "

            Case "ESTUDIOS CONTRASTADOS"
                resultado = vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "ESTUDIOS CONTRASTADOS" + vbCrLf + " "

            Case "ESTUDIO ANATOMÍA PATOLÓGICA"
                resultado = vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "ESTUDIO ANATOMÍA PATOLÓGICA" + vbCrLf + " "

            Case "ESTUDIOS  DE LA  GLANDULA MAMARIA"
                resultado = vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "ESTUDIOS  DE LA  GLANDULA MAMARIA" + vbCrLf + " "

            Case Else
                resultado = ""
        End Select
        Return resultado
    End Function

    Private Sub brbtnBuscaInforme_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brbtnBuscaInforme.ItemClick
        dlgBuscadorInforme.tbLogin.Text = lbIDUsuario.Text
        dlgBuscadorInforme.ShowDialog()
    End Sub

End Class