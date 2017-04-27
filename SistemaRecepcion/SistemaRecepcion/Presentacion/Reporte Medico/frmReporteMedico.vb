Imports System.Drawing.Text
Imports System.IO


Public Class frmReporteMedico

    Private dt As New DataTable
    Private Sub CarregarFont()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\font.txt") = False Then
            Dim fi As New System.IO.StreamWriter(Application.StartupPath & "\font.txt")
            Dim family As FontFamily
            For Each family In FontFamily.Families
                If family.IsStyleAvailable(FontStyle.Bold) = False Then Exit For
                fi.WriteLine(family.Name)
            Next family
            fi.Close()
        End If
        '-------------------------------------------------------------------------------------------/
        Dim linha As New StreamReader(Application.StartupPath & "\font.txt")
        Do While Not linha.EndOfStream
            txtFont.Items.Add(linha.ReadLine)
        Loop
        linha.Close()
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SCor.ShowDialog()
        rtbAreaTexto.SelectionColor = SCor.Color
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SCor.ShowDialog()
        rtbAreaTexto.SelectionBackColor = SCor.Color
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFont()
    End Sub


    Private Sub txtSize_ValueChanged(sender As Object, e As EventArgs) Handles txtSize.ValueChanged
        Dim f As New Font(rtbAreaTexto.SelectionFont.FontFamily, txtSize.Value)
        rtbAreaTexto.SelectionFont = f
    End Sub
    Private Sub txtFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtFont.SelectedIndexChanged
        Dim f As New Font(txtFont.Text, rtbAreaTexto.SelectionFont.Size)
        rtbAreaTexto.SelectionFont = f
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Try
            SaveFile1.ShowDialog()
            Dim saveT As New System.IO.StreamWriter(SaveFile1.FileName)
            saveT.Write(rtbAreaTexto.Rtf)
            saveT.Close()
        Catch
            MsgBox("Erro ao salvar arquivo.", MsgBoxStyle.Exclamation, Title:="Salvar")
        End Try
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Try
            OpenFile1.ShowDialog()
            Dim ri As New System.IO.StreamReader(OpenFile1.FileName)
            rtbAreaTexto.Rtf = ri.ReadToEnd
            ri.Close()
        Catch
            MsgBox("Erro ao abrir arquivo.", MsgBoxStyle.Exclamation, Title:="Abrir")
        End Try
    End Sub

    Private Sub btnNegrita_Click(sender As Object, e As EventArgs) Handles btnNegrita.Click
        If rtbAreaTexto.SelectionFont.Style = FontStyle.Regular Then
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Bold)
        Else
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Regular)
        End If

    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        rtbAreaTexto.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnCentro_Click(sender As Object, e As EventArgs) Handles btnCentro.Click
        rtbAreaTexto.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        rtbAreaTexto.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnJustificado_Click(sender As Object, e As EventArgs) Handles btnJustificado.Click
    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click
        If rtbAreaTexto.SelectionFont.Style = FontStyle.Regular Then
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Italic)
        Else
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnSubrayado_Click(sender As Object, e As EventArgs) Handles btnSubrayado.Click
        If rtbAreaTexto.SelectionFont.Style = FontStyle.Regular Then
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Underline)
        Else
            rtbAreaTexto.SelectionFont = New Font(rtbAreaTexto.SelectionFont, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
    End Sub

    Private Sub datos_informe_medico()

    End Sub
    Private Sub mostrar(ByVal id_atencion As Integer)
        Try
            Dim func As New fReporteMedico
            dt = func.mostrar(id_atencion)

            If dt.Rows.Count <> 0 Then
                pnContenedor.Visible = True
                dgvResultados.DataSource = dt
                dgvResultados.ColumnHeadersVisible = True
                lbDatosInexistentes.Visible = False
            Else
                pnContenedor.Visible = False
                dgvResultados.DataSource = Nothing
                dgvResultados.ColumnHeadersVisible = False
                lbDatosInexistentes.Visible = True
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
    Private Sub dgvResultados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellContentDoubleClick
        llenar_datos()
        pnContenedor.Visible = False
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


    'Private Sub tbIdAtencion_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIdAtencion.KeyDown
    '    If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue <= 8)) Then
    '        e.Handled = True
    '        Debug.Write("Este campo solo requiere números")
    '        tbIdAtencion.Text = vbNullChar
    '    End If
    'End Sub


End Class




