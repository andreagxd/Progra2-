Module Module1
    'Vectores
    Public indice As Byte = 0
    Public dpi(6) As Integer
    Public nombre(6) As String
    Public valor(6) As Double
    Public cantidad(6) As Integer
    Public interes(6) As Double
    Public final(6) As Double
    Public I As Integer
    Sub limpiar_entradas()
        Form1.TXTDPI.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTCANTIDAD.Clear()
        Form1.TXTVALOR.Clear()
    End Sub
    Sub limpiar_vectores()
        Dim i As Byte

        For i = 0 To 6
            dpi(i) = Nothing
            nombre(i) = Nothing
            valor(i) = Nothing
            cantidad(i) = Nothing
            interes(i) = Nothing
            final(i) = Nothing
        Next i

        Form1.DataGridView1.Rows.Clear()

        indice = 0
    End Sub

    Sub mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()

        For I = 0 To 6

            If (dpi(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((dpi(I)), nombre(I), valor(I), cantidad(I), interes(I), final(I))
            Else

                Exit For
            End If
        Next I
    End Sub
    Public Function ctasa(meses As Integer, valor As Double) As Double

        If meses = 12 And valor > 8000 Then
            Return 0.02
        ElseIf meses > 12 And meses <= 24 Then
            Return 0.045
        ElseIf meses > 24 And meses <= 36 Then
            Return 0.055
        ElseIf meses >= 36 Then
            Return 0.062
        ElseIf meses <= 12 Then
            Return 0.03
        End If

        Return 0
    End Function

End Module
