Imports System.Math
Module Module1
    Public TOTAL As Double
    Public SUBTOTAL As Double
    Public DESCUENTO As Double
    Public PASAJEROS As Integer
    Public Const ASUR = 150
    Public Const AIZABAL = 175.99
    Public Const APETEN = 250.99
    Public Const JSUR = 250.99
    Public Const JIZABAL = 325.99
    Public Const JPETEN = 450.99
    Public Const HSUR = 125.99
    Public Const HIZABAL = 175.99
    Public Const HPETEN = 275.99
    Public Const descuento1 = (2 / 100)
    Public Const descuento2 = (10 / 100)
    Sub LIMPIAR_ENTRADAS()
        Form1.CBSUR.Checked = False
        Form1.CBIZABAL.Checked = False
        Form1.CBPETEN.Checked = False
        Form1.RBAVIONETA.Checked = False
        Form1.RBJET.Checked = False
        Form1.RBHELICOPTERO.Checked = False
        Form1.TXTPASAJEROS.Text = 0
        Form1.LSUBTOTAL.Text = "--"
        Form1.LTOTAL.Text = "--"
        Form1.LDESCUENTO.Text = "--"
        Form1.CBSUR.Focus()
    End Sub
End Module
