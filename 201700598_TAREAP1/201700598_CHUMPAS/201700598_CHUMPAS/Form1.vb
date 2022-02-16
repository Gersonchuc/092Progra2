Public Class Form1
    Private Sub LRESULTADOS_Click(sender As Object, e As EventArgs) Handles LRESULTADOS.Click

    End Sub

    Private Sub LVENTA_Click(sender As Object, e As EventArgs) Handles LVENTA.Click

    End Sub

    Private Sub BTSALIR_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub BTLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub BTCALCULAR_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        TotalYardas = Val(TXTALGODON.Text) + Val(TXTSEDA.Text) + Val(TXTLONA.Text)
        If RBSMALL.Checked Then
            If TotalYardas >= 2 Then
                TOTAL = 65.5 + Val(TXTALGODON.Text) * algodon + Val(TXTSEDA.Text) * seda + Val(TXTLONA.Text) * lona
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBMEDIUM.Checked Then
            If TotalYardas >= 2.5 Then
                TOTAL = 85.99 + Val(TXTALGODON.Text) * algodon + Val(TXTSEDA.Text) * seda + Val(TXTLONA.Text) * lona
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBLARGE.Checked Then
            If TotalYardas >= 2 Then
                TOTAL = 99.99 + Val(TXTALGODON.Text) * algodon + Val(TXTSEDA.Text) * seda + Val(TXTLONA.Text) * lona
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If

    End Sub

    Private Sub CBALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles CBALGODON.CheckedChanged
        If CBALGODON.Checked Then
            TXTALGODON.Enabled = True
        Else
            TXTALGODON.Enabled = False
            TXTALGODON.Text = 0
        End If
    End Sub

    Private Sub CBSEDA_CheckedChanged(sender As Object, e As EventArgs) Handles CBSEDA.CheckedChanged
        If CBSEDA.Checked Then
            TXTSEDA.Enabled = True
        Else
            TXTSEDA.Enabled = False
            TXTSEDA.Text = 0
        End If
    End Sub

    Private Sub CBLONA_CheckedChanged(sender As Object, e As EventArgs) Handles CBLONA.CheckedChanged
        If CBLONA.Checked Then
            TXTLONA.Enabled = True
        Else
            TXTLONA.Enabled = False
            TXTLONA.Text = 0
        End If
    End Sub
End Class
