Module Module1
    'Vectores 
    Public indice As Byte = 0
    Public nit(5) As String
    Public placa(5) As Double
    Public marca(5) As String
    Public dias(5) As Integer
    Public pagoparcial(5) As Double
    Public Descuento(5) As Double
    Public recargo(5) As Double
    Public total(5) As Double


    'Variables 
    Public precio As Double
    Public parcial As Double
    Public descuentoo As Double
    Public recargoo As Double
    Public totalapagar As Double

    Sub mostrar_vectores()
        Form1.LST1.Items.Add(nit(indice))
        Form1.LST2.Items.Add(placa(indice))
        Form1.LST3.Items.Add(marca(indice))
        Form1.LST4.Items.Add(dias(indice))
        Form1.LST5.Items.Add(pagoparcial(indice))
        Form1.LST6.Items.Add(Descuento(indice))
        Form1.LST7.Items.Add(total(indice))
    End Sub

    Sub limpiar_entradas()
        Form1.TXTNIT.Clear()
        Form1.TXTNUMPLACA.Clear()
        Form1.TXTDIAS.Clear()
        Form1.TXTEFECTIVO.Clear()
        Form1.TXTTARJETA.Clear()
        Form1.CMBMARCA.Text = ""
        Form1.CHKEFECTIVO.Checked = 0
        Form1.CHKTARJETA.Checked = 0
    End Sub
    Sub limpiar_listas()
        Form1.LST1.Items.Clear()
        Form1.LST2.Items.Clear()
        Form1.LST3.Items.Clear()
        Form1.LST4.Items.Clear()
        Form1.LST5.Items.Clear()
        Form1.LST6.Items.Clear()
        Form1.LST7.Items.Clear()
    End Sub
    Sub limpiar_vectores()
        indice = 0
        Form1.LST1.Items.Clear()
        Form1.LST2.Items.Clear()
        Form1.LST3.Items.Clear()
        Form1.LST4.Items.Clear()
        Form1.LST5.Items.Clear()
        Form1.LST6.Items.Clear()
        Form1.LST7.Items.Clear()
    End Sub
End Module
