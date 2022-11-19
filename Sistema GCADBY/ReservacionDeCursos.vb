Public Class ReservacionDeCursos
    Private Sub ReservaCursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReservaCursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReservaCursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub ReservacionDeCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.ReservaCursos' Puede moverla o quitarla según sea necesario.
        Me.ReservaCursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.ReservaCursos)

        Me.ReservaCursosBindingSource.AddNew()
        ComboBox1.Items.Add("Barberia")
        ComboBox1.Items.Add("Uñas Acrilicas")
        ComboBox1.Items.Add("Keratina")
        ComboBox1.Items.Add("Auto Maquillaje")
        ComboBox1.Items.Add("Trenzas Africanas")
        ComboBox2.Items.Add("09:00 - 10:00")
        ComboBox2.Items.Add("10:00 - 11:00")
        ComboBox2.Items.Add("11:00 - 12:00")
        ComboBox2.Items.Add("12:00 - 13:00")
        ComboBox2.Items.Add("13:00 - 14:00")
        ComboBox2.Items.Add("14:00 - 15:00")
        ComboBox2.Items.Add("15:00 - 16:00")
        ComboBox2.Items.Add("16:00 - 17:00")
        ComboBox2.Items.Add("17:00 - 18:00")
        ComboBox2.Items.Add("19:00 - 20:00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ReservaCursosTableAdapter.ListasCursos(ComboBox1.Text, CostoTextBox.Text, FechaTextBox.Text, ComboBox2.Text, NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text)
        Me.ReservaCursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.ReservaCursos)
        Me.ReservaCursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)
        MsgBox("Registro Exitoso")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ApellidoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ApellidoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ApellidoTextBox.TextChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MenuS.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FechaTextBox.Text = MonthCalendar1.SelectionStart.Day & "/" & MonthCalendar1.SelectionStart.Month & "/" & MonthCalendar1.SelectionStart.Year
    End Sub
End Class