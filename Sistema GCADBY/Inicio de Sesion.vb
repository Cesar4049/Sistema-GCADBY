Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CuentasTableAdapter.BuscarUsuarios(Me.BD_Sistema_GCADBYDataSet.Cuentas, UsuarioTextBox.Text, PasswordTextBox.Text) Then
            MenuS.Show()
            Me.Hide()
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub CuentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CuentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_GCADBYDataSet)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_GCADBYDataSet.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BD_Sistema_GCADBYDataSet.Cuentas)
        UsuarioTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

End Class
