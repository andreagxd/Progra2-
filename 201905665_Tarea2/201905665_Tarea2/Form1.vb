Public Class Form1

    'Constantes
    Const precioarroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioazucar As Double = 2.5

    'Variables 
    Dim totalsiniva As Double
    Dim IVA As Double
    Dim pagoparcial As Double
    Dim descuento1 As Double
    Dim descuento2 As Double
    Dim pagototal As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalsiniva = Val(txtlbarroz.Text) * precioarroz + Val(txtlbfrijol.Text) * preciofrijol + Val(txtlbazucar.Text) * precioazucar
        IVA = totalsiniva * 0.12
        pagoparcial = Val(totalsiniva) + Val(IVA)
        pagototal = Val(pagoparcial) - descuento1 - descuento2

        'lectura de datos 
        txtsiniva.Text += "Q" & Str(System.Math.Round(totalsiniva, 2))
        txtiva.Text += "Q" & Str(System.Math.Round(IVA, 2))
        txtpagoparcial.Text += "Q" & Str(System.Math.Round(pagoparcial, 2))
        txttotalapagar.Text += "Q" & Str(System.Math.Round(pagototal, 2))

        'Descuento  1
        If pagoparcial > 15.0 Then
            descuento1 = (2.5 * pagoparcial) / 100
        End If

        'Descuento 2
        If Val(txtlbfrijol.Text) > 5 Then
            descuento2 = (3 * pagoparcial) / 100
        End If

        txtdescuento1.Text += "Q" & Str(System.Math.Round(descuento1, 2))
        txtdescuento2.Text += "Q" & Str(System.Math.Round(descuento2, 2))

        'MsgBox Total de la factura 
        MsgBox("El total de su factura es de Q." + Str(System.Math.Round(pagototal, 2)))



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtlbarroz.Clear()
        txtlbfrijol.Clear()
        txtlbazucar.Clear()
        txtsiniva.Clear()
        txtiva.Clear()
        txtpagoparcial.Clear()
        txtdescuento1.Clear()
        txtdescuento2.Clear()
        txttotalapagar.Clear()

        txtlbarroz.Focus()

    End Sub
    Sub limpiar()
        txtlbarroz.Clear()
        txtlbfrijol.Clear()
        txtlbazucar.Clear()
        txtsiniva.Clear()
        txtiva.Clear()
        txtpagoparcial.Clear()
        txtdescuento1.Clear()
        txtdescuento2.Clear()
        txttotalapagar.Clear()

        txtlbarroz.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿DESEA SALIR DEL PROGRAMA?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar()
        End If
    End Sub
End Class

