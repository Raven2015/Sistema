Public Class frmReporteCategorias
    Private Sub frmReporteCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbBioDataSet.mostrar_categoria' table. You can move, or remove it, as needed.
        Me.mostrar_categoriaTableAdapter.Fill(Me.dbBioDataSet.mostrar_categoria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class