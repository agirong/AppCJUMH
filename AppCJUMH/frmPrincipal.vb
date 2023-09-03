Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombreDeUsuario As String = UsuarioActual.usuarioLogin
        lbUsuarioActual.Text = nombreDeUsuario
        OcultarBotones()
        MostrarBotones()
    End Sub
    'YM. Hacer una funcion que oculte todos los botones 
    Private Sub OcultarBotones()
        btnFicha.Visible = False
        btnSeguimiento.Visible = False
        btnDelegacion.Visible = False
        btnAudiencias.Visible = False
        btnCasosPPS.Visible = False
        BotonUsuarios.Visible = False
        BotonRoles.Visible = False
    End Sub
    'YM. Hacer una funcion que muestre los botones en funcion de los permisos del rol que tiene asignado el usuario
    Private Sub MostrarBotones()
        Try
            OcultarBotones()

            Dim nombreDeUsuario As String = UsuarioActual.usuarioLogin

            Dim permisosUsuario As New DataTable()
            permisosUsuario = ConexionDB.GetDataTablePermisosUsuario(nombreDeUsuario)

            ' Recorre las filas del DataTable de permisosUsuario
            For Each row As DataRow In permisosUsuario.Rows
                ' Accede a los datos de cada fila por columna
                Dim vFichaAtencion As Boolean = row("fichaAtencion")
                Dim vSeguimientoPPS As Boolean = row("seguimientoPPS")
                Dim vdelegacionesProcuradores As Boolean = row("delegacionesProcuradores")
                Dim vaudienciasVigentes As Boolean = row("audienciasVigentes")
                Dim vcasosPPS As Boolean = row("casosPPS")
                Dim vroles As Boolean = row("roles")
                Dim vusuarios As Boolean = row("usuarios")

                btnFicha.Visible = vFichaAtencion
                btnSeguimiento.Visible = vSeguimientoPPS
                btnDelegacion.Visible = vdelegacionesProcuradores
                btnAudiencias.Visible = vaudienciasVigentes
                btnCasosPPS.Visible = vcasosPPS
                BotonUsuarios.Visible = vroles
                BotonRoles.Visible = vusuarios
            Next

        Catch ex As Exception

        End Try



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFicha.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form1 As New Form1()

        'YM. Mostrar el formulario
        form1.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form2 As New Form2()

        'YM. Mostrar el formulario
        form2.Show()

        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelegacion.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form3 As New Form3()

        'YM. Mostrar el formulario
        form3.Show()

        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAudiencias.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form4 As New Form4()

        'YM. Mostrar el formulario
        form4.Show()

        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCasosPPS.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form5 As New Form5()

        'YM. Mostrar el formulario
        form5.Show()

        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BotonUsuarios_Click(sender As Object, e As EventArgs) Handles BotonUsuarios.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmUsuario As New frmUsuario()

        'YM. Mostrar el formulario
        frmUsuario.Show()

        Me.Hide()
    End Sub

    Private Sub BotonRoles_Click(sender As Object, e As EventArgs) Handles BotonRoles.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmRoles As New frmRoles()

        'YM. Mostrar el formulario
        frmRoles.Show()

        Me.Hide()
    End Sub
End Class