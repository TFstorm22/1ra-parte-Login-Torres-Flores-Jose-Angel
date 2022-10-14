Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo As String
        Dim contraseña As Integer

        correo = TextBox1.Text
        contraseña = TextBox2.Text

        If (correo = "qwert@hotmail.com") And (contraseña = "123") Then

            MsgBox("bienvenido")



        Else

            MsgBox("Usuario Incorrecto")






        End If






    End Sub
End Class
