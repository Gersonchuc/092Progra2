Module Module1
    Public reservaciones = {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
    Public totalPagar(6) As Integer
    Public numReservaciones As Integer = 0

    Public Sub calcularTotalPagar(numCabina As Integer, numClase As Integer, numPersonas As Integer)
        Dim total As Integer = 0
        Select Case numCabina
            Case 0
                Select Case numClase
                    Case 0
                        total = numPersonas * 400
                    Case 1
                        total = numPersonas * 375
                End Select
            Case 1
                Select Case numClase
                    Case 0
                        total = numPersonas * 700
                    Case 1
                        total = numPersonas * 600
                End Select
            Case 2
                Select Case numClase
                    Case 0
                        total = numPersonas * 350
                    Case 1
                        total = numPersonas * 300
                End Select
        End Select
        totalPagar(numReservaciones) = total
    End Sub
End Module
