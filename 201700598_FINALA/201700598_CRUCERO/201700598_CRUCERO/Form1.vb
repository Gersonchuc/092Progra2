Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If TextBox1.Text <> Nothing And TextBox2.Text <> Nothing And TextBox3.Text <> Nothing Then
            If ListBox1.SelectedIndex > -1 And ListBox1.SelectedIndex < 3 Then
                If ListBox2.SelectedIndex > -1 And ListBox2.SelectedIndex < 2 Then
                    reservaciones(numReservaciones) = {TextBox1.Text, TextBox2.Text, ListBox1.SelectedItem, TextBox3.Text, ListBox2.SelectedItem}
                    calcularTotalPagar(ListBox1.SelectedIndex, ListBox2.SelectedIndex, TextBox3.Text)
                    numReservaciones = numReservaciones + 1
                    MsgBox("Reservacion guardada con exito")
                Else
                    MsgBox("Seleccione una clase")
                End If
            Else
                MsgBox("Seleccione el tipo de cabina")
            End If
        Else
            MsgBox("Debe de ingresar datos en todos los campos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        ListBox3.Items.Clear()
        ListBox3.Items.Add("Nit ; Nombre ; Cabina ; No.Personas ; Clase ; Total Pagar")
        For i As Integer = 0 To numReservaciones - 1
            ListBox3.Items.Add(reservaciones(i)(0) & " ; " & reservaciones(i)(1) & " ; " & reservaciones(i)(2) & " ; " & reservaciones(i)(3) & " ; " & reservaciones(i)(4) & " ; Q" & totalPagar(i))
        Next i
    End Sub

    Private Sub DatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEntradaToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = 0
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
        ListBox3.SelectedIndex = -1
        ListBox3.Items.Clear()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        ListBox3.Items.Clear()
        For i As Integer = 0 To numReservaciones - 1
            reservaciones(i) = Nothing
            totalPagar(i) = Nothing

        Next i
        numReservaciones = 0
        MsgBox("Vectores limpiados con exito")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub
End Class
