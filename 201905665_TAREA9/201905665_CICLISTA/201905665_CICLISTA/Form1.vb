Public Class Form1
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (indice < 12) Then
            'Verificaciones 
            If TXTETAPA.Text <> "" Then
                etapa(indice) = Val(TXTETAPA.Text)
            Else
                MsgBox("Debe ingresar el número de etapa",, "ADVERTENCIA")
            End If

            If CMBEQUIPO.SelectedIndex > -1 Then
                equipo(indice) = CMBEQUIPO.Text
            Else
                MsgBox("Debe seleccionar un equipo",, "ADVERTENCIA")
            End If

            If TXTKM.Text <> "" Then
                km(indice) = Val(TXTKM.Text)
            Else
                MsgBox("Debe ingresar la cantidad de kilómetros recorridos",, "ADVERTENCIA")
            End If

            If TXTTIEMPO.Text <> "" Then
                tiempo(indice) = Val(TXTTIEMPO.Text)
            Else
                MsgBox("Debe ingresar el tiempo del ciclista",, "ADVERTENCIA")
            End If

            'verificación de que se haya seleccionado una nacionalidad
            If (RDBEXT.Checked) Or (RDBGUA.Checked) Then
                If (RDBEXT.Checked) Then
                    nacionalidad(indice) = RDBEXT.Text
                End If

                If (RDBGUA.Checked) Then
                    nacionalidad(indice) = RDBGUA.Text
                End If
            Else
                MsgBox("Debe seleccionar una nacionalidad")
            End If

            'Calculo de penalización
            If tiempo(indice) > 120 Then
                penalización(indice) = tiempo(indice) + 30
            ElseIf tiempo(indice) > 140 Then
                penalización(indice) = tiempo(indice) + 40
            ElseIf tiempo(indice) > 160 Then
                penalización(indice) = tiempo(indice) + 50
            Else
                penalización(indice) = "0"
            End If

            'Bono 
            If tiempo(indice) < 85 And equipo(indice) = "Movistar" Then
                bono(indice) = tiempo(indice) - 15
            ElseIf tiempo(indice) < 85 And equipo(indice) = "Pro Team" Then
                bono(indice) = tiempo(indice) - 10
            Else
                bono(indice) = "0"
            End If


            indice = indice + 1
        End If

        If (indice = 12) Then
            MsgBox("NO SE ACEPTAN MÁS DE 12 ingresos",, "ADVERTENCIA")
        End If
        limpiar_entradas()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        etapa(indice) = TXTETAPA.Text
        equipo(indice) = CMBEQUIPO.Text
        km(indice) = TXTKM.Text
        tiempo(indice) = TXTTIEMPO.Text

        If RDBEXT.Checked Then
            nacionalidad(indice) = "extranjero"
        End If

        If RDBGUA.Checked Then
            nacionalidad(indice) = "guatemalteco"
        End If

        'Calculo de penalización
        If tiempo(indice) > 120 Then
            penalización(indice) = tiempo(indice) + 30
        ElseIf tiempo(indice) > 140 Then
            penalización(indice) = tiempo(indice) + 40
        ElseIf tiempo(indice) > 160 Then
            penalización(indice) = tiempo(indice) + 50
        Else
            penalización(indice) = "0"
        End If

        'Bono 
        If tiempo(indice) < 85 And equipo(indice) = "Movistar" Then
            bono(indice) = tiempo(indice) - 15
        ElseIf tiempo(indice) < 85 And equipo(indice) = "Pro Team" Then
            bono(indice) = tiempo(indice) - 10
        Else
            bono(indice) = "0"
        End If


        MsgBox("Registro actualizado correctamente")

        indice = 11

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click

        etapa(indice) = Nothing
        equipo(indice) = Nothing
        km(indice) = Nothing
        tiempo(indice) = Nothing
        nacionalidad(indice) = Nothing
        penalización(indice) = Nothing
        bono(indice) = Nothing

        For I = indice To 10

            etapa(I) = etapa(I + 1)
            equipo(I) = equipo(I + 1)
            km(I) = km(I + 1)
            tiempo(I) = tiempo(I + 1)
            nacionalidad(I) = nacionalidad(I + 1)
            penalización(I) = penalización(I + 1)
            bono(I) = bono(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        etapa(I) = Nothing
        equipo(I) = Nothing
        km(I) = Nothing
        tiempo(I) = Nothing
        nacionalidad(I) = Nothing
        penalización(I) = Nothing
        bono(I) = Nothing

        indice = I

        limpiar_entradas()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim j As Byte
        Dim temp1 As String

        For I = 0 To 11
            For j = I + 1 To 10
                If (etapa(j) <> Nothing) Then
                    If (etapa(I) > etapa(j)) Then
                        temp1 = etapa(I)
                        etapa(I) = etapa(j)
                        etapa(j) = temp1
                    End If
                Else
                    Exit For
                End If
            Next j
        Next I
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        Dim e1 As Integer = 0
        Dim e2 As Integer = 0
        Dim e3 As Integer = 0
        Dim e4 As Integer = 0
        Dim e5 As Integer = 0
        Dim e6 As Integer = 0
        Dim e7 As Integer = 0
        Dim e8 As Integer = 0
        Dim e9 As Integer = 0
        Dim hora1, min1 As Double
        Dim hora2, min2 As Double
        Dim hora3, min3 As Double
        Dim hora4, min4 As Double


        Dim I As Byte

        I = 0
        While (I <= 11)
            If (etapa(I) <> Nothing) Then

                If (nacionalidad(I) = "guatemalteco") And (km(I) > 45) Then
                    e1 = e1 + 1
                End If

                'Kilometros recorridos por cada equipo
                Select Case equipo(I)
                    Case "Sky"
                        e2 = e2 + Val(km(I))
                        e6 = e6 + Val(tiempo(I))
                    Case "Movistar"
                        e3 = e3 + Val(km(I))
                        e7 = e7 + Val(tiempo(I))
                    Case "Pro Cycling"
                        e4 = e4 + Val(km(I))
                        e8 = e8 + Val(tiempo(I))
                    Case "Pro Team"
                        e5 = e5 + Val(km(I))
                        e9 = e9 + Val(tiempo(I))
                End Select

                I = I + 1
            Else
                Exit While
            End If
        End While

        'mostrar los resultados 
        TXTE1.Text = Str(e1)
        TXTE2.Text = Str(e2)
        TXTE3.Text = Str(e3)
        TXTE4.Text = Str(e4)
        TXTE5.Text = Str(e5)

        hora1 = Int(e6 / 60)
        min1 = (e6 / 60 - hora1) * 60

        hora2 = Int(e7 / 60)
        min2 = (e7 / 60 - hora2) * 60

        hora3 = Int(e8 / 60)
        min3 = (e8 / 60 - hora3) * 60

        hora4 = Int(e9 / 60)
        min4 = (e9 / 60 - hora4) * 60

        TXTE6.Text = Str(System.Math.Round(hora1, 2)) + "horas con " + Str(System.Math.Round(min1, 2)) + "minutos"
        TXTE7.Text = Str(System.Math.Round(hora2, 2)) + "horas con " + Str(System.Math.Round(min2, 2)) + "minutos"
        TXTE8.Text = Str(System.Math.Round(hora3, 2)) + "horas con " + Str(System.Math.Round(min3, 2)) + "minutos"
        TXTE9.Text = Str(System.Math.Round(hora4, 2)) + "horas con " + Str(System.Math.Round(min4, 2)) + "minutos"
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub BTNCONSULTAR_Click(sender As Object, e As EventArgs) Handles BTNCONSULTAR.Click
        Dim i As Byte = 0

        If TXTCONSULTA.Text = "" Then
            MsgBox("No se ingresó en número de etapa")
        End If

        Dim encontro = False

        For indice As Integer = 0 To 11
            If (etapa(indice) <> Nothing) Then
                If (etapa(indice) = TXTCONSULTA.Text) Then
                    TXTETAPA.Text = etapa(indice)
                    CMBEQUIPO.Text = equipo(indice)
                    TXTKM.Text = km(indice)
                    TXTTIEMPO.Text = tiempo(indice)
                    If nacionalidad(indice) = "extranjero" Then
                        RDBEXT.Checked = True
                    End If

                    If nacionalidad(indice) = "guatemalteco" Then
                        RDBGUA.Checked = True
                    End If
                    encontro = True

                    DataGridView1.Rows.Clear()
                    DataGridView1.Rows.Add(Str(etapa(i)), equipo(i), km(i), tiempo(i), nacionalidad(i), penalización(i), bono(i))

                End If
            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el número de etapa")
        ElseIf encontro = True Then
            MsgBox("Se encontró el número de etapa buscado")

        End If
    End Sub
End Class
