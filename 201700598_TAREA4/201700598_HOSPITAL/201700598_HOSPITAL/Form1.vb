Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub LVECTORESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LVECTORESToolStripMenuItem1.Click
        limpiar_vectores()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub LST_DIAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_DIAS.SelectedIndexChanged

    End Sub

    Private Sub LIMPIARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem1.Click
        limpiar_entradas()

    End Sub

    Private Sub AGREGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem1.Click
        If (indice < 6) Then
            HABITACION(indice) = CBHABITACION.Text
            SERVICIO(indice) = CBSERVICIO.Text
            PAGO(indice) = CBPAGO.Text
            If (TXTDIAS.Text <> "") Then
                dias(indice) = Val(TXTDIAS.Text)
            Else
                MsgBox("Error, no ingresó cant. de dias")
                TXTDIAS.Focus() : Exit Sub
            End If

            Select Case (CBHABITACION.SelectedIndex)
                Case 0
                    Select Case (CBSERVICIO.SelectedIndex)
                        Case 0 : Subtotal(indice) = dias(indice) * 350
                        Case 1 : Subtotal(indice) = dias(indice) * 550
                        Case 2 : Subtotal(indice) = dias(indice) * 450
                    End Select
                Case 1
                    Select Case (CBSERVICIO.SelectedIndex)
                        Case 0 : Subtotal(indice) = dias(indice) * 250
                        Case 1 : Subtotal(indice) = dias(indice) * 400
                        Case 2 : Subtotal(indice) = dias(indice) * 350
                    End Select
                Case 2
                    Select Case (CBSERVICIO.SelectedIndex)
                        Case 0 : Subtotal(indice) = dias(indice) * 150
                        Case 1 : Subtotal(indice) = dias(indice) * 300
                        Case 2 : Subtotal(indice) = dias(indice) * 250
                    End Select
                Case Else
                    MsgBox("Error, no seleccionó tipo de servicio")
                    CBSERVICIO.Focus() : Exit Sub
            End Select
            If (CBPAGO.SelectedIndex = 0 Or CBPAGO.SelectedIndex = 1) Then
                Descuento(indice) = Round(Val(Subtotal(indice) * 0.15), 2)
            ElseIf CBPAGO.SelectedIndex = 3 Then
                Descuento(indice) = Round(Val(Subtotal(indice) * 0.08), 2)
            ElseIf CBPAGO.SelectedIndex = 2 Then
                Recargo(indice) = Round(Val(Subtotal(indice) * 0.05), 2)
            End If

            PagoTotal(indice) = Val(Subtotal(indice)) - Val(Descuento(indice)) + Val(Recargo(indice))
            mostrar()

            indice = indice + 1
        End If
        If (indice = 6) Then
            MsgBox("Vectores llenos")
        End If
    End Sub
End Class
