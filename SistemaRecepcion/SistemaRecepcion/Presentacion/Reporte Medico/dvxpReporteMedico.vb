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
        Dim fecha As String = ""
        Dim salto As String = ""
        Dim Contenido As String = ""
        Dim nombre As String = ""
        Dim edad As String = ""
        Dim medico As String = ""

        'fecha = "La Paz " & Date.Now.Day & " de " & Date.Now.Month & " de " & Date.Now.Year
        fecha = Date.Now.ToLongDateString()
        salto = vbCrLf
        nombre = vbTab & vbTab & "PACIENTE: " & vbTab & vbTab & tbApellidos.Text & " " & tbNombres.Text
        edad = vbTab & vbTab & "EDAD: " & vbTab & vbTab & tbedad.Text
        medico = vbTab & vbTab & "MEDICO: " & vbTab & vbTab & tbMedicoRemitente.Text

        rhedctContenidoReporte.Text = fecha & salto & salto & salto & nombre & salto & edad & salto & medico

        rhedctContenidoReporte.Document.BeginUpdate()
        rhedctContenidoReporte.Document.AppendText("First Paragraph" & ControlChars.Lf & "Second Paragraph" & ControlChars.Lf & "Third Paragraph")
        rhedctContenidoReporte.Document.EndUpdate()
        Dim pos As DocumentPosition = rhedctContenidoReporte.Document.CaretPosition
        Dim doc As SubDocument = pos.BeginUpdateDocument()
        Dim par As Paragraph = doc.Paragraphs.Get(pos)
        Dim newPos As DocumentPosition = doc.CreatePosition(par.Range.End.ToInt() - 1)
        doc.InsertText(newPos, "<<Appended to Paragraph End>>")
        pos.EndUpdateDocument(doc)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ntIcon.BalloonTipText = "AVISO"

        ntIcon.ShowBalloonTip(5)
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

                        dts.gid_atencion = tbIdAtencion.Text
                        dts.ginforme = rhedctContenidoReporte.Text
                        dts.gfecha_informe = Date.Now


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
        Dim salto As String = ""
        Dim Contenido As String = ""
        Dim nombre As String = ""
        Dim edad As String = ""
        Dim medico As String = ""

        'fecha = "La Paz " & Date.Now.Day & " de " & Date.Now.Month & " de " & Date.Now.Year
        fecha = Date.Now.ToLongDateString()
        salto = vbCrLf
        nombre = vbTab & vbTab & "PACIENTE: " & vbTab & vbTab & tbApellidos.Text & " " & tbNombres.Text
        edad = vbTab & vbTab & "EDAD: " & vbTab & vbTab & tbedad.Text
        medico = vbTab & vbTab & "MEDICO: " & vbTab & vbTab & tbMedicoRemitente.Text

        rhedctContenidoReporte.Text = salto & salto & fecha & salto & salto & salto & nombre & salto & edad & salto & medico

        rhedctContenidoReporte.Document.BeginUpdate()
        rhedctContenidoReporte.Document.AppendText(vbCrLf & estudio & ControlChars.Lf & "Atentamente:  " & ControlChars.Lf & "NOMBRE DEL MEDICO")
        rhedctContenidoReporte.Document.EndUpdate()

    End Sub

    Private Function generar_texto(ByVal tabla As DataGridView) As String
        Dim estudio As String = tabla.SelectedCells.Item(0).Value
        Dim resultado As String = ""
        Select Case (estudio)
            Case "ESTUDIOS ECOGRAFÍA"
                resultado = vbCrLf & vbCrLf & "ESTUDIOS DE ECOGRAFÍA" + vbCrLf + "Nota. Conserve estos  estudios  y  muéstrelos  a  su  Medico  Radiólogo  en el siguiente  control  un cambio  mínimo  puede  indicarnos un  cáncer en  estadios  tempranos cuando aun es  CURABLE. " + vbCrLf + "Del 15 al 30% de los  canceres no  puede ser  diagnosticado por  métodos de  imagen,  un  estudio negativo no  contraindica  la  biopsia  si clínicamente   lo  amerita."

            Case "BIOPSIA GUIADA POR ECOGRAFÍA"
                resultado = "BIOPSIA GUIADA POR ECOGRAFÍA"

            Case "ESTUDIOS CONTRASTADOS"
                resultado = "ESTUDIOS CONTRASTADOS"
            Case "ESTUDIO ANATOMÍA PATOLÓGICA"
                resultado = "ESTUDIO ANATOMÍA PATOLÓGICA"
            Case Else
                resultado = ""
        End Select
        Return resultado
    End Function
End Class