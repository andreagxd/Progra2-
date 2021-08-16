Module Module1
    Public total_a_depositar As Double
    Public saldo_anterior As Double
    Public saldo_nuevo As Double
    Public Interes As Double
    Public saldo_nuevo1 As Double
    Public Intereses As Double


    Sub limpiar()
        Form1.TXT_CHEQUESPROPIOS.Clear()
        Form1.TXT_CHEQUESOTROSBANCOS.Clear()
        Form1.TXT_EFECTIVO.Clear()
        Form1.TXT_SALDOANTERIOR.Clear()
        Form1.TXT_TOTALADEPOSITAR.Clear()
        Form1.TXT_SALDONUEVO.Clear()
        Form1.TXT_INTERES.Clear()
        Form1.RDB_AHORRO.Checked = 0
        Form1.RDB_MONETARIO.Checked = 0
        Form1.RDB_MONETARIOPREMIER.Checked = 0
        Form1.CHK_CHEQUESOTROSBANCOS.Checked = 0
        Form1.CHK_CHEQUESPROPIOS.Checked = 0
        Form1.CHK_EFECTIVO.Checked = 0

    End Sub
End Module

