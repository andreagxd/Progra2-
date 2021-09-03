Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        'Vectores 
        If (indice <= 11) Then
            'Verificaciones de ingreso de datos 
            If (IsNumeric(TXTNIT.Text)) And Val((TXTNIT.Text) > 0) Then
                ver1 = Val(TXTNIT.Text)
            Else
                MsgBox("Dato ingresado no válido",, "Advertencia")
                TXTNIT.Focus()
                Exit Sub
            End If

            If (IsNumeric(TXTSALDOANTERIOR.Text)) And Val((TXTSALDOANTERIOR.Text) > 0) Then
                ver1 = Val(TXTSALDOANTERIOR.Text)
            Else
                MsgBox("Dato ingresado no válido",, "Advertencia")
                TXTSALDOANTERIOR.Focus()
                Exit Sub
            End If

            If (IsNumeric(TXTCONSUMOMENSUAL.Text)) And Val((TXTCONSUMOMENSUAL.Text) > 0) Then
                ver1 = Val(TXTCONSUMOMENSUAL.Text)
            Else
                MsgBox("Dato ingresado no válido",, "Advertencia")
                TXTCONSUMOMENSUAL.Focus()
                Exit Sub
            End If

            'Tarifa residencial
            If (CMBSERVICIO.SelectedItem = "RESIDENCIAL") Then
                Select Case Val(TXTCONSUMOMENSUAL.Text)
                    Case 1 To 100
                        tarifa = 0.99
                    Case 101 To 300
                        tarifa = 1.2
                    Case Is >= 301
                        tarifa = 3
                    Case Else
                        MsgBox("ERROR NO SELECCIONO TIPO DE SERVICIO")
                End Select
            End If

            'Tarifa Industrial 
            If (CMBSERVICIO.SelectedItem = "INDUSTRIAL") Then
                Select Case Val(TXTCONSUMOMENSUAL.Text)
                    Case 1 To 100
                        tarifa = 1.99
                    Case 101 To 300
                        tarifa = 2.2
                    Case Is >= 301
                        tarifa = 4
                    Case Else
                        MsgBox("ERROR NO SELECCIONO TIPO DE SERVICIO")
                End Select
            End If

            'Pago inicial 
            pago_inicial = Val(TXTCONSUMOMENSUAL.Text) * tarifa

            'Mora 
            If Val(TXTSALDOANTERIOR.Text) > 0 Then
                mora = Val(TXTSALDOANTERIOR.Text) * 0.02
            End If

            'Descuentos 
            Select Case (CMBTARIFA.SelectedIndex)
                Case 0
                    descuento = (Val(TXTSALDOANTERIOR.Text) + mora + pago_inicial) * 0.2
                Case 1
                    descuento = (pago_inicial) * 0.1
                Case Else
                    MsgBox("ERROR NO SELECCIONO TARIFA")
            End Select

            'Total a pagar 
            pagototal = Val(TXTSALDOANTERIOR.Text) + pago_inicial + mora

            'Mostrar datos 
            tipo_de_servicio(indice) = CMBSERVICIO.Text
            tipo_de_tarifa(indice) = CMBTARIFA.Text
            saldo_anterior(indice) = "Q" & Val(TXTSALDOANTERIOR.Text)
            pago_inicial1(indice) = "Q" & System.Math.Round(pago_inicial, 2)
            mora1(indice) = "Q" & System.Math.Round(mora, 2)
            descuento1(indice) = "Q" & System.Math.Round(descuento, 2)
            pago_total1(indice) = "Q" & System.Math.Round(pagototal, 2)
            nombre(indice) = (TXTNOMBRE.Text)
            nit(indice) = Val(TXTNIT.Text)

            mostrar_vectores()

            indice = indice + 1
        End If

        If (indice = 11) Then
            MsgBox("NO SE ACEPTAN MÁS DE 11 CLIENTES")
        End If
        limpiar_entradas()


    End Sub

    Private Sub BTNLIMPIARENTRADAS_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARENTRADAS.Click
        limpiar_entradas()
    End Sub

    Private Sub BTNLIMPIARLISTAS_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARLISTAS.Click
        limpiar_listas()
    End Sub

    Private Sub BTNLIMPIARVECTORES_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARVECTORES.Click
        limpiar_vectores()
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            'Limpiar entradas unicamente por si se desea seguir ingresando datos 
            limpiar_entradas()
        End If
    End Sub
End Class
