Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRoles()
        PanelPermisos.Visible = False
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

    Private Sub limpiarCheckBox()
        PanelPermisos.Visible = False
        CBfichaAtencion.Checked = False
        CBseguimientoPPS.Checked = False
        CBdelegacionesProcuradores.Checked = False
        CBaudienciasVigentes.Checked = False
        CBcasosPPS.Checked = False
        CBroles.Checked = False
        CBusuarios.Checked = False
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrin As New frmPrincipal()

        'YM. Mostrar el formulario
        frmPrin.Show()

        Me.Hide()
    End Sub

    Private Sub ComboBoxRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoles.SelectedIndexChanged
        Try
            limpiarCheckBox()

            Dim idRol As Integer
            idRol = Convert.ToInt32(ComboBoxRoles.SelectedValue)

            Dim rolPermisos As New DataTable()
            rolPermisos = ConexionDB.GetDataTableRoles(idRol)
            PanelPermisos.Visible = True

            ' Recorre las filas del DataTable de rolPermisos
            For Each row As DataRow In rolPermisos.Rows
                ' Accede a los datos de cada fila por columna
                Dim vFichaAtencion As Boolean = row("fichaAtencion")
                Dim vSeguimientoPPS As Boolean = row("seguimientoPPS")
                Dim vdelegacionesProcuradores As Boolean = row("delegacionesProcuradores")
                Dim vaudienciasVigentes As Boolean = row("audienciasVigentes")
                Dim vcasosPPS As Boolean = row("casosPPS")
                Dim vroles As Boolean = row("roles")
                Dim vusuarios As Boolean = row("usuarios")

                CBfichaAtencion.Checked = vFichaAtencion
                CBseguimientoPPS.Checked = vSeguimientoPPS
                CBdelegacionesProcuradores.Checked = vdelegacionesProcuradores
                CBaudienciasVigentes.Checked = vaudienciasVigentes
                CBcasosPPS.Checked = vcasosPPS
                CBroles.Checked = vroles
                CBusuarios.Checked = vusuarios
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

    End Sub
End Class