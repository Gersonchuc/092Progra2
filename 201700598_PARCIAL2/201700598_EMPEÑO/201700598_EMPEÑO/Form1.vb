Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        CUI = Val(TXTCUI.Text)
        NOMBRE = TXTNOMBRE.Text
        DIRECCION = TXTDIRECCION.Text
        personas(fila, 0) = CUI
        personas(fila, 1) = DIRECCION

        Select Case (CBPLAZO.SelectedIndex)
            Case 0
                TV = 250
                TELEFONO = 550
                LAPTOP = 770
                REFRIGERADORA = 1000
                PLAZO = "CORTO"

            Case 1
                TV = 300
                TELEFONO = 600
                LAPTOP = 800
                REFRIGERADORA = 1200
                PLAZO = "LARGO"
            Case Else
                MsgBox("Error, no seleccionó plazo")
                CBPLAZO.Focus() : Exit Sub
        End Select

        If CBTV.Checked Or CBCELULAR.Checked Or CBLAPTOP.Checked Or CBREFRIGERADORA.Checked Then
            If (CBTV.Checked) Then
                APARATO = "TV"
                PARCIAL = TV
                If CBCELULAR.Checked Then
                    APARATO = "TV & CELULAR"
                    PARCIAL = TV + TELEFONO
                    If CBLAPTOP.Checked Then
                        APARATO = "TV, CELULAR & LAPTOP"
                        PARCIAL = TV + TELEFONO + LAPTOP
                        If CBREFRIGERADORA.Checked Then
                            APARATO = "TV, CELULAR, LAPTOP & REFRIGERADORA"
                            PARCIAL = TV + TELEFONO + LAPTOP + REFRIGERADORA
                        End If
                    End If
                End If
                TOTALFINAL = PARCIAL
            End If
            If CBCELULAR.Checked Then
                APARATO = "CELULAR"
                PARCIAL = TELEFONO
                If CBLAPTOP.Checked Then
                    APARATO = "CELULAR & LAPTOP"
                    PARCIAL = TELEFONO + LAPTOP
                    If CBREFRIGERADORA.Checked Then
                        APARATO = "CELULAR, LAPTOP & REFRIGERADORA"
                        PARCIAL = TELEFONO + LAPTOP + REFRIGERADORA
                        If CBTV.Checked Then
                            APARATO = "CELULAR, LAPTOP, REFRIGERADORA & TV"
                            PARCIAL = TELEFONO + LAPTOP + REFRIGERADORA + TV
                        End If
                    End If
                End If
                TOTALFINAL = PARCIAL
            End If

            If CBLAPTOP.Checked Then
                APARATO = "LAPTOP"
                PARCIAL = LAPTOP
                If CBREFRIGERADORA.Checked Then
                    APARATO = "LAPTOP & REFRIGERADORA"
                    PARCIAL = LAPTOP + REFRIGERADORA
                    If CBTV.Checked Then
                        APARATO = "LAPTOP, REFRIGERADORA & TV"
                        PARCIAL = LAPTOP + REFRIGERADORA + TV
                        If CBCELULAR.Checked Then
                            APARATO = "LAPTOP, REFRIGERADORA, TV & CELULAR"
                            PARCIAL = LAPTOP + REFRIGERADORA + TV + TELEFONO
                        End If
                    End If
                End If
                TOTALFINAL = PARCIAL
            End If

            If CBREFRIGERADORA.Checked Then
                APARATO = "REFRIGERADORA"
                PARCIAL = REFRIGERADORA
                If CBTV.Checked Then
                    APARATO = "REFRIGERADORA & TV"
                    PARCIAL = REFRIGERADORA + TV
                    If CBCELULAR.Checked Then
                        APARATO = "REFRIGERADORA, TV & CELULAR"
                        PARCIAL = REFRIGERADORA + TV + TELEFONO
                        If CBLAPTOP.Checked Then
                            APARATO = "REFRIGERADORA, TV, CELULAR & LAPTOP"
                            PARCIAL = REFRIGERADORA + TV + TELEFONO + LAPTOP
                        End If
                    End If
                End If
                TOTALFINAL = PARCIAL
            End If
        Else
            MsgBox("ERROR, NO SELECCIONÓ APARATO")
            Exit Sub
        End If

        If CBTV.Checked And CBREFRIGERADORA.Checked And CBPLAZO.SelectedIndex = 0 Then
            DESCUENTO = PARCIAL * 0.15
            TOTALFINAL = PARCIAL - DESCUENTO
        End If

        If CBTV.Checked And CBREFRIGERADORA.Checked And CBPLAZO.SelectedIndex = 1 Then
            DESCUENTO = PARCIAL * 0.05
            TOTALFINAL = PARCIAL - DESCUENTO
        End If

        If CBLAPTOP.Checked And CBCELULAR.Checked And CBPLAZO.SelectedIndex = 1 Then
            DESCUENTO = PARCIAL * 0.1
            TOTALFINAL = PARCIAL - DESCUENTO
        End If

        If CBLAPTOP.Checked And CBCELULAR.Checked And CBPLAZO.SelectedIndex = 0 Then
            DESCUENTO = PARCIAL * 0.05
            TOTALFINAL = PARCIAL - DESCUENTO
        End If


        personas(fila, 2) = APARATO
        personas(fila, 3) = CBPLAZO.Text
        personas(fila, 4) = DESCUENTO
        personas(fila, 5) = PARCIAL
        personas(fila, 6) = TOTALFINAL
        muestre_totales()
        fila = fila + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_matriz()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_entradas()
        limpiar_matriz()
    End Sub
End Class
