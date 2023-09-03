Public Class frmPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form1 As New Form1()

        'YM. Mostrar el formulario
        form1.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form2 As New Form2()

        'YM. Mostrar el formulario
        form2.Show()

        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form3 As New Form3()

        'YM. Mostrar el formulario
        form3.Show()

        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form4 As New Form4()

        'YM. Mostrar el formulario
        form4.Show()

        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim form5 As New Form5()

        'YM. Mostrar el formulario
        form5.Show()

        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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