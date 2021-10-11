Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (indice < 7) Then
            'Verificaciones 
            If TXTEDAD.Text <> "" Then
                edad(indice) = Val(TXTEDAD.Text)
            Else
                MsgBox("Debe ingresar una edad",, "ADVERTENCIA")
            End If

            If CMBGENERO.SelectedIndex > -1 Then
                genero(indice) = CMBGENERO.Text
            Else
                MsgBox("Debe seleccionar un género",, "ADVERTENCIA")
            End If

            If CMBREGISTRO.SelectedIndex > -1 Then
                codigo(indice) = CMBREGISTRO.Text
            Else
                MsgBox("Debe seleccionar un código de registro. Seleccione 0 si es extranjero o seleccione 1 si es guatemalteco",, "ADVERTENCIA")
            End If

            If TXTMONTO.Text <> "" Then
                monto(indice) = Val(TXTMONTO.Text)
            Else
                MsgBox("Debe ingresar el monto por daños ocasionados",, "ADVERTENCIA")
            End If

            If CMBTALLER.SelectedIndex > -1 Then
                taller(indice) = CMBTALLER.Text
            Else
                MsgBox("Debe seleccionar un taller",, "ADVERTENCIA")
            End If


            'Calculo de deducible 
            deducible(indice) = monto(indice) * 0.06

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

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        estadisticas()
        total_monto()
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
