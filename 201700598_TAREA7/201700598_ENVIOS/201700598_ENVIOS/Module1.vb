Module Module1
    Public INDICE As Byte = 0

    Public CLIENTE(10) As String
    Public VALOR(10) As Integer
    Public PESO(10) As Integer
    Public TIPO(10) As String
    Public TRANSPORTE(10) As String
    Public IMPUESTO(10) As Double
    Public PARCIAL(10) As Double
    Public TOTAL(10) As Double

    Public Const camion = 50
    Public Const moto = 15

    Public Const documentos = 0.015
    Public Const ropa = 0.06
    Public Const pedecederos = 0.055
    Public Const plastico = 0.045
    Public Const lociones = 0.02

    Sub mostrar_vectores()

        Form1.ListBox1.Items.Add(CLIENTE(INDICE))
        Form1.ListBox2.Items.Add(VALOR(INDICE))
        Form1.ListBox3.Items.Add(IMPUESTO(INDICE))
        Form1.ListBox4.Items.Add(TIPO(INDICE))
        Form1.ListBox5.Items.Add(PARCIAL(INDICE))
        Form1.ListBox6.Items.Add(TOTAL(INDICE))



    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.TXTCLIENTE.Clear()
        Form1.TXTVALOR.Clear()
        Form1.CBTRANSPORTE.Text = ""
        Form1.CBTIPO.Text = ""
        Form1.TXTCLIENTE.Focus()
    End Sub
End Module
