Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRoles()

    End Sub

    'Ym. Hacer una funcion para llenar el combobox de roles
    Private Sub cargarRoles()
        Try
            ComboBoxRoles.DataSource = ConexionDB.GetDataTable("SELECT id,rolNombre FROM roles")
            ComboBoxRoles.DisplayMember = "rolNombre"
            ComboBoxRoles.ValueMember = "id"

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrin As New frmPrincipal()

        'YM. Mostrar el formulario
        frmPrin.Show()

        Me.Hide()
    End Sub

    Private Sub ComboBoxRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoles.SelectedIndexChanged

    End Sub
End Class