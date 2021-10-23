Module Module1
    'Matriz
    Public indice As Byte = 0
    Public hospi(6, 10) As String
    Sub mostrar_matriz()
        Dim I As Byte
        Form1.DataGridView1.Rows.Clear()

        I = 0
        While (I <= 5)
            If (hospi(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(hospi(I, 0), hospi(I, 1), hospi(I, 2), hospi(I, 3), hospi(I, 4), hospi(I, 5), hospi(I, 6), hospi(I, 7), hospi(I, 8), hospi(I, 9))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub

    Sub limpiar_entradas()
        Form1.TXTNIT.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTDIAS.Clear()
        Form1.TXTHONORARIOS.Clear()
        Form1.CMBHABITACION.Text = ""
        Form1.CMBPAGO.Text = ""
        Form1.TXTCONSULTA.Clear()
    End Sub

    Sub limpiar()
        Dim I As Byte

        Form1.DataGridView1.Rows.Clear()
        indice = 0

        I = 0

        While (I <= 4)
            hospi(I, 0) = Nothing
            hospi(I, 1) = Nothing
            hospi(I, 2) = Nothing
            hospi(I, 3) = Nothing
            hospi(I, 4) = Nothing
            hospi(I, 5) = Nothing
            hospi(I, 6) = Nothing
            hospi(I, 7) = Nothing
            hospi(I, 8) = Nothing
            hospi(I, 9) = Nothing

            I = I + 1
        End While
    End Sub
    Sub limpiar_estadisticas()
        Form1.TXTE1.Clear()
        Form1.TXTE2.Clear()
        Form1.TXTE3.Clear()
    End Sub
End Module
