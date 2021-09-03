Module Module1
    Public ver1 As Double
    Public ver2 As Double
    Public ver3 As Double
    Public ver4 As Double

    Public indice As Byte = 0
    Public tipo_de_servicio(11) As String
    Public tipo_de_tarifa(11) As String
    Public saldo_anterior(11) As Double
    Public pago_inicial1(11) As Double
    Public mora1(11) As Double
    Public descuento1(11) As Double
    Public pago_total1(11) As Double
    Public nombre(11) As String
    Public nit(11) As Integer

    Public tarifa As Double
    Public tarifa1 As Double
    Public tarifa_residencial As Double
    Public tarifa_industrial As Double
    Public pago_inicial As Double
    Public descuento As Double
    Public mora As Double
    Public pagototal As Double
    Sub mostrar_vectores()
        Form1.LST1.Items.Add(nombre(indice))
        Form1.LST2.Items.Add(nit(indice))
        Form1.LST3.Items.Add(tipo_de_servicio(indice))
        Form1.LST4.Items.Add(tipo_de_tarifa(indice))
        Form1.LST5.Items.Add(saldo_anterior(indice))
        Form1.LST6.Items.Add(pago_inicial1(indice))
        Form1.LST7.Items.Add(mora1(indice))
        Form1.LST8.Items.Add(descuento1(indice))
        Form1.LST9.Items.Add(pago_total1(indice))
    End Sub

    Sub limpiar_entradas()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTSALDOANTERIOR.Clear()
        Form1.TXTCONSUMOMENSUAL.Clear()
        Form1.CMBSERVICIO.Text = ""
        Form1.CMBTARIFA.Text = ""
    End Sub

    Sub limpiar_listas()
        Form1.LST1.Items.Clear()
        Form1.LST2.Items.Clear()
        Form1.LST3.Items.Clear()
        Form1.LST4.Items.Clear()
        Form1.LST5.Items.Clear()
        Form1.LST6.Items.Clear()
        Form1.LST7.Items.Clear()
        Form1.LST8.Items.Clear()
        Form1.LST9.Items.Clear()

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
        Form1.LST8.Items.Clear()
        Form1.LST9.Items.Clear()
    End Sub
End Module
