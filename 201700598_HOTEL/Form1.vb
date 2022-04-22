Public Class Form1
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If x <= 7 Then
            Nombre(x) = txtNombre.Text
            Nit(x) = txtNiot.Text
            Dias(x) = CInt(Int(txtDias.Text))
            Valor(x) = Convert.ToDouble(txtImpuesto.Text)

            TipoHabitacion(x) = cbHabitacion.SelectedItem.ToString
            TipoPago(x) = cbPago.SelectedItem.ToString


            Select Case TipoHabitacion(x)
                Case "Sencilla"
                    Total(x) = 250 * Dias(x)
                Case "Doble"
                    Total(x) = 400 * Dias(x)
                Case "Cabana"
                    Total(x) = 650 * Dias(x)
            End Select

            Select Case TipoHabitacion(x)
                Case "Sencilla"
                    Total(x) = 250 * Dias(x)
                Case "Doble"
                    Total(x) = 400 * Dias(x)
                Case "Cabana"
                    Total(x) = 650 * Dias(x)
            End Select

        End If
    End Sub
End Class
