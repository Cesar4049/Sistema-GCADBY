Public Class Reserva_de_Cursos

    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CursosBindingSource.EndEdit()
        MsgBox("Guardado Correctamente", MsgBoxStyle.Information, "Guardar")
        CursosTableAdapter.Update(BD_Sistema_GCADBYDataSet.Cursos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuS.Show()
    End Sub
End Class