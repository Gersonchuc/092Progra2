
Public Class Form1
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
        INDICE = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (INDICE <= 10) Then
            CLIENTE(INDICE) = TXTCLIENTE.Text
            VALOR(INDICE) = Val(TXTVALOR.Text)
            PESO(INDICE) = Val(InputBox("INGRESE PESO"))
            TIPO(INDICE) = CBTIPO.Text
            TRANSPORTE(INDICE) = CBTRANSPORTE.Text
            If TRANSPORTE(INDICE) = "CAMION" Then
                If TIPO(INDICE) = "DOCUMENTOS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * documentos
                ElseIf TIPO(INDICE) = "ROPA" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * ropa
                ElseIf TIPO(INDICE) = "ART. PEDECEDEROS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * pedecederos
                ElseIf TIPO(INDICE) = "ART. PLASTICOS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * plastico
                ElseIf TIPO(INDICE) = "LOCIONES" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * lociones
                End If
                PARCIAL(INDICE) = Math.Round(camion + IMPUESTO(INDICE), 2)

            ElseIf TRANSPORTE(INDICE) = "MOTOCICLETA" Then
                If TIPO(INDICE) = "DOCUMENTOS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * documentos
                ElseIf TIPO(INDICE) = "ROPA" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * ropa
                ElseIf TIPO(INDICE) = "ART. PEDECEDEROS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * pedecederos
                ElseIf TIPO(INDICE) = "ART. PLASTICOS" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * plastico
                ElseIf TIPO(INDICE) = "LOCIONES" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * lociones
                End If
                PARCIAL(INDICE) = Math.Round(moto + IMPUESTO(INDICE), 2)
            End If

            TOTAL(INDICE) = Math.Round(PARCIAL(INDICE) + VALOR(INDICE), 2)

            mostrar_vectores()
            INDICE = INDICE + 1
        End If

        If (INDICE = 10) Then
            MsgBox("VECTORES LLENOS")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ESTADISTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICAToolStripMenuItem.Click
        Dim i As Byte
        Dim totlociones As Double
        Dim totdocumentos As Double
        Dim totropa As Double
        Dim totplasticos As Double
        totplasticos = 0
        totropa = 0
        totlociones = 0
        totdocumentos = 0
        For i = 0 To 10

            If (ListBox4.Text = "DOCUMENTOS") Then

                totdocumentos = totdocumentos + VALOR(i)

                If (CBTIPO.Text = "LOCIONES") Then
                    totlociones = totlociones + VALOR(INDICE)
                End If

                If (CBTIPO.Text = "ROPA") Then
                    totropa = totropa + 1
                End If
                If (CBTIPO.Text = "ART. PLASTICOS") Then
                    totplasticos = totplasticos + 1
                End If

            Else
                Exit For
            End If
        Next i
        TXTDOCUMENTOS.Text = Str(totdocumentos)
        TXTLOCIONES.Text = Str(totlociones)
        TXTPLASTICO.Text = Str(totplasticos)
        TXTTOTAL.Text = Str(totropa)
    End Sub
End Class
