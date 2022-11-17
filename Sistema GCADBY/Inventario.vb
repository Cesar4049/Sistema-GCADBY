Imports System.Data.OleDb
Imports System.Data
Public Class Inventario
    Dim Cadena As New OleDbConnection
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Cursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Servicios)

    End Sub

    Private Sub Mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim Consulta As String

        Consulta = "Select *From Servicios"
        oda = New OleDbDataAdapter(Consulta, Cadena)
        ods.Tables.Add("Servicios")
        oda.Fill(ods.Tables("Servicios"))
        DataGridView1.DataSource = ods.Tables("Servicios")

    End Sub
End Class