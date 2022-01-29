Imports System.Math
Public Class Form1
    Private Sub Calculos_Click(sender As Object, e As EventArgs) Handles Calculos.Click
        Dim PARCIAL As Double
        Dim DESCUENTO1 As Double

        Dim TOTAL As Double
        Dim ARROZ As Double
        Dim AZUCAR As Double
        Dim FRIJOL As Double
        Dim IVAA As Double

        Dim arz = 2.0
        Dim azcr = 2.5
        Dim frj = 1.75

        ARROZ = Val(TxtArroz.Text)
        FRIJOL = Val(TxtFrijol.Text)
        AZUCAR = Val(TxtAzucar.Text)

        PARCIAL = (ARROZ * arz) + (AZUCAR * azcr) + (FRIJOL * frj)

        IVAA = PARCIAL * (12 / 100)

        DESCUENTO1 = PARCIAL * (2.5 / 100)

        TOTAL = (PARCIAL + IVAA) - (DESCUENTO1)

        TxtParcial.Text = Str(Round(PARCIAL, 2))
        TxtIva.Text = Str(Round(IVAA, 2))
        TxtDesc1.Text = Str(Round(PARCIAL + IVAA, 2))
        TXtDesc2.Text = Str(Round(DESCUENTO1, 2))
        TxtPagoTotal.Text = Str(Round(TOTAL, 2))
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TxtArroz.Clear()
        TxtFrijol.Clear()
        TxtAzucar.Clear()
        TxtParcial.Clear()
        TxtIva.Clear()
        TxtDesc1.Clear()
        TXtDesc2.Clear()
        TxtPagoTotal.Clear()
        TxtArroz.Focus()
    End Sub

    Private Sub Out_Click(sender As Object, e As EventArgs) Handles out.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA")) = vbYes Then
            End
        Else
            TxtArroz.Clear()
            TxtFrijol.Clear()
            TxtAzucar.Clear()
            TxtParcial.Clear()
            TxtIva.Clear()
            TxtDesc1.Clear()
            TXtDesc2.Clear()
            TxtPagoTotal.Clear()
            TxtArroz.Focus()
        End If
    End Sub
End Class
