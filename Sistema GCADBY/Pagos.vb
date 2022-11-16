Public Class Pagos
    Private Sub CompraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CompraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub CompraBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CompraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Venta)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Compra' Puede moverla o quitarla según sea necesario.
        Me.CompraTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Compra)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ServiciosBindingSource.EndEdit()
        MsgBox("Guardado Correctamente", MsgBoxStyle.Information, "Guardar")
        ServiciosTableAdapter.Update(BD_Sistema_GCADBYDataSet.Servicios)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuS.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class