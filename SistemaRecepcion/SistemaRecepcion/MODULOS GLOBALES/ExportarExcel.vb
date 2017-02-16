Imports Microsoft.Office.Interop
Public Class ExportarExcel
    Public Sub exportarInforme(ByVal tabla As DataTable)
        Dim fila As DataRow
        Dim posicion As Integer = 3
        Dim MExcel As New Excel.Application
        Dim objLibroExcel As Excel.Workbook = MExcel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        Dim contador As Integer = 1
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            .Name = "Datos_Exportados"
            .Range("A1").Value = "REPORTE DE ATENCIONES"
            .Range("A1").Font.Size = 28
            .Range("A1").Font.Bold = True
            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A1").RowHeight = 30
            .Range("A1:L1").MergeCells = True

            .Range("A2").Value = "Nº"
            .Range("A2").Font.Bold = True
            .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A2").ColumnWidth = 10
            .Range("B2").Value = "FECHA DE ATENCION"
            .Range("B2").Font.Bold = True
            .Range("B2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("B2").ColumnWidth = 20
            .Range("C2").Value = "APELLIDOS"
            .Range("C2").Font.Bold = True
            .Range("C2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("C2").ColumnWidth = 30
            .Range("D2").Value = "NOMBRES"
            .Range("D2").Font.Bold = True
            .Range("D2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("D2").ColumnWidth = 30
            .Range("E2").Value = "MÉDICO REMITENTE"
            .Range("E2").Font.Bold = True
            .Range("E2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("E2").ColumnWidth = 20
            .Range("F2").Value = "ENTIDAD"
            .Range("F2").Font.Bold = True
            .Range("F2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("F2").ColumnWidth = 20
            .Range("G2").Value = "MÉDICO DESTINATARIO"
            .Range("G2").Font.Bold = True
            .Range("G2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("G2").ColumnWidth = 20
            .Range("H2").Value = "CÓDIGO DE ESTUDIO"
            .Range("H2").Font.Bold = True
            .Range("H2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("H2").ColumnWidth = 30
            .Range("I2").Value = "CATEGORIA"
            .Range("I2").Font.Bold = True
            .Range("I2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("I2").ColumnWidth = 40
            .Range("J2").Value = "ESTUDIO"
            .Range("J2").Font.Bold = True
            .Range("J2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("J2").ColumnWidth = 50
            .Range("K2").Value = "PRECIO"
            .Range("K2").Font.Bold = True
            .Range("K2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("K2").ColumnWidth = 10
            .Range("L2").Value = "ID_ATENCION"
            .Range("L2").Font.Bold = True
            .Range("L2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("L2").ColumnWidth = 10
        End With

        For Each fila In tabla.Rows
            objHojaExcel.Range("A" & posicion).Value = contador
            objHojaExcel.Range("A" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("B" & posicion).Value = fila.Item("FECHA_ATENCION")
            objHojaExcel.Range("B" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("C" & posicion).Value = fila.Item("APELLIDOS")
            objHojaExcel.Range("D" & posicion).Value = fila.Item("NOMBRE")
            objHojaExcel.Range("E" & posicion).Value = fila.Item("MEDICO_REMITENTE")
            objHojaExcel.Range("E" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("F" & posicion).Value = fila.Item("ENTIDAD")
            objHojaExcel.Range("F" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("G" & posicion).Value = fila.Item("MEDICO_DESTINATARIO")
            objHojaExcel.Range("H" & posicion).Value = fila.Item("CODIGO_ESTUDIO")
            objHojaExcel.Range("H" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("I" & posicion).Value = fila.Item("CATEGORIA")
            objHojaExcel.Range("I" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("J" & posicion).Value = fila.Item("ESTUDIO")
            objHojaExcel.Range("K" & posicion).Value = fila.Item("PRECIO")
            objHojaExcel.Range("K" & posicion).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            objHojaExcel.Range("L" & posicion).Value = fila.Item("id_atencion")

            posicion += 1
            contador = posicion - 3
        Next
        MExcel.Visible = True
    End Sub
End Class
