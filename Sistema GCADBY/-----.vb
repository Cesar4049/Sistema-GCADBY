Imports System.Data.OleDb
Public Class ConsultaDeCitas

    Private Sub ConsultaDeCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Reservacion_de_Citas' Puede moverla o quitarla según sea necesario.
        Me.Reservacion_de_CitasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Reservacion_de_Citas)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class