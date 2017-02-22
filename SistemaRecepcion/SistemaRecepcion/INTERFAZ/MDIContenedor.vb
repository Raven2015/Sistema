Imports System.Windows.Forms

Public Class MDIContenedor
    Private Sub MDIContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.White
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PACIENTESToolStripMenuItem.Click
        frmCliente.ShowDialog()
    End Sub
End Class
