Imports System.Data.OleDb
Public Class ConsultaDeCitas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cesar\Desktop\Sistema-GCADBY\Sistema GCADBY\BD Sistema GCADBY.accdb;Persist Security Info=True]")
        Dim comandoSQL As New OleDbCommand("SELECT * FROM ReservaCursos", conexion)
        Dim miDataReader As OleDbDataReader
        Dim miDataTable As New DataTable()

        conexion.Open()
        miDataReader = comandoSQL.ExecuteReader
        miDataTable.Load(miDataReader)

        Me.DataGridView1.DataSource = miDataTable
        conexion.Close()

    End Sub
End Class