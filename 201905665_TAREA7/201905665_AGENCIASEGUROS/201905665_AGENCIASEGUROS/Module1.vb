Module Module1
    'Vectores
    Public indice As Byte = 0
    Public edad(6) As Integer
    Public genero(6) As String
    Public codigo(6) As String
    Public monto(6) As Double
    Public taller(6) As String
    Public deducible(6) As Double


    Sub mostrar_vectores()
        Dim x As Byte
        Form1.LST1.Items.Clear()
        Form1.LST2.Items.Clear()
        Form1.LST3.Items.Clear()
        Form1.LST4.Items.Clear()
        Form1.LST5.Items.Clear()
        Form1.LST6.Items.Clear()

        For x = 0 To 6
            If edad(x) <> Nothing Then
                Form1.LST1.Items.Add(edad(x))
                Form1.LST2.Items.Add(genero(x))
                Form1.LST3.Items.Add(codigo(x))
                Form1.LST4.Items.Add(monto(x))
                Form1.LST5.Items.Add(taller(x))
                Form1.LST6.Items.Add(deducible(x))
            Else
                Exit For
            End If
        Next x
    End Sub
    Sub limpiar_entradas()
        Form1.TXTEDAD.Clear()
        Form1.TXTMONTO.Clear()
        Form1.CMBGENERO.Text = ""
        Form1.CMBREGISTRO.Text = ""
        Form1.CMBTALLER.Text = ""
    End Sub
    Sub limpiar_vectores()
        Dim i As Byte

        For i = 0 To 6
            edad(i) = Nothing
            genero(i) = Nothing
            codigo(i) = Nothing
            monto(i) = Nothing
            taller(i) = Nothing
            deducible(i) = Nothing
        Next i
        Form1.LST1.Items.Clear()
        Form1.LST2.Items.Clear()
        Form1.LST3.Items.Clear()
        Form1.LST4.Items.Clear()
        Form1.LST5.Items.Clear()
        Form1.LST6.Items.Clear()

        indice = 0
    End Sub
    Sub limpiar_estadisticas()
        Form1.TXTMENORES.Clear()
        Form1.TXTFEMENINO.Clear()
        Form1.TXTMASCULINO.Clear()
        Form1.TXTEXTRANJEROS.Clear()
        Form1.TXTTOTALCONDUCTORES.Clear()
        Form1.TXTTOTALMONTO.Clear()
    End Sub

    Sub estadisticas()
        Dim i As Byte
        Dim estadistica1 As Byte = 0
        Dim estadistica2 As Byte = 0
        Dim estadistica3 As Byte = 0
        Dim estadistica4 As Byte = 0

        For i = 0 To Form1.LST1.Items.Count - 1
            If (edad(i) < 25) Then
                estadistica1 = estadistica1 + 1
            End If

            If (genero(i) = "FEMENINO") Then
                estadistica2 = estadistica2 + 1
            End If

            If (genero(i) = "MASCULINO") And (edad(i) > 18) And (edad(i) < 25) Then
                estadistica3 = estadistica3 + 1
            End If

            If (codigo(i) = "0") Then
                estadistica4 = estadistica4 + 1
            End If
        Next i

        Form1.TXTMENORES.Text = (estadistica1 / indice) * 100
        Form1.TXTFEMENINO.Text = (estadistica2 / indice) * 100
        Form1.TXTMASCULINO.Text = (estadistica3 / indice) * 100
        Form1.TXTEXTRANJEROS.Text = (estadistica4 / indice) * 100
        Form1.TXTTOTALCONDUCTORES.Text = indice
    End Sub

    Sub total_monto()
        Dim totalmonto As Integer = 0
        Dim r As Integer

        For r = 0 To Form1.LST4.Items.Count - 1
            totalmonto = totalmonto + Val(Form1.LST4.Items.Item(r))
        Next r
        Form1.TXTTOTALMONTO.Text = Str(totalmonto)
    End Sub
End Module
