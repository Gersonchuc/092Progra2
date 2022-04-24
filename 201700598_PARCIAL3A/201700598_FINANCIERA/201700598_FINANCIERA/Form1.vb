Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click

        If reservaciones < 7 Then
            If TextBox1.Text = Nothing Then
                MsgBox("DEBE ESCRIBIR UN ID PARA CLIENTE")
            ElseIf TextBox2.Text = Nothing Then
                MsgBox("DEBE COLOCAR EL NUMERO DE DIAS")
            ElseIf TextBox3.Text = Nothing Then
                MsgBox("DEBE DE INGRESAR EL NUMERO DE PERSONAS")
            ElseIf ComboBox1.SelectedIndex < 0 Then
                MsgBox("DEBE DE SELECCIONAR EL TIPO DE VIAJE")
            Else
                ID(reservaciones) = TextBox1.Text
                viaje(reservaciones) = ComboBox1.SelectedItem.ToString()
                dias(reservaciones) = Val(TextBox2.Text)
                personas(reservaciones) = Val(TextBox3.Text)
                preciopersona()
                reservaciones = reservaciones + 1


                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""

                MsgBox("Registro guardado con exito")
            End If

        Else
            MsgBox("LAS RESERVACIONES SUPERAN EL NUMERO MAXIMO DE 7 REGISTROS ELIMINE DATOS O LIMPIE EL VECTOR COMPLETO")
        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

        For I = 0 To ID.Length - 1
            If ID(I) <> Nothing Then
                ListBox1.Items.Add(ID(I))
                ListBox2.Items.Add(viaje(I))
                ListBox3.Items.Add(dias(I))
                ListBox4.Items.Add(personas(I))
                ListBox5.Items.Add("Q " + toralPagar(I).ToString())
            End If
        Next I


    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim BUSCAR As String = TextBox1.Text

        If TextBox1.Text <> Nothing Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()
            ListBox5.Items.Clear()


            For I = 0 To ID.Length - 1
                If ID(I) <> Nothing And BUSCAR = ID(I) Then
                    ListBox1.Items.Add(ID(I))
                    ListBox2.Items.Add(viaje(I))
                    ListBox3.Items.Add(dias(I))
                    ListBox4.Items.Add(personas(I))
                    ListBox5.Items.Add("Q " + toralPagar(I).ToString())
                    DATOCONSULTADO = I
                End If
            Next I
        Else
            MsgBox("NO A ESCRITO EL ID DEL CLIENTE PARA BUSCARLO")
            DATOCONSULTADO = -1
        End If



    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        If DATOCONSULTADO > -1 Then
            ID(DATOCONSULTADO) = Nothing
            viaje(DATOCONSULTADO) = Nothing
            dias(DATOCONSULTADO) = Nothing
            personas(DATOCONSULTADO) = Nothing
            toralPagar(DATOCONSULTADO) = Nothing
            For I = DATOCONSULTADO To ID.Length - 1
                If I = ID.Length - 1 Then
                    ID(I) = Nothing
                    viaje(I) = Nothing
                    dias(I) = Nothing
                    personas(I) = Nothing
                    toralPagar(I) = Nothing
                Else
                    ID(I) = ID(I + 1)
                    viaje(I) = viaje(I + 1)
                    dias(I) = dias(I + 1)
                    personas(I) = personas(I + 1)
                    toralPagar(I) = toralPagar(I + 1)
                End If
            Next I
            DATOCONSULTADO = -1
            MsgBox("EL DATO A SIDO ELIMINADO")
            TextBox1.Text = ""
            reservaciones = reservaciones - 1
        Else
            MsgBox("NO  A BUSCADO UN CLIENTE PARA PODERLO ELIMINAR")
            DATOCONSULTADO = -1
        End If


    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        For i = 0 To ID.Length - 1
            ID(i) = Nothing
            viaje(i) = Nothing
            dias(i) = Nothing
            personas(i) = Nothing
            toralPagar(i) = Nothing
        Next i
        reservaciones = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        MsgBox("vectores limpiados con exito")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
