Module Module1
    'Precio de los materiales 
    Public Const PrecioLino As Double = 15
    Public Const Precioalgodon As Double = 23.99
    Public Const Precioseda As Double = 30.99
    Public Const Preciohilocrudo As Double = 39.99
    ' Costo de la mano de obra 
    Public Const costoimperial As Double = 65.5
    Public Const costomatrimonial As Double = 85.99
    Public Const costoqueen As Double = 99.99
    Public Const costoking As Double = 105.99
    'Variables de operación 
    Public manodeobra As Double
    Public yardasaemplear As Double
    Public preciodeventa As Double
    Public preciodecosto As Double
    'Total de material 
    Public Totallino As Double
    Public Totalalgodon As Double
    Public Totalseda As Double
    Public Totalhilocrudo As Double
    Public Totalmateriales As Double
    'Verificacion de datos 
    Public verificacion1 As Double
    Public verificacion2 As Double
    Public verificacion3 As Double
    Public verificacion4 As Double


    Sub limpiar()
        Form1.TXTALGODON.Clear()
        Form1.TXTHILOCRUDO.Clear()
        Form1.TXTLINO.Clear()
        Form1.TXTPRECIODECOSTO.Clear()
        Form1.TXTPRECIODEVENTA.Clear()
        Form1.TXTSEDA.Clear()
        Form1.TXTTOTALALGODON.Clear()
        Form1.TXTTOTALDEMATERIAL.Clear()
        Form1.TXTTOTALHILOCRUDO.Clear()
        Form1.TXTTOTALLINO.Clear()
        Form1.TXTTOTALSEDA.Clear()
        Form1.RDBIMPERIAL.Checked = 0
        Form1.RDBKING.Checked = 0
        Form1.RDBMATRIMONIAL.Checked = 0
        Form1.RDBQUEEN.Checked = 0
        Form1.CHKALGODON.Checked = 0
        Form1.CHKHILOCRUDO.Checked = 0
        Form1.CHKLINO.Checked = 0
        Form1.CHKSEDA.Checked = 0

    End Sub
End Module
