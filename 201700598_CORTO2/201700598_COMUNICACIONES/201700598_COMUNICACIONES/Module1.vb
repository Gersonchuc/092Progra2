Module Module1
    Public indice As Byte = 0

    Public empleado(7) As String
    Public COMISION(7) As Double
    Public bono(7) As Double
    Public SUELDO(7) As Double
    Public VENTAS(7) As Double

    Public Const tablet = 375
    Public Const drone = 560
    Public Const celular = 1450
    Public Const televisor = 3250

    Public Const bono1 = 0.03
    Public Const bono2 = 0.04
    Public Const bono3 = 0.05
    Public Const comisiones = 0.055
    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub
    Sub limpiar_vectores()
        indice = 0

        Form1.LSTEMPLEADO.Items.Clear()
        Form1.LSTBONO.Items.Clear()
        Form1.LSTCOMISION.Items.Clear()
        Form1.LSTSUELDO.Items.Clear()
        Form1.LSTVENTAS.Items.Clear()

    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTSUELDO.Clear()
        Form1.RBTABLET.Checked = False
        Form1.RBDRONE.Checked = False
        Form1.RBCELULAR.Checked = False
        Form1.RBTELEVISOR.Checked = False

        Form1.TXTNOMBRE.Focus()
    End Sub
End Module
