Public Class Form1
    Private Sub CHKEFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEFECTIVO.CheckedChanged
        If (CHKEFECTIVO.Checked) Then
            TXTEFECTIVO.Visible = True
            TXTEFECTIVO.Focus()
        Else
            TXTEFECTIVO.Clear()
            TXTEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub CHKTARJETA_CheckedChanged(sender As Object, e As EventArgs) Handles CHKTARJETA.CheckedChanged
        If (CHKTARJETA.Checked) Then
            TXTTARJETA.Visible = True
            TXTTARJETA.Focus()
        Else
            TXTTARJETA.Clear()
            TXTTARJETA.Visible = False
        End If
    End Sub
    Function precioo() As Double
        Select Case (CMBMARCA.SelectedIndex)
            Case 0 : precio = 250
            Case 1 : precio = 450
            Case 2 : precio = 325
            Case 3 : precio = 300
        End Select
        Return precio
    End Function

    Private Sub PROCESOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESOSToolStripMenuItem.Click
        If (indice < 6) Then
            'Verificaciones 
            If TXTNIT.Text <> "" Then
                nit(indice) = Val(TXTNIT.Text)
            Else
                MsgBox("Ingrese número de NIT",, "ADVERTENCIA")
            End If

            If TXTNUMPLACA.Text <> "" Then
                placa(indice) = Val(TXTNUMPLACA.Text)
            Else
                MsgBox("Ingrese número de placa",, "ADVERTENCIA")
            End If

            If TXTDIAS.Text <> "" Then
                dias(indice) = Val(TXTDIAS.Text)
            Else
                MsgBox("Ingrese número de días a alquilar el auto",, "ADVERTENCIA")
            End If

            If CMBMARCA.SelectedIndex > -1 Then
                marca(indice) = CMBMARCA.Text
            Else
                MsgBox("Seleccione una marca",, "ADVERTENCIA")
            End If


            'Pago parcial
            parcial = Val(TXTDIAS.Text) * precioo()

            'Descuento y recargo 
            If CHKEFECTIVO.Checked Or CHKTARJETA.Checked Then
                If CHKEFECTIVO.Checked And Val(TXTEFECTIVO.Text) = 100 Then
                    descuentoo = parcial * 0.05
                Else
                    descuentoo = 0
                End If

                If CHKTARJETA.Checked And Val(TXTTARJETA.Text) = 100 Then
                    recargoo = parcial * 0.025
                Else
                    recargoo = 0
                End If
            End If


            If (CHKEFECTIVO.Checked And CHKTARJETA.Checked) Then
                If (Val(TXTEFECTIVO.Text) + Val(TXTTARJETA.Text)) = 100 Then
                    descuentoo = 0
                    recargoo = 0
                Else
                    MsgBox("Los porcentajes de pago deben sumar 100% ",, "ADVERTENCIA")
                End If
            End If



            'Total
            totalapagar = parcial - descuentoo + recargoo

            'Mostrar datos 
            nit(indice) = Val(TXTNIT.Text)
            placa(indice) = Val(TXTNUMPLACA.Text)
            marca(indice) = CMBMARCA.Text
            dias(indice) = Val(TXTDIAS.Text)
            pagoparcial(indice) = "Q" & System.Math.Round(parcial, 2)
            Descuento(indice) = "Q" & descuentoo
            recargo(indice) = "Q" & recargoo
            total(indice) = "Q" & System.Math.Round(totalapagar, 2)

            mostrar_vectores()

            indice = indice + 1
        End If
        If (indice = 6) Then
            MsgBox("NO SE ACEPTAN MÁS DE 6 ingresos",, "ADVERTENCIA")
        End If
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            'Limpiar entradas unicamente por si se desea seguir ingresando datos 
            limpiar_entradas()
        End If
    End Sub
End Class
