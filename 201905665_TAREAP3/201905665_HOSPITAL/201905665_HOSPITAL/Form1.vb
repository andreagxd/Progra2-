Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        For indice As Integer = 0 To 5
            If (hospi(indice, 0) <> Nothing) Then
                If (hospi(indice, 0) = TXTNIT.Text) Then
                    MsgBox("Ya existe ese NIT registrado")
                    Exit Sub
                End If
            End If
        Next


        If (indice < 6) Then
            'Verificaciones 
            If TXTNIT.Text <> "" Then
                hospi(indice, 0) = Val(TXTNIT.Text)
            Else
                MsgBox("Debe ingresar el NIT del paciente",, "ADVERTENCIA")
            End If

            If TXTNOMBRE.Text <> "" Then
                hospi(indice, 1) = TXTNOMBRE.Text
            Else
                MsgBox("Debe ingresar el nombre del paciente",, "ADVERTENCIA")
            End If

            If TXTDIAS.Text <> "" Then
                hospi(indice, 2) = Val(TXTDIAS.Text)
            Else
                MsgBox("Debe ingresar el número de días",, "ADVERTENCIA")
            End If

            If TXTHONORARIOS.Text <> "" Then
                hospi(indice, 3) = Val(TXTHONORARIOS.Text)
            Else
                MsgBox("Debe ingresar el monto de los honorarios",, "ADVERTENCIA")
            End If

            If CMBHABITACION.SelectedIndex > -1 Then
                hospi(indice, 4) = CMBHABITACION.Text
            Else
                MsgBox("Debe seleccionar una habitación",, "ADVERTENCIA")
            End If

            If CMBPAGO.SelectedIndex > -1 Then
                hospi(indice, 5) = CMBPAGO.Text
            Else
                MsgBox("Debe seleccionar un método de pago",, "ADVERTENCIA")
            End If

            Select Case CMBHABITACION.Text
                Case "Privada"
                    hospi(indice, 6) = Str(Val(hospi(indice, 2)) * 350)
                Case "Semiprivada"
                    hospi(indice, 6) = Str(Val(hospi(indice, 2)) * 250)
                Case "No privada"
                    hospi(indice, 6) = Str(Val(hospi(indice, 2)) * 150)
            End Select

            'Descuentos
            Select Case CMBPAGO.Text
                Case "Efectivo"
                    hospi(indice, 7) = Str(Val(hospi(indice, 6) * 0.1))
                Case "Depósito bancario"
                    hospi(indice, 7) = Str(Val(hospi(indice, 6) * 0.1))
                Case "Transferencia ACH"
                    hospi(indice, 7) = Str(Val(hospi(indice, 6) * 0.08))
                Case Else
                    hospi(indice, 7) = "0"
            End Select

            'Recargo
            Select Case CMBPAGO.Text
                Case "Tarjeta de crédito"
                    hospi(indice, 8) = Str(Val(hospi(indice, 6) * 0.015))
                Case Else
                    hospi(indice, 8) = "0"
            End Select

            'Total
            hospi(indice, 9) = Str(Val(hospi(indice, 6)) - hospi(indice, 7) + hospi(indice, 8))

            indice = indice + 1
        End If

        If (indice = 6) Then
            MsgBox("Matriz llena")
        End If
        limpiar_entradas()


    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar_matriz()
    End Sub
    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXTCONSULTA.Text = "" Then
            MsgBox("No ingresó ningun numero de NIT")
        End If

        Dim encontro = False

        For indice As Integer = 0 To 5
            If (hospi(indice, 0) <> Nothing) Then
                If (hospi(indice, 0) = TXTCONSULTA.Text) Then
                    TXTNIT.Text = hospi(indice, 0)
                    TXTNOMBRE.Text = hospi(indice, 1)
                    TXTDIAS.Text = hospi(indice, 2)
                    TXTHONORARIOS.Text = hospi(indice, 3)
                    CMBHABITACION.Text = hospi(indice, 4)
                    CMBPAGO.Text = hospi(indice, 5)
                    encontro = True
                End If
            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el paciente")
        ElseIf encontro = True Then
            MsgBox("Se encontró el paciente")
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        Dim e1 As Integer = 0
        Dim e2 As Integer = 0
        Dim e3 As Integer = 0
        Dim I As Byte

        I = 0
        While (I <= 6)
            If (hospi(I, 0) <> Nothing) Then
                If (hospi(I, 4) = "Privada") Then
                    e1 = e1 + 1
                End If

                If (hospi(I, 5) = "Transferencia ACH") Then
                    e2 = e2 + Val(hospi(I, 9))
                End If

                If (hospi(I, 4) = "No privada") Then
                    e3 = e3 + Val(hospi(I, 2))
                End If
                I = I + 1
            Else
                Exit While
            End If
        End While

        'mostrar los resultados 
        TXTE1.Text = Str(e1)
        TXTE2.Text = Str(e2)
        TXTE3.Text = Str(e3)
    End Sub

    Private Sub LIMPIARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADÍSTICASToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub
End Class
