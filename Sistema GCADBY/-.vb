Public Class Reserva_de_Cursos

    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuS.Show()
    End Sub

End Class