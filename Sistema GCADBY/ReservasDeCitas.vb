Public Class ReservaDeCitas
    Private Sub Reservacion_de_CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Reservacion_de_CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Reservacion_de_CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub ReservaDeCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Reservacion_de_Citas' Puede moverla o quitarla según sea necesario.
        Me.Reservacion_de_CitasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Reservacion_de_Citas)

        Me.Reservacion_de_CitasBindingSource.AddNew()
        TipodeServicio.Items.Add("Corte")
        TipodeServicio.Items.Add("Maquillaje")
        TipodeServicio.Items.Add("Cuidado Facial")
        TipodeServicio.Items.Add("Depilacion")
        TipodeServicio.Items.Add("Manicura")
        TipodeServicio.Items.Add("Pedicura")
        Estilitalista.Items.Add("Gabriela")
        Estilitalista.Items.Add("Ana")
        Estilitalista.Items.Add("Hector")
        Estilitalista.Items.Add("Lis")
        listahora.Items.Add("09:00 - 10:00")
        listahora.Items.Add("10:00 - 11:00")
        listahora.Items.Add("11:00 - 12:00")
        listahora.Items.Add("12:00 - 13:00")
        listahora.Items.Add("13:00 - 14:00")
        listahora.Items.Add("14:00 - 15:00")
        listahora.Items.Add("15:00 - 16:00")
        listahora.Items.Add("16:00 - 17:00")
        listahora.Items.Add("17:00 - 18:00")
        listahora.Items.Add("19:00 - 20:00")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Reservacion_de_CitasTableAdapter.Listas(NombreTextBox.Text, ApellidosTextBox.Text, TelefonoTextBox.Text, TipodeServicio.Text, FechaTextBox.Text, listahora.Text, Estilitalista.Text)
        Me.Reservacion_de_CitasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Reservacion_de_Citas)
        Me.Reservacion_de_CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)
        MsgBox("Registro Exitoso")

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MenuS.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FechaTextBox.Text = MonthCalendar1.SelectionStart.Day & "/" & MonthCalendar1.SelectionStart.Month & "/" & MonthCalendar1.SelectionStart.Year
    End Sub

    Private Sub TipodeServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipodeServicio.SelectedIndexChanged

    End Sub
End Class