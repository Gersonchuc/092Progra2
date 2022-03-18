Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click

        limpiar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        empleado(indice) = TXTNOMBRE.Text
        SUELDO(indice) = Val(TXTSUELDO.Text)

        If RBTABLET.Checked Then
            VENTAS(indice) = tablet
            COMISION(indice) = Val(VENTAS(indice) * comisiones)
            If SUELDO(indice) >= 1 And SUELDO(indice) <= 2000 Then
                bono(indice) = Val(VENTAS(indice) * bono1)
                indice = indice + 1

            ElseIf SUELDO(indice) >= 2001 And SUELDO(indice) <= 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono2)
                indice = indice + 1
            ElseIf SUELDO(indice) > 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono3)
                indice = indice + 1
            ElseIf MsgBox("Coloque Sueldo del empleado", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

            End If
        ElseIf RBDRONE.Checked Then
            VENTAS(indice) = Val(drone)
            COMISION(indice) = Val(VENTAS(indice) * comisiones)
            If SUELDO(indice) >= 1 And SUELDO(indice) <= 2000 Then
                bono(indice) = Val(VENTAS(indice) * bono1)
                indice = indice + 1

            ElseIf SUELDO(indice) >= 2001 And SUELDO(indice) <= 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono2)
                indice = indice + 1
            ElseIf SUELDO(indice) > 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono3)
                indice = indice + 1
            ElseIf MsgBox("Coloque Sueldo del empleado", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

            End If
        ElseIf RBCELULAR.Checked Then
            VENTAS(indice) = Val(celular)
            COMISION(indice) = Val(VENTAS(indice) * comisiones)
            If SUELDO(indice) >= 1 And SUELDO(indice) <= 2000 Then
                bono(indice) = Val(VENTAS(indice) * bono1)
                indice = indice + 1

            ElseIf SUELDO(indice) >= 2001 And SUELDO(indice) <= 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono2)
                indice = indice + 1
            ElseIf SUELDO(indice) > 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono3)
                indice = indice + 1
            ElseIf MsgBox("Coloque Sueldo del empleado", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

            End If
        ElseIf RBTELEVISOR.Checked Then
            VENTAS(indice) = Val(televisor)
            COMISION(indice) = Val(VENTAS(indice) * comisiones)
            If SUELDO(indice) >= 1 And SUELDO(indice) <= 2000 Then
                bono(indice) = Val(VENTAS(indice) * bono1)
                indice = indice + 1

            ElseIf SUELDO(indice) >= 2001 And SUELDO(indice) <= 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono2)
                indice = indice + 1
            ElseIf SUELDO(indice) > 5000 Then
                bono(indice) = Val(VENTAS(indice) * bono3)
                indice = indice + 1
            ElseIf MsgBox("Coloque Sueldo del empleado", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

            End If
        ElseIf MsgBox("seleccione articulo", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
        End If
        LSTEMPLEADO.Items.Add(TXTNOMBRE.Text)
        LSTCOMISION.Items.Add(Str(COMISION(indice)))
        LSTBONO.Items.Add(Str(bono(indice)))
        LSTSUELDO.Items.Add(Str(SUELDO(indice)))
        LSTVENTAS.Items.Add(Str(VENTAS(indice)))
    End Sub
End Class
