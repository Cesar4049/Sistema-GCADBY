Public Class IInventari
    Private Sub IInventari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Inventario)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MenuS.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegistroInventario.Show()
        Me.Close()
    End Sub
End Class