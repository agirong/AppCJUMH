Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrin As New frmPrincipal()

        'YM. Mostrar el formulario
        frmPrin.Show()

        Me.Hide()
    End Sub
End Class