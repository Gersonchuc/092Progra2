Imports System.Math
Module Module1
    Public Const DOLAR = 7.69
    Public Const PESO = 0.38
    Public Const Euro = 8.79
    Public Const Colon = 0.0012
    Public Const comision1 = 0.025
    Public Const comision2 = 0.03
    Public totalcompra As Double
    Public totalventa As Double
    Public totalcomi1 As Double
    Public totalcomi2 As Double
    Public totalfinal1 As Double
    Public totalfinal2 As Double
    Public compra As Double
    Public venta As Double
    Public c1 As Double
    Public c2 As Double
    Public c3 As Double
    Public v1 As Double
    Public v2 As Double
    Public v3 As Double
    Sub limpiar()
        Form1.TXT_COMPRAR.Clear()
        Form1.TXT_VENDER.Clear()
        Form1.CBCOMPRA.Checked = False
        Form1.CBVENTA.Checked = False

        Form1.RDCDOLAR.Checked = False
        Form1.RBCEURO.Checked = False
        Form1.RBCPESO.Checked = False
        Form1.RBVPESO.Checked = False
        Form1.RBVEURO.Checked = False
        Form1.RBVCOLON.Checked = False
        Form1.RDVDOLAR.Checked = False
        Form1.RBCCOLON.Checked = False

        Form1.TXT_COMPRAR.Focus()
    End Sub
    Sub resultados()

        Form1.TXTC1.Text = Str(Round(c1, 2))
        Form1.TXTC2.Text = Str(Round(c2, 2))
        Form1.TXTC3.Text = Str(Round(c3, 2))
        Form1.TXTV1.Text = Str(Round(v1, 2))
        Form1.TXTV2.Text = Str(Round(v2, 2))
        Form1.TXTV3.Text = Str(Round(v3, 2))


    End Sub
End Module
