Module Module1
    Public TOTAL As Double
    Public Const algodon = 15
    Public Const seda = 23.99
    Public Const lona = 30.99
    Public TotalYardas As Double
    Public PrecioVenta As Double
    Sub LIMPIAR_ENTRADAS()

        Form1.TXTALGODON.Clear()
        Form1.TXTSEDA.Clear()
        Form1.TXTLONA.Clear()
        Form1.CBALGODON.Checked = False
        Form1.CBSEDA.Checked = False
        Form1.CBLONA.Checked = False
        Form1.RBSMALL.Focus()
        Form1.LRESULTADOS.Text = "--"
        Form1.LVENTA.Text = "--"
    End Sub
End Module
