Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresarLogin_Click(sender As Object, e As EventArgs) Handles btnIngresarLogin.Click
        Try
            If txtUsuarioLogin.Text = "" Then
                MessageBox.Show("Ingrese el Usuario")
            ElseIf txtContrasenaLogin.Text = "" Then
                MessageBox.Show("Ingrese la Contrasena")
            Else


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class