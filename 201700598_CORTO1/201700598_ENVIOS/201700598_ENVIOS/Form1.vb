Public Class Form1
    Private Sub BTLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub BTSALIR_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub BTCALCULAR_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        MONTO = Val(TXTMONTO.Text)
        If RBNORTE.Checked Then
            TOTAL = 3800 + NORTE

            If RBVEHICULO.Checked Then
                SEGURO = Val(3800 * VEHICULO)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(NORTE)
            ElseIf RBACCIDENTE.Checked Then
                SEGURO = Val(3800 * ACCIDENTE)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(NORTE)
            End If

        End If
        If RBSUR.Checked Then
            TOTAL = 3800 + SUR

            If RBVEHICULO.Checked Then
                SEGURO = Val(3800 * VEHICULO)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(SUR)
            ElseIf RBACCIDENTE.Checked Then
                SEGURO = Val(3800 * ACCIDENTE)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(SUR)
            End If

        End If
        If RBORIENTE.Checked Then
            TOTAL = 3800 + ORIENTE

            If RBVEHICULO.Checked Then
                SEGURO = Val(3800 * VEHICULO)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(ORIENTE)
            ElseIf RBACCIDENTE.Checked Then
                SEGURO = Val(3800 * ACCIDENTE)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(ORIENTE)
            End If

        End If
        If RBOCCIDENTE.Checked Then
            TOTAL = 3800 + OCCIDENTE

            If RBVEHICULO.Checked Then
                SEGURO = Val(3800 * VEHICULO)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(OCCIDENTE)
            ElseIf RBACCIDENTE.Checked Then
                SEGURO = Val(3800 * ACCIDENTE)
                LSUELDOFINAL.Text = Str(Val(TOTAL + SEGURO))
                LMONTOSEGURO.Text = Str(SEGURO)
                LVIATICOS.Text = Str(OCCIDENTE)
            End If
        End If
    End Sub
End Class
