Module modOperacionesAuxiliares
    Function TuEdad(ByVal dInicio As Date, ByVal dFin As Date) As Integer
        Dim Dias As Integer, Meses As Integer, Años As Integer
        Dim Edad As Integer
        Dim DiasMes As Integer

        Dias = DateAndTime.Day(dFin) - Microsoft.VisualBasic.DateAndTime.Day(dInicio)
        Meses = DatePart("m", dFin) - DatePart("m", dInicio)
        Años = DateDiff("yyyy", dInicio, dFin)
        If Dias < 0 Then
            DiasMes = DateAndTime.Day(DateSerial(Year(dInicio), Month(dInicio) + 1, 0))
            Dias = (DiasMes - DateAndTime.Day(dInicio)) + DateAndTime.Day(dFin)
            Meses = Meses - 1
        End If
        If Meses < 0 Then
            Meses = 12 + Meses
            Años = Años - 1
        End If
        'TuEdad = MsgBox("Tenes " & Format(Años, "00" & " Años") & Format(Meses, "00" & " Meses ") & Format(Dias, "00" & " Dias"))
        Edad = Años
        Return Edad
    End Function
End Module
