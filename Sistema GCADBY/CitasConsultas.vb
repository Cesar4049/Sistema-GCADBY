Public Class CitasConsultas
    Private Sub CitasConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Reservacion_de_Citas' Puede moverla o quitarla según sea necesario.
        Me.Reservacion_de_CitasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Reservacion_de_Citas)

    End Sub
End Class