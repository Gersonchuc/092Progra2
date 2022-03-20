Imports System.Math
Module Module1
    Public personas(5, 6) As String


    Public CUI As Integer
    Public NOMBRE As String
    Public DIRECCION As String
    Public PLAZO As String
    Public APARATO As String
    Public DESCUENTO As Double
    Public PARCIAL As Double
    Public TOTALFINAL As Double

    Public TV As Double
    Public TELEFONO As Double
    Public LAPTOP As Double
    Public REFRIGERADORA As Double

    Public fila As Byte = 0

    Sub limpiar_matriz()

        Dim i As Byte, j As Byte

        For i = 0 To 5
            For j = 0 To 6
                personas(i, j) = Nothing
            Next j
        Next i

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        fila = 0

    End Sub
    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            limpiar_matriz()

        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TXTCUI.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTDIRECCION.Clear()

        Form1.CBPLAZO.SelectedIndex = -1

        Form1.CBTV.Checked = 0
        Form1.CBCELULAR.Checked = 0
        Form1.CBLAPTOP.Checked = 0
        Form1.CBREFRIGERADORA.Checked = 0

        Form1.TXTCUI.Focus()


    End Sub
    Sub muestre_totales()
        Form1.ListBox1.Items.Add(personas(fila, 0))
        Form1.ListBox2.Items.Add(personas(fila, 1))
        Form1.ListBox3.Items.Add(personas(fila, 2))
        Form1.ListBox4.Items.Add(personas(fila, 3))
        Form1.ListBox5.Items.Add(personas(fila, 4))
        Form1.ListBox6.Items.Add(personas(fila, 5))
        Form1.ListBox7.Items.Add(personas(fila, 6))

    End Sub
End Module
