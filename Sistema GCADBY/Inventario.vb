Imports System.Data.OleDb
Imports System.Data
Public Class Inventario
    Dim Cadena As New OleDbConnection
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Reservacion_de_Citas' Puede moverla o quitarla según sea necesario.
        Me.Reservacion_de_CitasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Reservacion_de_Citas)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.ReservaCursos' Puede moverla o quitarla según sea necesario.
        Me.ReservaCursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.ReservaCursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Cursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Servicios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuS.Show()
        Me.Hide()
    End Sub
End Class