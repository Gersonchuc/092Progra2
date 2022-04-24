Module Module1
    Public ID(7) As String
    Public viaje(7) As String
    Public dias(7) As Integer
    Public personas(7) As Integer
    Public toralPagar(7) As Integer
    Public reservaciones As Integer = 0
    Public DATOCONSULTADO As Integer = -1

    Sub preciopersona()
        Dim diaporpersona As Integer = Val(Form1.TextBox2.Text) * Val(Form1.TextBox3.Text)
        Dim TIPOVIAJE As Integer = Val(Form1.ComboBox1.SelectedIndex)

        If TIPOVIAJE = 0 Then
            toralPagar(reservaciones) = diaporpersona * 1190
        ElseIf TIPOVIAJE = 1 Then
            toralPagar(reservaciones) = diaporpersona * 440
        ElseIf TIPOVIAJE = 2 Then
            toralPagar(reservaciones) = diaporpersona * 255
        End If

    End Sub

End Module
