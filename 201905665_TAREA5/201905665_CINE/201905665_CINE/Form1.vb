Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        If (indice < 9) Then
            If (IsNumeric(TXTENTRADAS.Text)) And Val((TXTENTRADAS.Text) > 0) Then
                ver1 = Val(TXTENTRADAS.Text)
            Else
                MsgBox("Dato ingresado no válido",, "Advertencia")
                TXTENTRADAS.Focus()
                Exit Sub
            End If

            'Tarifa para el cine A 
            Select Case (CMBCINE.Text)
                Case "A"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 0 : tarifa = 30
                        Case 1 : tarifa = 35
                        Case 2 : tarifa = 40
                        Case 3 : tarifa = 40
                    End Select
            End Select

            'Tarifa para el cine B 
            Select Case (CMBCINE.Text)
                Case "B"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 0 : tarifa = 24
                        Case 1 : tarifa = 34
                        Case 2 : tarifa = 44
                        Case 3 : tarifa = 44
                    End Select
            End Select

            'Tarifa para el cine C
            Select Case (CMBCINE.Text)
                Case "C"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 0 : tarifa = 35
                        Case 1 : tarifa = 40
                        Case 2 : tarifa = 50
                        Case 3 : tarifa = 50
                    End Select
            End Select

            'Entrada 
            entradas = Val(TXTENTRADAS.Text)

            'Subtotal 
            subtotal_1 = entradas_1(entradas, tarifa)

            'Descuento 1 
            Select Case (CMBCINE.Text)
                Case "A"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 1 : descuentoo = 0.015
                        Case Else
                            descuentoo = 0
                    End Select
            End Select

            Select Case (CMBCINE.Text)
                Case "B"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 0 : descuentoo = 0.03
                        Case 2 : descuentoo = 0.055
                        Case 3 : descuentoo = 0.055
                        Case Else
                            descuentoo = 0
                    End Select
            End Select

            Select Case (CMBCINE.Text)
                Case "C"
                    Select Case (CMBFUNCION.SelectedIndex)
                        Case 0 : descuentoo = 0.03
                        Case 2 : descuentoo = 0.055
                        Case 3 : descuentoo = 0.055
                        Case Else
                            descuentoo = 0
                    End Select
            End Select

            'Descuento 2
            Select Case subtotal_1
                Case 100 To 300
                    descuento = 0.02
                Case 300 To 500
                    descuento = 0.04
                Case 500 To 1000
                    descuento = 0.06
                Case Else
                    descuento = 0
            End Select

            'Descuento 1
            descuento_1 = desc1(subtotal_1, descuentoo)

            'Descuento 2 
            descuento_2 = desc2(subtotal_1, descuento)

            'Total a pagar 
            total_1 = subtotal_1 - descuento_1 - descuento_2

            'Mostrar datos 
            cine(indice) = CMBCINE.Text
            funcion(indice) = CMBFUNCION.Text
            numeroe(indice) = Val(TXTENTRADAS.Text)
            subtotal(indice) = "Q" & System.Math.Round(subtotal_1, 2)
            Descuento1(indice) = "Q" & descuentoo
            Descuento2(indice) = "Q" & System.Math.Round(descuento, 2)
            total(indice) = "Q" & System.Math.Round(total_1, 2)

            mostrar_vectores()

            indice = indice + 1
        End If

        If (indice = 9) Then
            MsgBox("NO SE ACEPTAN MÁS DE 9 ingresos")
        End If
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARLISTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARLISTAS.Click
        limpiar_listas()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARENTRADAS.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARVECTORES.Click
        limpiar_vectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            'Limpiar entradas unicamente por si se desea seguir ingresando datos 
            limpiar_entradas()
        End If
    End Sub

End Class
