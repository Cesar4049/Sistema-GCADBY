Public Class Inventario
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Cursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Servicios)

    End Sub
End Class