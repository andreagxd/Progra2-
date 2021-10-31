Module Module1
    'Vectores
    Public indice As Byte = 0
    Public etapa(11) As Integer
    Public equipo(11) As String
    Public km(11) As Double
    Public tiempo(11) As Double
    Public nacionalidad(11) As String
    Public penalización(11) As Double
    Public bono(11) As Double
    Public I As Integer

    Sub mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()


        For I = 0 To 11

            If (etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((etapa(I)), equipo(I), km(I), tiempo(I), nacionalidad(I), penalización(I), bono(I))
            Else

                Exit For
            End If
        Next I

    End Sub

    Sub limpiar_entradas()
        Form1.TXTETAPA.Clear()
        Form1.CMBEQUIPO.Text = ""
        Form1.TXTKM.Clear()
        Form1.TXTTIEMPO.Text = ""
        Form1.RDBGUA.Checked = 0
        Form1.RDBEXT.Checked = 0
        Form1.TXTCONSULTA.Clear()
    End Sub

    Sub limpiar_vectores()

        For I = 0 To 11
            etapa(I) = Nothing
            equipo(I) = Nothing
            km(I) = Nothing
            tiempo(I) = Nothing
            nacionalidad(I) = Nothing
            penalización(I) = Nothing
            bono(I) = Nothing
        Next I

        Form1.DataGridView1.Rows.Clear()
        indice = 0

    End Sub

    Sub limpiar_estadisticas()
        Form1.TXTE1.Clear()
        Form1.TXTE2.Clear()
        Form1.TXTE3.Clear()
        Form1.TXTE4.Clear()
        Form1.TXTE5.Clear()
        Form1.TXTE6.Clear()
        Form1.TXTE7.Clear()
        Form1.TXTE8.Clear()
        Form1.TXTE9.Clear()
    End Sub
End Module
