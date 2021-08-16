Public Class Form1
    Private Sub CHK_CHEQUESPROPIOS_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_CHEQUESPROPIOS.CheckedChanged
        If (CHK_CHEQUESPROPIOS.Checked) Then
            TXT_CHEQUESPROPIOS.Visible = True
        Else
            TXT_CHEQUESPROPIOS.Clear()
            TXT_CHEQUESPROPIOS.Visible = False
        End If
    End Sub

    Private Sub CHK_CHEQUESOTROSBANCOS_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_CHEQUESOTROSBANCOS.CheckedChanged
        If (CHK_CHEQUESOTROSBANCOS.Checked) Then
            TXT_CHEQUESOTROSBANCOS.Visible = True
        Else
            TXT_CHEQUESOTROSBANCOS.Clear()
            TXT_CHEQUESOTROSBANCOS.Visible = False
        End If
    End Sub

    Private Sub CHK_EFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_EFECTIVO.CheckedChanged
        If (CHK_EFECTIVO.Checked) Then
            TXT_EFECTIVO.Visible = True
        Else
            TXT_EFECTIVO.Clear()
            TXT_EFECTIVO.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click
        total_a_depositar = Val(TXT_EFECTIVO.Text) + Val(TXT_CHEQUESOTROSBANCOS.Text) + Val(TXT_CHEQUESPROPIOS.Text)
        'Mostrar resultados 
        TXT_TOTALADEPOSITAR.Text += "Q." & Str(total_a_depositar) + Val(TXT_SALDOANTERIOR.Text)

        'Saldo Nuevo 
        saldo_nuevo = total_a_depositar + Val(TXT_SALDOANTERIOR.Text)


        If (RDB_AHORRO.Checked) Or (RDB_MONETARIO.Checked) Or (RDB_MONETARIOPREMIER.Checked) Then
            'Select Case 
            If (RDB_AHORRO.Checked) Then

                Select Case saldo_nuevo
                    Case 1.01 To 1000.99
                        Interes = 1.5 / 100
                    Case 1001 To 5000.99
                        Interes = 2.5 / 100
                    Case 5001 To 15000.99
                        Interes = 7.5 / 100
                    Case Is >= 15001
                        Interes = 10 / 100
                End Select
            End If

            If (RDB_MONETARIOPREMIER.Checked) Then

                Select Case Val(TXT_SALDOANTERIOR.Text)
                    Case 1.01 To 10000.99
                        Interes = 2.5 / 100
                    Case 10001 To 15000.99
                        Interes = 3 / 100
                    Case Is >= 15001
                        Interes = 4.5 / 100
                End Select
            End If

            If (RDB_MONETARIO.Checked) Then
                Interes = 0
            End If
        Else
            'en esta cláusula del else se indica que no se seleccionó ninguna forma de pago
            MsgBox("ERROR, NO SELECCIONO FORMA DE DEPOSITO")
        End If

        If RDB_AHORRO.Checked Then
            Intereses = saldo_nuevo * Interes
        ElseIf RDB_MONETARIOPREMIER.Checked Then
            Intereses = Val(TXT_SALDOANTERIOR.Text) * Interes
        Else
            Intereses = 0
        End If

        'Mostrar Intereses 
        TXT_INTERES.Text = Intereses

        'Saldo Nuevo 1 
        saldo_nuevo1 = saldo_nuevo + Intereses
        TXT_SALDONUEVO.Text += "Q." & Str(saldo_nuevo1)

    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        limpiar()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar()
        End If
    End Sub
End Class
