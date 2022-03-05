Module Module1
    Public indice As Byte = 0

    Public HABITACION(6) As String
    Public SERVICIO(6) As String
    Public PAGO(6) As String
    Public dias(6) As Integer
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Recargo(6) As Double
    Public PagoTotal(6) As Double
    Sub limpiar_entradas()
        Form1.TXTNOMBRE.Clear()
        Form1.CBHABITACION.SelectedIndex = -1
        Form1.CBSERVICIO.SelectedIndex = -1
        Form1.CBPAGO.SelectedIndex = -1

        Form1.LST_HABITACION.Items.Clear()
        Form1.LST_SERVICIO.Items.Clear()
        Form1.LST_PAGO.Items.Clear()
        Form1.LST_DIAS.Items.Clear()
        Form1.LST_subtotal.Items.Clear()
        Form1.LST_DESCUENTO1.Items.Clear()
        Form1.LST_RECARGO.Items.Clear()
        Form1.LST_TOTAL.Items.Clear()

        Form1.TXTNOMBRE.Focus()
    End Sub
    Sub mostrar()
        Form1.LST_HABITACION.Items.Add(HABITACION(indice))
        Form1.LST_SERVICIO.Items.Add(SERVICIO(indice))
        Form1.LST_PAGO.Items.Add(PAGO(indice))
        Form1.LST_DIAS.Items.Add(dias(indice))
        Form1.LST_subtotal.Items.Add(Subtotal(indice))
        Form1.LST_DESCUENTO1.Items.Add(Descuento(indice))
        Form1.LST_RECARGO.Items.Add(Recargo(indice))
        Form1.LST_TOTAL.Items.Add(PagoTotal(indice))

        Form1.TXTNOMBRE.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTDIAS.Clear()
        Form1.CBHABITACION.SelectedIndex = -1
        Form1.CBSERVICIO.SelectedIndex = -1
        Form1.CBPAGO.SelectedIndex = -1
    End Sub
    Sub limpiar_vectores()
        indice = 0

        Form1.TXTNOMBRE.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTDIAS.Clear()
        Form1.CBHABITACION.SelectedIndex = -1
        Form1.CBSERVICIO.SelectedIndex = -1
        Form1.CBPAGO.SelectedIndex = -1

        Form1.LST_HABITACION.Items.Clear()
        Form1.LST_SERVICIO.Items.Clear()
        Form1.LST_PAGO.Items.Clear()
        Form1.LST_DIAS.Items.Clear()
        Form1.LST_subtotal.Items.Clear()
        Form1.LST_DESCUENTO1.Items.Clear()
        Form1.LST_RECARGO.Items.Clear()
        Form1.LST_TOTAL.Items.Clear()

        Form1.TXTNOMBRE.Focus()
    End Sub
End Module
