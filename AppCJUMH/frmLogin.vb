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

                'YM. Llamar a la funcin AutenticarUsuario que devuelve TRUE si las credenciales son correctas y FALSE si el usuario y contasena no existen
                Dim autenticado As Boolean = ConexionDB.AutenticarUsuario(txtUsuarioLogin.Text, txtContrasenaLogin.Text)

                If (autenticado = True) Then
                    'YM. El usuario ha sido autenticado correctamente, le mostramos un mensaje de exito y le mostramos el menu. 
                    ' Asignar el nombre de usuario a la propiedad estática
                    UsuarioActual.usuarioLogin = txtUsuarioLogin.Text
                    MessageBox.Show("Inicio de sesión exitoso")
                    Dim formularioPrincipal As New frmPrincipal()
                    formularioPrincipal.Show()
                    Me.Hide()
                Else
                    ' El usuario no ha sido autenticado correctamente, muestra un mensaje de error.
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class