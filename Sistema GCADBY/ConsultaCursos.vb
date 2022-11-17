Public Class Consulta_de_cursos
    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub Consulta_de_cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.ReservaCursos' Puede moverla o quitarla según sea necesario.
        Me.ReservaCursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.ReservaCursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Cursos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuS.Show()
        Me.Close()
    End Sub
End Class