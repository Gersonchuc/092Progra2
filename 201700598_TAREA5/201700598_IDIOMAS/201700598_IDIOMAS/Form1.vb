Public Class Form1
    Private Sub TXTCARNET_TextChanged(sender As Object, e As EventArgs) Handles TXTCARNET.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Salir()

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        limpiar_matriz()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Mostrar()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        carnet = TXTCARNET.Text
        nombre = TXTNOMBRE.Text
        horas = Val(InputBox("Ingrese cantidad horas a estudiar:"))
        inscripciones(fila, 0) = carnet
        inscripciones(fila, 1) = nombre
        inscripciones(fila, 4) = horas

        pago = 0

        If fila <= 7 Then

            inscripciones(fila, 2) = CBIDIOMA.Text

            If CBIDIOMA.SelectedIndex = 0 Then
                pago = Val(horas * ingles)
                inscripciones(fila, 6) = pago
            ElseIf CBIDIOMA.SelectedIndex = 1 Then
                pago = Val(horas * Portugues)
                inscripciones(fila, 6) = pago
            ElseIf CBIDIOMA.SelectedIndex = 2 Then
                pago = Val(horas * Frances)
                inscripciones(fila, 6) = pago
            Else
                MsgBox("Error, no seleccionó idioma")
                Exit Sub
            End If
            If (CBVIERNES.Checked) And (CBSABADO.Checked) Then
                inscripciones(fila, 3) = "V & S"
                descuento2 = Val(pago * dosdias)
                inscripciones(fila, 8) = descuento2
            ElseIf (CBVIERNES.Checked) Then
                inscripciones(fila, 3) = "VIERNES"
            ElseIf (CBSABADO.Checked) Then
                inscripciones(fila, 3) = "SABADO"
            Else
                MsgBox("Error, no seleccionó ningun dia")
                Exit Sub
            End If
            If (RBEFECTIVO.Checked) Then
                inscripciones(fila, 5) = RBEFECTIVO.Text
                descuento1 = Val(pago * efectivo)
                inscripciones(fila, 7) = descuento1
            ElseIf (RBCHEQUE.Checked) Then
                inscripciones(fila, 5) = RBCHEQUE.Text
                descuento1 = Val(pago * efectivo)
                inscripciones(fila, 7) = descuento1
            Else
                MsgBox("Error, no seleccionó tipo de pago")
                Exit Sub
            End If
            TOTALFINAL = Val(pago - descuento1 - descuento2)
            inscripciones(fila, 9) = TOTALFINAL
            fila = fila + 1
        End If
        If (fila = 8) Then
            MsgBox("Matriz llena")
        End If
        limpiar_entradas()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
