Public Class RegistroInventario
    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub RegistroInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Inventario)
        Me.InventarioBindingSource.AddNew()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inventario.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class