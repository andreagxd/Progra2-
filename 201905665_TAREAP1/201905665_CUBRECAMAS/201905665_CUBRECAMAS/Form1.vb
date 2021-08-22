Public Class Form1
    Private Sub CHKLINO_CheckedChanged(sender As Object, e As EventArgs) Handles CHKLINO.CheckedChanged
        If (CHKLINO.Checked) Then
            TXTLINO.Visible = True
            TXTLINO.Focus()
        Else
            TXTLINO.Clear()
            TXTLINO.Visible = False
        End If
    End Sub

    Private Sub CHKALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles CHKALGODON.CheckedChanged
        If (CHKALGODON.Checked) Then
            TXTALGODON.Visible = True
            TXTALGODON.Focus()
        Else
            TXTALGODON.Clear()
            TXTALGODON.Visible = False
        End If
    End Sub

    Private Sub CHKSEDA_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSEDA.CheckedChanged
        If (CHKSEDA.Checked) Then
            TXTSEDA.Visible = True
            TXTSEDA.Focus()
        Else
            TXTSEDA.Clear()
            TXTSEDA.Visible = False
        End If
    End Sub

    Private Sub CHKHILOCRUDO_CheckedChanged(sender As Object, e As EventArgs) Handles CHKHILOCRUDO.CheckedChanged
        If (CHKHILOCRUDO.Checked) Then
            TXTHILOCRUDO.Visible = True
            TXTHILOCRUDO.Focus()
        Else
            TXTHILOCRUDO.Clear()
            TXTHILOCRUDO.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        yardasaemplear = Val(TXTALGODON.Text) + Val(TXTHILOCRUDO.Text) + Val(TXTLINO.Text) + Val(TXTSEDA.Text)

        If (CHKLINO.Checked) Or (CHKALGODON.Checked) Or (CHKSEDA.Checked) Or (CHKHILOCRUDO.Checked) Then
            If (CHKLINO.Checked) Then
                If (IsNumeric(TXTLINO.Text)) And Val((TXTLINO.Text) > 0) Then
                    verificacion1 = Val(TXTLINO.Text)
                Else
                    MsgBox("Dato ingresado no válido",, "Advertencia")
                    TXTLINO.Focus()
                    Exit Sub
                End If
            End If

            If (CHKALGODON.Checked) Then
                If (IsNumeric(TXTALGODON.Text)) And Val((TXTALGODON.Text) > 0) Then
                    verificacion2 = Val(TXTALGODON.Text)
                Else
                    MsgBox("Dato ingresado no válido",, "Advertencia")
                    TXTALGODON.Focus()
                    Exit Sub
                End If
            End If

            If (CHKSEDA.Checked) Then
                If (IsNumeric(TXTSEDA.Text)) And Val((TXTSEDA.Text) > 0) Then
                    verificacion3 = Val(TXTSEDA.Text)
                Else
                    MsgBox("Dato ingresado no válido",, "Advertencia")
                    TXTSEDA.Focus()
                    Exit Sub
                End If
            End If

            If (CHKHILOCRUDO.Checked) Then
                If (IsNumeric(TXTHILOCRUDO.Text)) And Val((TXTHILOCRUDO.Text) > 0) Then
                    verificacion4 = Val(TXTHILOCRUDO.Text)
                Else
                    MsgBox("Dato ingresado no válido",, "Advertencia")
                    TXTHILOCRUDO.Focus()
                    Exit Sub
                End If
            End If

        Else
            MsgBox("No seleccinó material")

        End If


        'Precio de MO 
        If (RDBIMPERIAL.Checked) Or (RDBKING.Checked) Or (RDBMATRIMONIAL.Checked) Or (RDBQUEEN.Checked) Then
            If (RDBIMPERIAL.Checked) Then
                manodeobra = costoimperial
            End If
            If (RDBMATRIMONIAL.Checked) Then
                manodeobra = costomatrimonial
            End If
            If (RDBQUEEN.Checked) Then
                manodeobra = costoqueen
            End If
            If (RDBKING.Checked) Then
                manodeobra = costoking
            End If
        End If

        'Costo 
        If (RDBIMPERIAL.Checked) Or (RDBKING.Checked) Or (RDBMATRIMONIAL.Checked) Or (RDBQUEEN.Checked) Then
            If (RDBIMPERIAL.Checked) Then
                If yardasaemplear = 3 Then
                    preciodecosto = Val(TXTALGODON.Text) * Precioalgodon + Val(TXTHILOCRUDO.Text) * Preciohilocrudo + Val(TXTLINO.Text) * PrecioLino + Val(TXTSEDA.Text) * Precioseda + manodeobra
                Else
                    MsgBox("La cantidad de yardas a seleccionar debe ser igual a 3",, "Advertencia")
                End If


            ElseIf (RDBMATRIMONIAL.Checked) Then
                If yardasaemplear = 5 Then
                    preciodecosto = Val(TXTALGODON.Text) * Precioalgodon + Val(TXTHILOCRUDO.Text) * Preciohilocrudo + Val(TXTLINO.Text) * PrecioLino + Val(TXTSEDA.Text) * Precioseda + manodeobra
                Else
                    MsgBox("La cantidad de yardas a seleccionar debe ser igual a 5",, "Advertencia")
                End If

            ElseIf (RDBQUEEN.Checked) Then
                If yardasaemplear = 6 Then
                    preciodecosto = Val(TXTALGODON.Text) * Precioalgodon + Val(TXTHILOCRUDO.Text) * Preciohilocrudo + Val(TXTLINO.Text) * PrecioLino + Val(TXTSEDA.Text) * Precioseda + manodeobra
                Else
                    MsgBox("La cantidad de yardas a seleccionar debe ser igual a 6",, "Advertencia")
                End If

            ElseIf (RDBKING.Checked) Then
                If yardasaemplear = 7 Then
                    preciodecosto = Val(TXTALGODON.Text) * Precioalgodon + Val(TXTHILOCRUDO.Text) * Preciohilocrudo + Val(TXTLINO.Text) * PrecioLino + Val(TXTSEDA.Text) * Precioseda + manodeobra
                Else
                    MsgBox("La cantidad de yardas a seleccionar debe ser igual a 7",, "Advertencia")
                End If
            End If
        Else
            MsgBox("No seleccionó el tamaño de la cubrecama",, "Advertencia")
        End If


        'Mostrar resultado 
        TXTPRECIODECOSTO.Text += "Q." & Str(System.Math.Round(preciodecosto, 2))

        'Precio de venta 
        preciodeventa = preciodecosto * (65 / 100) + preciodecosto
        'Mostrar precio de venta 
        TXTPRECIODEVENTA.Text += "Q." & Str(System.Math.Round(preciodeventa, 2))

        'Total por material 
        Totallino = Val(TXTLINO.Text) * PrecioLino
        Totalalgodon = Val(TXTALGODON.Text) * Precioalgodon
        Totalseda = Val(TXTSEDA.Text) * Precioseda
        Totalhilocrudo = Val(TXTTOTALHILOCRUDO.Text) * Preciohilocrudo


        TXTTOTALLINO.Text += "Q." & Str(System.Math.Round(Totallino, 2))
        TXTTOTALALGODON.Text += "Q." & Str(System.Math.Round(Totalalgodon, 2))
        TXTTOTALSEDA.Text += "Q." & Str(System.Math.Round(Totalseda, 2))
        TXTTOTALHILOCRUDO.Text += "Q." & Str(System.Math.Round(Totalhilocrudo, 2))

        'Total de materiales 
        Totalmateriales = Totallino + Totalalgodon + Totalseda + Totalhilocrudo
        TXTTOTALDEMATERIAL.Text += "Q." & Str(System.Math.Round(Totalmateriales, 2))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar()
        End If
    End Sub
End Class
