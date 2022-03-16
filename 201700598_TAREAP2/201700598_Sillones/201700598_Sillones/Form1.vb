Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBCUERO.CheckedChanged
        If RBCUERO.Checked Then
            TXTCUERO.Enabled = True
        Else
            TXTCUERO.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RBCUERINA.CheckedChanged
        If RBCUERINA.Checked Then
            TXTCUERINA.Enabled = True
        Else
            TXTCUERINA.Enabled = False
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click

        limpiar_vectores()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        Venta(INDICE) = Str(TXTVENTAS.Text)
        yardas(INDICE) = Val(Val(TXTCUERO.Text) + Val(TXTCUERINA.Text))
        If RBSOFA.Checked Then
            tamaño(INDICE) = "SOFA"
            If yardas(INDICE) >= 8 Then
                If RBCUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = sofa + Val(TXTCUERO.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(sofa + Val(TXTCUERO.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RBCUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = sofa + Val(TXTCUERINA.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + Round(Val(sofa + Val(TXTCUERINA.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBINDIVIDUAL.Checked Then
            tamaño(INDICE) = "INDIVIDUAL"
            If yardas(INDICE) >= 3.5 Then
                If RBCUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = individual + Val(TXTCUERO.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(individual + Val(TXTCUERO.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RBCUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = individual + Val(TXTCUERINA.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + Round(Val(individual + Val(TXTCUERINA.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBDOBLE.Checked Then
            tamaño(INDICE) = "DOBLE"
            If yardas(INDICE) >= 6 Then
                If RBCUERO.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = doble + Val(TXTCUERO.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(doble + Val(TXTCUERO.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RBCUERINA.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = doble + Val(TXTCUERINA.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(doble + Val(TXTCUERINA.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If (INDICE = 8) Then
            MsgBox("VECTORES LLENOS")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
