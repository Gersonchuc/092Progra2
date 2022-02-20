Imports System.Math
Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        PASAJEROS = Val(TXTPASAJEROS.Text)
        If RBAVIONETA.Checked Then
            If CBSUR.Checked And CBIZABAL.Checked And CBPETEN.Checked Then
                SUBTOTAL = Val(ASUR * PASAJEROS + AIZABAL * PASAJEROS + APETEN * PASAJEROS)
                DESCUENTO = Val(SUBTOTAL * descuento2)
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBSUR.Checked Then
                SUBTOTAL = Val(ASUR * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBIZABAL.Checked Then
                SUBTOTAL = Val(AIZABAL * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBPETEN.Checked Then
                SUBTOTAL = Val(APETEN * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            End If
        End If
        If RBJET.Checked Then
            If CBIZABAL.Checked And CBPETEN.Checked Then
                SUBTOTAL = Val(JIZABAL * PASAJEROS + JPETEN * PASAJEROS)
                DESCUENTO = Val(SUBTOTAL * descuento1)
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBSUR.Checked Then
                SUBTOTAL = Val(JSUR * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBIZABAL.Checked Then
                SUBTOTAL = Val(JIZABAL * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBPETEN.Checked Then
                SUBTOTAL = Val(JPETEN * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            End If

        End If
        If RBHELICOPTERO.Checked Then
            If CBSUR.Checked Then
                SUBTOTAL = Val(HSUR * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBIZABAL.Checked Then
                SUBTOTAL = Val(HIZABAL * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            ElseIf CBPETEN.Checked Then
                SUBTOTAL = Val(HPETEN * PASAJEROS)
                DESCUENTO = 0
                TOTAL = Round(Val(SUBTOTAL - DESCUENTO), 2)
                LDESCUENTO.Text = Str(DESCUENTO)
                LSUBTOTAL.Text = Str(SUBTOTAL)
                LTOTAL.Text = Str(TOTAL)
            End If
        End If

    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
