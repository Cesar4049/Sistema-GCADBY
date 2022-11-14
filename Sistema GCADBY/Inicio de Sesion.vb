Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbusuario.Text = "Cesar" And tbcontraseña.Text = "1948769" Then
            MsgBox("Sesion Iniciada")
        Else
            MsgBox("Error")
        End If
    End Sub
End Class
