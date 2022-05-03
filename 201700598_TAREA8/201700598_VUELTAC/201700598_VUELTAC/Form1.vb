Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Equipo.SelectedIndexChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Netapas.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_Kilometros.TextChanged

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        For i = 0 To etapas.Length - 1
            equipo(i) = Nothing
            etapas(i) = Nothing
            kilometros(i) = Nothing
            tiempo(i) = Nothing
            nacionalidad(i) = Nothing
        Next i
        datos = 0
        ListBox1.Items.Clear()
        MsgBox("Vectores limpiados")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_tiempo.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Nacionalidad.SelectedIndexChanged

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        txt_Netapas.Clear()
        txt_Kilometros.Clear()
        txt_tiempo.Clear()


    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim penalizacion As Integer = txt_tiempo.Text()
        Dim equip As String = txt_Equipo.SelectedItem.ToString()

        If penalizacion < 85 And equip = "MOVISTAR" Then
            penalizacion = penalizacion - 15
        ElseIf penalizacion < 85 And equip = "PRO TEAM" Then
            penalizacion = penalizacion - 10
        ElseIf penalizacion > 120 And penalizacion < 140 Then
            penalizacion = penalizacion + 30
        ElseIf penalizacion >= 140 And penalizacion < 160 Then
            penalizacion = penalizacion + 40
        ElseIf penalizacion >= 160 Then
            penalizacion = penalizacion + 60
        End If

        etapas(datos) = txt_Netapas.Text()
        equipo(datos) = txt_Equipo.SelectedItem.ToString()
        kilometros(datos) = txt_Kilometros.Text()
        tiempo(datos) = penalizacion
        nacionalidad(datos) = txt_Nacionalidad.SelectedItem.ToString()
        datos = datos + 1

        txt_Netapas.Clear()
        txt_Kilometros.Clear()
        txt_tiempo.Clear()

        MsgBox("Se guardo con exito")
        corredores()

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Dim texto As String

        ListBox1.Items.Clear()
        For i = 0 To etapas.Length - 1
            If etapas(i) <> Nothing Then
                texto = "Etapa: " & etapas(i) & " Equipo: " & equipo(i) & " km: " & kilometros(i) & " min: " & tiempo(i) & " nacionalidad:  " & nacionalidad(i)
                ListBox1.Items.Add(texto)
            End If
        Next i
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        Dim aux As Double
        Dim auxe As String
        Dim auxn As String
        Dim i, j As Integer

        For i = 1 To etapas.Length - 1
            For j = 0 To etapas.Length - i - 1
                If (etapas(j) > etapas(j + 1)) Then
                    auxe = equipo(j + 1)
                    equipo(j + 1) = equipo(j)
                    equipo(j) = auxe

                    aux = kilometros(j + 1)
                    kilometros(j + 1) = kilometros(j)
                    kilometros(j) = aux

                    aux = tiempo(j + 1)
                    tiempo(j + 1) = tiempo(j)
                    tiempo(j) = aux

                    auxn = nacionalidad(j + 1)
                    nacionalidad(j + 1) = nacionalidad(j)
                    nacionalidad(j) = auxn

                    aux = etapas(j + 1)
                    etapas(j + 1) = etapas(j)
                    etapas(j) = aux
                End If
            Next
        Next

        MsgBox("Ordenado correctamente")
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        MsgBox("no conculta")
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        MsgBox("no actualiza")
    End Sub
End Class
