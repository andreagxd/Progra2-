Public Class Form1
    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If (indice < 7) Then
            'Verificaciones 
            If TXTDPI.Text <> "" Then
                dpi(indice) = Val(TXTDPI.Text)
            Else
                MsgBox("Debe ingresar el número de DPI",, "ADVERTENCIA")
                End If

                If TXTNOMBRE.Text <> "" Then
                    nombre(indice) = TXTNOMBRE.Text
                Else
                    MsgBox("Debe ingresar el nombre del cliente",, "ADVERTENCIA")
                End If

                If TXTVALOR.Text <> "" Then
                    valor(indice) = Val(TXTVALOR.Text)
                Else
                    MsgBox("Debe ingresar el valor del artículo vendido",, "ADVERTENCIA")
                End If

                If TXTCANTIDAD.Text <> "" Then
                    cantidad(indice) = Val(TXTCANTIDAD.Text)
                Else
                    MsgBox("Debe ingresar la cantidad de artículos vendidos",, "ADVERTENCIA")
                End If

            'Calculos 
            interes(indice) = ctasa(Val(TXTCANTIDAD.Text), Val(TXTVALOR.Text))
            final(indice) = Val(TXTVALOR.Text) + Val(interes(indice)) * Val(TXTCANTIDAD.Text)

            indice = indice + 1
            End If

            If (indice = 7) Then
            MsgBox("NO SE ACEPTAN MÁS DE 7 ingresos",, "ADVERTENCIA")
        End If
        limpiar_entradas()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar_vectores()
    End Sub

    Private Sub ORDENARDESCENDENTEMENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENDENTEMENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Double
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6
                If (dpi(j) <> Nothing) Then
                    If (dpi(i) < dpi(j)) Then
                        temp1 = dpi(i)
                        dpi(i) = dpi(j)
                        dpi(j) = temp1
                        temp2 = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp2
                        temp3 = valor(i)
                        valor(i) = valor(j)
                        valor(j) = temp3
                        temp4 = cantidad(i)
                        cantidad(i) = cantidad(j)
                        cantidad(j) = temp4
                        temp5 = interes(i)
                        interes(i) = interes(j)
                        interes(j) = temp5
                        temp6 = final(i)
                        final(i) = final(j)
                        final(j) = temp6
                    End If
                End If
            Next
        Next

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
            limpiar_entradas()
        End If
    End Sub
End Class
