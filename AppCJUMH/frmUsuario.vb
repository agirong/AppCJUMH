Imports System.Data.SqlClient

Public Class frmUsuario
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRoles()

        ' YM. Código para centar frmUsuario
        Dim medirPantalla As Size = Screen.PrimaryScreen.WorkingArea.Size
        Dim xPosicion As Integer = (medirPantalla.Width - Me.Width) / 2
        Dim yPosicion As Integer = (medirPantalla.Height - Me.Height) / 2
        ' Establecer la posición del formulario
        Me.Location = New Point(xPosicion, yPosicion)
    End Sub

    Private Sub cargarRoles()
        Try

            cbRol.DataSource = ConexionDB.GetDataTable("SELECT id,rolNombre FROM roles")
            cbRol.DisplayMember = "rolNombre"
            cbRol.ValueMember = "id"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub limpiarCampos()
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtDNI.Text = ""
        txtCorreo.Text = ""
        txtUser.Text = ""
        txtContrasena.Text = ""
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Usuarios.Click

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrin As New frmPrincipal()

        'YM. Mostrar el formulario
        frmPrin.Show()

        Me.Hide()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            If txtNombres.Text = "" Then
                MessageBox.Show("Ingrese el nombre")
            ElseIf txtApellidos.Text = "" Then
                MessageBox.Show("Ingrese el apellido")
            ElseIf txtDNI.Text = "" Then
                MessageBox.Show("Ingrese el DNI")
            ElseIf txtCorreo.Text = "" Then
                MessageBox.Show("Ingrese el correo")
            ElseIf txtUser.Text = "" Then
                MessageBox.Show("Ingrese el usuario")
            ElseIf txtContrasena.Text = "" Then
                MessageBox.Show("Ingrese la contraseña")
            Else

                Dim parametros As SqlParameter() = {
                    New SqlParameter("@nombres", txtNombres.Text),
                    New SqlParameter("@apellidos", txtApellidos.Text),
                    New SqlParameter("@dni", txtDNI.Text),
                    New SqlParameter("@correo_umh", txtCorreo.Text),
                    New SqlParameter("@user_umh", txtUser.Text),
                    New SqlParameter("@contrasena", txtContrasena.Text),
                    New SqlParameter("@id_rol", Integer.Parse(cbRol.SelectedValue))
                }
                Dim consulta As String = "INSERT INTO usuarios_umh (nombres, apellidos, dni, correo_umh, user_umh, contrasena, id_rol) VALUES (@nombres, @apellidos, @dni, @correo_umh, @user_umh, @contrasena, @id_rol);"
                ConexionDB.InsertData(consulta, parametros)

                limpiarCampos()
                MsgBox("Datos guardados correctamente")
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class