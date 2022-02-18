Module Module1
    Public TOTAL As Double
    Public MONTO As Double
    Public SEGURO As Double

    Public Const NORTE = 150
    Public Const SUR = 200
    Public Const ORIENTE = 175
    Public Const OCCIDENTE = 225

    Public Const VEHICULO = (3 / 100)
    Public Const ACCIDENTE = (5 / 100)

    Sub LIMPIAR_ENTRADAS()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTMONTO.Clear()
        Form1.RBNORTE.Checked = False
        Form1.RBSUR.Checked = False
        Form1.RBORIENTE.Checked = False
        Form1.RBOCCIDENTE.Checked = False
        Form1.RBVEHICULO.Checked = False
        Form1.RBACCIDENTE.Checked = False
        Form1.LMONTOSEGURO.Text = "--"
        Form1.LVIATICOS.Text = "--"
        Form1.LSUELDOFINAL.Text = "--"
        Form1.TXTNOMBRE.Focus()
    End Sub
End Module
