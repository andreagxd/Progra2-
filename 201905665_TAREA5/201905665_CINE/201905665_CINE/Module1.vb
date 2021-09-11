Module Module1
    'Vectores
    Public indice As Byte = 0
    Public cine(8) As String
    Public funcion(8) As String
    Public numeroe(8) As Integer
    Public subtotal(8) As Double
    Public Descuento1(8) As Double
    Public Descuento2(8) As Double
    Public total(8) As Double

    'Verificacion
    Public ver1 As Integer

    'Variables 
    Public tarifa As Integer
    Public subtotal_1 As Double
    Public descuento As Double
    Public descuentoo As Double
    Public descuento_1 As Double
    Public descuento_2 As Double
    Public total_1 As Double
    Public entradas As Double
    Public Function entradas_1(ByVal entrada As Double, ByVal tarifa As Double) As Double
        entradas_1 = (entrada * tarifa)
        Return entradas_1
    End Function
    Public Function desc1(ByVal subtotal As Double, ByVal descuentoo As Double) As Double
        desc1 = subtotal * descuentoo
    End Function
    Public Function desc2(ByVal subtotal As Double, ByVal descuento As Double) As Double
        desc2 = subtotal * descuento
    End Function

    Sub mostrar_vectores()
        Form1.LST1.Items.Add(cine(indice))
        Form1.LST2.Items.Add(funcion(indice))
        Form1.LST3.Items.Add(numeroe(indice))
        Form1.LST4.Items.Add(subtotal(indice))
        Form1.LST5.Items.Add(Descuento1(indice))
        Form1.LST6.Items.Add(Descuento2(indice))
        Form1.LST7.Items.Add(total(indice))
    End Sub
    Sub limpiar_entradas()
        Form1.TXTENTRADAS.Clear()
        Form1.CMBCINE.Text = ""
        Form1.CMBFUNCION.Text = ""
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
