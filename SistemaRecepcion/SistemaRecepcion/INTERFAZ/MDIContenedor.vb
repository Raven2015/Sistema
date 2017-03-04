Imports System.Windows.Forms

Public Class MDIContenedor

    Dim state As Integer
    Dim px, py As Integer
    Dim mover As Boolean

    Private Sub MDIContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BackColor = Color.White
        lbHora.Text = TimeOfDay
        tmHora.Start()
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PACIENTESToolStripMenuItem.Click
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMover_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMover.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub btnMover_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMover.MouseUp
        mover=false
    End Sub

    Private Sub tmHora_Tick(sender As Object, e As EventArgs) Handles tmHora.Tick
        lbHora.Text = TimeOfDay
        tmHora.Start()
    End Sub

    Private Sub btnAtención_Click(sender As Object, e As EventArgs) Handles btnAtención.Click
        frmCentral.ShowDialog()
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        frmCotizacion.ShowDialog()
    End Sub

    Private Sub btnArqueos_Click(sender As Object, e As EventArgs) Handles btnArqueos.Click
        frmArqueos.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        frmMenuReportes.ShowDialog()
    End Sub

    Private Sub ESTUDIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTUDIOSToolStripMenuItem.Click
        frmEstudio.ShowDialog()
    End Sub

    Private Sub CATEGORIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CATEGORIASToolStripMenuItem.Click
        frmCategoria.ShowDialog()
    End Sub

    Private Sub ATENCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATENCIONToolStripMenuItem.Click
        frmAtencion.ShowDialog()
    End Sub

    Private Sub ENTIDADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTIDADESToolStripMenuItem.Click
        frmEntidad.ShowDialog()
    End Sub

    Private Sub COTIZACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COTIZACIONToolStripMenuItem.Click
        frmCotizacion.ShowDialog()
    End Sub

    Private Sub ARQUEOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARQUEOSToolStripMenuItem.Click
        frmArqueos.ShowDialog()
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click
        frmArqueos.ShowDialog()
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnComprobante.Click
        frmComprobantesCaja.ShowDialog()
    End Sub

    Private Sub LISTADEPRECIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADEPRECIOSToolStripMenuItem.Click
        frmListaPrecios.ShowDialog()
    End Sub

    Private Sub COMPROBANTESDECAJAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPROBANTESDECAJAToolStripMenuItem.Click
        frmComprobantesCaja.ShowDialog()
    End Sub

    Private Sub btnMover_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMover.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub
End Class
