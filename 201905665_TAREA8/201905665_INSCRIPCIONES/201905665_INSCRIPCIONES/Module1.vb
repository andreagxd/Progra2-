Module Module1
    'Vectores
    Public indice As Byte = 0
    Public colegio(7, 7) As String

    'Constantes 
    Public Const inscripcion_basicos As Integer = 350
    Public Const inscripcion_diversificado As Integer = 450
    Public Const mensual_basicos As Integer = 250
    Public Const mensual_diversificado As Integer = 350

    Sub mostrar_matriz()
        Dim i As Byte

        For i = 0 To 6

            If colegio(i, 0) <> Nothing Then
                Form1.DataGridView2.Rows.Add(colegio(i, 0), colegio(i, 1), colegio(i, 2), colegio(i, 3), colegio(i, 4), colegio(i, 5), colegio(i, 6))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub limpiar_entradas()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTCARNET.Clear()
        Form1.CMBDIVER.Text = ""
        Form1.CMBPAGO.Text = ""
        Form1.RDBBASICOS.Checked = False
        Form1.RDBDIVER.Checked = False
    End Sub

    Sub limpiar_matriz()

        Dim i As Byte, j As Byte

        'el ciclo for externo (i) controlará las filas de la matriz
        'el ciclo for interno (j) controlará las columnas de la matriz

        For i = 0 To 6
            For j = 0 To 6
                colegio(i, j) = Nothing
            Next j
        Next i

        Form1.DataGridView2.Rows.Clear()

        indice = 0
    End Sub

    Sub limpiar_totales()
        Form1.TXTGENERAL.Clear()
        Form1.TXTEFECTIVO.Clear()
        Form1.TXTTARJETA.Clear()
        Form1.TXTTRANSF.Clear()
        Form1.TXTDEPOSITO.Clear()
        Form1.TXTBASICOS.Clear()
        Form1.TXTDIVER.Clear()
        Form1.TXTPERITO.Clear()
        Form1.TXTBACH.Clear()
        Form1.TXTDISEÑO.Clear()
        Form1.TXTELEC.Clear()
    End Sub

    Sub totales()
        Dim i As Byte
        Dim totgeneral As Double = 0
        Dim totefectivo As Double = 0
        Dim tottarjeta As Double = 0
        Dim tottransf As Double = 0
        Dim totdeposito As Double = 0
        Dim totbasicos As Double = 0
        Dim totdiver As Double = 0
        Dim totperito As Byte = 0
        Dim totbach As Byte = 0
        Dim totelec As Byte = 0
        Dim totdiseño As Byte = 0

        For i = 0 To 6

            If (colegio(i, 0) <> Nothing) Then

                If Val(colegio(i, 5) <> 0) Then
                    totgeneral = totgeneral + Val(colegio(i, 5))
                End If

                If (colegio(i, 4) = "Efectivo") Then
                    totefectivo = totefectivo + Val(colegio(i, 5))
                End If

                If (colegio(i, 4) = "Tarjeta de crédito") Then
                    tottarjeta = tottarjeta + Val(colegio(i, 5))
                End If

                If (colegio(i, 4) = "Transferencia por ACH") Then
                    tottransf = tottransf + Val(colegio(i, 5))
                End If

                If (colegio(i, 4) = "Depósito Bancario") Then
                    totdeposito = totdeposito + Val(colegio(i, 5))
                End If

                If (colegio(i, 2) = "Básicos") Then
                    totbasicos = totbasicos + Val(colegio(i, 5))
                End If

                If (colegio(i, 2) = "Diversificado") Then
                    totdiver = totdiver + Val(colegio(i, 5))
                End If

                If (colegio(i, 3) = "Perito Contador") Then
                    totperito = totperito + 1
                End If

                If (colegio(i, 3) = "Bachillerato") Then
                    totbach = totbach + 1
                End If

                If (colegio(i, 3) = "Electrónica") Then
                    totelec = totelec + 1
                End If

                If (colegio(i, 3) = "Diseño Gráfico") Then
                    totdiseño = totdiseño + 1
                End If
            Else
                Exit For
            End If
        Next i

        'Mostrar totales
        Form1.TXTGENERAL.Text = System.Math.Round(totgeneral, 2)
        Form1.TXTEFECTIVO.Text = System.Math.Round(totefectivo, 2)
        Form1.TXTTARJETA.Text = System.Math.Round(tottarjeta, 2)
        Form1.TXTTRANSF.Text = System.Math.Round(tottransf, 2)
        Form1.TXTDEPOSITO.Text = System.Math.Round(totdeposito, 2)
        Form1.TXTBASICOS.Text = System.Math.Round(totbasicos, 2)
        Form1.TXTDIVER.Text = System.Math.Round(totdiver, 2)
        Form1.TXTPERITO.Text = System.Math.Round(totperito, 2)
        Form1.TXTBACH.Text = System.Math.Round(totbach, 2)
        Form1.TXTELEC.Text = System.Math.Round(totelec, 2)
        Form1.TXTDISEÑO.Text = System.Math.Round(totdiseño, 2)

    End Sub
End Module
