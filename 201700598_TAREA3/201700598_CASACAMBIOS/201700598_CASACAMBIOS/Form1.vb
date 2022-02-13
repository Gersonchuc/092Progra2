Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar()

        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub BT_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BT_LIMPIAR.Click
        limpiar()
    End Sub

    Private Sub BT_CALCULAR_Click(sender As Object, e As EventArgs) Handles BT_CALCULAR.Click
        If ((CBCOMPRA.Checked) Or (CBVENTA.Checked)) Then

            If (CBCOMPRA.Checked) Then

                If (IsNumeric(TXT_COMPRAR.Text) And Val(TXT_COMPRAR.Text) > 0) Then
                    compra = Val(TXT_COMPRAR.Text)
                Else
                    MsgBox("Ingresó un valor erroneo")
                    TXT_COMPRAR.Focus()

                    Exit Sub
                End If
            Else
                compra = 0
            End If





            If (CBVENTA.Checked) Then
                If (IsNumeric(TXT_VENDER.Text) And Val(TXT_VENDER.Text) > 0) Then
                    venta = Val(TXT_VENDER.Text)
                Else
                    MsgBox("Ingresó un valor erroneo")
                    TXT_VENDER.Focus()
                    Exit Sub
                End If
            Else
                venta = 0
            End If
        End If




        If (CBCOMPRA.Checked) Then
            If (CBCOMPRA.Checked) And (RDCDOLAR.Checked) Then

                c1 = compra / DOLAR
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()



            ElseIf (CBCOMPRA.Checked) And (RDCDOLAR.Checked) Then

                c1 = compra / PESO
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()


            ElseIf (CBCOMPRA.Checked) And (RDCDOLAR.Checked) Then

                c1 = compra / Euro
                c2 = c1 * comision1
                c3 = c1 + c2 : resultados()


            ElseIf (CBCOMPRA.Checked) And (RDCDOLAR.Checked) Then

                c1 = compra / Colon
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()

            Else

                MsgBox("No selecciono ninguna moneda")
                Exit Sub
            End If

        End If





        If (CBVENTA.Checked) Then
            If (CBVENTA.Checked) And (RDVDOLAR.Checked) Then

                v1 = venta * DOLAR
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()

            ElseIf (CBVENTA.Checked) And (RDVDOLAR.Checked) Then

                v1 = venta * PESO
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()


            ElseIf (CBVENTA.Checked) And (RDVDOLAR.Checked) Then

                v1 = venta * Euro
                v2 = v1 * comision2
                v3 = v1 + v2
            ElseIf (CBVENTA.Checked) And (RDVDOLAR.Checked) Then

                v1 = venta * Colon
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()

            Else

                MsgBox("No selecciono ninguna moneda")
                Exit Sub
            End If

        End If


    End Sub

    Private Sub TXT_COMPRAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_COMPRAR.TextChanged

    End Sub

    Private Sub TXT_VENDER_TextChanged(sender As Object, e As EventArgs) Handles TXT_VENDER.TextChanged

    End Sub

    Private Sub CBCOMPRA_CheckedChanged(sender As Object, e As EventArgs) Handles CBCOMPRA.CheckedChanged
        If CBCOMPRA.Checked = True Then
            TXT_COMPRAR.Enabled = True
        Else
            TXT_COMPRAR.Enabled = False
        End If
    End Sub

    Private Sub CBVENTA_CheckedChanged(sender As Object, e As EventArgs) Handles CBVENTA.CheckedChanged
        If CBVENTA.Checked = True Then
            TXT_VENDER.Enabled = True
        Else
            TXT_VENDER.Enabled = False
        End If
    End Sub
End Class
