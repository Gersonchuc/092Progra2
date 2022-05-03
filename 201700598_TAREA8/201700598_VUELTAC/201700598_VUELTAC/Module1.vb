Module Module1
    Public etapas(12) As Integer
    Public equipo(12) As String
    Public kilometros(12) As Integer
    Public tiempo(12) As Integer
    Public nacionalidad(12) As String
    Public contar As Integer = 0
    Public datos As Integer = 0

    Public Sub corredores()
        contar = 0
        For i = 0 To etapas.Length - 1
            If nacionalidad(i) = "Guatemalteco" And kilometros(i) > 45 Then
                contar = contar + 1
            End If
        Next i
        Form1.TextBox1.Text = contar
    End Sub
End Module
