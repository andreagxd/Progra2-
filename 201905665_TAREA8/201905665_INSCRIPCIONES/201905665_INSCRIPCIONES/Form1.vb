Public Class Form1
    Private Sub RDBDIVER_CheckedChanged(sender As Object, e As EventArgs) Handles RDBDIVER.CheckedChanged
        If (RDBDIVER.Checked) Then
            CMBDIVER.Visible = True
        Else
            CMBDIVER.Text = ""
            CMBDIVER.Visible = False
        End If
    End Sub
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (indice < 7) Then
            'Verificaciones 
            If TXTNOMBRE.Text <> "" Then
                colegio(indice, 0) = TXTNOMBRE.Text
            Else
                MsgBox("Debe ingresar el nombre del alumno",, "ADVERTENCIA")
            End If

            If TXTCARNET.Text <> "" Then
                colegio(indice, 1) = Val(TXTCARNET.Text)
            Else
                MsgBox("Debe ingresar el carnet del alumno",, "ADVERTENCIA")
            End If

            'verificación de que se haya seleccionado una nivel 
            If (RDBBASICOS.Checked) Or (RDBDIVER.Checked) Then
                If (RDBBASICOS.Checked) Then
                    colegio(indice, 2) = RDBBASICOS.Text
                    colegio(indice, 5) = Str(inscripcion_basicos + mensual_basicos)
                End If

                If (RDBDIVER.Checked) Then
                    colegio(indice, 2) = RDBDIVER.Text
                    colegio(indice, 3) = CMBDIVER.SelectedItem
                    colegio(indice, 5) = Str(inscripcion_diversificado + mensual_diversificado)
                End If

            Else
                MsgBox("Debe seleccionar el nivel de estudio del alumno")
            End If

            'se almacena forma de pago 
            If CMBPAGO.SelectedIndex > -1 Then
                colegio(indice, 4) = CMBPAGO.Text
            Else
                MsgBox("Debe seleccionar un método de pago",, "ADVERTENCIA")
            End If

            If CMBPAGO.Text = "Tarjeta de crédito" Then
                colegio(indice, 6) = Str((Val(colegio(indice, 5) * 0.1)) + Val(colegio(indice, 5)))
            Else
                colegio(indice, 6) = Str(colegio(indice, 5))
            End If
            indice = indice + 1
        End If

        If (indice = 7) Then
            MsgBox("Matriz llena")
        End If
        limpiar_entradas()
    End Sub

    Private Sub MOSTRARDATOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARDATOSToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub CALCULARTOTALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARTOTALESToolStripMenuItem.Click
        totales()
    End Sub

    Private Sub LIMPIARTOTALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTOTALESToolStripMenuItem.Click
        limpiar_totales()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

End Class
